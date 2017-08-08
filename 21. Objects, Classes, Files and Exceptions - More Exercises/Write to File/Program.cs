using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("sample_text.txt");

            var output = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                output.Add(string.Join("", input[i].Split('.', ',', '!', '?', ':')));
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
