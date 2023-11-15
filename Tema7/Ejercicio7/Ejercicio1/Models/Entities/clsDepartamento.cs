namespace Ejercicio1.Models.Entities
{
    public class clsDepartamento
    {
        #region atributos
        private int id;

        private string nombre;
        #endregion

        #region contructor
        public clsDepartamento(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;   
        }
        #endregion


        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion
    }
}
