using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    public class TransaccionesServicio
    {
        private readonly TransaccionesRepositorio repositorio;


        public TransaccionesServicio()
        {
            repositorio = new TransaccionesRepositorio();
        }
        #region VALIDACIONES (compra, venta, ingreso)
        public bool ValidarCompra(Transaccion c)
        {
            return c.ValidarMonedero() && c.ValidarTipo() && c.ValidarMontoUSD();
        }
        public bool ValidarVenta(Transaccion v)
        {
            return v.ValidarMonedero() && v.ValidarTipo() && v.ValidarMontoCriptoEnMonedero() && v.ValidarMontoCripto();
        }
        public bool ValidarIngreso(Transaccion i)
        {
            return i.ValidarMonedero() && i.ValidarTipo() && i.ValidarMontoUSD();
        }
        #endregion

        #region TRANSACCIONES (comprar, vender, ingresar)
        public void Comprar(Transaccion c)
        {
            float comision = c.getTipo().getComision();
            float monto_comision = (float)Math.Round(c.getMontoUSD() * comision);
            c.setMontoComision(monto_comision);

            float monto_usd = c.getMontoUSD() - monto_comision;
            c.setMontoUSD(monto_usd);

            var monto_cripto = (float)Math.Round(c.getMontoUSD() / c.getCotizacion().getPrecio(), 8);
            c.setMontoCripto(monto_cripto);
            c.setFechaHoraTransaccion(DateTime.Now);
            repositorio.Comprar(c);
        }
        public void Vender(Transaccion v)
        {
            float comision = v.getTipo().getComision();
            float monto_usd_pre_comision = (float)Math.Round(v.getMontoCripto() * v.getCotizacion().getPrecio(), 2);
            float monto_comision = (float)Math.Round(monto_usd_pre_comision * comision, 2);
            v.setMontoComision(monto_comision);
            
            float monto_usd = monto_usd_pre_comision - monto_comision;
            v.setMontoUSD(monto_usd);

            v.setFechaHoraTransaccion(DateTime.Now);
            repositorio.Vender(v);
        }
        public void Ingresar(Transaccion i)
        {
            float comision = i.getTipo().getComision();
            float monto_comision = (float)Math.Round(i.getMontoUSD() * comision);
            i.setMontoComision(monto_comision);

            float monto_usd = i.getMontoUSD() - monto_comision;
            i.setMontoUSD(monto_usd);
            
            float monto_cripto = 0;
            i.setMontoCripto(monto_cripto);
            i.setFechaHoraTransaccion(DateTime.Now);
            repositorio.Ingresar(i);
        }
        #endregion
        public double CriptoEstimado(float usdIngresado, float precio) 
        {
            return Math.Round(usdIngresado / precio, 6);
        }

        internal double UsdEstimado(float criptoIngresado, float precio)
        {
            return Math.Round(criptoIngresado * precio, 2);
        }
    }
}
