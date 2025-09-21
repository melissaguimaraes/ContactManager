using ContactManager.Controls;
using ContactManager.Helper;
using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Forms.ActivityWin;
using System.Drawing.Design;

namespace ContactManager.Forms
{

    // Form for Contact CRUD actions
    public partial class ContactWin : Form
    {
        // attributes
        private FormState formState;
        private Person currentContact;

        private ContactHandler contactHandler = ContactHandler.GetContactHandler();
        private HistoryHandler historyHandler = HistoryHandler.GetHistoryHandler();

        // constructor for creating a new contact = Add new FormState
        public ContactWin()
        {
            InitializeComponent();

            formState = FormState.AddNew;
            SetFormState(formState);

            // set datasource to contact types
            CmdContactType.DataSource = Enum.GetValues(typeof(ContactType));

            // initalizes window
            CmdContactType_SelectedIndexChanged(CmdContactType, EventArgs.Empty);
        }

        // constructor for viewing a contact = View Formstate
        public ContactWin(Person contact)
        {
            InitializeComponent();

            SetFormState(formState);

            this.currentContact = contact;

            LoadContact(contact);
        }


        /*
        Generic class to set the current formstae

        @parameter: state (FormState enum)
        */
        private void SetFormState(FormState state)
        {
            formState = state;

            bool isEditable = state == FormState.Edit || state == FormState.AddNew;

            ApplyEditMode(isEditable);

            // changes view of the buttons based on current state
            switch (state)
            {
                case FormState.Edit:
                    BtnViewHistory.Visible = true;
                    BtnActivities.Visible = false;
                    BtnDeleteContact.Visible = false;
                    BtnEditContact.Visible = false;
                    BtnSaveContact.Visible = true;
                    BtnCancelContact.Visible = true;
                    CmdContactType.Visible = false;
                    break;

                case FormState.AddNew:
                    BtnViewHistory.Visible = false;
                    BtnActivities.Visible = false;
                    BtnDeleteContact.Visible = false;
                    BtnEditContact.Visible = false;
                    BtnSaveContact.Visible = true;
                    BtnCancelContact.Visible = true;
                    CmdContactType.Visible = true;
                    break;

                case FormState.View:
                    BtnViewHistory.Visible = true;
                    BtnActivities.Visible = true;
                    BtnDeleteContact.Visible = true;
                    BtnEditContact.Visible = true;
                    BtnSaveContact.Visible = false;
                    BtnCancelContact.Visible = false;
                    CmdContactType.Visible = false;
                    break;
            }
        }


        /*
        loops through all fields of current form and applies if editable state

        @parameter: isEditable
        */
        private void ApplyEditMode(bool isEditable)
        {
            ControlPerson.ApplyEditMode(isEditable);
            ControlEmployee.ApplyEditMode(isEditable);
            ControlCustomer.ApplyEditMode(isEditable);
        }

        /*
        Loads contact information into the intended User control form and displays Usercontrol

        @parameter: contact (contact to display)
        */
        private void LoadContact(Person contact)
        {
            if (contact == null) return;

            ControlPerson.LoadData(contact);

            if (contact is Employee employee)
            {
                ControlEmployee.Visible = true;
                ControlCustomer.Visible = false;
                ControlEmployee.LoadData(employee);

                if (employee is Trainee trainee)
                {
                    ControlEmployee.LoadData(trainee);
                }
            }
            else if (contact is Customer customer)
            {
                ControlEmployee.Visible = false;
                ControlCustomer.Visible = true;
                ControlCustomer.LoadData(customer);
            }

            // changes the combobox selection based on the contact
            CmdContactType.SelectedItem = (contact is Employee) ? ContactType.Employee : ContactType.Customer;
        }

