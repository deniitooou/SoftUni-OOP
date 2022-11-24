namespace ValidationAttributes
{
    using System.Linq;

    using System.Reflection;
    using Attributes;

    public class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj
                .GetType()
                .GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(MyValidationAttribute))
                .Any())
                .ToArray();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                MyValidationAttribute attribute = property.GetCustomAttribute<MyValidationAttribute>();
                bool isValid = attribute.IsValid(value);

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}