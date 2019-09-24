using System;

namespace lesson9Class
{
    public class Human
    {

        public Human(){}

        public Human(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string Name{get;set;}
        public int Age{get;set;}

        public void printInfo()
        {
            System
            .Console
            .WriteLine("Name " + Name + "\t" + "Age " + Age);
        }
    }
}