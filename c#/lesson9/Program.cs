using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 0; i < 12; i ++){
            //     User us = new User(i);
            // }
            System.Console.WriteLine("cdcd" + "dwdw");
            System.Console.WriteLine(4 + 4);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
            // int i = 1;
            // MyClass obj = new MyClass(i);
            User us = new User("Dmirerf",1323);
            // System.Console.WriteLine(us.Name);
            // us.Name = "Dmi";
            // us.Id = 1;
            // System.Console.WriteLine(us.Name);
            // System.Console.WriteLine(us.Id);
            User us2 = new User();
            us2.nameOfUser = "Dcdscsdc";
            System.Console.WriteLine(us2.nameOfUser);
            // System.Console.WriteLine(us2.Name);
            // System.Console.WriteLine(us2.Id);
            // System.Console.WriteLine(us2.age);
            // System.Console.WriteLine(us2.Id);
            // for (; i < 120000; i++)
            // {
            //     MyClass mc = new MyClass(i);
            //     System.Console.WriteLine(mc.GetSetI);
            // }

            
            // char myCH = 'A';
            // Console.WriteLine("\nКонец");
            // obj.Method1(myCH);
            // Console.WriteLine("Использование метода без ключевого слова this: {0}", obj.ch);
            // obj.Method2(myCH);
            // Console.WriteLine("Использование метода c ключевым словом this: {0}", obj.ch);
            // Console.ReadLine();

        }
    }
}
