using System;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // MyAbstarctClass myAbstarctClass  
            // = new MyAbstarctClass("Test");

            // MyClass myClass = new MyClass("SuperClass" , "Name");

            // myClass.printHello();

            // System.Console.WriteLine(myClass.getInfo());
        

            // MyAbstarctClass myAbstarctClass = new MyClass
            // ("SuperClass2", "Name2");

            // myAbstarctClass.printHello();
            // System.Console.WriteLine(myAbstarctClass.getInfo());
            // myAbstarctClass.printHello();

            // MyClass2 myClass2 = new MyClass2("MyClass2");

            // System.Console.WriteLine(myClass2.getInfo());

            int [] arr = new int [0];
            MyArray myArray = new MyArray(arr);
            myArray.add(3);
            myArray.add(5);
               myArray.add(7);
            myArray.add(9);
               myArray.add(10);
            myArray.add(12);
               myArray.add(14);
            myArray.add(16);
            System.Console.WriteLine("Size");
            System.Console.WriteLine(myArray.getCount());

            myArray.print();

            
            
        }
    }
    
}
