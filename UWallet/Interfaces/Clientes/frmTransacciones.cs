using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Entidades.Enums;
using UWallet.Interfaces.Notificaciones;
using UWallet.Servicios;

namespace UWallet.Interfaces.Clientes
{
    public partial class frmTransacciones : Form
    {
        #region INICIALIZADORES
        private readonly MonederosServicio monederosServicio;
        private readonly CotizacionesServicio cotizacionesServicio;
        private readonly TransaccionesServicio transaccionesServicio;
        private readonly TipoTransaccionesServicio tipoTransaccionServicio;
        private frmNotificacion notificacion;
        private Point ingreso; 
        private Point egreso;
        private Guna2Button btnActivo;
        private List<Monedero> monederos;
        private List<Monedero> monederos_secundario;
        private Monedero monederoSeleccionado;
        private btnCripto btnSeleccionado;
        #endregion
        public frmTransacciones()
        {
            InitializeComponent();
            notificacion = new frmNotificacion();
            ingreso = txtDolar.Location;
            egreso = txtCripto.Location;
            monederosServicio = new MonederosServicio();
            cotizacionesServicio = new CotizacionesServicio();
            transaccionesServicio = new TransaccionesServicio();
            tipoTransaccionServicio = new TipoTransaccionesServicio();
            monederos = monederosServicio.GetMonederos();
            monederos_secundario = monederosServicio.GetMonederos();
            ActivarFoco(btnComprar);
        }
        #region CARGA DE MONEDEROS
        private void ActivarFoco(Guna2Button btnFoco)
        {
            btnFoco.Checked = true;
            btnFoco.Cursor = DefaultCursor;
            if (btnActivo != btnFoco && btnActivo != null)
            {
                btnActivo.Checked = false;
                btnActivo.Cursor = Cursors.Hand;
            }
            btnActivo = btnFoco;
            GenerarBotones();
        }
        private void GenerarBotones()
        {
            var monedero = EliminarMonederoDeLista();
            pnlSeleccionar.Controls.Clear();
            imgMonedero.Visible = false;
            lblCantidad.Text = "-";
            btnCripto[] listaMonederos = new btnCripto[monedero.Count];
            for (int i = 0; i < listaMonederos.Length; i++)
            {
                listaMonederos[i] = new btnCripto();
                listaMonederos[i].Cursor = Cursors.Hand;
                listaMonederos[i].Logo = monedero[i].getCripto().Image;
                listaMonederos[i].Abreviatura = monedero[i].getCripto().Abreviacion;
                listaMonederos[i].Nombre = monedero[i].getCripto().Nombre;
                listaMonederos[i].Id_cripto = monedero[i].getCripto().Id.ToString();
                listaMonederos[i].Cantidad = monedero[i].getCripto().Cantidad.ToString();
                listaMonederos[i].Id_usuario = monedero[i].getUsuario().getIdUsuario().ToString();
                listaMonederos[i].Saldo = monedero[i].getSaldo().ToString();
                listaMonederos[i].Click += new EventHandler(Botones_Click);
                pnlSeleccionar.Controls.Add(listaMonederos[i]);
            }
        }
        public List<Monedero> EliminarMonederoDeLista()
        {
            if (btnIngresar == btnActivo)
            {
                
                var monederoUSD = new List<Monedero>();
                for (int j = 0; j < monederos.Count; j++)
                {
                    var abreviatura = monederos[j].getCripto().Abreviacion;
                    if (abreviatura == "USD")
                    {
                        monederoUSD.Add(monederos[j]);
                        break;
                    }
                }
                return monederoUSD;
            }
            else
            {
                foreach (Monedero mon in monederos)
                {
                    var abreviatura = mon.getCripto().Abreviacion;
                    if (monederos_secundario.Count == monederos.Count)
                    {
                        for (int j = 0; j < monederos_secundario.Count; j++)
                        {
                            if (monederos_secundario[j].getCripto().Abreviacion == "USD" && abreviatura == "USD")
                            {
                                monederos_secundario.RemoveAt(j);
                                break;
                            }
                        }
                    }
                }
                return monederos_secundario;
            }
        }
        #endregion

