using System;
using System.Text.RegularExpressions;

namespace userRagistration
{
    public class UserValidater
    {
        private static string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3}$";
        public bool validateFirstName(string firstname)
        {
            Regex re = new Regex(FIRST_NAME_PATTERN);
            if (re.IsMatch(firstname))
                return (true);
            else
                return (false);
        }
    }
}
