using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovies.Models
{
    public enum Languages
    {
        [Display(Name = "English")]
        English,
        [Display(Name = "Hindi")]
        Hindi,
        [Display(Name = "Sinhala")]
       Sinhala
    }
}
