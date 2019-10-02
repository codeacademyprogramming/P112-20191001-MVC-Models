using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseProject.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            P112CourseEntities db = new P112CourseEntities();
            List<Student> students = db.Students.OrderBy(s => s.Firstname).ToList();

            return View(students);
        }

        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return Content("Id null ola bilmez");
            }

            P112CourseEntities db = new P112CourseEntities();
            Student student = db.Students.Find(Id);

            if (student == null)
            {
                return HttpNotFound();
            }

            //Student student = new Student {
            //    Firstname = "Sattar",
            //    Lastname = "Amrahov",
            //    Email = "sattar@code.edu.az",
            //    Birthdate = new DateTime(1992, 12, 6)
            //};
            return View(student);
        }


        public string Test(int a)
        {
            return "sizin gonderdiyiniz eded = " + a;
        }
    }
}