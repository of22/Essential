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

        public double Convert(Currencies initialCurrency, Currencies resultCurrency, double value) // change parameter to double , 2 - also add iformatProvider as parameter
        {
            double calculatedResult = -0.1;

            if (initialCurrency == resultCurrency)
            {
                return value;
            }

            //converting received value to uah 
            switch (initialCurrency)
            {
                case Currencies.Usd:
                    calculatedResult = value * Usd;
                    break;
                case Currencies.Eur:
                    calculatedResult = value * Eur;
                    break;
                case Currencies.Rub:
                    calculatedResult = value * Rub;
                    break;
                case Currencies.Uah:
                    calculatedResult = value;
                    break;
            }
            
            //calculating result
            if (calculatedResult >= 0)
            {
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
                Console.WriteLine("You entered value below zero");
                throw new Exception();
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