        /*
        Returns Enum of the current Contact type based on formstate

        @return: ContactType
        */
        private ContactType GetContactType()
        {
            if (formState == FormState.AddNew)
            {
                return (ContactType)Enum.Parse(typeof(ContactType), CmdContactType.Text);
            }
            else
            {
                return this.currentContact is Employee ? ContactType.Employee : ContactType.Customer;
            }
        }


        // UI ACTIONS //


        /*
        Shows/Hides User controls based on the selected combobox item.

        @parameter: sender
        @parameter: e (event)
        */
        private void CmdContactType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmdContactType.Text)) return; // Safety check

            // Show/hide controls based on selection
            ControlEmployee.Visible = CmdContactType.Text == ContactType.Employee.ToString();
            ControlCustomer.Visible = CmdContactType.Text == ContactType.Customer.ToString();
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

                // closes windows after creating an object
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else // in edit mode just exit mode and reload current values
            {
                SetFormState(FormState.View);
                LoadContact(currentContact);
            }

        }

        /*
        Adds / Saves changes of the new contact

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnSaveContact_Click(object sender, EventArgs e)
        {
            ContactType type = GetContactType();

            Person contact = null;

            // create contact ojbect based on current contact type
            if (type == ContactType.Employee)
            {
                string password;

                // if user already exists -> checks if password has changed before saving
                if (formState == FormState.Edit && currentContact is Employee existingEmployee)
                {
                    // prüfen, ob sich das Passwort geändert hat
                    if (existingEmployee.Password.Equals(ControlEmployee.Password))
                        password = existingEmployee.Password;
                    else
                        password = AuthService.HashPassword(ControlEmployee.Password);
                }
                else // new contact
                {
                    password = AuthService.HashPassword(ControlEmployee.Password);
                }

                if (ControlEmployee.IsTrainee)
                {
                    contact = new Trainee
                    {
                        // Person properties
                        PersonalNumber = ControlPerson.PersonalNumber,
                        Salutation = ControlPerson.Salutation,
                        FirstName = ControlPerson.FirstName,
                        LastName = ControlPerson.LastName,
                        DateOfBirth = ControlPerson.DateOfBirth,
                        Gender = ControlPerson.Gender,
                        Title = ControlPerson.Title,
                        BusinessPhone = ControlPerson.BusinessPhone,
                        MobilePhone = ControlPerson.MobilePhone,
                        PrivatePhone = ControlPerson.PrivatePhone,
                        EmailAddress = ControlPerson.EmailAddress,
                        Status = ControlPerson.Status,
                        AhvNumber = ControlPerson.AhvNumber,
                        City = ControlPerson.City,
                        Nationality = ControlPerson.Nationality,
                        Street = ControlPerson.Street,
                        PostalCode = ControlPerson.PostalCode,

                        // Employee properties
                        Department = ControlEmployee.Department,
                        EntryDate = ControlEmployee.EntryDate,
                        IsLeaving = ControlEmployee.IsLeaving,
                        ExitDate = ControlEmployee.ExitDate,
                        Workload = ControlEmployee.Workload,
                        Role = ControlEmployee.Role,
                        ManagementLevel = ControlEmployee.ManagementLevel,
                        IsAdmin = ControlEmployee.IsAdmin,
                        Username = ControlEmployee.Username,
                        Password = password,
                        // Trainee properties
                        CurrentApprenticeshipYear = ControlEmployee.CurrentApprenticeshipYear,
                        ApprenticeshipYears = ControlEmployee.ApprenticeshipYears
                    };
                }
                else
                {
                    contact = new Employee
                    {
                        // Person properties
                        PersonalNumber = ControlPerson.PersonalNumber,
                        Salutation = ControlPerson.Salutation,
                        FirstName = ControlPerson.FirstName,
                        LastName = ControlPerson.LastName,
                        DateOfBirth = ControlPerson.DateOfBirth,
                        Gender = ControlPerson.Gender,
                        Title = ControlPerson.Title,
                        BusinessPhone = ControlPerson.BusinessPhone,
                        MobilePhone = ControlPerson.MobilePhone,
                        PrivatePhone = ControlPerson.PrivatePhone,
                        EmailAddress = ControlPerson.EmailAddress,
                        Status = ControlPerson.Status,
                        AhvNumber = ControlPerson.AhvNumber,
                        City = ControlPerson.City,
                        Nationality = ControlPerson.Nationality,
                        Street = ControlPerson.Street,
                        PostalCode = ControlPerson.PostalCode,

                        // Employee properties
                        Department = ControlEmployee.Department,
                        EntryDate = ControlEmployee.EntryDate,
                        IsLeaving = ControlEmployee.IsLeaving,
                        ExitDate = ControlEmployee.ExitDate,
                        Workload = ControlEmployee.Workload,
                        Role = ControlEmployee.Role,
                        ManagementLevel = ControlEmployee.ManagementLevel,
                        IsAdmin = ControlEmployee.IsAdmin,
                        Username = ControlEmployee.Username,
                        Password = password
                    };
                }
            }
            else if (type == ContactType.Customer)
            {
                contact = new Customer
                {
                    // Person properties
                    PersonalNumber = ControlPerson.PersonalNumber,
                    Salutation = ControlPerson.Salutation,
                    FirstName = ControlPerson.FirstName,
                    LastName = ControlPerson.LastName,
                    DateOfBirth = ControlPerson.DateOfBirth,
                    Gender = ControlPerson.Gender,
                    Title = ControlPerson.Title,
                    BusinessPhone = ControlPerson.BusinessPhone,
                    MobilePhone = ControlPerson.MobilePhone,
                    PrivatePhone = ControlPerson.PrivatePhone,
                    EmailAddress = ControlPerson.EmailAddress,
                    Status = ControlPerson.Status,
                    AhvNumber = ControlPerson.AhvNumber,
                    City = ControlPerson.City,
                    Nationality = ControlPerson.Nationality,
                    Street = ControlPerson.Street,
                    PostalCode = ControlPerson.PostalCode,

                    // Customer properties
                    CompanyName = ControlCustomer.CompanyName,
                    CustomerType = ControlCustomer.CustomerType,
                    CompanyContact = ControlCustomer.CompanyContact
                };
            }

            // checks if form state is editable
            if (formState == FormState.Edit)
            {
                // updates contact
                contact.PersonalNumber = currentContact.PersonalNumber;
                contactHandler.UpdateContact(contact);
                MessageBox.Show("contact updated successfully!", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                historyHandler.AddToHistory(new HistoryEvent(AuthService.CurrentUser.Username, FormState.Edit.ToString(), DateTime.Now, this.currentContact, contact));

            }
            // adds contact
            else if (formState == FormState.AddNew)
            {
                contactHandler.AddContact(contact);
                MessageBox.Show("contact added successfully!", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                historyHandler.AddToHistory(new HistoryEvent(AuthService.CurrentUser.Username, FormState.AddNew.ToString(), DateTime.Now, this.currentContact, contact));
            }

            this.Close();
        }

        /*
        Shows activity comments modal for current user

        @parameter: sender
        @parameter: e (event)
        */
        private void BtnActivities_Click(object sender, EventArgs e)
        {
            ActivityWin.ActivityWin activityWin = new ActivityWin.ActivityWin(this.currentContact);

            activityWin.ShowDialog();
        }

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            SetFormState(FormState.Edit);
        }

        /*
        deletes current contact with warning message

        @parameter: sender
        @paramenter: e (event)
        */
        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show($"Are you sure you want to delete: {currentContact.FirstName} {currentContact.LastName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                contactHandler.DeleteContact(currentContact);
                this.Close();
            }

        }

        /*
        shows history form of current contact

        @parameter: sender
        @paramenter: e (event)
         */
        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            HistoryWin.HistoryWin win = new HistoryWin.HistoryWin(this.currentContact);

            win.ShowDialog();
        }
    }
}
