using System;
using System.Text.RegularExpressions;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input for name
            Console.Write("Please enter first and last name (Ex: John Smith): ");
            string inputName = Console.ReadLine();

            /*
            Regex to make sure first letter for both first and last name
            is capital and each name is limited to 30 characters
            */
            string nameRegex = @"^[A-Z]{1}[a-z]{1,29}\s[A-Z]{1}[a-z]{1,29}$";

            if (Regex.IsMatch(inputName, nameRegex))
            {
                Console.WriteLine($"The name {inputName} is valid.");
            }
            else
            {
                Console.WriteLine("That is not a valid name.");
            }

            //Get input for email address
            Console.Write("Please enter email address (Ex: johnsmith@gmail.com): ");
            string inputEmail = Console.ReadLine();

            //Regex to verify email address. Before the @ must be between 5 and 30 characters
            //After the @ domain must be between 5 and 10 characters
            //after the domain and ., domain must be either 2 or 3 characters long
            string emailRegex = @"(\w{5,30}\@)\w{5,10}(\.\w{2,3})";

            if (Regex.IsMatch(inputEmail, emailRegex))
            {
                Console.WriteLine($"The email {inputEmail} is valid.");
            }
            else
            {
                Console.WriteLine("That is not a valid email address.");
            }

            //Get input for phone number
            Console.Write("Please enter phone number (Ex: 313-555-1212): ");
            string inputPhone = Console.ReadLine();

            /*
            Regex to match phone number in any of the following formats:
            313-555-1212
            (313)-555-1212
            313.555.1212
            */
            string phoneRegex = @"\(*\d{3}\)*(-|.)\d{3}(-|.)\d{4}";

            if (Regex.IsMatch(inputPhone, phoneRegex))
            {
                Console.WriteLine($"The phone number {inputPhone} is valid.");
            }
            else
            {
                Console.WriteLine("That is not a valid phone number");
            }

            //Get input for date
            Console.Write("Please enter a date. Ex: (01/10/2020): ");
            string inputDate = Console.ReadLine();

            //Regex to check date in the following format: 01/01/2020
            string dateRegex = @"\d{2}\/\d{2}\/\d{4}";

            if (Regex.IsMatch(inputDate, dateRegex))
            {
                Console.WriteLine($"The date {inputDate} is valid.");
            }
            else
            {
                Console.WriteLine("That is not a valid date.");
            }
        }
    }
}
