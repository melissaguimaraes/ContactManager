using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactManager.Helper
{
    // Handles HistoryEvents which are being stored locally in a json file
    internal class HistoryHandler
    {
        // single instance
        private static HistoryHandler _historyHandler = new HistoryHandler();
        // path to history.json file
        private string history_path = "Data/history.json";

        private HistoryHandler() { 
        
            // private constructor to prevent public instantiating
        }

        /*
        HistoryHandler returns instantiated HistoryHandler-object

        @return: _historyHandler
         */
        public static HistoryHandler GetHistoryHandler()
        {
            return _historyHandler;
        }

        /*
        adds HistoryEvent to json file

        @parameter: HistoryEvent
        */ 
        public void AddToHistory(HistoryEvent historyEvent)
        {

            List< HistoryEvent> history = this.GetHistory();

            if(HasChanges(historyEvent.BeforeChange, historyEvent.AfterChange)) 
            {
                history.Add(historyEvent);

                // converts object back to json format
                //JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                //string updatedHistory = JsonSerializer.Serialize(history, options);

                //File.WriteAllText(history_path, updatedHistory);
                FileHandler.WriteObjectsToFile(history_path, history);
            }
        }

        /*
        Compares the old Obj and new Obj if Attributes have changed, returns true if yes

        @parameter: oldObj
        @parameter: newObj

        @return: bool (contact has changed)
        */
        private bool HasChanges(Person oldObj, Person newObj)
        {
            // oldObj == null means a new Contact has been created -> therefore log
            if(oldObj == null)
            {
                return true;
            }

            // get all properties from both runtime types -> can be trainee, customer or employee
            var oldType = oldObj.GetType();
            var newType = newObj.GetType();

            // gets all public properties as Hashset
            var oldProps = oldType.GetProperties().Select(p => p.Name).ToHashSet();
            var newProps = newType.GetProperties().Select(p => p.Name).ToHashSet();

            // combines all attributes in a set (without duplicates)
            var allPropNames = oldProps.Union(newProps);

            // Loop throuy each attribute and compores their values, if one attribute value is differnet, return true
            foreach (var propName in allPropNames)
            {
                var oldProp = oldType.GetProperty(propName);
                var newProp = newType.GetProperty(propName);

                var oldValue = oldProp?.GetValue(oldObj);
                var newValue = newProp?.GetValue(newObj);

                if (oldValue == null && newValue == null)
                    continue;

                if ((oldValue == null) != (newValue == null) || !Equals(oldValue, newValue))
                    return true; // a difference is found
            }

            return false; // no differences found
        }

        /*
        Gets all History objects as list

        @return: history
        */
        public List<HistoryEvent> GetHistory() 
        {
            // string json = File.ReadAllText(this.history_path);

            List<HistoryEvent> history = FileHandler.GetObjectsAsList<HistoryEvent>(history_path);

            return history;
        }

        /*
        Returns Events for a a specific contact

        @parameter: personalNumber

        @return: List<HistoryEvent>
        */
        public List<HistoryEvent> GetEventsForContact(Person person)
        {
            List<HistoryEvent> allEvents = HistoryHandler.GetHistoryHandler().GetHistory();

            // List comprehhension to filter for events of the specified user
            return allEvents
                .Where(e =>
                    (e.BeforeChange?.PersonalNumber == person.PersonalNumber) ||
                    (e.AfterChange?.PersonalNumber == person.PersonalNumber))
                .OrderByDescending(e => e.Timestamp)
                .ToList();
        }

        /*
         Deletes all history events for a specific contact and updates the JSON file

         @parameter: contact
        */
        public void DeleteHistory(Person contact)
        {
            // get all history events
            List<HistoryEvent> allHistory = GetHistory();

            // keep only events that do NOT belong to this contact
            List<HistoryEvent> updatedHistory = allHistory
                .Where(h => h.BeforeChange?.PersonalNumber != contact.PersonalNumber
                         && h.AfterChange?.PersonalNumber != contact.PersonalNumber)
                .ToList();

            FileHandler.WriteObjectsToFile(history_path, updatedHistory);
        }

    }
}
