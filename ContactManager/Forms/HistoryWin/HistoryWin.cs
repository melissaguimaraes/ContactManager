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
    // Form te view history of changed attributes of object
    public partial class HistoryWin : Form
    {
        private HistoryHandler historyHandler = HistoryHandler.GetHistoryHandler();
        public HistoryWin(Person contact)
        {
            InitializeComponent();

            // set columns of listview and other settings
            listViewHistory.View = View.Details;
            listViewHistory.Columns.Clear();
            listViewHistory.Columns.Add("Field", 0);
            listViewHistory.Columns.Add("Previouslsy", 0);
            listViewHistory.Columns.Add("Afterwards", 0);
            listViewHistory.GridLines = true;

            ShowHistory(contact);

            AutoResizeColumns();
        }

        /*
        Displays change history of the current contact in a formated way

        @parameter: person
        */
        private void ShowHistory(Person person)
        {
            // gets all event for a contact and clears listview
            List<HistoryEvent> events = historyHandler.GetEventsForContact(person);
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
        Returns changed attributes of previously and after changed contact attributes - List of tuples

        @parameter: before (Contact)
        @parameter: after (Contact)

        @return: changes (List of tuples)
        */
        public static List<(string Field, string OldValue, string NewValue)> GetChanges(Person before, Person after)
        {
            var changes = new List<(string, string, string)>();
            if (before == null || after == null) return changes; // failsave

            // Detect type change e. g Trainee has been changed to employee
            if (before.GetType() != after.GetType())
            {
                changes.Add(("Type", before.GetType().Name, after.GetType().Name));
            }

            // get properties of before object
            var beforeProps = before.GetType().GetProperties();
            var afterProps = after.GetType().GetProperties();

            // only compare properties that exist in both objects
            var commonProps = beforeProps
                .Where(bp => afterProps.Any(ap => ap.Name == bp.Name))
                .ToList();

            // gets changed attributes and prepares it for the output
            foreach (var prop in commonProps)
            {
                var oldVal = prop.GetValue(before)?.ToString() ?? "";
                var newVal = after.GetType().GetProperty(prop.Name)?.GetValue(after)?.ToString() ?? "";

                if (oldVal != newVal)
                {
                    // add the changes list
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
