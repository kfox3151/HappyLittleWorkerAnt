using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Common
{
    public class EnumHelper
    {
        public static string GetRandomEnumDescription<T>()
        {
            var values = Enum.GetValues(typeof(T));
            var randomItem = (T)values.GetValue(NumberHelper.GenerateRandomNumber().Next(values.Length));

            var description = GetDescription(randomItem as Enum);

            return description;
        }

        public static int GetRandomEnumDescriptionAndParse<T>()
        {
            var description = GetRandomEnumDescription<T>();
            int parsedDescription;

            int number;
            var canParse = int.TryParse(description,out number);
            if (canParse)
            {
                parsedDescription = int.Parse(description);
            }
            else parsedDescription = -1;

            return parsedDescription;
        }

        public static string GetDescription(Enum value)
        {
            return
                value
                    .GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    ?.GetCustomAttribute<DescriptionAttribute>()
                    ?.Description;
        }
    }
}
