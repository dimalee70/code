using System;
namespace lesson2{
    class IndexClass{
        public int length;
        private string [] arr;
        public IndexClass(int size){
            length = size;
            arr = new string[size];
        }

        //Indexer
        public string this[int index]
        {
            get 
            { 
                return arr[index];
             }
            set { 
                arr[index] = value;
             }
             
        }
        public int this[string v]
        {
            get{
                int temp =-1;
                for(int i = 0; i < arr.Length;i++){
                    if(arr[i].Equals(v)){
                        temp = i;
                    }
                }
                return temp;
            }
        }
    }
}