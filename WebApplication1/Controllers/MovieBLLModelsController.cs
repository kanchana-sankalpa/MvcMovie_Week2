using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1._BAL.Models;
using WebApplication1._BAL.Services;
using WebApplication1.ViewModels;

namespace MvcMovies.Controllers
{
    public class MovieBLLModelsController : Controller
    {
      
        private readonly IMovieService _movieService;


        // GET: MovieBLLModels
        public async Task<IActionResult> Index()
        {
            return View();
        }
        /*
        // GET: MovieBLLModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieBLLModel = await _context.MovieBLLModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieBLLModel == null)
            {
                return NotFound();
            }

            return View(movieBLLModel);
        }
        */
        // GET: MovieBLLModels/Create
        public IActionResult Create()
        {
            return View();
        }
        /*
        // POST: MovieBLLModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ReleaseDate,Director,ContactEmailAddress")] MovieBLLModel movieBLLModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieBLLModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieBLLModel);
        }

        // GET: MovieBLLModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieBLLModel = await _context.MovieBLLModel.FindAsync(id);
            if (movieBLLModel == null)
            {
                return NotFound();
            }
            return View(movieBLLModel);
        }

        // POST: MovieBLLModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ReleaseDate,Director,ContactEmailAddress")] MovieBLLModel movieBLLModel)
        {
            if (id != movieBLLModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieBLLModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieBLLModelExists(movieBLLModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movieBLLModel);
        }

        // GET: MovieBLLModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieBLLModel = await _context.MovieBLLModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movieBLLModel == null)
            {
                return NotFound();
            }

            return View(movieBLLModel);
        }

        // POST: MovieBLLModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieBLLModel = await _context.MovieBLLModel.FindAsync(id);
            _context.MovieBLLModel.Remove(movieBLLModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieBLLModelExists(int id)
        {
            return _context.MovieBLLModel.Any(e => e.Id == id);
        }


        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _movieService;
        public HomeController(ILogger<HomeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _movieService = employeeService;
        }
        */
       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public ActionResult MovieList()
        {
            var movieBModels = _movieService.FetchAll();

            var vmList = new List<MovieViewModel>();
            foreach (var item in movieBModels)
            {
                var vmMovie = new MovieViewModel();

                vmMovie.Id = item.Id;
                vmMovie.Name = item.Name.ToUpper();
                vmMovie.ReleaseDate = item.ReleaseDate; //.ToString();
                vmMovie.Director = item.Director;
                /*
                if (item.Salary > 5)
                {
                    vmEmployee.SalaryColor = "green";
                }
                else
                {
                    vmEmployee.SalaryColor = "red";
                }
                */
                vmList.Add(vmMovie);
            }

            return View(vmList);
        }

        [HttpGet]
        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                //add to business layer
                var emplyeeBModel = new MovieBLLModel();
                emplyeeBModel.Name = model.Name;
                emplyeeBModel.ReleaseDate = model.ReleaseDate;
                emplyeeBModel.Director = model.Director;
                _movieService.Add(emplyeeBModel);

                return RedirectToAction("EmployeeList");
            }

            return View(model);
        }
    }
}
