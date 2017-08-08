using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var phonebook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                var personInfo = command.Split().ToList();

                switch (personInfo[0])
                {
                    case "A": AddEntryToPhonebook(phonebook, personInfo[1], personInfo[2]); break;
                    case "S": SearchForContact(phonebook, personInfo[1]); break;
                    case "ListAll": PrintPhonebook(phonebook); break;
                }

                command = Console.ReadLine();
            }
        }

        static void PrintPhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach (var pair in phonebook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }

        static void SearchForContact(SortedDictionary<string, string> phonebook, string personName)
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

        static void AddEntryToPhonebook(SortedDictionary<string, string> phonebook, string personName, string personPhone)
        {
            phonebook[personName] = personPhone;
        }
    }
}
