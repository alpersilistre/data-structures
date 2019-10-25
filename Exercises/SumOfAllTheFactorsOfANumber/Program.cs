using System;

namespace SumOfAllTheFactorsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfAllFactors(30));
        }

        static int SumOfAllFactors(int number)
        {
            var result = 0;

            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (i == (number / i))
                    {
                        result += i;
                    }
                    else
                    {
                        result += (i + (number / i));
                    }
                }
            }

            return result + 1 + number;
        }
    }
}
