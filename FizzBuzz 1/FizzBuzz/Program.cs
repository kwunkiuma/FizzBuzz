using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 260; i++)
            {
                String[] outputArr = new String[5];

                if (i % 3 == 0)
                {
                    outputArr[0] = "Fizz";
                }

                if (i % 5 == 0)
                {
                    outputArr[3] = "Buzz";
                }

                if (i % 7 == 0)
                {
                    outputArr[4] = "Bang";
                }

                if (i % 11 == 0)
                {
                    outputArr = new String[5];
                    outputArr[2] = "Bong";
                }

                if (i % 13 == 0)
                {
                    outputArr[1] = "Fezz";
                }

                if (i % 17 == 0)
                {
                    Array.Reverse(outputArr);
                }

                String outputString = String.Concat(outputArr);

                if (String.IsNullOrEmpty(outputString))
                {
                    outputString = i.ToString();
                }

                Console.WriteLine(outputString);
            }
        }
    }
}
