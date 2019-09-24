using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte mySByte;//декларация
            // sbyte mySByteDecWithInit = 100;
            // //декларация с инициализацией
            // mySByte = 10; //инициализация

            // short myShort = 1000;

            // long myLong = 989898938748973474L;

            // double myDouble = 121.1232;


            // int age = 100;
            // byte ageByte = 100; 




            // Console.WriteLine("Hello World!");

            // System.Console.WriteLine(1.2343432423423421f);
            //эта команда выводит на консоль


            // decimal myDecimal = 2.33M;
            // System.Console.WriteLine(myDecimal);

            // char myChar;
            // myChar = (char)33;


        
            // bool myBool = false;


            // var myVar = '2';

            // dynamic myDynamic = 123232; 


            // myDynamic = '3';

            // var t = (2m/2m);

            // System.Console.WriteLine("Привет");


            // object myObject = 213132;


            // string text = "rgdfgfddfjsadkas";

            // System.Console.WriteLine("\"Пр\nив\tет\"");




            // System.Console.WriteLine("Hello World");
            // System.Console.Write("safdsvsdv");
            // System.Console.WriteLine("Hello");

            // System.Console.WriteLine("Как тебя зовут?");

            //  string name = Console.ReadLine();

            // System.Console.WriteLine(name);

            System.Console.WriteLine("Enter the number");

            // double myD = Convert.ToDouble(Console.ReadLine());
            // System.Console.WriteLine(myD);


            int doubleString = Convert.ToInt32("123");

            int d = (int)20.55454;

            System.Console.WriteLine(doubleString);
             
        
        }
    }
}

package kz.dragau.larek.di.modules

import android.graphics.Bitmap
import android.net.Uri
import dagger.Module
import dagger.Provides
import javax.inject.Singleton

// @Module
// class ImageSelectionModule {
//     private var uri: Uri? = null

//     @Provides
//     @Singleton
//     fun provideImageSelection(): Uri{
//         return uri!!
//     }
// }