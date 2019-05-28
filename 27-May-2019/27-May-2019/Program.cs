using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_May_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            phone["Bakhtiyar"] = "051-314-34-63";
            phone["Samir"] = "055-567-94-43";
            phone["Rashad"] = "070-874-74-43";
            phone["Kamal"] = "077-675-12-98";

            Contact contact5 = new Contact { Name = "Elchin", Number = "055-678-97-45" };
            phone.AddContact(contact5);

            Console.WriteLine(phone);
            //Console.WriteLine(phone[0]);
            //Console.WriteLine(phone["Bakhtiyar"]);
            //Console.WriteLine(contact5);

            #region Extensions Method
            //string email = "bakhtiyarkhsh@code.edu.az";
            //Console.WriteLine(email.isEmail());
           
            Console.WriteLine(2.pow(3));
            #endregion
        }
    }
}