        #region EVENTOS CLICK DE BOTONES
        public void Botones_Click(object sender, EventArgs e)
        {
            btnSeleccionado = (btnCripto)sender;
            txtCripto.PlaceholderText = btnSeleccionado.Abreviatura;
            txtCripto.IconLeft = btnSeleccionado.Logo;
            imgMonedero.Visible = true;
            imgMonedero.Image = btnSeleccionado.Logo;
            lblCantidad.Text = btnSeleccionado.Saldo;
            txtCripto.Text = string.Empty;
            txtDolar.Text = string.Empty;
            ObtenerMonederoSeleccionado(btnSeleccionado);
        }

        private void ObtenerMonederoSeleccionado(btnCripto btnCripto)
        {
            var usuario = new Usuario(Convert.ToInt16(btnCripto.Id_usuario));
            var cripto = new Criptomoneda(Convert.ToInt16(btnCripto.Id_cripto), btnCripto.Abreviatura, Convert.ToDouble(btnCripto.Cantidad));
            var saldo = (float)Convert.ToDouble(btnCripto.Saldo);
            monederoSeleccionado = new Monedero(usuario, cripto, saldo);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            lblTransaccion.Text = btnComprar.Text;
            txtDolar.Location = ingreso;
            txtCripto.Location = egreso;
            txtDolar.Enabled = true;
            txtCripto.Enabled = false;
            pnlSeleccionar.Enabled = true;
            txtCripto.Visible = true;
            lblEgreso.Visible = true;
            txtCripto.Text = String.Empty;
            txtDolar.Text = String.Empty;
            ActivarFoco(btnComprar);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            lblTransaccion.Text = btnVender.Text;
            txtDolar.Location = egreso;
            txtCripto.Location = ingreso;
            txtDolar.Enabled = false;
            txtCripto.Enabled = true; 
            pnlSeleccionar.Enabled = true;
            txtCripto.Visible = true;
            lblEgreso.Visible = true;
            txtCripto.Text = String.Empty;
            txtDolar.Text = String.Empty;
            ActivarFoco(btnVender);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblTransaccion.Text = btnIngresar.Text;
            txtDolar.Location = ingreso;
            txtDolar.Enabled = true;
            txtCripto.Visible = false;
            lblEgreso.Visible = false;
            txtCripto.Text = String.Empty;
            txtDolar.Text = String.Empty;
            ActivarFoco(btnIngresar);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (btnActivo == btnComprar)
            {
                if (txtDolar.Text.Length > 10) 
                { 
                    new frmNotificacion("Cantidad de decimales excedida", Color.FromArgb(255, 0, 0), 3);
                    txtDolar.Focus();
                }
                else { Comprar((float)Convert.ToDouble(txtDolar.Text)); }
            }

            if (btnActivo == btnVender)
            {
                if (txtCripto.Text.Length > 10) 
                { 
                    new frmNotificacion("Cantidad de decimales excedida", Color.FromArgb(255, 0, 0), 3);
                    txtCripto.Focus();
                }
                else { Vender((float)Convert.ToDouble(txtCripto.Text)); }
            }

            if (btnActivo == btnIngresar)
            {
                if (txtDolar.Text.Length > 10) 
                { 
                    new frmNotificacion("Cantidad de decimales excedida", Color.FromArgb(255, 0, 0), 3);
                    txtDolar.Focus();
                }
                else { Ingresar((float)Convert.ToDouble(txtDolar.Text)); }
            }
            txtDolar.Text = String.Empty;
            txtCripto.Text = String.Empty;
        }
        #endregion

