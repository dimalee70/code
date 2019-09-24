using System;
namespace classes
{
    class Student : Human
    {
        public static int num;
        public string studentId{get;set;}
        public int age{get;set;}

        public Student(string name, string studentId, int age):base(name)
        {
            this.studentId = studentId;
            this.age = age;
        }

        static Student()
        {
            System.Console.WriteLine("Hello From Student");
        }
        // static Student(int t)
        // {
        //     System.Console.WriteLine(t);
        // }

        public override void prinInfo()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(studentId);
        }

        public override string ToString()
        {
            return name;
        }

        public static String Reverse( ref string name)
        {
            char[] n = name.ToCharArray();
            Array.Reverse(n);
            name = String.Join("",n);
            return name;
        }
    }
}