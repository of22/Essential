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

        public static int FindBiggestValue(int[] array)
        {
            if (array == null)
            {
                throw new Exception();
            }

            int result = int.MinValue;
            foreach (var value in array)
            {
                if (value > result)
                {
                    result = value;
                }
            }
            return result;
        }

        public static int FindSmallestValue(int[] array)
        {
            if (array == null)
            {
                throw new Exception();
            }

            int result = int.MaxValue;
            foreach (var value in array)
            {
                if (value < result)
                {
                    result = value;
                }
            }
            return result;
        }

        public static int CalculateSumOfArrayValues(int[] array)
        {
            if (array == null)
            {
                throw new Exception();
            }

            int result = 0;
            foreach (var value in array)
            {
                result += value;
            }
            return result;
        }

        public static int FindAverageValue(int[] array)
        {
            if (array == null)
            {
                throw new Exception();
            }

            int result = 0;
            foreach (var value in array)
            {
                result += value;
            }
            return result / array.Length;
        }

        public static void DisplayAllNotEvenNumbers(int[] array)
        {
            if (array == null)
            {
                throw new Exception();
            }

            Console.WriteLine("Even numbers:");
            foreach (var value in array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }

    }
}
