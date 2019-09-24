using System;

namespace lesson8
{
    public class User
    {

        public int [] arr{get;set;}
        public int iD {get;set;}
        private string name;

        public String Name 
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

        // public int Id 
        // {
        //     get
        //     {
        //         return iD;
        //     }
        //     set
        //     {
        //         if(value < 1)
        //             iD = 0;
        //         else
        //             iD = value;
        //     }
        // }

        public User()
        {
            iD = -1;
            name = "NoName";
        }

        public User(int Id)
        {
            iD = Id;
            name = "NoName";
        }

        public User(string Name)
        {
            iD = -1;
            name = Name;
        }

        public User(int id, string name)
        {
            this.iD = id;
            this.name = name;

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setId(int id)
        {
            this.iD = id;
        }

        public int getId()
        {
            return iD;
        }
        public void printInfo()
        {
            System.Console.WriteLine(iD  + " " + name);
        }
    } 
}