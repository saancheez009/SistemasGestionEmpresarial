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

        [HttpPost]
       public IActionResult Index(clsMision mision) 
        {
            clsMision misionSelect = ListadoMisiones.ListadoMisionesCompleto().Find(m => m.Id == mision.Id);
         
            return View(misionSelect);
    
        }
        
    }
}