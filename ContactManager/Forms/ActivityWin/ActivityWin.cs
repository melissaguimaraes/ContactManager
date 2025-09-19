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

namespace ContactManager.Forms.ActivityWin
{
    public partial class ActivityWin : Form
    {
        private Person CurrentContact;

        // get singleton instance of activityHandler
        private ActivityHandler activityHandler = ActivityHandler.GetActivityHandler();
        public ActivityWin(Person contact)
        {

            InitializeComponent();
            CurrentContact = contact;
            dataGridView1.DataSource = activityHandler.GetActivityComments(CurrentContact);

            // allows enter on keyboard
            this.AcceptButton = BtnSaveCmnt;
        }

        /*
         saves comment 

        @parameter: sender
        @parameter: e (event)
         */
        private void BtnSaveCmnt_Click(object sender, EventArgs e)
        {
            ActivityComment NewComment = new ActivityComment(TxtCmntField.Text.Trim(), AuthService.CurrentUser, DateTime.Now, CurrentContact.PersonalNumber);

            // checks if comment has been typed
            if (TxtCmntField.Text != null && TxtCmntField.Text != "")
            {


                activityHandler.SaveActivity(NewComment);

                dataGridView1.DataSource = activityHandler.GetActivityComments(CurrentContact);
                dataGridView1.Refresh();

                // resets comment field
                TxtCmntField.Text = "";
                TxtCmntField.Refresh();

            }
        }

    }
}
