using System;
using System.Collections.Generic;
namespace lesson1{
    class Users{
        private string name;
        private uint age;
        private string surname;
        public Users(){}
        public Users(string name, uint age,string surname)
        {
            this.name = name;
            this.age = age;
            this.surname = surname;
        }
        public Users(uint age):this("noname", age,"nosurname"){}
        public Users(string name): this(name,0,"nosurname"){}
        public Users (object surname) : this("noname",0,(string)surname){}
        
        public string userName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public uint ageUser
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string surnameUser
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public void SayHello(string name)
        {
            System.Console.WriteLine("Hello, " + name);
        }
        public void SayHello(string name, string surname)
        {
            System.Console.WriteLine($"Hello, {name} {surname}");
        }
        public void SayHello(string name, string surname, uint age)
        {
            System.Console.WriteLine($"Hello, {name} {surname}\nYour age is {age}");
        }
        public uint YearOfAge()
        {
            return (uint)DateTime.Now.Year - age;
        }
        public IEnumerable<int > Yields()
        {
            int [] arr = new int [20];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i ++){
                arr[i] = rand.Next(0,20); 
            }
            Array.Sort(arr);
            foreach(int t in arr){
                yield return t;
            }

        }
    }
}