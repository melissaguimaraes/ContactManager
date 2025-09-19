using ContactManager.Forms.ActivityWin;
using ContactManager.Helper;
using ContactManager.HelperRB;
using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ContactManager.NewContactWin
{
    public partial class NewContactWin : Form
    {

        private FormState formState;
        private Person current_contact;
        private HistoryHandler historyHandler = HistoryHandler.GetHistoryHandler();
        private ContactHandler contactHandler = ContactHandler.GetContactHandler();
        //should grab RadioButtonHandler
        //private readonly RadioButtonHandler _radioButtonHandler;
        private readonly ContactKind _kind;

        // ctor 1
        public NewContactWin()
        {
            InitializeComponent();
        }

        // ctor 2
        public NewContactWin(ContactKind kind) : this()
        {
            
            _kind = kind;
            this.Text = "Add New Contact";
            SetFormState(FormState.AddNew);

            // sets button state for add new mode
            BtnViewHistory.Hide();
            BtnDeleteContact.Hide();
            BtnSaveContact.Show();
            BtnCancelContact.Show();
            BtnActivities.Hide();


            ShowGroupsForKind(_kind);
            RbCustomer.CheckedChanged += RadioButtonHandler.OnRBCheckedChanged;
            RbEmployee.CheckedChanged += RadioButtonHandler.OnRBCheckedChanged;

            RbEmployee.Checked = true;
        }

        // here depending on radioButton selected the groups will be visible or not
        private void ShowGroupsForKind(ContactKind kind)
        {
            employeeGroup.Visible = (kind == ContactKind.Employee || kind == ContactKind.Trainee);
            traineeGroup.Visible = (kind == ContactKind.Trainee);
            customerGroup.Visible = (kind == ContactKind.Customer);
        }
        /*
         View mode constructor

        @paramenter: contToDisplay
            
        */
        //ctor 3
        public NewContactWin(Person contToDisplay)
        {
            InitializeComponent();

            current_contact = contToDisplay ?? throw new ArgumentNullException(nameof(contToDisplay));
            LoadContact(current_contact);

            _kind = current_contact is Trainee ? ContactKind.Trainee 
                   : current_contact is Employee ? ContactKind.Employee
                   : ContactKind.Customer;

            ShowGroupsForKind(_kind);

            // set button and form state
            SetFormState(FormState.View);
            BtnCancelContact.Hide();
            BtnSaveContact.Hide();
            BtnDeleteContact.Show();
            BtnActivities.Show();
        }

        /*
         cancel button with warning message, cancels edit and new contact form

        @parameter: sender
        @paramenter: e (event)

        */
               

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            if (this.formState == FormState.AddNew)
            {
                var result = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                SetFormState(FormState.View);
                LoadContact(current_contact);
            }

        }

        /*
         displays current contact

        @paramenter: c (Contact)
        */
        private void LoadContact(Person c)
        {

            TxtEmployeeNo.Text = c.PersonalNumber ?? "";
            CmbSalutation.Text = c.Salutation ?? "";
            TxtFirstname.Text = c.FirstName ?? "";
            TxtLastname.Text = c.LastName ?? "";
            dateTimePickerDateOfBirth.Text = c.DateOfBirth?.ToString() ?? "";
            CmbGender.Text = c.Gender ?? "";
            CmbTitle.Text = c.Title ?? "";
            TxtBusinessPhone.Text = c.BusinessPhone ?? "";
            TxtMobilePhone.Text = c.MobilePhone ?? "";
            TxtMailadress.Text = c.EmailAddress ?? "";
            CmbStatus.Text = c.Status ?? "";           
            TxtAHV.Text = c.AhvNumber ?? "";
            TextCity.Text = c.City ?? "";
            CmbNationality.Text = c.Nationality ?? "";
            TxtStreet.Text = c.Street ?? "";
            NumPostalCode.Text = c.PostalCode?.ToString() ?? "";
            TxtPrivatePhone.Text = c.PrivatePhone ?? "";


            // show/hide groups depending on person type 

            customerGroup.Visible = c is Customer;
            employeeGroup.Visible = c is Employee;
            traineeGroup.Visible = c is Trainee;

            
            if (c is Customer cust)
            {
                TxtCompanyName.Text = cust.CompanyName ?? "";
                CmbCustomerType.Text = cust.CustomerType ?? "";
                CmbCompanyContact.Text = cust.CompanyContact ?? "";
                TxtBusinessAddress.Text = cust.BusinessAddress ?? "";
            }

            if ( c is Employee emp)
            {
                CmbDepartment.Text = emp.Department ?? "";
                dateTimePickerEntryDate.Text = emp.EntryDate?.ToString() ?? "";
                dateTimePickerExitDate.Text = emp.ExitDate?.ToString() ?? "";
                CmbWorkload.Text = emp.Workload ?? "";
                CmbRole.Text = emp.Role ?? "";
                CmbMgmtLevel.Text = emp.ManagementLevel?.ToString() ?? "";
                
            }
            
            if (c is Trainee trai)
            {
                NumAppYears.Value = trai.ApprenticeshipYears ?? 0;
                NumCurrentAppYear.Value = trai.CurrentApprenticeshipYear ?? 0;
            }
                
            
        }

        /*
         changes form state and applies edit mode

        @paramenter: state
        */

        private void SetFormState(FormState state)
        {
            formState = state;

            bool isEditable = state == FormState.Edit || state == FormState.AddNew;

            ApplyEditMode(isEditable);
        }


        /*
         loops through all fields of current form and applies if editable state

        @parameter: isEditable
        */
        private void ApplyEditMode(bool isEditable)
        {
            void Walk(Control parent)
            {
                foreach (Control child in parent.Controls)
                {
                    switch (child)
                    {
                        case TextBox tb:
                            tb.ReadOnly = !isEditable;
                            break;
                        case ComboBox cmb:
                        case DateTimePicker dtP:
                        case NumericUpDown nuD:
                        case RadioButton rb:
                        case CheckBox cb:
                            child.Enabled = isEditable;
                            break;
                    }

                    // applies edit mode also on sub child fields
                    if (child.HasChildren)
                        Walk(child);
                }
            }

            Walk(this);

            TxtEmployeeNo.ReadOnly = true;

            // Toggle buttons
            BtnSaveContact.Visible = isEditable;
            BtnCancelContact.Visible = isEditable;
            BtnEditContact.Visible = !isEditable;
            BtnDeleteContact.Visible = !isEditable;
            BtnActivities.Visible = !isEditable;
        }

        /*
         shows history form of current contact

        @parameter: sender
        @paramenter: e (event)
         */
        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            HistoryWin.HistoryWin win = new HistoryWin.HistoryWin(this.current_contact);

            win.ShowDialog();
        }

        /*
         sets form state editable and hides/shows buttons

        @parameter: sender
        @paramenter: e (event)
         */

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Edit);

            BtnViewHistory.Show();
            BtnDeleteContact.Hide();
            BtnSaveContact.Show();
            BtnCancelContact.Show();
            BtnActivities.Hide();
        }


        /*
         saves changes of edited or new added contact

        @parameter: sender
        @paramenter: e (event)
         */

        // as to be similar to method LoadContact on line 126 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void BtnSaveContact_Click(object sender, EventArgs e)
        {
            try
            {
                var handler = ContactHandler.GetContactHandler();

                var updatedContact = new Person
                {
                    Salutation = CmbSalutation.Text,
                    FirstName = TxtFirstname.Text,
                    LastName = TxtLastname.Text,
                    DateOfBirth = DateOnly.FromDateTime(dateTimePickerDateOfBirth.Value),
                    Gender = CmbGender.Text,
                    Title = CmbTitle.Text,
                    BusinessPhone = TxtBusinessPhone.Text,
                    MobilePhone = TxtMobilePhone.Text,
                    EmailAddress = TxtMailadress.Text,
                    Status = CmbStatus.Text,
                    //Department = CmbDepartment.Text,
                    AhvNumber = TxtAHV.Text,
                    City = TextCity.Text,
                    Nationality = CmbNationality.Text,
                    Street = TxtStreet.Text,
                    PostalCode = NumPostalCode.Text,
                    PrivatePhone = TxtPrivatePhone.Text,
                    //EntryDate = DateOnly.FromDateTime(dateTimePickerEntryDate.Value),
                    //ExitDate = string.IsNullOrWhiteSpace(dateTimePickerExitDate.Text) ? null : DateOnly.FromDateTime(dateTimePickerExitDate.Value),
                    //Workload = CmbWorkload.Text,
                    //Role = CmbRole.Text,
                    //ManagementLevel = int.TryParse(CmbMgmtLevel.Text, out int mgmt) ? mgmt : null,
                    //ApprenticeshipYears = (int)NumAppYears.Value,
                    //CurrentApprenticeshipYear = (int?)NumCurrentAppYear.Value,
                    //CompanyName = TxtCompanyName.Text,
                    //BusinessAddress = TxtBusinessAddress.Text,
                    //CustomerType = CmbCustomerType.Text,
                    //CompanyContact = CmbCompanyContact.Text
                };

                // checks if form state is editable and if currenct contact exists
                if (formState == FormState.Edit && current_contact != null)
                {

                    // updates contact
                    updatedContact.PersonalNumber = current_contact.PersonalNumber;
                    handler.UpdateContact(updatedContact);
                    MessageBox.Show("Contact updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    historyHandler.AddToHistory(new HistoryEvent(AuthService.CurrentUser, FormState.Edit.ToString(), DateTime.Now, current_contact, updatedContact));
                }

                // adds contact
                else
                {
                    handler.AddContact(updatedContact);
                    MessageBox.Show("Contact added successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    historyHandler.AddToHistory(new HistoryEvent(AuthService.CurrentUser, FormState.AddNew.ToString(), DateTime.Now, current_contact, null));
                }

                this.Close();


            }

            // provides input safety
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving contact:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         deletes current contact with warning message

        @parameter: sender
        @paramenter: e (event)
        */
        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            contactHandler.DeleteContact(current_contact);


            var result = MessageBox.Show($"Are you sure you want to delete: {current_contact.FirstName} {current_contact.LastName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        /*
        Shows activity comments modal for current user

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnActivities_Click(object sender, EventArgs e)
        {
            ActivityWin activityWin = new ActivityWin(this.current_contact);

            activityWin.ShowDialog();
        }
    }
}
