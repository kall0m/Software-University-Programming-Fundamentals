using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Exception
{
    class Program
    {
        class NegativeNumberException : System.Exception
        {
            public NegativeNumberException() : base("My first exception is awesome!!!") { }
        }

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        throw new NegativeNumberException();
                    }

                    Console.WriteLine(num);
                }
            }
            catch (NegativeNumberException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
