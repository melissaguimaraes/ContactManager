namespace ContactManager.Controls
{
    partial class PersonControl
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
            PersonGroup = new GroupBox();
            NumPostalCode = new TextBox();
            TxtMailadress = new TextBox();
            TxtPrivatePhone = new TextBox();
            LblPrivatePhone = new Label();
            CmbNationality = new ComboBox();
            LblPostalCode = new Label();
            LblNationality = new Label();
            TxtStreet = new TextBox();
            LblStreet = new Label();
            LblCity = new Label();
            TxtAHV = new TextBox();
            LblAHV = new Label();
            CmbStatus = new ComboBox();
            TxtMobilePhone = new TextBox();
            LblBusinessPhone = new Label();
            CmbTitle = new ComboBox();
            CmbGender = new ComboBox();
            dateTimePickerDateOfBirth = new DateTimePicker();
            CmbSalutation = new ComboBox();
            LblStatus = new Label();
            TxtBusinessPhone = new TextBox();
            LblMobilePhone = new Label();
            LblGender = new Label();
            TxtLastname = new TextBox();
            LblLastname = new Label();
            TextCity = new TextBox();
            LblMailadress = new Label();
            LblTitle = new Label();
            LblDateOfBirth = new Label();
            TxtFirstname = new TextBox();
            LblFirstname = new Label();
            LblSalutation = new Label();
            TxtEmployeeNo = new TextBox();
            LblEmployeeNo = new Label();
            dateTimePicker1 = new DateTimePicker();
            PersonGroup.SuspendLayout();
            SuspendLayout();
            // 
            // PersonGroup
            // 
            PersonGroup.Controls.Add(NumPostalCode);
            PersonGroup.Controls.Add(TxtMailadress);
            PersonGroup.Controls.Add(TxtPrivatePhone);
            PersonGroup.Controls.Add(LblPrivatePhone);
            PersonGroup.Controls.Add(CmbNationality);
            PersonGroup.Controls.Add(LblPostalCode);
            PersonGroup.Controls.Add(LblNationality);
            PersonGroup.Controls.Add(TxtStreet);
            PersonGroup.Controls.Add(LblStreet);
            PersonGroup.Controls.Add(LblCity);
            PersonGroup.Controls.Add(TxtAHV);
            PersonGroup.Controls.Add(LblAHV);
            PersonGroup.Controls.Add(CmbStatus);
            PersonGroup.Controls.Add(TxtMobilePhone);
            PersonGroup.Controls.Add(LblBusinessPhone);
            PersonGroup.Controls.Add(CmbTitle);
            PersonGroup.Controls.Add(CmbGender);
            PersonGroup.Controls.Add(dateTimePickerDateOfBirth);
            PersonGroup.Controls.Add(CmbSalutation);
            PersonGroup.Controls.Add(LblStatus);
            PersonGroup.Controls.Add(TxtBusinessPhone);
            PersonGroup.Controls.Add(LblMobilePhone);
            PersonGroup.Controls.Add(LblGender);
            PersonGroup.Controls.Add(TxtLastname);
            PersonGroup.Controls.Add(LblLastname);
            PersonGroup.Controls.Add(TextCity);
            PersonGroup.Controls.Add(LblMailadress);
            PersonGroup.Controls.Add(LblTitle);
            PersonGroup.Controls.Add(LblDateOfBirth);
            PersonGroup.Controls.Add(TxtFirstname);
            PersonGroup.Controls.Add(LblFirstname);
            PersonGroup.Controls.Add(LblSalutation);
            PersonGroup.Location = new Point(18, 36);
            PersonGroup.Margin = new Padding(2);
            PersonGroup.Name = "PersonGroup";
            PersonGroup.Padding = new Padding(2);
            PersonGroup.Size = new Size(623, 323);
            PersonGroup.TabIndex = 80;
            PersonGroup.TabStop = false;
            // 
            // NumPostalCode
            // 
            NumPostalCode.Location = new Point(424, 243);
            NumPostalCode.Name = "NumPostalCode";
            NumPostalCode.Size = new Size(96, 23);
            NumPostalCode.TabIndex = 102;
            // 
            // TxtMailadress
            // 
            TxtMailadress.Location = new Point(419, 134);
            TxtMailadress.Name = "TxtMailadress";
            TxtMailadress.Size = new Size(178, 23);
            TxtMailadress.TabIndex = 93;
            // 
            // TxtPrivatePhone
            // 
            TxtPrivatePhone.Location = new Point(122, 209);
            TxtPrivatePhone.Name = "TxtPrivatePhone";
            TxtPrivatePhone.Size = new Size(197, 23);
            TxtPrivatePhone.TabIndex = 98;
            // 
            // LblPrivatePhone
            // 
            LblPrivatePhone.AutoSize = true;
            LblPrivatePhone.Location = new Point(14, 212);
            LblPrivatePhone.Name = "LblPrivatePhone";
            LblPrivatePhone.Size = new Size(80, 15);
            LblPrivatePhone.TabIndex = 113;
            LblPrivatePhone.Text = "Private Phone";
            // 
            // CmbNationality
            // 
            CmbNationality.FormattingEnabled = true;
            CmbNationality.Items.AddRange(new object[] { "Albanian", "American", "Austrian", "Bosnian", "British", "Chinese", "Croatian", "Czech", "Dutch", "Filipino", "French", "German", "Greek", "Hungarian", "Iranian", "Italian", "Kosovar", "Polish", "Portuguese", "Romanian", "Russian", "Serbian", "Spanish", "Sri Lankan", "Swiss", "Thai", "Turkish" });
            CmbNationality.Location = new Point(419, 209);
            CmbNationality.Name = "CmbNationality";
            CmbNationality.RightToLeft = RightToLeft.Yes;
            CmbNationality.Size = new Size(178, 23);
            CmbNationality.TabIndex = 99;
            // 
            // LblPostalCode
            // 
            LblPostalCode.AutoSize = true;
            LblPostalCode.Location = new Point(339, 244);
            LblPostalCode.Name = "LblPostalCode";
            LblPostalCode.Size = new Size(70, 15);
            LblPostalCode.TabIndex = 110;
            LblPostalCode.Text = "Postal Code";
            // 
            // LblNationality
            // 
            LblNationality.AutoSize = true;
            LblNationality.Location = new Point(334, 209);
            LblNationality.Name = "LblNationality";
            LblNationality.Size = new Size(65, 15);
            LblNationality.TabIndex = 109;
            LblNationality.Text = "Nationality";
            // 
            // TxtStreet
            // 
            TxtStreet.Location = new Point(85, 242);
            TxtStreet.Name = "TxtStreet";
            TxtStreet.Size = new Size(238, 23);
            TxtStreet.TabIndex = 100;
            // 
            // LblStreet
            // 
            LblStreet.AutoSize = true;
            LblStreet.Location = new Point(16, 244);
            LblStreet.Name = "LblStreet";
            LblStreet.Size = new Size(37, 15);
            LblStreet.TabIndex = 108;
            LblStreet.Text = "Street";
            // 
            // LblCity
            // 
            LblCity.AutoSize = true;
            LblCity.Location = new Point(16, 280);
            LblCity.Name = "LblCity";
            LblCity.Size = new Size(28, 15);
            LblCity.TabIndex = 107;
            LblCity.Text = "City";
            // 
            // TxtAHV
            // 
            TxtAHV.Location = new Point(419, 173);
            TxtAHV.Name = "TxtAHV";
            TxtAHV.Size = new Size(178, 23);
            TxtAHV.TabIndex = 96;
            // 
            // LblAHV
            // 
            LblAHV.AutoSize = true;
            LblAHV.Location = new Point(334, 176);
            LblAHV.Name = "LblAHV";
            LblAHV.Size = new Size(76, 15);
            LblAHV.TabIndex = 106;
            LblAHV.Text = "AHV number";
            // 
            // CmbStatus
            // 
            CmbStatus.FormattingEnabled = true;
            CmbStatus.Items.AddRange(new object[] { "Active", "Passive" });
            CmbStatus.Location = new Point(538, 19);
            CmbStatus.Name = "CmbStatus";
            CmbStatus.Size = new Size(73, 23);
            CmbStatus.TabIndex = 82;
            // 
            // TxtMobilePhone
            // 
            TxtMobilePhone.Location = new Point(121, 134);
            TxtMobilePhone.Name = "TxtMobilePhone";
            TxtMobilePhone.Size = new Size(199, 23);
            TxtMobilePhone.TabIndex = 92;
            // 
            // LblBusinessPhone
            // 
            LblBusinessPhone.AutoSize = true;
            LblBusinessPhone.Location = new Point(14, 176);
            LblBusinessPhone.Name = "LblBusinessPhone";
            LblBusinessPhone.Size = new Size(89, 15);
            LblBusinessPhone.TabIndex = 105;
            LblBusinessPhone.Text = "Business phone";
            // 
            // CmbTitle
            // 
            CmbTitle.FormattingEnabled = true;
            CmbTitle.Items.AddRange(new object[] { "Dr.", "Prof." });
            CmbTitle.Location = new Point(226, 17);
            CmbTitle.Name = "CmbTitle";
            CmbTitle.Size = new Size(66, 23);
            CmbTitle.TabIndex = 81;
            // 
            // CmbGender
            // 
            CmbGender.FormattingEnabled = true;
            CmbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            CmbGender.Location = new Point(392, 95);
            CmbGender.Name = "CmbGender";
            CmbGender.Size = new Size(131, 23);
            CmbGender.TabIndex = 91;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(122, 96);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(197, 23);
            dateTimePickerDateOfBirth.TabIndex = 90;
            // 
            // CmbSalutation
            // 
            CmbSalutation.FormattingEnabled = true;
            CmbSalutation.Items.AddRange(new object[] { "Ms", "Mrs", "Mr", "Mx" });
            CmbSalutation.Location = new Point(80, 17);
            CmbSalutation.Name = "CmbSalutation";
            CmbSalutation.Size = new Size(61, 23);
            CmbSalutation.TabIndex = 80;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(491, 22);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(39, 15);
            LblStatus.TabIndex = 104;
            LblStatus.Text = "Status";
            // 
            // TxtBusinessPhone
            // 
            TxtBusinessPhone.Location = new Point(121, 173);
            TxtBusinessPhone.Name = "TxtBusinessPhone";
            TxtBusinessPhone.Size = new Size(197, 23);
            TxtBusinessPhone.TabIndex = 95;
            // 
            // LblMobilePhone
            // 
            LblMobilePhone.AutoSize = true;
            LblMobilePhone.Location = new Point(14, 137);
            LblMobilePhone.Name = "LblMobilePhone";
            LblMobilePhone.Size = new Size(81, 15);
            LblMobilePhone.TabIndex = 101;
            LblMobilePhone.Text = "Mobile phone";
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(341, 99);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(45, 15);
            LblGender.TabIndex = 97;
            LblGender.Text = "Gender";
            // 
            // TxtLastname
            // 
            TxtLastname.Location = new Point(304, 54);
            TxtLastname.Name = "TxtLastname";
            TxtLastname.Size = new Size(211, 23);
            TxtLastname.TabIndex = 88;
            // 
            // LblLastname
            // 
            LblLastname.AutoSize = true;
            LblLastname.Location = new Point(233, 62);
            LblLastname.Name = "LblLastname";
            LblLastname.Size = new Size(58, 15);
            LblLastname.TabIndex = 94;
            LblLastname.Text = "Lastname";
            // 
            // TextCity
            // 
            TextCity.Location = new Point(85, 277);
            TextCity.Name = "TextCity";
            TextCity.Size = new Size(238, 23);
            TextCity.TabIndex = 103;
            // 
            // LblMailadress
            // 
            LblMailadress.AutoSize = true;
            LblMailadress.Location = new Point(334, 137);
            LblMailadress.Name = "LblMailadress";
            LblMailadress.Size = new Size(84, 15);
            LblMailadress.TabIndex = 89;
            LblMailadress.Text = "E-Mail address";
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(190, 20);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(30, 15);
            LblTitle.TabIndex = 87;
            LblTitle.Text = "Title";
            // 
            // LblDateOfBirth
            // 
            LblDateOfBirth.AutoSize = true;
            LblDateOfBirth.Location = new Point(14, 99);
            LblDateOfBirth.Name = "LblDateOfBirth";
            LblDateOfBirth.Size = new Size(73, 15);
            LblDateOfBirth.TabIndex = 85;
            LblDateOfBirth.Text = "Date of birth";
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(80, 54);
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(130, 23);
            TxtFirstname.TabIndex = 86;
            // 
            // LblFirstname
            // 
            LblFirstname.AutoSize = true;
            LblFirstname.Location = new Point(14, 62);
            LblFirstname.Name = "LblFirstname";
            LblFirstname.Size = new Size(59, 15);
            LblFirstname.TabIndex = 81;
            LblFirstname.Text = "Firstname";
            // 
            // LblSalutation
            // 
            LblSalutation.AutoSize = true;
            LblSalutation.Location = new Point(14, 20);
            LblSalutation.Name = "LblSalutation";
            LblSalutation.Size = new Size(60, 15);
            LblSalutation.TabIndex = 80;
            LblSalutation.Text = "Salutation";
            // 
            // TxtEmployeeNo
            // 
            TxtEmployeeNo.Location = new Point(133, 13);
            TxtEmployeeNo.Name = "TxtEmployeeNo";
            TxtEmployeeNo.ReadOnly = true;
            TxtEmployeeNo.Size = new Size(140, 23);
            TxtEmployeeNo.TabIndex = 1;
            // 
            // LblEmployeeNo
            // 
            LblEmployeeNo.AutoSize = true;
            LblEmployeeNo.Location = new Point(25, 16);
            LblEmployeeNo.Name = "LblEmployeeNo";
            LblEmployeeNo.Size = new Size(99, 15);
            LblEmployeeNo.TabIndex = 114;
            LblEmployeeNo.Text = "Personal Number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(710, 142);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 115;
            // 
            // PersonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(TxtEmployeeNo);
            Controls.Add(LblEmployeeNo);
            Controls.Add(PersonGroup);
            Margin = new Padding(2);
            Name = "PersonControl";
            Size = new Size(720, 361);
            PersonGroup.ResumeLayout(false);
            PersonGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public GroupBox PersonGroup;
        protected TextBox NumPostalCode;
        protected TextBox TxtMailadress;
        protected TextBox TxtPrivatePhone;
        protected Label LblPrivatePhone;
        protected ComboBox CmbNationality;
        protected Label LblPostalCode;
        protected Label LblNationality;
        protected TextBox TxtStreet;
        protected Label LblStreet;
        protected Label LblCity;
        protected TextBox TxtAHV;
        protected Label LblAHV;
        protected ComboBox CmbStatus;
        protected TextBox TxtMobilePhone;
        protected Label LblBusinessPhone;
        protected ComboBox CmbTitle;
        protected ComboBox CmbGender;
        protected DateTimePicker dateTimePickerDateOfBirth;
        protected ComboBox CmbSalutation;
        protected Label LblStatus;
        protected TextBox TxtBusinessPhone;
        protected Label LblMobilePhone;
        protected Label LblGender;
        protected TextBox TxtLastname;
        protected Label LblLastname;
        protected TextBox TextCity;
        protected Label LblMailadress;
        protected Label LblTitle;
        protected Label LblDateOfBirth;
        protected TextBox TxtFirstname;
        protected Label LblFirstname;
        protected Label LblSalutation;
        protected TextBox TxtEmployeeNo;
        protected Label LblEmployeeNo;
        private DateTimePicker dateTimePicker1;
    }
}
