using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1._BAL.Models;
using WebApplication1.Models;      

 namespace WebApplication1._BAL.Services
    {
    public interface IMovieService
    {
        MovieBLLModel FetchById(long id);
        List<MovieBLLModel> FetchAll();
        void Update(MovieBLLModel model);
        void Add(MovieBLLModel model);
        void Delete(long id);

    }
        
}
