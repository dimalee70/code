using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using idetTest.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace idetTest.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment _appEnvironment;
 
        public HomeController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        DepartamentDAO departamentDAO = new DepartamentDAO();
        public IActionResult Index()
        {
            List<Department> listDep = new List<Department>();
            listDep = departamentDAO.GetAllDep().ToList();
            return View(listDep);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewModel viewModel = new ViewModel();
            List<SelectListItem> listSelectListPos = new List<SelectListItem>();
            List<SelectListItem> listSelectListDep = new List<SelectListItem>();
            List<SelectListItem> listSelectListPer = new List<SelectListItem>();
            viewModel.position = departamentDAO.GetAllPos();
            viewModel.department = departamentDAO.GetAllDepartment();
            viewModel.permision = departamentDAO.GetAllPermision();
            foreach(var i in viewModel.permision)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = i.name,
                    Value = i.id.ToString()
                };
                listSelectListPer.Add(selectList);
            }
            foreach(var i in viewModel.position)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = i.name,
                    Value = i.id.ToString()
                };
                listSelectListPos.Add(selectList);
            }
            foreach(var i in viewModel.department)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = i.name,
                    Value = i.id.ToString()
                };
                listSelectListDep.Add(selectList);
            }
            viewModel.selectListPos = listSelectListPos;
            viewModel.selectListPer = listSelectListPer;
            viewModel.selectListDep = listSelectListDep;
            return View(viewModel);
        }
    [HttpPost]
    public IActionResult Create(ViewModel viewModel)
    {   

        foreach(string s in viewModel.selectedListPer)
        {
            departamentDAO.insertPer(viewModel.itemEmployee,Convert.ToInt32(s));
        }
        departamentDAO.InsertEmp(viewModel.itemEmployee);
        departamentDAO.insertIntoRel(viewModel.itemEmployee,viewModel.selectedListPos,viewModel.selectedListDep);

        // System.Console.WriteLine(viewModel.ImageFile.FileName.ToString());
        // string path = "/Files/" + viewModel.ImageFile.FileName;
        // using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        // {
        //     viewModel.ImageFile.CopyTo(fileStream);
        // }
        // Image image = new Image{path = filename};
        // departamentDAO.insertImage(image);


        return RedirectToAction("Index");
    }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
