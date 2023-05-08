using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    partial class frmGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestion));
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.btnCriptos = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransacciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaises = new Guna.UI2.WinForms.Guna2Button();
            this.btnCiudades = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGestion
            // 
            this.pnlGestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGestion.Controls.Add(this.btnCriptos);
            this.pnlGestion.Controls.Add(this.btnTransacciones);
            this.pnlGestion.Controls.Add(this.btnClientes);
            this.pnlGestion.Controls.Add(this.btnPaises);
            this.pnlGestion.Controls.Add(this.btnCiudades);
            this.pnlGestion.Location = new System.Drawing.Point(12, 12);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(676, 466);
            this.pnlGestion.TabIndex = 9;
            // 
            // btnCriptos
            // 
            this.btnCriptos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCriptos.BorderColor = System.Drawing.Color.Empty;
            this.btnCriptos.BorderRadius = 10;
            this.btnCriptos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCriptos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCriptos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCriptos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCriptos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnCriptos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptos.ForeColor = System.Drawing.Color.White;
            this.btnCriptos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCriptos.Image = global::UWallet.Properties.Resources.crypto;
            this.btnCriptos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCriptos.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCriptos.Location = new System.Drawing.Point(45, 30);
            this.btnCriptos.Margin = new System.Windows.Forms.Padding(10);
            this.btnCriptos.MaximumSize = new System.Drawing.Size(250, 120);
            this.btnCriptos.MinimumSize = new System.Drawing.Size(280, 120);
            this.btnCriptos.Name = "btnCriptos";
            this.btnCriptos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCriptos.Size = new System.Drawing.Size(280, 120);
            this.btnCriptos.TabIndex = 18;
            this.btnCriptos.Text = "Gestionar Criptomonedas";
            this.btnCriptos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCriptos.Click += new System.EventHandler(this.btnCriptos_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransacciones.BorderColor = System.Drawing.Color.Empty;
            this.btnTransacciones.BorderRadius = 10;
            this.btnTransacciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransacciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransacciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransacciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransacciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransacciones.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnTransacciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacciones.ForeColor = System.Drawing.Color.White;
            this.btnTransacciones.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnTransacciones.Image = global::UWallet.Properties.Resources.transaction;
            this.btnTransacciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransacciones.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTransacciones.Location = new System.Drawing.Point(345, 30);
            this.btnTransacciones.Margin = new System.Windows.Forms.Padding(10);
            this.btnTransacciones.MaximumSize = new System.Drawing.Size(250, 120);
            this.btnTransacciones.MinimumSize = new System.Drawing.Size(280, 120);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnTransacciones.Size = new System.Drawing.Size(280, 120);
            this.btnTransacciones.TabIndex = 17;
            this.btnTransacciones.Text = "Gestionar Transacciones";
            this.btnTransacciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransacciones.Click += new System.EventHandler(this.btnTransacciones_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.BorderColor = System.Drawing.Color.Empty;
            this.btnClientes.BorderRadius = 10;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnClientes.Image = global::UWallet.Properties.Resources.user;
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClientes.Location = new System.Drawing.Point(195, 310);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(10);
            this.btnClientes.MaximumSize = new System.Drawing.Size(250, 120);
            this.btnClientes.MinimumSize = new System.Drawing.Size(280, 120);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnClientes.Size = new System.Drawing.Size(280, 120);
            this.btnClientes.TabIndex = 16;
            this.btnClientes.Text = "Gestionar Clientes";
            this.btnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPaises
            // 
            this.btnPaises.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaises.BorderColor = System.Drawing.Color.Empty;
            this.btnPaises.BorderRadius = 10;
            this.btnPaises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaises.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaises.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaises.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaises.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaises.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnPaises.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaises.ForeColor = System.Drawing.Color.White;
            this.btnPaises.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnPaises.Image = global::UWallet.Properties.Resources.pais;
            this.btnPaises.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPaises.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPaises.Location = new System.Drawing.Point(45, 170);
            this.btnPaises.Margin = new System.Windows.Forms.Padding(10);
            this.btnPaises.MaximumSize = new System.Drawing.Size(250, 120);
            this.btnPaises.MinimumSize = new System.Drawing.Size(280, 120);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnPaises.Size = new System.Drawing.Size(280, 120);
            this.btnPaises.TabIndex = 15;
            this.btnPaises.Text = "Gestionar Paises";
            this.btnPaises.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnCiudades
            // 
            this.btnCiudades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCiudades.BorderColor = System.Drawing.Color.Empty;
            this.btnCiudades.BorderRadius = 10;
            this.btnCiudades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCiudades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCiudades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCiudades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCiudades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCiudades.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnCiudades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiudades.ForeColor = System.Drawing.Color.White;
            this.btnCiudades.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCiudades.Image = global::UWallet.Properties.Resources.city;
            this.btnCiudades.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCiudades.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCiudades.Location = new System.Drawing.Point(345, 170);
            this.btnCiudades.Margin = new System.Windows.Forms.Padding(10);
            this.btnCiudades.MaximumSize = new System.Drawing.Size(250, 120);
            this.btnCiudades.MinimumSize = new System.Drawing.Size(280, 120);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnCiudades.Size = new System.Drawing.Size(280, 120);
            this.btnCiudades.TabIndex = 14;
            this.btnCiudades.Text = "Gestionar Ciudades";
            this.btnCiudades.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.pnlGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestion";
            this.ShowIcon = false;
            this.Text = "Gestion";
            this.pnlGestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlGestion;
        private Guna.UI2.WinForms.Guna2Button btnCiudades;
        private Guna.UI2.WinForms.Guna2Button btnTransacciones;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private Guna.UI2.WinForms.Guna2Button btnPaises;
        private Guna.UI2.WinForms.Guna2Button btnCriptos;
    }
}