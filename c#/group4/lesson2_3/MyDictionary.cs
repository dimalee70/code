using System;
namespace lesson2_3
{
    public class MyDictionary<T,V> where T : struct 
                where V : class
    {
        public MyDictionary(T key, V value)
        {
            this.key = key;
            this.value = value;
        }

        public T key{get;set;}
        public V value{get;set;}

        public override string ToString()
        {
            return "Key " + key.ToString() + 
            "\tValue " + value.ToString(); 
        }

        
    }
}