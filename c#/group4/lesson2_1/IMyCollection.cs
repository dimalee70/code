using System;

namespace lesson2_1
{
    public interface IMyCollection
    {
        void push(int num);
        int pop();
        int peek();
        int getSize();

    }
}