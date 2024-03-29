﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AboutMe
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Image { get; set; }
        [Required]
        public string Bio { get; set; }
        [Required]
        [StringLength(50)]
        public string SignutureImg { get; set; }

    }
}
