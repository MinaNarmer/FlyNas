
using System;

namespace ConsoleApp1
{
    public static class Helper
    {
        public static (bool, string) ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return (false, string.Empty);
            }
            return (true, name);
        }

        public static (bool, string) ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                return (false, string.Empty);
            }
            return (true, email);
        }


    }
}
