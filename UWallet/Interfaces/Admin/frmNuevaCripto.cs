using System.Windows.Forms;
using System;
using System.Drawing;
using UWallet.Interfaces.Notificaciones;
using UWallet.Servicios;
using System.IO;
using System.Drawing.Imaging;
using UWallet.Entidades;
using System.Drawing.Text;

namespace UWallet.Interfaces.Admin
{
    public partial class frmNuevaCripto : Form
    {
        private readonly CriptomonedasServicio criptomonedasServicio;
        private Criptomoneda criptoVieja = null;
        public frmNuevaCripto()
        {
            InitializeComponent();
            this.criptomonedasServicio = new CriptomonedasServicio();
        }
        public frmNuevaCripto(Criptomoneda cripto)
        {
            InitializeComponent();
            criptomonedasServicio = new CriptomonedasServicio();
            this.lblTitulo.Text = "EDITAS CRIPTOMONEDA";
            this.btnConfirmar.Text = "Actualizar";
            criptoVieja = cripto;
            Editar(cripto);
        }

        #region Eventos
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (criptoVieja == null)
            {
                try { RegistrarCriptomoneda(); }
                catch (Exception ex) { new frmNotificacion("Ocurrio un error...Intente nuevamente mas tarde", Color.FromArgb(220, 220, 220), 1); }    
            }
            else 
            { 
                string nuevoNombre = txtNombreNuevo.Text.Trim();
                string nuevaAbreviacion = txtAbreviacion.Text.Trim();
                int nuevaCantidad = Convert.ToInt32(txtCantidad.Text);
                Image image = imgPerfil.Image;
                var cripto = new Criptomoneda(criptoVieja.Id,nuevoNombre,nuevaAbreviacion,nuevaCantidad,image);
                if(!(criptoVieja.EsIgual(cripto)||criptomonedasServicio.Exists(cripto)))
                {
                    criptomonedasServicio.Update(cripto);
                    new frmNotificacion("Criptomoneda actualizada", Color.FromArgb(50, 230, 0), 5);
                    this.Dispose();
                }
                else { new frmNotificacion("Los datos son iguales..", Color.FromArgb(220, 220, 220), 5); }
            }
            
        }
        #endregion

        #region Metodos de la Pantalla
        public void RegistrarCriptomoneda()
        {
            var imagen = imgPerfil.Image;
            var nombre = txtNombreNuevo.Text.Trim();
            var abreviacion = txtAbreviacion.Text.Trim();
            var monto = string.IsNullOrEmpty(txtCantidad.Text) ? 0 : Convert.ToInt32(txtCantidad.Text);
            var cripto = new Criptomoneda(nombre, abreviacion,monto,imagen);

            if (criptomonedasServicio.Validate(cripto))
            {
                if (criptomonedasServicio.Exists(cripto))
                {
                    new frmNotificacion("Esa criptomoneda ya existe", Color.FromArgb(220, 20, 60), 1);
                }
                else
                {
                    criptomonedasServicio.Register(cripto);
                    new frmNotificacion("Criptomoneda registrada con exito!", Color.FromArgb(34, 139, 34), 1);
                    this.Hide();
                }
            }
            else { new frmNotificacion("Datos Incompletos", Color.FromArgb(220, 220, 220), 1); }
        }

        #endregion

        #region Imagen
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imgLocation = ofd.FileName;
                    imgPerfil.Image = Image.FromFile(imgLocation);
                    imgPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la foto", "Error", MessageBoxButtons.OK);
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
        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void Editar(Criptomoneda cripto) 
        {
            this.txtNombreNuevo.Text = cripto.Nombre;
            this.txtAbreviacion.Text = cripto.Abreviacion;
            this.txtCantidad.Text = cripto.Cantidad.ToString();
            this.imgPerfil.Image = cripto.Image;
        }
        #endregion
    }
}
