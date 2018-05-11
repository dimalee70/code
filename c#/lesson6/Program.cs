using System;

namespace lesson6
{
    class Program
    {
 static void Main(string[] args)
        {
            // string[] arr = new string[5];
            // Array arr2 = Array.CreateInstance(typeof(string),5);
            // for (int i = 0; i < arr.Length;i++){
            //     string name = Console.ReadLine();
            //     arr[i] = name;
            //     arr2.SetValue(name,i);
            //     // arr[0] = name;
            //     // arr[1] = name;
            // }
            // foreach(string n in arr){
            //     System.Console.WriteLine($"{n} ");
            // }
            // foreach(string n in arr2){
            //     System.Console.WriteLine($"{n} ");
            // }

            // int [,] arr = new int[4,6];
            // for (int i = 0; i < arr.GetLength(0);i++){
            //     for (int j = 0; j < arr.GetLength(1);j++){
            //         System.Console.Write(arr[i,j]+" ");
            //     }
            //     System.Console.WriteLine();
            // }
            // System.Console.WriteLine(); 
            // arr[1,2] = 2;
            // for (int i = 0; i < arr.GetLength(0);i++){
            //     for (int j = 0; j < arr.GetLength(1);j++){
            //         System.Console.Write(arr[i,j]+" ");
            //     }
            //     System.Console.WriteLine();
            // }
            // int i = 0;
            // // Объявляем ступенчатый массив
            // int[][] myArr = new int[4][];
            // myArr[0] = new int[4];
            // myArr[1] = new int[6];
            // myArr[2] = new int[8];
            // myArr[3] = new int[10];

            // // // Инициализируем ступенчатый массив
            // for (; i < myArr[0].Length; i++)
            // {
            //     // myArr[0][0] = 0;
            //     // myArr[0][1]= i 
            //     myArr[0][i] = i;
            //     Console.Write("{0}\t",myArr[0][i]);
            // }

            // Console.WriteLine();
            // for (i = 0; i < myArr[1].Length; i++)
            // {
            //     // myArr[1][0] = 0;
            //     // myArr[1][1]= i ;
            //     myArr[1][i] = i;
            //     Console.Write("{0}\t", myArr[1][i]);
            // }

            // Console.WriteLine();
            // for (i = 0; i < myArr[2].Length; i++)
            // {
            //     // myArr[2][0] = 0;
            //     // myArr[2][1]= i; 
            //     myArr[2][i] = i;
            //     Console.Write("{0}\t", myArr[2][i]);
            // }

            // Console.WriteLine();
            // for (i = 0; i < myArr[3].Length; i++)
            // {
            //     myArr[3][i] = i;
            //     Console.Write("{0}\t", myArr[3][i]);
            // }

            // Console.ReadLine();


            // Console.WriteLine("Общая длина всего массива: " + myArr.Length);
            // Console.WriteLine("\nДлина первой цепи: " + myArr[0].Length);
            // Console.WriteLine("\nДлина второй цепи: " + myArr[1].Length);
            // Console.WriteLine("\nДлина третьей цепи: " + myArr[2].Length);
            // Console.WriteLine("\nДлина четвертой цепи: " + myArr[3].Length);

        //             // Создаем массив типа string, длиной 5
        // Array myArrStr = Array.CreateInstance(typeof(string),5);
        // myArrStr.SetValue("Name",0);
        // myArrStr.SetValue("Age",1);

        // // Считываем данные из массива
        // //Array.Sort(myArrStr);
        // foreach (string s1 in myArrStr){
        //     System.Console.WriteLine(s1);
        // }
        // Array.Sort(myArrStr);
        // foreach (string s1 in myArrStr){
        //     System.Console.WriteLine(s1);
        // }
        
        // System.Console.WriteLine((string)myArrStr.GetValue(3));
        // Console.ReadLine();

        string[] starts = {"Steve", 
                        "John", 
                        "Tomas", 
                        "Jack", 
                        "Frank", 
                        "Stark"};

    //     Console.WriteLine();
    //     foreach( string star in starts )
    //     {
    //         Console.WriteLine(star);
    //     }
    //  System.Console.WriteLine($"Первый элемент до сортировки {starts[0]}");
    //     // Console.WriteLine("\nSort");
    //     Array.Sort(starts);

    //     Console.WriteLine();
    //     foreach( string star in starts )
    //     {
    //         Console.WriteLine(star);
    //     }
    //     System.Console.WriteLine($"Первый элемент после сортировки {starts[0]}");

    //     Console.WriteLine("\nBinarySearch for 'Steve':");
    //     int index = Array.BinarySearch(starts, "Steve");
    //     System.Console.WriteLine(index);
    //     Array.Resize(ref starts,7);
    //     foreach( string star in starts )
    //     {
    //         Console.WriteLine(star);
    //     }
    //     starts[6] = "Uill";
    //     foreach( string star in starts )
    //     {
    //         Console.WriteLine(star);
    //     }

        }
    }
}
