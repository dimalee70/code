using System;
namespace lesson11
{
    public class WorkWithArr
    {
        public static string className{get;}
        public int [] arr{get;set;}

        static WorkWithArr()
        {
            className = "WorkWithArrClassName";
            System.Console.WriteLine(className);
        }

        public WorkWithArr(int [] arr)
        {
            this.arr = arr;
        }
        public void printArr()
        {
            foreach(int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }

        // public string getClassName()
        // {
        //     return WorkWithArr;
        // }

        public static WorkWithArr newInstance(int [] arr)
        {
            return new WorkWithArr(arr);
        }


    }
}