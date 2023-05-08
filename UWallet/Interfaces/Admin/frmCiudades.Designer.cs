using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    partial class frmCiudades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgCiudades = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCripto = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.elipseDvg = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCiudades)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgCiudades
            // 
            this.dvgCiudades.AllowUserToAddRows = false;
            this.dvgCiudades.AllowUserToDeleteRows = false;
            this.dvgCiudades.AllowUserToResizeColumns = false;
            this.dvgCiudades.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dvgCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCiudades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.dvgCiudades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgCiudades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dvgCiudades.ColumnHeadersHeight = 50;
            this.dvgCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.NombrePais,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCiudades.DefaultCellStyle = dataGridViewCellStyle16;
            this.dvgCiudades.EnableHeadersVisualStyles = false;
            this.dvgCiudades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.dvgCiudades.Location = new System.Drawing.Point(13, 68);
            this.dvgCiudades.Margin = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.dvgCiudades.MultiSelect = false;
            this.dvgCiudades.Name = "dvgCiudades";
            this.dvgCiudades.ReadOnly = true;
            this.dvgCiudades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCiudades.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dvgCiudades.RowHeadersVisible = false;
            this.dvgCiudades.RowHeadersWidth = 20;
            this.dvgCiudades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dvgCiudades.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dvgCiudades.RowTemplate.Height = 25;
            this.dvgCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCiudades.ShowEditingIcon = false;
            this.dvgCiudades.Size = new System.Drawing.Size(741, 382);
            this.dvgCiudades.TabIndex = 0;
            this.dvgCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCiudades_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle12;
            this.Nombre.FillWeight = 120F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NombrePais
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombrePais.DefaultCellStyle = dataGridViewCellStyle13;
            this.NombrePais.FillWeight = 60F;
            this.NombrePais.HeaderText = "Nombre del País";
            this.NombrePais.MinimumWidth = 6;
            this.NombrePais.Name = "NombrePais";
            this.NombrePais.ReadOnly = true;
            this.NombrePais.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle15;
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
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.BorderRadius = 15;
            this.panelContenido.Controls.Add(this.btnActualizar);
            this.panelContenido.Controls.Add(this.btnAddCripto);
            this.panelContenido.Controls.Add(this.dvgCiudades);
            this.panelContenido.Controls.Add(this.txtSearch);
            this.panelContenido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panelContenido.Location = new System.Drawing.Point(16, 78);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(768, 462);
            this.panelContenido.TabIndex = 7;
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
            this.btnAddCripto.Click += new System.EventHandler(this.btnAddCiudad_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(421, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 6);
            this.txtSearch.MaximumSize = new System.Drawing.Size(533, 43);
            this.txtSearch.MinimumSize = new System.Drawing.Size(333, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Buscar Ciudad\r\n";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(333, 43);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.panelBarra.Size = new System.Drawing.Size(800, 74);
            this.panelBarra.TabIndex = 6;
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
            this.imgClose.Location = new System.Drawing.Point(748, 18);
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
            this.imgMaximize.Location = new System.Drawing.Point(708, 18);
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
            this.imgMinimize.Location = new System.Drawing.Point(668, 18);
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
            this.lblTitulo.Size = new System.Drawing.Size(147, 74);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CIUDADES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elipseDvg
            // 
            this.elipseDvg.BorderRadius = 15;
            this.elipseDvg.TargetControl = this.dvgCiudades;
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
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 554);
            this.Name = "frmCiudades";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dvgCiudades)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dvgCiudades;
        private Guna.UI2.WinForms.Guna2Panel panelContenido;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnAddCripto;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Panel panelBarra;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Elipse elipseDvg;
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NombrePais;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}