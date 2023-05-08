namespace UWallet.Interfaces.Reportes
{
    partial class frmReportes
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
            this.rwAdmin = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rwAdmin
            // 
            this.rwAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.rwAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rwAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwAdmin.LocalReport.ReportEmbeddedResource = "UWallet.Interfaces.Reportes.ReporteAdmin.rdlc";
            this.rwAdmin.Location = new System.Drawing.Point(0, 12);
            this.rwAdmin.Name = "rwAdmin";
            this.rwAdmin.ServerReport.BearerToken = null;
            this.rwAdmin.ShowFindControls = false;
            this.rwAdmin.ShowPageNavigationControls = false;
            this.rwAdmin.ShowStopButton = false;
            this.rwAdmin.Size = new System.Drawing.Size(700, 479);
            this.rwAdmin.TabIndex = 49;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.rwAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 490);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwAdmin;
    }
}