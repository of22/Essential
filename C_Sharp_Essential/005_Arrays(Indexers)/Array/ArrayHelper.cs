namespace Array
{
    using System;

    class ArrayHelper
    {
        public static int[] CreateArray(int number)
        {
            return new int[number];
        }

        public static int[] FillArrayWithRandomValues(int[] array, int minValue, int maxValue)
        {
            Random random = new Random();
            for(int index = 0; index < array.Length; index++)
            {
                array[index] = random.Next(minValue, maxValue);
            }
            return array;
        }

        public static void PrintAllArrayValues(int[] array)
        {
            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
        }

    }
}
