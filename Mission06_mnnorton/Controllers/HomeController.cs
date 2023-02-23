using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_mnnorton.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_mnnorton.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _MovieContext { get; set; }

        //Construcotr
        public HomeController(MovieContext someMovie)
        {
            _MovieContext = someMovie;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Movie ()
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movie (ApplicationResponse ar)
        {
            if(ModelState.IsValid)
            {
                _MovieContext.Add(ar);
                _MovieContext.SaveChanges();

                return View("confirmation");
            }
            else //invalid
            {
                ViewBag.Categories = _MovieContext.Categories.ToList();
                return View(ar);
            }
            
        }

        public IActionResult Podcast()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var MovieList = _MovieContext.Responses.
                Include(x => x.Category).
                OrderBy(x => x.MovieTitle).
                ToList();
            return View(MovieList);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();
            var entry = _MovieContext.Responses.Single(x => x.MovieID == movieid);

            return View("Movie", entry);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blahmovie)
        {
            _MovieContext.Update(blahmovie);
            _MovieContext.SaveChanges();
            return RedirectToAction("MovieList");

        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
