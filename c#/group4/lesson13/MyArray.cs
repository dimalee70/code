using System;
namespace lesson13
{
    public class MyArray
    {
        public string [] Arr{get;set;}
        public string [,] Arr2D{get;set;}

        public MyArray(string [] Arr)
        {
            this.Arr = Arr;
        }
        public MyArray(int size)
        {
            this.Arr = new string[size];
        }

        public MyArray(int rows, int columns)
        {
            this.Arr2D = new string[rows,columns];
        }
        public override string ToString()
        {
            string str = "";
            foreach(string s in Arr)
            {
                str += s + " ";
            }
            return str += "\n";
        }
        public string this[int index]
        {
            set
            {
                Arr[index] = value;
            }

            get
            {
                return Arr[index];
            }
    
        }

        public string this[double index]
        {
            set
            {
                int idx = (int) index;
                Arr[idx] = value;
            }
            get
            {
                int idx = (int) index;
                return Arr[idx];
            }
        }
        public string this[int row, int column]
        {
            set
            {
                Arr2D[row, column] = value;
            }
            get
            {
                return Arr2D[row, column];
            }
        }


    }
}