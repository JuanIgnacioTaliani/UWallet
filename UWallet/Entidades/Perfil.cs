namespace UWallet.Entidades
{
    public class Perfil
    {
        #region Atributos
        private int id;
        private string descripcion;
        
        #endregion

        #region Accesores
        public void setIdPerfil(int id) { this.id = id; }
        public int getIdPerfil() { return this.id; }
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public string getDescripcion() { return this.descripcion; }
        
        #endregion

        public Perfil(int id, string descripcion) 
        { 
            this.id = id;
            this.descripcion = descripcion; 
        }
        public Perfil(int id)
        {
            this.id = id;
        }

    }
}
