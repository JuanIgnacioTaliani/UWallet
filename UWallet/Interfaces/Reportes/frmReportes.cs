using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UWallet.Repositorio;

namespace UWallet.Interfaces.Reportes
{
    public partial class frmReportes : Form
    {
        private ReportesRepositorio reportesRepositorio;
        public frmReportes()
        {
            reportesRepositorio = new ReportesRepositorio();
            InitializeComponent();
            
        }
      private void frmReportes_Load(object sender, EventArgs e)
        {
            cargarGrafico();
            
        }
        private void cargarGrafico()
        {
            var datosClientes = reportesRepositorio.ObtenerClientesPorPais();
            var datosCriptos = reportesRepositorio.ObtenerCriptosMasTransaccionadas();
            var datosComisiones = reportesRepositorio.ObtenerComisiones(); 

            this.rwAdmin.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DTClienteXPais", datosClientes);
            var ds1 = new ReportDataSource("DTCriptomonedasMasTransaccionadas", datosCriptos);
            var ds2 = new ReportDataSource("DTComisiones", datosComisiones);

            this.rwAdmin.LocalReport.DataSources.Add(ds);
            this.rwAdmin.LocalReport.DataSources.Add(ds1);
            this.rwAdmin.LocalReport.DataSources.Add(ds2);

            var hoy = DateTime.Now;
            var parametros = new List<ReportParameter>() {
                new ReportParameter("ParamFechaHoy", hoy.ToString("dd/MM/yyyy hh:mm")),
                new ReportParameter("ParamMes", hoy.ToString("MMMM"))
            };
            this.rwAdmin.LocalReport.SetParameters(parametros);

            this.rwAdmin.RefreshReport();
        }

  
    }
}
