using System;
namespace lesson9
{
    public class MyPoint
    {
        public int x {get;set;}
        public int y {get;set;}

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public MyPoint summ (MyPoint other)
        {
            MyPoint returnMyPoint =
            new MyPoint(x + other.x, y + other.y);

            return returnMyPoint;
            // return new MyPoint(x + other.x, y + other.y);
        }

        public string toString()
        {
            return "x = " + x +"\ty " + y; 
        }
    }
}