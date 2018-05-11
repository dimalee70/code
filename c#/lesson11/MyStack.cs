

using System;
namespace lesson11{
    class MyStack:AbsMyStack{
        private int size;
        private int[] arr;
        private int index = 0;
        public MyStack(int size)
        {
            this.size = size;
            arr = new int [size];
        }
        
        public void push(int d){
            arr[index] = d;
            index++;
        }

        public override bool isEmpty()
        {
            if(index == 0){
                return true;
            }else
            {
                return false;
            }
        }

        public override bool isFull()
        {
            if (index == size){
                return true;

            }
            else{
                return false;
            }
        }
        public int pop(){
            return arr[--index];
        }
        public override int peek()
        {
            return arr[index-1];
        }
    }
}