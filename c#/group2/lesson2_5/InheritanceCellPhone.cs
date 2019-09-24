using System;
namespace lesson2_5
{
    public class InheritanceCellPhone : CellPhone, BaseInterface
    {
        public InheritanceCellPhone(string model) : base(model){}
        public void hello()
        {
            System.Console.WriteLine("hello");
        }
    }
}