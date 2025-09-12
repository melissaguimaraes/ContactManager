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

        public List<Contact> LoadContacts()
        {
            if (!File.Exists(contact_path))
                return new List<Contact>();

            string json = File.ReadAllText(contact_path);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new DateOnlyJsonConverter() }
            };

            return JsonSerializer.Deserialize<List<Contact>>(json, options) ?? new List<Contact>();
        }

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

        public void UpdateContact(Contact updatedContact)
        {
            var contacts = LoadContacts();
            var index = contacts.FindIndex(c => c.EmployeeNumber == updatedContact.EmployeeNumber);

            if (index == -1)
                throw new InvalidOperationException("Contact not found for update.");

            contacts[index] = updatedContact;
            SaveContacts(contacts);
        }

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

           
            


public class DateOnlyJsonConverter : JsonConverter<DateOnly?>
{
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String &&
            DateOnly.TryParse(reader.GetString(), out var date))
        {
            return date;
        }
        return null;
    }

    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
            writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd"));
        else
            writer.WriteNullValue();
    }

}
