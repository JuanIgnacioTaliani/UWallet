namespace UWallet.Entidades
{
    public class Ciudad
    {
        #region Atributos
        private string nombre;
        private Pais pais;
        private int id;
        #endregion

        #region Accesores
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public Pais getPais() { return pais; }
        public void setPais(Pais pais) { this.pais = pais; }
        public void setId(int id) { this.id = id; }
        public int getId() { return id; }

        #endregion

        public Ciudad(string nombre, Pais pais)
        {
            this.nombre = nombre;
            this.pais = pais;
        }
        public Ciudad(string nombre, int id, Pais pais)
        {
            this.nombre = nombre;
            this.id = id;
            this.pais = pais;
        }

        public bool ValidarNombre() { return !(string.IsNullOrEmpty(nombre)); }
        public bool ValidarPais() { return !(pais == null); }
        public bool IgualNombre(string nombre) { return this.nombre == nombre; }
        public bool IgualPais(Pais pais) { return this.pais.getNombre() == pais.getNombre(); }
        public bool EsIgual(Ciudad ciudad) { return IgualNombre(ciudad.getNombre()) && IgualPais(ciudad.getPais()); }
    }
}
