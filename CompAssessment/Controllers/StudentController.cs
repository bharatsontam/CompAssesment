using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompAssessment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Repository<Student> repo = new Repository<Student>();
            var result = repo.GetAll;
            return View(result);
        }

        public ActionResult AddStudent()
        {
            return View();
        }

        
    }
}