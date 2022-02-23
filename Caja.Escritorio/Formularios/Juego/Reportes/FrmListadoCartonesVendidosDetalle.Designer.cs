
namespace Caja.Escritorio.Formularios.Juego.Reportes
{
    partial class FrmListadoCartonesVendidosDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCartonesVendidosDetalle));
            this.grbValoresActuales = new System.Windows.Forms.GroupBox();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.ExportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txCartonesValidos = new System.Windows.Forms.TextBox();
            this.txCartones = new System.Windows.Forms.TextBox();
            this.txHojasValidas = new System.Windows.Forms.TextBox();
            this.txHojas = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lstCartones = new System.Windows.Forms.ListBox();
            this.lstHojas = new System.Windows.Forms.ListBox();
            this.grbVendedores = new System.Windows.Forms.GroupBox();
            this.cmdVendedores = new System.Windows.Forms.ComboBox();
            this.grbValoresActuales.SuspendLayout();
            this.menuVentana.SuspendLayout();
            this.grbDetalle.SuspendLayout();
            this.grbVendedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbValoresActuales
            // 
            this.grbValoresActuales.Controls.Add(this.cmdProgramacion);
            this.grbValoresActuales.Controls.Add(this.lblJuego);
            this.grbValoresActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValoresActuales.Location = new System.Drawing.Point(12, 37);
            this.grbValoresActuales.Name = "grbValoresActuales";
            this.grbValoresActuales.Size = new System.Drawing.Size(275, 71);
            this.grbValoresActuales.TabIndex = 5;
            this.grbValoresActuales.TabStop = false;
            this.grbValoresActuales.Text = "Datos del Juego";
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(120, 18);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(140, 23);
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
            this.ExportarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(597, 24);
            this.menuVentana.TabIndex = 4;
            // 
            // ExportarToolStripMenuItem
            // 
            this.ExportarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExportarToolStripMenuItem.Image")));
            this.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem";
            this.ExportarToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ExportarToolStripMenuItem.Text = "Exportar";
            this.ExportarToolStripMenuItem.Click += new System.EventHandler(this.ExportarToolStripMenuItem_Click);
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.Label2);
            this.grbDetalle.Controls.Add(this.Label1);
            this.grbDetalle.Controls.Add(this.txCartonesValidos);
            this.grbDetalle.Controls.Add(this.txCartones);
            this.grbDetalle.Controls.Add(this.txHojasValidas);
            this.grbDetalle.Controls.Add(this.txHojas);
            this.grbDetalle.Controls.Add(this.Label10);
            this.grbDetalle.Controls.Add(this.Label8);
            this.grbDetalle.Controls.Add(this.Label5);
            this.grbDetalle.Controls.Add(this.Label3);
            this.grbDetalle.Controls.Add(this.lstCartones);
            this.grbDetalle.Controls.Add(this.lstHojas);
            this.grbDetalle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalle.Location = new System.Drawing.Point(12, 114);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(565, 176);
            this.grbDetalle.TabIndex = 6;
            this.grbDetalle.TabStop = false;
            this.grbDetalle.Text = "Detalle";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold);
            this.Label2.Location = new System.Drawing.Point(103, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 17);
            this.Label2.TabIndex = 59;
            this.Label2.Text = "Cartones";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(9, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 17);
            this.Label1.TabIndex = 58;
            this.Label1.Text = "Hojas";
            // 
            // txCartonesValidos
            // 
            this.txCartonesValidos.Location = new System.Drawing.Point(482, 140);
            this.txCartonesValidos.Name = "txCartonesValidos";
            this.txCartonesValidos.Size = new System.Drawing.Size(77, 22);
            this.txCartonesValidos.TabIndex = 57;
            this.txCartonesValidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txCartones
            // 
            this.txCartones.Location = new System.Drawing.Point(482, 114);
            this.txCartones.Name = "txCartones";
            this.txCartones.Size = new System.Drawing.Size(77, 22);
            this.txCartones.TabIndex = 56;
            this.txCartones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txHojasValidas
            // 
            this.txHojasValidas.Location = new System.Drawing.Point(482, 69);
            this.txHojasValidas.Name = "txHojasValidas";
            this.txHojasValidas.Size = new System.Drawing.Size(77, 22);
            this.txHojasValidas.TabIndex = 55;
            this.txHojasValidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txHojas
            // 
            this.txHojas.Location = new System.Drawing.Point(482, 45);
            this.txHojas.Name = "txHojas";
            this.txHojas.Size = new System.Drawing.Size(77, 22);
            this.txHojas.TabIndex = 54;
            this.txHojas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Label10.Location = new System.Drawing.Point(274, 142);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(128, 17);
            this.Label10.TabIndex = 53;
            this.Label10.Text = "Total cartones validas";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Label8.Location = new System.Drawing.Point(274, 116);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(152, 17);
            this.Label8.TabIndex = 52;
            this.Label8.Text = "Total cartones entregadas";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Label5.Location = new System.Drawing.Point(274, 67);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(112, 17);
            this.Label5.TabIndex = 51;
            this.Label5.Text = "Total Hojas validas";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Label3.Location = new System.Drawing.Point(274, 43);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 17);
            this.Label3.TabIndex = 50;
            this.Label3.Text = "Total Hojas entregadas";
            // 
            // lstCartones
            // 
            this.lstCartones.FormattingEnabled = true;
            this.lstCartones.Location = new System.Drawing.Point(101, 41);
            this.lstCartones.Name = "lstCartones";
            this.lstCartones.Size = new System.Drawing.Size(167, 121);
            this.lstCartones.TabIndex = 49;
            // 
            // lstHojas
            // 
            this.lstHojas.FormattingEnabled = true;
            this.lstHojas.Location = new System.Drawing.Point(6, 41);
            this.lstHojas.Name = "lstHojas";
            this.lstHojas.Size = new System.Drawing.Size(89, 121);
            this.lstHojas.TabIndex = 48;
            // 
            // grbVendedores
            // 
            this.grbVendedores.Controls.Add(this.cmdVendedores);
            this.grbVendedores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVendedores.Location = new System.Drawing.Point(302, 37);
            this.grbVendedores.Name = "grbVendedores";
            this.grbVendedores.Size = new System.Drawing.Size(275, 71);
            this.grbVendedores.TabIndex = 6;
            this.grbVendedores.TabStop = false;
            this.grbVendedores.Text = "Listado de Vendedores";
            // 
            // cmdVendedores
            // 
            this.cmdVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdVendedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVendedores.FormattingEnabled = true;
            this.cmdVendedores.Location = new System.Drawing.Point(6, 18);
            this.cmdVendedores.Name = "cmdVendedores";
            this.cmdVendedores.Size = new System.Drawing.Size(254, 23);
            this.cmdVendedores.TabIndex = 2;
            this.cmdVendedores.SelectedIndexChanged += new System.EventHandler(this.cmdVendedores_SelectedIndexChanged);
            // 
            // FrmListadoCartonesVendidosDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 303);
            this.Controls.Add(this.grbVendedores);
            this.Controls.Add(this.grbDetalle);
            this.Controls.Add(this.grbValoresActuales);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoCartonesVendidosDetalle";
            this.Text = "Listado de Cartones Vendidos Detalle";
            this.grbValoresActuales.ResumeLayout(false);
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            this.grbVendedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbValoresActuales;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem ExportarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbDetalle;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txCartonesValidos;
        internal System.Windows.Forms.TextBox txCartones;
        internal System.Windows.Forms.TextBox txHojasValidas;
        internal System.Windows.Forms.TextBox txHojas;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox lstCartones;
        internal System.Windows.Forms.ListBox lstHojas;
        private System.Windows.Forms.GroupBox grbVendedores;
        internal System.Windows.Forms.ComboBox cmdVendedores;
    }
}