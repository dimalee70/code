using System;
namespace lesson2_8
{
    public class Person
    {
        public int Age{get;set;}

        public string Name{get;set;}
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}