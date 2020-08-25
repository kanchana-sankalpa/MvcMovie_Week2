using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1._BAL.Models;
using WebApplication1._DAL.Models;
using WebApplication1._DAL.Service;
using WebApplication1.Models; 



namespace WebApplication1._DAL.Services
{
    public interface IDALService
    {
        List<MovieBLLModel> FetchAllMovies();
        void DeleteMovie(long id);
        void UpdateMovie(MovieBLLModel model);
        void AddMovie(MovieBLLModel model);


        //CategoryBLLModel FetchCategory(long id);
        //CategoryBLLModel FetchCategory(string codeValue);
        //List<CategoryBLLModel> FetchAllCategory();
        //void DeleteCategory(long id);
        //void UpdateCategory(CategoryBLLModel model);
        //void AddCategory(CategoryBLLModel model);


    }

    public class DALService : IDALService
    {
        private readonly MvcMovieContextWeek4 context;

        public DALService(MvcMovieContextWeek4 _context)
        {
            this.context = _context;
        }

        public List<MovieBLLModel> FetchAllMovies()
        {
            var efModel = context.Movie.ToList();
            var returnObject = new List<MovieBLLModel>();

            foreach (var item in efModel)
            {
                returnObject.Add(new MovieBLLModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    ReleaseDate = item.ReleaseDate,
                    Director = item.Director,
                    ContactEmailAddress = item.ContactEmailAddress
                });
            }

            return returnObject;
        }

        public void MoviesEmployee(long id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMovie(MovieBLLModel model)
        {
            throw new System.NotImplementedException();
        }

        public void AddMoviea(MovieBLLModel model)
        {
            var efModel = new Movie()
            {
                Name = model.Name,
                ReleaseDate = model.ReleaseDate,
                Director = model.Director,
                ContactEmailAddress = model.ContactEmailAddress
              
            };
            context.Movie.Add(efModel);
            context.SaveChanges();
        }

        List<MovieBLLModel> IDALService.FetchAllMovies()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMovie(long id)
        {
            throw new System.NotImplementedException();
        }


        public void AddMovie(MovieBLLModel model)
        {
            throw new System.NotImplementedException();
        }

        void IDALService.DeleteMovie(long id)
        {
            throw new System.NotImplementedException();
        }

        void IDALService.UpdateMovie(MovieBLLModel model)
        {
            throw new System.NotImplementedException();
        }

        void IDALService.AddMovie(MovieBLLModel model)
        {
            throw new System.NotImplementedException();
        }
    }
    }
