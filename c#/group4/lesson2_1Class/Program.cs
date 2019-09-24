using System;

namespace lesson2_1Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // int t = 10;

  

          

            // int c = t;
            // t = 15;
          
            // User user = new User();
            // user.myInt = 20;
            // User user2 = user;
            
            // user.myInt  = 50;

            // System.Console.WriteLine(c);
            // System.Console.WriteLine(user2.myInt);

            // MyStruct myStruct = new MyStruct();
            // myStruct.myInt = 10;
            // MyStruct myStruct2 = myStruct;
            // myStruct.myInt = 20;
            // myStruct2.print();
            // myStruct2.Hello();

            // MyStruct m = new MyStruct(15);
            // m.print();

            User user = new User();
            user.myInt = 20;
            MyEnum day = MyEnum.Saturday;
            user.day = day;

            user.day = MyEnum.Saturday;

            System.Console.WriteLine(user.day);
            System.Console.WriteLine((int)user.day);

            MyEnum m = MyEnum.Wednesday;
            if ((int)m == 10)
            {
                System.Console.WriteLine("WWW");
            }

            // var myEnums = Enum.GetValues(typeof(MyEnum));

            // System.Console.WriteLine(myEnums.GetValue(0));
        
        }
    }
}
