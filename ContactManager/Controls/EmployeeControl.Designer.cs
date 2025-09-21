namespace ContactManager.Controls
{
    partial class EmployeeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmployeeGroup = new GroupBox();
            ChckIsAdmin = new CheckBox();
            labe200 = new Label();
            TextUsername = new TextBox();
            dateTimePickerExitDate = new DateTimePicker();
            LblExitDate = new Label();
            ChkIsLeaving = new CheckBox();
            ChckIsTrainee = new CheckBox();
            label5 = new Label();
            TxtPassword = new TextBox();
            label4 = new Label();
            NumMgmtLevel = new NumericUpDown();
            label3 = new Label();
            CmdRole = new ComboBox();
            label2 = new Label();
            CmdWorkload = new ComboBox();
            CmdDepartment = new ComboBox();
            label1 = new Label();
            traineeGroup = new GroupBox();
            NumAppYears = new NumericUpDown();
            NumCurrentAppYear = new NumericUpDown();
            LblAppYears = new Label();
            LblCurrentAppYear = new Label();
            dateTimePickerEntryDate = new DateTimePicker();
            LblEntryDate = new Label();
            EmployeeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumMgmtLevel).BeginInit();
            traineeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumAppYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumCurrentAppYear).BeginInit();
            SuspendLayout();
            // 
            // EmployeeGroup
            // 
            EmployeeGroup.Controls.Add(ChckIsAdmin);
            EmployeeGroup.Controls.Add(labe200);
            EmployeeGroup.Controls.Add(TextUsername);
            EmployeeGroup.Controls.Add(dateTimePickerExitDate);
            EmployeeGroup.Controls.Add(LblExitDate);
            EmployeeGroup.Controls.Add(ChkIsLeaving);
            EmployeeGroup.Controls.Add(ChckIsTrainee);
            EmployeeGroup.Controls.Add(label5);
            EmployeeGroup.Controls.Add(TxtPassword);
            EmployeeGroup.Controls.Add(label4);
            EmployeeGroup.Controls.Add(NumMgmtLevel);
            EmployeeGroup.Controls.Add(label3);
            EmployeeGroup.Controls.Add(CmdRole);
            EmployeeGroup.Controls.Add(label2);
            EmployeeGroup.Controls.Add(CmdWorkload);
            EmployeeGroup.Controls.Add(CmdDepartment);
            EmployeeGroup.Controls.Add(label1);
            EmployeeGroup.Controls.Add(traineeGroup);
            EmployeeGroup.Controls.Add(dateTimePickerEntryDate);
            EmployeeGroup.Controls.Add(LblEntryDate);
            EmployeeGroup.Location = new Point(3, 2);
            EmployeeGroup.Margin = new Padding(3, 2, 3, 2);
            EmployeeGroup.Name = "EmployeeGroup";
            EmployeeGroup.Padding = new Padding(3, 2, 3, 2);
            EmployeeGroup.Size = new Size(619, 287);
            EmployeeGroup.TabIndex = 109;
            EmployeeGroup.TabStop = false;
            EmployeeGroup.Text = "Employee Info";
            // 
            // ChckIsAdmin
            // 
            ChckIsAdmin.AutoSize = true;
            ChckIsAdmin.Location = new Point(13, 188);
            ChckIsAdmin.Margin = new Padding(2, 2, 2, 2);
            ChckIsAdmin.Name = "ChckIsAdmin";
            ChckIsAdmin.Size = new Size(78, 19);
            ChckIsAdmin.TabIndex = 118;
            ChckIsAdmin.Text = "Is Admin?";
            ChckIsAdmin.UseVisualStyleBackColor = true;
            // 
            // labe200
            // 
            labe200.AutoSize = true;
            labe200.Location = new Point(13, 158);
            labe200.Name = "labe200";
            labe200.Size = new Size(60, 15);
            labe200.TabIndex = 115;
            labe200.Text = "Username";
            // 
            // TextUsername
            // 
            TextUsername.Location = new Point(89, 155);
            TextUsername.Margin = new Padding(2, 2, 2, 2);
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(187, 23);
            TextUsername.TabIndex = 114;
            // 
            // dateTimePickerExitDate
            // 
            dateTimePickerExitDate.Enabled = false;
            dateTimePickerExitDate.Location = new Point(89, 64);
            dateTimePickerExitDate.Name = "dateTimePickerExitDate";
            dateTimePickerExitDate.Size = new Size(239, 23);
            dateTimePickerExitDate.TabIndex = 102;
            dateTimePickerExitDate.Value = new DateTime(2999, 1, 1, 0, 0, 0, 0);
            // 
            // LblExitDate
            // 
            LblExitDate.AutoSize = true;
            LblExitDate.Location = new Point(13, 64);
            LblExitDate.Name = "LblExitDate";
            LblExitDate.Size = new Size(52, 15);
            LblExitDate.TabIndex = 113;
            LblExitDate.Text = "Exit Date";
            // 
            // ChkIsLeaving
            // 
            ChkIsLeaving.AutoSize = true;
            ChkIsLeaving.Location = new Point(336, 64);
            ChkIsLeaving.Margin = new Padding(2, 2, 2, 2);
            ChkIsLeaving.Name = "ChkIsLeaving";
            ChkIsLeaving.Size = new Size(83, 19);
            ChkIsLeaving.TabIndex = 104;
            ChkIsLeaving.Text = "Is Leaving?";
            ChkIsLeaving.UseVisualStyleBackColor = true;
            ChkIsLeaving.CheckedChanged += ChkIsLeaving_CheckedChanged;
            // 
            // ChckIsTrainee
            // 
            ChckIsTrainee.AutoSize = true;
            ChckIsTrainee.Location = new Point(13, 211);
            ChckIsTrainee.Margin = new Padding(2, 2, 2, 2);
            ChckIsTrainee.Name = "ChckIsTrainee";
            ChckIsTrainee.Size = new Size(80, 19);
            ChckIsTrainee.TabIndex = 120;
            ChckIsTrainee.Text = "Is Trainee?";
            ChckIsTrainee.UseVisualStyleBackColor = true;
            ChckIsTrainee.CheckedChanged += ChckIsTrainee_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 158);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 74;
            label5.Text = "Password";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(421, 157);
            TxtPassword.Margin = new Padding(2, 2, 2, 2);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(187, 23);
            TxtPassword.TabIndex = 116;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 124);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 72;
            label4.Text = "Management Level";
            // 
            // NumMgmtLevel
            // 
            NumMgmtLevel.Location = new Point(421, 121);
            NumMgmtLevel.Margin = new Padding(2, 2, 2, 2);
            NumMgmtLevel.Name = "NumMgmtLevel";
            NumMgmtLevel.Size = new Size(186, 23);
            NumMgmtLevel.TabIndex = 112;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 98);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 70;
            label3.Text = "Role";
            // 
            // CmdRole
            // 
            CmdRole.FormattingEnabled = true;
            CmdRole.Items.AddRange(new object[] { "Assistant", "Specialist", "Junior", "Senior", "Manager", "Team Lead", "Director", "Executive", "Trainee", "Consultant" });
            CmdRole.Location = new Point(421, 93);
            CmdRole.Margin = new Padding(2, 2, 2, 2);
            CmdRole.Name = "CmdRole";
            CmdRole.Size = new Size(187, 23);
            CmdRole.TabIndex = 108;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 124);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 68;
            label2.Text = "Workload";
            // 
            // CmdWorkload
            // 
            CmdWorkload.FormattingEnabled = true;
            CmdWorkload.Items.AddRange(new object[] { "100%", "90%", "80%", "70%", "60%", "50%", "40%", "30%", "20%", "10%" });
            CmdWorkload.Location = new Point(89, 122);
            CmdWorkload.Margin = new Padding(2, 2, 2, 2);
            CmdWorkload.Name = "CmdWorkload";
            CmdWorkload.Size = new Size(187, 23);
            CmdWorkload.TabIndex = 110;
            // 
            // CmdDepartment
            // 
            CmdDepartment.FormattingEnabled = true;
            CmdDepartment.Items.AddRange(new object[] { "IT", "HR", "Finance", "Marketing", "Sales", "Customer Support", "Legal", "Procurement", "Operations", "Logistics", "Administration", "Quality", "Facilities", "Communications" });
            CmdDepartment.Location = new Point(89, 93);
            CmdDepartment.Margin = new Padding(2, 2, 2, 2);
            CmdDepartment.Name = "CmdDepartment";
            CmdDepartment.Size = new Size(187, 23);
            CmdDepartment.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 95);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 65;
            label1.Text = "Department";
            // 
            // traineeGroup
            // 
            traineeGroup.Controls.Add(NumAppYears);
            traineeGroup.Controls.Add(NumCurrentAppYear);
            traineeGroup.Controls.Add(LblAppYears);
            traineeGroup.Controls.Add(LblCurrentAppYear);
            traineeGroup.Location = new Point(365, 203);
            traineeGroup.Margin = new Padding(3, 2, 3, 2);
            traineeGroup.Name = "traineeGroup";
            traineeGroup.Padding = new Padding(3, 2, 3, 2);
            traineeGroup.Size = new Size(248, 79);
            traineeGroup.TabIndex = 63;
            traineeGroup.TabStop = false;
            // 
            // NumAppYears
            // 
            NumAppYears.Location = new Point(167, 49);
            NumAppYears.Name = "NumAppYears";
            NumAppYears.Size = new Size(76, 23);
            NumAppYears.TabIndex = 124;
            // 
            // NumCurrentAppYear
            // 
            NumCurrentAppYear.Location = new Point(167, 15);
            NumCurrentAppYear.Name = "NumCurrentAppYear";
            NumCurrentAppYear.Size = new Size(76, 23);
            NumCurrentAppYear.TabIndex = 122;
            // 
            // LblAppYears
            // 
            LblAppYears.AutoSize = true;
            LblAppYears.Location = new Point(9, 51);
            LblAppYears.Name = "LblAppYears";
            LblAppYears.Size = new Size(117, 15);
            LblAppYears.TabIndex = 62;
            LblAppYears.Text = "Apprenticeship Years";
            // 
            // LblCurrentAppYear
            // 
            LblCurrentAppYear.AutoSize = true;
            LblCurrentAppYear.Location = new Point(8, 19);
            LblCurrentAppYear.Name = "LblCurrentAppYear";
            LblCurrentAppYear.Size = new Size(155, 15);
            LblCurrentAppYear.TabIndex = 61;
            LblCurrentAppYear.Text = "Current Apprenticeship Year";
            // 
            // dateTimePickerEntryDate
            // 
            dateTimePickerEntryDate.Location = new Point(89, 26);
            dateTimePickerEntryDate.Name = "dateTimePickerEntryDate";
            dateTimePickerEntryDate.Size = new Size(239, 23);
            dateTimePickerEntryDate.TabIndex = 100;
            // 
            // LblEntryDate
            // 
            LblEntryDate.AutoSize = true;
            LblEntryDate.Location = new Point(13, 31);
            LblEntryDate.Name = "LblEntryDate";
            LblEntryDate.Size = new Size(61, 15);
            LblEntryDate.TabIndex = 47;
            LblEntryDate.Text = "Entry Date";
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EmployeeGroup);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EmployeeControl";
            Size = new Size(720, 292);
            EmployeeGroup.ResumeLayout(false);
            EmployeeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumMgmtLevel).EndInit();
            traineeGroup.ResumeLayout(false);
            traineeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumAppYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumCurrentAppYear).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EmployeeGroup;
        private GroupBox traineeGroup;
        protected DateTimePicker dateTimePickerEntryDate;
        protected Label LblEntryDate;
        protected Label label1;
        private TextBox TxtExit;
        private ComboBox CmdDepartment;
        protected Label label3;
        private ComboBox CmdRole;
        protected Label label2;
        private ComboBox CmdWorkload;
        protected Label label4;
        private NumericUpDown NumMgmtLevel;
        private CheckBox ChckIsTrainee;
        protected Label label5;
        private TextBox TxtPassword;
        private CheckBox ChkIsLeaving;
        protected DateTimePicker dateTimePickerExitDate;
        protected Label LblExitDate;
        private CheckBox ChckIsAdmin;
        protected Label labe200;
        private TextBox TextUsername;
        private NumericUpDown NumAppYears;
        protected NumericUpDown NumCurrentAppYear;
        protected Label LblAppYears;
        protected Label LblCurrentAppYear;
    }
}
