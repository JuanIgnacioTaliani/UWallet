using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    partial class frmTransacciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransacciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.elipseDvg = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dvgTransacciones = new System.Windows.Forms.DataGridView();
            this.panelContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IdTransac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTransac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTransacciones)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dcForm
            // 
            this.dcForm.DockIndicatorTransparencyValue = 0.6D;
            this.dcForm.UseTransparentDrag = true;
            // 
            // resizeForm
            // 
            this.resizeForm.TargetForm = this;
            // 
            // elipseDvg
            // 
            this.elipseDvg.BorderRadius = 15;
            this.elipseDvg.TargetControl = this.dvgTransacciones;
            // 
            // dvgTransacciones
            // 
            this.dvgTransacciones.AllowUserToAddRows = false;
            this.dvgTransacciones.AllowUserToDeleteRows = false;
            this.dvgTransacciones.AllowUserToResizeColumns = false;
            this.dvgTransacciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dvgTransacciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgTransacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTransacciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.dvgTransacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgTransacciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgTransacciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgTransacciones.ColumnHeadersHeight = 50;
            this.dvgTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransac,
            this.IdUsuario,
            this.Fecha,
            this.Hora,
            this.TipoTransac,
            this.Monto,
            this.IdCripto,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgTransacciones.DefaultCellStyle = dataGridViewCellStyle9;
            this.dvgTransacciones.EnableHeadersVisualStyles = false;
            this.dvgTransacciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.dvgTransacciones.Location = new System.Drawing.Point(10, 55);
            this.dvgTransacciones.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.dvgTransacciones.MultiSelect = false;
            this.dvgTransacciones.Name = "dvgTransacciones";
            this.dvgTransacciones.ReadOnly = true;
            this.dvgTransacciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgTransacciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgTransacciones.RowHeadersVisible = false;
            this.dvgTransacciones.RowHeadersWidth = 20;
            this.dvgTransacciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dvgTransacciones.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dvgTransacciones.RowTemplate.Height = 25;
            this.dvgTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTransacciones.ShowEditingIcon = false;
            this.dvgTransacciones.Size = new System.Drawing.Size(856, 310);
            this.dvgTransacciones.TabIndex = 0;
            this.dvgTransacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTransacciones_CellClick);
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.BorderRadius = 15;
            this.panelContenido.Controls.Add(this.txtSearch);
            this.panelContenido.Controls.Add(this.dvgTransacciones);
            this.panelContenido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panelContenido.Location = new System.Drawing.Point(12, 63);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(876, 375);
            this.panelContenido.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::UWallet.Properties.Resources.search;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(516, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.txtSearch.MaximumSize = new System.Drawing.Size(400, 35);
            this.txtSearch.MinimumSize = new System.Drawing.Size(350, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Buscar ID";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(350, 35);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelBarra.Controls.Add(this.imgClose);
            this.panelBarra.Controls.Add(this.imgMaximize);
            this.panelBarra.Controls.Add(this.imgMinimize);
            this.panelBarra.Controls.Add(this.lblTitulo);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(900, 60);
            this.panelBarra.TabIndex = 10;
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.HoverState.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgClose.ImageRotate = 0F;
            this.imgClose.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Location = new System.Drawing.Point(861, 15);
            this.imgClose.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgClose.Name = "imgClose";
            this.imgClose.PressedState.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Size = new System.Drawing.Size(30, 30);
            this.imgClose.TabIndex = 13;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // imgMaximize
            // 
            this.imgMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMaximize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMaximize.HoverState.Image = global::UWallet.Properties.Resources.macos_fullscreen_gris;
            this.imgMaximize.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Image = global::UWallet.Properties.Resources.macos_fullscreen;
            this.imgMaximize.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgMaximize.ImageRotate = 0F;
            this.imgMaximize.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Location = new System.Drawing.Point(831, 15);
            this.imgMaximize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMaximize.Name = "imgMaximize";
            this.imgMaximize.PressedState.Image = global::UWallet.Properties.Resources.macos_fullscreen_gris;
            this.imgMaximize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Size = new System.Drawing.Size(30, 30);
            this.imgMaximize.TabIndex = 12;
            this.imgMaximize.Click += new System.EventHandler(this.imgMaximize_Click);
            // 
            // imgMinimize
            // 
            this.imgMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinimize.HoverState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Image = global::UWallet.Properties.Resources.macos_minimize;
            this.imgMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgMinimize.ImageRotate = 0F;
            this.imgMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Location = new System.Drawing.Point(801, 15);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.PressedState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Size = new System.Drawing.Size(30, 30);
            this.imgMinimize.TabIndex = 11;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TRANSACCIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTransac
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IdTransac.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdTransac.FillWeight = 50F;
            this.IdTransac.HeaderText = "ID Transacción";
            this.IdTransac.Name = "IdTransac";
            this.IdTransac.ReadOnly = true;
            this.IdTransac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdUsuario
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IdUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.IdUsuario.FillWeight = 50F;
            this.IdUsuario.HeaderText = "ID Usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fecha
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha.FillWeight = 70F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Hora
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Hora.DefaultCellStyle = dataGridViewCellStyle6;
            this.Hora.FillWeight = 70F;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TipoTransac
            // 
            this.TipoTransac.HeaderText = "Tipo de Transacción";
            this.TipoTransac.Name = "TipoTransac";
            this.TipoTransac.ReadOnly = true;
            this.TipoTransac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Monto
            // 
            this.Monto.FillWeight = 70F;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdCripto
            // 
            this.IdCripto.FillWeight = 50F;
            this.IdCripto.HeaderText = "ID Criptomoneda";
            this.IdCripto.Name = "IdCripto";
            this.IdCripto.ReadOnly = true;
            this.IdCripto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle7;
            this.Edit.FillWeight = 20F;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::UWallet.Properties.Resources.edit1;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 30;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 30;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle8;
            this.Delete.FillWeight = 20F;
            this.Delete.HeaderText = "";
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 30;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 30;
            // 
            // frmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmTransacciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dvgTransacciones)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
        private Guna.UI2.WinForms.Guna2Elipse elipseDvg;
        private Guna.UI2.WinForms.Guna2Panel panelContenido;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DataGridView dvgTransacciones;
        private Panel panelBarra;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn IdTransac;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn TipoTransac;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn IdCripto;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}