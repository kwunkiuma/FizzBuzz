using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = -1;
            while (max < 1)
            {
                Console.Write("Enter a number to go up to: ");
                try
                {
                    max = Int32.Parse(Console.ReadLine());
                } catch (Exception e)
                {

                }
            }

            for (int i = 1; i <= max; i++)
            {
                var outputArr = new String[5];

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
