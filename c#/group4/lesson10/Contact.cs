using System;
namespace lesson10
{
    public class Contact
    {
        public string Name{get; set;}

        public long Phone{get;set;}

        public Contact(string name, long phone)
        {
            Phone = phone;
            Name = name;
        }

        public override String ToString()
        {
            return "Name " + Name + "\tPhone" + Phone;
        }
    }
}