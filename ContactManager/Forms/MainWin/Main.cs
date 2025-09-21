using ContactManager.Forms;
using ContactManager.Helper;
using ContactManager.Models;  // maybe need to change once I want to use the properties of obj
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;




namespace ContactManager.MainWin
{
    // mainform/landing page to view and search for alle contacts
    public partial class Main : Form
    {
        private ContactHandler contactHandler = ContactHandler.GetContactHandler();
        public Main()
        {
            InitializeComponent();
            ShowContactButton_Click(this, EventArgs.Empty);

            // allows enter on keyboard
            this.AcceptButton = ShowContactButton;

            gridViewContactList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewContactList.ReadOnly = true;
            gridViewContactList.CellDoubleClick += gridViewContactList_DoubleClick;
        }

        /*
        Generich method to search for contacts troug all attributes and return them as list

        @parameter: contacts
        @parameter: seachinput

        @return: List<Person>
        */
        private List<Person> SearchContacts(List<Person> contacts, string searchInput)
        {
            searchInput = searchInput?.Trim() ?? "";

            return contacts
                .Where(c => MatchesCheckboxFilter(c))
                .Where(c => string.IsNullOrEmpty(searchInput) ||
                            c.GetType().GetProperties()
                             .Any(p => (p.GetValue(c)?.ToString() ?? "")
                             .IndexOf(searchInput, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();
        }

        /*
        Updates the datagrid with the passed list of contacts and doesnt reset the whole grid

        @parameter: contacts
        */
        private void UpdateDataGrid(List<Person> contacts)
        {
            // Check if the GridView does not already have a BindingList<Person> as its data source
            if (gridViewContactList.DataSource is not BindingList<Person> bindingList)
            {
                bindingList = new BindingList<Person>(contacts);
                gridViewContactList.DataSource = bindingList;
            }
            else
            {
                // If a BindingList already exists, clear its current items
                bindingList.Clear();
                foreach (var contact in contacts)
                    bindingList.Add(contact);
            }
        }

        /*
        Helper method to check if a user matches current checkbox filters

        @parmeter: contact

        @return: bool (true = contact matches checkbox filter/is from type)
        */
        private bool MatchesCheckboxFilter(Person contact)
        {
            if (contact == null) return false;

            bool isEmployee = contact is Employee && !(contact is Trainee);
            bool isTrainee = contact is Trainee;
            bool isCustomer = contact is Customer;

            // Return true if the contact matches any of the checked checkboxes
            return (ChkEmployeeFilter.Checked && isEmployee) ||
                   (ChkTraineeFilter.Checked && isTrainee) ||
                   (ChkCustomerFilter.Checked && isCustomer);
        }


        // TODO: To be deleted - deprecated
        //// once again depending on kind of customer different file is loaded
        //private List<Person> LoadCurrentContact()
        //{

        //    var path = RadioButtonHandler.CurrentDataPath();

        //    if (!File.Exists(path)) return new List<Person>();

        //    var json = File.ReadAllText(path);

        //    if(RadioButtonHandler.IsCustomerChecked)
        //    {
        //        var clients = JsonSerializer.Deserialize<List<Customer>>(json) ?? new List<Customer>();
        //        return clients.Cast<Person>().ToList();
        //    }
        //    else
        //    {
        //        var employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        //        return employees.Cast<Person>().ToList();
        //    }
        //}

        // UI ACTIONS //

        /*
        button reads input from searchtextbox compares to text file and returns findings inside ContactList group box
        
        @parameter: sender
        @parameter: e (event)
        */
        private void ShowContactButton_Click(object sender, EventArgs e)
        {
            List<Person> contacts = contactHandler.LoadContacts();

            List<Person> filteredContacts = SearchContacts(contacts, SearcByTxtBox.Text);

            UpdateDataGrid(filteredContacts);

            // TODO: To be deleted - deprecated
            //// Trim() is used to ignore any white spaces that user might add
            //string searchInput = SearcByTxtBox.Text.Trim();


            //// parses the objcts into list so that it can be rendered in the grid
            //List<Person> contacts = contactHandler.LoadContacts();

            //// if no entry on text box: show all entries of text file
            //if (string.IsNullOrEmpty(searchInput))
            //{

            //    // it reads the json and creates the columns  
            //    gridViewContactList.AutoGenerateColumns = true;
            //    gridViewContactList.DataSource = null;
            //    gridViewContactList.DataSource = contacts;
            //    return;

            //}
            //else

            // TODO: To be deleted - deprecated
            //// here we check if any given entry matches 
            //{
            //    var contactListToCompare = new List<Person>();

            //    foreach (var c in contacts)
            //    {
            //        bool match = false;

            //        // loops over properties in contact class
            //        foreach (var p in c.GetType().GetProperties())
            //        {
            //            // if val == null then it becames empty string and it is able to compare 
            //            var val = p.GetValue(c)?.ToString() ?? "";

            //            // only here it compares 
            //            if (val.IndexOf(searchInput, StringComparison.OrdinalIgnoreCase) >= 0)
            //            {
            //                match = true;
            //                break;
            //            }
            //            continue;
            //        }

            //        if (match)
            //        {
            //            contactListToCompare.Add(c);
            //        }

            //    }
            //    gridViewContactList.AutoGenerateColumns = true;
            //    gridViewContactList.DataSource = null;
            //    gridViewContactList.DataSource = contactListToCompare;

        }

        /*
        gets contact form and displays the selected contact

        @parameter: sender
        @parameter: e (DataGridCellEventArgs)
        */
        private void gridViewContactList_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Person selectedContact = gridViewContactList.Rows[e.RowIndex].DataBoundItem as Person;

                ContactWin win = new ContactWin(selectedContact);

                win.ShowDialog();
            }

            //using (var dlg = new ContactManager.NewContactWin.NewContactWin(selectedRow))
            //{
            //    dlg.ShowDialog(this);
            //}

            ShowContactButton_Click(this, EventArgs.Empty);

        }

        /*
        Opens add new contact modal

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnAddNewContact_Click(object sender, EventArgs e)
        {
            // TODO: To be deleted - deprecated
            // var kind = RadioButtonHandler.IsCustomerChecked ? ContactType.Customer : ContactType.Employee;

            ContactWin win = new ContactWin();
            win.ShowDialog();

            // TODO: To be deleted - deprecated
            //using (var dlg = new NewContactWin.NewContactWin(kind)) 
            //{
            //    if (dlg.ShowDialog(this) == DialogResult.OK)
            //    {
            //        string path = RadioButtonHandler.CurrentDataPath();

            //        var json = File.Exists(path) ? File.ReadAllText(path) : "[]";

            //    }
            //}

            ShowContactButton_Click(this, EventArgs.Empty);

        }

        /*
        Logs current user out

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            AuthService.Logout(this);
        }

        /*
        Updates grid immediatly after filter chackbox has been pressed

        @parameter: sender
        @parameter: e (event)
        */
        private void Filters_CheckedChanged(object sender, EventArgs e)
        {
            ShowContactButton_Click(sender, EventArgs.Empty);
        }

        /*
        Clears current set filters and search input

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            SearcByTxtBox.Text = string.Empty;
            ChkCustomerFilter.Checked = true;
            ChkEmployeeFilter.Checked = true;
            ChkTraineeFilter.Checked = true;

            ShowContactButton_Click(sender, EventArgs.Empty);
        }
    }
}
