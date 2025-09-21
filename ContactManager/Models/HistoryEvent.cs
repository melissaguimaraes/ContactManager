using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    // Class to track changed objects
    public class HistoryEvent
    {
        public string ChangedBy { get; set; }
        public string ActionName { get; set; }
        public DateTime Timestamp { get; set; } 
        public Person BeforeChange { get; set; }      
        public Person AfterChange { get; set; }

        public HistoryEvent() { }

        // overloading constructor
        public HistoryEvent(string changedBy, string actionName, DateTime timestamp, Person beforeChange, Person afterChange)
        {
            ChangedBy = changedBy;
            ActionName = actionName;
            Timestamp = timestamp;
            BeforeChange = beforeChange;
            AfterChange = afterChange;
        }
    }
}
