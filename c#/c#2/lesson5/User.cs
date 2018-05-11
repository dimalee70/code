using System;
namespace lesson5{
    class User{
        private string name;
        private string surname;
        private int age;

        public User(string name,string surname,int age){
            this.name = name;
            this.age = age;
            this.surname = surname;
        }
        public string nameOfUser{
            get
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }

        public string surnameOfUser{
            get
            {
                return surname; 
            }
            set
            {
                surname = value;
            }
        }

        public int ageOfUser{
            get
            {
                return age; 
            }
            set
            {
                age = value;
            }
        }

        public static implicit operator string(User us){
            return $"{ us.nameOfUser } {us.surnameOfUser} {us.ageOfUser}";            
        }
    }
}