        #region TRANSACCIONES
        private void Comprar(float montoUsd) 
        { 
            var tipo_tx = tipoTransaccionServicio.obtenerTipoTransaccion((int)TipoTransaccionesDisponibles.Compra);
            var cotizacion = cotizacionesServicio.obtenerCotizacionReciente(monederoSeleccionado.getCripto().Id);
            var compra = new Transaccion(monederoSeleccionado, tipo_tx, montoUsd, cotizacion);
            if (transaccionesServicio.ValidarCompra(compra))
            {
                transaccionesServicio.Comprar(compra);
                notificacion.ShowNotificacion("Compra exitosa", Color.FromArgb(34, 139, 34), 1);
                //lblCantidad.Text = (Convert.ToDouble(lblCantidad.Text) + Convert.ToDouble(txtCripto.Text)).ToString();
            }
            else
            {
                notificacion.ShowNotificacion("Error en la compra", Color.FromArgb(255, 0, 0), 3);
            }
        }

        private void Vender(float montoCripto) 
        {
            var tipo_tx = tipoTransaccionServicio.obtenerTipoTransaccion((int)TipoTransaccionesDisponibles.Venta);
            var cotizacion = cotizacionesServicio.obtenerCotizacionReciente(monederoSeleccionado.getCripto().Id);
            var venta = new Transaccion(monederoSeleccionado, tipo_tx, cotizacion, montoCripto);
            if (transaccionesServicio.ValidarVenta(venta))
            {
                transaccionesServicio.Vender(venta);
                notificacion.ShowNotificacion("Venta exitosa", Color.FromArgb(34, 139, 34), 1);
                //lblSaldo.Text = (Convert.ToDouble(lblSaldo.Text.Replace("$ ",string.Empty)) + Convert.ToDouble(txtDolar.Text)).ToString();

            }
            else
            {
                notificacion.ShowNotificacion("Error en la venta", Color.FromArgb(255, 0, 0), 3);
            }
        }

        private void Ingresar(float montoUsd)
        {
            var tx = tipoTransaccionServicio.obtenerTipoTransaccion((int)TipoTransaccionesDisponibles.Ingreso);
            var cotizacion = new Cotizacion(1);
            // TODO: optimizar, pq el monedero se lo paso solo pq necesita el id_usuario. 
            var ingreso = new Transaccion(monederos[0], tx, montoUsd, cotizacion);
            if (transaccionesServicio.ValidarIngreso(ingreso))
            {
                transaccionesServicio.Ingresar(ingreso);
                notificacion.ShowNotificacion("Ingreso de USD exitoso", Color.FromArgb(34, 139, 34), 1);
                //lblSaldo.Text = (Convert.ToDouble(lblSaldo.Text) + Convert.ToDouble(txtDolar.Text)).ToString();
            }
            else
            {
                notificacion.ShowNotificacion("Error en el ingreso de USD", Color.FromArgb(255, 0, 0), 3);
                txtDolar.Focus();
            }
        }
        #endregion

        #region NOTIFICACIONES
        
        #endregion
        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            if (btnActivo == btnComprar)
            {
                if (txtDolar.Text != null && txtDolar.Text.Length != 0 && (float)Convert.ToDouble(txtDolar.Text) > 0 && monederoSeleccionado != null)
                {
                    var usdIngresado = (float)Convert.ToDouble(txtDolar.Text);
                    var precio = cotizacionesServicio.obtenerCotizacionReciente(monederoSeleccionado.getCripto().Id).getPrecio();
                    txtCripto.Text = transaccionesServicio.CriptoEstimado(usdIngresado, precio).ToString();
                }
                else
                    txtCripto.Text = string.Empty;
            }
        }

        private void txtCripto_TextChanged(object sender, EventArgs e)
        {
            if (btnActivo == btnVender)
            {
                if (txtCripto.Text != null && txtCripto.Text.Length != 0 && (float)Convert.ToDouble(txtCripto.Text) > 0 && monederoSeleccionado != null)
                {
                    var criptoIngresado = (float)Convert.ToDouble(txtCripto.Text);
                    var precio = cotizacionesServicio.obtenerCotizacionReciente(monederoSeleccionado.getCripto().Id).getPrecio();
                    txtDolar.Text = transaccionesServicio.UsdEstimado(criptoIngresado, precio).ToString();
                }
                else
                    txtDolar.Text = string.Empty;
            }
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',') { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtCripto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',') { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
