using System;
namespace lesson10
{
    public class Circle2 : Circle
    {
        public Circle2(double r) : base(r)
        {
        }
        public override double Area()
        {
            return PI * x * x * x;
        }
        // public sealed override void PrintShape(){
        //     double area = Area();
        //     System.Console.WriteLine(area);
        // }
    }
}