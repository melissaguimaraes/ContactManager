using ContactManager.Helper;
using ContactManager.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.HistoryWin
{
    public partial class HistoryWin : Form
    {
        public HistoryWin(Person contact)
        {
            InitializeComponent();

            listViewHistory.View = View.Details;
            listViewHistory.Columns.Clear();
            listViewHistory.Columns.Add("Field", 0);
            listViewHistory.Columns.Add("Previouslsy", 0);
            listViewHistory.Columns.Add("Afterwards", 0);
            listViewHistory.GridLines = true;

            string personalNumber = contact.PersonalNumber;
            ShowHistory(personalNumber);
            AutoResizeColumns();
        }


        /*
        Displays change history of the current contact in a formated way
        */
        private void ShowHistory(string personalNumber)
        {
            // gets all event for a contact and clears listview
            var events = GetEventsForContact(personalNumber);
            listViewHistory.Items.Clear();

            foreach (var evt in events)
            {
                // generates header for for events (timestampt, changer/usernamer, actionname) and formats it bold
                var header = new ListViewItem($"[{evt.Timestamp}] {evt.ChangedBy} - {evt.ActionName}");
                header.Font = new Font(header.Font, FontStyle.Bold);
                listViewHistory.Items.Add(header);

                // returns list of changed attributes for user
                var changes = GetChanges(evt.BeforeChange, evt.AfterChange);

                foreach (var change in changes)
                {
                    // adds items to Listview
                    var item = new ListViewItem(change.Field);
                    item.SubItems.Add(change.OldValue);
                    item.SubItems.Add(change.NewValue);
                    listViewHistory.Items.Add(item);
                }

                // adds an empty line at the end of the change event
                listViewHistory.Items.Add(new ListViewItem(""));
            }
        }

        /*
        Returns Events for a a specific event

        @parameter: personalNumber

        @return: List<HistoryEvent>
        */
        public List<HistoryEvent> GetEventsForContact(string personalNumber)
        {
            var allEvents = HistoryHandler.GetHistoryHandler().GetHistory();

            // List comprehhension to filter for events of the specified user
            return allEvents
                .Where(e =>
                    (e.BeforeChange?.PersonalNumber == personalNumber) ||
                    (e.AfterChange?.PersonalNumber == personalNumber))
                .OrderByDescending(e => e.Timestamp)
                .ToList();
        }

        /*
        Returns changed attributes of previously and after changed contact attributes - List of tuples

        @parameter: before (Contact)
        @parameter: after (Contact)

        @return: changes (List of tuples)
        */
        public static List<(string Field, string OldValue, string NewValue)> GetChanges(Person before, Person after)
        {
            var changes = new List<(string, string, string)>();

            if (before == null || after == null) return changes;

            var props = typeof(Person).GetProperties();

            // generates tuples of changes attributes
            foreach (var prop in props)
            {
                var oldVal = prop.GetValue(before)?.ToString() ?? "";
                var newVal = prop.GetValue(after)?.ToString() ?? "";

                if (oldVal != newVal)
                {
                    changes.Add((prop.Name, oldVal, newVal));
                }
            }

            return changes;
        }


        /*
        Automatically resizes columsn of the listview
        */
        private void AutoResizeColumns()
        {
            foreach (ColumnHeader column in listViewHistory.Columns)
            {
                column.Width = -2;
            }
        }
    }
}
