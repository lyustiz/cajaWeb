namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmGeneracionCartonesVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneracionCartonesVendidos));
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.ExportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbValoresActuales = new System.Windows.Forms.GroupBox();
            this.lblTotalModulos = new System.Windows.Forms.Label();
            this.txtCantidadModulos = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCartones = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.menuVentana.SuspendLayout();
            this.grbValoresActuales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(459, 24);
            this.menuVentana.TabIndex = 2;
            // 
            // ExportarToolStripMenuItem
            // 
            this.ExportarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExportarToolStripMenuItem.Image")));
            this.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem";
            this.ExportarToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ExportarToolStripMenuItem.Text = "Exportar";
            this.ExportarToolStripMenuItem.Click += new System.EventHandler(this.ExportarToolStripMenuItem_Click);
            // 
            // grbValoresActuales
            // 
            this.grbValoresActuales.Controls.Add(this.lblTotalModulos);
            this.grbValoresActuales.Controls.Add(this.txtCantidadModulos);
            this.grbValoresActuales.Controls.Add(this.lblTotalCartones);
            this.grbValoresActuales.Controls.Add(this.txtCantidad);
            this.grbValoresActuales.Controls.Add(this.cmdProgramacion);
            this.grbValoresActuales.Controls.Add(this.lblJuego);
            this.grbValoresActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValoresActuales.Location = new System.Drawing.Point(12, 38);
            this.grbValoresActuales.Name = "grbValoresActuales";
            this.grbValoresActuales.Size = new System.Drawing.Size(431, 130);
            this.grbValoresActuales.TabIndex = 3;
            this.grbValoresActuales.TabStop = false;
            this.grbValoresActuales.Text = "Datos del Juego";
            // 
            // lblTotalModulos
            // 
            this.lblTotalModulos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalModulos.Location = new System.Drawing.Point(11, 86);
            this.lblTotalModulos.Name = "lblTotalModulos";
            this.lblTotalModulos.Size = new System.Drawing.Size(149, 25);
            this.lblTotalModulos.TabIndex = 19;
            this.lblTotalModulos.Text = "Total Módulos en Juego";
            this.lblTotalModulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidadModulos
            // 
            this.txtCantidadModulos.Enabled = false;
            this.txtCantidadModulos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadModulos.Location = new System.Drawing.Point(301, 86);
            this.txtCantidadModulos.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCantidadModulos.Name = "txtCantidadModulos";
            this.txtCantidadModulos.Size = new System.Drawing.Size(100, 25);
            this.txtCantidadModulos.TabIndex = 20;
            this.txtCantidadModulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalCartones
            // 
            this.lblTotalCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCartones.Location = new System.Drawing.Point(11, 55);
            this.lblTotalCartones.Name = "lblTotalCartones";
            this.lblTotalCartones.Size = new System.Drawing.Size(149, 25);
            this.lblTotalCartones.TabIndex = 23;
            this.lblTotalCartones.Text = "Total Cartones en Juego";
            this.lblTotalCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(301, 55);
            this.txtCantidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 25);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // FrmGeneracionCartonesVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 186);
            this.Controls.Add(this.grbValoresActuales);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGeneracionCartonesVendidos";
            this.Text = "Generación Archivo Cartones Vendidos";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbValoresActuales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.GroupBox grbValoresActuales;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Label lblTotalModulos;
        private System.Windows.Forms.NumericUpDown txtCantidadModulos;
        private System.Windows.Forms.Label lblTotalCartones;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.ToolStripMenuItem ExportarToolStripMenuItem;
    }
}