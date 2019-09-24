using System;
namespace lesson12
{
    public abstract class AbstractArray : IBaseInterface, IMyInterface
    {
        public int [] arr{get;set;}

        public AbstractArray(int [] arr)
        {
            this.arr = arr;
        }


        public void add(int a)
        {
            // System.Console.WriteLine("Length");
            // System.Console.WriteLine(arr.Length);
            int [] tempArr = new int[arr.Length + 1];
            for(int i = 0, j = 1; i < arr.Length; i++)
            {
                if(tempArr.Length > 1)
                {
                    // System.Console.WriteLine("InSide if");
                    tempArr[j++] =  arr[i];
                }
                    
            }

            tempArr[0] = a;
            System.Console.WriteLine("Ellement ");
            System.Console.WriteLine(tempArr[0]);

            arr = tempArr;
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public int getCount()
        {
            return arr.Length;
        }

        public abstract void print();

        public void printHello()
        {
            System.Console.WriteLine("Hello");
        }

        public void printName(string name)
        {
            System.Console.WriteLine("Hello " + name);
        }
    }
}