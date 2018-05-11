using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <User> userList = new List<User>();
            for (int i = 0; i < 10;i++)
            {
                User us = new User("Name " + i,"Surname " + i, 18+i);
                userList.Add(us);
            }
            // foreach(User us in userList)
            userList.ForEach(item => 
                Console.WriteLine(item + "\n "));
            Console.WriteLine("Hello World!");
            int [] num = new int []{1,2,3,4,5,6};
            int [] arr = num.OrderByDescending(t => t).ToArray();
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
                
            }
            // foreach(int index in num){
            //     System.Console.WriteLine();
            // } 
            userList = userList.OrderByDescending(t => 
                t.ageOfUser).ToList();
            userList.ForEach(i => Console.WriteLine(i + "\n "));
            int number = 1;
            List<Tuple<int,User>> userTuple = new List<Tuple<int,User>>();
            for(int i = 0 ; i < 10;i++)
            {
                Tuple <int,User> userT = new Tuple<int, User>(number,userList[i]);
                userTuple.Add(userT);
                number++;
            }
            int key = 1;
            userTuple.ForEach(item =>Console.WriteLine(item.Item1 + " " + item.Item2 + "\n "));
            Dictionary <int,Tuple<int,User>> dictionary =
                    new Dictionary<int, Tuple<int, User>>();
            for(int i = 0; i < 10; i ++){
                dictionary.Add(key,userTuple[i]);
                key++;
            }
            for (int i = 1; i < 11;i++){
                System.Console.WriteLine("ffsdsd"+dictionary[i].Item2);
            }

            var lines = dictionary.Select(kvp => 
                kvp.Key + ": " + kvp.Value.ToString());
            string ans = string.Join(Environment.NewLine, lines);
            System.Console.WriteLine(ans);

            Dictionary <int,string>d =
                new Dictionary<int, string>();
            d.Add(1,"hello");
            d.Add(2,"hello");
            d.Add(3,"dfsdcs");
            int k = 1;
            System.Console.WriteLine(d[k]);
            var keys = d.Where(x =>
                "hello".Contains(x.Value)).Select(x => x.Key);
            // var myKey = d.FirstOrDefault(x =>
                // x.Value == "hello").Key;
            string a = string.Join(Environment.NewLine, keys);
            System.Console.WriteLine(a);

        }
    }
}
