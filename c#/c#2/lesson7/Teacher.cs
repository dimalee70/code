using System;
namespace lesson7
{
    class Teacher
    {
        private string name,city;
        // private string city
        public Teacher(string name, string city)
        {
            this.name = name;
            this.city = city;            
        }
    public string nameOfT
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }
    public string cityOfT
    {
        set
        {
            city = value;
        }
        get
        {
            return city ;
        }
    }

    }
}