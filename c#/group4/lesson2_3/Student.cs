using System;
namespace lesson2_3
{   public class Student<T>: Human
    {
        public Student(int id, string name) : base(id, name)
        {
        }


        // public void checkType()
        // {
        //     if
        // }

        public T studentId{get;set;}
    }
}