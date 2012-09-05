using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googlebook
{
    public static class Config
    {
        public static string appName = "Googlebook";
        public static string appId = "373236969412426";
        public static string appSecret = "43c6fb995ea396a8099578fa33522e8b";
        public static string scope = "email,user_birthday,user_location,user_website,friends_birthday,friends_location,friends_website";
        public static string facebookLoginUrl = "https://www.facebook.com/dialog/oauth?client_id=" + appId + "&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token&scope=" + scope;
    }
}
