using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace idetTest.Models {
    public class ViewModel {


        public string SelectedAGender { get; set; }
        public IEnumerable<string> selectedListPer { get; set; }
        public IEnumerable<SelectListItem> selectListPer { get; set; }
        public ItemEmployee itemEmployee { get; set; }

        public IEnumerable<Position> position { get; set; }
        public IEnumerable<Department> department { get; set; }
        public IEnumerable<Permision> permision { get; set; }
        public IEnumerable<SelectListItem> selectListPos { get; set; }
        public int selectedListPos { get; set; }
        public IEnumerable<SelectListItem> selectListDep { get; set; }
        public int selectedListDep { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}