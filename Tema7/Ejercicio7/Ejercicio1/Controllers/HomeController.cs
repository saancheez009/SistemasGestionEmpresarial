using Ejercicio1.Models;
using Ejercicio1.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            clsPersona persona = new clsPersona();
            DateTime horaActual = DateTime.Now;

            if (horaActual.Hour >= 5 && horaActual.Hour <= 12)
            {
                ViewData["Saludo"] = "Buenos días";

            }
            else if (horaActual.Hour > 12 && horaActual.Hour < 9)
            {
                ViewData["Saludo"] = "Buenas tardes";

            }
            else 
            {
                ViewData["Saludo"] = "Buenas noches";
            }

            ViewBag.HoraActual = horaActual;


            persona.Nombre = "Juanma";
            persona.Apellido = "Sanchez";
            persona.Direccion = "¿Quieres raptarme?";

            ViewBag.Nombre=persona.Nombre;
            ViewBag.Apellido = persona.Apellido;
            ViewBag.Direccion = persona.Direccion;


            List<clsPersona> listaPers = new List<clsPersona>
            {
                new clsPersona("Juanma", "Sanchez"),
                new clsPersona("Fernando", "Miguel"),
                new clsPersona("Pablo", "Gonzalez"),
                new clsPersona("Yeray", "Jimenez"),
                new clsPersona("Matti", "Ditaranto"),
            };
            
            ViewBag.listPers=listaPers;



            return View();
        }
        

    }
}