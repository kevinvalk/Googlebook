using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using Google.Contacts;
using Google.GData.Client;

namespace Googlebook
{
    class ContactManager
    {
        private static int maxNo = 5000;
        private FacebookClient facebook;
        private ContactsRequest google;

        public ContactManager()
        {
            facebook = new FacebookClient();

            // Defaults
            isGoogleLogin = false;
        }

        public bool loginGoogle(string user, string password)
        {
            try
            {
                RequestSettings settings = new RequestSettings(Config.appName, user, password);
                settings.Maximum = maxNo;
                settings.AutoPaging = true;
                google = new ContactsRequest(settings);

                isGoogleLogin = (google.GetContacts().PageSize > 0);

                return isGoogleLogin;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Properties
        private bool isGoogleLogin;

        public bool IsGoogleLogin
        {
            get { return isGoogleLogin; }
        }
    }
}
