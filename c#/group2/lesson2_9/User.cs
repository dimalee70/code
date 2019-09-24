using System;
using System.Collections.Generic;

namespace lesson2_9 {
    public class User 
    // : IComparable<User> 
    {


        // public override bool Equals(object obj)
        // {
        //     User u = (User) obj;

        //     return Age == u.Age;
        // }
        public User (string name, int age) {
            this.Name = name;
            this.Age = age;

        }
  

        public string Name { get; set; }
        public int Age { get; set; }

 
        public override string ToString () {
            return "Name " + Name + "\tAge " + Age;
        }

        // public int CompareTo (User obj) {
        //     return Age - obj.Age;
        // }

    }

}