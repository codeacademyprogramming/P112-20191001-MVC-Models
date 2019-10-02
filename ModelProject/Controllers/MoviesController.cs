using ModelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            ViewBag.TableTitle = "Filmlərin siyahısı";
            ViewData["tema1"] = "esgerin sohbeti";
            ViewData["tema2"] = "esgerin sohbeti 2";

            P112CinemaEntities _context = new P112CinemaEntities();

            Student student = new Student() {
                Name = "Ceyhun",
                Lastname = "Cavadov"
            };
            List<Movy> movies = _context.Movies.ToList();

            MoviesIndexViewModel model = new MoviesIndexViewModel();
            model.Student = student;
            model.Movies = movies;

            return View(model);
        }
    }
}