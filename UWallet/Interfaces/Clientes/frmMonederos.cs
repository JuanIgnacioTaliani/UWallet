using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UWallet.Repositorio;
using UWallet.Entidades;
using UWallet.Interfaces.Notificaciones;
using System.Drawing;
using UWallet.Servicios;

namespace UWallet.Interfaces.Clientes
{
    public partial class frmMonederos : Form
    {
        #region INICIALIZADORES
        private readonly MonederoRepositorio monederoRepositorio;
        private readonly MonederosServicio monederosServicio;
        private readonly CriptomonedasServicio criptomonedasServicio;
        private Monedero newMonedero;
        private frmNotificacion notificacion;
        #endregion
        public frmMonederos()
        {
            criptomonedasServicio = new  CriptomonedasServicio();
            monederosServicio = new MonederosServicio();
            notificacion = new frmNotificacion();
            InitializeComponent();
        }

        private void frmMonederos_Load(object sender, EventArgs e)
        {
            CargarDgvMonederos();
        }

        #region CARGAR DATOS
        public void CargarDgvMonederos()
        {
            var monederos = monederosServicio.GetMonederos();
            EliminarNombres(monederos);

            foreach (Monedero mn in monederos)
            {
                dgvMonederos.Rows.Add(mn.getCripto().Id, mn.getCripto().Image, mn.getCripto().Nombre, mn.getCripto().Abreviacion, mn.getSaldo());
            }
        }
        public void EliminarNombres(List<Monedero> lista)
        {
            var listaCompleta = criptomonedasServicio.GetCriptomonedas();
            var cont = listaCompleta.Count;
            foreach (var fila in lista)
            {
                var nombre = fila.getCripto().Nombre;

                for (int i = 0; i < cont; i++)
                {
                    if (listaCompleta[i].Nombre == nombre) { listaCompleta.RemoveAt(i); break; }
                }
            }
            CargarComboBox(listaCompleta);
        }
        public void CargarComboBox(List<Criptomoneda> criptosNombres)
        {
            if (criptosNombres.Count > 0)
            {
                var criptoDefault = new Criptomoneda();
                criptoDefault.Nombre = "Seleccionar";
                criptosNombres.Add(criptoDefault);

                var conector = new BindingSource();
                conector.DataSource = criptosNombres;
                cbNombresCriptos.DataSource = conector;
                cbNombresCriptos.DisplayMember = "Nombre";
                cbNombresCriptos.ValueMember = "Id";
                cbNombresCriptos.SelectedItem = criptoDefault;
            }
            else
            {
                var listaVacia = new List<string>();
                listaVacia.Add("Sin monedas disponibles");
                cbNombresCriptos.DataSource = listaVacia;
                btnAgregar.Enabled = false;
                notificacion.ShowNotificacion("Lo sentimos, no hay criptomonedas disponibles!", Color.FromArgb(220, 20, 60), 5);
            }
        }
        #endregion

        #region AGREGAR MONEDERO
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Criptomoneda nuevaCripto = (Criptomoneda)cbNombresCriptos.SelectedItem;
            if (nuevaCripto.Nombre == "Seleccionar")
            {
                notificacion.ShowNotificacion("Debe seleccionar una criptomoneda", Color.FromArgb(220, 20, 60), 2);
                return;
            }
                if (!EsOperacionConfirmada())
                    return;
                AgregarMonedero(nuevaCripto);
                ActualizarDgvMonedero();
            }
            catch (ApplicationException)
            {
                notificacion.ShowNotificacion("ERROR!", Color.FromArgb(220, 20, 60), 3);
            }
            catch (Exception)
            {
                notificacion.ShowNotificacion("ERROR! Intente nuevamente", Color.FromArgb(220, 20, 60), 3);
            }
        }
        private void AgregarMonedero(Criptomoneda nuevaCripto)
        {
            var newMonedero = new Monedero(UsuariosServicio.UsuarioLogueado, nuevaCripto, 0);
            this.newMonedero = newMonedero;
            if (!monederosServicio.AgregarMonedero(newMonedero))
            {
                notificacion.ShowNotificacion("ERROR! No se pudo agregar el monedero", Color.FromArgb(220, 20, 60), 3);
                return;
            }
            notificacion.ShowNotificacion("Se agregó el monedero exitosamente!", Color.FromArgb(34, 139, 34), 4);
        }
        #endregion

        #region ELIMINAR MONEDERO
        private void btnEliminar_Click(object sender, EventArgs e)
         {
            if (!EsOperacionConfirmada())
                return;
            // VALIDAR QUE EL MONEDERO ESTE EN 0
            if (!ValidarEliminacion())
                return;
            EliminarMonedero();
            ActualizarDgvMonedero();
         }
        private bool ValidarEliminacion()
        {
            int saldo = Convert.ToInt32(dgvMonederos.CurrentRow.Cells["Saldo"].Value);
            if (saldo != 0)
            {
                notificacion.ShowNotificacion("Operación Cancelada", Color.FromArgb(220, 20, 60), 6);
                notificacion.ShowNotificacion("El monedero debe estar vacío", Color.FromArgb(200, 20, 60), 5);
                return false;
            }
            return true;
        }

        private void EliminarMonedero()
        {
            int idCripto = Convert.ToInt32(dgvMonederos.CurrentRow.Cells["IdCripto"].Value);
            int idUsuario = UsuariosServicio.UsuarioLogueado.getIdUsuario();
            if (!monederosServicio.EliminarMonedero(idCripto, idUsuario))
            {
                notificacion.ShowNotificacion("ERROR! No se pudo Eliminar el monedero", Color.FromArgb(220, 20, 60), 3);
                return;
            }
            notificacion.ShowNotificacion("Monedero Eliminado Exitosamente!", Color.FromArgb(34, 139, 34), 4);
        }
        #endregion

        #region OPERACIONES VARIAS
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }
        private void ActualizarDgvMonedero()
        {
            dgvMonederos.Rows.Clear();
            MessageBox.Show("Actualizando... Espere un momento");
            CargarDgvMonederos();
        }
        #endregion

    }
}
