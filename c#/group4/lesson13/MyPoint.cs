using System;
namespace lesson13
{
    public class MyPoint
    {
        public int x {get; set;}
        public int y {get;set;}

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() 
        {
            return "x = " + x + "\t" + "y = " + y;
        }

        public static MyPoint operator +(MyPoint m1, 
                                        MyPoint m2)
        {
            MyPoint newM = new MyPoint(m1.x + m2.x,
                                        m1.y + m2.y);
            return newM;
        }

        public static bool operator ==(MyPoint m1,
                                      MyPoint m2)
        {
            if(m1.x == m2.x && m1.y == m2.y)
                return true;
            return false;
        }

        public static bool operator !=(MyPoint m1,
                                      MyPoint m2)
        {
            if(m1.x == m2.x && m1.y == m2.y)
                return false;
            return true;
        }

        public static bool operator true(MyPoint m1)
        {
            if(m1.x == m1.y)
                return true;
            return false;
        }

        public static bool operator false(MyPoint m1)
        {
            if(m1.x == m1.y)
                return false;
            return true;
        }
        public static bool operator !(MyPoint m1)
        {
            if(m1.x != m1.y)
                return true;
            return false;
        }

        public static implicit operator string(MyPoint m1)
        {
            return m1.x + " " + m1.y; 
        }
        public static explicit operator int(MyPoint m1)
        {
            return m1.x + m1.y; 
        }
    }
}