using System;
using lesson2_3.interfaces;
namespace lesson2_3
{
    public struct MyStruct:newinterface
    {

        public void Hello()
        {
            System.Console.WriteLine("Hello");
        }
        public string Name{get;set;}
        public int Age{get;set;}

        public MyStruct(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }

        

    }
}