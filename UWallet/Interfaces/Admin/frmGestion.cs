using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCriptos_Click(object sender, EventArgs e)
        {
            Form form = new Admin.frmCriptomonedas();
            form.Show();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            Form form = new Admin.frmTransacciones();
            form.Show();
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            Form form = new Admin.frmCiudades();
            form.Show();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            Form form = new Admin.frmPaises();
            form.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form form = new Admin.frmClientes();
            form.Show();
        }
    }
}
