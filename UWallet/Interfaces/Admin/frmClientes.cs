using UWallet.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UWallet.Interfaces.Notificaciones;

namespace UWallet.Interfaces.Admin
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgClientes.Columns[e.ColumnIndex].Name == "Edit")
            {
                //Cuerpo de editar
                new frmNotificacion("Editado con éxito", Color.FromArgb(34, 139, 34), 1);
            }
            else if (dvgClientes.Columns[e.ColumnIndex].Name == "Delete")
            {
                //Cuerpo de borrar
                dvgClientes.Rows.Clear();
            }
        }

        private void cargarClientes()
        {
            var sql = $"SELECT c.apellido ,c.nombre,c.telefono,cd.nombre,u.nombre FROM Clientes c JOIN Ciudades cd ON c.id_ciudad = cd.id_ciudad JOIN usuarios u ON c.id_usuario = u.id_usuario";
            var todosLosClientes = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in todosLosClientes.Rows) { dvgClientes.Rows.Add(fila["apellido"], fila["nombre"], fila["email"], fila["telefono"], fila["nombre"], fila["nombre"]); }
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
                    dvgClientes.CurrentCell = null;
                    foreach (DataGridViewRow r in dvgClientes.Rows)
                    {
                        r.Visible = false;
                    }

                    foreach (DataGridViewRow r in dvgClientes.Rows)
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
                    dvgClientes.CurrentCell = null;
                    foreach (DataGridViewRow r in dvgClientes.Rows)
                    {
                        r.Visible = true;
                    }
                }

            }
        }
    }
}
