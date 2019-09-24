using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name  = "Test";
            // name.


            
            // System.Console.WriteLine(u.id + " " + u.name);
            // System.Console.WriteLine(u2.id + " " + u2.name);

            // Console.WriteLine("Hello World!");

            // int [] t =  {10,20,30};
            // string[] names = {"John", "Test", "Petya"};

            // printYearName(t, names);


            // largestLength
            // (new string[]{"Hello", "My", "namesdvsvsd", "dfdfdd"});

            User u  = new User();
            u.setId(1);
            u.setName("John");
            // u.id = 1;
            // u.name = "John";

            User u2 = new User();
            
            // u2.id = 2;
            // u2.name = "Bill";

            User u3 = new User();

            User u4 = new User(5);
            User u5 = new User("Lesha");
            User u6 = new User(10, "John");

            User[] arr = new User[]{u4, u5, u6};

            foreach(var r in arr)
            {
                r.printInfo();
            }
            

            u6.iD = 32;

            // u6.Name = "fdfvfd";

            // u6.Id = 4;

            // u6.printInfo();

           

            // u.printInfo();
            // u2.printInfo();
            // u3.printInfo();

            u6.printInfo();

            u6.setId(20);
            u6.setName("Hello");

            // u6.printInfo();

            // int u6Id = u6.getId();

            // System.Console.WriteLine(u6Id);




        }

        static void largestLength(string [] arr)
        {
            int maxLength = arr[0].Length;
            string maxString = arr[0];
            foreach(string s in arr)
            {
                if(maxLength < s.Length)
                {
                    maxLength = s.Length;
                    maxString = s;
                }
            }

            System.Console.WriteLine(maxString);
        }

        public static void printYearName(int[] t , string[] s)
        {
            for(int i = 0; i < t.Length; i++)
            {
                System.Console.WriteLine(t[i] + " " + s[i] );
            }
            
        }
    }
}
