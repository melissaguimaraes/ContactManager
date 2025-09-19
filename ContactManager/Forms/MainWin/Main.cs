using System.Data;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


using ContactManager.Models;  // maybe need to change once I want to use the properties of obj
using System.Text.Json;
using System.CodeDom.Compiler;
using System;
using System.IO;
using ContactManager.Helper;




namespace ContactManager.MainWin
{
    public partial class Main : Form
    {
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

        // button reads input from searchtextbox compares to text file and returns findings inside ContactList group box
        private void ShowContactButton_Click(object sender, EventArgs e)
        {
            // Trim() is used to ignore any white spaces that user might add
            string searchInput = SearcByTxtBox.Text.Trim();
                        

            // parses the objcts into list so that it can be rendered in the grid
            List<Person> contacts = LoadCurrentContact();

            // if no entry on text box: show all entries of text file
            if (string.IsNullOrEmpty(searchInput))
            {

                // it reads the json and creates the columns  
                gridViewContactList.AutoGenerateColumns = true;
                gridViewContactList.DataSource = null;
                gridViewContactList.DataSource = contacts;
                return;

            }
            else

            // here we check if any given entry matches 
            {
                var contactListToCompare = new List<Person>();

                foreach (var c in contacts)
                {
                    bool match = false;

                    // loops over properties in contact class
                    foreach (var p in c.GetType().GetProperties())
                    {
                        // if val == null then it becames empty string and it is able to compare 
                        var val = p.GetValue(c)?.ToString() ?? "";

                        // only here it compares 
                        if (val.IndexOf(searchInput, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            match = true;
                            break;
                        }
                        continue;
                    }

                    if (match)
                    {
                        contactListToCompare.Add(c);
                    }

                }
                gridViewContactList.AutoGenerateColumns = true;
                gridViewContactList.DataSource = null;
                gridViewContactList.DataSource = contactListToCompare;

            }

        }

       
        // once again depending on kind of customer different file is loaded
        private List<Person> LoadCurrentContact()
        {
            var path = RadioButtonHandler.CurrentDataPath();

            if (!File.Exists(path)) return new List<Person>();

            var json = File.ReadAllText(path);

            if(RadioButtonHandler.IsCustomerChecked)
            {
                var clients = JsonSerializer.Deserialize<List<Customer>>(json) ?? new List<Customer>();
                return clients.Cast<Person>().ToList();
            }
            else
            {
                var employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
                return employees.Cast<Person>().ToList();
            }
        }

        // gets contact form and displays the selected contact
        private void gridViewContactList_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewContactList.CurrentRow?.DataBoundItem is not Person selectedRow)
                return; 


            using (var dlg = new ContactManager.NewContactWin.NewContactWin(selectedRow))
            {
                dlg.ShowDialog(this);
            }

            ShowContactButton_Click(this, EventArgs.Empty);

        }

        /*
        Opens add new contact modal

        @parameter: sender
        @parameter: e (event)
        */
        // it is adding to correct json based on type of contact
        private void BtnAddNewContact_Click(object sender, EventArgs e)
        {

            var kind = RadioButtonHandler.IsCustomerChecked ? ContactKind.Customer : ContactKind.Employee;

            using (var dlg = new NewContactWin.NewContactWin(kind)) 
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string path = RadioButtonHandler.CurrentDataPath();

                    var json = File.Exists(path) ? File.ReadAllText(path) : "[]";

                }
            }
                
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
    }
}
