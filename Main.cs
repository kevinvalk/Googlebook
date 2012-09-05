using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Google.Contacts;
using Google.GData.Client;
using Google.GData.Contacts;

namespace Googlebook
{
    public partial class Main : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private readonly ContactManager _cm = new ContactManager();
        private readonly Properties.Settings _settings = Properties.Settings.Default;

        // Custom fields
        private bool _modLogin;

        public Main()
        {
            // Initialize form and do some custom changes
            InitializeComponent();
            browser.BringToFront();

            // Load the settings
            tbUser.Text = _settings.googleUser;
            tbPassword.Text = _settings.googlePass;

            // Call default
            LoginStep(State.GoogleLogin);            
        }

        private void LoginStep(State state, bool automation = true)
        {
            // Reset all
            browser.Visible = false;
            pGoogleLogin.Show();
			lbLoginComplete.Hide();

            // Set to new settings
            step.CurrentStep = (int)state;
            switch(state)
            {
                case State.GoogleLogin:
					if (automation && _settings.googleAuto)
                        BGoogleLoginClick(null, null);
                    break;
                case State.FacebookLogin:
                    // Check if we can reuse the token
					if (automation && _settings.facebookExpirationTime > DateTime.Now)
					{
						if (_settings.facebookInitTime.AddDays(1) < DateTime.Now)
							_cm.GetFacebookExtended(_settings.facebookToken);
						else
							if (_cm.LoginFacebook(_settings.facebookToken))
								LoginStep(State.LoginDone);
							else
								LoginStep(State.FacebookLogin, false);
					}
                    else
                    {
                        browser.Visible = true;
                        browser.Navigate(Config.facebookLoginUrl);
                        _modLogin = true;   
                    }
                    break;
                case State.LoginDone:
                    pGoogleLogin.Hide();
		            lbLoginComplete.Show();
					lbLoginComplete.BringToFront();
		            SetStatusText("Logged in");

					// Check for unlinked contacts
					if (HasUnlinkedContacts())
					{
						Shell.SelectedTab = tabLink;
					}

                    break;
            }
        }

        private void BGoogleLoginClick(object sender, EventArgs e)
        {
            // Save the settings
            _settings.googleUser = tbUser.Text;
            _settings.googlePass = tbPassword.Text;
            _settings.Save();


            if(_cm.LoginGoogle(tbUser.Text, tbPassword.Text))
            {
                SetStatusText("SUCCESS");
                LoginStep(State.FacebookLogin);
                _settings.googleAuto = true;
                _settings.Save();
            }
            else
            {
                SetStatusText("FAILED");
            }
            status.Refresh();
        }

		private void SetStatusText(string txt)
		{
			lbState.Text = txt;
			status.Refresh();
		}

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Modify the login page a bit so it better fits the design
            if(_modLogin)
            {
                browser.Document.GetElementById("pagelet_bluebar").OuterHtml = "";
                browser.Document.GetElementById("pageFooter").OuterHtml = "";
                browser.Document.Window.ScrollTo(40,100);
                browser.Document.Body.Style = "overflow: hidden;";
                _modLogin = false;
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
                    // Lets get our extended token and then login with that
                    _cm.GetFacebookExtended(query[1]);
                    LoginStep(State.LoginDone);
                }
                else
                {
                    LoginStep(State.FacebookLogin);    
                }
                return;
            }
        }

		private void SetDefaultTile(MetroTileItem tile)
		{
			tile.TileStyle.TextLineAlignment = eStyleTextAlignment.Near;
			tile.TileStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
			tile.TitleTextFont = new Font("Segoe UI", 15, FontStyle.Bold);
			tile.Style = eDotNetBarStyle.Metro;
			tile.TileColor = eMetroTileColor.Azure;
		}

		private bool HasUnlinkedContacts()
		{
			pUnlinkedContacts.Items.Clear();
			var contacts = _cm.GetGoogleUnlinkedContacts();
			foreach (var contact in contacts)
			{
				var entry = contact.ContactEntry;
				var tile = new MetroTileItem
					           {
						           Text =	((entry.Phonenumbers.Count > 0) ? entry.Phonenumbers[0].Value : "") + "\n" +
											entry.Birthday + "\n" +
											((entry.Emails.Count > 0) ? entry.Emails[0].Address : ""),
						           TitleText = entry.Name.FullName,
						           Name = "tile" + entry.Name.FamilyName
					           };
				tile.SetOwner(contact);
				tile.Click += TileOnClick;
				SetDefaultTile(tile);

				pUnlinkedContacts.Items.Add(tile);
			}
			return (contacts.Count > 0);
		}



	    // Events
		private void TileOnClick(object sender, EventArgs eventArgs)
		{
			var metroTileItem = sender as MetroTileItem;
			if (metroTileItem != null)
			{
				var contact = metroTileItem.GetOwner() as Contact;
				if(contact == null)
					return;

				pSuggestions.Items.Clear();
				SetStatusText(contact.ContactEntry.Name.FullName);
				var suggestions = _cm.GetFacebookContactSuggestion(contact.ContactEntry.Name);
				foreach (var suggestion in suggestions)
				{
					var tile = new MetroTileItem
					{
						Text = suggestion.name,
						Name = "tile" + suggestion.name
					};
					tile.SetOwner(suggestion);
					//tile.Click += TileOnClick;
					SetDefaultTile(tile);
					tile.TileStyle.TextLineAlignment = eStyleTextAlignment.Center;
					tile.TileStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
					

					pSuggestions.Items.Add(tile);
				}
				pSuggestions.Refresh();
				
			}
		}

        private void TabLinkClick(object sender, EventArgs e)
        {
	        HasUnlinkedContacts();
        }

		private void PUnlinkedContactsMouseEnter(object sender, EventArgs e)
		{
			pUnlinkedContacts.Focus();
		}
    }
}