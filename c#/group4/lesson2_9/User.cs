using System;

namespace lesson2_9
{
    public class User
    {
        public string Name{get;set;}
        public int age{get;set;}

        public void print ()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(age);
        }
    }
}