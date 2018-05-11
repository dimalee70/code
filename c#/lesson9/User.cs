using System;
namespace lesson9{
    class User{
        private string Name;
        private int Id;
        private int age;

        public User():this("Noname",0000,24){

        }
        public User(string name,int id, int age){
            Name = name;
            Id = id; 
            this.age = age; 

        }
        public string nameOfUser{
            get{
                return Name;
            }
            set{
                Name = value;
            }
        }
        public User(string Name,int Id){
            this.Name = Name;
            this.Id = Id;
        }
        public User(int id){
            Id = id;
        }
        ~User(){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("class deleted");
        }
    }
}