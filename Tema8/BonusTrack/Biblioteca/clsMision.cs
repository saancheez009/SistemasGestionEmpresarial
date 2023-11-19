namespace Biblioteca
{
    public class clsMision
    {
        #region atributos
        private string nombre;
        private string detalles;
        private int recompensa;
        #endregion

        #region constructores
        public clsMision() 
        {
            nombre = "";
            detalles = "";
            recompensa = 0;
        }
        public clsMision(string nombre, string detalles, int recompensa)
        {
            this.nombre = nombre;
            this.detalles = detalles;
            this.recompensa = recompensa;
        }
        #endregion

        #region propiedades
        public string Nombre 
        { 
            get { return nombre; }
        }
        
        public string Detalles 
        {
            get { return detalles; }
        }

        public int Recompensa 
        {
            get { return recompensa; }
        }
        #endregion
    }
}