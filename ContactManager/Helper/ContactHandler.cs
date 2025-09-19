using ContactManager.HelperRB;
using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContactManager.Helper
{
    internal class ContactHandler
    {
        private static ContactHandler _contactHandler = new ContactHandler();
        // local path to contacts.json
        private static string GetCurrentPath() => RadioButtonHandler.CurrentDataPath();

        private ContactHandler() { }

        /*
        retunrns singelton instance of ContactHandler Object

        @return: _contactHandler
        */
        public static ContactHandler GetContactHandler()
        {
            return _contactHandler;
        }

        /*
        Gets current content of contacts.json file and returns it as List.

        @return: Lists<Contact>
        */
        public List<Person> LoadContacts()
        {
            var path = GetCurrentPath();
            if (!File.Exists(path))
                return new List<Person>();

            string json = File.ReadAllText(path);
            
            // json serialize options for converting DateTime in specific date format (yyyy-MM-dd)
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, Converters = { new DateOnlyJsonConverter() } };

            return JsonSerializer.Deserialize<List<Person>>(json, options) ?? new List<Person>();
        }

        /*
        Saves List of contacts as new json content and saves it to file

        @parameter: contacts
        */
        public void SaveContacts(List<Person> contacts)
        {
            // options for JSON Identation
            var path = GetCurrentPath();
            var options = new JsonSerializerOptions{ WriteIndented = true,Converters = { new DateOnlyJsonConverter() }};

            string json = JsonSerializer.Serialize(contacts, options);

            File.WriteAllText(path, json);
        }
        
        /*
        Adds new contact

        @parameter: newContact
        @return: void
        */
        public void AddContact(Person newContact)
        {
            var contacts = LoadContacts();

            // gets last element of ordered json file and gets current max id/number
            int maxNumber = 0; //int.Parse(contacts[contacts.Count - 1].PersonalNumber);

            // Creates new contact with (current max number) + 1 
            // leading digits with zeros
            //newContact.PersonalNumber = (maxNumber + 1).ToString("D4");

            // add new contact to current list
            //contacts.Add(newContact);

            //SaveContacts(contacts);
            foreach (var p in contacts)
            {
                var id = p.PersonalNumber ?? "";
                var digits = new string(id.Where(char.IsDigit).ToArray());
                if (int.TryParse(digits, out int n) && n > maxNumber)
                    maxNumber = n;
            }

            var path = GetCurrentPath();
            string prefix = path.IndexOf("client", StringComparison.OrdinalIgnoreCase) >= 0 ? "C-" : "E-";

            newContact.PersonalNumber = prefix + (maxNumber + 1).ToString("D4");

            contacts.Add(newContact);
            SaveContacts(contacts);

        }

        /*
        Update existing contact

        @parameter: updatedContact
        @return: void
        */
        public void UpdateContact(Person updatedContact)
        {

            var contacts = LoadContacts();

            // gets position of the contact which will be updated
            var index = contacts.FindIndex(c => c.PersonalNumber == updatedContact.PersonalNumber);

            // throws exception if employe is not in list
            if (index == -1)
                throw new InvalidOperationException("Contact not found for update.");

            // updates contact
            contacts[index] = updatedContact;

            SaveContacts(contacts);
        }

        /*
        Delete contact

        @parameter: deletesContact
        @return: void
        */
        public void DeleteContact(Person deleteContact)
        {
            List<Person> contacts = LoadContacts();

            // search algo to find contact in imported list
            for (int i = 0; i < contacts.Count; i++)
            {
                // removes contact at the found postion
                if (deleteContact.PersonalNumber == contacts[i].PersonalNumber)
                {
                    contacts.RemoveAt(i);
                }
            }

            SaveContacts(contacts);

        }
    }
}


// custom Json Serializer to convert dates into datetime format  (yyyy-MM-dd)
public class DateOnlyJsonConverter : JsonConverter<DateOnly?>
{
    /*
        Reads a nullable DateOnly value from JSON.

        @parameter: reader
        @parameter: typeToConvert
        @parameter: options
    
        @return: DateOnly? - parsed date if valid, otherwise null
    */
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String &&
            DateOnly.TryParse(reader.GetString(), out var date))
        {
            return date;
        }
        return null;
    }

    /*
        Writes a nullable DateOnly value to JSON.

        @parameter: writer
        @parameter: value
        @parameter: options
    
        @return: void
    */
    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
            writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd"));
        else
            writer.WriteNullValue();
    }

}
