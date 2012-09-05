using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Googlebook
{
    public partial class Main : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private ContactManager cm = new ContactManager();
        private Properties.Settings settings = Properties.Settings.Default;

        public Main()
        {
            InitializeComponent();

            // Load the settings
            tbUser.Text = settings.googleUser;
            tbPassword.Text = settings.googlePass;
        }

        private void bGoogleLogin_Click(object sender, EventArgs e)
        {
            // Save the settings
            settings.googleUser = tbUser.Text;
            settings.googlePass = tbPassword.Text;
            settings.Save();


            if(cm.loginGoogle(tbUser.Text, tbPassword.Text))
            {
                lbState.Text = "SUCCESS";
            }
            else
            {
                lbState.Text = "FAILED";
            }
            status.Refresh();
        }
    }
}