using System;
using System.Drawing;
using System.Windows.Forms;
using UWallet.Servicios;
using UWallet.Entidades;
using System.IO;

namespace UWallet.Interfaces.Admin
{
    public partial class frmCriptomonedas : Form
    {
        private readonly CriptomonedasServicio criptomonedasServicio;
        public frmCriptomonedas()
        {
            InitializeComponent();
            criptomonedasServicio = new CriptomonedasServicio();
            cargarCriptos();
        }

        #region Eventos
        private void btnAddCripto_Click(object sender, EventArgs e) { frmNuevaCripto frm = new frmNuevaCripto(); frm.Show(); }
        private void txtSearch_TextChanged(object sender, EventArgs e) { buscar(); }
        private void btnActualizar_Click(object sender, EventArgs e) { cargarCriptos(); }
        private void dvgCriptomonedas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgCriptomonedas.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = Convert.ToInt32(dvgCriptomonedas[0, dvgCriptomonedas.CurrentRow.Index].Value);
                Image logo = (Image) dvgCriptomonedas[1, dvgCriptomonedas.CurrentRow.Index].Value;
                string nombre = Convert.ToString(dvgCriptomonedas[2, dvgCriptomonedas.CurrentRow.Index].Value);
                string abreviacion = Convert.ToString(dvgCriptomonedas[3, dvgCriptomonedas.CurrentRow.Index].Value);
                int cantidad = Convert.ToInt32(dvgCriptomonedas[4, dvgCriptomonedas.CurrentRow.Index].Value);
                var cripto = new Criptomoneda(id,nombre,abreviacion,cantidad,logo);
                frmNuevaCripto frm = new frmNuevaCripto(cripto);
                frm.Show();
            }

            if (dvgCriptomonedas.Columns[e.ColumnIndex].Name == "Delete")
            {
                int codigo = (int)dvgCriptomonedas[0, dvgCriptomonedas.CurrentRow.Index].Value;
                criptomonedasServicio.Delete(codigo);
                cargarCriptos();
            }
        }
        #endregion

        #region Metodos de la Pantalla
        private void limpiarGrilla() { dvgCriptomonedas.Rows.Clear(); }
        private void cargarCriptos()
        {
            limpiarGrilla();
            var criptomonedas = criptomonedasServicio.GetCriptomonedas();
            foreach (Criptomoneda c in criptomonedas) { dvgCriptomonedas.Rows.Add(c.Id, c.Image, c.Nombre, c.Abreviacion, c.Cantidad); }
        }
        private void buscar() 
        {
            {
                if (txtSearch.Text != "")
                {
                    dvgCriptomonedas.CurrentCell = null;
                    foreach (DataGridViewRow r in dvgCriptomonedas.Rows)
                    {
                        r.Visible = false;
                    }

                    foreach (DataGridViewRow r in dvgCriptomonedas.Rows)
                    {
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value.ToString().ToUpper()).IndexOf(txtSearch.Text.ToUpper()) == 0)
                            {
                                r.Visible = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    dvgCriptomonedas.CurrentCell = null;
                    foreach (DataGridViewRow r in dvgCriptomonedas.Rows)
                    {
                        r.Visible = true;
                    }
                }
            }
        }
        #endregion

        #region Manejo de la Pantalla 
        private void imgMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void imgMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            this.WindowState = FormWindowState.Normal;
        }

        private void imgClose_Click(object sender, EventArgs e) { this.Dispose(); }
        #endregion 
    }
}
