using System;
using System.Data;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Repositorio;
using UWallet.Servicios;

namespace UWallet.Interfaces.Admin
{
    public partial class frmPaises : Form
    {
        private readonly PaisesServicios paisesServicios;
        public frmPaises()
        {
            InitializeComponent();
            paisesServicios = new PaisesServicios();
            cargarPaises();
        }

        private void btnAddPais_Click(object sender, EventArgs e)
        {
            Form form = new frmNuevoPais();
            form.Show();
        }

        private void dvgPaises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgPaises.Columns[e.ColumnIndex].Name == "Edit")
            {
                int codigo = Convert.ToInt32(dvgPaises[0, dvgPaises.CurrentRow.Index].Value);
                string nombre = Convert.ToString(dvgPaises[1, dvgPaises.CurrentRow.Index].Value);
                var pais = new Pais(nombre, codigo);
                frmNuevoPais frm = new frmNuevoPais(pais);
                frm.Show();
            }

            if (dvgPaises.Columns[e.ColumnIndex].Name == "Delete")
            {
                int codigo = (int)dvgPaises[0, dvgPaises.CurrentRow.Index].Value;
                paisesServicios.Delete(codigo);
                cargarPaises();
            }
        }

        private void cargarPaises()
        {
            limpiarGrilla();
            var paises = paisesServicios.obtenerPaises();
            foreach (Pais p in paises) { dvgPaises.Rows.Add(p.getId(), p.getNombre()); }
        }

        private void limpiarGrilla() { dvgPaises.Rows.Clear(); }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarPaises();
        }

        private void txtSearch_IconRightClick(object sender, EventArgs e)
        {
            // EJECUTAR BUSQUEDA
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            {

                if (txtSearch.Text != "")
                {
                    dvgPaises.CurrentCell = null;
                    foreach (DataGridViewRow r in dvgPaises.Rows)
                    {
                        r.Visible = false;
                    }

                    foreach (DataGridViewRow r in dvgPaises.Rows)
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
                    dvgPaises.CurrentCell = null;
                    foreach (DataGridViewRow r in dvgPaises.Rows)
                    {
                        r.Visible = true;
                    }
                }

            }
        }
    }
}
