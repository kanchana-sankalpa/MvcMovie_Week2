using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcMovies.Models;


namespace WebApplication1._BAL.Models
{
    public class MovieBLLModel
    {
        public int Id { get; set; }

   
        public string Name { get; set; }


        public DateTime ReleaseDate { get; set; }

   
        public string Director { get; set; }


        public string ContactEmailAddress { get; set; }


       // public Languages Languages { get; set; }


       // public int CategoryId { get; set; }

       // public  CategoryViewModel Category { get; set; }
        //  https://sensibledev.com/how-to-bind-dropdownlist-in-mvc/
    }
}
