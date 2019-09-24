using System;

namespace lesson10
{
    public class Human
    {
        public string Name{get;set;}

        public int Age {get;set;}

        public Human(){}

        public Human(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void printInfo()
        {
            System.Console.WriteLine("Name " + Name +"\tAge " + Age);
        }
    }
}