using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Victor";
            bool isEqual = name == "Victor";
            string helloName = "Hello, " + name;
            // System.Console.WriteLine(helloName); 
            // System.Console.WriteLine(helloName.Length);
            // System.Console.WriteLine(helloName[3]);

            // char [] myCharArr = {'h', 'e', 'l', 'l', 'o'};
            // Array.Sort(myCharArr);
            // string text = new string(myCharArr);
            // System.Console.WriteLine(text);

            string test1 = "hellotest";
            string test2 = "Testhello";
        
            // char [] arrayCharFromString = text.ToCharArray();
            // System.Console.WriteLine(String.Compare(test1,
            //     test2, true));
            // System.Console.WriteLine(String.Compare(test1, 5,
            //     test2,0, 4, true));

            // bool isEquals = "test1".Equals("test1");
            // System.Console.WriteLine("test1".Equals("test1"));

            // string concatString = 
            //     String.Concat(test1, test2, test1, test2);
            // System.Console.WriteLine(concatString);

            // System.Console.WriteLine(test1.Contains("hello"));
            // System.Console.WriteLine(test1.StartsWith("he"));
            // System.Console.WriteLine(test1.IndexOf("e"));

            // string text = "Hello. My name is Mac!";
            // string[] splitString = text.Split('.', '!', '?');
            // System.Console.WriteLine(splitString.Length);
            // foreach (var item in splitString)
            // {
            //     System.Console.WriteLine(item);
            // }


            
            // string text = "Hello. My     name    is    Mac!";
            // string[] splitString = text.Split(" ", 
            //     StringSplitOptions.RemoveEmptyEntries);
            // System.Console.WriteLine(splitString.Length);
            // foreach (var item in splitString)
            // {
            //     System.Console.WriteLine(item);
            // }

            // string stringFromJoin = String.Join(" ", splitString);
            // System.Console.WriteLine(stringFromJoin);

            // string pasword = "gggggg   gffhdgd   gggggg";
            // System.Console.WriteLine(pasword);
            // pasword = pasword.Trim('g', ' ');
            // System.Console.WriteLine(pasword);


            // string text = "Hello";
            // text = text.PadLeft(30);
            // System.Console.WriteLine(text.Length);
            // System.Console.WriteLine(text);
            // text = text.PadRight(40);
            // System.Console.WriteLine(text.Length);
            // System.Console.WriteLine(text);

            // string text = "Hello";
            // text = text.Insert(2, "World");
            // System.Console.WriteLine(text);


            // string text = "Hello";
            // // text = text.Remove(2);
            // text = text.Remove(2, 2);
            // System.Console.WriteLine(text);

            // string text = "Hello Hello Hello Hello";
            // // text = text.Replace('l', '*');
            // text = text.Replace("Hello", "World");
            // System.Console.WriteLine(text);


            // string text = "Hello";
            // text = text.ToUpper();
            // System.Console.WriteLine(text);
            // text = text.ToLower();
            // System.Console.WriteLine(text);

            string text = "Hello World. I am programmer";
            int index = text.IndexOf("World");
            string sub = text.Substring(index);
            string subCount = text.Substring(index, 5);
            System.Console.WriteLine(sub);
            System.Console.WriteLine(subCount);






        }
    }
}
