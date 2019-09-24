using System;

namespace lesson2_5
{
    public class Test<T, V, K> where K : CellPhone, BaseInterface
    {
        public T id{get;set;}
        public V name{get;set;}

        public K[] arr{get;set;}
        public Test(T id, V name, int s)
        {
            this.id = id;
            this.name = name;
            this.arr = new K[s];
        }

        public void add(int i, K val)
        {
             arr[i] = val;
        }

        public void pritnArr()
        {
            foreach(K v in arr)
            {
                // v.addString("dfdsc");
                System.Console.Write(v.ToString() + " ");
            }
            System.Console.WriteLine();
        }



        // public static implicit operator string(Test test)
        // {
        //     return "id " + test.id + "/tname " + test.name;
        // }
        public override string ToString()
        {
             return "id " + id.ToString() + "\tname " + name.ToString() ;
        }

    }
}