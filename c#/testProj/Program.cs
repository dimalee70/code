using System;

namespace testProj
{
    class Program
    {
        static void Main(string[] args)
        {


            //базовые типы 
            //byte myByte = 12; //это число байт
            //Целые числа
            sbyte mySbyte = -12;


            short m = -32000;
            ushort uShort = 64000;

            int myInt = 121312312;
            uint myUint = 324342323;

            long myLong = -213231231232323234L;
            ulong myUlong = 233232434234343434;


            double myDouble = -21312.2132;
            float myFloat = 323.343454F;

            bool myBool = false;

            string text = "hjfhhshjfdhsjd";

            var myVar = 12321;
            var myVar2 = "fvdfffdssd";

            dynamic myDynamic = 213231;

            myDynamic = "dfdfsdsd";

            myDynamic = 's';
            

            decimal myDecimal = 34234234.323243423423M;


            string tex = "\"При\tве\tт\" ска\t\tзал\n \'Андрей\'";
            System.Console.WriteLine(mySbyte);
            Console.WriteLine("\"При\tве\tт\" ска\t\tзал\n \'Андрей\'");

            System.Console.WriteLine("Привет\rРРР");

            
        }
    }
}
