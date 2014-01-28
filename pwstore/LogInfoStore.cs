using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pwstore
{
    public class LogInfoStore
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public LogInfoStore()
        {
            this.Name = "nom";
            this.URL = "";

        }

        public bool FindStringInFields(string text)
        {

            Regex rx = new Regex(text, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matchesName = rx.Matches(this.Name);
            MatchCollection matchesURL = rx.Matches(this.URL);
            MatchCollection matchesLogin = rx.Matches(this.Login);
            MatchCollection matchesPassword = rx.Matches(this.Password);

            if (matchesName.Count > 0 || matchesURL.Count > 0 || matchesLogin.Count > 0 || matchesPassword.Count > 0)
                return true;

            return false;
        }

    }
}
