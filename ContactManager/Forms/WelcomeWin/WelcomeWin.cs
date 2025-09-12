using ContactManager;
using ContactManager.MainWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class WelcomeWin : Form
    {
        public WelcomeWin()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;

            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            var user = txtUser.Text.Trim();
            var pass = txtPass.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                lblError.Text = "Please enter your Login credentials!";
                return;
            }

            if (AuthService.Validate(user, pass))
            {

                // when userlogin valid it redirects to mainWin
                Main main = new Main();
                main.Show();
                this.Hide();
            }

            else
            {
                lblError.Text = "Login failed";
                txtPass.SelectAll();
                txtPass.Focus();
            }
        }

        private void chkShow_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
            txtPass.Update();
        }

        
    }
}

