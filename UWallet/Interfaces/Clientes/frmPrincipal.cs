using UWallet.Repositorio;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System;
using Guna.UI2.WinForms;
using UWallet.Interfaces.Ingreso;
using UWallet.Servicios;

namespace UWallet.Interfaces.Clientes
{
    
    public partial class frmPrincipal : Form
    {
        private Form activeForm;
        private Guna2Button btnActive;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            panelPrincipal.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(childForm);
            this.panelPrincipal.Tag = childForm;
            this.lblTitulo.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateFocus(Guna2Button btnFocus)
        {
            btnFocus.Checked = true;
            btnFocus.Cursor = DefaultCursor;
            if (btnActive != btnFocus && btnActive != null)
            {
                btnActive.Checked = false;
                btnActive.Cursor = Cursors.Hand;
            }
            btnActive = btnFocus;
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCotizaciones(), sender);
            ActivateFocus(this.btnCotizaciones);
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTransacciones(), sender);
            ActivateFocus(this.btnTransacciones);
        }

        private void btnMonederos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMonederos(), sender);
            ActivateFocus(this.btnMonederos);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEstadisticas(), sender);
            ActivateFocus(this.btnEstadisticas);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmAjustes(), sender);
            ActivateFocus(this.btnAjustes);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UsuariosServicio.UsuarioLogueado = null;
            this.Dispose(); 
            Form form = new frmLogin();
            form.Show();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

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
            Application.Exit();
        }
    }
}
