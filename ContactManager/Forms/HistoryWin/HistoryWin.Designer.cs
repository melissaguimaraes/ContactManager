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
            listViewHistory.Location = new Point(18, 61);
            listViewHistory.Margin = new Padding(4, 5, 4, 5);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(1075, 620);
            listViewHistory.TabIndex = 1;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            // 
            // HistoryWin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(listViewHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "HistoryWin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contact History";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewHistory;
    }
}