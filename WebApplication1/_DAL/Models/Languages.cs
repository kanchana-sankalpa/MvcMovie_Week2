using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum LanguagesViewModel
    {
        [Display(Name = "English")]
        English,
        [Display(Name = "Hindi")]
        Hindi,
        [Display(Name = "Sinhala")]
       Sinhala
    }
}
