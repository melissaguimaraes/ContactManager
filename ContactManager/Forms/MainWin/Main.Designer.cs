namespace ContactManager.MainWin
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            SearchByTextBox = new TextBox();
            searchLbl = new Label();
            SearchBox = new GroupBox();
            BtnClearFilter = new Button();
            ChkCustomerFilter = new CheckBox();
            ChkTraineeFilter = new CheckBox();
            ChkEmployeeFilter = new CheckBox();
            BtnLogout = new Button();
            ShowContactButton = new Button();
            SearcByTxtBox = new TextBox();
            searchLabel = new Label();
            contactListBox = new GroupBox();
            gridViewContactList = new DataGridView();
            personalNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salutationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            businessPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            privatePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ahvNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nationalityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postalCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            BtnAddNewContact = new Button();
            SearchBox.SuspendLayout();
            contactListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SearchByTextBox
            // 
            SearchByTextBox.Location = new Point(0, 0);
            SearchByTextBox.Name = "SearchByTextBox";
            SearchByTextBox.Size = new Size(100, 31);
            SearchByTextBox.TabIndex = 0;
            // 
            // searchLbl
            // 
            searchLbl.Location = new Point(0, 0);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(100, 23);
            searchLbl.TabIndex = 0;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.FromArgb(27, 38, 59);
            SearchBox.Controls.Add(BtnClearFilter);
            SearchBox.Controls.Add(ChkCustomerFilter);
            SearchBox.Controls.Add(ChkTraineeFilter);
            SearchBox.Controls.Add(ChkEmployeeFilter);
            SearchBox.Controls.Add(BtnLogout);
            SearchBox.Controls.Add(ShowContactButton);
            SearchBox.Controls.Add(SearcByTxtBox);
            SearchBox.Controls.Add(searchLabel);
            SearchBox.Location = new Point(21, 25);
            SearchBox.Margin = new Padding(4, 3, 4, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Padding = new Padding(4, 3, 4, 3);
            SearchBox.Size = new Size(1521, 219);
            SearchBox.TabIndex = 0;
            SearchBox.TabStop = false;
            // 
            // BtnClearFilter
            // 
            BtnClearFilter.BackColor = Color.FromArgb(119, 141, 169);
            BtnClearFilter.ForeColor = Color.White;
            BtnClearFilter.Location = new Point(937, 97);
            BtnClearFilter.Name = "BtnClearFilter";
            BtnClearFilter.Size = new Size(70, 34);
            BtnClearFilter.TabIndex = 6;
            BtnClearFilter.Text = "Clear";
            BtnClearFilter.UseVisualStyleBackColor = false;
            BtnClearFilter.Click += BtnClearFilter_Click;
            // 
            // ChkCustomerFilter
            // 
            ChkCustomerFilter.AutoSize = true;
            ChkCustomerFilter.Checked = true;
            ChkCustomerFilter.CheckState = CheckState.Checked;
            ChkCustomerFilter.ForeColor = Color.White;
            ChkCustomerFilter.Location = new Point(254, 167);
            ChkCustomerFilter.Name = "ChkCustomerFilter";
            ChkCustomerFilter.Size = new Size(115, 29);
            ChkCustomerFilter.TabIndex = 5;
            ChkCustomerFilter.Text = "Customer";
            ChkCustomerFilter.UseVisualStyleBackColor = true;
            ChkCustomerFilter.CheckedChanged += Filters_CheckedChanged;
            // 
            // ChkTraineeFilter
            // 
            ChkTraineeFilter.AutoSize = true;
            ChkTraineeFilter.Checked = true;
            ChkTraineeFilter.CheckState = CheckState.Checked;
            ChkTraineeFilter.ForeColor = Color.White;
            ChkTraineeFilter.Location = new Point(152, 167);
            ChkTraineeFilter.Name = "ChkTraineeFilter";
            ChkTraineeFilter.Size = new Size(92, 29);
            ChkTraineeFilter.TabIndex = 4;
            ChkTraineeFilter.Text = "Trainee";
            ChkTraineeFilter.UseVisualStyleBackColor = true;
            ChkTraineeFilter.CheckedChanged += Filters_CheckedChanged;
            // 
            // ChkEmployeeFilter
            // 
            ChkEmployeeFilter.AutoSize = true;
            ChkEmployeeFilter.Checked = true;
            ChkEmployeeFilter.CheckState = CheckState.Checked;
            ChkEmployeeFilter.ForeColor = Color.White;
            ChkEmployeeFilter.Location = new Point(30, 167);
            ChkEmployeeFilter.Name = "ChkEmployeeFilter";
            ChkEmployeeFilter.Size = new Size(116, 29);
            ChkEmployeeFilter.TabIndex = 3;
            ChkEmployeeFilter.Text = "Employee";
            ChkEmployeeFilter.UseVisualStyleBackColor = true;
            ChkEmployeeFilter.CheckedChanged += Filters_CheckedChanged;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.FromArgb(119, 141, 169);
            BtnLogout.ForeColor = Color.White;
            BtnLogout.Location = new Point(1406, 18);
            BtnLogout.Margin = new Padding(4, 5, 4, 5);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(107, 38);
            BtnLogout.TabIndex = 3;
            BtnLogout.Text = "Logout";
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // ShowContactButton
            // 
            ShowContactButton.BackColor = Color.FromArgb(119, 141, 169);
            ShowContactButton.ForeColor = Color.White;
            ShowContactButton.Location = new Point(783, 134);
            ShowContactButton.Margin = new Padding(4, 3, 4, 3);
            ShowContactButton.Name = "ShowContactButton";
            ShowContactButton.Size = new Size(147, 37);
            ShowContactButton.TabIndex = 2;
            ShowContactButton.Text = "Show Contacts";
            ShowContactButton.UseVisualStyleBackColor = false;
            ShowContactButton.Click += ShowContactButton_Click;
            // 
            // SearcByTxtBox
            // 
            SearcByTxtBox.Location = new Point(30, 97);
            SearcByTxtBox.Margin = new Padding(4, 3, 4, 3);
            SearcByTxtBox.Name = "SearcByTxtBox";
            SearcByTxtBox.Size = new Size(900, 31);
            SearcByTxtBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.ForeColor = Color.White;
            searchLabel.Location = new Point(30, 63);
            searchLabel.Margin = new Padding(4, 0, 4, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(145, 30);
            searchLabel.TabIndex = 0;
            searchLabel.Tag = "Search Contact";
            searchLabel.Text = "Search Contacts";
            searchLabel.UseCompatibleTextRendering = true;
            // 
            // contactListBox
            // 
            contactListBox.Controls.Add(gridViewContactList);
            contactListBox.ForeColor = Color.Black;
            contactListBox.Location = new Point(21, 250);
            contactListBox.Margin = new Padding(4, 3, 4, 3);
            contactListBox.Name = "contactListBox";
            contactListBox.Padding = new Padding(4, 3, 4, 3);
            contactListBox.Size = new Size(1523, 763);
            contactListBox.TabIndex = 1;
            contactListBox.TabStop = false;
            // 
            // gridViewContactList
            // 
            gridViewContactList.AllowUserToAddRows = false;
            gridViewContactList.AllowUserToDeleteRows = false;
            gridViewContactList.AutoGenerateColumns = false;
            gridViewContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewContactList.BackgroundColor = Color.White;
            gridViewContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewContactList.Columns.AddRange(new DataGridViewColumn[] { personalNumberDataGridViewTextBoxColumn, salutationDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, businessPhoneDataGridViewTextBoxColumn, mobilePhoneDataGridViewTextBoxColumn, privatePhoneDataGridViewTextBoxColumn, emailAddressDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn, ahvNumberDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, nationalityDataGridViewTextBoxColumn, streetDataGridViewTextBoxColumn, postalCodeDataGridViewTextBoxColumn });
            gridViewContactList.DataSource = personBindingSource;
            gridViewContactList.Dock = DockStyle.Fill;
            gridViewContactList.GridColor = Color.Black;
            gridViewContactList.Location = new Point(4, 27);
            gridViewContactList.Margin = new Padding(4, 3, 4, 3);
            gridViewContactList.Name = "gridViewContactList";
            gridViewContactList.ReadOnly = true;
            gridViewContactList.RowHeadersWidth = 51;
            gridViewContactList.Size = new Size(1515, 733);
            gridViewContactList.TabIndex = 0;
            // 
            // personalNumberDataGridViewTextBoxColumn
            // 
            personalNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonalNumber";
            personalNumberDataGridViewTextBoxColumn.HeaderText = "PersonalNumber";
            personalNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            personalNumberDataGridViewTextBoxColumn.Name = "personalNumberDataGridViewTextBoxColumn";
            personalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            personalNumberDataGridViewTextBoxColumn.Width = 179;
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            salutationDataGridViewTextBoxColumn.MinimumWidth = 8;
            salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            salutationDataGridViewTextBoxColumn.ReadOnly = true;
            salutationDataGridViewTextBoxColumn.Width = 127;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 128;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 126;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfBirthDataGridViewTextBoxColumn.Width = 141;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 105;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 80;
            // 
            // businessPhoneDataGridViewTextBoxColumn
            // 
            businessPhoneDataGridViewTextBoxColumn.DataPropertyName = "BusinessPhone";
            businessPhoneDataGridViewTextBoxColumn.HeaderText = "BusinessPhone";
            businessPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            businessPhoneDataGridViewTextBoxColumn.Name = "businessPhoneDataGridViewTextBoxColumn";
            businessPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            businessPhoneDataGridViewTextBoxColumn.Width = 165;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.HeaderText = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            mobilePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            mobilePhoneDataGridViewTextBoxColumn.Width = 153;
            // 
            // privatePhoneDataGridViewTextBoxColumn
            // 
            privatePhoneDataGridViewTextBoxColumn.DataPropertyName = "PrivatePhone";
            privatePhoneDataGridViewTextBoxColumn.HeaderText = "PrivatePhone";
            privatePhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            privatePhoneDataGridViewTextBoxColumn.Name = "privatePhoneDataGridViewTextBoxColumn";
            privatePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            privatePhoneDataGridViewTextBoxColumn.Width = 151;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            emailAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            emailAddressDataGridViewTextBoxColumn.Width = 155;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            statusDataGridViewCheckBoxColumn.MinimumWidth = 8;
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.ReadOnly = true;
            statusDataGridViewCheckBoxColumn.Width = 66;
            // 
            // ahvNumberDataGridViewTextBoxColumn
            // 
            ahvNumberDataGridViewTextBoxColumn.DataPropertyName = "AhvNumber";
            ahvNumberDataGridViewTextBoxColumn.HeaderText = "AhvNumber";
            ahvNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            ahvNumberDataGridViewTextBoxColumn.Name = "ahvNumberDataGridViewTextBoxColumn";
            ahvNumberDataGridViewTextBoxColumn.ReadOnly = true;
            ahvNumberDataGridViewTextBoxColumn.Width = 144;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 78;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            nationalityDataGridViewTextBoxColumn.MinimumWidth = 8;
            nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            nationalityDataGridViewTextBoxColumn.Width = 133;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            streetDataGridViewTextBoxColumn.HeaderText = "Street";
            streetDataGridViewTextBoxColumn.MinimumWidth = 8;
            streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            streetDataGridViewTextBoxColumn.ReadOnly = true;
            streetDataGridViewTextBoxColumn.Width = 93;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            postalCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            postalCodeDataGridViewTextBoxColumn.Width = 137;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Models.Person);
            // 
            // BtnAddNewContact
            // 
            BtnAddNewContact.BackColor = Color.FromArgb(119, 141, 169);
            BtnAddNewContact.ForeColor = Color.White;
            BtnAddNewContact.Location = new Point(1379, 1065);
            BtnAddNewContact.Margin = new Padding(4, 5, 4, 5);
            BtnAddNewContact.Name = "BtnAddNewContact";
            BtnAddNewContact.Size = new Size(161, 38);
            BtnAddNewContact.TabIndex = 2;
            BtnAddNewContact.Text = "Add new contact";
            BtnAddNewContact.UseVisualStyleBackColor = false;
            BtnAddNewContact.Click += BtnAddNewContact_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 59);
            ClientSize = new Size(1579, 1140);
            Controls.Add(BtnAddNewContact);
            Controls.Add(contactListBox);
            Controls.Add(SearchBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Manager";
            SearchBox.ResumeLayout(false);
            SearchBox.PerformLayout();
            contactListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridViewContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label searchLbl;
        private TextBox SearchByTextBox;
        private GroupBox SearchBox;
        private TextBox SearcByTxtBox;
        private Label searchLabel;
        private Button ShowContactButton;
        private GroupBox contactListBox;
        private DataGridView gridViewContactList;
        private Button BtnAddNewContact;
        private Button BtnLogout;
        private DataGridViewTextBoxColumn personalNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn businessPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn privatePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ahvNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private BindingSource personBindingSource;
        private CheckBox ChkEmployeeFilter;
        private CheckBox ChkCustomerFilter;
        private CheckBox ChkTraineeFilter;
        private Button BtnClearFilter;
    }
}