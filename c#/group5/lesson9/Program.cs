using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // User user = new User();
            // user.name = "Dmitriy";
            // User user2 = new User();
            // user2.name = "Dmitriy2";
            // System.Console.WriteLine(user.name);
            // System.Console.WriteLine(user2.name);
            // user.printInfo();



            User u = new User("Pasha",30);

            u.name = "Dima";

            // u.setName("Test");
            // u.printInfo();

            // u.Name = "Hello";


            System.Console.WriteLine(u.Name);

            // User u2 = new User("Pasha", 30);

            // User u3 = u2;

            // u3.printInfo();
            
            // int t  = 5;
            // int n = 0;
            // n = t ;
            // t = 10;
            // System.Console.WriteLine(n);

            // System.Console.WriteLine(u2.Equals(u3));
           
            // System.Console.WriteLine(u2.GetHashCode());
            // System.Console.WriteLine(u3.GetHashCode());
            // System.Console.WriteLine(u.GetHashCode());

            // System.Console.WriteLine(u2.GetType());

            // System.Console.WriteLine(u);


        }
    }
}
