// #define Use
// #define NoUse
using System;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // IntArrayInitializer intArrayInitializer = new IntArrayInitializer();
            // System.Console.WriteLine(intArrayInitializer.GetArray().Length);
            // intArrayInitializer.HelloFromAt();
            // // TypeInfo typeInfo = typeof(IntArrayInitializer).GetTyp
            //Отражение 
            // Получение сведения о классе.
            // int [] arr = intArrayInitializer.GetArray();
            // System.Console.WriteLine(arr.Length);
            TypeInfo typeInfo = typeof(IntArrayInitializer).GetTypeInfo();
            Console.WriteLine("The assembly qualified name of MyClass is " + 
                typeInfo.AssemblyQualifiedName);

            // Motorcycle motorcycle = new Motorcycle();
            // motorcycle.NoUseMotorcycle();
            // motorcycle.UseMotorcycle();
            var attrs = typeInfo.GetCustomAttributes();
            foreach(var attr in attrs)
                Console.WriteLine("Attribute on MyClass: " + attr.GetType().Name);


            //Serialization

            // Person person = new Person("Tom", 29);

            // Person [] persons = new Person[]
            // {
            //     new Person("Tom",29),
            //     new Person("Jerry",15),
            //     new Person("Chip",10) 
            // };
            // Console.WriteLine("Объект создан");
 
            // // // передаем в конструктор тип класса
            // XmlSerializer formatter = 
            //     new XmlSerializer(typeof(Person[]));
 
            // // получаем поток, куда будем записывать сериализованный объект
            // using (FileStream fs = new FileStream("persons.xml", 
            // FileMode.OpenOrCreate))
            // {
            //     formatter.Serialize(fs, persons);
 
            //     Console.WriteLine("Объект сериализован");
            // }
 
            // десериализация
            // using (FileStream fs = 
            // new FileStream("persons.xml", FileMode.OpenOrCreate))
            // {
            //     Person [] newPerson = 
            //         (Person[])formatter.Deserialize(fs);
            //     foreach (Person p in newPerson)
            //     {
            //         Console.WriteLine("Имя: {0} --- {1}", p.NameOfPerson,p.AgeOfPerson);
            //     }
 
            //     Console.WriteLine("Объект десериализован");
                
            // }
 
            Console.ReadLine();
        }
    }
}
