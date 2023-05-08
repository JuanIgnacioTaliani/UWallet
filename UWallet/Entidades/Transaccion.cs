using System;
using System.Drawing;
using System.Windows.Forms;
using UWallet.Interfaces.Notificaciones;

namespace UWallet.Entidades
{
    public class Transaccion
    {
        #region Atributos
        private Monedero monedero;
        private DateTime fecha_hora_transaccion;
        private TipoTransaccion tipo;
        private float monto_usd;
        private float monto_cripto;
        private Cotizacion cotizacion;
        private float monto_comision;
        #endregion

        #region Accesores
        public void setMonedero(Monedero monedero) { this.monedero = monedero; }
        public Monedero getMonedero() { return this.monedero; }

        public void setFechaHoraTransaccion(DateTime fecha_hora_cotizacion) { this.fecha_hora_transaccion = fecha_hora_cotizacion; }
        public DateTime getFechaHoraTransaccion() { return this.fecha_hora_transaccion; }

        public void setTipo(TipoTransaccion tipo) { this.tipo = tipo; }
        public TipoTransaccion getTipo() { return this.tipo; }

        public void setCotizacion(Cotizacion cotizacion) { this.cotizacion = cotizacion; }
        public Cotizacion getCotizacion() { return this.cotizacion; }

        public void setMontoUSD(float monto_usd) { this.monto_usd = monto_usd; }
        public float getMontoUSD() { return this.monto_usd; }

        public void setMontoCripto(float monto_cripto) { this.monto_cripto = monto_cripto; }
        public float getMontoCripto() { return this.monto_cripto; }

        public void setMontoComision(float monto_comision) { this.monto_comision = monto_comision; }
        public float getMontoComision() { return this.monto_comision; }
        #endregion
        
        public Transaccion(Monedero monedero, TipoTransaccion tipoTx, float montoUSD, Cotizacion cotizacion)
        {
            this.monedero = monedero;
            this.tipo = tipoTx;
            this.monto_usd = montoUSD;
            this.cotizacion = cotizacion;
        }

        public Transaccion(Monedero monedero, TipoTransaccion tipoTx, Cotizacion cotizacion, float monto_cripto)
        {
            this.monedero = monedero;
            this.tipo = tipoTx;
            this.monto_cripto = monto_cripto;
            this.cotizacion = cotizacion;
        }

        //TODO: cambiar las excepciones por notificaciones en frm.
        //TODO: hacer los mensajes mas especificos.
        //TODO: VALIDACION!!! validar que el broker tenga suficiente saldo para la tx.

        public bool ValidarMonedero()
        {
            if (monedero == null)
            {
                new frmNotificacion("El monedero es requerido", Color.FromArgb(255, 192, 128), 2);
                return false;
            }
            else 
            { 
                return true; 
            }
        }

        public bool ValidarMontoCriptoEnMonedero()
        {
            if (monedero.getSaldo() < monto_cripto)
            { 
                new frmNotificacion("No se posee el saldo suficiente", Color.FromArgb(255, 192, 128), 2);
                return false;
            }
            else
            {
                return true;
            }
        }

        // TODO: VALIDACION!!! validar que el usuario posee suficiente usd en su monedero de usd.
        // No se como conseguir el saldo de ese monedero a partir del monedero de la cripto.
        //public void ValidarMontoUSDEnMonedero()
        //{
        //    NO SE COMO VALIDAR, PORQUE NO TENGO EL MONEDERO DE USD :(
        //    if (monedero.getSaldo() < monto_usd)
        //        throw new ApplicationException("No se posee el saldo suficiente.");
        //}

        public bool ValidarTipo()
        {
            if (tipo == null || tipo.getId() == 0)
            { 
                new frmNotificacion("El tipo de tx es requerida", Color.FromArgb(255, 192, 128), 2);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarMontoUSD()
        {
            if (monto_usd < tipo.getMontoMin() || monto_usd > tipo.getMontoMax() || monto_usd <= 0)
            { 
                new frmNotificacion("El monto es incorrecto", Color.FromArgb(255, 192, 128), 2);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarMontoCripto()
        {
            if (monto_cripto <= 0)
            { 
                new frmNotificacion("El monto es incorrecto", Color.FromArgb(255, 192, 128), 2);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
