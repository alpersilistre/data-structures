using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[]{5, 1, 4, 2, 8, 9};

            ApplyBubbleSort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] ApplyBubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }

            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
