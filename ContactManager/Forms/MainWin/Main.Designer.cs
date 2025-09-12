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
            SearchByTextBox = new TextBox();
            searchLbl = new Label();
            SearchBox = new GroupBox();
            ShowContactButton = new Button();
            SearcByTxtBox = new TextBox();
            searchLabel = new Label();
            contactListBox = new GroupBox();
            gridViewContactList = new DataGridView();
            BtnAddNewContact = new Button();
            SearchBox.SuspendLayout();
            contactListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewContactList).BeginInit();
            SuspendLayout();
            // 
            // SearchByTextBox
            // 
            SearchByTextBox.Location = new Point(0, 0);
            SearchByTextBox.Name = "SearchByTextBox";
            SearchByTextBox.Size = new Size(100, 23);
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
            SearchBox.Controls.Add(ShowContactButton);
            SearchBox.Controls.Add(SearcByTxtBox);
            SearchBox.Controls.Add(searchLabel);
            SearchBox.Location = new Point(15, 15);
            SearchBox.Margin = new Padding(3, 2, 3, 2);
            SearchBox.Name = "SearchBox";
            SearchBox.Padding = new Padding(3, 2, 3, 2);
            SearchBox.Size = new Size(1065, 118);
            SearchBox.TabIndex = 0;
            SearchBox.TabStop = false;
            // 
            // ShowContactButton
            // 
            ShowContactButton.Location = new Point(732, 57);
            ShowContactButton.Margin = new Padding(3, 2, 3, 2);
            ShowContactButton.Name = "ShowContactButton";
            ShowContactButton.Size = new Size(122, 22);
            ShowContactButton.TabIndex = 2;
            ShowContactButton.Text = "Show Contacts";
            ShowContactButton.UseVisualStyleBackColor = true;
            ShowContactButton.Click += ShowContactButton_Click;
            // 
            // SearcByTxtBox
            // 
            SearcByTxtBox.Location = new Point(21, 58);
            SearcByTxtBox.Margin = new Padding(3, 2, 3, 2);
            SearcByTxtBox.Name = "SearcByTxtBox";
            SearcByTxtBox.Size = new Size(631, 23);
            SearcByTxtBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(21, 38);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(92, 21);
            searchLabel.TabIndex = 0;
            searchLabel.Tag = "Search Contact";
            searchLabel.Text = "Search Contacts";
            searchLabel.UseCompatibleTextRendering = true;
            // 
            // contactListBox
            // 
            contactListBox.Controls.Add(gridViewContactList);
            contactListBox.Location = new Point(15, 150);
            contactListBox.Margin = new Padding(3, 2, 3, 2);
            contactListBox.Name = "contactListBox";
            contactListBox.Padding = new Padding(3, 2, 3, 2);
            contactListBox.Size = new Size(1066, 458);
            contactListBox.TabIndex = 1;
            contactListBox.TabStop = false;
            contactListBox.Text = "Contact List";
            // 
            // gridViewContactList
            // 
            gridViewContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewContactList.Dock = DockStyle.Fill;
            gridViewContactList.Location = new Point(3, 18);
            gridViewContactList.Margin = new Padding(3, 2, 3, 2);
            gridViewContactList.Name = "gridViewContactList";
            gridViewContactList.RowHeadersWidth = 51;
            gridViewContactList.Size = new Size(1060, 438);
            gridViewContactList.TabIndex = 0;
            gridViewContactList.CellContentClick += gridViewContactList_CellContentClick;
            // 
            // BtnAddNewContact
            // 
            BtnAddNewContact.Location = new Point(965, 639);
            BtnAddNewContact.Name = "BtnAddNewContact";
            BtnAddNewContact.Size = new Size(113, 23);
            BtnAddNewContact.TabIndex = 2;
            BtnAddNewContact.Text = "Add new contact";
            BtnAddNewContact.UseVisualStyleBackColor = true;
            BtnAddNewContact.Click += BtnAddNewContact_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 684);
            Controls.Add(BtnAddNewContact);
            Controls.Add(contactListBox);
            Controls.Add(SearchBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Manager";
            SearchBox.ResumeLayout(false);
            SearchBox.PerformLayout();
            contactListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridViewContactList).EndInit();
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
    }
}