using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using Google.Contacts;
using Google.GData.Client;
using Google.GData.Contacts;

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
            IsGoogleLogin = false;
        }

        public bool LoginGoogle(string user, string password)
        {
            try
            {
                RequestSettings settings = new RequestSettings(Config.appName, user, password);
                settings.Maximum = maxNo;
                settings.AutoPaging = true;
                google = new ContactsRequest(settings);

                IsGoogleLogin = (google.GetContacts().PageSize > 0);

                return IsGoogleLogin;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Contact> GetGoogleContacts(bool filter = false)
        {
            if(google == null)
                return new List<Contact>();

            var feed = google.GetContacts();
            feed.Maximum = maxNo;

            var filtered = new List<Contact>();

            foreach (Contact contact in feed.Entries)
            {
                if(!filter)
                {
                    filtered.Add(contact);
                    continue;
                }

                if (!HasFbKey(contact))
                    filtered.Add(contact);
            }

            filtered.Sort(ContactComparison);
            return filtered;
        }

        private static int ContactComparison(Contact a, Contact b)
        {
            return System.String.CompareOrdinal(a.ContactEntry.Name.FullName, b.ContactEntry.Name.FullName);
        }

        public List<Contact> GetGoogleUnlinkedContacts()
        {
            return GetGoogleContacts(true);
        }

        private bool HasFbKey(Contact contact)
        {
            foreach (UserDefinedField f in contact.ContactEntry.UserDefinedFields)
                if (f.Key == Config.googleFbField)
                    return true;
            return false;
        }

        public bool LoginFacebook(string token, int ttl)
        {
            dynamic extendedToken = facebook.Get(Config.facebookExtendedToken + token);
            facebook = new FacebookClient(extendedToken.access_token){AppId = Config.appId, AppSecret = Config.appSecret};
            return true;
        }

        // Properties
        public bool IsGoogleLogin { get; private set; }
    }
}
