using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 1. Базовые типы данных
            int t;//Декларация
            byte myByte = 244; //Декларация с Инициализации
            t = 10;//Инициализация
            sbyte mySByte = -10;


            myByte = 100;

            double myDouble = -1.324234;

            float myFloat = 1.2321f; 

            short myShort = -32500;
            ushort myUShort = 64000;

            bool myBlool = false;

            char myChar = 'w';


            // 2. Ссылочные типы данных
            string myString = "Hello dfffv";
            myString = null; //Ничему не равно

            object myObject = 1.34234f;
            myObject = 1000;
            // myString = null;

            decimal myDecimal = 12;

            var myVar = "dsfdf";
           

            dynamic myDynamic = 3232;
            myDynamic = "sfsf";

            // object myObjectInt = myObject;
            string myVar2 = myVar;
            string myDynamicString = myDynamic;


            DateTime myDateTime = DateTime.Now;
            System.Console.WriteLine(myDateTime.Day);
            // myVar = 123;

            
            
            System.Console.WriteLine((int)myChar);
            System.Console.WriteLine(myByte);
            // int t = 5;
            // unsafe
            // {
            //     int*p;
            // }
            // string name;
            // Console.WriteLine("Your name :");
            // name = Console.ReadLine();
            // string sur = Console.ReadLine();
            // int age = Int32.Parse(sur);
            // Console.WriteLine($"Hello, {name} {age}");
            // Console.ReadKey();

            // double d = Convert.ToDouble(age);
            Console.WriteLine("Dmitriy");
            System.Console.WriteLine("My value = "+myBlool);
            System.Console.WriteLine($"My value = {myBlool}" );
            System.Console.WriteLine("My value {0} {1} ",myBlool,myDynamic);
        } 
    }
}
            // const double P = 3.14;
            // byte t = 12;
            // sbyte st = -12;
            // short short1 = -30000;
            // ushort ushort1 = 65000;
            // int int1 = -2000000;
            // uint uint1 = 4000000;
            // long long1 = -90000000000;
            // ulong ulong1 = 900000000000000;
            // float float1 = 1.2323234334F;
            // double double1 = 1.2323232443355445;
            // object object1 = 14554646565.4345;
            // char char1 = 'A';
            // decimal dec = 211;
            // bool bool1 = true;
            // bool bool2 = false;
            // DateTime dt = DateTime.Now;
            // TimeSpan ts = DateTime.Now - DateTime.Today;
            // string text = null;
            // object o = "rferferf";
            // var bh = 1.2;
            // dynamic rttr = "dwefef";
            // const int t = 5;
            // int y = 5;          
            // y = 6;
            // string n = null;
            // uint t2 = 2;
            // Console.WriteLine("Enter");
            // int i = Console.Read();
            // Console.WriteLine(i);

            // //int t3 = Console.Read();
            // DateTime date1 = DateTime.Now;
            // DateTime date2 = DateTime.UtcNow;
            // DateTime date3 = DateTime.Today;
            // // Console.WriteLine($"date3 {t2}");
     
            // byte byteValue1 = 201;
            // Console.WriteLine(byteValue1);

            // byte byteValue2 = 0x00C9;
            // Console.WriteLine(byteValue2);

            // byte byteValue3 = 0b1100_1001;
            // Console.WriteLine(byteValue3);
// byte	1	0 to 255
// sbyte	1	-128 to 127
// short	2	-32768 to 32767
// ushort	2	0 to 65535
// int	4	-2 billion to 2 billion
// uint	4	0 to 4 billion
// long	8	-9 quintillion to 9 quintillion
// ulong	8	0 to 18 quintillion
// float	4	7 significant digits1
// double	8	15 significant digits2
// object	4 byte address	All C# Objects
// char	2	Unicode characters
// string	4 byte address	Length up to 2 billion bytes3
// decimal	24	28 to 29 significant digits4
// bool	1	true, false5
// DateTime 8 0:00:00am 1/1/01 to 11:59:59pm 12/31/9999
// DateSpan -10675199.02:48:05.4775808 to 10675199.02:48:05.47758076
// static void Main(string[] args)
// {

//     Console.ReadLine();
// }

