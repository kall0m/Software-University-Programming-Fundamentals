using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInfo = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToList();

                var username = command[1];

                if(command[0] == "register")
                {
                    var licensePlateNumber = command[2];

                    RegisterUser(userInfo, username, licensePlateNumber);
                }
                else if(command[0] == "unregister")
                {
                    UnregisterUser(userInfo, username);
                }
            }

            foreach (var user in userInfo)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static void UnregisterUser(Dictionary<string, string> userInfo, string username)
        {
            if (!userInfo.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
                return;
            }

            userInfo.Remove(username);
            Console.WriteLine($"user {username} unregistered successfully");
        }

        static void RegisterUser(Dictionary<string, string> userInfo, string username, string licensePlateNumber)
        {
            if (userInfo.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {userInfo[username]}");
                return;
            }

            var isValid = CheckLicensePlateNumber(licensePlateNumber);

            if (!isValid)
            {
                Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                return;
            }

            foreach (var user in userInfo)
            {
                if (licensePlateNumber == user.Value)
                {
                    Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    return;
                }
            }

            userInfo[username] = licensePlateNumber;
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }

        static bool CheckLicensePlateNumber(string licensePlateNumber)
        {
            if(licensePlateNumber.Length != 8)
            {
                return false;
            }

            var uppercaseLettersInLicensePlateNumber = licensePlateNumber.Take(2).ToList();

            uppercaseLettersInLicensePlateNumber.AddRange(licensePlateNumber.Skip(6).Take(2).ToList());

            foreach (var letter in uppercaseLettersInLicensePlateNumber)
            {
                if (!char.IsUpper(letter))
                {
                    return false;
                }
            }

            var digitsInLicensePlateNumber = licensePlateNumber.Skip(2).Take(4).ToList();

            foreach (var digit in digitsInLicensePlateNumber)
            {
                if (!char.IsDigit(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
