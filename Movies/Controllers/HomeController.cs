using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using DAL.DBModels;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {

        private MoviesDataContext _db;

        public HomeController (MoviesDataContext db)
        {
            _db = db;
        }


        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Movie.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var movie = _db.Movie.Single(a => a.Id == id);
            return View(movie);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind()] Movie movieToCreate)
        {
            try
            {
                if (!ModelState.IsValid) return View();
                // TODO: Add insert logic here
                _db.Movie.Add(movieToCreate);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = _db.Movie.Single(a => a.Id == id);
            return View(movie);
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movieToEdit)
        {
            try
            {
                var editMovie = _db.Movie.Single(a=>a.Id == movieToEdit.Id);

                if(editMovie ==null) View(movieToEdit);


                // TODO: Add update logic here
                editMovie.Title = movieToEdit.Title;
                editMovie.Director = movieToEdit.Director;
                editMovie.DateReleased = movieToEdit.DateReleased;

                _db.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = _db.Movie.Single(a => a.Id == id);
            return View(movie);
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Movie m)
        {
            try
            {
                var movie = _db.Movie.Single(a => a.Id == m.Id);

                _db.Movie.Remove(movie);
                _db.SaveChanges();

                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}