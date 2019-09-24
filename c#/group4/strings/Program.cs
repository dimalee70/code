using System;
using System.Globalization;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "abcText";
            string t2 = "textabc";
            Console.WriteLine("Hello World!");
            // System.Console.WriteLine(t.Length);
            int a = string.Compare(t,t2);

            int a2 = string.Compare(t,3,t2,0,4);
            System.Console.WriteLine(a);
            // CultureInfo c = CultureInfo.CurrentCulture;
            int a3 = string.Compare(t,t2, true,CultureInfo.CurrentCulture);

            System.Console.WriteLine(a3);

            System.Console.WriteLine(a2);

            int compareTo = t.CompareTo(t2);

            System.Console.WriteLine(t.Equals(t2));

            System.Console.WriteLine(t.Equals(t2, StringComparison.CurrentCultureIgnoreCase));

            System.Console.WriteLine(string.Equals(t,t2));

            string newT = string.Concat(t,t2);
            System.Console.WriteLine(newT);

            string newManyString = 
            string.Concat(t,t2,"hello","my","name");

            System.Console.WriteLine(newManyString);

            bool isContains =  newManyString.Contains("h");
            // System.Console.WriteLine(isContains);

            bool isStratWith = newManyString.StartsWith("abcD");
            // System.Console.WriteLine(isStratWith);

            int indexOf = newManyString.IndexOf("text123");
            // System.Console.WriteLine(indexOf);

            // int indexOfStart = newManyString.IndexOf('t',8);
            // // System.Console.WriteLine(indexOfStart);

            // int indexOfStartCount = 
            //     newManyString.IndexOf('t',8,2);

            // System.Console.WriteLine(indexOfStartCount);

            // int indexOfAny = 
            //     newManyString.IndexOfAny(new char[]{'t', 'a', 'b','c'});
            // System.Console.WriteLine(indexOfAny);

            // int lastIndexOf = 
            //     newManyString.LastIndexOf('t');
            // System.Console.WriteLine(lastIndexOf);

            string text = "Hello my Name Is John";

            string [] splitText = text.Split
            (new string []{"l"," ","J"},text.Length,
            StringSplitOptions.RemoveEmptyEntries);

            string s = new string(new char [] {'a', 'b', 'c'});
            System.Console.WriteLine(s);

            // foreach(string s in splitText)
            // {
            //     System.Console.WriteLine(s);
            // }

            string textJoin = string.Join(" ", splitText);

            System.Console.WriteLine(textJoin);

            string trim = "         hello             ";
            string aTrim = trim.Trim(' ','h', 'l');
            System.Console.WriteLine(aTrim.Length);
            aTrim = aTrim.PadLeft(10);
            System.Console.WriteLine(aTrim);
            System.Console.WriteLine(aTrim.Length);

            aTrim = aTrim.Insert(0, "hello");
            System.Console.WriteLine(aTrim);
            aTrim = aTrim.Remove(5, 2);
            System.Console.WriteLine(aTrim);

            aTrim = aTrim.Replace("h", "b");
            System.Console.WriteLine(aTrim);

            string subStr = aTrim.Substring(7).Trim();
            System.Console.WriteLine(subStr);
            subStr = subStr.ToLower();
            char c = Char.ToUpper(subStr[0]);
            System.Console.WriteLine(c);
            char [] ch = subStr.ToCharArray();
            ch[0] = c;
            subStr = new string(ch);
            System.Console.WriteLine(subStr);
            // System.Console.WriteLine(aTrim.ToLower());









            // System.Console.WriteLine(splitText[0]);





        }
    }
}
