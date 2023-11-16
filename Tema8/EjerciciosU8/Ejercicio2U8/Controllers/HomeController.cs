using Ejercicio2U8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio2U8.Controllers
{
    public class HomeController : Controller
    {
      
        //Action de la primera vez que el usuario pide en la pagina
        public IActionResult Index()
        {
            return View();
        }

        //Action cuando el usuario pulse el boton
        [HttpPost]
        public IActionResult Index(string nombre) 
        { 

            ViewBag.nombre = nombre;

            return View("Saludo");        
        }

       
    }
}