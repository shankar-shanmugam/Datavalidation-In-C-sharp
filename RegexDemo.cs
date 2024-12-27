using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionInC_
{
    internal class RegexDemo
    {
        public static void Demo()
        {
            string pattern = @"^\d+$";
            string input = "12345";
            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine(isMatch);
        }

        public static bool IsValidMobileNumber(string input)
        {
            string pattern = @"^\d{10}$"; // Validates a 10-digit mobile number
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsValidEmail(string input)
        {
            string pattern = @"^[\w._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsValidDate(string input)
        {
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidIPAddress(string input)
        {
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidZipCode(string input)
        {
            string pattern = @"^\d{5}|[0-9]{1}$"; 
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidURL(string input)
        {
            string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
            // Validates HTTP, HTTPS, or FTP URLs
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidHexNumber(string input)
        {
            string pattern = @"^0x[0-9a-fA-F]+$"; // Hexadecimal numbers starting with '0x'
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidSSN(string input)
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$"; // E.g., "123-45-6789"
            return Regex.IsMatch(input, pattern);
        }

        public static bool IsValidTime(string input)
        {
            string pattern = @"^([01]?[0-9]|2[0-3]):[0-5][0-9]$";
            return Regex.IsMatch(input, pattern);
        }


    }
}
