using Biblioteca;
using BonustrackU8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace BonustrackU8.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(clsMision mision) 
        { 
            


            return View(mision);
        }
        

        

    }
}