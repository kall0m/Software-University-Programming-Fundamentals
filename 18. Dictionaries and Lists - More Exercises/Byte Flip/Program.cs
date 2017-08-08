using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bytes = Console.ReadLine().Split().Where(n => n.Length == 2).ToList();

            for (int i = 0; i < bytes.Count; i++)
            {
                char[] charArray = bytes[i].ToCharArray();
                Array.Reverse(charArray);
                bytes[i] = new string(charArray);
            }

            bytes.Reverse();

            List<char> result = bytes.Select(ch => (char)Convert.ToInt32(ch, 16)).ToList();

            Console.WriteLine(string.Join("", result));
        }
    }
}
