using System;
using System.Collections.Generic;

namespace FindTheMostFrequentElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 5, 2, 5, 1, 3, 5, 2, 1, 5, 5}; 
          
            Console.WriteLine(MostFrequentSorted(arr));

            Console.WriteLine(MostFrequentDict(arr));
        }

        static int MostFrequentSorted(int[] array)
        {
            var length = array.Length;

            Array.Sort(array);

            int maxCount = 1;
            int count = 1;
            int output = array[0];

            for (int i = 1; i < length; i++)
            {
                if (array[i] == array[i - 1])
                    count++;
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        output = array[i - 1];
                    }

                    count = 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                output = array[length - 1];
            }

            return output;
        }

        static int MostFrequentDict(int[] array)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                var key = array[i];

                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            int minCount = 0;
            int output = 0;

            foreach (var pair in dict)
            {
                if (minCount < pair.Value)
                {
                    output = pair.Key;
                    minCount = pair.Value;
                }
            }

            return output;
        }
    }
}
