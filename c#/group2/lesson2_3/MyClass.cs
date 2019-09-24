using System;
using lesson2_3.interfaces;
namespace lesson2_3
{
    public sealed class MyClass:newinterface
    {

        public MyClass(){}
        private int [] arr;
        public int size;

        public MyClass(int size)
        {
            this.arr = new int[size];
            this.size = size;
        }

        public  int this[int idx]
        {
            get
            {
                return arr[idx];
            }
            set
            {
                arr[idx] = value;
            }
        }

        public  int this[string idx]
        {
            get
            {
                return arr[Convert.ToInt32(idx)];
            }
            set
            {
                arr[Convert.ToInt32(idx)] = value;
            }
        }

        public static MyClass operator +(MyClass t1, MyClass t2)
        {
            return new MyClass(t1.size + t2.size);
        }

        public static MyClass operator -(MyClass t1, MyClass t2)
        {
            return new MyClass(t1.size - t2.size);
        }

        public static bool operator >(MyClass t1, MyClass t2)
        {
            return t1.size > t2.size;
        }

        public static bool operator <(MyClass t1, MyClass t2)
        {
            return t1.size < t2.size;
        }

        public static bool operator true(MyClass t1)
        {
            if(t1.size > 5)
                return true;
            return false;
        }

        public static bool operator false (MyClass t1)
        {
            if(t1.size <= 5)
                return false;
            return true;
        }

        public static explicit operator string(MyClass m)
        {
            return m.size + " string ";
        }

        public static implicit operator int (MyClass m)
        {
            return m.size;
        }


        public void printArr()
        {
            foreach(int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }
        private int age;

        public int Age
        {
            set
            {
                if(value > 18)
                    age = value;
                else
                    age = 0;
            }

            get
            {
                return age;
            }

   
        }
        // public string Name
        // {
        //     get
        //     {
        //         return "Your name is " + Name;
        //     }

        //     set
        //     {
        //         Name = value;

        //     }


        // }
        public void Hello()
        {
            System.Console.WriteLine("Hello from MyClass");
        }
    }

}