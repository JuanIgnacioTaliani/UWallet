using System;
using System.Data;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Repositorio;
using UWallet.Servicios;

namespace UWallet.Interfaces.Admin
{
    public partial class frmCiudades : Form
    {
        private readonly CiudadServicio ciudadServicios;
        public frmCiudades()
        {
            InitializeComponent();
            ciudadServicios = new CiudadServicio();
            cargarCiudades();
        }
        private void btnAddCiudad_Click(object sender, EventArgs e)
        {
            Form frm = new frmNuevaCiudad();
            frm.Show();
        }

        #region Metodos de la Pantalla
        private void limpiarGrilla() { dvgCiudades.Rows.Clear(); }
        private void cargarCiudades()
        {
            limpiarGrilla();
            var ciudades = ciudadServicios.obtenerCiudades();
            foreach (Ciudad c in ciudades) { dvgCiudades.Rows.Add(c.getId(), c.getNombre(), c.getPais().getNombre()); }
        }
        private void buscar()
        {
            if (txtSearch.Text != "")
            {
                dvgCiudades.CurrentCell = null;
                foreach (DataGridViewRow r in dvgCiudades.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dvgCiudades.Rows)
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
                dvgCiudades.CurrentCell = null;
                foreach (DataGridViewRow r in dvgCiudades.Rows)
                {
                    r.Visible = true;
                }
            }
        }
        #endregion

        #region Eventos
        private void txtSearch_TextChanged(object sender, EventArgs e) { buscar(); }
        private void btnActualizar_Click(object sender, EventArgs e) { cargarCiudades(); }
        private void dvgCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgCiudades.Columns[e.ColumnIndex].Name == "Edit")
            {   
                int id = Convert.ToInt32(dvgCiudades[0, dvgCiudades.CurrentRow.Index].Value);
                string nombre = Convert.ToString(dvgCiudades[1, dvgCiudades.CurrentRow.Index].Value);
                string nombre_pais = Convert.ToString(dvgCiudades[2, dvgCiudades.CurrentRow.Index].Value);
                var pais = new Pais(nombre_pais);
                var ciudad = new Ciudad(nombre,id,pais);
                frmNuevaCiudad frm = new frmNuevaCiudad(ciudad);
                frm.Show();
            }

            if (dvgCiudades.Columns[e.ColumnIndex].Name == "Delete")
            {
                int codigo = (int)dvgCiudades[0, dvgCiudades.CurrentRow.Index].Value;
                ciudadServicios.Delete(codigo);
                cargarCiudades();
            }
        }
        #endregion

        #region Manejo de la Pantalla
        private void imgMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            this.WindowState = FormWindowState.Normal;
        }
        private void imgMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void imgClose_Click(object sender, EventArgs e) { this.Dispose(); }


        #endregion
    }
}
