using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var personInfo = new Dictionary<string, string>();

            var name = Console.ReadLine();

            while(name != "stop")
            {
                var email = Console.ReadLine();
            
                if (!(email.EndsWith("us")) && !(email.EndsWith("uk")))
                {
                    personInfo[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var person in personInfo)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
