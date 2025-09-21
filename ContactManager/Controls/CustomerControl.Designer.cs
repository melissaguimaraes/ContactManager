namespace ContactManager.Controls
{
    partial class CustomerControl
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
            components = new System.ComponentModel.Container();
            CustomerGroup = new GroupBox();
            CmbCustomerType = new ComboBox();
            CmbCompanyContact = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            LblCompanyContact = new Label();
            TxtCompanyName = new TextBox();
            LblCompanyName = new Label();
            LblCustomerType = new Label();
            CustomerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CustomerGroup
            // 
            CustomerGroup.Controls.Add(CmbCustomerType);
            CustomerGroup.Controls.Add(CmbCompanyContact);
            CustomerGroup.Controls.Add(LblCompanyContact);
            CustomerGroup.Controls.Add(TxtCompanyName);
            CustomerGroup.Controls.Add(LblCompanyName);
            CustomerGroup.Controls.Add(LblCustomerType);
            CustomerGroup.Font = new Font("Segoe UI", 9F);
            CustomerGroup.Location = new Point(15, 15);
            CustomerGroup.Margin = new Padding(4);
            CustomerGroup.Name = "CustomerGroup";
            CustomerGroup.Padding = new Padding(4);
            CustomerGroup.Size = new Size(874, 144);
            CustomerGroup.TabIndex = 106;
            CustomerGroup.TabStop = false;
            CustomerGroup.Text = "Customer Info";
            // 
            // CmbCustomerType
            // 
            CmbCustomerType.FormattingEnabled = true;
            CmbCustomerType.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            CmbCustomerType.Location = new Point(169, 46);
            CmbCustomerType.Margin = new Padding(4, 5, 4, 5);
            CmbCustomerType.Name = "CmbCustomerType";
            CmbCustomerType.Size = new Size(48, 33);
            CmbCustomerType.TabIndex = 5;
            // 
            // CmbCompanyContact
            // 
            CmbCompanyContact.DataSource = employeeBindingSource;
            CmbCompanyContact.DisplayMember = "FullName";
            CmbCompanyContact.FormattingEnabled = true;
            CmbCompanyContact.Location = new Point(647, 95);
            CmbCompanyContact.Margin = new Padding(4, 5, 4, 5);
            CmbCompanyContact.Name = "CmbCompanyContact";
            CmbCompanyContact.Size = new Size(198, 33);
            CmbCompanyContact.TabIndex = 23;
            CmbCompanyContact.ValueMember = "PersonalNumber";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // LblCompanyContact
            // 
            LblCompanyContact.AutoSize = true;
            LblCompanyContact.Location = new Point(489, 96);
            LblCompanyContact.Margin = new Padding(4, 0, 4, 0);
            LblCompanyContact.Name = "LblCompanyContact";
            LblCompanyContact.Size = new Size(155, 25);
            LblCompanyContact.TabIndex = 73;
            LblCompanyContact.Text = "Company Contact";
            // 
            // TxtCompanyName
            // 
            TxtCompanyName.Location = new Point(169, 102);
            TxtCompanyName.Margin = new Padding(4, 5, 4, 5);
            TxtCompanyName.Name = "TxtCompanyName";
            TxtCompanyName.Size = new Size(198, 31);
            TxtCompanyName.TabIndex = 19;
            // 
            // LblCompanyName
            // 
            LblCompanyName.AutoSize = true;
            LblCompanyName.Location = new Point(12, 103);
            LblCompanyName.Margin = new Padding(4, 0, 4, 0);
            LblCompanyName.Name = "LblCompanyName";
            LblCompanyName.Size = new Size(141, 25);
            LblCompanyName.TabIndex = 68;
            LblCompanyName.Text = "Company Name";
            // 
            // LblCustomerType
            // 
            LblCustomerType.AutoSize = true;
            LblCustomerType.Location = new Point(16, 49);
            LblCustomerType.Margin = new Padding(4, 0, 4, 0);
            LblCustomerType.Name = "LblCustomerType";
            LblCustomerType.Size = new Size(131, 25);
            LblCustomerType.TabIndex = 66;
            LblCustomerType.Text = "Customer Type";
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerGroup);
            Name = "CustomerControl";
            Size = new Size(1028, 167);
            CustomerGroup.ResumeLayout(false);
            CustomerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomerGroup;
        protected ComboBox CmbCustomerType;
        protected ComboBox CmbCompanyContact;
        protected Label LblCompanyContact;
        protected TextBox TxtCompanyName;
        protected Label LblCompanyName;
        protected Label LblCustomerType;
        private BindingSource employeeBindingSource;
    }
}
