using System;
namespace lesson8{
    
    public class User: Human{
        private string name;
        private string sex;

        public User(string name1){
            name = name1;
        }
        public User (string name1,string sex1, int age)
        {
            name = name1;
            sex = sex1;
            AgeOfHuman = age;
            

        }
        public string UserSex{
            get{
                return sex;
            }
            set{
                sex = value;
            }
        }
        public string GetName{
            get{
                return name;
            }
            set{
                name = value;
            }
        }
        public void MessHello(){
            System.Console.WriteLine($"Hello {name}");
        }
        public void Info(){
            System.Console.WriteLine($"{name},{sex}, {AgeOfHuman}");
        }
    }
}