using System;

namespace UWallet.Entidades
{
    public class Cotizacion
    {
        #region Atributos
        private DateTime fecha_hora_cotizacion;
        private Criptomoneda criptomoneda;
        private float precio;
        #endregion

        #region Accesores
        public void setFechaHoraCotizacion(DateTime fecha_hora_cotizacion) { this.fecha_hora_cotizacion = fecha_hora_cotizacion; }
        public DateTime getFechaHoraCotizacion() { return this.fecha_hora_cotizacion; }
        public void setIdCripto(Criptomoneda criptomoneda) { this.criptomoneda = criptomoneda; }
        public Criptomoneda getCripto() { return this.criptomoneda; }
        public void setPrecio(float precio) { this.precio = precio; }
        public float getPrecio() { return this.precio; }
        #endregion

        public Cotizacion(DateTime fecha, Criptomoneda cripto, float precio)
        {
            this.fecha_hora_cotizacion = fecha;
            this.criptomoneda = cripto;
            this.precio = precio;
        }

        public Cotizacion(float precio)
        {
            this.precio = precio;
        }
    }
}
