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
using System.Windows.Forms.VisualStyles;
using BaseForm = ContactManager.NewContactWin.NewContactWin;

// grabing contact CLASS 
using ContactModel = ContactManager.Models.Contact;


namespace ContactManager.ContactWin
{
    public partial class ContactWin : BaseForm
    {


        private readonly ContactModel _contact;
        private FormState formState;

        public ContactWin()
        {
            InitializeComponent();
            this.Text = "Add New Contact";
            SetFormState(FormState.AddNew);
        }

        // View mode
        // it inherits form from NewContact and loads contact into it - blocks edit
        public ContactWin(Contact contToDisplay)
        {
            InitializeComponent();

            _contact = contToDisplay ?? throw new ArgumentNullException(nameof(contToDisplay));
            LoadContact(_contact);

            SetFormState(FormState.View);
            BtnCancelContact.Hide();
            BtnSaveContact.Hide();
        }

        private void LoadContact(ContactModel c)
        {

            TxtEmployeeNo.Text = c.EmployeeNumber ?? "";
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
            CmbDepartment.Text = c.Department ?? "";
            TxtAHV.Text = c.AhvNumber ?? "";
            TextCity.Text = c.City ?? "";
            CmbNationality.Text = c.Nationality ?? "";
            TxtStreet.Text = c.Street ?? "";
            NumPostalCode.Text = c.PostalCode?.ToString() ?? "";
            TxtPrivatePhone.Text = c.PrivatePhone ?? "";
            dateTimePickerEntryDate.Text = c.EntryDate?.ToString() ?? "";
            dateTimePickerExitDate.Text = c.ExitDate?.ToString() ?? "";
            CmbWorkload.Text = c.Workload ?? "";
            CmbRole.Text = c.Role ?? "";
            CmbMgmtLevel.Text = c.ManagementLevel?.ToString() ?? "";
            NumCurrentAppYear.Value = c.CurrentApprenticeshipYear ?? 0;
            TxtCompanyName.Text = c.CompanyName ?? "";
            TxtBusinessAddress.Text = c.BusinessAddress ?? "";
            CmbCustomerType.Text = c.CustomerType ?? "";
            CmbCompanyContact.Text = c.CompanyContact ?? "";

        }

        private void SetFormState(FormState state)
        {
            formState = state;

            bool isEditable = state == FormState.Edit || state == FormState.AddNew;

            // Enable or disable controls
            TxtEmployeeNo.ReadOnly = !isEditable;
            CmbSalutation.Enabled = isEditable;
            TxtFirstname.ReadOnly = !isEditable;
            TxtLastname.ReadOnly = !isEditable;
            dateTimePickerDateOfBirth.Enabled = isEditable;
            CmbGender.Enabled = isEditable;
            CmbTitle.Enabled = isEditable;
            TxtBusinessPhone.ReadOnly = !isEditable;
            TxtMobilePhone.ReadOnly = !isEditable;
            TxtMailadress.ReadOnly = !isEditable;
            CmbStatus.Enabled = isEditable;
            CmbDepartment.Enabled = isEditable;
            TxtAHV.ReadOnly = !isEditable;
            TextCity.ReadOnly = !isEditable;
            CmbNationality.Enabled = isEditable;
            TxtStreet.ReadOnly = !isEditable;
            NumPostalCode.Enabled = isEditable;
            TxtPrivatePhone.ReadOnly = !isEditable;
            dateTimePickerEntryDate.Enabled = isEditable;
            dateTimePickerExitDate.Enabled = isEditable;
            CmbWorkload.Enabled = isEditable;
            CmbRole.Enabled = isEditable;
            CmbMgmtLevel.Enabled = isEditable;
            NumCurrentAppYear.Enabled = isEditable;
            TxtCompanyName.ReadOnly = !isEditable;
            TxtBusinessAddress.ReadOnly = !isEditable;
            CmbCustomerType.Enabled = isEditable;
            CmbCompanyContact.Enabled = isEditable;

            // Optional: toggle Save/Edit/Add buttons
            BtnSaveContact.Visible = isEditable;
            BtnCancelContact.Visible = isEditable;
            BtnEditContact.Visible = state == FormState.View;
        }

        /*
        Sets formstate -> Edit current contact

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Edit);
        }

    }
}
