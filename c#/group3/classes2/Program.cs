using System;

namespace classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Human human = new Human();
            // human.Name = "Hello";
            // human.setAge(10);
            // System.Console.WriteLine(human.Name);
            // System.Console.WriteLine(human.getAge());

            Human human = new Human();
            human.setAge(10);
            human.Name = "Human";

            Human human1 = new Human("Name" , 11);

            System.Console.WriteLine(human.sum(1,3));

            System.Console.WriteLine(human.sum(1,2,3));

            System.Console.WriteLine(1+2);
            System.Console.WriteLine("1" + 4);


            Student student = new Student();

            student.Name = "John";
            student.setAge(12);
            student.ID = "12345";

            string info = student.printStudent();

            System.Console.WriteLine(info);

            Student s = new Student();
            s.t = 10;

            Student y = new Student();
            y.t = 5;
            System.Console.WriteLine(s.pluss(y));

            

            System.Console.WriteLine(s.printStudent());

            Test test = new Test();

            System.Console.WriteLine(test.printStudent());
        }
    }
}
