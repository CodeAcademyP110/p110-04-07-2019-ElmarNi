using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [Required]
        [StringLength(300)]
        public string Comment { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}
