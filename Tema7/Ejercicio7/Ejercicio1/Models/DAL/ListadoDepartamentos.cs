using Ejercicio1.Models.Entities;

namespace Ejercicio1.Models.DAL
{
    public class ListadoDepartamentos
    {

        public static List<clsDepartamento> ListadoCompletoDepartamento()
        {
            List<clsDepartamento> listaDept = new List<clsDepartamento>()
            {
                new clsDepartamento(1,"RRHH"),
                new clsDepartamento(2,"Produccion"),
                new clsDepartamento(3,"Administracion"),
                new clsDepartamento(4,"Finanzas"),
                new clsDepartamento(5,"Marketing"),
                
            };
            return listaDept;   
        }

    }
}
