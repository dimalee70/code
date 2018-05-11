using System;
namespace lesson12_2
{
    class MyLibrary<T>
    {
        public int size = 4;
        public T[] myArr;

        public MyLibrary()
        {
            myArr = new T[size];
        }
        public T myAdd(T obj)
        {
            for(int i = 0; i < size; i++)
            {
                if(myArr[i] == null)
                {
                    myArr[i] = obj;
                    return obj;
                }
                
            }
            return obj;
        }
        public override string ToString(){
            string result = "";
            foreach(T myT in myArr)
            {
                result += myT.ToString();
            }
            return result;
        }
    }
}