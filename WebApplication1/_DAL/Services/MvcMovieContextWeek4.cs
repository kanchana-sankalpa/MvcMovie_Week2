using Microsoft.EntityFrameworkCore;
using WebApplication1._DAL.Models;
using WebApplication1.Models;      
using WebApplication1._BAL.Models;


namespace WebApplication1._DAL.Service
{
    public class MvcMovieContextWeek4 : DbContext
    {
        public MvcMovieContextWeek4(DbContextOptions<MvcMovieContextWeek4> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        //public DbSet<WebApplication1._BAL.Models.MovieBLLModel> MovieBLLModel { get; set; }

        public DbSet<Category> Category { get; set; }

       //public DbSet<WebApplication1.Models.CategoryViewModel> Category_1 { get; set; }
    }
}
