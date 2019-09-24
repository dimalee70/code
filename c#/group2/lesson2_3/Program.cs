using System;

namespace lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // int t = 5;

            // MyStruct user = new MyStruct("dsd",12);
            // user.Name = "Dmitriy";
            // user.Age = 22;

            // MyStruct user1 = user;
            // user.Age = 30;
            // System.Console.WriteLine(user);
            // System.Console.WriteLine(user1);

            // user.Hello();

            MyClass myClass = new MyClass(10);
            MyClass myClass2 = new MyClass(3);
            MyClass myClass3 = myClass + myClass2;

            System.Console.WriteLine(myClass3.size);

            System.Console.WriteLine(myClass > myClass2);
            System.Console.WriteLine(myClass3 < myClass);

            // bool t = true;
            // if(t)

            if(myClass2)
            {
                System.Console.WriteLine("bigger than 5");
            }
            else
            {
                System.Console.WriteLine("Less");
            }


            byte  b = 10;
            int t = b;

            b = (byte)t;
            // if(myClass)
            // {
            //     System.Console.WriteLine();
            // }


            // for(int i = 0 ; i < myClass.size; i++)
            // {
            //     myClass["1"]  = i;
            // }

            // // myClass =+ myClass;
            // myClass.printArr();

            // myClass.Age = 10;
            // System.Console.WriteLine(myClass.Age);

            // myClass[0] = "dsfdsd";

            string s = (string)myClass;
            System.Console.WriteLine(s);

            int sizeFromClass = myClass;
            System.Console.WriteLine(sizeFromClass);
        }
    }
}
