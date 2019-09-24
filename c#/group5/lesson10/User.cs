using System;
namespace lesson10
{
    class User
    {
        public User(){}

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void printHello()
        {
            System.Console.WriteLine("Hello");
        }

        public void printHello(string word)
        {
            System.Console.WriteLine("Hello " + word);
        }

        public int age {get;set;}
        public string name {get;set;}
    }
}