using System;
using System.Collections.Generic;
using System.IO;
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

		public List<dynamic> GetFacebookContacts()
		{
			dynamic data = _facebook.Get("me/friends");
			var list = new List<dynamic>(data.data);
			return list;
		}

		public List<dynamic> GetFacebookContactSuggestion(Google.GData.Extensions.Name gName)
		{
			var list = GetFacebookContacts();
			var suggestions = new List<dynamic>();

			// Try to find on both parts
			foreach (dynamic user in list)
			{
				var name = (user.name as string);
				if (name == null)
					continue;

				if (name.IndexOf(gName.GivenName, StringComparison.Ordinal) > -1 && name.IndexOf(gName.FamilyName, StringComparison.Ordinal) > -1)
					suggestions.Add(user);
			}

			// If nothing found try more general search
			if(suggestions.Count <= 0)
			{
				suggestions.Clear();
				foreach (dynamic user in list)
				{
					var name = (user.name as string);
					if (name == null)
						continue;

					if ((gName.FamilyName != null && name.IndexOf(gName.FamilyName, StringComparison.Ordinal) > -1) || name.IndexOf(gName.GivenName, StringComparison.Ordinal) > -1)
						suggestions.Add(user);
				}
			}

			return suggestions;
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

		public Stream GetGooglePhoto(Contact c)
		{
			try
			{
				return _google.GetPhoto(c);
			}
			catch (Exception)
			{
				return null;
			}
			
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
