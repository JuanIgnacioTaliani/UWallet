using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    partial class frmCriptomonedas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriptomonedas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCripto = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dvgCriptomonedas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreviacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.elipseDvg = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panelBarra.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCriptomonedas)).BeginInit();
            this.SuspendLayout();
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
            this.panelBarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(933, 74);
            this.panelBarra.TabIndex = 3;
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
            this.imgClose.Location = new System.Drawing.Point(881, 18);
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
            this.imgMaximize.Location = new System.Drawing.Point(841, 18);
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
            this.imgMinimize.Location = new System.Drawing.Point(801, 18);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.PressedState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Size = new System.Drawing.Size(40, 37);
            this.imgMinimize.TabIndex = 11;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(29, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 74);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CRIPTOMONEDAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.BorderRadius = 15;
            this.panelContenido.Controls.Add(this.btnActualizar);
            this.panelContenido.Controls.Add(this.btnAddCripto);
            this.panelContenido.Controls.Add(this.txtSearch);
            this.panelContenido.Controls.Add(this.dvgCriptomonedas);
            this.panelContenido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panelContenido.Location = new System.Drawing.Point(16, 78);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(901, 462);
            this.panelContenido.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnActualizar.BorderRadius = 5;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizar.FillColor = System.Drawing.Color.ForestGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::UWallet.Properties.Resources.refresh;
            this.btnActualizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActualizar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnActualizar.Location = new System.Drawing.Point(187, 12);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(7, 12, 13, 6);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.PressedColor = System.Drawing.Color.LimeGreen;
            this.btnActualizar.Size = new System.Drawing.Size(187, 43);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAddCripto
            // 
            this.btnAddCripto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnAddCripto.BorderRadius = 5;
            this.btnAddCripto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCripto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCripto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCripto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCripto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCripto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAddCripto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAddCripto.ForeColor = System.Drawing.Color.White;
            this.btnAddCripto.Image = global::UWallet.Properties.Resources.add;
            this.btnAddCripto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddCripto.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCripto.Location = new System.Drawing.Point(13, 12);
            this.btnAddCripto.Margin = new System.Windows.Forms.Padding(13, 12, 7, 6);
            this.btnAddCripto.Name = "btnAddCripto";
            this.btnAddCripto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAddCripto.Size = new System.Drawing.Size(160, 43);
            this.btnAddCripto.TabIndex = 34;
            this.btnAddCripto.Text = "Añadir";
            this.btnAddCripto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddCripto.Click += new System.EventHandler(this.btnAddCripto_Click);
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
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::UWallet.Properties.Resources.search;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(555, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 6);
            this.txtSearch.MaximumSize = new System.Drawing.Size(533, 43);
            this.txtSearch.MinimumSize = new System.Drawing.Size(333, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Buscar Criptomoneda";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(333, 43);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dvgCriptomonedas
            // 
            this.dvgCriptomonedas.AllowUserToAddRows = false;
            this.dvgCriptomonedas.AllowUserToDeleteRows = false;
            this.dvgCriptomonedas.AllowUserToResizeColumns = false;
            this.dvgCriptomonedas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dvgCriptomonedas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCriptomonedas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCriptomonedas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCriptomonedas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.dvgCriptomonedas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCriptomonedas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgCriptomonedas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCriptomonedas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCriptomonedas.ColumnHeadersHeight = 50;
            this.dvgCriptomonedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Logo,
            this.Nombre,
            this.Abreviacion,
            this.Cantidad,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCriptomonedas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgCriptomonedas.EnableHeadersVisualStyles = false;
            this.dvgCriptomonedas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.dvgCriptomonedas.Location = new System.Drawing.Point(13, 68);
            this.dvgCriptomonedas.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.dvgCriptomonedas.MultiSelect = false;
            this.dvgCriptomonedas.Name = "dvgCriptomonedas";
            this.dvgCriptomonedas.ReadOnly = true;
            this.dvgCriptomonedas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCriptomonedas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgCriptomonedas.RowHeadersVisible = false;
            this.dvgCriptomonedas.RowHeadersWidth = 20;
            this.dvgCriptomonedas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dvgCriptomonedas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgCriptomonedas.RowTemplate.Height = 25;
            this.dvgCriptomonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCriptomonedas.ShowEditingIcon = false;
            this.dvgCriptomonedas.Size = new System.Drawing.Size(875, 382);
            this.dvgCriptomonedas.TabIndex = 5;
            this.dvgCriptomonedas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCriptomonedas_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 45.08253F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Logo
            // 
            this.Logo.FillWeight = 28F;
            this.Logo.HeaderText = "Logo";
            this.Logo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Logo.MinimumWidth = 25;
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.FillWeight = 96.47664F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Abreviacion
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Abreviacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Abreviacion.FillWeight = 96.47664F;
            this.Abreviacion.HeaderText = "Abreviación";
            this.Abreviacion.MinimumWidth = 6;
            this.Abreviacion.Name = "Abreviacion";
            this.Abreviacion.ReadOnly = true;
            this.Abreviacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cantidad.FillWeight = 48.2383F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.Delete.FillWeight = 20F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 30;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 30;
            // 
            // elipseDvg
            // 
            this.elipseDvg.BorderRadius = 15;
            this.elipseDvg.TargetControl = this.dvgCriptomonedas;
            // 
            // dcForm
            // 
            this.dcForm.DockIndicatorTransparencyValue = 0.6D;
            this.dcForm.TargetControl = this.panelBarra;
            this.dcForm.UseTransparentDrag = true;
            // 
            // resizeForm
            // 
            this.resizeForm.TargetForm = this;
            // 
            // frmCriptomonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(933, 554);
            this.Name = "frmCriptomonedas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelBarra.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCriptomonedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBarra;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel panelContenido;
        private DataGridView dvgCriptomonedas;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnAddCripto;
        private Guna.UI2.WinForms.Guna2Elipse elipseDvg;
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Abreviacion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}