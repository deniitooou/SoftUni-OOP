using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone();
            var stationaryPhone = new StationaryPhone();

            var phoneNumbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (!IsValidPhoneNumber(phoneNumber))
                {
                    Console.WriteLine("Invalid number!");
                 }
                else if (phoneNumber.Length == 10)
                {
                    smartphone.Call(phoneNumber);
                }
                else
                {
                    stationaryPhone.Call(phoneNumber);
                }
            }

            foreach (var url in urls)
            {
                if (!IsValidWebsiteAdress(url))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartphone.Browse(url);
                }
            }


        }

        public static bool IsValidPhoneNumber(string digits)
        {
            foreach (char digit in digits)
            {
                if (!char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidWebsiteAdress(string websites)
        {
            foreach (char website in websites)
            {
                if (char.IsDigit(website))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
