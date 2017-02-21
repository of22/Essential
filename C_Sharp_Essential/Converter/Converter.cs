namespace Converter
{
    using System;
    using System.Globalization;

    class Converter
    {
        public double Usd { get; }

        public double Eur { get; }

        public double Rub { get; }

        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double Convert(Currencies initialCurrency, Currencies resultCurrency, string value) // change parameter to double , 2 - also add iformatProvider as parameter
        {
            NumberFormatInfo provider = new NumberFormatInfo
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = "."
            };

            //converting received string value to Double
            double convertedValue = System.Convert.ToDouble(value, provider);
            double calculatedResult = -0.1;

            if (initialCurrency == resultCurrency)
            {
                return convertedValue;
            }

            //converting received value to uah 
            switch (initialCurrency)
            {
                case Currencies.Usd:
                    calculatedResult = convertedValue * Usd;
                    break;
                case Currencies.Eur:
                    calculatedResult = convertedValue * Eur;
                    break;
                case Currencies.Rub:
                    calculatedResult = convertedValue * Rub;
                    break;
                case Currencies.Uah:
                    calculatedResult = convertedValue;
                    break;
            }

            //calculating result
            if (calculatedResult >= 0)
                switch (resultCurrency)
                {
                    case Currencies.Usd:
                        return calculatedResult / Usd;
                    case Currencies.Eur:
                        return calculatedResult / Eur;
                    case Currencies.Rub:
                        return calculatedResult / Rub;
                    case Currencies.Uah:
                        return calculatedResult;
                }
            throw new Exception();
        }


        public Currencies DefineCurrency(int value)
        {
            switch (value)
            {
                case 0:
                    return Currencies.Uah;
                case 1:
                    return Currencies.Usd;
                case 2:
                    return Currencies.Eur;
                case 3:
                    return Currencies.Rub;
            }
            throw new Exception();
        }

    }
}
