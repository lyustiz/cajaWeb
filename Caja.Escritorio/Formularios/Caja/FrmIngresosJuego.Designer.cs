namespace Caja.Escritorio.Formularios.Caja
{
    partial class FrmIngresosJuego
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresosJuego));
            this.grbHistorico = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdIngresoJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbRegistroIngreso = new System.Windows.Forms.GroupBox();
            this.lblValorIngreso = new System.Windows.Forms.Label();
            this.txtValorIngreso = new System.Windows.Forms.NumericUpDown();
            this.cmdConceptos = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbRegistroIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorIngreso)).BeginInit();
            this.menuVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHistorico
            // 
            this.grbHistorico.Controls.Add(this.Grilla);
            this.grbHistorico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHistorico.Location = new System.Drawing.Point(8, 280);
            this.grbHistorico.Name = "grbHistorico";
            this.grbHistorico.Size = new System.Drawing.Size(646, 242);
            this.grbHistorico.TabIndex = 14;
            this.grbHistorico.TabStop = false;
            this.grbHistorico.Text = "Registro Histórico";
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIngresoJuego,
            this.FechaHora,
            this.NombreUsuario,
            this.Concepto,
            this.Valor});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(9, 21);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(619, 206);
            this.Grilla.TabIndex = 6;
            // 
            // IdIngresoJuego
            // 
            this.IdIngresoJuego.HeaderText = "IdIngresoJuego";
            this.IdIngresoJuego.Name = "IdIngresoJuego";
            this.IdIngresoJuego.ReadOnly = true;
            this.IdIngresoJuego.Visible = false;
            // 
            // FechaHora
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = "-";
            this.FechaHora.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaHora.HeaderText = "Fecha Hora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DividerWidth = 1;
            this.NombreUsuario.HeaderText = "Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 150;
            // 
            // Concepto
            // 
            this.Concepto.DividerWidth = 1;
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 207;
            // 
            // Valor
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 120;
            // 
            // grbRegistroIngreso
            // 
            this.grbRegistroIngreso.Controls.Add(this.lblValorIngreso);
            this.grbRegistroIngreso.Controls.Add(this.txtValorIngreso);
            this.grbRegistroIngreso.Controls.Add(this.cmdConceptos);
            this.grbRegistroIngreso.Controls.Add(this.lblConcepto);
            this.grbRegistroIngreso.Controls.Add(this.cmdProgramacion);
            this.grbRegistroIngreso.Controls.Add(this.lblJuego);
            this.grbRegistroIngreso.Controls.Add(this.txtDescripcion);
            this.grbRegistroIngreso.Controls.Add(this.lblDescripcion);
            this.grbRegistroIngreso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroIngreso.Location = new System.Drawing.Point(8, 65);
            this.grbRegistroIngreso.Name = "grbRegistroIngreso";
            this.grbRegistroIngreso.Size = new System.Drawing.Size(646, 209);
            this.grbRegistroIngreso.TabIndex = 13;
            this.grbRegistroIngreso.TabStop = false;
            this.grbRegistroIngreso.Text = "Registro del Ingreso";
            // 
            // lblValorIngreso
            // 
            this.lblValorIngreso.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIngreso.Location = new System.Drawing.Point(382, 166);
            this.lblValorIngreso.Name = "lblValorIngreso";
            this.lblValorIngreso.Size = new System.Drawing.Size(116, 25);
            this.lblValorIngreso.TabIndex = 9;
            this.lblValorIngreso.Text = "Valor Ingreso";
            this.lblValorIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorIngreso
            // 
            this.txtValorIngreso.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorIngreso.Location = new System.Drawing.Point(508, 166);
            this.txtValorIngreso.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtValorIngreso.Name = "txtValorIngreso";
            this.txtValorIngreso.Size = new System.Drawing.Size(120, 29);
            this.txtValorIngreso.TabIndex = 5;
            this.txtValorIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorIngreso.ThousandsSeparator = true;
            // 
            // cmdConceptos
            // 
            this.cmdConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdConceptos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConceptos.FormattingEnabled = true;
            this.cmdConceptos.Location = new System.Drawing.Point(120, 51);
            this.cmdConceptos.Name = "cmdConceptos";
            this.cmdConceptos.Size = new System.Drawing.Size(508, 23);
            this.cmdConceptos.TabIndex = 2;
            // 
            // lblConcepto
            // 
            this.lblConcepto.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(6, 50);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(100, 25);
            this.lblConcepto.TabIndex = 3;
            this.lblConcepto.Text = "Concepto";
            this.lblConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(120, 21);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(265, 23);
            this.cmdProgramacion.TabIndex = 1;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdProgramacion_SelectedIndexChanged);
            // 
            // lblJuego
            // 
            this.lblJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(6, 20);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(100, 25);
            this.lblJuego.TabIndex = 0;
            this.lblJuego.Text = "Número Juego";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(120, 81);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(508, 79);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 25);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblNombreUsuario.Location = new System.Drawing.Point(8, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(646, 30);
            this.lblNombreUsuario.TabIndex = 12;
            this.lblNombreUsuario.Text = "{ Nombre Usuario}";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(667, 24);
            this.menuVentana.TabIndex = 11;
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // FrmIngresosJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 534);
            this.Controls.Add(this.grbHistorico);
            this.Controls.Add(this.grbRegistroIngreso);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresosJuego";
            this.Text = "Registro de Ingresos Adicionales por Juego";
            this.grbHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbRegistroIngreso.ResumeLayout(false);
            this.grbRegistroIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorIngreso)).EndInit();
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHistorico;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.GroupBox grbRegistroIngreso;
        private System.Windows.Forms.Label lblValorIngreso;
        private System.Windows.Forms.NumericUpDown txtValorIngreso;
        internal System.Windows.Forms.ComboBox cmdConceptos;
        private System.Windows.Forms.Label lblConcepto;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIngresoJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}