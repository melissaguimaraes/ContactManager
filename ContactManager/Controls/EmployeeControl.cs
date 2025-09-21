using ContactManager.Interfaces;
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

namespace ContactManager.Controls
{
    // Usercontrol for Person
    public partial class EmployeeControl : UserControl, IUserControlMethods
    {

        // public accessable attributes

        // Employee specific
        public string Department => CmdDepartment.Text;
        public string Workload => CmdWorkload.Text;
        public string Role => CmdRole.Text;
        public int? ManagementLevel => (int?)NumMgmtLevel.Value;
        public bool IsLeaving => ChkIsLeaving.Checked;
        public DateOnly? EntryDate => DateOnly.FromDateTime(dateTimePickerEntryDate.Value);
        public DateOnly? ExitDate => ChkIsLeaving.Checked ? DateOnly.FromDateTime(dateTimePickerExitDate.Value) : null;
        public string Username => TextUsername.Text;
        public string Password => TxtPassword.Text;
        public bool IsAdmin => ChckIsAdmin.Checked;

        // Trainee specifics
        public bool IsTrainee => ChckIsTrainee.Checked;
        public int? ApprenticeshipYears => (int?)NumAppYears.Value;
        public int? CurrentApprenticeshipYear => (int?)NumCurrentAppYear.Value;

        private bool _isEditable = false;

        public EmployeeControl()
        {
            InitializeComponent();

            traineeGroup.Visible = false;
        }

        /*
        Show Trainee/Apprentice Information dependig if isTrainee is checked.

        @parameter: sender
        @parameter: e (event)
        */
        private void ChckIsTrainee_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            traineeGroup.Visible = chkBox.Checked;
        }

        /*
        Toggles dateTimePicker state for ExitDate

        @parameter: sender
        @parameter: e (event)
        */
        private void ChkIsLeaving_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerExitDate.Enabled = ChkIsLeaving.Checked && _isEditable;
        }

        // INTERFACE FORCED METHODS //

        /*
        method to toggle edit mode for controls

        @parameter: isEditable
        */
        public void ApplyEditMode(bool isEditable)
        {
            _isEditable = isEditable;

            foreach (Control child in EmployeeGroup.Controls)
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

            NumCurrentAppYear.Enabled = isEditable;
            NumAppYears.Enabled = isEditable;

            // datetime picker for exitDate shouldn't be affected only by state
            dateTimePickerExitDate.Enabled = (ChkIsLeaving.Checked && isEditable);
        }

        /*
        Loads data of the passed contact into the controls

        @parameter: contact
        */
        public void LoadData(Person contact)
        {
            if (contact is not Employee employee) return;

            dateTimePickerEntryDate.Value = employee.EntryDate.HasValue && employee.EntryDate.Value != DateOnly.MinValue
                ? employee.EntryDate.Value.ToDateTime(TimeOnly.MinValue)
                : DateTime.Now;

            dateTimePickerExitDate.Value = employee.ExitDate.HasValue && employee.ExitDate.Value != DateOnly.MinValue
                ? employee.ExitDate.Value.ToDateTime(TimeOnly.MinValue)
                : new DateTime(2999, 1, 1);

            ChkIsLeaving.Checked = employee.IsLeaving;
            ChckIsAdmin.Checked = employee.IsAdmin;
            TextUsername.Text = employee.Username ?? string.Empty;
            TxtPassword.Text = employee.Password ?? string.Empty;

            // Department / Role / Workload / Management Level
            CmdDepartment.SelectedItem = employee.Department ?? null;
            CmdRole.SelectedItem = employee.Role ?? null;
            CmdWorkload.SelectedItem = employee.Workload ?? null;
            NumMgmtLevel.Value = (int) employee.ManagementLevel;

            if (employee is Trainee trainee)
            {
                // Trainee
                ChckIsTrainee.Checked = true;
                ChckIsTrainee_CheckedChanged(ChckIsTrainee, EventArgs.Empty);
                NumCurrentAppYear.Value = (int) trainee.CurrentApprenticeshipYear;
                NumAppYears.Value = (int) trainee.ApprenticeshipYears;
            }
        }

    }
}
