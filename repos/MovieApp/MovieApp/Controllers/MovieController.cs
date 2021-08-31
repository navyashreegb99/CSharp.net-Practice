using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Minions!!" };
            return View(movie);
            // return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
           // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int MovieId)
        {
            return Content("Id=" + MovieId);
        }

        public ActionResult Index(int? PageIndex, string sortBy)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("PAgeIndex={0},sortBy={1}", PageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year,int month)
        {

            return Content(year+"/"+month);
            
        }
    }
}