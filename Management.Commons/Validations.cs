using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Management.Commons
{
    public class Validations
    {
        public static bool IsEmailValid(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s\.]+@[^@\s]+\.[^@\s]+$"))
            {
                return false;
            }

            return true;
        }

        public static string CleanName(string name)
        {
            var firstChar = (int)name[0];
            if (!double.IsNaN(firstChar))
            {
                if (firstChar >= 65 || firstChar <= 90)
                {
                    return name;
                }

                return name.ToUpper()[0] + name.Substring(1);
            }

            while (int.TryParse(name[0].ToString(), out int _))
            {
                name = name.Substring(1);
            }

            return CleanName(name);
        }

        public static int IsValidInput(string data)
        {
            bool isValid = int.TryParse(data, out int value);
            if (!isValid)
                return -1;
            else if (value < 0 || value > 5)
                return -1;
            else
                return value;
        }
    }
}
