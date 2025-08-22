using System.Data;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ContactManager.MainWin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // button reads input from searchtextbox compares to text file and returns findings inside ContactList group box
        private void ShowContactButton_Click(object sender, EventArgs e)
        {
            // Trim() is used to ignore any white spaces that user might add
            string searchInput = SearcByTxtBox.Text.Trim();

            var showAll = File.ReadAllText("Data/contacts.json");

            // if no entry on text box: show all entries of text file
            if (string.IsNullOrEmpty(searchInput) ) { 



            }

            

            
            

        }
    }
}
