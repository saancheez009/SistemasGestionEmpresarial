namespace Ejercicio1.Models.Entities
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellido;
        private int idDpto;
        private int id;
        #endregion

        #region constructores
        public clsPersona()
        {

            this.nombre = "";
            this.apellido = "";
            this.idDpto = 0;
            this.id = 0;    

        }

        public clsPersona(string nombre, string apellido, int idDpto, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idDpto = idDpto;
            this.id = id;
        }
        #endregion

        #region propiedades

        public int Id
        {
            get { return id; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public int IdDpto
        {
            get { return idDpto; }
            set { idDpto = value; }
        }
       


        public String NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        
        #endregion
    }
}
