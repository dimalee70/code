using System;
using lesson10;

namespace lesson10{


    class Contact{
        public string number {set;get;}
        public string name {set; get;}

        public Contact(string name, string number){
            this.name = name;
            this.number = number;
        }
    }
}