using System;
namespace lesson10{
    public class Shape{
        public const double PI = Math.PI;
        protected double x, y;
        public Shape()
        {
        }
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double Area()
        {
            return x * y;
        }
        public  virtual void PrintShape(){
            double area = Area();
        }
    }
    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }
        public override double Area()
        {
            return PI * x * x;
        }
        public sealed override void PrintShape(){
            double area = Area();
            System.Console.WriteLine(area);
        }
    }
    class Sphere : Shape
        {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
        public sealed override void PrintShape(){
            double area = Area();
            System.Console.WriteLine(area+ "fgerger");
        }


    }
    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }

}