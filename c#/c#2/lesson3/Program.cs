using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {

            User us = new User();
            System.Console.WriteLine(us.getName());
            Fraction fr = new Fraction(4,8);
            fr.simplify();
            fr.Aruzhan();
            System.Console.WriteLine(fr.Nurtilek());
            // us.setName("Dima");
            System.Console.WriteLine(us.nameOfUser);
            // string name;
            System.Console.WriteLine(5.5%1);
            // int age;
            // name = "Dima";
            // age = 24;
            // // Console.WriteLine("Hello World!");
            // PrintHello(name);
            // //PrintHello();   // us.nameOfUser = "Dima";
            // int t = getAge(age);
            // System.Console.WriteLine(t);
        }
        static void PrintHello(string name){
            System.Console.WriteLine($"Hello {name}");
        }
        static int getAge(int age){
            return age;
        }
    }
}
