using System;

namespace UWallet.Interfaces.Clientes
{
    partial class btnCripto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAbreviacion = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.imgCripto = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblId_Cripto = new System.Windows.Forms.Label();
            this.lblId_Usuario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Visible = false;
            // 
            // lblAbreviacion
            // 
            this.lblAbreviacion.AutoSize = true;
            this.lblAbreviacion.Location = new System.Drawing.Point(13, 23);
            this.lblAbreviacion.Name = "lblAbreviacion";
            this.lblAbreviacion.Size = new System.Drawing.Size(0, 13);
            this.lblAbreviacion.TabIndex = 2;
            this.lblAbreviacion.Visible = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(11, 42);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Visible = false;
            // 
            // imgCripto
            // 
            this.imgCripto.BackColor = System.Drawing.Color.Transparent;
            this.imgCripto.BorderColor = System.Drawing.Color.Transparent;
            this.imgCripto.BorderThickness = 1;
            this.imgCripto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.imgCripto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.imgCripto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.imgCripto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.imgCripto.FillColor = System.Drawing.Color.Transparent;
            this.imgCripto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imgCripto.ForeColor = System.Drawing.Color.White;
            this.imgCripto.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.imgCripto.Image = global::UWallet.Properties.Resources.ETH_icono;
            this.imgCripto.ImageSize = new System.Drawing.Size(65, 65);
            this.imgCripto.Location = new System.Drawing.Point(5, 3);
            this.imgCripto.Name = "imgCripto";
            this.imgCripto.PressedColor = System.Drawing.Color.Silver;
            this.imgCripto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgCripto.Size = new System.Drawing.Size(67, 67);
            this.imgCripto.TabIndex = 4;
            this.imgCripto.Click += new System.EventHandler(this.Botones_Click);
            this.imgCripto.MouseEnter += new System.EventHandler(this.btnCripto_MouseEnter);
            this.imgCripto.MouseLeave += new System.EventHandler(this.btnCripto_MouseLeave);
            // 
            // lblId_Cripto
            // 
            this.lblId_Cripto.AutoSize = true;
            this.lblId_Cripto.Location = new System.Drawing.Point(6, 6);
            this.lblId_Cripto.Name = "lblId_Cripto";
            this.lblId_Cripto.Size = new System.Drawing.Size(0, 13);
            this.lblId_Cripto.TabIndex = 5;
            this.lblId_Cripto.Visible = false;
            // 
            // lblId_Usuario
            // 
            this.lblId_Usuario.AutoSize = true;
            this.lblId_Usuario.Location = new System.Drawing.Point(4, 39);
            this.lblId_Usuario.Name = "lblId_Usuario";
            this.lblId_Usuario.Size = new System.Drawing.Size(0, 13);
            this.lblId_Usuario.TabIndex = 6;
            this.lblId_Usuario.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(42, 27);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Visible = false;
            // 
            // btnCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblId_Usuario);
            this.Controls.Add(this.lblId_Cripto);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblAbreviacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.imgCripto);
            this.Name = "btnCripto";
            this.Size = new System.Drawing.Size(77, 77);
            this.Click += new System.EventHandler(this.Botones_Click);
            this.MouseEnter += new System.EventHandler(this.btnCripto_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.btnCripto_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAbreviacion;
        private System.Windows.Forms.Label lblSaldo;
        private Guna.UI2.WinForms.Guna2CircleButton imgCripto;
        private System.Windows.Forms.Label lblId_Cripto;
        private System.Windows.Forms.Label lblId_Usuario;
        private System.Windows.Forms.Label lblCantidad;
    }
}
