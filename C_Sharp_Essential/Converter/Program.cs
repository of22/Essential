using System.Globalization;

namespace Converter
{
    using System;

    class Program
    {
        static void Main()
        {

            Converter converter = new Converter(27.30, 28.15, 0.46);

            try
            {
                Console.WriteLine("Enter your current currency and press Enter: \n Type '1' for USD \n Type '2' for EUR \n Type '3' for RUB \n Type '0' for UAH  ");
                Currencies initialCurrency = converter.DefineCurrency(Convert.ToInt16(Console.ReadLine()));


                Console.WriteLine("Enter result currency and press Enter: \n Type '1' for USD \n Type '2' for EUR \n Type '3' for RUB \n Type '0' for UAH  ");
                Currencies resultCurrency = converter.DefineCurrency(Convert.ToInt16(Console.ReadLine()));

                NumberFormatInfo provider = new NumberFormatInfo
                {
                    NumberDecimalSeparator = ",",
                    NumberGroupSeparator = "."
                };

                Console.WriteLine("Enter your amount for convertation with comma as decimal separator:");
                double value = InputConverter.ConvertStringToDouble(Console.ReadLine(), provider);

                Console.WriteLine($"Result: {value} " +
                                  $"{EnumHelper.GetEnumDescriptionAttribute(initialCurrency)} " +
                                  "equals to " +
                                  $"{converter.Convert(initialCurrency, resultCurrency, value)} " +
                                  $"{EnumHelper.GetEnumDescriptionAttribute(resultCurrency)}");

                Console.Write("\nPress any key to quit . . . ");
                Console.ReadKey();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't process entered values");
                Console.Write("\nPress any key to quit . . . ");
                Console.ReadKey();
            }



        }
    }
}
