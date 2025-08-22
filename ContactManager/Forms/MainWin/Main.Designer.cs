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
            FilterBox = new ComboBox();
            filterLbl = new Label();
            ShowContactButton = new Button();
            SearcByTxtBox = new TextBox();
            searchLabel = new Label();
            contactListBox = new GroupBox();
            gridViewContactList = new DataGridView();
            SearchBox.SuspendLayout();
            contactListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewContactList).BeginInit();
            SuspendLayout();
            // 
            // SearchByTextBox
            // 
            SearchByTextBox.Location = new Point(0, 0);
            SearchByTextBox.Name = "SearchByTextBox";
            SearchByTextBox.Size = new Size(100, 27);
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
            SearchBox.Controls.Add(FilterBox);
            SearchBox.Controls.Add(filterLbl);
            SearchBox.Controls.Add(ShowContactButton);
            SearchBox.Controls.Add(SearcByTxtBox);
            SearchBox.Controls.Add(searchLabel);
            SearchBox.Location = new Point(17, 20);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(1217, 214);
            SearchBox.TabIndex = 0;
            SearchBox.TabStop = false;
            SearchBox.Text = "Search ";
            // 
            // FilterBox
            // 
            FilterBox.FormattingEnabled = true;
            FilterBox.Location = new Point(24, 151);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(202, 28);
            FilterBox.TabIndex = 4;
            // 
            // filterLbl
            // 
            filterLbl.AutoSize = true;
            filterLbl.Location = new Point(24, 128);
            filterLbl.Name = "filterLbl";
            filterLbl.Size = new Size(42, 20);
            filterLbl.TabIndex = 3;
            filterLbl.Text = "Filter";
            // 
            // ShowContactButton
            // 
            ShowContactButton.Location = new Point(836, 76);
            ShowContactButton.Name = "ShowContactButton";
            ShowContactButton.Size = new Size(139, 30);
            ShowContactButton.TabIndex = 2;
            ShowContactButton.Text = "Show Contact";
            ShowContactButton.UseVisualStyleBackColor = true;
            ShowContactButton.Click += ShowContactButton_Click;
            // 
            // SearcByTxtBox
            // 
            SearcByTxtBox.Location = new Point(24, 78);
            SearcByTxtBox.Name = "SearcByTxtBox";
            SearcByTxtBox.Size = new Size(721, 27);
            SearcByTxtBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(24, 50);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(55, 25);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Search ";
            searchLabel.UseCompatibleTextRendering = true;
            // 
            // contactListBox
            // 
            contactListBox.Controls.Add(gridViewContactList);
            contactListBox.Location = new Point(17, 244);
            contactListBox.Name = "contactListBox";
            contactListBox.Size = new Size(1218, 566);
            contactListBox.TabIndex = 1;
            contactListBox.TabStop = false;
            contactListBox.Text = "Contact List";
            // 
            // gridViewContactList
            // 
            gridViewContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewContactList.Dock = DockStyle.Fill;
            gridViewContactList.Location = new Point(3, 23);
            gridViewContactList.Name = "gridViewContactList";
            gridViewContactList.RowHeadersWidth = 51;
            gridViewContactList.Size = new Size(1212, 540);
            gridViewContactList.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 912);
            Controls.Add(contactListBox);
            Controls.Add(SearchBox);
            Name = "Main";
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
        private ComboBox FilterBox;
        private Label filterLbl;
        private Button ShowContactButton;
        private GroupBox contactListBox;
        private DataGridView gridViewContactList;
    }
}