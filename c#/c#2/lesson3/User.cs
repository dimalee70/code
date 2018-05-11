using System;
namespace lesson3
{
    class User
    {
        private string name;
        private int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public User()
        {
            this.name = "noname";
        }


        public string nameOfUser
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

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}