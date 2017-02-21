namespace Converter
{
    using System;

    class InputConverter
    {
        public static double ConvertStringToDouble(string value, IFormatProvider provider)
        {
            return Convert.ToDouble(value, provider);
        }
    }
}
