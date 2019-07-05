using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class YourAgentDbContext : DbContext
    {
        public YourAgentDbContext(DbContextOptions<YourAgentDbContext> options) : base(options)
        {

        }
        public DbSet<PopularPropertie> PopularProperties { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
    }
}
