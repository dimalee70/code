using System;
using System.Reflection;
// using System.
// using Attribute;

namespace lesson9
{
    
    [Obsolete("ThisClass is obsolete. Use ThisClass2 instead.")]
    // [AttributeUsage(AttributeTargets.Class)]
    [MyAttribute (Count = 3,Hello = "Hello from MyAtribute")]
    // [MyAttribute(Hello = "")]
    public class IntArrayInitializer : Attribute
{
    [Obsolete("ThisMethod is obsolete. Use Method2 instead.")]
     public int[] GetArray()
     {
          var type = this.GetType(); 
          // получение описания типа
          if (Attribute.IsDefined(type, typeof(MyAttribute))) 
          // проверка на существование атрибута
          {
              var attributeValue = 
              Attribute.GetCustomAttribute(type, typeof(MyAttribute)) as MyAttribute; // получаем значение атрибута
              return new int[attributeValue.Count]; // используем значение атрибута для формирования результата
          }
          return new int[0];

     }
     
     public void HelloFromAt()
     {
            var type = this.GetType(); 
            // получение описания типа
            if (Attribute.IsDefined(type, typeof(MyAttribute))) 
            // проверка на существование атрибута
            {
                var attributeValue = 
                Attribute.GetCustomAttribute(type, typeof(MyAttribute)) as MyAttribute; // получаем значение атрибута
                System.Console.WriteLine(attributeValue.Hello);
            }
            else
            {
                System.Console.WriteLine("No");
            }
          

     }
}
}