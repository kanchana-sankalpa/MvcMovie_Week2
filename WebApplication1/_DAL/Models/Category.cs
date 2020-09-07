using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1._DAL.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Code { get; set; }
    }
}
