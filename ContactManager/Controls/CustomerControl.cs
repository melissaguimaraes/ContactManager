using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Helper;
using ContactManager.Interfaces;
using ContactManager.Models;

namespace ContactManager.Controls
{
    // usercontrol for customer
    public partial class CustomerControl : UserControl, IUserControlMethods
    {
        // public accessable attributes
        public string CustomerCompanyName => TxtCompanyName.Text;
        public char CustomerType => string.IsNullOrEmpty(CmbCustomerType.Text) ? ' ' : CmbCustomerType.Text[0];
        public Employee CompanyContact => (Employee)CmbCompanyContact.SelectedItem;

        public CustomerControl()
        {
            InitializeComponent();

            ContactHandler handler = ContactHandler.GetContactHandler();

            List<Employee> employees = handler.LoadContacts().OfType<Employee>().ToList();

            CmbCompanyContact.DataSource = employees;
        }

        // INTERFACE FORCED METHODS //

        /*
        method to toggle edit mode for controls

        @parameter: isEditable
        */
        public void ApplyEditMode(bool isEditable)
        {
            foreach (Control child in CustomerGroup.Controls)
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
            if (contact is not Customer customer) return;

            TxtCompanyName.Text = customer.CompanyName ?? string.Empty;
            CmbCustomerType.SelectedItem = Char.ToString(customer.CustomerType) ?? String.Empty;

            if (customer.CompanyContact != null)
            {
                CmbCompanyContact.SelectedValue = customer.CompanyContact.PersonalNumber;
            }
            else
            {
                CmbCompanyContact.SelectedIndex = -1;
            }
        }
    }
}
