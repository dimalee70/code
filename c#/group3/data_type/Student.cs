using System;

namespace data_type
{
    public class Student
    {

        private int id;
        private string name;

        private int year;

        public Student(int id, string name)
        {
            this.name = name;
            this.id = id;
            this.year = 1;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getYear()
        {
            return year;
        }
        public int getId()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }

        public void incYear()
        {
            this.year = ++year;
        }
    }
}