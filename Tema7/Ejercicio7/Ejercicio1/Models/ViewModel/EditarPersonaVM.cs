using Ejercicio1.Models.DAL;
using Ejercicio1.Models.Entities;

namespace Ejercicio1.Models.ViewModel

{
    public class EditarPersonaVM: clsPersona
    {
        #region atributos
        private List<clsDepartamento> listaDept;
        #endregion

        #region constructores

        public EditarPersonaVM() 
        { 
            this.listaDept = new List<clsDepartamento>(ListadoDepartamentos.ListadoCompletoDepartamento());
        }

        #endregion

        #region propiedades

        public List<clsDepartamento> ListaDept 
        { 
            get { return listaDept; } 
        } 


        #endregion

    }
}
