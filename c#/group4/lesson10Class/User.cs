using System;
namespace lesson10Class
{
    public class User
    {
        public string Name{get;set;}
        public int Age{get;set;}

        public int schoolClass {get;set;}

        public virtual int addToClassSchool()
        {
            return ++schoolClass;
        }

        public User(string name, int age, int schoolClass)
        {
            Name = name;
            this.schoolClass = schoolClass;
            Age  = age;
        }

        public override string ToString()
        {
            return "name " + Name + "\tAge " + Age;
        }

        public override int GetHashCode()
        {
            return Age;
        }

        public override bool Equals(object obj)
        {
            User u = (User) obj;
            return u.Age == Age;
        }
    }
}