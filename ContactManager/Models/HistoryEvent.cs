using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class HistoryEvent
    {
        public string ChangedBy { get; set; }
        public string ActionName { get; set; }
        public DateTime Timestamp { get; set; } 
        public Contact BeforeChange { get; set; }      
        public Contact AfterChange { get; set; }

        public HistoryEvent() { }

        // overloading constructor
        public HistoryEvent(string changedBy, string actionName, DateTime timestamp, Contact beforeChange, Contact afterChange)
        {
            ChangedBy = changedBy;
            ActionName = actionName;
            Timestamp = timestamp;
            BeforeChange = beforeChange;
            AfterChange = afterChange;
        }
    }
}
