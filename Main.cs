using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Google.Contacts;
using Google.GData.Client;
using Google.GData.Contacts;

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
            // Initialize form and do some custom changes
            InitializeComponent();
            browser.BringToFront();

            // Load the settings
            tbUser.Text = settings.googleUser;
            tbPassword.Text = settings.googlePass;

            // Call default
            LoginStep(State.GoogleLogin);

            // Do automating
            if (settings.googleAuto)
                BGoogleLoginClick(null, null);
        }

        private void LoginStep(State state)
        {
            // Reset all
            browser.Visible = false;

            // Set to new settings
            step.CurrentStep = (int)state;
            switch(state)
            {
                case State.GoogleLogin:
                    break;
                case State.FacebookLogin:
                    browser.Visible = true;
                    browser.Navigate(Config.facebookLoginUrl);
                    modLogin = true;
                    break;
                case State.LoginDone:

                    break;
            }
        }

        private void BGoogleLoginClick(object sender, EventArgs e)
        {
            // Save the settings
            settings.googleUser = tbUser.Text;
            settings.googlePass = tbPassword.Text;
            settings.Save();


            if(cm.LoginGoogle(tbUser.Text, tbPassword.Text))
            {
                lbState.Text = "SUCCESS";
                LoginStep(State.FacebookLogin);
                settings.googleAuto = true;
                settings.Save();
            }
            else
            {
                lbState.Text = "FAILED";
            }
            status.Refresh();
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Modify the login page a bit so it better fits the design
            if(modLogin)
            {
                browser.Document.GetElementById("pagelet_bluebar").OuterHtml = "";
                browser.Document.GetElementById("pageFooter").OuterHtml = "";
                browser.Document.Window.ScrollTo(40,100);
                browser.Document.Body.Style = "overflow: hidden;";
                modLogin = false;
                return;
            }

            //Login succeed so grab that access token
            if (browser.Document.Body.InnerHtml.IndexOf("Success") >= 0)
            {
                int timeToLive;
                string[] query = (browser.Url.ToString().Replace("&expires_in", "")).Split('=');
                Debug.Assert(query.Length == 3);
                if (int.TryParse(query[2], out timeToLive))
                {
                    cm.LoginFacebook(query[1], timeToLive);
                    LoginStep(State.LoginDone);
                }
                else
                {
                    LoginStep(State.FacebookLogin);    
                }
                return;
            }
        }

        // Events
        private void TabLinkClick(object sender, EventArgs e)
        {
            var contacts = cm.GetGoogleUnlinkedContacts();
            foreach (var contact in contacts)
            {
                pUnlinkedContacts.AddItem(contact.ContactEntry.Name.FullName);
            }
        }
    }
}