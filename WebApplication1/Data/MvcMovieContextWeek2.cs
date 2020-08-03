using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;      


namespace WebApplication1.Data
{
    public class MvcMovieContextWeek2 : DbContext
    {
        public MvcMovieContextWeek2(DbContextOptions<MvcMovieContextWeek2> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Movie> Category { get; set; }

        public DbSet<WebApplication1.Models.Category> Category_1 { get; set; }
    }
}
