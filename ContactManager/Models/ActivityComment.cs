using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    // class to track activities created by admins
    public class ActivityComment
    {
        public string Comment { get; set; }
        public string Commentor { get; set; }
        public DateTime Timestamp { get; set; }
        public string ContactID { get; set; }

        /*
        construcor for ActivityComment
        */
        public ActivityComment(string comment, string commentor, DateTime timestamp, string contactID) 
        {
            Comment = comment;
            Commentor = commentor;
            Timestamp = timestamp;
            ContactID = contactID;

        }

    }
}
