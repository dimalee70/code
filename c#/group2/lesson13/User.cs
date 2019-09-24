using System;
namespace lesson13
{
    class User :Human 
    {

        public string Name{ get; set;}

        public int Age { get; set;}

        public User(){

        }

        public User(string name)
        {
            this.Name = name;
        }
        public User (string race, string sex): base(race, sex)
        {
    
            this.Name = "No name";
            this.Age = -1;
        }

        public User(string race, string sex, string name): base(race, sex)
        {
            this.Name = name;
            this.Age = 14;
        }

        public User (string race, string sex, int age):base(race, sex)
        {
            Age = age;
        }
        public User(string race, string sex, string name, int age):base(race, sex)
        {
            this.Name = name;
            this.Age = age;
        }

        public void printInfo()
        {
            System.Console.WriteLine(race);
            System.Console.WriteLine(sex);
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Age);
        }

        public void printInfo(string name)
        {
            Name = name;
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Age);   
        }

        public void printInfo(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Age);
        }

        public void print()
        {
            base.print();
            System.Console.WriteLine("test");
        }

        public override string ToString()
        {
            return $"race = {race},\nsex = {sex},\nname={Name},\nage = {Age}";

        }

        // public void setName(string name)
        // {
        //     this.name = name;
        // }
        // public string getName()
        // {
        //     return name;
        // }

        // public void setAge(int age)
        // {
        //     this.age = age;
        // }
        // public int getAge()
        // {
        //     return age;
        // }
    }
}