using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student student = new Student("Test", 3);
            Student [] students = {new Student("Test1", 3),
            new Student("Test2", 2),
            new Student("Test3", 3),
            new Student("Test4", 4)};
        
            student.printStudents(students, 3);


            MyPoint myPoint = new MyPoint(1,2);

            // int t = myPoint.sum(3,4);
            // System.Console.WriteLine(t);
            // System.Console.WriteLine(myPoint.x);
            // System.Console.WriteLine(myPoint.y);

            MyPoint myPoint2 = new MyPoint(3,4);
            System.Console.WriteLine("Summ MyPoint other " + 
            myPoint.sum(new MyPoint(5,6)));
            // myPoint.sum(myPoint2);

            System.Console.WriteLine("X " + myPoint.x);
            System.Console.WriteLine("Y " + myPoint.y);



        }
    }
}
