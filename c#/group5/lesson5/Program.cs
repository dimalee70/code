using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dmitriy";
            
            // char [] stringChar = name.ToCharArray();
            // foreach(char c in name)
            // {
            //     System.Console.Write(c + " ");
            // }
            // System.Console.WriteLine();
            // System.Console.WriteLine(name[0]);
            // stringChar[0] = 'Q';
            

            // string nam = new string(stringChar);
            // for(int i = 0; i < nam.Length; i++)
            // {
            //     System.Console.Write(nam[i]);
            // }
            // System.Console.WriteLine();


            string str1 = "programming";
            string str2 = "22helllllo";

            // System.Console.WriteLine
            // (string.Compare(str1, str2, true));

            // System.Console.WriteLine
            // (string.Compare(str1, 0, str2,2, 3, true));

            System.Console.WriteLine(str1.CompareTo("hello"));

            // object o = "rfr";
            // object o2 = o;
            // System.Console.WriteLine(o.Equals(o2));

            // System.Console.WriteLine(str1.Equals(str2));

            // System.Console.WriteLine(string.Equals(str1, str2));

            // System.Console.WriteLine
            //     (string
            //     .Concat
            //         (str1, str2, "dfsdfs","dsfdfs","sdfdsfsd"));

            // System.Console.WriteLine(str1.Contains("hel123"));

            // System.Console.WriteLine(str1.StartsWith("ahell"));

            // System.Console.WriteLine(str1.IndexOf("elll"));

            // System.Console.WriteLine(str1.IndexOf("ro", 3, 7));

            // System.Console.WriteLine(str1.LastIndexOf('r'));

            // System.Console.WriteLine(
            //     str1
            //     .IndexOfAny(new char[]{'a', 'g'}));
                
            // System.Console.WriteLine(
            //     str1.LastIndexOfAny(new char[]{'a','g'})
            // );

            // string text = "Hello My Name is John";
            // string [] words = text.Split(new char[]{' ', 's'}, 
            // StringSplitOptions.RemoveEmptyEntries);

            // foreach(string d in words)
            // {
            //     System.Console.WriteLine(d );
            // }
            // System.Console.WriteLine();

            // string textJoin = string.Join(" ",words);

            // System.Console.WriteLine(textJoin);

            string textTrim = "      H    E    llo             ";

            System.Console.WriteLine(textTrim);
            textTrim = textTrim.Trim();
            System.Console.WriteLine(textTrim.Trim());


            // textTrim.PadLeft(20);
            
            // System.Console.WriteLine(textTrim.PadLeft(40));

            // textTrim = textTrim.Insert(3,"hello");
            // System.Console.WriteLine(textTrim);

            // textTrim = textTrim.Remove(4, 2 );
            // System.Console.WriteLine(textTrim);

            // textTrim = textTrim.Replace(' ', '*') + "H**";
            // textTrim = textTrim.Replace("H**", "HW");
            // System.Console.WriteLine(textTrim);


            // System.Console.WriteLine(textTrim.Substring(4));

            // System.Console.WriteLine("Enter text");

            // string str = Console.ReadLine();


            // string [] tempWords = str.Split();

            

            // for(int i=0; i< tempWords.Length; i++){
            //     char[] temp = tempWords[i].ToCharArray();
            //     Array.Reverse(temp);
            //     tempWords[i] = new string(temp);
            // }
            // Array.Reverse(tempWords);

            // string strResult = String.Join(" ",tempWords);

            // System.Console.WriteLine(strResult);

            System.Console.WriteLine("Enter text");
            string str = Console.ReadLine();
            char [] numbers = new char [0];

            // foreach(char c in str.ToCharArray())
            // {
            //     System.Console.WriteLine((int)c);
            // }
            for(int i=0; i< str.ToCharArray().Length; i++)
            {
                int temp = (int) str[i];
                // System.Console.WriteLine(temp);
                if(temp>=48 && temp<=57)
                {
                // if(str[i]=='2'){
                    Array.Resize(ref numbers, numbers.Length+1);
                    numbers[numbers.Length-1]=str[i];
                }
            }
            string strResult = string.Join("",numbers);
            System.Console.WriteLine(strResult);

        
        }
    }
}
