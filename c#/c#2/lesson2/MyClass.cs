using System;
namespace lesson2{
    class MyClass{
        int[] arr;
        public int Length;
        
        public MyClass(int size){
            arr = new int[size];
            Length = size;
        }
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

    }
}