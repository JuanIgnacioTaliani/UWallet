using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing;
using UWallet.Repositorio;
using UWallet.Interfaces.Notificaciones;
using UWallet.Servicios;
using UWallet.Entidades;
using System.Web.UI.Design.WebControls;

namespace UWallet.Interfaces.Admin
{
    public partial class frmNuevaCiudad : Form
    {
        private CiudadServicio ciudadServicio;
        private PaisesServicios paisesServicios;
        private Ciudad ciudadVieja = null;

        public frmNuevaCiudad()
        {
            InitializeComponent();
            ciudadServicio = new CiudadServicio();
            paisesServicios = new PaisesServicios();
            cargarComboBox();
        }

        public frmNuevaCiudad(Ciudad ciudad)
        {
            InitializeComponent();
            ciudadServicio = new CiudadServicio();
            paisesServicios = new PaisesServicios();
            this.lblTitulo.Text = "EDITAR CIUDAD";
            this.btnConfirmar.Text = "Actualizar";
            ciudadVieja = ciudad;
            Editar(ciudad);
        }

        #region Metodos de la Pantalla
        private void cargarComboBox()
        {
            var paises = paisesServicios.obtenerPaises();
            foreach (Pais p in paises) { cbPaises.Items.Add(p.getNombre()); }
        }
        private void RegistrarCiudad() 
        {
            var nombre_pais = cbPaises.SelectedItem.ToString();
            int id_pais = paisesServicios.obtenerPais(nombre_pais);
            var pais = new Pais(nombre_pais, id_pais);
            var ciudad = new Ciudad(txtNombreNuevo.Text, pais);

            if (ciudadServicio.Validate(ciudad)) 
            {
                if (ciudadServicio.Exists(ciudad)) 
                {
                    new frmNotificacion("Esa ciudad ya existe", Color.FromArgb(220, 20, 60), 1);
                }
                else 
                {
                    ciudadServicio.Register(ciudad);
                    new frmNotificacion("Criptomoneda registrada con exito!", Color.FromArgb(34, 139, 34), 1);
                    this.Hide();
                }
            }
            else { new frmNotificacion("Datos Incompletos", Color.FromArgb(220, 220, 220), 1); txtNombreNuevo.Focus(); }
        }
        private void Editar(Ciudad ciudad)
        {
            int id_pais = paisesServicios.obtenerPais(ciudad.getPais().getNombre());
            ciudad.getPais().setId(id_pais);
            cargarComboBox();

            for (int i = 0; i < cbPaises.Items.Count; i++)
            {
                string p = (string)cbPaises.Items[i];
                if (p == ciudad.getPais().getNombre())
                {
                    cbPaises.SelectedIndex = i;
                }
            }

            this.txtNombreNuevo.Text = ciudad.getNombre();
        }
        #endregion

        #region Manejo de la Pantalla
        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void imgClose_Click(object sender, EventArgs e) { this.Dispose(); }
        private void imgMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void imgMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region Eventos
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ciudadVieja == null)
            {
                try { RegistrarCiudad(); }
                catch (Exception ex) { new frmNotificacion("Ocurrio un error...Intente nuevamente mas tarde", Color.FromArgb(220, 220, 220), 1); }
            }
            else
            {   
                string nuevo_nombre_ciudad = txtNombreNuevo.Text.Trim();
                string nuevo_nombre_pais = cbPaises.SelectedItem.ToString();
                int id_pais = paisesServicios.obtenerPais(nuevo_nombre_pais);
                var pais = new Pais(nuevo_nombre_pais,id_pais);
                var ciudad = new Ciudad(nuevo_nombre_ciudad,ciudadVieja.getId(), pais);
                if (!(ciudadVieja.EsIgual(ciudad) || ciudadServicio.Exists(ciudad)))
                {
                    ciudadServicio.Update(ciudad);
                    new frmNotificacion("Ciudad actualizada", Color.FromArgb(50, 230, 0), 5);
                    this.Dispose();
                }
                else { new frmNotificacion("Los datos son iguales..", Color.FromArgb(220, 220, 220), 5); }    
            }
        }
        #endregion
    }
}
