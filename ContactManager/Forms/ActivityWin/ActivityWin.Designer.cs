namespace ContactManager.Forms.ActivityWin
{
    partial class ActivityWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityWin));
            TxtCmntField = new TextBox();
            BtnSaveCmnt = new Button();
            activityCommentBindingSource = new BindingSource(components);
            activityCommentBindingSource1 = new BindingSource(components);
            activityCommentBindingSource2 = new BindingSource(components);
            contactBindingSource = new BindingSource(components);
            activityCommentBindingSource3 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            timestampDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtCmntField
            // 
            TxtCmntField.BorderStyle = BorderStyle.FixedSingle;
            TxtCmntField.Location = new Point(47, 35);
            TxtCmntField.Margin = new Padding(4, 5, 4, 5);
            TxtCmntField.Multiline = true;
            TxtCmntField.Name = "TxtCmntField";
            TxtCmntField.Size = new Size(1050, 207);
            TxtCmntField.TabIndex = 0;
            // 
            // BtnSaveCmnt
            // 
            BtnSaveCmnt.Location = new Point(991, 270);
            BtnSaveCmnt.Margin = new Padding(4, 5, 4, 5);
            BtnSaveCmnt.Name = "BtnSaveCmnt";
            BtnSaveCmnt.Size = new Size(107, 38);
            BtnSaveCmnt.TabIndex = 1;
            BtnSaveCmnt.Text = "Save";
            BtnSaveCmnt.UseVisualStyleBackColor = true;
            BtnSaveCmnt.Click += BtnSaveCmnt_Click;
            // 
            // activityCommentBindingSource
            // 
            activityCommentBindingSource.DataSource = typeof(Models.ActivityComment);
            // 
            // activityCommentBindingSource1
            // 
            activityCommentBindingSource1.DataSource = typeof(Models.ActivityComment);
            // 
            // activityCommentBindingSource2
            // 
            activityCommentBindingSource2.DataSource = typeof(Models.ActivityComment);
            // 
            // contactBindingSource
            // 
            contactBindingSource.DataSource = typeof(Models.Person);
            // 
            // activityCommentBindingSource3
            // 
            activityCommentBindingSource3.DataSource = typeof(Models.ActivityComment);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { timestampDataGridViewTextBoxColumn, commentorDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn });
            dataGridView1.DataSource = activityCommentBindingSource;
            dataGridView1.Location = new Point(47, 335);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1051, 395);
            dataGridView1.TabIndex = 2;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            timestampDataGridViewTextBoxColumn.MinimumWidth = 8;
            timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            timestampDataGridViewTextBoxColumn.ReadOnly = true;
            timestampDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentorDataGridViewTextBoxColumn
            // 
            commentorDataGridViewTextBoxColumn.DataPropertyName = "Commentor";
            commentorDataGridViewTextBoxColumn.HeaderText = "Commentor";
            commentorDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentorDataGridViewTextBoxColumn.Name = "commentorDataGridViewTextBoxColumn";
            commentorDataGridViewTextBoxColumn.ReadOnly = true;
            commentorDataGridViewTextBoxColumn.Width = 200;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 637;
            // 
            // ActivityWin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSaveCmnt);
            Controls.Add(TxtCmntField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ActivityWin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ActivityWin";
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityCommentBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCmntField;
        private Button BtnSaveCmnt;
        private BindingSource activityCommentBindingSource;
        private BindingSource activityCommentBindingSource1;
        private BindingSource activityCommentBindingSource2;
        private BindingSource contactBindingSource;
        private BindingSource activityCommentBindingSource3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}