using System;

namespace inheritance
{
    class MyPoint
    {
        public int x{get; set;}
        public int y {get; set;}

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int sum(int x1, int y1)
        {
            x = x + x1;
            y += y1;
            return x +y;

        }

        public int sum(MyPoint other)
        {
            x += other.x;
            y += other.y;
            return x+y;
        }

    }
}