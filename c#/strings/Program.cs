using System;
using System.Globalization;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string str = string.Empty;
            str = "Привет";
            string myString = "привет";
            System.Console.WriteLine(str.Length);
            System.Console.WriteLine(str[4]);

            System.Console
                .WriteLine
                (string
                .Compare(str,myString,comparisonType: StringComparison.CurrentCulture));



            System.Console
                .WriteLine
                (string
                .Compare(str,myString,true, new CultureInfo("ru-RU")));

            // System.Console.WriteLine(CultureInfo.CurrentCulture);

            
        }
    }
}
