using UWallet.Repositorio;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System;
using UWallet.Servicios;
using UWallet.Entidades;

namespace UWallet.Interfaces.Clientes
{
    public partial class frmCotizaciones : Form
    {
        private readonly CotizacionesServicio cotizacionesServicio;

        public frmCotizaciones()
        {
            cotizacionesServicio = new CotizacionesServicio();
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            CargarDgvCotizaciones();
        }

        public void CargarDgvCotizaciones()
        {
            var cotizaciones = cotizacionesServicio.GetCotizaciones();
            foreach (Cotizacion fila in cotizaciones)
            {
                dgvCotizaciones.Rows.Add(fila.getCripto().Image, fila.getCripto().Nombre, fila.getCripto().Abreviacion, fila.getPrecio(), fila.getFechaHoraCotizacion());
            }
        }
    }
}