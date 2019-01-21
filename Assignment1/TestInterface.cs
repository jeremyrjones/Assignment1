using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    static class TestInterface
    {
        private static void FormatRecord(IFormatter formatter)
        {
            formatter.Format();
        }

        private static string GetRecordType()
        {
            Console.WriteLine("Select choice:");
            Console.WriteLine("1. create phone number record");
            Console.WriteLine("2. create social security record");
            Console.WriteLine("0. exit");

            return Console.ReadLine();
        }

        public static void Main()
        {
            bool keepGoing = true;
            string userChoice;

            while (keepGoing)
            {
                userChoice = GetRecordType();
                int choiceAsInt = int.Parse(userChoice);
                switch (choiceAsInt)
                {
                    case 1:
                        Console.WriteLine("Enter string representing phone number");
                        string phoneNumberInput = Console.ReadLine();
                        PhoneNumber phoneNumber = new PhoneNumber(phoneNumberInput);
                        FormatRecord(phoneNumber);
                        Console.WriteLine($"Formatted phone number is: {phoneNumber}");
                        break;
                    case 2:
                        Console.WriteLine("Enter string representing social security number");
                        string ssnInput = Console.ReadLine();
                        SocialSecurityNumber socialSecurityNumber = new SocialSecurityNumber(ssnInput);
                        FormatRecord(socialSecurityNumber);
                        Console.WriteLine($"Formatted social security number is: {socialSecurityNumber}");
                        break;
                    case 0:
                        keepGoing = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Bad input! Exiting...");
                        keepGoing = false;
                        break;
                }
            }
        }
    }
}
