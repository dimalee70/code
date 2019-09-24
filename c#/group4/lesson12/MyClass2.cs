using System;

namespace lesson12
{
    public class MyClass2 : MyAbstarctClass
    {
        public int age{get;set;}
    
        public MyClass2(string Tag) : base(Tag)
        {
        }

        public override string getInfo()
        {
            return "Age " + age + "\tTag " + Tag;   
        }
    }
}