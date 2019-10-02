using ModelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student student = new Student();
            student.Name = "Esger";
            student.Lastname = "Aghazade";

            return View(student);
        }
    }
}