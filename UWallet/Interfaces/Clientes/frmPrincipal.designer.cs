namespace UWallet.Interfaces.Clientes
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAjustes = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnEstadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonederos = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransacciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnCotizaciones = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnAjustes);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnEstadisticas);
            this.panelMenu.Controls.Add(this.btnMonederos);
            this.panelMenu.Controls.Add(this.btnTransacciones);
            this.panelMenu.Controls.Add(this.btnCotizaciones);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 600);
            this.panelMenu.TabIndex = 4;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAjustes.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAjustes.CheckedState.Image = global::UWallet.Properties.Resources.settings_azul;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAjustes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjustes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjustes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjustes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjustes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjustes.FillColor = System.Drawing.Color.Empty;
            this.btnAjustes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAjustes.Image = ((System.Drawing.Image)(resources.GetObject("btnAjustes.Image")));
            this.btnAjustes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjustes.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAjustes.Location = new System.Drawing.Point(0, 410);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAjustes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAjustes.Size = new System.Drawing.Size(200, 60);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjustes.UseTransparentBackground = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Image = global::UWallet.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(32, 32);
            this.btnLogout.Location = new System.Drawing.Point(0, 540);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Size = new System.Drawing.Size(200, 60);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnEstadisticas.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnEstadisticas.CheckedState.Image = global::UWallet.Properties.Resources.graph_azul;
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEstadisticas.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEstadisticas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstadisticas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FillColor = System.Drawing.Color.Empty;
            this.btnEstadisticas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEstadisticas.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 350);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstadisticas.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnEstadisticas.Size = new System.Drawing.Size(200, 60);
            this.btnEstadisticas.TabIndex = 5;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEstadisticas.UseTransparentBackground = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnMonederos
            // 
            this.btnMonederos.BackColor = System.Drawing.Color.Transparent;
            this.btnMonederos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMonederos.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMonederos.CheckedState.Image = global::UWallet.Properties.Resources.wallet_azul;
            this.btnMonederos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonederos.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnMonederos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonederos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonederos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonederos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonederos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonederos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonederos.FillColor = System.Drawing.Color.Empty;
            this.btnMonederos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMonederos.ForeColor = System.Drawing.Color.White;
            this.btnMonederos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMonederos.Image = global::UWallet.Properties.Resources.wallet_blanca;
            this.btnMonederos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonederos.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMonederos.Location = new System.Drawing.Point(0, 290);
            this.btnMonederos.Name = "btnMonederos";
            this.btnMonederos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMonederos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMonederos.Size = new System.Drawing.Size(200, 60);
            this.btnMonederos.TabIndex = 3;
            this.btnMonederos.Text = "Monederos";
            this.btnMonederos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMonederos.UseTransparentBackground = true;
            this.btnMonederos.Click += new System.EventHandler(this.btnMonederos_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.BackColor = System.Drawing.Color.Transparent;
            this.btnTransacciones.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnTransacciones.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnTransacciones.CheckedState.Image = global::UWallet.Properties.Resources.transaction_azul;
            this.btnTransacciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransacciones.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnTransacciones.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransacciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransacciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransacciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransacciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransacciones.FillColor = System.Drawing.Color.Empty;
            this.btnTransacciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTransacciones.ForeColor = System.Drawing.Color.White;
            this.btnTransacciones.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnTransacciones.Image = ((System.Drawing.Image)(resources.GetObject("btnTransacciones.Image")));
            this.btnTransacciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransacciones.ImageSize = new System.Drawing.Size(32, 32);
            this.btnTransacciones.Location = new System.Drawing.Point(0, 230);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransacciones.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnTransacciones.Size = new System.Drawing.Size(200, 60);
            this.btnTransacciones.TabIndex = 2;
            this.btnTransacciones.Text = "Transacciones";
            this.btnTransacciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransacciones.UseTransparentBackground = true;
            this.btnTransacciones.Click += new System.EventHandler(this.btnTransacciones_Click);
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnCotizaciones.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCotizaciones.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCotizaciones.CheckedState.Image = global::UWallet.Properties.Resources.dashboard_azul;
            this.btnCotizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizaciones.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnCotizaciones.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCotizaciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCotizaciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCotizaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCotizaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCotizaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCotizaciones.FillColor = System.Drawing.Color.Empty;
            this.btnCotizaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizaciones.ForeColor = System.Drawing.Color.White;
            this.btnCotizaciones.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCotizaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizaciones.Image")));
            this.btnCotizaciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCotizaciones.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCotizaciones.Location = new System.Drawing.Point(0, 170);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCotizaciones.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCotizaciones.Size = new System.Drawing.Size(200, 60);
            this.btnCotizaciones.TabIndex = 1;
            this.btnCotizaciones.Text = "Cotizaciones";
            this.btnCotizaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCotizaciones.UseTransparentBackground = true;
            this.btnCotizaciones.Click += new System.EventHandler(this.btnCotizaciones_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.imgLogo);
            this.panelLogo.Controls.Add(this.lblNombre);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 19);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 82);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.lblNombre.Location = new System.Drawing.Point(0, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(200, 32);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "U Wallet";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPrincipal.BackgroundImage = global::UWallet.Properties.Resources.logo_negro;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPrincipal.Controls.Add(this.labelDescripcion);
            this.panelPrincipal.Controls.Add(this.lblBienvenida);
            this.panelPrincipal.Location = new System.Drawing.Point(200, 60);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(699, 539);
            this.panelPrincipal.TabIndex = 9;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(0, 173);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(697, 30);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Comienza tu experiencia en U Wallet presionando alguna de las opciones del menú";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(0, 103);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(3, 100, 3, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(697, 40);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a U Wallet";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.imgClose);
            this.panelBarra.Controls.Add(this.imgMaximize);
            this.panelBarra.Controls.Add(this.imgMinimize);
            this.panelBarra.Controls.Add(this.lblTitulo);
            this.panelBarra.Controls.Add(this.imgBack);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(200, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(700, 60);
            this.panelBarra.TabIndex = 8;
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
            this.imgClose.Location = new System.Drawing.Point(661, 15);
            this.imgClose.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgClose.Name = "imgClose";
            this.imgClose.PressedState.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Size = new System.Drawing.Size(30, 30);
            this.imgClose.TabIndex = 15;
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
            this.imgMaximize.Location = new System.Drawing.Point(631, 15);
            this.imgMaximize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMaximize.Name = "imgMaximize";
            this.imgMaximize.PressedState.Image = global::UWallet.Properties.Resources.macos_fullscreen_gris;
            this.imgMaximize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Size = new System.Drawing.Size(30, 30);
            this.imgMaximize.TabIndex = 14;
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
            this.imgMinimize.Location = new System.Drawing.Point(601, 15);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.PressedState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Size = new System.Drawing.Size(30, 30);
            this.imgMinimize.TabIndex = 13;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(52, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 54);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgBack
            // 
            this.imgBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBack.HoverState.Image = global::UWallet.Properties.Resources.back_hover;
            this.imgBack.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.imgBack.Image = global::UWallet.Properties.Resources.back4;
            this.imgBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgBack.ImageRotate = 0F;
            this.imgBack.ImageSize = new System.Drawing.Size(40, 40);
            this.imgBack.Location = new System.Drawing.Point(6, 10);
            this.imgBack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.imgBack.Name = "imgBack";
            this.imgBack.PressedState.Image = global::UWallet.Properties.Resources.back_hover;
            this.imgBack.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.imgBack.Size = new System.Drawing.Size(40, 40);
            this.imgBack.TabIndex = 12;
            // 
            // resizeForm
            // 
            this.resizeForm.TargetForm = this;
            // 
            // dcForm
            // 
            this.dcForm.DockIndicatorTransparencyValue = 0.6D;
            this.dcForm.TargetControl = this.panelBarra;
            this.dcForm.UseTransparentDrag = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel panelBarra;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2ImageButton imgBack;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnEstadisticas;
        private Guna.UI2.WinForms.Guna2Button btnMonederos;
        private Guna.UI2.WinForms.Guna2Button btnTransacciones;
        private Guna.UI2.WinForms.Guna2Button btnCotizaciones;
        private Guna.UI2.WinForms.Guna2Button btnAjustes;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
    }
}