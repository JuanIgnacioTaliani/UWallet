using System.Windows.Forms;

namespace UWallet.Interfaces.Ingreso
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnAcceder = new Guna.UI2.WinForms.Guna2Button();
            this.txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLblRestablecerContrasenia = new System.Windows.Forms.LinkLabel();
            this.linkLblRegister = new System.Windows.Forms.LinkLabel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelEmpresa.Controls.Add(this.lblEmpresa);
            this.panelEmpresa.Controls.Add(this.imgLogo);
            this.panelEmpresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmpresa.Location = new System.Drawing.Point(0, 0);
            this.panelEmpresa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(250, 400);
            this.panelEmpresa.TabIndex = 2;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpresa.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.lblEmpresa.Location = new System.Drawing.Point(0, 240);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(250, 60);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "U Wallet";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 100);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(2, 34, 2, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(250, 137);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelLogin.Controls.Add(this.btnAcceder);
            this.panelLogin.Controls.Add(this.txtContrasenia);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.linkLblRestablecerContrasenia);
            this.panelLogin.Controls.Add(this.linkLblRegister);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Location = new System.Drawing.Point(250, 30);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(399, 369);
            this.panelLogin.TabIndex = 5;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAcceder.BorderColor = System.Drawing.Color.Empty;
            this.btnAcceder.BorderRadius = 5;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAcceder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAcceder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAcceder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAcceder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnAcceder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAcceder.IndicateFocus = true;
            this.btnAcceder.Location = new System.Drawing.Point(49, 271);
            this.btnAcceder.MinimumSize = new System.Drawing.Size(300, 45);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnAcceder.Size = new System.Drawing.Size(300, 45);
            this.btnAcceder.TabIndex = 12;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasenia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtContrasenia.BorderRadius = 15;
            this.txtContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia.DefaultText = "";
            this.txtContrasenia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtContrasenia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtContrasenia.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtContrasenia.ForeColor = System.Drawing.Color.White;
            this.txtContrasenia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtContrasenia.IconLeft = global::UWallet.Properties.Resources.password_azul;
            this.txtContrasenia.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtContrasenia.IconRight = global::UWallet.Properties.Resources.visible;
            this.txtContrasenia.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtContrasenia.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtContrasenia.IconRightSize = new System.Drawing.Size(22, 22);
            this.txtContrasenia.Location = new System.Drawing.Point(49, 149);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(50, 30, 50, 1);
            this.txtContrasenia.MinimumSize = new System.Drawing.Size(300, 35);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.PlaceholderText = "Contraseña";
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.Size = new System.Drawing.Size(300, 35);
            this.txtContrasenia.TabIndex = 11;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.IconRightClick += new System.EventHandler(this.txtContrasenia_IconRightClick);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtUsuario.IconLeft = global::UWallet.Properties.Resources.user_azul;
            this.txtUsuario.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUsuario.Location = new System.Drawing.Point(49, 83);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(50, 30, 50, 1);
            this.txtUsuario.MinimumSize = new System.Drawing.Size(300, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "Nombre de usuario";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(300, 35);
            this.txtUsuario.TabIndex = 10;
            // 
            // linkLblRestablecerContrasenia
            // 
            this.linkLblRestablecerContrasenia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.linkLblRestablecerContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLblRestablecerContrasenia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblRestablecerContrasenia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.linkLblRestablecerContrasenia.ForeColor = System.Drawing.Color.White;
            this.linkLblRestablecerContrasenia.LinkColor = System.Drawing.Color.White;
            this.linkLblRestablecerContrasenia.Location = new System.Drawing.Point(49, 245);
            this.linkLblRestablecerContrasenia.Margin = new System.Windows.Forms.Padding(2, 26, 2, 3);
            this.linkLblRestablecerContrasenia.Name = "linkLblRestablecerContrasenia";
            this.linkLblRestablecerContrasenia.Size = new System.Drawing.Size(300, 20);
            this.linkLblRestablecerContrasenia.TabIndex = 9;
            this.linkLblRestablecerContrasenia.TabStop = true;
            this.linkLblRestablecerContrasenia.Text = "¿Olvidaste tu contraseña?";
            this.linkLblRestablecerContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLblRegister
            // 
            this.linkLblRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.linkLblRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.linkLblRegister.ForeColor = System.Drawing.Color.White;
            this.linkLblRegister.LinkColor = System.Drawing.Color.White;
            this.linkLblRegister.Location = new System.Drawing.Point(49, 322);
            this.linkLblRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 18);
            this.linkLblRegister.Name = "linkLblRegister";
            this.linkLblRegister.Size = new System.Drawing.Size(300, 20);
            this.linkLblRegister.TabIndex = 4;
            this.linkLblRegister.TabStop = true;
            this.linkLblRegister.Text = "Crear nueva cuenta";
            this.linkLblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegister_LinkClicked);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(-1, 15);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(400, 45);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "INICIAR SESIÓN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.panelBarra.Controls.Add(this.imgClose);
            this.panelBarra.Controls.Add(this.imgMaximize);
            this.panelBarra.Controls.Add(this.imgMinimize);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(250, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(400, 30);
            this.panelBarra.TabIndex = 4;
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgClose.ImageRotate = 0F;
            this.imgClose.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Location = new System.Drawing.Point(370, 0);
            this.imgClose.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgClose.Name = "imgClose";
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
            this.imgMaximize.Image = ((System.Drawing.Image)(resources.GetObject("imgMaximize.Image")));
            this.imgMaximize.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgMaximize.ImageRotate = 0F;
            this.imgMaximize.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Location = new System.Drawing.Point(340, 0);
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
            this.imgMinimize.Image = ((System.Drawing.Image)(resources.GetObject("imgMinimize.Image")));
            this.imgMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgMinimize.ImageRotate = 0F;
            this.imgMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Location = new System.Drawing.Point(310, 0);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.PressedState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Size = new System.Drawing.Size(30, 30);
            this.imgMinimize.TabIndex = 11;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelEmpresa;
        private Label lblEmpresa;
        private PictureBox imgLogo;
        private Panel panelLogin;
        private Guna.UI2.WinForms.Guna2Button btnAcceder;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private LinkLabel linkLblRestablecerContrasenia;
        private LinkLabel linkLblRegister;
        private Label lblLogin;
        private Panel panelBarra;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
    }
}