using System;

namespace lesson2_3
{


    public class Human
    {

        public Human(){}
        public Human(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public String name{get;set;}
        public int id {get;set;}

        public override string ToString()
        {
            return "Name " + name + "\tId " + id;

        }
    }
}