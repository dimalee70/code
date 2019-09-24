using System.Collections.Generic;

namespace idetTest.Models {
    public class Department {
        public int id { get; set; }
        public string name { get; set; }
        public List<ItemEmployee> listEmployee { get; set; }
    }
}