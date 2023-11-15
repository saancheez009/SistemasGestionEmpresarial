namespace Ejercicio1.Models.Entities
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellido;
        private int idDpto;
        #endregion

        #region constructores
        public clsPersona()
        {
            this.nombre = "";
            this.apellido = "";
            this.idDpto = 0;

        }

        public clsPersona(string nombre, string apellido, int idDpto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idDpto = idDpto;
        }
        #endregion

        #region propiedades
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

        public String Direccion { get; set; }

        public String NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        public int IdDpto 
        {
            get { return idDpto;  }
            set { idDpto = value; }
        }

        #endregion
    }
}
