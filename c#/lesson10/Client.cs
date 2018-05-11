using System;
namespace lesson10{
class Client : IClient
{
    // реализация методов и свойств интерфейса
        string name; 
        public string Name {
            get{
                return name;
                }
            set {name = value;
            }
        }

        public int age(int age)
        {
            return age;
        }
    }
}