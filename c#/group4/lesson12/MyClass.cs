using System;

namespace lesson12
{
    public class MyClass : MyAbstarctClass
    {
        public String Name{get;set;}
        public MyClass(string Tag, string Name) : base(Tag)
        {
            this.Name = Name;
        }

        public override string getInfo()
        {
            return "Name " + Name + "\tTag " + Tag;  
        }
    }
}