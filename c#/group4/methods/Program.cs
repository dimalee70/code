using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Console.WriteLine("Hello World!");
            // string text = "Hello World From C#";

            // string [] stringArr = text.Split();
            // string answer = "";
            // for(int i = 0; i < stringArr.Length; i++)
            // {
            //     string temp = stringArr[i];
            //     answer = answer + temp[temp.Length - 1];

            //     answer += stringArr[i][stringArr[i].Length - 1];
            // }
            // System.Console.WriteLine(answer);

            // string Text = "        hello           world         ";
            // string [] arr = Text.Split(' ', 
            // StringSplitOptions.RemoveEmptyEntries);
            // Text = String.Join(' ', arr);
            // System.Console.WriteLine(Text);


            // char c = (char)Console.Read();
            // System.Console.WriteLine(c);

            string r = Console.ReadLine();
            // char myChar = r[0];
            char myChar = (char)Console.Read();
            System.Console.WriteLine(myChar);

            r = r.Replace(Char.ToLower(myChar),'*')
            .Replace(Char.ToUpper(myChar), '*');
            System.Console.WriteLine(r);
            // Char.ToLower(myChar);
            // Char.ToUpper(myChar);
            // r.Replace();


        }
    }
}
