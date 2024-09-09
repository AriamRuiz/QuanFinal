using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Lab1_ASPNetConnectedMode.VALIDATION
{
    public static class Validator
    {
        public static bool IsValidId(string empNum)
        {
            if (!Regex.IsMatch(empNum, @"^\d{4}$"))
            {

                return false;

            }
            return true;
        }

        public static bool IsValidId(string empNum, int size)
        {
            if (!Regex.IsMatch(empNum, $@"^\d{{{size}}}$"))
            {
                return false;
            }
            return true;
        }

    }
}