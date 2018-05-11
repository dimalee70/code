using System;
namespace lesson12_2{
    class Library{
        public string Title;
        public int year;
        public Library(string Title,int year)
        {
            this.Title = Title;
            this.year = year;
        }
        public override string ToString()
        {
            return Title + "\n" + year+"\n"; 
        }
    }

}