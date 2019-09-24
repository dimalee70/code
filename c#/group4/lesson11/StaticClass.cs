using System;

namespace lesson11
{
    public static class StaticClass
    {

        public static string HalfString (this string str)
        {
            string temp = str.Remove(str.Length/2,str.Length/2);
            return temp;
        }

        public static int HalfInt (this int str)
        {
            return str/2;
        }
    }
}