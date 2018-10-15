using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Please Give a Valid Name:");
                GetNames(Console.ReadLine());
                Console.WriteLine("Please Give a valid email address:");
                GetEmail(Console.ReadLine());
                Console.WriteLine("Please Give a valid phone number: xxx-xxx-xxxx:");
                GetPhone(Console.ReadLine());
                Console.WriteLine("Please Give a valid date: mm-dd-yyyy:");
                GetDate(Console.ReadLine());
                Console.WriteLine("Please Give a html tag.");
                GetTags(Console.ReadLine());

                Console.WriteLine("Do you wish to continue? y/n?");
                cont = Console.ReadLine().ToLower() == "y";
            }


        }

        static void GetNames(string name)
        {

            if (Regex.IsMatch(name, @"^[A-Z]+[A-z]{1,30}$"))
            {
                Console.WriteLine("is a valid name\n");
            }
            else
            {
                Console.WriteLine("Sorry, not a valid name\n");
            }
        }
        static void GetEmail(string email)
        {

            if (Regex.IsMatch(email, @"^([A-z0-9]{5,30})@([A-z]{5,10}).([a-z]{2,3})$"))
            {
                Console.WriteLine("is a valid email\n");
            }
            else
            {
                Console.WriteLine("Sorry, not a valid email\n");
            }
        }
        static void GetPhone(string phone)
        {

            if (Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("is a valid phone number\n");
            }
            else
            {
                Console.WriteLine("Sorry, not a valid phone number.\n");
            }
        }

        static void GetDate(string date)
        {
            if(Regex.IsMatch(date, @"^\d{2}\/\d{2}\/\d{4}$"))
            {
                Console.WriteLine("Is a valid date number\n");
            }
            else
            {
                Console.WriteLine("Sorry, not a valid date.\n");
            }
        }
        static void GetTags(string elements)
        {
            if (Regex.IsMatch(elements, @"<[a-z0-9](.*?)>(.*?)<\/[a-z0-9]>"))
            {
                Console.WriteLine("Is a valid tag\n");
            }
            else
            {
                Console.WriteLine("Sorry, not a tag.\n");
            }
        }
    }
}
