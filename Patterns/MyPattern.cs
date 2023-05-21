using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patterns
{
    public class MyPattern
    {
        public static string Name = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string email = "^[a-z]{3,}([.]{1}[a-z]{2,})?[/@/][a-z]{2,5}[/./][a-z]{2,5}([.]{1}[a-z]{2})?$";
        public static string phoneNumber = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string passcode = "^(?=.*[!@#$%^&*]{1})(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9@$!%*#?&]{8,}$";
        public string ValidateFirstAndLastName(string data)
        {
            string result = Regex.IsMatch(data, Name) ? "Valid" : "Invalid";
            return result;

        }
        public string ValidateEmailName(string data)
        {
            string result = Regex.IsMatch(data, email) ? "Valid" : "Invalid";
            return result;

        }
        public string ValidatePhoneNumber(string data)
        {
            string result = Regex.IsMatch(data, phoneNumber) ? "Valid" : "Invalid";
            return result;

        }
        public string ValidatePassCode(string data)
        {
            string result = Regex.IsMatch(data, passcode) ? "Valid" : "Invalid";
            return result;

        }

    }
}
