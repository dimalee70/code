using System;
using System.Collections.Generic;

namespace lesson2_8
{
    public class Book
    {
        public int id { get; set;}

        public string title{ get; set;}

        public Book(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public override string ToString()
        {
            return id + "\t" + title;
        }

        // public int CompareTo(Book other)
        // {
        //     return id - other.id;
        // }


        // public bool Equals(Book x, Book y)
        // {
        //     return x.id == y.id;
        // }

        // public int GetHashCode(Book obj)
        // {
        //     throw new NotImplementedException();
        // }
    }

}