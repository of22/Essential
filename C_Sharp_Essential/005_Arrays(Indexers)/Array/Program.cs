namespace Array
{
    using System;

    class Program
    {

        //  Задание 2 
        //  Используя Visual Studio, создайте проект по шаблону Console Application.
        //  Требуется:  
        //  Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
        //  Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 

        static void Main()
        {

            int[] array = ArrayHelper.CreateArray(10);

            ArrayHelper.FillArrayWithRandomValues(array, 0, 100);

            Console.WriteLine("All array values:");

            ArrayHelper.PrintAllArrayValues(array);

            Console.WriteLine("\n*****\n");

            Console.WriteLine("Biggest - " + ArrayHelper.FindBiggestValue(array));
            Console.WriteLine("Smallest - " + ArrayHelper.FindSmallestValue(array));
            Console.WriteLine("Average - " + ArrayHelper.FindAverageValue(array));
            Console.WriteLine("Sum - " + ArrayHelper.CalculateSumOfArrayValues(array));
            Console.WriteLine("Biggest - " + ArrayHelper.FindBiggestValue(array));

            Console.WriteLine("\n*****\n");

            ArrayHelper.DisplayAllNotEvenNumbers(array);

            Console.ReadLine();

        }
    }
}
