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

            history.Add(historyEvent);

            // converts object back to json format
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string updatedHistory = JsonSerializer.Serialize(history, options);

            File.WriteAllText(history_path, updatedHistory);
        }

        /*
        reads json file and converts json into a list

        @return: history
         
        */ 
        public List<HistoryEvent> GetHistory() 
        {
            string json = File.ReadAllText(this.history_path);

            List<HistoryEvent> history = JsonSerializer.Deserialize<List<HistoryEvent>>(json);

            return history;
        }

    }
}
