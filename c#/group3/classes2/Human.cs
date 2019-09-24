using System;
namespace classes2
{
    public class Human
    {
        public Human(){}
        public Human(string name, int age)
        {
            this.age = age;
            Name = name;
        }
        private int age;

        public string Name{get; set;}

        public void setAge( int age)
        {
            this.age = age;
        }

        public void pringString()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(age);
        }

        public int getAge()
        {
            return age;
        }

        public int sum (int a, int b)
        {
            return a+b;
        }

        public int sum(int a, int b, int c)
        {
            return a+b+c;
        
        }

    }
}