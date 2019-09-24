using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // string text = Console.ReadLine();
            // string [] stringArr = text.Split(" ");
            // string t = string.Empty;
            // foreach(string s in stringArr)
            // {
            //     // char[] charArr = s.ToCharArray();
            //     // t+= charArr[charArr.Length - 1] ;
            //     t+= s[s.Length-1];           
            // }
            // System.Console.WriteLine(t);


            Console.WriteLine("Hello World!");
            char[] text = Console.ReadLine().ToCharArray();
            char letter = Convert.ToChar(Console.ReadLine());

            // foreach(char c in text)
            // {
            //     if(char.IsUpper(c))
            //     {

            //     }
            // }

            for(int i = 0; i < text.Length;i++)
            {
                if((char.IsUpper(text[i])
                && char.ToLower(text[i]) == letter)
                || (text[i] == letter))
                {
                    text[i] = '*';
                }
            }

            System.Console.WriteLine(new string(text));
        }
    }
}
