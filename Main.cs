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
        ContactManager cm = new ContactManager();

        public Main()
        {
            InitializeComponent();
        }

        private void bGoogleLogin_Click(object sender, EventArgs e)
        {
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