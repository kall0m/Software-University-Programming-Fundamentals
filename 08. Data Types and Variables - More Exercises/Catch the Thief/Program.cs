using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string thiefsID = Console.ReadLine().ToLower();
            int idsCount = int.Parse(Console.ReadLine());
            long max = long.MinValue;
            double sentence = 0.0;

            switch (thiefsID)
            {
                case "sbyte":
                    for (int i = 0; i < idsCount; i++)
                    {
                        long id = long.Parse(Console.ReadLine());

                        if (id >= sbyte.MinValue && id <= sbyte.MaxValue)
                        {
                            if(max < id)
                            {
                                max = id;
                            }
                        }
                    }
                    if(max > 0)
                    {
                        sentence = Math.Ceiling(max / 127.0);
                    }
                    else
                    {
                        sentence = Math.Ceiling(max / -128.0);
                    }

                    if (sentence == 1)
                    {
                        Console.WriteLine($"Prisoner with id {max} is sentenced to {sentence} year");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {max} is sentenced to {sentence} years");
                    }
                    break;
                case "int":
                    for (int i = 0; i < idsCount; i++)
                    {
                        long id = long.Parse(Console.ReadLine());

                        if (id >= int.MinValue && id <= int.MaxValue)
                        {
                            if (max < id)
                            {
                                max = id;
                            }
                        }
                    }
                    if (max > 0)
                    {
                        sentence = Math.Ceiling(max / 127.0);
                    }
                    else
                    {
                        sentence = Math.Ceiling(max / -128.0);
                    }

                    if (sentence == 1)
                    {
                        Console.WriteLine($"Prisoner with id {max} is sentenced to {sentence} year");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {max} is sentenced to {sentence} years");
                    }
                    break;
                case "long":
                    for (int i = 0; i < idsCount; i++)
                    {
                        long id = long.Parse(Console.ReadLine());

                        if (id >= long.MinValue && id <= long.MaxValue)
                        {
                            if (max < id)
                            {
                                max = id;
                            }
                        }
                    }
                    if (max > 0)
                    {
                        sentence = Math.Ceiling(max / 127.0);
                    }
                    else
                    {
                        sentence = Math.Ceiling(max / -128.0);
                    }

                    if(sentence == 1)
                    {
                        Console.WriteLine($"Prisoner with id {max} is sentenced to {sentence} year");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {max} is sentenced to {sentence} years");
                    }
                    break;
            }
        }
    }
}
