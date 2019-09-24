using System;

namespace data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte myByte = 12;
            // sbyte mySByte = -12;

            // short myShort =  -32000;
            // ushort myUshort = 65000;

            // int myInt = -12;
            // uint myUInt = 213231;

            // long myLong = -21323123123;
            // ulong myULong = 2132314342342432L;

            // double myDouble = 12.232312312312;
            // float myFloat = 21.32312312f;

            // char myChar = '1';

            // bool myBoolean = true;

            // decimal myDecimal = 1231231.324324342M;

            // var myVar = 12312;
            // dynamic myDynamic = 12312;

            // // myVar = "Test";
            // myDynamic = "test";

            // object myObject = 212123;

            // string myString = "\"Привет\" - \tсказал\n уч\vитель";

            // System.Console.WriteLine(myString);

            // int x, y = 45, z;

            // int t ;//декларация

            // t = 34;//инициализация

            // int p = 12;//декларация с инициализацией

            // int? u = null;
            // float? eferf = 23.3F;
          

            // System.Console.WriteLine(u);

            // byte myByteInt = 212;
            // int myInteger = myByteInt;
            // long myLongInt = myInteger;

            // int myIntToByte = 31231321;
            // System.Console.WriteLine(Convert.ToString(myIntToByte, 2));
            // System.Console.WriteLine(Convert.ToString(myIntToByte, 2).Length);
            // byte myByteFromInt = (byte)myIntToByte;
            // System.Console.WriteLine(Convert.ToString(myByteFromInt, 2));
            // System.Console.WriteLine(Convert.ToString(myByteFromInt, 2).Length);

            // System.Console.WriteLine(myByteFromInt);

            // char myCharAsci = 'a';
            // int charAsci = myCharAsci;
            // System.Console.WriteLine(charAsci);

            // string text = "hello world";
            // System.Console.WriteLine("Text " + text);
            // System.Console.WriteLine($" Text {text}");
            // System.Console.WriteLine("Text {1} {0} {1}", text, "fvdf");

            // System.Console.WriteLine(5 + 5);

            // string te = "123";
            // int e = (int ) te;

            // int b = Convert.ToInt32("123");
            // System.Console.WriteLine(b);
            // Convert.ToInt32(Console.ReadLine());



            // int x = 5;
            // // System.Console.WriteLine(x++);
            // System.Console.WriteLine(++x);
            // System.Console.WriteLine(x);


            // int one = 3;//011
            // int two = 5;//101
            // System.Console.WriteLine
            // (Convert.ToString(one,2));

            //  System.Console.WriteLine
            // (Convert.ToString(two,2));

            // int three = one | two;
            // System.Console.WriteLine(three);
            // System.Console.WriteLine
            // (Convert.ToString(three,2));

            // bool myAnd = !((5 > 6) || (5 < 3));


            // System.Console.WriteLine(myAnd);


            // int num = 10;
            // num += 20;
            // // System.Console.WriteLine(num + 20);
            // System.Console.WriteLine(num);
            // num = num + 20;

            // int mod = 9;
            // mod %= 2;
            // mod = mod % 2;
            // System.Console.WriteLine(mod);

    
            // int shiftOne = 10;//1010
            // System.Console.WriteLine
            // (Convert.ToString(shiftOne, 2));

            // // shiftOne >>= 1;//0001
            // shiftOne <<= 5;

            // System.Console.WriteLine
            // (Convert.ToString(shiftOne, 2));
            // System.Console.WriteLine(shiftOne);
            //01010
            //10100

            // short complement = 10;
            // System.Console.WriteLine
            // (Convert.ToString(complement, 2));
            // complement =(short)~complement;
            // System.Console.WriteLine
            // (Convert.ToString(complement, 2));
            // System.Console.WriteLine(complement);

            int one = 10;
            int two = 20;

            string answer = 
            (one > two)? "One is bigger":
            (two > one )? "Two is bigger":
            "Two and one are equal";

        System.Console.Write("Hello");
        System.Console.WriteLine("World");

        System.Console.WriteLine("Enter char");
        int t = Console.Read();
        System.Console.WriteLine(t);
        }
    }
}
