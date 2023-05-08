using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    public partial class frmAjustes : Form
    {
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    imgPerfil.ImageLocation = imageLocation;
                    imgPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                }
            } catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la foto","Error", MessageBoxButtons.OK);
            }
        }
    }
}
