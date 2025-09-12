using ContactManager.Helper;
using ContactManager.Models;
using System;
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
        public HistoryWin(Contact contact)
        {
            InitializeComponent();

            listViewHistory.View = View.Details;
            listViewHistory.Columns.Clear();
            listViewHistory.Columns.Add("Field", 0);
            listViewHistory.Columns.Add("Previouslsy", 0);
            listViewHistory.Columns.Add("Afterwards", 0);
            listViewHistory.GridLines = true;

            string employeeNumber = contact.EmployeeNumber;
            ShowHistory(employeeNumber);
            AutoResizeColumns();
        }


        private void ShowHistory(string employeeNumber)
        {
            var events = GetEventsForContact(employeeNumber);
            listViewHistory.Items.Clear();

            foreach (var evt in events)
            {
                var header = new ListViewItem($"[{evt.Timestamp}] {evt.ChangedBy} - {evt.ActionName}");
                header.Font = new Font(header.Font, FontStyle.Bold);
                listViewHistory.Items.Add(header);

                var changes = GetChanges(evt.BeforeChange, evt.AfterChange);

                foreach (var change in changes)
                {
                    var item = new ListViewItem(change.Field);
                    item.SubItems.Add(change.OldValue);
                    item.SubItems.Add(change.NewValue);
                    listViewHistory.Items.Add(item);
                }

                listViewHistory.Items.Add(new ListViewItem(""));
            }
        }

        public List<HistoryEvent> GetEventsForContact(string employeeNumber)
        {
            var allEvents = HistoryHandler.GetHistoryHandler().GetHistory();

            return allEvents
                .Where(e =>
                    (e.BeforeChange?.EmployeeNumber == employeeNumber) ||
                    (e.AfterChange?.EmployeeNumber == employeeNumber))
                .OrderByDescending(e => e.Timestamp)
                .ToList();
        }


        public static List<(string Field, string OldValue, string NewValue)> GetChanges(Contact before, Contact after)
        {
            var changes = new List<(string, string, string)>();

            if (before == null || after == null) return changes;

            var props = typeof(Contact).GetProperties();

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


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AutoResizeColumns()
        {
            foreach (ColumnHeader column in listViewHistory.Columns)
            {
                column.Width = -2;
            }
        }
    }
}
