using System;
using System.Collections.Generic;

namespace lesson2_9
{
    public class UserAgeComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            return x.Age == y.Age || x.Name.Equals(y.Name);
        }

        public int GetHashCode(User obj)
        {
            return obj.Age.GetHashCode();
        }
    }
}