using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWallet.Interfaces.Clientes
{
    public partial class btnCripto : UserControl
    {
        public btnCripto()
        {
            InitializeComponent();
        }
        private Image logo;
        private string nombre;
        private string abreviatura;
        private string saldo;
        private string id_cripto;
        private string id_usuario;
        private string cantidad;

        public Image Logo { get { return logo; } set { logo = value; imgCripto.Image = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; lblNombre.Text = value; } }
        public string Abreviatura { get { return abreviatura; } set { abreviatura = value; lblAbreviacion.Text = value; } }
        public string Saldo { get { return saldo; } set { saldo = value; value = lblSaldo.Text; } }
        public string Id_cripto { get { return id_cripto; } set { id_cripto = value; value = lblId_Cripto.Text; } }
        public string Id_usuario { get { return id_usuario; } set { id_usuario = value; value = lblId_Usuario.Text; } }
        public string Cantidad { get { return cantidad; } set { cantidad = value; value =lblCantidad.Text; } }
        

        private void btnCripto_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void btnCripto_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        public void Botones_Click(object sender, EventArgs e)
        {
        }
    }
}
