namespace UWallet.Entidades
{
    public class Pais
    {
        #region Atributos
        private string nombre;
        private int id;
        #endregion

        #region Accesores
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return nombre; }
        public int getId() { return id; }
        public void setId(int id) { this.id = id; }
        #endregion

        public Pais(string nombre,int id) 
        {
            this.nombre = nombre;
            this.id = id;
        }
        public Pais(string nombre) { this.nombre = nombre; }

        public bool ValidarNombre() { return !string.IsNullOrEmpty(nombre); }
        public bool IgualNombre(Pais pais) { return nombre == pais.getNombre(); }
    }
}
