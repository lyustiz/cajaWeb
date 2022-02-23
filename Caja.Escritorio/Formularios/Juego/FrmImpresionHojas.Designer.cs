namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmImpresionHojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpresionHojas));
            this.grbValoresActuales = new System.Windows.Forms.GroupBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.chkSoloCodigo = new System.Windows.Forms.CheckBox();
            this.lblCartonFinal = new System.Windows.Forms.Label();
            this.txtCartonInicial = new System.Windows.Forms.NumericUpDown();
            this.cmdSeries = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblCartonInicial = new System.Windows.Forms.Label();
            this.txtCartonFinal = new System.Windows.Forms.NumericUpDown();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbValoresActuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonFinal)).BeginInit();
            this.menuVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbValoresActuales
            // 
            this.grbValoresActuales.Controls.Add(this.txtSimbolo);
            this.grbValoresActuales.Controls.Add(this.chkSoloCodigo);
            this.grbValoresActuales.Controls.Add(this.lblCartonFinal);
            this.grbValoresActuales.Controls.Add(this.txtCartonInicial);
            this.grbValoresActuales.Controls.Add(this.cmdSeries);
            this.grbValoresActuales.Controls.Add(this.lblSerie);
            this.grbValoresActuales.Controls.Add(this.lblCartonInicial);
            this.grbValoresActuales.Controls.Add(this.txtCartonFinal);
            this.grbValoresActuales.Controls.Add(this.cmdProgramacion);
            this.grbValoresActuales.Controls.Add(this.lblJuego);
            this.grbValoresActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValoresActuales.Location = new System.Drawing.Point(12, 27);
            this.grbValoresActuales.Name = "grbValoresActuales";
            this.grbValoresActuales.Size = new System.Drawing.Size(567, 142);
            this.grbValoresActuales.TabIndex = 6;
            this.grbValoresActuales.TabStop = false;
            this.grbValoresActuales.Text = "Juegos Activos";
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Enabled = false;
            this.txtSimbolo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimbolo.Location = new System.Drawing.Point(449, 59);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(100, 23);
            this.txtSimbolo.TabIndex = 25;
            this.txtSimbolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.chkSoloCodigo.AutoSize = true;
            this.chkSoloCodigo.Location = new System.Drawing.Point(449, 21);
            this.chkSoloCodigo.Name = "checkBox1";
            this.chkSoloCodigo.Size = new System.Drawing.Size(95, 17);
            this.chkSoloCodigo.TabIndex = 24;
            this.chkSoloCodigo.Text = "Solo Códigos";
            this.chkSoloCodigo.UseVisualStyleBackColor = true;
            // 
            // lblCartonFinal
            // 
            this.lblCartonFinal.Enabled = false;
            this.lblCartonFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonFinal.Location = new System.Drawing.Point(226, 90);
            this.lblCartonFinal.Name = "lblCartonFinal";
            this.lblCartonFinal.Size = new System.Drawing.Size(99, 25);
            this.lblCartonFinal.TabIndex = 21;
            this.lblCartonFinal.Text = "Cartón Final";
            this.lblCartonFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCartonInicial
            // 
            this.txtCartonInicial.Enabled = false;
            this.txtCartonInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonInicial.Location = new System.Drawing.Point(120, 90);
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
            this.cmdSeries.Size = new System.Drawing.Size(323, 23);
            this.cmdSeries.TabIndex = 15;
            this.cmdSeries.SelectedIndexChanged += new System.EventHandler(this.cmdSeries_SelectedIndexChanged);
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
            // lblCartonInicial
            // 
            this.lblCartonInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonInicial.Location = new System.Drawing.Point(11, 90);
            this.lblCartonInicial.Name = "lblCartonInicial";
            this.lblCartonInicial.Size = new System.Drawing.Size(99, 25);
            this.lblCartonInicial.TabIndex = 23;
            this.lblCartonInicial.Text = "Cartón Inicial";
            this.lblCartonInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCartonFinal
            // 
            this.txtCartonFinal.Enabled = false;
            this.txtCartonFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonFinal.Location = new System.Drawing.Point(331, 90);
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
            this.cmdProgramacion.Size = new System.Drawing.Size(323, 23);
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
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImprimirToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(608, 24);
            this.menuVentana.TabIndex = 5;
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirToolStripMenuItem.Image")));
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ImprimirToolStripMenuItem.Text = "Imprimir";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // FrmImpresionHojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 184);
            this.Controls.Add(this.grbValoresActuales);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImpresionHojas";
            this.Text = "Impresión de Hojas por Juego";
            this.grbValoresActuales.ResumeLayout(false);
            this.grbValoresActuales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonFinal)).EndInit();
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbValoresActuales;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.CheckBox chkSoloCodigo;
        private System.Windows.Forms.Label lblCartonFinal;
        private System.Windows.Forms.NumericUpDown txtCartonInicial;
        internal System.Windows.Forms.ComboBox cmdSeries;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblCartonInicial;
        private System.Windows.Forms.NumericUpDown txtCartonFinal;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
    }
}