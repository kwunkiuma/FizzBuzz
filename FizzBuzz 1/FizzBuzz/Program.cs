using System;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 260; i++)
            {
                StringBuilder output = new StringBuilder(16);

                if (i % 3 == 0)
                {
                    output.AppendLine("Fizz");
                }

                if (i % 5 == 0)
                {
                    output.AppendLine("Buzz");
                }

                if (i % 7 == 0)
                {
                    output.AppendLine("Bang");
                }

                if (i % 11 == 0)
                {
                    output = new StringBuilder("Bong", 16); // Not sure if there's a way to set the content
                }

                if (i % 13 == 0)
                {
                    int bpos = output.ToString().IndexOf("B");
                    if (bpos == -1)
                    {
                        bpos = output.Length;
                    }
                    output.Insert(bpos, "Fezz\r\n");
                }

                if (i % 17 == 0)
                {
                    StringBuilder newOutput = new StringBuilder(16);
                    string[] substrings = output.ToString().Split("\r\n");
                    foreach (string s in substrings)
                    {
                        newOutput.Insert(0, s);
                    }
                    output = newOutput;
                }

                if (output.Length == 0)
                {
                    output.Append(i.ToString());
                }

                Console.WriteLine(output.ToString().Replace("\r\n", ""));
            }
        }
    }
}
