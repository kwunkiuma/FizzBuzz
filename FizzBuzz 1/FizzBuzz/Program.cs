using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Numerics;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                String output = new String("");

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }

                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output.Equals(""))
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }
    }
}
