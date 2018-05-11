using System;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Статические конструкторы
            // Bus bus1 = new Bus(71);
            // Bus bus2 = new Bus(72);
            // bus1.Drive();
            // bus2.Drive();

            // Student st = new Student();
            // st.NameOfHuman = "Sasha";
            // st.StudentID = 12132332;
            // System.Console.WriteLine(st.NameOfHuman);
            // System.Console.WriteLine(st.StudentID);
            // st.sayHello();
            // виртуал Наследование
            // double r = 3.0, h = 5.0;
            // Shape c = new Circle(r);
            // Shape s = new Sphere(r);
            // Shape l = new Cylinder(r, h);
            // // Display results:
            // Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            // Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            // Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
            // c.PrintShape();
            // s.PrintShape();
            // l.PrintShape();
            FromAbsClass fromabs = new FromAbsClass();
            fromabs.sayHello();
            fromabs.sayGoodBiy();
            System.Console.ReadKey();
        }
    }
    
}
// Статические конструкторы
// виртуал Наследование
//Interface
//abstract
