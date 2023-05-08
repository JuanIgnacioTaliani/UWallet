using System.Windows.Forms.DataVisualization;

namespace UWallet.Interfaces.Clientes
{
    partial class frmCotizaciones
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(22D, 40D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(23D, 55D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(24D, 32D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(25D, 48D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(26D, 13D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(27D, 16D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCotizaciones = new Guna.UI2.WinForms.Guna2Panel();
            this.chartSpiline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMes = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoy = new Guna.UI2.WinForms.Guna2Button();
            this.btnSemana = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnio = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCotizaciones = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elipseDvg = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelCotizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpiline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCotizaciones
            // 
            this.panelCotizaciones.BorderRadius = 15;
            this.panelCotizaciones.Controls.Add(this.chartSpiline);
            this.panelCotizaciones.Controls.Add(this.btnMes);
            this.panelCotizaciones.Controls.Add(this.btnHoy);
            this.panelCotizaciones.Controls.Add(this.btnSemana);
            this.panelCotizaciones.Controls.Add(this.btnAnio);
            this.panelCotizaciones.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panelCotizaciones.Location = new System.Drawing.Point(19, 19);
            this.panelCotizaciones.Margin = new System.Windows.Forms.Padding(10);
            this.panelCotizaciones.Name = "panelCotizaciones";
            this.panelCotizaciones.Size = new System.Drawing.Size(662, 260);
            this.panelCotizaciones.TabIndex = 45;
            // 
            // chartSpiline
            // 
            this.chartSpiline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.Size = 3F;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.LabelStyle.Format = "$ {0}";
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.AxisY.MajorTickMark.Size = 3F;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            chartArea2.Name = "ChartArea1";
            this.chartSpiline.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.TitleForeColor = System.Drawing.Color.White;
            this.chartSpiline.Legends.Add(legend2);
            this.chartSpiline.Location = new System.Drawing.Point(10, 50);
            this.chartSpiline.Margin = new System.Windows.Forms.Padding(10);
            this.chartSpiline.Name = "chartSpiline";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint7.Label = "";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            this.chartSpiline.Series.Add(series2);
            this.chartSpiline.Size = new System.Drawing.Size(642, 200);
            this.chartSpiline.TabIndex = 0;
            this.chartSpiline.Text = "chartSpiline";
            title2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Cotizaciones";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartSpiline.Titles.Add(title2);
            // 
            // btnMes
            // 
            this.btnMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnMes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnMes.BorderThickness = 1;
            this.btnMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnMes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnMes.Location = new System.Drawing.Point(330, 10);
            this.btnMes.Margin = new System.Windows.Forms.Padding(0);
            this.btnMes.Name = "btnMes";
            this.btnMes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMes.Size = new System.Drawing.Size(160, 30);
            this.btnMes.TabIndex = 38;
            this.btnMes.Text = "Mes";
            // 
            // btnHoy
            // 
            this.btnHoy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnHoy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnHoy.BorderRadius = 5;
            this.btnHoy.BorderThickness = 1;
            this.btnHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoy.CustomizableEdges.BottomRight = false;
            this.btnHoy.CustomizableEdges.TopRight = false;
            this.btnHoy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnHoy.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnHoy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnHoy.Location = new System.Drawing.Point(10, 10);
            this.btnHoy.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnHoy.Size = new System.Drawing.Size(160, 30);
            this.btnHoy.TabIndex = 36;
            this.btnHoy.Text = "Hoy";
            // 
            // btnSemana
            // 
            this.btnSemana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnSemana.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnSemana.BorderThickness = 1;
            this.btnSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSemana.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSemana.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSemana.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSemana.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSemana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnSemana.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSemana.ForeColor = System.Drawing.Color.White;
            this.btnSemana.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnSemana.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnSemana.Location = new System.Drawing.Point(170, 10);
            this.btnSemana.Margin = new System.Windows.Forms.Padding(0);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnSemana.Size = new System.Drawing.Size(160, 30);
            this.btnSemana.TabIndex = 37;
            this.btnSemana.Text = "Semana";
            // 
            // btnAnio
            // 
            this.btnAnio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnAnio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.btnAnio.BorderRadius = 5;
            this.btnAnio.BorderThickness = 1;
            this.btnAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnio.CustomizableEdges.BottomLeft = false;
            this.btnAnio.CustomizableEdges.TopLeft = false;
            this.btnAnio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnAnio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAnio.ForeColor = System.Drawing.Color.White;
            this.btnAnio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAnio.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            this.btnAnio.Location = new System.Drawing.Point(490, 10);
            this.btnAnio.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnAnio.Size = new System.Drawing.Size(160, 30);
            this.btnAnio.TabIndex = 39;
            this.btnAnio.Text = "Año";
            // 
            // dgvCotizaciones
            // 
            this.dgvCotizaciones.AllowUserToAddRows = false;
            this.dgvCotizaciones.AllowUserToDeleteRows = false;
            this.dgvCotizaciones.AllowUserToResizeColumns = false;
            this.dgvCotizaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCotizaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCotizaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.dgvCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCotizaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCotizaciones.ColumnHeadersHeight = 50;
            this.dgvCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Logo,
            this.Nombre,
            this.Abreviatura,
            this.Cotizacion,
            this.Fecha});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCotizaciones.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCotizaciones.EnableHeadersVisualStyles = false;
            this.dgvCotizaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.dgvCotizaciones.Location = new System.Drawing.Point(19, 294);
            this.dgvCotizaciones.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.dgvCotizaciones.MultiSelect = false;
            this.dgvCotizaciones.Name = "dgvCotizaciones";
            this.dgvCotizaciones.ReadOnly = true;
            this.dgvCotizaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotizaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCotizaciones.RowHeadersVisible = false;
            this.dgvCotizaciones.RowHeadersWidth = 20;
            this.dgvCotizaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCotizaciones.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCotizaciones.RowTemplate.Height = 25;
            this.dgvCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCotizaciones.ShowEditingIcon = false;
            this.dgvCotizaciones.Size = new System.Drawing.Size(662, 227);
            this.dgvCotizaciones.TabIndex = 46;
            // 
            // Logo
            // 
            this.Logo.FillWeight = 50F;
            this.Logo.HeaderText = "Logo";
            this.Logo.MinimumWidth = 6;
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Logo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle11;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Abreviatura
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Abreviatura.DefaultCellStyle = dataGridViewCellStyle12;
            this.Abreviatura.FillWeight = 50F;
            this.Abreviatura.HeaderText = "Abreviatura";
            this.Abreviatura.MinimumWidth = 6;
            this.Abreviatura.Name = "Abreviatura";
            this.Abreviatura.ReadOnly = true;
            this.Abreviatura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cotizacion
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Cotizacion.DefaultCellStyle = dataGridViewCellStyle13;
            this.Cotizacion.FillWeight = 50F;
            this.Cotizacion.HeaderText = "Cotización";
            this.Cotizacion.MinimumWidth = 6;
            this.Cotizacion.Name = "Cotizacion";
            this.Cotizacion.ReadOnly = true;
            this.Cotizacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 50F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // elipseDvg
            // 
            this.elipseDvg.BorderRadius = 15;
            this.elipseDvg.TargetControl = this.dgvCotizaciones;
            // 
            // frmCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.dgvCotizaciones);
            this.Controls.Add(this.panelCotizaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 540);
            this.Name = "frmCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.frmCotizaciones_Load);
            this.panelCotizaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpiline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelCotizaciones;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpiline;
        private Guna.UI2.WinForms.Guna2Button btnMes;
        private Guna.UI2.WinForms.Guna2Button btnHoy;
        private Guna.UI2.WinForms.Guna2Button btnSemana;
        private Guna.UI2.WinForms.Guna2Button btnAnio;
        private System.Windows.Forms.DataGridView dgvCotizaciones;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private Guna.UI2.WinForms.Guna2Elipse elipseDvg;
    }
}

