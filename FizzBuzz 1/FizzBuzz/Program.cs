using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static Boolean ReadYN(string message)
        {
            char answer = 'a';
            var valid = new List<char>();
            valid.Add('y');
            valid.Add('n');
            while (!valid.Contains(answer))
            {
                Console.Write(message);
                try
                {
                    answer = Char.Parse(Console.ReadLine());
                    answer = Char.ToLower(answer);
                }
                catch
                {
                }
            }
            if (answer == 'y')
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int max = -1;
            while (max < 1)
            {
                Console.Write("Enter a number to go up to: ");
                try
                {
                    max = Int32.Parse(Console.ReadLine());
                } catch
                {
                }
            }

            Boolean[] rules = new bool[6];

            if (ReadYN("Enable Fizz if mod 3? (y/n): "))
            {
                rules[0] = true;
            }

            if (ReadYN("Enable Buzz if mod 5? (y/n): "))
            {
                rules[1] = true;
            }

            if (ReadYN("Enable Bang if mod 7? (y/n): "))
            {
                rules[2] = true;
            }

            if (ReadYN("Enable Bong if mod 11? (y/n): "))
            {
                rules[3] = true;
            }

            if (ReadYN("Enable Fezz if mod 13? (y/n): "))
            {
                rules[4] = true;
            }

            if (ReadYN("Enable reverse if mod 17? (y/n): "))
            {
                rules[5] = true;
            }

            for (int i = 1; i <= max; i++)
            {
                var outputArr = new String[5];
                int ruleNum = 0;

                if (rules[ruleNum] && i % 3 == 0)
                {
                    outputArr[0] = "Fizz";
                }
                ruleNum++;

                if (rules[ruleNum] && i % 5 == 0)
                {
                    outputArr[3] = "Buzz";
                }
                ruleNum++;

                if (rules[ruleNum] && i % 7 == 0)
                {
                    outputArr[4] = "Bang";
                }
                ruleNum++;

                if (rules[ruleNum] && i % 11 == 0)
                {
                    outputArr = new String[5];
                    outputArr[2] = "Bong";
                }
                ruleNum++;

                if (rules[ruleNum] && i % 13 == 0)
                {
                    outputArr[1] = "Fezz";
                }
                ruleNum++;

                if (rules[ruleNum] && i % 17 == 0)
                {
                    Array.Reverse(outputArr);
                }

                var outputString = String.Concat(outputArr);

                if (String.IsNullOrEmpty(outputString))
                {
                    outputString = i.ToString();
                }

                Console.WriteLine(outputString);
            }
        }
    }
}
