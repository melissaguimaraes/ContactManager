using ContactManager.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Models;

namespace ContactManager.Controls
{
    // Usercontrol for Person
    public partial class PersonControl : UserControl, IUserControlMethods
    {

        // public accessable attributes
        public string PersonalNumber => TxtEmployeeNo.Text;
        public string Salutation => CmbSalutation.Text;
        public string Title => CmbTitle.Text;
        public string FirstName => TxtFirstname.Text;
        public string LastName => TxtLastname.Text;
        public DateOnly DateOfBirth => DateOnly.FromDateTime(dateTimePickerDateOfBirth.Value);
        public string Gender => CmbGender.Text;
        public string BusinessPhone => TxtBusinessPhone.Text;
        public string MobilePhone => TxtMobilePhone.Text;
        public string PrivatePhone => TxtPrivatePhone.Text;
        public string EmailAddress => TxtMailadress.Text;
        public bool Status => CmbStatus.Text == ContactStatus.Active.ToString();
        public string AhvNumber => TxtAHV.Text;
        public string Street => TxtStreet.Text;
        public string City => TextCity.Text;
        public string PostalCode => NumPostalCode.Text;
        public string Nationality => CmbNationality.Text;

        public PersonControl()
        {
            InitializeComponent();
        }

        // INTERFACE FORCED METHODS //

        /*
        method to toggle edit mode for controls

        @parameter: isEditable
        */
        public void ApplyEditMode(bool isEditable)
        {
            foreach (Control child in PersonGroup.Controls)
            {
                switch (child)
                {
                    case TextBox tb:
                        tb.ReadOnly = !isEditable;
                        break;
                    case ComboBox cmb:
                    case NumericUpDown nuD:
                    case RadioButton rb:
                    case CheckBox cb:
                    case DateTimePicker dtp:
                        child.Enabled = isEditable;
                        break;
                }
            }
        }

        /*
        Loads data of the passed contact into the controls

        @parameter: contact
        */
        public void LoadData(Person contact)
        {
            TxtEmployeeNo.Text = contact.PersonalNumber ?? string.Empty;
            CmbSalutation.SelectedItem = contact.Salutation ?? string.Empty;
            TxtFirstname.Text = contact.FirstName ?? string.Empty;
            TxtLastname.Text = contact.LastName ?? string.Empty;
            dateTimePickerDateOfBirth.Value = contact.DateOfBirth != DateOnly.MinValue ? contact.DateOfBirth.ToDateTime(new TimeOnly(0, 0)) : DateTime.Now;
            CmbGender.SelectedItem = contact.Gender ?? string.Empty;
            CmbTitle.SelectedItem = contact.Title ?? string.Empty;
            TxtBusinessPhone.Text = contact.BusinessPhone ?? string.Empty;
            TxtMobilePhone.Text = contact.MobilePhone ?? string.Empty;
            TxtPrivatePhone.Text = contact.PrivatePhone ?? string.Empty;
            TxtMailadress.Text = contact.EmailAddress ?? string.Empty;
            CmbStatus.SelectedItem = contact.Status ? ContactStatus.Active.ToString() : ContactStatus.Passive.ToString(); ;
            TxtAHV.Text = contact.AhvNumber ?? string.Empty;
            TextCity.Text = contact.City ?? string.Empty;
            CmbNationality.SelectedItem = contact.Nationality ?? string.Empty;
            TxtStreet.Text = contact.Street ?? string.Empty;
            NumPostalCode.Text = contact.PostalCode ?? string.Empty;
        }
    }
}
