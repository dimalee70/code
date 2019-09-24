using System;
namespace lesson2_3
{
    public class Repository<T> where T : Human
    {
        public T myT{get; set;}
    }
}