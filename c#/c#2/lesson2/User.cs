using System;
namespace lesson2
{
    class User
    {
        public string name;
        DateTime yearOfBirth;
        int age;
        private string [] Hobbi;
        public int length;
        //public DateTime year;
        //public int age;
        
        public User(string name,DateTime yearOfBirth)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.age = getAge(yearOfBirth);
        }
        public string nameOfUser
        {
            get
            {
                return name;
            }
        }
        public DateTime yearOfUser
        {
            get
            {
                return yearOfBirth;
            }
        }

        public int ageOfUser
        {
            get
            {
                return age;
            }

        }
        public int getAge(DateTime yearOfBirth){
            TimeSpan diference = DateTime.Today - yearOfBirth;
            return (int)Math.Floor(diference.Days/365.255);
        }
        public string this[int index]
        {
            get 
            { 
                return Hobbi[index];
            }
            set 
            { 
                Hobbi[index] = value;
            }  
        }
        public int this[string v]
        {
            get{
                int temp =-1;
                for(int i = 0; i < Hobbi.Length;i++){
                    if(Hobbi[i].Equals(v)){
                        temp = i;
                    }
                }
                return temp;
        
            }
        }
        public static implicit operator string(User u)
        {
            return $"Name is {u.nameOfUser}\nYear of birth is {u.yearOfUser}\nage is {u.ageOfUser}";
        }
    }
}