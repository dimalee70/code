using System;

namespace lesson2_1Class
{
    public struct MyStruct : IMyInterface
    {
        public int myInt {get;set;}
        public MyStruct(int myInt)
        {
            this.myInt = myInt;
        }
      

        public void Hello()
        {
            System.Console.WriteLine("Hello");
        }

        public void print()
        {
            System.Console.WriteLine(myInt);
        }
    }
}