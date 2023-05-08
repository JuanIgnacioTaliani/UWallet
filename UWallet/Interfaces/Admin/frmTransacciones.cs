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
    public partial class frmTransacciones : Form
    {
        public frmTransacciones()
        {
            InitializeComponent();
        }

        private void dvgTransacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgTransacciones.Columns[e.ColumnIndex].Name == "Edit")
            {
                //Cuerpo de editar
                MessageBox.Show("Editado con exito");
            }
            else if (dvgTransacciones.Columns[e.ColumnIndex].Name == "Delete")
            {
                //Cuerpo de borrar
                dvgTransacciones.Rows.Clear();
            }
        }

        private void imgMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
