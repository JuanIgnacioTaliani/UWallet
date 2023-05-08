using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Interfaces.Notificaciones;
using UWallet.Repositorio;
using UWallet.Servicios;

namespace UWallet.Interfaces.Admin
{
    public partial class frmNuevoPais : Form
    {
        private readonly PaisesServicios paisesServicios;
        private Pais paisViejo = null;
        public frmNuevoPais()
        {
            InitializeComponent();
            paisesServicios = new PaisesServicios();
        }

        public frmNuevoPais(Pais pais)
        {
            InitializeComponent();
            paisesServicios = new PaisesServicios();
            this.lblTitulo.Text = "EDITAR PAIS";
            this.btnConfirmar.Text = "Actualizar";
            paisViejo = pais;
            Editar(pais);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (paisViejo == null)
            {
                try { Register(); }
                catch (Exception ex) { new frmNotificacion("Ocurrio un error...Intente nuevamente mas tarde", Color.FromArgb(220, 220, 220), 1); }
            }
            else
            {
                string nuevoNombre = txtNombreNuevo.Text.Trim();
                var pais = new Pais(nuevoNombre,paisViejo.getId());
                if (!(paisViejo.IgualNombre(pais) || paisesServicios.Exist(pais))) 
                {
                    paisesServicios.Update(pais);
                    new frmNotificacion("Pais actualizado", Color.FromArgb(50, 230, 0), 5);
                    this.Dispose();
                }
                else { new frmNotificacion("Los datos son iguales..", Color.FromArgb(220, 220, 220), 5); }
            }
        }

        #region Manejo de la Pantalla
        private void imgClose_Click(object sender, EventArgs e) { this.Dispose(); }
        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void imgMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void imgMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region Metodos de la Pantalla
        private void Register() 
        {
            var nombre = txtNombreNuevo.Text.Trim();
            var pais = new Pais(nombre);
            if (paisesServicios.Validate(pais)) 
            {
                if (paisesServicios.Exist(pais))
                {
                    new frmNotificacion("Ese pais ya existe!", Color.FromArgb(220, 20, 60), 1);
                    txtNombreNuevo.Clear();
                    lblNombre.Focus();
                }
                else
                {
                    paisesServicios.Register(pais);
                    new frmNotificacion("Pais registrado con exito!", Color.FromArgb(50, 230, 0), 4);
                    this.Hide();
                }
            }
            else { new frmNotificacion("Datos Incompletos!", Color.FromArgb(220, 220, 220), 1); lblNombre.Focus(); return; }
        }

        private void Editar(Pais pais) 
        {
            this.txtNombreNuevo.Text = pais.getNombre();
        }
        #endregion
    }
}
