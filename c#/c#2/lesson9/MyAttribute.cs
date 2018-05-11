using System;
namespace lesson9
{
    public class MyAttribute : Attribute 
    // создаём собственный атрибут 
    // наследуясь от стандартного класса
    {
        public int Count { get; set; } 
        public string Hello{get;set;}
        // создаём своё свойство которое будет содержать атрибут
        // можно описать несколько свойств но для примера создаётся только одно
    }
}