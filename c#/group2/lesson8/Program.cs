using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Привет мир
            // мир Привет
            // зим тевирП
            string name = "Dima";
            char [] charFromStr = name.ToCharArray();//{'D','i','m','a'}
            System.Console.WriteLine(charFromStr[2]);

            // char [] charArr ={'H','e', 'l', 'l', 'o'};
            // Array.Reverse(charArr);
            // string n = new string(charArr);

            // string testString = "My name is Dias, I am cool programmer";

            // for(int i = 0; i < testString.Length; i++)
            // {
            //     if(testString[i] == ' ')
            //     {
            //         System.Console.WriteLine();
            //         continue;
            //     }
            //     System.Console.Write(testString[i]);
            // }
            // Console.WriteLine(n);




            // string myCompStr = "Hello";
            // string myCompStr2 = "Hello";
            // // int ans = string.Compare(myCompStr, myCompStr2, StringComparison.);
            // // System.Console.WriteLine(ans);

            // // int a = myCompStr.CompareTo(myCompStr2);

            // // System.Console.WriteLine(a);

            // // if(myCompStr.Equals(myCompStr2))
            // // {
            // //     System.Console.WriteLine("Equals");
            // // }
            // // else {
            // //     System.Console.WriteLine("Not Equals");
            // // }

            // // if(myCompStr == myCompStr2)
            // // {
            // //     System.Console.WriteLine("Equals");
            // // }
            // // else {
            // //     System.Console.WriteLine("Not Equals");
            // // }

            // // System.Console.WriteLine(string.Equals(myCompStr,myCompStr2));
            
            // // string myConcatStr = string.Concat(myCompStr, myCompStr2);
            // // string myConcatStr = myCompStr + myCompStr2;
            // // System.Console.WriteLine(myConcatStr);

            // // string testString = "My name is Dias, I am cool programmer";
            // string[] myStringArr = {"Hello", "World","My", "namHe", "is", "Dias" };

            // string res = string.Concat(myStringArr);
            // System.Console.WriteLine(res);

            // // System.Console.WriteLine(res.Contains("iD"));

            // // System.Console.WriteLine(res.StartsWith("Hellohihhihu"));


            // // int idx = res.IndexOf("H",5);

            
            // // int idx = res.IndexOfAny(new char[]{'j','z'}, 5, 4);
            // // System.Console.WriteLine(idx);

            // string textSplit = "My name is Dias, I am cool programmer";

            // string[] textArrSplit = textSplit.Split(new char[]{' ','D'},
            // StringSplitOptions.RemoveEmptyEntries);

            // foreach(string n in textArrSplit)
            // {
            //     System.Console.Write(n+" ");
            // }
            // System.Console.WriteLine();
            // System.Console.WriteLine(textArrSplit.Length);

            // string textJoin = string.Join(',',textArrSplit);

            // System.Console.WriteLine(textJoin);

            // string textTrim = "eeeeeee  rrrrr     Hello My name is John    rrreee    rrrrrrr";


            // System.Console.WriteLine(textTrim);
            // // System.Console.WriteLine(textTrim.Trim());
            // System.Console.WriteLine(textTrim.Trim('e','r',' '));

            // System.Console.WriteLine(textTrim.Length);

            // string t = textTrim.PadLeft(80);
            // System.Console.WriteLine(t);

            // string textSub = "is John";  
            // System.Console.WriteLine(textSub.Substring(3,2));

        }
    }
}
