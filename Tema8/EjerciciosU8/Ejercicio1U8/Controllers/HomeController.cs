using Ejercicio1U8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1U8.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saludo(string nombre)
        {
            ViewBag.nombre = nombre;

            return View();
        }

    }
}