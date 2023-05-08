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
    public partial class Copia : Form
    {
        private ReportesRepositorio reportesRepositorio;
        public Copia()
        {
            reportesRepositorio = new ReportesRepositorio();
            InitializeComponent();
            
        }
      private void Copia_Load(object sender, EventArgs e)
        {
            cargarGrafico();
            
        }
        private void cargarGrafico()
        {
 

            //chartCriptos.DataSource = db.ConsultaSQL("SELECT count(id_transaccion) AS 'Cantidad', abreviacion_cripto AS 'Abreviacion' FROM Transacciones t JOIN Criptomonedas c ON t.id_cripto = c.id_cripto GROUP BY abreviacion_cripto");
            //chartCriptos.Series["Criptos"].XValueMember = "Abreviacion";
            //chartCriptos.Series["Criptos"].YValueMembers = "Cantidad";

            //chartClientes.DataSource = db.ConsultaSQL("SELECT count(nro_cliente) AS 'Cantidad', p.nombre AS 'Pais' FROM Clientes c JOIN Ciudades t ON c.id_ciudad = t.id_ciudad JOIN Paises p ON t.cod_pais = p.id_pais GROUP BY p.nombre");
            //chartClientes.Series["Clientes"].XValueMember = "Pais";
            //chartClientes.Series["Clientes"].YValueMembers = "Cantidad";


        }

  
    }
}
