using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyPoint m1 = new MyPoint(1,2);
            MyPoint m2 = new MyPoint(3,4);
            MyPoint m3 = m1.summ(m2);

            System.Console.WriteLine(m3.toString());

            Student s1 = new Student("Dima", 4);
            Student s2 = new Student("Aruzhan", 1);
            Student s3 = new Student("Assem", 3);
            Student s4 = new Student("Rabiga", 3);

            Student [] students = {s1, s2, s3, s4};

            s1.printStudent(students, 3);


        }
    }
}
