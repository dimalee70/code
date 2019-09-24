using System;

namespace data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //gsdsfds
            // byte m; //декларация
            // byte n = 100; //декларация с инициализацией

            // m = 200; // инициализация
        

            // sbyte mySByte = -123;

            // short myShort = 32000;
            // ushort myUshort = 65000;

            // int myInt = 342343432;
            // uint myUInt = 454545454;

            // long myLong = 2132312312312312312;

            
            // Console.WriteLine("12");

            // double myDouble = 1.3432342342342343423;

            // float myFloat = 1.232323243423432423f;

            // // System.Console.WriteLine(myDouble);

            // // System.Console.WriteLine(myFloat);

            
            // char myChar = 'R';

            // bool myBool = true;

            // decimal myDecimal = 1.31232312312312m;

            // var myVar = 'd';

            // dynamic myDynamic = 1.232434;

            // // myVar = 2323;
            // myDynamic = 'c';

            // const int constInt = 6;

            // // System.Console.WriteLine("\"Привет\"\t - сказал Паша");
            // // System.Console.WriteLine();


            // // int t = Console.Read();
            
            // // System.Console.WriteLine((char)t);
            // // System.Console.WriteLine();

            int t = Convert.ToInt32(Console.ReadLine());

            string [][] myArr  = new string [t][];
            for(int i = 0; i < t; i++)
            {
                myArr [i] = new string[i+1];
                Array.Fill(myArr[i],"[*]");
            } 
            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                for(int j = 0; j < myArr[i].Length; j++)
                {
                    System.Console.Write(myArr[i][j]);
                }
                System.Console.WriteLine();
            }

            // Student student = new Student(1,"Aruzhan");
            // System.Console.WriteLine(student.getId());
            // System.Console.WriteLine(student.getName());

            // student.incYear();
            // System.Console.WriteLine(student.getYear());

        }
    }
}
