using System;
namespace lesson13
{
    class UserChild : User
    {
        string id{get; set;}
        public UserChild(string race, string sex, string name, int age, string id):base(race, sex, name, age)
        {
            this.id = id;
        }
    }
}