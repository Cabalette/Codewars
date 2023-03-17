namespace Convert_string_to_camel_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ToCamelCase("the-stealth-warrior"));
        }
        public class Kata
        {
            public static string ToCamelCase(string str)
            {
                return string.Join("", str.Split('_', '-').
                                           Select((x, idx) => idx != 0 ? x[0].ToString().ToUpper() + x.Substring(1) : x));
            }
        }
    }
}