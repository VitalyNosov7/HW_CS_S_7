namespace HW_7
{
    internal class Program
    {
        static string ObjectToString(object o)
        {
            Type type = o.GetType();
            string result = "";

            foreach (var property in type.GetProperties())
            {

                CustomNameFieldAttribute attribute = (CustomNameFieldAttribute)Attribute.GetCustomAttribute(property, typeof(CustomNameFieldAttribute));

                if (attribute != null)

                {
                    string originalFieldName = attribute.OriginalFieldName;
                    string customFieldName = attribute.CustomFieldName;
                    result += $"{customFieldName}";
                }

                else
                {
                    string name = property.Name;
                    result += $"{name}";
                }
            }

            return result;
        }

        static string StringToObject(object o)
        {
            Type type = o.GetType();
            string result = "";
            foreach (var property in type.GetProperties())
            {
                CustomNameFieldAttribute attribute = (CustomNameFieldAttribute)Attribute.GetCustomAttribute(property, typeof(CustomNameFieldAttribute));
                if (attribute != null)

                {
                    string originalFieldName = attribute.OriginalFieldName;
                    string customFieldName = attribute.CustomFieldName;
                    object? value = property.GetValue(o, null);
                    result += $"{customFieldName}: {value}n";
                }
                else
                {
                    string name = property.Name;
                    object? value = property.GetValue(o, null);
                    result += $"{name}: {value}n";
                }
            }
            return result;
        }

        static void Main(string[] args)
        {

            TestClass myObject = new TestClass { OriginalFieldName = "Это значение, переданное пользователем." };

            string result1 = ObjectToString(myObject);
            Console.WriteLine(result1);

            string result2 = StringToObject(myObject);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}