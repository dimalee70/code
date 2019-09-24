using System;
using System.Collections.Generic;

namespace lesson2_8
{
    public class BookComparer : IComparer<Book>, 
                                IEqualityComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.id - y.id;
        }

        public bool Equals(Book x, Book y)
        {
            return x.id == y.id;
        }

        public int GetHashCode(Book obj)
        {
            return obj.id;
        }



        // public bool Equals(Book x, Book y)
        // {
        //     return x.title == y.title;
        // }

        // public int GetHashCode(Book obj)
        // {
        //     return obj.title.GetHashCode();
        // }
    }
}