using System;

namespace classes
{
    class Program
    {

        static string maxStr(params string [] arr)
        {
            int maxidx = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i].Length > arr[maxidx].Length)
                {
                    maxidx = i;
                }
               
            }
            return arr[maxidx];
        }

        static void printNameAgeInArray(string [] names, int [] ages)
        {
            for(int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine(names[i]);
                System.Console.WriteLine(ages[i]);
            }
        }

        static void printNameAgeInArray(string [] names, int [] ages, int idx)
        {
            // for(int i = 0; i < names.Length; i++)
            // {
                System.Console.WriteLine(names[idx]);
                System.Console.WriteLine(ages[idx]);
            // }
        }
        static void Main(string[] args)
        {
            // int t = 5;
            // Console.WriteLine("Hello World!");
            // Human human = new Human();

            // Human human2 = new Human();
            // Human human3 = new Human(5, "test");

            // Human[]  h = new Human[10]; 

            // Human [] humans = {human, human2, human3};
            // int [] t = {1,2,3,4,5,};
            // human.printHumanByAge(humans, Convert.ToInt32(Console.ReadLine()));
            // human2.age = 16;
            // human.age = 13;


            // human3.printHuman();

            // string name = "";

            // System.Console.WriteLine(maxStr("hello", "My", "dsfd", "dsfdfs", "Hello World", "ds", "dfsd"));


        //     int [] arr = new int[0];
        //     while(true)
        //     {

        //         System.Console.WriteLine("Enter the number");
        //         int t = Convert.ToInt32(Console.ReadLine());
        //         if(t == -1)
        //         {
        //             break;
        //         }
        //         int [] arr2 = new int[arr.Length + 1];
        //         Array.Copy(arr, arr2, arr.Length);
        //         arr2[arr2.Length-1] = t;

        //         arr = arr2;

        //     }

        //     foreach(int t in arr)
        //     {
        //         System.Console.Write(t + " ");
        //     }
        //     System.Console.WriteLine();
        // 
        // printNameAgeInArray(new string[] {"Dima", "Aruzhan", "Islam", "Aidana"},
        // new int [] {18, 6,7,8}, 0);

        // System.Console.WriteLine("Enter the text");
        // string text = Console.ReadLine().ToLower();
        // System.Console.WriteLine("Enter the char");
        // char c = Char.ToLower(Convert.ToChar(Console.ReadLine()));

        // System.Console.WriteLine(text.LastIndexOf(c));


        System.Console.WriteLine("Enter the text");
        string text = Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter the char");
        char c = Char.ToLower(Convert.ToChar(Console.ReadLine()));

        System.Console.WriteLine(text.Replace(c, '*'));

        // string [] textSplit = text.Split(" ");

        // text = text.Trim();

        // string [] str = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        // text = string.Join(" ", str);
        // System.Console.WriteLine(text);
        // int counter = 0;


        // foreach(string s in textSplit)
        // {
        //     char [] c = s.ToCharArray();
        //     // if(Char.IsUpper(c[0]))
        //     // {
        //     //     counter++;
        //     // }
        //     if(c[0] >= 'A' && c[0]<= 'Z')
        //         counter++;
        // }
        // System.Console.WriteLine(counter);
        
        }
    }
}
