namespace Converter
{
    using System.ComponentModel;

    class EnumHelper
    {
        public static string GetEnumDescriptionAttribute<T>(T value)
        {
            var type = typeof(T);
            var memInfo = type.GetMember(value.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute),
                false);
            var description = ((DescriptionAttribute)attributes[0]).Description;
            return description;
        }
    }
}
