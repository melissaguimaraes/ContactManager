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
            TxtCmntField.Location = new Point(33, 21);
            TxtCmntField.Multiline = true;
            TxtCmntField.Name = "TxtCmntField";
            TxtCmntField.Size = new Size(736, 126);
            TxtCmntField.TabIndex = 0;
            // 
            // BtnSaveCmnt
            // 
            BtnSaveCmnt.Location = new Point(694, 162);
            BtnSaveCmnt.Name = "BtnSaveCmnt";
            BtnSaveCmnt.Size = new Size(75, 23);
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
            dataGridView1.Location = new Point(33, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(736, 237);
            dataGridView1.TabIndex = 2;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            timestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentorDataGridViewTextBoxColumn
            // 
            commentorDataGridViewTextBoxColumn.DataPropertyName = "Commentor";
            commentorDataGridViewTextBoxColumn.HeaderText = "Commentor";
            commentorDataGridViewTextBoxColumn.Name = "commentorDataGridViewTextBoxColumn";
            commentorDataGridViewTextBoxColumn.ReadOnly = true;
            commentorDataGridViewTextBoxColumn.Width = 200;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 393;
            // 
            // ActivityWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSaveCmnt);
            Controls.Add(TxtCmntField);
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