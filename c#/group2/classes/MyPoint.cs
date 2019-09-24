using System;

namespace classes
{
    class MyPoint
    {
        public int x{get;set;}
        public int y{get;set;}
        public int z{get;set;}

        private int sum;
        public MyPoint()
        {
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.sum = x+y;
        }
        public MyPoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.sum = x+y+z;
            System.Console.WriteLine(Student.num);
        }
     
        public int getSum()
        {
            return sum;
        }
        public String print()
        {
            return x + " " + y +" " +z;
        }
        public override String ToString()
        {
            return x + " " + y +" " +z;
        }
    }
}