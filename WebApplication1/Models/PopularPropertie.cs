using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PopularPropertie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string BlogTitle { get; set; }

        [Required]
        [StringLength(200)]
        public string Blog { get; set; }
    }
}
