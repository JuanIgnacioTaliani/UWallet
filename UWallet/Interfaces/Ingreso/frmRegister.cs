using System;
using System.Drawing;
using System.Windows.Forms;
using UWallet.Entidades;
using UWallet.Interfaces.Notificaciones;
using UWallet.Servicios;

namespace UWallet.Interfaces.Ingreso
{
    public partial class frmRegister : Form
    {
        private readonly UsuariosServicio usuariosServicio;

        public frmRegister()
        {
            InitializeComponent();
            usuariosServicio = new UsuariosServicio();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (VerificarCaracteres(txtUsuario.Text,40) || VerificarCaracteres(txtContrasenia1.Text, 20) || VerificarCaracteres(txtContrasenia2.Text, 20) || VerificarCaracteres(txtEmail.Text, 50))
            {
                new frmNotificacion("Cantidad de caracteres excedida", Color.FromArgb(255, 0, 0), 3);
                return;
            }

            var perfil = new Perfil(2);
            var usuario = new Usuario(txtUsuario.Text, txtContrasenia1.Text,txtEmail.Text,perfil);
            
            if (usuariosServicio.verificarDatos(usuario,txtContrasenia2.Text))
            {
                usuariosServicio.Register(usuario);
                new frmNotificacion("Usuario registrado", Color.FromArgb(50, 230, 0), 4);
                this.Close();
                Clientes.frmPrincipal ventana = new Clientes.frmPrincipal();
                ventana.Show();
            }
            else { new frmNotificacion("Por favor ingrese los datos necesarios",Color.FromArgb(220,220,220),2); }
        }

        public bool VerificarCaracteres(string cadena, int n)
        {
            return cadena.Length > n;
        }

        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { this.Close(); }

        private void imgMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

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

        private void imgClose_Click(object sender, EventArgs e) { this.Dispose(); }
    }
}
