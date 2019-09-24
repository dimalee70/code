using System;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // string name = "Dima";
            // int t = name.Length;

            // MyClass myClass = new MyClass();
            // MyClass myClass2 = new MyClass();

            // // int  t2  = 5;

            // // int t3 = t2;

            // // t2 = 6;

            // // System.Console.WriteLine(t3);
            // // System.Console.WriteLine(t2);

            // myClass.age = 18;
            // myClass.name = "Dima";

            // MyClass myClass3 = myClass;

            // myClass.name = "Hello";
            // myClass.age = 25;

            // System.Console.WriteLine(myClass3.age);
            // System.Console.WriteLine(myClass3.name);



            // myClass2.age = 20;
            // myClass2.name = "Human";

            // System.Console.WriteLine(myClass.age);
            // System.Console.WriteLine(myClass.name);

            // System.Console.WriteLine(myClass2.age);
            // System.Console.WriteLine(myClass2.name);

            // myClass.helloFromMyClass();

            // MyClass myClass4 = new MyClass{age = 12, name = "sdfsd"};

            // MyClass myClass5 = new MyClass();
            // System.Console.WriteLine(myClass5.age);
            // System.Console.WriteLine(myClass5.name);
            // System.Console.WriteLine(myClass4.name);
            // System.Console.WriteLine(myClass4.age);

            MyClass myClass = new MyClass();
            System.Console.WriteLine(myClass.age);

            MyClass myClass2 = new MyClass("John", 29);

            myClass2.printInfo();
            System.Console.WriteLine(myClass.ToString());
            System.Console.WriteLine(myClass.GetHashCode());
            HelloClass hello = new HelloClass();
            MyClass myClass3 = myClass2; 
            System.Console.WriteLine(myClass2.Equals(myClass3));

            System.Console.WriteLine(myClass2.GetType());

        }
    }
}
