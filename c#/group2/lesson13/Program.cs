using System;

namespace lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            // User user = new User();

            User user2 = new User("Dima");

            // User user3 = new User(13);

            // User user4 = new User("Test", 25);

            // user.setName("Dima");
            // user.setAge(24);

            // System.Console.WriteLine(user.getName());
            // System.Console.WriteLine(user.getAge());

            // user.Age = 18;
            // user.Name = "Dima";

            // System.Console.WriteLine(user.Name);

            // System.Console.WriteLine(6 + 7);

            User user = new User();
            user.race = "Негроидная";
            user.sex = "male";
            // user.print();

            user.Name = "John";
            user.Age = 54;
            // user.printInfo();

            User u = new User ("Негроидная", "male", "John",25);

            // System.Console.WriteLine();
            // u.print();
            // System.Console.WriteLine();
            // u.printInfo();

            System.Console.WriteLine("ToString()");
            System.Console.WriteLine(u);
        }
    }
}
