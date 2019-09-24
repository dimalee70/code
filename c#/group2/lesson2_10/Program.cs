using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lesson2_10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string[]> myList2 = new List<string[]>();
            string [] peoples22 = new string[]{"Dima3", "Li2323"};
            string [] peoples23 = new string[]{"Dima2", "Li232323"};
            string [] peoples24 = new string[]{"Dima1", "Li123232"};
            myList2.Add(peoples22);
            myList2.Add(peoples23);
            myList2.Add(peoples24);




            List<string[]> myList = new List<string[]>();
            string [] peoples1 = new string[]{"Dima4", "Li4"};
            string [] peoples2 = new string[]{"Dima3", "Li3"};
            string [] peoples3 = new string[]{"Dima2", "Li2"};
            string [] peoples4 = new string[]{"Dima1", "Li1"};
            string [] peoples5 = new string[]{"Dima4", "Li4"};
            string [] peoples6 = new string[]{"Dima3", "Li3"};
            string [] peoples7 = new string[]{"Dima2", "Li2"};
            string [] peoples8 = new string[]{"Dima1", "Li1"};
            string [] peoples9 = new string[]{"Dima1", "Li1"};

            myList.Add(peoples1);
            myList.Add(peoples2);
            myList.Add(peoples3);
            myList.Add(peoples4);
            myList.Add(peoples5);
            myList.Add(peoples6);
            myList.Add(peoples7);
            myList.Add(peoples8);
            myList.Add(peoples9);

            List<string> myStr = new List<string>();
            foreach(string [] item in myList)
            {
                myStr.Add(item[0]);
            }
            myStr.Sort();
            
            List <string []> arr = new List<string[]>();

            foreach(string t in myStr)
            {
                string [] tempArr = new string[2];
                tempArr[0] = t;
                foreach(string [] a in myList)
                {
                    if(a[0] == t)
                        tempArr[1] = a[1];
                } 
                arr.Add(tempArr);
            }

            foreach(string [] s in arr)
            {
                System.Console.Write(s[0] + " " + s[1]);
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            // var selectedTeams = from t in myStr
                                // select t;

            //   var selectedTeams = from t in myStr
            //                     orderby t descending
            //                     select t;

            // var selectedTeams = from t in myList
            //                 orderby t[0]
            //                 group t by t[0];
                    

            // System.Console.WriteLine(selectedTeams.GetType());


            // //iterate each group        
            // foreach (var ageGroup in selectedTeams)
            // {
            //     Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 
                        
            //     foreach(string[] s in ageGroup) // Each group has inner collection
            //         Console.WriteLine("Student Name: {0}", s[0] + " " + s[1]);
            // }
            // foreach(string[] s in selectedTeams)
            // {
            //     System.Console.Write(s[0] + " " + s[1]);
            // }
            System.Console.WriteLine();
            
            var selectedTeams = from t in myList
                        orderby t[0]
                        join t2 in myList2
                        on t[0] equals t2[0]
                        select
                        new string []{t[0], t[1], t2[1]};

            foreach(string[]  w in selectedTeams)
            {
                System.Console.WriteLine(w[0] + 
                " " + w[1] + " " + w[2]);
            }
                        // orderby t[0]
                        // group t by t[0];





        

        }
    }
}
