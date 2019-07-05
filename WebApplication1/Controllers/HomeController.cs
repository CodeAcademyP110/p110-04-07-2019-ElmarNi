using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly YourAgentDbContext _context;
        public HomeController(YourAgentDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeIndexVM viewModel = new HomeIndexVM() {
                PopularProperties = _context.PopularProperties,
                Testimonials = _context.Testimonials,
                AboutMe = _context.AboutMe.First()
            };
            return View(viewModel);
        }
    }
}