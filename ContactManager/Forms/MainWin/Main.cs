using System.Data;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


using ContactManager.Models;  // maybe need to change once I want to use the properties of obj
using System.Text.Json;
using System.CodeDom.Compiler;

namespace ContactManager.MainWin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            ShowContactButton_Click(null, null);

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

            string jsonFile = File.ReadAllText("Data/contacts.json");

            // parses the objcts into list so that it can be rendered in the grid
            List<Contact> contacts = JsonSerializer.Deserialize<List<Contact>>(jsonFile);

            // if no entry on text box: show all entries of text file
            if (string.IsNullOrEmpty(searchInput))
            {

                // it reads the json and creates the columns  
                gridViewContactList.AutoGenerateColumns = true;
                gridViewContactList.DataSource = contacts;

            }
            else

            // here we check if any given entry matches 
            {
                var contactListToCompare = new List<Contact>();

                foreach (var c in contacts)
                {
                    bool match = false;

                    // loops over properties in contact class
                    foreach (var p in typeof(Contact).GetProperties())
                    {
                        // if val == null then it becames empty string and it is able to compare 
                        var val = p.GetValue(c)?.ToString() ?? "";

                        // only here it compares 
                        if (val.Contains(searchInput, StringComparison.OrdinalIgnoreCase))
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
                gridViewContactList.DataSource = contactListToCompare;

            }

        }

        // gets contact form and displays the selected contact
        private void gridViewContactList_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewContactList.CurrentRow == null) return;

            var selectedRow = gridViewContactList.CurrentRow.DataBoundItem as Contact;

            if (selectedRow == null) return;

            
            using (var dlg = new ContactManager.NewContactWin.NewContactWin(selectedRow))
            {
                dlg.ShowDialog(this);
            }

            ShowContactButton_Click(this, EventArgs.Empty);

        }

        private void BtnAddNewContact_Click(object sender, EventArgs e)
        {
            new NewContactWin.NewContactWin().ShowDialog();

            ShowContactButton_Click(this, EventArgs.Empty);

        }

        private void gridViewContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
