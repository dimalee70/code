using System;

namespace lesson12
{
    class MyClass
    {
        public string name;
        public int age;

        public MyClass()
        {
            name = "hello";
            age = 24;
            System.Console.WriteLine("Hello from constructor");
        }

        public MyClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void helloFromMyClass()
        {
            HelloClass helloClass = new HelloClass();
            string ans = helloClass.hello();
            System.Console.WriteLine(ans);
        }

        public void printInfo()
        {
            System.Console.WriteLine("name " + name);
            System.Console.WriteLine("age " + age);
        }
    }
}