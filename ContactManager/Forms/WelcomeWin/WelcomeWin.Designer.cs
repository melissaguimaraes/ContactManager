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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(68, 44);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(693, 106);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Manager";
            // 
            // lblUserNameTitle
            // 
            lblUserNameTitle.AutoSize = true;
            lblUserNameTitle.ForeColor = Color.White;
            lblUserNameTitle.Location = new Point(68, 291);
            lblUserNameTitle.Margin = new Padding(4, 0, 4, 0);
            lblUserNameTitle.Name = "lblUserNameTitle";
            lblUserNameTitle.Size = new Size(96, 25);
            lblUserNameTitle.TabIndex = 1;
            lblUserNameTitle.Text = "User name";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(68, 321);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(142, 31);
            txtUser.TabIndex = 2;
            // 
            // lblPassTitle
            // 
            lblPassTitle.AutoSize = true;
            lblPassTitle.ForeColor = Color.White;
            lblPassTitle.Location = new Point(68, 399);
            lblPassTitle.Margin = new Padding(4, 0, 4, 0);
            lblPassTitle.Name = "lblPassTitle";
            lblPassTitle.Size = new Size(87, 25);
            lblPassTitle.TabIndex = 3;
            lblPassTitle.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(68, 429);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(142, 31);
            txtPass.TabIndex = 4;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.ForeColor = Color.White;
            chkShow.Location = new Point(237, 431);
            chkShow.Margin = new Padding(4, 5, 4, 5);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(164, 29);
            chkShow.TabIndex = 5;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(119, 141, 169);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(68, 535);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(369, 545);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(768, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(795, 716);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 9;
            label1.Text = "by Kyra und Melissa™";
            // 
            // WelcomeWin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 38, 59);
            ClientSize = new Size(991, 750);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(chkShow);
            Controls.Add(txtPass);
            Controls.Add(lblPassTitle);
            Controls.Add(txtUser);
            Controls.Add(lblUserNameTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
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
        private Label label1;
    }
}