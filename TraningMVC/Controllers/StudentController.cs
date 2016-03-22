using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraningMVC.Models;

namespace TraningMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [OutputCache(Duration =10)]
        public ActionResult Index()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student {
                Id = 1,
                FullName = "Nguyen Tran",
                ClassName = "Class1"
            });
            list.Add(new Student
            {
                Id = 2,
                FullName = "Ngoc",
                ClassName = "Class1"
            });

            
            return View(list);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Student model)
        {
            var valid = ModelState.IsValid;
            return View();
        }
    }
}