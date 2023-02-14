using DenemeApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApp.Web.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int hour =DateTime.Now.Hour;
            ViewBag.Greating = hour<12?"Good Afternoon":"Good Morning";

            return View("MyView");
        }
        //course/list
        public ViewResult List()
        {

            var liste = Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }
            
        }
    }
}
