using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                var personInfo = command.Split().ToList();

                switch (personInfo[0])
                {
                    case "A": AddEntryToPhonebook(phonebook, personInfo[1], personInfo[2]); break;
                    case "S": SearchForContact(phonebook, personInfo[1]); break;
                }

                command = Console.ReadLine();
            }
        }

        static void SearchForContact(Dictionary<string, string> phonebook, string personName)
        {
            if (phonebook.ContainsKey(personName))
            {
                Console.WriteLine($"{personName} -> {phonebook[personName]}");
            }
            else
            {
                Console.WriteLine($"Contact {personName} does not exist.");
            }
        }

        static void AddEntryToPhonebook(Dictionary<string, string> phonebook, string personName, string personPhone)
        {
            phonebook[personName] = personPhone;
        }
    }
}
