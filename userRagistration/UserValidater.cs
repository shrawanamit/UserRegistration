using System;
using System.Text.RegularExpressions;

namespace userRagistration
{
    public class UserValidater
    {
        private static string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3}$";
        private static string LAST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3}$";
        public Boolean validateFirstName(string firstname)
        {
            return Regex.IsMatch( firstname, FIRST_NAME_PATTERN);
        }

        public Boolean validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, LAST_NAME_PATTERN);
        }
    }
}
