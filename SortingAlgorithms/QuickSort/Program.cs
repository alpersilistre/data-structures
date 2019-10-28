using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {4, 3, 7, 8, 1, 6, 2};

            ApplyQuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted Array:");

            PrintArray(array);
        }

        static void ApplyQuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                var partitionIndex = Partition(array, low, high);

                ApplyQuickSort(array, low, partitionIndex - 1);
                ApplyQuickSort(array, partitionIndex + 1, high);
            }
        }

        // Pivot is the last item inside the array.
        static int Partition(int[] array, int low, int high)
        {
            var pivot = array[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;

                    var temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }

            var temp2 = array[high];
            array[high] = array[i + 1];
            array[i + 1] = temp2;

            return i + 1;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
