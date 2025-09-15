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
            listViewHistory.Location = new Point(14, 49);
            listViewHistory.Margin = new Padding(3, 4, 3, 4);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(861, 497);
            listViewHistory.TabIndex = 1;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            // 
            // HistoryWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listViewHistory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HistoryWin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contact History";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewHistory;
    }
}