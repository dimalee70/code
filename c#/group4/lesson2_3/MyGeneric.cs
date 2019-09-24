using System;

namespace lesson2_3
{
    public class MyGeneric<T> where T : new()
    {
        public T myT{get;set;}
    }
} 