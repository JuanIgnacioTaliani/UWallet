using System;
using System.Drawing;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Interfaces;
using UWallet.Interfaces.Notificaciones;
using UWallet.Repositorio;
using UWallet.Servicios;

namespace UWallet.Interfaces.Ingreso
{
    public partial class frmLogin : Form
    {
        private readonly UsuariosServicio usuariosServicio;

        public frmLogin()
        {
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmRegister();
            form.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var nombre = txtUsuario.Text;
            var contrasenia = txtContrasenia.Text;

            if (ValidarCaracteres(nombre, 40) || ValidarCaracteres(contrasenia, 20))
            {
                new frmNotificacion("Cantidad de caracteres excedida", Color.FromArgb(255, 0, 0), 3);
                return;
            }

            if (ValidarCamposVacios(nombre, contrasenia)) return;

            var usuario = new Usuario(nombre, contrasenia);

            if (usuariosServicio.Login(usuario))
            {
                Validacion();
            }
            else
            {
                new frmNotificacion("Usuario y/o contraseña inválidas", Color.FromArgb(220, 20, 60), 1);
                txtUsuario.Focus();
            }
        }

        private bool ValidarCamposVacios(String nombre, String contrasenia)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                new frmNotificacion("Debe ingresar usuario.", Color.FromArgb(220, 20, 60), 1);
                txtUsuario.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(contrasenia))
            {
                new frmNotificacion("Debe ingresar la contraseña.", Color.FromArgb(220, 20, 60), 1);
                txtContrasenia.Focus();
                return true;
            }

            return false;
        }

        public bool ValidarCaracteres(string cadena, int n) 
        {
            return cadena.Length > n;
        }

        public void Validacion()
        {
            var perfil = UsuariosServicio.UsuarioLogueado.getPerfil().getIdPerfil();

            if (perfil == 1)
            {
                Admin.frmPrincipal ventana = new Admin.frmPrincipal();
                ventana.Show();
                new frmNotificacion("Logeo Exitoso", Color.FromArgb(34, 139, 34), 1);
                this.Hide();
            }
            if (perfil == 2)
            {
                Clientes.frmPrincipal ventana = new Clientes.frmPrincipal();
                ventana.Show();
                new frmNotificacion("Logeo Exitoso", Color.FromArgb(34, 139, 34), 1);
                this.Hide();
            }
        }

        private void txtContrasenia_IconRightClick(object sender, EventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar == true)
            {
                txtContrasenia.UseSystemPasswordChar = false;
                txtContrasenia.PasswordChar = '\0';
                txtContrasenia.IconRight = Properties.Resources.no_visible;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                txtContrasenia.PasswordChar = '●';
                txtContrasenia.IconRight = Properties.Resources.visible;
            }

        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
