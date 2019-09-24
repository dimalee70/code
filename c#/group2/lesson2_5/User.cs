using System;
namespace lesson2_5
{
    public class User<T, V> where V : class, new()
    {
        public T id{get;set;}
        public V name{get;set;}

        public User(T id, V name)
        {
            this.name = name;
            this.id = id;
        }

        // public User(T id, string name)
        // {
        //     this.name = name;
        //     this.id = id;
        // }
        public override string ToString()
        {
            return "id " + id + "\tname " + name;
        }
    }
}