using System.Collections.Generic;

namespace idetTest.Models {
    public class ItemEmployee {
        public int id { get; set; }
        public string name { get; set; }

        public string surname{get;set;}
        public string patronymic { get; set; }
        public Position position { get; set; }
        public List<Permision> listPermision { get; set;}

        public string Gender{get;set;}
    }
}