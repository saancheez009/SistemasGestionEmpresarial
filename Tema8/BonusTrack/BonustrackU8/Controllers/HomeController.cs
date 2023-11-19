using BonustrackU8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BonustrackU8.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}