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

        public string ValidateFirstName(string data)
        {
            string result = Regex.IsMatch(data, Name) ? "Valid" : "Invalid";
            return result;

        }   
    }
}
