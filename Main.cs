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

        // Custom fields
        private bool modLogin;

        public Main()
        {
            InitializeComponent();

            // Load the settings
            tbUser.Text = settings.googleUser;
            tbPassword.Text = settings.googlePass;
        }

        private void LoginStep(int stepNo)
        {
            // Reset all
            browser.Visible = false;

            // Set to new settings
            step.CurrentStep = stepNo+1;
            switch(stepNo)
            {
                case 0:
                    break;
                case 1:
                    browser.Visible = true;
                    browser.Navigate(Config.facebookLoginUrl);
                    modLogin = true;
                    

                    break;
            }
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
                LoginStep(1);
            }
            else
            {
                lbState.Text = "FAILED";
            }
            status.Refresh();
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(modLogin)
            {
                browser.Document.GetElementById("pagelet_bluebar").OuterHtml = "";
                browser.Document.GetElementById("pageFooter").OuterHtml = "";
                browser.Document.Window.ScrollTo(40,100);
                browser.Document.Body.Style = "overflow: hidden;";
                modLogin = false;
            }
        }
    }
}