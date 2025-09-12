namespace ContactManager.HistoryWin
{
    partial class HistoryWin
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
            listViewHistory = new ListView();
            SuspendLayout();
            // 
            // listViewHistory
            // 
            listViewHistory.Location = new Point(12, 37);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(754, 374);
            listViewHistory.TabIndex = 1;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.SelectedIndexChanged += listViewHistory_SelectedIndexChanged;
            // 
            // HistoryWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewHistory);
            Name = "HistoryWin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewHistory;
    }
}