using ContactManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ContactManager.Helper
{
    // singleton class to handle contact related methods and data which is being stored locally
    internal class ContactHandler
    {
        private static readonly ContactHandler _contactHandler = new ContactHandler();
        HistoryHandler historyHandler = HistoryHandler.GetHistoryHandler();
        ActivityHandler activityHandler = ActivityHandler.GetActivityHandler();
        // local path to contacts.json
        private static string contacts_path = "Data/contacts.json";

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
            return FileHandler.GetObjectsAsList<Person>(contacts_path);
        }

        public Employee GetAdminByUsername(string username)
        {
            List<Employee> contacts = FileHandler.GetObjectsAsList<Person>(contacts_path).OfType<Employee>().ToList();

            return contacts.FirstOrDefault(c => c.Username.Equals(username) && c.Status && c.IsAdmin);
        }


        // TODO: To be deleted - deprecated
        ///*
        //Saves List of contacts as new json content and saves it to file

        //@parameter: contacts
        //*/
        //public void SaveContacts(List<Person> contacts)
        //{
        //    var path = contacts_path;

        //    // serialize with type information
        //    var settings = new JsonSerializerSettings
        //    {
        //        TypeNameHandling = TypeNameHandling.Auto,
        //        Formatting = Formatting.Indented
        //    };

        //    string json = JsonConvert.SerializeObject(contacts, settings);
        //    File.WriteAllText(path, json);
        //}

        /*
        Adds new contact

        @parameter: newContact
        */
        public void AddContact(Person newContact)
        {

            List<Person> contacts = FileHandler.GetObjectsAsList<Person>(contacts_path);

            // based on contact type sets prefix for ID
            string prefix = newContact switch
            {
                Employee _ => "E-",
                Customer _ => "C-",
                _ => "E-"
            };

            // returns current max id for either customer or employee
            int maxNumber = contacts
                .Select(c => c.PersonalNumber)
                .Where(id => !string.IsNullOrEmpty(id) && id.StartsWith(prefix))
                .Select(id => new string(id.Where(char.IsDigit).ToArray()))
                .Where(digits => int.TryParse(digits, out _))
                .Select(int.Parse)
                .DefaultIfEmpty(0)
                .Max();

            var path = contacts_path;

            // passes generated contact id
            newContact.PersonalNumber = prefix + (maxNumber + 1).ToString("D4");

            FileHandler.AddObjectToFile<Person>(contacts_path, newContact);

        }

        /*
        Update existing contact

        @parameter: updatedContact
        */
        public void UpdateContact(Person updatedContact)
        {

            List<Person> contacts = LoadContacts();

            var index = contacts.FindIndex(c => c.PersonalNumber == updatedContact.PersonalNumber);

            if (index == -1)
                throw new InvalidOperationException("Contact not found for update.");

            contacts[index] = updatedContact;
            
            FileHandler.WriteObjectsToFile(contacts_path, contacts);
        }

        /*
        Deletes contact and all related contetn (activities, history)

        @parameter: deletesContact
        */
        public void DeleteContact(Person deleteContact)
        {
            List<Person> contacts = LoadContacts();
            contacts.RemoveAll(c => c.PersonalNumber == deleteContact.PersonalNumber);

            // deletes History and Activities for contact
            historyHandler.DeleteHistory(deleteContact);
            activityHandler.DeleteActivityComments(deleteContact);

            FileHandler.WriteObjectsToFile(contacts_path, contacts);
        }
    }
}