using System;

namespace lesson9Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            // m.age = 18;

            // System.Console.WriteLine(m.age);
            // m.setAge(16);
            // System.Console.WriteLine(m.getAge());
            // Console.WriteLine("Hello World!");



            System.Console.WriteLine(3+2);
            System.Console.WriteLine("4" + 3);

            m.startMethod();
            m.startMethod(10);
            m.startMethod("Hello");

            System.Console.WriteLine(m.summ(5,4));
            System.Console.WriteLine(m.summ(6,7,8));

            Student student = new Student();
            Student student2 = new Student("Assem", 18, "1111111111");
            student2.printInfo();
            System.Console.WriteLine();
            student2.showStudent();
            myVoid();

        }
        public static void myVoid()
        {
            int t = 6;
            System.Console.WriteLine("Before return");
            if (t == 5)
                return;
            System.Console.WriteLine("End");
        }
    }
}
