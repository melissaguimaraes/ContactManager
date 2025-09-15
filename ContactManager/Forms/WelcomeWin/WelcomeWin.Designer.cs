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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeWin));
            lblTitle = new Label();
            lblUserNameTitle = new Label();
            txtUser = new TextBox();
            lblPassTitle = new Label();
            txtPass = new TextBox();
            chkShow = new CheckBox();
            btnLogin = new Button();
            lblError = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ActiveCaption;
            lblTitle.Location = new Point(339, 119);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(349, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Manager";
            // 
            // lblUserNameTitle
            // 
            lblUserNameTitle.AutoSize = true;
            lblUserNameTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserNameTitle.ForeColor = SystemColors.ControlDarkDark;
            lblUserNameTitle.Location = new Point(32, 304);
            lblUserNameTitle.Name = "lblUserNameTitle";
            lblUserNameTitle.Size = new Size(91, 21);
            lblUserNameTitle.TabIndex = 1;
            lblUserNameTitle.Text = "User name";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(32, 328);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(112, 23);
            txtUser.TabIndex = 2;
            // 
            // lblPassTitle
            // 
            lblPassTitle.AutoSize = true;
            lblPassTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassTitle.ForeColor = SystemColors.ControlDarkDark;
            lblPassTitle.Location = new Point(32, 360);
            lblPassTitle.Name = "lblPassTitle";
            lblPassTitle.Size = new Size(82, 21);
            lblPassTitle.TabIndex = 3;
            lblPassTitle.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(32, 385);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(112, 23);
            txtPass.TabIndex = 4;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkShow.ForeColor = SystemColors.ControlDark;
            chkShow.Location = new Point(162, 389);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(112, 19);
            chkShow.TabIndex = 5;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged_1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ControlDarkDark;
            btnLogin.Location = new Point(324, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 30);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // WelcomeWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 457);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(chkShow);
            Controls.Add(txtPass);
            Controls.Add(lblPassTitle);
            Controls.Add(txtUser);
            Controls.Add(lblUserNameTitle);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "WelcomeWin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}