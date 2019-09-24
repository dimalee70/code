using System;
namespace lesson2_5
{
    public class TestClass: CellPhone, BaseInterface
    {
        public TestClass(string model) : base(model){}

        public void hello()
        {
            System.Console.WriteLine("fbdfnkdsbjhdss");
        }
    }
}