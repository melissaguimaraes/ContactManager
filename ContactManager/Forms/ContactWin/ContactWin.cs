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


using BaseForm = ContactManager.NewContactWin.NewContactWin;

// grabing contact CLASS 
using ContactModel = ContactManager.Models.Contact;


namespace ContactManager.ContactWin
{
    public partial class ContactWin : BaseForm
    {

        private readonly ContactModel _contact;

       
        public ContactWin() 
        {
            InitializeComponent();
            this.Text = "Contact Details";
                                    
        }

        // it inherits form from NewContact and loads contact into it - blocks edit
        public ContactWin(ContactModel contToDisplay) : base()
        {
            _contact = contToDisplay ?? throw new ArgumentNullException(nameof(contToDisplay));
            LoadContact(_contact);

            ContactFormNoEdit(true);
            BtnCancelNewContact.Hide();
            BtnSaveNewContact.Hide();

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
            CmbAppYears.SelectedItem = c.ApprenticeshipYears ?? 0;   
            NumCurrentAppYear.Value = c.CurrentApprenticeshipYear ?? 0;   
            TxtCompanyName.Text = c.CompanyName ?? "";
            TxtBusinessAddress.Text = c.BusinessAddress ?? "";
            CmbCustomerType.Text = c.CustomerType ?? "";
            CmbCompanyContact.Text = c.CompanyContact ?? "";
            
        }

    }
}
