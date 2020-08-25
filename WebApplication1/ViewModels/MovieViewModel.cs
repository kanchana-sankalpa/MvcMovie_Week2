using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcMovies.ViewModels;

namespace WebApplication1.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Director { get; set; }


        [EmailAddress]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]

        public string ContactEmailAddress { get; set; }


        public Languages Languages { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public  CategoryViewModel Category { get; set; }
        //  dddd https://sensibledev.com/how-to-bind-dropdownlist-in-mvc/
    }
}
