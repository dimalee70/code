using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {


            // int [] sortArray = {3,10,54,1,0,4,5,100};
            // Array.Sort(sortArray);
            // Array.Resize(ref sortArray, sortArray.Length + 2);
            // sortArray[sortArray.Length - 2] = 1;
            // sortArray[sortArray.Length - 1] = -1;

            // foreach(int item in sortArray){
            //     System.Console.Write(item + " ");
            // }


            //Binary Search
            // int index = Array.BinarySearch(sortArray, 54);
            // System.Console.WriteLine(index);

            //Clear
            // Array.Clear(sortArray, 0, sortArray.Length/2);
            // Array.Clear(sortArray, 0, sortArray.Length);
            //Reverse
            // Array.Reverse(sortArray);
      

            //Линейный поиск
            // for(int i = 0; i < sortArray.Length; i++){
            //     if(sortArray[i] == 54){
            //         System.Console.WriteLine(i);
            //         break;
            //     }
            //     else if(i == sortArray.Length - 1)
            //         System.Console.WriteLine(-1);
            // }


            System.Console.WriteLine();

            // int [] myArray = new int[10];
            // string [] stringArray = {"hello", "world"};
            // char [] arrChar = new char[]{'a','b', 'c'}
            // myArray[0] = 10;
            // int intFromArray = myArray[0];
            // System.Console.WriteLine(intFromArray);
            // System.Console.WriteLine(myArray[1]);
            // System.Console.WriteLine(myArray.Length);


            // myArray[myArray.Length - 1] = 30;


            // for (int i = 0; i < myArray.Length; i++)
            // {
            //     myArray[i] = i;
            // }

            // for (int i = myArray.Length - 1; i >= 0 ; i--)
            // {
            //     System.Console.Write(myArray[i] + " ");
            // }
            // System.Console.WriteLine();

            // foreach (int item in myArray)
            // {
            //     System.Console.WriteLine(item);
            // }




            // int [,] my2dArray = new int[3,4];
            // int number = 10;
            // // [[1,2,3,4], [5,6,7,8], [8,9,8,6]]

            // for(int i = 0; i < 3; i++){
            //     for(int j = 0; j< 4; j++){
            //         my2dArray[i,j] = number++;
            //     }
            // }


            // System.Console.WriteLine(my2dArray.Length);
            // System.Console.WriteLine(my2dArray.GetLength(0));
            // System.Console.WriteLine(my2dArray.GetLength(1));

            // for(int i = 0; i < my2dArray.GetLength(0); i++){
            //     for(int j = 0; j < my2dArray.GetLength(1);j++){
            //         System.Console.Write(my2dArray[i, j] + "\t");
            //     }
            //     System.Console.WriteLine();
            // }
            
            // Random rand = new Random();

            // int [][] myArr = new int[3][];
            // myArr[0] = new int[3];
            // myArr[1] = new int[5];
            // myArr[2] = new int[7];

            // for(int i = 0; i < myArr.GetLength(0); i++){
            //     for(int j = 0; j < myArr[i].Length; j++){
            //         myArr[i][j] = rand.Next(0, 10);
            //     }
            // }

            // for(int i = 0; i < myArr.GetLength(0); i++){
            //     for(int j = 0; j < myArr[i].Length; j++){
            //         System.Console.Write(myArr[i][j] + "\t");
            //     }
            //     System.Console.WriteLine();
            // }

            // for(int i = 0;i < myArr[0].Length;i++){
            //     myArr[0][i] = rand.Next(100);
            // }
            // for(int i = 0; i < myArr[1].Length; i++){
            //     myArr[1][i] = rand.Next(100);
            // }
            // for(int i = 0; i < myArr[2].Length; i++){
            //     myArr[2][i] = rand.Next(50, 100);
            // }


            // for(int i = 0;i < myArr[0].Length;i++){
            //     System.Console.Write(myArr[0][i] + "\t");
            // }
            // System.Console.WriteLine();
            // for(int i = 0; i < myArr[1].Length; i++){
            //     System.Console.Write(myArr[1][i] + "\t");
            // }
            // System.Console.WriteLine();
            // for(int i = 0; i < myArr[2].Length; i++){
            //     System.Console.Write(myArr[2][i] + "\t");
            // }
            // System.Console.WriteLine();



           

            // Array array =Array.CreateInstance(typeof(string), 5);
            // array.SetValue("Hello", 2);
            // System.Console.WriteLine(array.GetValue(2));



            // string [] arrayString = {"Hello", "World", "Victor"};

            // string[] copyArrayString = 
            // new string[arrayString.Length + 1];
            // Array.Copy(arrayString, copyArrayString, arrayString.Length);
            // copyArrayString[copyArrayString.Length - 1] = "Test";
            // foreach(var item in copyArrayString){
            //     System.Console.Write(item + " ");
            // }
            // System.Console.WriteLine();



            // string [] cloneStringArray = arrayString;
            // // string[] cloneStringArray = (string[])arrayString.Clone();

            // arrayString[0] = "Test";

            // foreach(string s in cloneStringArray){
            //     System.Console.Write(s + " ");
            // }
            // System.Console.WriteLine();











            // hello:
            //     System.Console.WriteLine("Enter the number");
            //     int command = Convert.ToInt32(Console.ReadLine());
            //     if(command == 1){
            //         goto exit;
            //     }
            //     else{
            //         goto hello;
            //     }


            // exit:
            //     System.Console.WriteLine("Exit");

            // int index = 0;
            // do
            // {
            //     System.Console.WriteLine("Index " + index);
            // } while (index < 0);

            // while(index < 10){
            //     if (index % 2 == 1)
            //     {
            //         index++;
            //         continue;
            //     }
            //     else
            //     {
            //        System.Console.WriteLine("Index " + index++); 
            //     }
            // }
            // while(index < 10){

            //     System.Console.WriteLine("Index " + ++index);
            //     // index++
            // }
            // while (true)
            // {
            //     System.Console.WriteLine("Hello World!");
            // }
        }
    }
}
