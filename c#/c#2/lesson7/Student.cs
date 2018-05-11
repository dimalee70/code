using System;

namespace lesson7
{
    class Student
    {
        public Student(string name,string city, int age)
        {
            this.city = city;
            this.name = name;
            this.age = age;

        }

        // private double GPA;
        private string name;
        private int age;

        private string city;

        public int  ageOfSt
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public string nameOfSt
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
        public string cityOfSt
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
    }

}