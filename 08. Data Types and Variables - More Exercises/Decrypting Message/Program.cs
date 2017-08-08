using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decryptedMessage = "";

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                decryptedMessage += (char)(letter + key);
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
