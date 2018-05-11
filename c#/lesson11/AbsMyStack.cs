using System;
namespace lesson11{
    abstract class AbsMyStack{
        public int[] arr;
        public int size;
        // public AbsMyStack(int size){
        //     this.size = size;
        //     arr = new int [size];
        // }
        public abstract int peek();
        public abstract bool isFull();
        public abstract bool isEmpty();
    }
}