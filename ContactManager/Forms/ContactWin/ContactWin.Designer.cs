namespace ContactManager.Forms
{
    partial class ContactWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdContactType = new ComboBox();
            ControlPerson = new ContactManager.Controls.PersonControl();
            ControlEmployee = new ContactManager.Controls.EmployeeControl();
            ControlCustomer = new ContactManager.Controls.CustomerControl();
            BtnActivities = new Button();
            BtnDeleteContact = new Button();
            BtnViewHistory = new Button();
            BtnEditContact = new Button();
            BtnCancelContact = new Button();
            BtnSaveContact = new Button();
            SuspendLayout();
            // 
            // CmdContactType
            // 
            CmdContactType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmdContactType.FormattingEnabled = true;
            CmdContactType.Location = new Point(545, 7);
            CmdContactType.Margin = new Padding(2, 2, 2, 2);
            CmdContactType.Name = "CmdContactType";
            CmdContactType.Size = new Size(129, 23);
            CmdContactType.TabIndex = 0;
            CmdContactType.SelectedIndexChanged += CmdContactType_SelectedIndexChanged;
            // 
            // ControlPerson
            // 
            ControlPerson.Location = new Point(21, 31);
            ControlPerson.Margin = new Padding(1, 1, 1, 1);
            ControlPerson.Name = "ControlPerson";
            ControlPerson.Size = new Size(666, 382);
            ControlPerson.TabIndex = 1;
            // 
            // ControlEmployee
            // 
            ControlEmployee.Location = new Point(39, 397);
            ControlEmployee.Margin = new Padding(1, 1, 1, 1);
            ControlEmployee.Name = "ControlEmployee";
            ControlEmployee.Size = new Size(634, 302);
            ControlEmployee.TabIndex = 2;
            // 
            // ControlCustomer
            // 
            ControlCustomer.Location = new Point(39, 397);
            ControlCustomer.Margin = new Padding(1, 1, 1, 1);
            ControlCustomer.Name = "ControlCustomer";
            ControlCustomer.Size = new Size(633, 188);
            ControlCustomer.TabIndex = 3;
            // 
            // BtnActivities
            // 
            BtnActivities.BackColor = Color.FromArgb(119, 141, 169);
            BtnActivities.ForeColor = Color.White;
            BtnActivities.Location = new Point(39, 718);
            BtnActivities.Name = "BtnActivities";
            BtnActivities.Size = new Size(104, 23);
            BtnActivities.TabIndex = 106;
            BtnActivities.Text = "Show Actvities";
            BtnActivities.UseVisualStyleBackColor = false;
            BtnActivities.Click += BtnActivities_Click;
            // 
            // BtnDeleteContact
            // 
            BtnDeleteContact.BackColor = Color.FromArgb(255, 53, 94);
            BtnDeleteContact.ForeColor = Color.White;
            BtnDeleteContact.Location = new Point(177, 704);
            BtnDeleteContact.Name = "BtnDeleteContact";
            BtnDeleteContact.Size = new Size(76, 23);
            BtnDeleteContact.TabIndex = 107;
            BtnDeleteContact.Text = "Delete";
            BtnDeleteContact.UseVisualStyleBackColor = false;
            BtnDeleteContact.Click += BtnDeleteContact_Click;
            // 
            // BtnViewHistory
            // 
            BtnViewHistory.BackColor = Color.FromArgb(119, 141, 169);
            BtnViewHistory.ForeColor = Color.White;
            BtnViewHistory.Location = new Point(39, 688);
            BtnViewHistory.Name = "BtnViewHistory";
            BtnViewHistory.Size = new Size(104, 23);
            BtnViewHistory.TabIndex = 105;
            BtnViewHistory.Text = "Show History";
            BtnViewHistory.UseVisualStyleBackColor = false;
            BtnViewHistory.Click += BtnViewHistory_Click;
            // 
            // BtnEditContact
            // 
            BtnEditContact.BackColor = Color.FromArgb(119, 141, 169);
            BtnEditContact.ForeColor = Color.White;
            BtnEditContact.Location = new Point(580, 704);
            BtnEditContact.Name = "BtnEditContact";
            BtnEditContact.Size = new Size(76, 23);
            BtnEditContact.TabIndex = 108;
            BtnEditContact.Text = "Edit";
            BtnEditContact.UseVisualStyleBackColor = false;
            BtnEditContact.Click += BtnEditContact_Click;
            // 
            // BtnCancelContact
            // 
            BtnCancelContact.BackColor = Color.FromArgb(255, 53, 94);
            BtnCancelContact.ForeColor = Color.White;
            BtnCancelContact.Location = new Point(580, 704);
            BtnCancelContact.Name = "BtnCancelContact";
            BtnCancelContact.Size = new Size(76, 23);
            BtnCancelContact.TabIndex = 110;
            BtnCancelContact.Text = "Cancel";
            BtnCancelContact.UseVisualStyleBackColor = false;
            BtnCancelContact.Click += BtnCancel_Click;
            // 
            // BtnSaveContact
            // 
            BtnSaveContact.BackColor = Color.PaleGreen;
            BtnSaveContact.Location = new Point(491, 704);
            BtnSaveContact.Name = "BtnSaveContact";
            BtnSaveContact.Size = new Size(76, 23);
            BtnSaveContact.TabIndex = 109;
            BtnSaveContact.Text = "Save";
            BtnSaveContact.UseVisualStyleBackColor = false;
            BtnSaveContact.Click += BtnSaveContact_Click;
            // 
            // ContactWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 761);
            Controls.Add(BtnActivities);
            Controls.Add(BtnDeleteContact);
            Controls.Add(BtnViewHistory);
            Controls.Add(BtnEditContact);
            Controls.Add(BtnCancelContact);
            Controls.Add(BtnSaveContact);
            Controls.Add(ControlCustomer);
            Controls.Add(ControlEmployee);
            Controls.Add(ControlPerson);
            Controls.Add(CmdContactType);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "ContactWin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ContactWin";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CmdContactType;
        private Controls.PersonControl ControlPerson;
        private Controls.EmployeeControl ControlEmployee;
        private Controls.CustomerControl ControlCustomer;
        private Button BtnActivities;
        private Button BtnDeleteContact;
        private Button BtnViewHistory;
        private Button BtnEditContact;
        protected Button BtnCancelContact;
        protected Button BtnSaveContact;
    }
}