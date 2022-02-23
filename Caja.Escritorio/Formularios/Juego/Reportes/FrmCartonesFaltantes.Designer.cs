namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmCartonesFaltantse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartonesFaltantse));
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.grbValoresActuales = new System.Windows.Forms.GroupBox();
            this.lblConectorHojas = new System.Windows.Forms.Label();
            this.txtHojaInicial = new System.Windows.Forms.NumericUpDown();
            this.lblRangoHojas = new System.Windows.Forms.Label();
            this.txtHojaFinal = new System.Windows.Forms.NumericUpDown();
            this.lblConectorCartones = new System.Windows.Forms.Label();
            this.txtCartonInicial = new System.Windows.Forms.NumericUpDown();
            this.cmdSeries = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblRangoCartones = new System.Windows.Forms.Label();
            this.txtCartonFinal = new System.Windows.Forms.NumericUpDown();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.grbInformacionHojas = new System.Windows.Forms.GroupBox();
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstHojas = new System.Windows.Forms.ListBox();
            this.menuVentana.SuspendLayout();
            this.grbValoresActuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonFinal)).BeginInit();
            this.grbInformacionHojas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(459, 24);
            this.menuVentana.TabIndex = 2;
            // 
            // grbValoresActuales
            // 
            this.grbValoresActuales.Controls.Add(this.lblConectorHojas);
            this.grbValoresActuales.Controls.Add(this.txtHojaInicial);
            this.grbValoresActuales.Controls.Add(this.lblRangoHojas);
            this.grbValoresActuales.Controls.Add(this.txtHojaFinal);
            this.grbValoresActuales.Controls.Add(this.lblConectorCartones);
            this.grbValoresActuales.Controls.Add(this.txtCartonInicial);
            this.grbValoresActuales.Controls.Add(this.cmdSeries);
            this.grbValoresActuales.Controls.Add(this.lblSerie);
            this.grbValoresActuales.Controls.Add(this.lblRangoCartones);
            this.grbValoresActuales.Controls.Add(this.txtCartonFinal);
            this.grbValoresActuales.Controls.Add(this.cmdProgramacion);
            this.grbValoresActuales.Controls.Add(this.lblJuego);
            this.grbValoresActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValoresActuales.Location = new System.Drawing.Point(12, 38);
            this.grbValoresActuales.Name = "grbValoresActuales";
            this.grbValoresActuales.Size = new System.Drawing.Size(431, 178);
            this.grbValoresActuales.TabIndex = 3;
            this.grbValoresActuales.TabStop = false;
            this.grbValoresActuales.Text = "Datos del Juego";
            // 
            // lblConectorHojas
            // 
            this.lblConectorHojas.Enabled = false;
            this.lblConectorHojas.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectorHojas.Location = new System.Drawing.Point(276, 123);
            this.lblConectorHojas.Name = "lblConectorHojas";
            this.lblConectorHojas.Size = new System.Drawing.Size(21, 25);
            this.lblConectorHojas.TabIndex = 14;
            this.lblConectorHojas.Text = "al";
            this.lblConectorHojas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHojaInicial
            // 
            this.txtHojaInicial.Enabled = false;
            this.txtHojaInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaInicial.Location = new System.Drawing.Point(171, 123);
            this.txtHojaInicial.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtHojaInicial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHojaInicial.Name = "txtHojaInicial";
            this.txtHojaInicial.Size = new System.Drawing.Size(100, 25);
            this.txtHojaInicial.TabIndex = 18;
            this.txtHojaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHojaInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRangoHojas
            // 
            this.lblRangoHojas.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoHojas.Location = new System.Drawing.Point(11, 123);
            this.lblRangoHojas.Name = "lblRangoHojas";
            this.lblRangoHojas.Size = new System.Drawing.Size(149, 25);
            this.lblRangoHojas.TabIndex = 19;
            this.lblRangoHojas.Text = "Rango de Hojas";
            this.lblRangoHojas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHojaFinal
            // 
            this.txtHojaFinal.Enabled = false;
            this.txtHojaFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaFinal.Location = new System.Drawing.Point(301, 123);
            this.txtHojaFinal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtHojaFinal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHojaFinal.Name = "txtHojaFinal";
            this.txtHojaFinal.Size = new System.Drawing.Size(100, 25);
            this.txtHojaFinal.TabIndex = 20;
            this.txtHojaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHojaFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblConectorCartones
            // 
            this.lblConectorCartones.Enabled = false;
            this.lblConectorCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectorCartones.Location = new System.Drawing.Point(276, 92);
            this.lblConectorCartones.Name = "lblConectorCartones";
            this.lblConectorCartones.Size = new System.Drawing.Size(21, 25);
            this.lblConectorCartones.TabIndex = 21;
            this.lblConectorCartones.Text = "al";
            this.lblConectorCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCartonInicial
            // 
            this.txtCartonInicial.Enabled = false;
            this.txtCartonInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonInicial.Location = new System.Drawing.Point(171, 92);
            this.txtCartonInicial.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCartonInicial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCartonInicial.Name = "txtCartonInicial";
            this.txtCartonInicial.Size = new System.Drawing.Size(100, 25);
            this.txtCartonInicial.TabIndex = 16;
            this.txtCartonInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCartonInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdSeries
            // 
            this.cmdSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSeries.Enabled = false;
            this.cmdSeries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeries.FormattingEnabled = true;
            this.cmdSeries.Location = new System.Drawing.Point(120, 59);
            this.cmdSeries.Name = "cmdSeries";
            this.cmdSeries.Size = new System.Drawing.Size(281, 23);
            this.cmdSeries.TabIndex = 15;
            // 
            // lblSerie
            // 
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(10, 59);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(100, 25);
            this.lblSerie.TabIndex = 22;
            this.lblSerie.Text = "Serie";
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRangoCartones
            // 
            this.lblRangoCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoCartones.Location = new System.Drawing.Point(11, 92);
            this.lblRangoCartones.Name = "lblRangoCartones";
            this.lblRangoCartones.Size = new System.Drawing.Size(149, 25);
            this.lblRangoCartones.TabIndex = 23;
            this.lblRangoCartones.Text = "Rango de Cartones";
            this.lblRangoCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCartonFinal
            // 
            this.txtCartonFinal.Enabled = false;
            this.txtCartonFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonFinal.Location = new System.Drawing.Point(301, 92);
            this.txtCartonFinal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCartonFinal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCartonFinal.Name = "txtCartonFinal";
            this.txtCartonFinal.Size = new System.Drawing.Size(100, 25);
            this.txtCartonFinal.TabIndex = 17;
            this.txtCartonFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCartonFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(120, 18);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(281, 23);
            this.cmdProgramacion.TabIndex = 2;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdProgramacion_SelectedIndexChanged);
            // 
            // lblJuego
            // 
            this.lblJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(10, 18);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(100, 25);
            this.lblJuego.TabIndex = 5;
            this.lblJuego.Text = "Número Juego";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbInformacionHojas
            // 
            this.grbInformacionHojas.Controls.Add(this.lstHojas);
            this.grbInformacionHojas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacionHojas.Location = new System.Drawing.Point(12, 222);
            this.grbInformacionHojas.Name = "grbInformacionHojas";
            this.grbInformacionHojas.Size = new System.Drawing.Size(431, 227);
            this.grbInformacionHojas.TabIndex = 4;
            this.grbInformacionHojas.TabStop = false;
            this.grbInformacionHojas.Text = "Información Hojas No Entregadas";
            // 
            // realizarDevoluciónHojasNOEntregadasToolStripMenuItem
            // 
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("realizarDevoluciónHojasNOEntregadasToolStripMenuItem.Image")));
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem.Name = "realizarDevoluciónHojasNOEntregadasToolStripMenuItem";
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem.Size = new System.Drawing.Size(253, 20);
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem.Text = "Realizar Devolución Hojas NO entregadas";
            this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem.Click += new System.EventHandler(this.realizarDevoluciónHojasNOEntregadasToolStripMenuItem_Click);
            // 
            // lstHojas
            // 
            this.lstHojas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHojas.FormattingEnabled = true;
            this.lstHojas.ItemHeight = 17;
            this.lstHojas.Location = new System.Drawing.Point(6, 21);
            this.lstHojas.Name = "lstHojas";
            this.lstHojas.Size = new System.Drawing.Size(419, 191);
            this.lstHojas.Sorted = true;
            this.lstHojas.TabIndex = 16;
            // 
            // FrmCartonesFaltantse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 461);
            this.Controls.Add(this.grbInformacionHojas);
            this.Controls.Add(this.grbValoresActuales);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCartonesFaltantse";
            this.Text = "Cartones Faltantes";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbValoresActuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonFinal)).EndInit();
            this.grbInformacionHojas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.GroupBox grbValoresActuales;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Label lblConectorHojas;
        private System.Windows.Forms.NumericUpDown txtHojaInicial;
        private System.Windows.Forms.Label lblRangoHojas;
        private System.Windows.Forms.NumericUpDown txtHojaFinal;
        private System.Windows.Forms.Label lblConectorCartones;
        private System.Windows.Forms.NumericUpDown txtCartonInicial;
        internal System.Windows.Forms.ComboBox cmdSeries;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblRangoCartones;
        private System.Windows.Forms.NumericUpDown txtCartonFinal;
        private System.Windows.Forms.GroupBox grbInformacionHojas;
        private System.Windows.Forms.ToolStripMenuItem realizarDevoluciónHojasNOEntregadasToolStripMenuItem;
        private System.Windows.Forms.ListBox lstHojas;
    }
}