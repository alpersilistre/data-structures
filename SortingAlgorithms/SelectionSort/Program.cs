using System;

namespace SelectionSort
{
    class Program
    {
        static void SelectionSort(int[] array)
        {
            var n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    // If the next item is smaller than the current next
                    if(array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = {13, 4, 36, 76, 23, 9};
            SelectionSort(array);

            Console.WriteLine("Result;");
            PrintArray(array);
        }
    }
}