using System;
namespace lesson2_3
{
    public class User<T>
    {
        public User(T id, string name)
        {
            this.id = id;
            this.name = name;
        }


        public void checkType()
        {
            if(id.GetType() == typeof(int))
            {
                System.Console.WriteLine("int");
            }
            else if(id.GetType() == typeof(double))
            {
                System.Console.WriteLine("double");
            }
        }
        public T id{get;set;}
        public String name{get;set;}
    
        public override string ToString()
        {
            return "Name " + name + "\tid " + id.ToString();

        }
    }
}