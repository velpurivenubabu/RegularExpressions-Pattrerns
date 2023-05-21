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
    }
}
