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
        private readonly Properties.Settings _settings = Properties.Settings.Default;
        private const int MaxNo = 5000;
        private FacebookClient _facebook;
        private ContactsRequest _google;

        public ContactManager()
        {
            _facebook = new FacebookClient();

            // Defaults
            IsGoogleLogin = false;
        }

        public bool LoginGoogle(string user, string password)
        {
            try
            {
                var settings = new RequestSettings(Config.appName, user, password){Maximum = MaxNo, AutoPaging = true};
                _google = new ContactsRequest(settings);

                IsGoogleLogin = (_google.GetContacts().PageSize > 0);

                return IsGoogleLogin;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Contact> GetGoogleContacts(bool filter = false)
        {
            if(_google == null)
                return new List<Contact>();

            var feed = _google.GetContacts();
            feed.Maximum = MaxNo;

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

        public bool LoginFacebook(string token)
        {
            _facebook = new FacebookClient(token) { AppId = Config.appId, AppSecret = Config.appSecret };

            IsFacebookLogin = (_facebook != null);
            return IsFacebookLogin;
        }

        public bool GetFacebookExtended(string token)
        {
            dynamic extendedToken = _facebook.Get(Config.facebookExtendedToken + token);
            if (LoginFacebook(extendedToken.access_token))
            {
				_settings.facebookToken = extendedToken.access_token;
                _settings.facebookInitTime = DateTime.Now;
                _settings.facebookExpirationTime = DateTime.Now;
                _settings.facebookExpirationTime = _settings.facebookExpirationTime.AddMinutes(extendedToken.expires);
                _settings.Save();
                return true;
            }
            return false;
        }

        // Properties
        public bool IsGoogleLogin { get; private set; }
        public bool IsFacebookLogin { get; private set; }
    }
}
