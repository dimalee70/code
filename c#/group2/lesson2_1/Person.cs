using System;
namespace lesson2_1
{
    public class Person
    {
        public string Name{get;set;}
        public string Phone{get;set;}
        public Person(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }


        public override string ToString()
        {
            return "Name = " + Name + "\tPhone "+ Phone;
        }
    }
}