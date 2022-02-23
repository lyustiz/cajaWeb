namespace Caja.Escritorio.Formularios.Caja
{
    partial class FrmGastosJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGastosJuego));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.grbRegistroGasto = new System.Windows.Forms.GroupBox();
            this.lblValorGasto = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.NumericUpDown();
            this.cmdSocios = new System.Windows.Forms.ComboBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.cmdConceptos = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grbHistorico = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdGastoJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuVentana.SuspendLayout();
            this.grbRegistroGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorGasto)).BeginInit();
            this.grbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(674, 24);
            this.menuVentana.TabIndex = 5;
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 33);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(646, 30);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "{ Nombre Usuario}";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbRegistroGasto
            // 
            this.grbRegistroGasto.Controls.Add(this.lblValorGasto);
            this.grbRegistroGasto.Controls.Add(this.txtValorGasto);
            this.grbRegistroGasto.Controls.Add(this.cmdSocios);
            this.grbRegistroGasto.Controls.Add(this.lblSocio);
            this.grbRegistroGasto.Controls.Add(this.cmdConceptos);
            this.grbRegistroGasto.Controls.Add(this.lblConcepto);
            this.grbRegistroGasto.Controls.Add(this.cmdProgramacion);
            this.grbRegistroGasto.Controls.Add(this.lblJuego);
            this.grbRegistroGasto.Controls.Add(this.txtDescripcion);
            this.grbRegistroGasto.Controls.Add(this.lblDescripcion);
            this.grbRegistroGasto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroGasto.Location = new System.Drawing.Point(12, 66);
            this.grbRegistroGasto.Name = "grbRegistroGasto";
            this.grbRegistroGasto.Size = new System.Drawing.Size(646, 242);
            this.grbRegistroGasto.TabIndex = 7;
            this.grbRegistroGasto.TabStop = false;
            this.grbRegistroGasto.Text = "Registro del Gasto";
            // 
            // lblValorGasto
            // 
            this.lblValorGasto.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGasto.Location = new System.Drawing.Point(398, 195);
            this.lblValorGasto.Name = "lblValorGasto";
            this.lblValorGasto.Size = new System.Drawing.Size(100, 25);
            this.lblValorGasto.TabIndex = 9;
            this.lblValorGasto.Text = "Valor Gasto";
            this.lblValorGasto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorGasto.Location = new System.Drawing.Point(508, 195);
            this.txtValorGasto.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(120, 29);
            this.txtValorGasto.TabIndex = 5;
            this.txtValorGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorGasto.ThousandsSeparator = true;
            // 
            // cmdSocios
            // 
            this.cmdSocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSocios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSocios.FormattingEnabled = true;
            this.cmdSocios.Location = new System.Drawing.Point(120, 166);
            this.cmdSocios.Name = "cmdSocios";
            this.cmdSocios.Size = new System.Drawing.Size(508, 23);
            this.cmdSocios.TabIndex = 4;
            // 
            // lblSocio
            // 
            this.lblSocio.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(6, 165);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(100, 25);
            this.lblSocio.TabIndex = 5;
            this.lblSocio.Text = "Socio";
            this.lblSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmdConceptos.SelectedIndexChanged += new System.EventHandler(this.cmdConceptos_SelectedIndexChanged);
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
            // grbHistorico
            // 
            this.grbHistorico.Controls.Add(this.Grilla);
            this.grbHistorico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHistorico.Location = new System.Drawing.Point(12, 314);
            this.grbHistorico.Name = "grbHistorico";
            this.grbHistorico.Size = new System.Drawing.Size(646, 242);
            this.grbHistorico.TabIndex = 10;
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
            this.IdGastoJuego,
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
            // IdGastoJuego
            // 
            this.IdGastoJuego.HeaderText = "IdGastoJuego";
            this.IdGastoJuego.Name = "IdGastoJuego";
            this.IdGastoJuego.ReadOnly = true;
            this.IdGastoJuego.Visible = false;
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
            // FrmGastosJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 567);
            this.Controls.Add(this.grbHistorico);
            this.Controls.Add(this.grbRegistroGasto);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGastosJuego";
            this.Text = "Registro de Gastos Adicionales por Juego";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbRegistroGasto.ResumeLayout(false);
            this.grbRegistroGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorGasto)).EndInit();
            this.grbHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.GroupBox grbRegistroGasto;
        internal System.Windows.Forms.ComboBox cmdSocios;
        private System.Windows.Forms.Label lblSocio;
        internal System.Windows.Forms.ComboBox cmdConceptos;
        private System.Windows.Forms.Label lblConcepto;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblValorGasto;
        private System.Windows.Forms.NumericUpDown txtValorGasto;
        private System.Windows.Forms.GroupBox grbHistorico;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGastoJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}