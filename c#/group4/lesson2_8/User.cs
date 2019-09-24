using System;
using System.Collections;

namespace lesson2_8
{
    public class User : IComparable<User>
    {
        public int id { get; set; }
        public string name { get; set;}

        public int age {get;set;}

        public User(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return id + "\t" + name + "\t" + age;
        }

        public int CompareTo(User other)
        {
            if(name == other.name)
            {
                if(age == other.age)
                {
                    return other.id - id;
                }
                return other.age - age;
            }
            return name.CompareTo(other.name);
        }
    }
}