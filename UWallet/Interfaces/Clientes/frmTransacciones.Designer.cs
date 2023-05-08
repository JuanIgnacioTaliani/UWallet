namespace UWallet.Interfaces.Clientes
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
            this.btnComprar = new Guna.UI2.WinForms.Guna2Button();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.btnVender = new Guna.UI2.WinForms.Guna2Button();
            this.panelTransaccion = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtCripto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTransaccion = new System.Windows.Forms.Label();
            this.panelMonederos = new Guna.UI2.WinForms.Guna2Panel();
            this.imgMonedero = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMonedero = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlSeleccionar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCripto1 = new UWallet.Interfaces.Clientes.btnCripto();
            this.panelTransaccion.SuspendLayout();
            this.panelMonederos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMonedero)).BeginInit();
            this.pnlSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComprar.BorderColor = System.Drawing.Color.Empty;
            this.btnComprar.BorderRadius = 20;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnComprar.Location = new System.Drawing.Point(12, 12);
            this.btnComprar.MinimumSize = new System.Drawing.Size(200, 45);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnComprar.Size = new System.Drawing.Size(200, 45);
            this.btnComprar.TabIndex = 13;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresar.BorderColor = System.Drawing.Color.Empty;
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnIngresar.Location = new System.Drawing.Point(488, 12);
            this.btnIngresar.MinimumSize = new System.Drawing.Size(200, 45);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnIngresar.Size = new System.Drawing.Size(200, 45);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVender.BorderColor = System.Drawing.Color.Empty;
            this.btnVender.BorderRadius = 20;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnVender.Location = new System.Drawing.Point(250, 12);
            this.btnVender.MinimumSize = new System.Drawing.Size(200, 45);
            this.btnVender.Name = "btnVender";
            this.btnVender.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnVender.Size = new System.Drawing.Size(200, 45);
            this.btnVender.TabIndex = 15;
            this.btnVender.Text = "Vender";
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // panelTransaccion
            // 
            this.panelTransaccion.BorderRadius = 15;
            this.panelTransaccion.Controls.Add(this.lblSeleccionar);
            this.panelTransaccion.Controls.Add(this.btnConfirmar);
            this.panelTransaccion.Controls.Add(this.lblEgreso);
            this.panelTransaccion.Controls.Add(this.lblIngreso);
            this.panelTransaccion.Controls.Add(this.txtCripto);
            this.panelTransaccion.Controls.Add(this.txtDolar);
            this.panelTransaccion.Controls.Add(this.lblTransaccion);
            this.panelTransaccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panelTransaccion.Location = new System.Drawing.Point(12, 100);
            this.panelTransaccion.Name = "panelTransaccion";
            this.panelTransaccion.Size = new System.Drawing.Size(450, 350);
            this.panelTransaccion.TabIndex = 16;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionar.Location = new System.Drawing.Point(201, 0);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(10);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(237, 30);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Seleccionar Criptomoneda";
            this.lblSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnConfirmar.Location = new System.Drawing.Point(17, 285);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Size = new System.Drawing.Size(170, 45);
            this.btnConfirmar.TabIndex = 33;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblEgreso
            // 
            this.lblEgreso.BackColor = System.Drawing.Color.Transparent;
            this.lblEgreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgreso.ForeColor = System.Drawing.Color.White;
            this.lblEgreso.Location = new System.Drawing.Point(17, 160);
            this.lblEgreso.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(170, 30);
            this.lblEgreso.TabIndex = 32;
            this.lblEgreso.Text = "Usted recibe ~";
            this.lblEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIngreso
            // 
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(17, 60);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(170, 30);
            this.lblIngreso.TabIndex = 31;
            this.lblIngreso.Text = "Monto:";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCripto
            // 
            this.txtCripto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCripto.BackColor = System.Drawing.Color.Transparent;
            this.txtCripto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtCripto.BorderRadius = 5;
            this.txtCripto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCripto.DefaultText = "";
            this.txtCripto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtCripto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtCripto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCripto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCripto.Enabled = false;
            this.txtCripto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtCripto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtCripto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCripto.ForeColor = System.Drawing.Color.White;
            this.txtCripto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtCripto.IconLeft = global::UWallet.Properties.Resources.btc;
            this.txtCripto.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtCripto.Location = new System.Drawing.Point(17, 200);
            this.txtCripto.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtCripto.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtCripto.Name = "txtCripto";
            this.txtCripto.PasswordChar = '\0';
            this.txtCripto.PlaceholderText = "-";
            this.txtCripto.SelectedText = "";
            this.txtCripto.Size = new System.Drawing.Size(170, 40);
            this.txtCripto.TabIndex = 30;
            this.txtCripto.TextOffset = new System.Drawing.Point(5, 0);
            this.txtCripto.TextChanged += new System.EventHandler(this.txtCripto_TextChanged);
            this.txtCripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCripto_KeyPress);
            // 
            // txtDolar
            // 
            this.txtDolar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDolar.BackColor = System.Drawing.Color.Transparent;
            this.txtDolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtDolar.BorderRadius = 5;
            this.txtDolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDolar.DefaultText = "";
            this.txtDolar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtDolar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtDolar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDolar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDolar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.txtDolar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtDolar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.ForeColor = System.Drawing.Color.White;
            this.txtDolar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtDolar.IconLeft = global::UWallet.Properties.Resources.dolar;
            this.txtDolar.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtDolar.Location = new System.Drawing.Point(17, 100);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txtDolar.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.PasswordChar = '\0';
            this.txtDolar.PlaceholderText = "USD";
            this.txtDolar.SelectedText = "";
            this.txtDolar.Size = new System.Drawing.Size(170, 40);
            this.txtDolar.TabIndex = 29;
            this.txtDolar.TextOffset = new System.Drawing.Point(5, 0);
            this.txtDolar.TextChanged += new System.EventHandler(this.txtDolar_TextChanged);
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            // 
            // lblTransaccion
            // 
            this.lblTransaccion.BackColor = System.Drawing.Color.Transparent;
            this.lblTransaccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaccion.ForeColor = System.Drawing.Color.White;
            this.lblTransaccion.Location = new System.Drawing.Point(0, 10);
            this.lblTransaccion.Margin = new System.Windows.Forms.Padding(10);
            this.lblTransaccion.Name = "lblTransaccion";
            this.lblTransaccion.Size = new System.Drawing.Size(200, 30);
            this.lblTransaccion.TabIndex = 1;
            this.lblTransaccion.Text = "Comprar";
            this.lblTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMonederos
            // 
            this.panelMonederos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMonederos.BackColor = System.Drawing.Color.Transparent;
            this.panelMonederos.BorderRadius = 15;
            this.panelMonederos.Controls.Add(this.imgMonedero);
            this.panelMonederos.Controls.Add(this.lblCantidad);
            this.panelMonederos.Controls.Add(this.lblActivos);
            this.panelMonederos.Controls.Add(this.lblDinero);
            this.panelMonederos.Controls.Add(this.lblSaldo);
            this.panelMonederos.Controls.Add(this.lblMonedero);
            this.panelMonederos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.panelMonederos.Location = new System.Drawing.Point(488, 100);
            this.panelMonederos.Name = "panelMonederos";
            this.panelMonederos.Size = new System.Drawing.Size(200, 350);
            this.panelMonederos.TabIndex = 17;
            // 
            // imgMonedero
            // 
            this.imgMonedero.ImageRotate = 0F;
            this.imgMonedero.Location = new System.Drawing.Point(50, 13);
            this.imgMonedero.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.imgMonedero.Name = "imgMonedero";
            this.imgMonedero.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgMonedero.Size = new System.Drawing.Size(100, 100);
            this.imgMonedero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMonedero.TabIndex = 36;
            this.imgMonedero.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(10, 290);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(180, 30);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "0";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActivos
            // 
            this.lblActivos.BackColor = System.Drawing.Color.Transparent;
            this.lblActivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.Color.White;
            this.lblActivos.Location = new System.Drawing.Point(10, 260);
            this.lblActivos.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(180, 30);
            this.lblActivos.TabIndex = 34;
            this.lblActivos.Text = "Cantidad";
            this.lblActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDinero
            // 
            this.lblDinero.BackColor = System.Drawing.Color.Transparent;
            this.lblDinero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.ForeColor = System.Drawing.Color.White;
            this.lblDinero.Location = new System.Drawing.Point(10, 210);
            this.lblDinero.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(180, 30);
            this.lblDinero.TabIndex = 33;
            this.lblDinero.Text = "$ -";
            this.lblDinero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(10, 180);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(180, 30);
            this.lblSaldo.TabIndex = 32;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonedero
            // 
            this.lblMonedero.BackColor = System.Drawing.Color.Transparent;
            this.lblMonedero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedero.ForeColor = System.Drawing.Color.White;
            this.lblMonedero.Location = new System.Drawing.Point(0, 120);
            this.lblMonedero.Margin = new System.Windows.Forms.Padding(10);
            this.lblMonedero.Name = "lblMonedero";
            this.lblMonedero.Size = new System.Drawing.Size(200, 30);
            this.lblMonedero.TabIndex = 2;
            this.lblMonedero.Text = "Monedero";
            this.lblMonedero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeleccionar
            // 
            this.pnlSeleccionar.Controls.Add(this.btnCripto1);
            this.pnlSeleccionar.Location = new System.Drawing.Point(204, 131);
            this.pnlSeleccionar.Name = "pnlSeleccionar";
            this.pnlSeleccionar.Size = new System.Drawing.Size(255, 319);
            this.pnlSeleccionar.TabIndex = 18;
            // 
            // btnCripto1
            // 
            this.btnCripto1.Abreviatura = null;
            this.btnCripto1.BackColor = System.Drawing.Color.Transparent;
            this.btnCripto1.Cantidad = null;
            this.btnCripto1.Id_cripto = null;
            this.btnCripto1.Id_usuario = null;
            this.btnCripto1.Location = new System.Drawing.Point(3, 3);
            this.btnCripto1.Logo = null;
            this.btnCripto1.Name = "btnCripto1";
            this.btnCripto1.Nombre = null;
            this.btnCripto1.Saldo = null;
            this.btnCripto1.Size = new System.Drawing.Size(70, 70);
            this.btnCripto1.TabIndex = 0;
            this.btnCripto1.Click += new System.EventHandler(this.Botones_Click);
            // 
            // frmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.pnlSeleccionar);
            this.Controls.Add(this.panelMonederos);
            this.Controls.Add(this.panelTransaccion);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 540);
            this.Name = "frmTransacciones";
            this.Text = "Transacciones";
            this.panelTransaccion.ResumeLayout(false);
            this.panelMonederos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMonedero)).EndInit();
            this.pnlSeleccionar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnComprar;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2Button btnVender;
        private Guna.UI2.WinForms.Guna2Panel panelTransaccion;
        private System.Windows.Forms.Label lblTransaccion;
        private Guna.UI2.WinForms.Guna2TextBox txtDolar;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblIngreso;
        private Guna.UI2.WinForms.Guna2TextBox txtCripto;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2Panel panelMonederos;
        private System.Windows.Forms.Label lblMonedero;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgMonedero;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblSaldo;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.FlowLayoutPanel pnlSeleccionar;
        private System.Windows.Forms.Label lblSeleccionar;
        private btnCripto btnCripto1;
    }
}