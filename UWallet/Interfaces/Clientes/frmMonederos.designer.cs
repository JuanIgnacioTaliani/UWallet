namespace UWallet.Interfaces.Clientes
{
    partial class frmMonederos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cpbMonedero = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.imgMonedero = new System.Windows.Forms.PictureBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.panelAgregar = new Guna.UI2.WinForms.Guna2Panel();
            this.cbNombresCriptos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.elipseDvg = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvMonederos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.IdCripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            this.cpbMonedero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMonedero)).BeginInit();
            this.panelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonederos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitulo.BorderRadius = 15;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.cpbMonedero);
            this.panelTitulo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.panelTitulo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panelTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitulo.ForeColor = System.Drawing.Color.White;
            this.panelTitulo.Location = new System.Drawing.Point(19, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(244, 193);
            this.panelTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mis Monederos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbMonedero
            // 
            this.cpbMonedero.Animated = true;
            this.cpbMonedero.AnimationSpeed = 0.4F;
            this.cpbMonedero.Controls.Add(this.imgMonedero);
            this.cpbMonedero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.cpbMonedero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbMonedero.ForeColor = System.Drawing.Color.White;
            this.cpbMonedero.Location = new System.Drawing.Point(60, 58);
            this.cpbMonedero.Minimum = 0;
            this.cpbMonedero.Name = "cpbMonedero";
            this.cpbMonedero.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.cpbMonedero.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(115)))), ((int)(((byte)(245)))));
            this.cpbMonedero.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbMonedero.Size = new System.Drawing.Size(130, 130);
            this.cpbMonedero.TabIndex = 5;
            this.cpbMonedero.Text = "guna2CircleProgressBar1";
            this.cpbMonedero.Value = 70;
            // 
            // imgMonedero
            // 
            this.imgMonedero.BackColor = System.Drawing.Color.Transparent;
            this.imgMonedero.Image = global::UWallet.Properties.Resources.wallet_grande;
            this.imgMonedero.Location = new System.Drawing.Point(36, 38);
            this.imgMonedero.Name = "imgMonedero";
            this.imgMonedero.Size = new System.Drawing.Size(61, 50);
            this.imgMonedero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMonedero.TabIndex = 0;
            this.imgMonedero.TabStop = false;
            // 
            // lblAgregar
            // 
            this.lblAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.ForeColor = System.Drawing.Color.White;
            this.lblAgregar.Location = new System.Drawing.Point(3, 10);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(155, 46);
            this.lblAgregar.TabIndex = 1;
            this.lblAgregar.Text = "Agregar Monedero";
            this.lblAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAgregar
            // 
            this.panelAgregar.BorderRadius = 10;
            this.panelAgregar.Controls.Add(this.cbNombresCriptos);
            this.panelAgregar.Controls.Add(this.lblAgregar);
            this.panelAgregar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.panelAgregar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panelAgregar.Location = new System.Drawing.Point(274, 149);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(407, 56);
            this.panelAgregar.TabIndex = 6;
            // 
            // cbNombresCriptos
            // 
            this.cbNombresCriptos.BackColor = System.Drawing.Color.Transparent;
            this.cbNombresCriptos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.cbNombresCriptos.BorderRadius = 15;
            this.cbNombresCriptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNombresCriptos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNombresCriptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombresCriptos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.cbNombresCriptos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.cbNombresCriptos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.cbNombresCriptos.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbNombresCriptos.ForeColor = System.Drawing.Color.White;
            this.cbNombresCriptos.IntegralHeight = false;
            this.cbNombresCriptos.ItemHeight = 30;
            this.cbNombresCriptos.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.cbNombresCriptos.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.cbNombresCriptos.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbNombresCriptos.Location = new System.Drawing.Point(171, 10);
            this.cbNombresCriptos.Margin = new System.Windows.Forms.Padding(10);
            this.cbNombresCriptos.Name = "cbNombresCriptos";
            this.cbNombresCriptos.Size = new System.Drawing.Size(226, 36);
            this.cbNombresCriptos.TabIndex = 18;
            // 
            // elipseDvg
            // 
            this.elipseDvg.BorderRadius = 15;
            this.elipseDvg.TargetControl = this.dgvMonederos;
            // 
            // dgvMonederos
            // 
            this.dgvMonederos.AllowUserToAddRows = false;
            this.dgvMonederos.AllowUserToDeleteRows = false;
            this.dgvMonederos.AllowUserToResizeColumns = false;
            this.dgvMonederos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonederos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonederos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonederos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonederos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.dgvMonederos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonederos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonederos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonederos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonederos.ColumnHeadersHeight = 50;
            this.dgvMonederos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonederos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCripto,
            this.Logo,
            this.Nombre,
            this.Abreviatura,
            this.Saldo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonederos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMonederos.EnableHeadersVisualStyles = false;
            this.dgvMonederos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.dgvMonederos.Location = new System.Drawing.Point(19, 213);
            this.dgvMonederos.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.dgvMonederos.MultiSelect = false;
            this.dgvMonederos.Name = "dgvMonederos";
            this.dgvMonederos.ReadOnly = true;
            this.dgvMonederos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonederos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMonederos.RowHeadersVisible = false;
            this.dgvMonederos.RowHeadersWidth = 20;
            this.dgvMonederos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonederos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMonederos.RowTemplate.Height = 25;
            this.dgvMonederos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonederos.ShowEditingIcon = false;
            this.dgvMonederos.Size = new System.Drawing.Size(662, 255);
            this.dgvMonederos.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminar.BorderThickness = 1;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnEliminar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEliminar.Location = new System.Drawing.Point(555, 481);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregar.BorderThickness = 1;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAgregar.Location = new System.Drawing.Point(421, 481);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.guna2Panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(274, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(407, 131);
            this.guna2Panel1.TabIndex = 6;
            // 
            // IdCripto
            // 
            this.IdCripto.HeaderText = "IdCripto";
            this.IdCripto.Name = "IdCripto";
            this.IdCripto.ReadOnly = true;
            this.IdCripto.Visible = false;
            // 
            // Logo
            // 
            this.Logo.FillWeight = 80F;
            this.Logo.HeaderText = "Logo";
            this.Logo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Logo.MinimumWidth = 6;
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Logo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.FillWeight = 120F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Abreviatura
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Abreviatura.DefaultCellStyle = dataGridViewCellStyle4;
            this.Abreviatura.FillWeight = 60F;
            this.Abreviatura.HeaderText = "Abreviatura";
            this.Abreviatura.MinimumWidth = 6;
            this.Abreviatura.Name = "Abreviatura";
            this.Abreviatura.ReadOnly = true;
            this.Abreviatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Saldo
            // 
            this.Saldo.FillWeight = 60F;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmMonederos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMonederos);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 540);
            this.Name = "frmMonederos";
            this.Text = "Monederos";
            this.Load += new System.EventHandler(this.frmMonederos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.cpbMonedero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMonedero)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonederos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbMonedero;
        private System.Windows.Forms.PictureBox imgMonedero;
        private System.Windows.Forms.Label lblAgregar;
        private Guna.UI2.WinForms.Guna2Panel panelAgregar;
        private Guna.UI2.WinForms.Guna2ComboBox cbNombresCriptos;
        private Guna.UI2.WinForms.Guna2Elipse elipseDvg;
        private System.Windows.Forms.DataGridView dgvMonederos;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCripto;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}