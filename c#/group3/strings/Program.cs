using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // string str = "MyMy";
            // string str2 = "My";

            // System.Console.WriteLine(string.Compare(str,2,str2, 2, 1, true));


            // char [] myWord = {'h','e','l','l','o'};
            // string str2 = new string(myWord);
            // System.Console.WriteLine(str2);

            // System.Console.WriteLine(str2[0]);
            // System.Console.WriteLine(str2.Length);
            // foreach(char c in str2)
            // {
            //     System.Console.Write(c + " ");
            // }
            // System.Console.WriteLine();
            // str2.ToCharArray();

            // int digit = string.Compare(str,str2, false, StringComparison.CurrentCulture, );
            // System.Console.WriteLine(digit);

            // System.Console.WriteLine(string.CompareOrdinal(str, str2));

            // System.Console.WriteLine(str.CompareTo(str2));

            string name = "Ar,,,uzhan      is ..co.ol prog,,,,rAmmer";
            string name2 = "Aid";

            if(name == name2)
            {
                System.Console.WriteLine("Equal");
            }
            else
            {
                System.Console.WriteLine("Not equals");
            }

            // string.Equals(name, name2);

            System.Console.WriteLine(string.Concat(name, name2));
            string ans = string.Concat(name, name2, "vdvsdcds","5456546", "Hello","Dima");
            System.Console.WriteLine(ans);

            // System.Console.WriteLine(name.Contains("Au"));

            // bool isStart = name.StartsWith("ru");
            // System.Console.WriteLine(isStart);

            // bool isEnd = name.EndsWith("ru");
            // System.Console.WriteLine(isEnd);

            // int indexOfA = name.IndexOf("S", 3, 1);
            // System.Console.WriteLine(indexOfA);

            // System.Console.WriteLine(name.IndexOfAny(new char[] {'r','i','p',}));
            // int temp = 1______236_654;
            // System.Console.WriteLine(temp);

            // System.Console.WriteLine(name.LastIndexOf('A'));

            string[] world = name.Split(' ',StringSplitOptions.RemoveEmptyEntries);



            char[] letters = world[0].ToCharArray();

            // System.Console.WriteLine(world.Length);

            // System.Console.WriteLine(world[0]);
            // System.Console.WriteLine(letters[0]);

            // foreach(string s in world)
            // {
            //     System.Console.WriteLine(s);
            // }
            // System.Console.WriteLine(world.Length);

            // string text = string.Join('!', world, 2, 1);
            // System.Console.WriteLine(text);

            // string textTrim = "   eeeeeeee    Hello           World    eeeeee            ";

            // System.Console.WriteLine(textTrim);

            // System.Console.WriteLine(textTrim.Trim());

            // string text2 = textTrim.Trim(' ', 'e', 'H');
            // System.Console.WriteLine(textTrim.Trim(' ', 'e', 'H'));

            // System.Console.WriteLine(text2.PadLeft(30));
            // System.Console.WriteLine(text2.l);

            string test = "HEllo";

            test = test.Insert(3,"hi");
            System.Console.WriteLine(test);

            test = test.Remove(3,2);
            System.Console.WriteLine(test);

            test = test.Replace("H","Eror");
            System.Console.WriteLine(test);
            test = test.Substring(3);
            System.Console.WriteLine(test);

            test = test.Substring(0,1);
            System.Console.WriteLine(test);








        }
    }
}
