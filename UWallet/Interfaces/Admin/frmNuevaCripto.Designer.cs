using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    partial class frmNuevaCripto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaCripto));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnSubirFoto = new Guna.UI2.WinForms.Guna2Button();
            this.imgPerfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAbreviacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreNuevo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblAbreviacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelLogo.Controls.Add(this.lblEmpresa);
            this.panelLogo.Controls.Add(this.imgLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(267, 554);
            this.panelLogo.TabIndex = 27;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpresa.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.lblEmpresa.Location = new System.Drawing.Point(0, 295);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(267, 74);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "U Wallet";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgLogo.Image = global::UWallet.Properties.Resources.logo1;
            this.imgLogo.Location = new System.Drawing.Point(0, 123);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 42, 3, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(267, 169);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelBarra.Controls.Add(this.imgClose);
            this.panelBarra.Controls.Add(this.imgMaximize);
            this.panelBarra.Controls.Add(this.imgMinimize);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(267, 0);
            this.panelBarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(533, 37);
            this.panelBarra.TabIndex = 28;
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
            this.imgClose.Location = new System.Drawing.Point(493, 0);
            this.imgClose.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.imgClose.Name = "imgClose";
            this.imgClose.PressedState.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Size = new System.Drawing.Size(40, 37);
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
            this.imgMaximize.Location = new System.Drawing.Point(453, 0);
            this.imgMaximize.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.imgMaximize.Name = "imgMaximize";
            this.imgMaximize.PressedState.Image = global::UWallet.Properties.Resources.macos_fullscreen_gris;
            this.imgMaximize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Size = new System.Drawing.Size(40, 37);
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
            this.imgMinimize.Location = new System.Drawing.Point(413, 0);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.PressedState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Size = new System.Drawing.Size(40, 37);
            this.imgMinimize.TabIndex = 11;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnSubirFoto);
            this.panelContenido.Controls.Add(this.imgPerfil);
            this.panelContenido.Controls.Add(this.txtCantidad);
            this.panelContenido.Controls.Add(this.txtAbreviacion);
            this.panelContenido.Controls.Add(this.txtNombreNuevo);
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnConfirmar);
            this.panelContenido.Controls.Add(this.lblTitulo);
            this.panelContenido.Controls.Add(this.lblCantidad);
            this.panelContenido.Controls.Add(this.lblAbreviacion);
            this.panelContenido.Controls.Add(this.lblNombre);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(267, 37);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenido.MinimumSize = new System.Drawing.Size(373, 2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(533, 517);
            this.panelContenido.TabIndex = 29;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubirFoto.BorderRadius = 5;
            this.btnSubirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirFoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubirFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubirFoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnSubirFoto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSubirFoto.ForeColor = System.Drawing.Color.White;
            this.btnSubirFoto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnSubirFoto.Location = new System.Drawing.Point(333, 347);
            this.btnSubirFoto.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnSubirFoto.Size = new System.Drawing.Size(133, 44);
            this.btnSubirFoto.TabIndex = 31;
            this.btnSubirFoto.Text = "Subir logo";
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // imgPerfil
            // 
            this.imgPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgPerfil.BackColor = System.Drawing.Color.Transparent;
            this.imgPerfil.ErrorImage = null;
            this.imgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("imgPerfil.Image")));
            this.imgPerfil.ImageLocation = "0";
            this.imgPerfil.ImageRotate = 0F;
            this.imgPerfil.Location = new System.Drawing.Point(333, 219);
            this.imgPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.imgPerfil.MaximumSize = new System.Drawing.Size(200, 185);
            this.imgPerfil.MinimumSize = new System.Drawing.Size(133, 123);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgPerfil.Size = new System.Drawing.Size(133, 123);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPerfil.TabIndex = 30;
            this.imgPerfil.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtCantidad.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCantidad.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtCantidad.Location = new System.Drawing.Point(67, 348);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(67, 6, 67, 6);
            this.txtCantidad.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.Size = new System.Drawing.Size(200, 43);
            this.txtCantidad.TabIndex = 29;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtAbreviacion
            // 
            this.txtAbreviacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAbreviacion.BackColor = System.Drawing.Color.Transparent;
            this.txtAbreviacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtAbreviacion.BorderRadius = 15;
            this.txtAbreviacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbreviacion.DefaultText = "";
            this.txtAbreviacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAbreviacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAbreviacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAbreviacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAbreviacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtAbreviacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtAbreviacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviacion.ForeColor = System.Drawing.Color.White;
            this.txtAbreviacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtAbreviacion.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAbreviacion.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtAbreviacion.Location = new System.Drawing.Point(67, 249);
            this.txtAbreviacion.Margin = new System.Windows.Forms.Padding(67, 6, 67, 6);
            this.txtAbreviacion.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtAbreviacion.Name = "txtAbreviacion";
            this.txtAbreviacion.PasswordChar = '\0';
            this.txtAbreviacion.PlaceholderText = "";
            this.txtAbreviacion.SelectedText = "";
            this.txtAbreviacion.Size = new System.Drawing.Size(200, 43);
            this.txtAbreviacion.TabIndex = 28;
            this.txtAbreviacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAbreviacion.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreNuevo.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreNuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtNombreNuevo.BorderRadius = 15;
            this.txtNombreNuevo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreNuevo.DefaultText = "";
            this.txtNombreNuevo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreNuevo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreNuevo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtNombreNuevo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtNombreNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevo.ForeColor = System.Drawing.Color.White;
            this.txtNombreNuevo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtNombreNuevo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtNombreNuevo.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtNombreNuevo.Location = new System.Drawing.Point(67, 149);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(67, 6, 67, 6);
            this.txtNombreNuevo.MinimumSize = new System.Drawing.Size(400, 43);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.PasswordChar = '\0';
            this.txtNombreNuevo.PlaceholderText = "";
            this.txtNombreNuevo.SelectedText = "";
            this.txtNombreNuevo.Size = new System.Drawing.Size(400, 43);
            this.txtNombreNuevo.TabIndex = 27;
            this.txtNombreNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreNuevo.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Image = global::UWallet.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(67, 426);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnCancelar.Size = new System.Drawing.Size(187, 55);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.BorderRadius = 5;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Image = global::UWallet.Properties.Resources.accept;
            this.btnConfirmar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirmar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfirmar.Location = new System.Drawing.Point(280, 426);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 25);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Size = new System.Drawing.Size(187, 55);
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AGREGAR NUEVA CRIPTOMONEDA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(67, 310);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(200, 32);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbreviacion
            // 
            this.lblAbreviacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAbreviacion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblAbreviacion.ForeColor = System.Drawing.Color.White;
            this.lblAbreviacion.Location = new System.Drawing.Point(67, 210);
            this.lblAbreviacion.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblAbreviacion.Name = "lblAbreviacion";
            this.lblAbreviacion.Size = new System.Drawing.Size(200, 32);
            this.lblAbreviacion.TabIndex = 4;
            this.lblAbreviacion.Text = "Abreviación:";
            this.lblAbreviacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(0, 111);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(533, 32);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de la Criptomoneda:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmNuevaCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 554);
            this.Name = "frmNuevaCripto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLogo;
        private Panel panelBarra;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private Panel panelContenido;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Label lblTitulo;
        private Label lblCantidad;
        private Label lblAbreviacion;
        private Label lblNombre;
        private Label lblEmpresa;
        private PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtAbreviacion;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreNuevo;
        private Guna.UI2.WinForms.Guna2Button btnSubirFoto;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgPerfil;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
    }
}