
using System;
using System.IO;
using System.Xml.Serialization;
 
namespace lesson9
{
    // класс и его члены объявлены как public
    [Serializable]
    public class Person
    {
        
        private string Name;
        private int Age;
        
        public string NameOfPerson 
        { 
            get
            {
                return Name;
            } 
            set
            {
                Name = value;
            } 
        }
        public int AgeOfPerson 
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            } 
            }
 
        // стандартный конструктор без параметров
        public Person()
        { }
 
        public Person( string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}