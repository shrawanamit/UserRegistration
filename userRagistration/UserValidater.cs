using System;
using System.Text.RegularExpressions;

namespace userRagistration
{
    public class UserValidater
    {
        private static readonly string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3}$";
        private static string LAST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3}$";
        private static string EMAIL_ADDRESS_PATTERN = "^[a-zA-Z0-9]*+([._-])?[a-zA-Z0-9]*@[a-zA-Z]+.[a-zA-Z]{2,4}(.[a-zA-Z]{2})*$";
        private static string MOBILE_NO_PATTERN = "^[1-9]{2}[[:space:]]{1}[0-9]{10}$";
        private static string PASSWORD_PATTERN = "^[A-Za-z0-9]*[@#$%^&*][0-9a-zA-Z]*$";
        public Boolean validateFirstName(string firstname)
        {
            return Regex.IsMatch( firstname, FIRST_NAME_PATTERN);
        }

        public Boolean validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, LAST_NAME_PATTERN);
        }

        public Boolean validateEmailId(string email)
        {
            return Regex.IsMatch(email, EMAIL_ADDRESS_PATTERN);
        }

    }
}
