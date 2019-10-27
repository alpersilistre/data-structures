using System;

namespace FindAPairWithMaxProductInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {1, 4, 3, 6, -7};

            MaxProduct(array);
        }

        static void MaxProduct(int[] array)
        {
            if (array.Length < 2)
                Console.WriteLine("No pair exists");

            int a = array[0];
            int b = array[1];
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] * array[j] > a * b)
                    {
                        a = array[i];
                        b = array[j];
                    }
                }
            }

            Console.WriteLine($"Max product pair is {a}, {b}");
        }
    }
}
