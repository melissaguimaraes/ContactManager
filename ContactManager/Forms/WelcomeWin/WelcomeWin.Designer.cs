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
            lblTitle.Location = new Point(273, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Manager";
            // 
            // lblUserNameTitle
            // 
            lblUserNameTitle.AutoSize = true;
            lblUserNameTitle.Location = new Point(41, 226);
            lblUserNameTitle.Name = "lblUserNameTitle";
            lblUserNameTitle.Size = new Size(63, 15);
            lblUserNameTitle.TabIndex = 1;
            lblUserNameTitle.Text = "User name";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(41, 244);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 2;
            // 
            // lblPassTitle
            // 
            lblPassTitle.AutoSize = true;
            lblPassTitle.Location = new Point(41, 290);
            lblPassTitle.Name = "lblPassTitle";
            lblPassTitle.Size = new Size(57, 15);
            lblPassTitle.TabIndex = 3;
            lblPassTitle.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(41, 308);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(147, 312);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(108, 19);
            chkShow.TabIndex = 5;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(41, 372);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(252, 378);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 7;
            // 
            // WelcomeWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(chkShow);
            Controls.Add(txtPass);
            Controls.Add(lblPassTitle);
            Controls.Add(txtUser);
            Controls.Add(lblUserNameTitle);
            Controls.Add(lblTitle);
            Name = "WelcomeWin";
            Text = "Form1";
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