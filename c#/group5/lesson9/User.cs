using System;
namespace lesson9
{
    public class User
    {
        public string n;
        public string name{get;set;}
        public int age{get;set;}
        public User(string name, int age)
        {
            this.age = age;
            this.name = name;
            // printInfo();
        }

        public string Name
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
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

       public User(int name, string age)
        {
            this.age = name;
            this.name = age;
            printInfo();
        }
        public User(string name)
        {
            this.name = name;
            this.age = 15;
            printInfo();
        }
      
        public User()
        {
            age = 0;
            name = "Name";
        }

        public void printInfo()
        {
            System.Console.WriteLine($"Name {name}\nAge = {age}");
        }

    }
}