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
            //user continue loop
            bool cont = true;
            while (cont)
            {
                //ask questions and grab methods passing strings enter by readlines.
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

        //get names first letter must be caps 1-30 in length
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

        //email min 5 max 30 A-z or 0-9 then @ then min 5 max 10 A-z lower case then
        //"." then 2min 3 max a-z lower
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
        //phone digits only 3 then - phone digits only 3 then -phone digits only 4
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

        //2 digits then / then 2 digits then / then 4 digits
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

        //first < then lower case and digits next lose care then / and < then lower case 
        //and digits
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
