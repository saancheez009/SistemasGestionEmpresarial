using Ejercicio1.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Models.DAL
{
    public static class ListadoPersona 
    {
        /// <summary>
        ///  Funcion que devuelve un listado de personas
        ///  Precondición: ninguna
        ///  Posrcondición: ninguna
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> listadoCompletoPersonas() {

            List<clsPersona> listaPersona = new List<clsPersona>
            {
                new clsPersona("Juanma", "Sanchez",1,1),
                new clsPersona("Fernando", "Miguel",2,2),
                new clsPersona("Pablo", "Gonzalez",3,3),
                new clsPersona("Yeray", "Jimenez",5,4),
                new clsPersona("Matti", "Ditaranto",4,5),
            };

            return listaPersona;

        }

    }
}
