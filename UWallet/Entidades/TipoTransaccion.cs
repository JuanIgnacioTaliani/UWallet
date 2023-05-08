namespace UWallet.Entidades
{
    public class TipoTransaccion
    {
        #region Atributos
        private string descripcion;
        private float comision;
        private float monto_max;
        private float monto_min;
        private int id;
        #endregion

        #region Accesores
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public string getDescripcion() { return this.descripcion; }
        public void setComision(int comision) { this.comision = comision; }
        public float getComision() { return this.comision; }
        public void setMontoMax(int monto_max) { this.monto_max = monto_max; }
        public float getMontoMax() { return this.monto_max; }
        public void setMontoMin(int monto_min) { this.monto_min = monto_min; }
        public float getMontoMin() { return this.monto_min; }
        public void setId(int id) { this.id = id; }
        public int getId() { return this.id; }
        #endregion

        public TipoTransaccion(int id, string descripcion, float comision, float monto_max, float monto_min)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.comision = comision;
            this.monto_max = monto_max;
            this.monto_min = monto_min;
        }

        public TipoTransaccion(int id) { this.id = id; }
    
    }
}
