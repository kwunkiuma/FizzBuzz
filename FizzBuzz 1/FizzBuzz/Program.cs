﻿using System;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                StringBuilder output = new StringBuilder(16);

                if (i % 3 == 0)
                {
                    output.Append("Fizz");
                }

                if (i % 5 == 0)
                {
                    output.Append("Buzz");
                }

                if (i % 7 == 0)
                {
                    output.Append("Bang");
                }

                if (i % 11 == 0)
                {
                    output = new StringBuilder("Bong", 16); // Not sure if there's a way to set the content
                }

                if (output.Length == 0)
                {
                    output.Append(i.ToString());
                }

                Console.WriteLine(output);
            }
        }
    }
}
