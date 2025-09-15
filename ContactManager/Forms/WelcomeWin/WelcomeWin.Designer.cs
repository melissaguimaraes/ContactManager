namespace ContactManager
{
    public partial class WelcomeWin : Form
    {

        //required designer variable

        private System.ComponentModel.IContainer components = null;


        //clean up any resources being used

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

        //required method for Designer support - do not modify
        //the contents of this method with the code editor
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUserNameTitle = new Label();
            txtUser = new TextBox();
            lblPassTitle = new Label();
            txtPass = new TextBox();
            chkShow = new CheckBox();
            btnLogin = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(312, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Manager";
            // 
            // lblUserNameTitle
            // 
            lblUserNameTitle.AutoSize = true;
            lblUserNameTitle.Location = new Point(47, 301);
            lblUserNameTitle.Name = "lblUserNameTitle";
            lblUserNameTitle.Size = new Size(79, 20);
            lblUserNameTitle.TabIndex = 1;
            lblUserNameTitle.Text = "User name";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(47, 325);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(114, 27);
            txtUser.TabIndex = 2;
            // 
            // lblPassTitle
            // 
            lblPassTitle.AutoSize = true;
            lblPassTitle.Location = new Point(47, 387);
            lblPassTitle.Name = "lblPassTitle";
            lblPassTitle.Size = new Size(70, 20);
            lblPassTitle.TabIndex = 3;
            lblPassTitle.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(47, 411);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(114, 27);
            txtPass.TabIndex = 4;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(168, 416);
            chkShow.Margin = new Padding(3, 4, 3, 4);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(134, 24);
            chkShow.TabIndex = 5;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged_1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(47, 496);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(288, 504);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 7;
            // 
            // WelcomeWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(chkShow);
            Controls.Add(txtPass);
            Controls.Add(lblPassTitle);
            Controls.Add(txtUser);
            Controls.Add(lblUserNameTitle);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WelcomeWin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUserNameTitle;
        private TextBox txtUser;
        private Label lblPassTitle;
        private TextBox txtPass;
        private CheckBox chkShow;
        private Button btnLogin;
        private Label lblError;
    }
}