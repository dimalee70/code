using System;

namespace lesson10Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // int t = 5;
            // User u = new User("Dima", 22);
            // User u2 = new User("RRRr", 22);
            // System.Console.WriteLine(u.ToString());
            // System.Console.WriteLine(u.GetHashCode());
            // System.Console.WriteLine(u.Equals(u));
            // System.Console.WriteLine(u.GetType());


            GroupA groupA = new GroupA("Aru", 18, 2, 1.3);
            int course = groupA.addToClassSchool();

            System.Console.WriteLine(course);
            System.Console.WriteLine(groupA.ToString());
            System.Console.WriteLine(groupA.GetHashCode());



        }
    }
}
