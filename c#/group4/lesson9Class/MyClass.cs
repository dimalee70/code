using System;
namespace lesson9Class
{
    public class MyClass
    {
        public int age{get;set;}
        public string name{get;set;}

        public MyClass(){}

        public MyClass(int age)
        {
            this.age = age;
        }

        public MyClass(int age, string name){}

        public MyClass(string name, int age){}

        public MyClass(int a, int b)
        {
        }


        public void startMethod()
        {
            System.Console.WriteLine("Start null");
        }

        public void startMethod(int age)
        {
            System.Console.WriteLine("Start " + age);
        }

        public void startMethod(string arg)
        {
            System.Console.WriteLine("Start " + arg + " string");
        }

        public int summ(int a, int b)
        {
            return a+b;
        }

        public int summ(int a, int b, int c)
        {
            return a+b+c;
        }
        // public int getAge()
        // {
        //     return age;
        // }

        // public void setAge(int age)
        // {
        //     this.age = age;
        // }

    }
}