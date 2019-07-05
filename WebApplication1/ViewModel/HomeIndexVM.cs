using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class HomeIndexVM
    {
        public IEnumerable<PopularPropertie> PopularProperties { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public AboutMe AboutMe { get; set; }
    }
}
