using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using UWallet.Interfaces.Ingreso;
using UWallet.Interfaces.Reportes;

namespace UWallet.Interfaces.Admin
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.Inicio());
            ActivateFocus(this.btnInicio);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGestion(), sender);
            ActivateFocus(this.btnGestion);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportes(), sender);
            ActivateFocus(this.btnReportes);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmAjustes(), sender);
            //ActivateFocus(this.btnAjustes);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmLogin();
            form.Show();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
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