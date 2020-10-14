using System;
using System.Collections.Generic;
using System.Security;

namespace FizzBuzz
{
    class Program
    {
        static Boolean ReadYN(string prompt)
        {
            string answer = "";
            do
            {
                Console.Write(prompt);
                try
                {
                    answer = Console.ReadLine().ToLower();
                }
                catch
                {
                }
            } while (answer != "y" && answer != "n");

            return answer == "y";
        }

        static bool[] GetRules()
        {
            var rules = new bool[6];

            rules[0] = ReadYN("Enable Fizz if mod 3? (y/n): ");
            rules[1] = ReadYN("Enable Buzz if mod 5? (y/n): ");
            rules[2] = ReadYN("Enable Bang if mod 7? (y/n): ");
            rules[3] = ReadYN("Enable Bong if mod 11? (y/n): ");
            rules[4] = ReadYN("Enable Fezz if mod 13? (y/n): ");
            rules[5] = ReadYN("Enable reverse if mod 17? (y/n): ");

            return rules;
        }

        static string ApplyRules(bool[] rules, int i)
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
            
            return String.Concat(outputArr);
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

            var rules = GetRules();

            for (int i = 1; i <= max; i++)
            {
                var outputString = ApplyRules(rules, i);

                if (String.IsNullOrEmpty(outputString))
                {
                    outputString = i.ToString();
                }

                Console.WriteLine(outputString);
            }
        }
    }
}
