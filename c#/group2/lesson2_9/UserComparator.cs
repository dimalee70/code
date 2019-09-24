using System;
using System.Collections.Generic;

namespace lesson2_9
{
    public class UserComparator : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.Name.CompareTo(y.Name);
            // return x.Age - y.Age;
        }
    }
}