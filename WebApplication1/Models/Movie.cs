using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Director { get; set; }


        [EmailAddress]
        public string ContactEmailAddress { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
        //  dddd https://sensibledev.com/how-to-bind-dropdownlist-in-mvc/
    }
}
