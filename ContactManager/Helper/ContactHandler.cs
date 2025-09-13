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
        private static string contact_path = "Data/contacts.json";

        private ContactHandler() { }

        public static ContactHandler GetContactHandler()
        {
            return _contactHandler;
        }

        /*
        Gets current content of contacts.json file and returns it as List.

        @return: Lists<Contact>
        */
        public List<Contact> LoadContacts()
        {
            if (!File.Exists(contact_path))
                return new List<Contact>();

            string json = File.ReadAllText(contact_path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, Converters = { new DateOnlyJsonConverter() } };

            return JsonSerializer.Deserialize<List<Contact>>(json, options) ?? new List<Contact>();
        }

        /*
        Saves List of contacts as new json content

        @parameter: contacts

        @return: 
        */
        public void SaveContacts(List<Contact> contacts)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new DateOnlyJsonConverter() }
            };

            string json = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(contact_path, json);
        }

        /*
        Add new contact

        @parameter: newContact
        @return: void
        */
        public void AddContact(Contact newContact)
        {
            var contacts = LoadContacts();

            // Get highest employe number
            int maxNumber = contacts
                .Select(c => int.TryParse(c.EmployeeNumber, out int num) ? num : 0)
                .DefaultIfEmpty(0)
                .Max();

            // leading digits with zeros
            newContact.EmployeeNumber = (maxNumber + 1).ToString("D4");

            contacts.Add(newContact);
            SaveContacts(contacts);
        }

        /*
        Update existing contact

        @parameter: updatedContact
        @return: void
        */
        public void UpdateContact(Contact updatedContact)
        {
            var contacts = LoadContacts();
            var index = contacts.FindIndex(c => c.EmployeeNumber == updatedContact.EmployeeNumber);

            if (index == -1)
                throw new InvalidOperationException("Contact not found for update.");

            contacts[index] = updatedContact;
            SaveContacts(contacts);
        }

        /*
        Delete contact

        @parameter: deleteContact
        @return: void
        */
        public void DeleteContact(Contact deleteContact)
        {
            List<Contact> contacts = LoadContacts();

            for (int i = 0; i < contacts.Count; i++)
            {

                if (deleteContact.EmployeeNumber == contacts[i].EmployeeNumber)
                {
                    contacts.RemoveAt(i);
                }
            }

            SaveContacts(contacts);

        }
    }
}


// custom Json Serializer to convert dates into datetime format
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
