using System;

namespace lesson8{
    struct Book
    {
        private string  _name, _author;
        private int _year;
        //конструктор
        public Book(string n, string a, int y)
        {
            _name = n;
            _author = a;
            _year = y;
        }
        public string NameOfBook {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }

        public string AuthorOfBook
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        public int YearOfBook{
            get{
                return _year;
            }
            set{
                _year = value;
            }
        }
        public void Info()
        {
            Console.WriteLine("Name : {0}, Author: {1}, Year: {2}", _name, _author,_year);
        }
    }
}