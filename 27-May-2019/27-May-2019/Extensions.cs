using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _27_May_2019
{
    public static class Extensions
    {
        public static bool isEmail(this string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int pow(this int number, int power)
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total *= number;
            }
            return total;
        }
    }
}
