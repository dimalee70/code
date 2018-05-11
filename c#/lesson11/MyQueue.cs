using System;
namespace lesson11{
    class MyQueue : AbsMyStack
    {
        private int size;
        private int [] arr;

        private int index = 0;
        public MyQueue(int size){
            this.size = size;
            arr = new int[size];
        }
        public void enqueue(int d){
            arr[index] = d;
            index++;
        }
        public void dequeue(){
            for (int i = 1; i< size;i++){
                arr[i-1] = arr[i];
            }
            index--;
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
        public override int peek()
        {
            return arr[0];
        }
    }
}