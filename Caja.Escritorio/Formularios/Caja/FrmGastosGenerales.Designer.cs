namespace Caja.Escritorio.Formularios.Caja
{
    partial class FrmGastosGenerales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGastosGenerales));
            this.grbHistorico = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdGastoGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbRegistroGasto = new System.Windows.Forms.GroupBox();
            this.dtpFechaRegsitro = new System.Windows.Forms.DateTimePicker();
            this.lblFecRegistro = new System.Windows.Forms.Label();
            this.lblValorGastoGeneral = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.NumericUpDown();
            this.cmdSocios = new System.Windows.Forms.ComboBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.cmdConceptos = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbOrigenRecursos = new System.Windows.Forms.GroupBox();
            this.rbSocial = new System.Windows.Forms.RadioButton();
            this.rbBancos = new System.Windows.Forms.RadioButton();
            this.rbCaja = new System.Windows.Forms.RadioButton();
            this.grbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbRegistroGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorGasto)).BeginInit();
            this.menuVentana.SuspendLayout();
            this.grbOrigenRecursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHistorico
            // 
            this.grbHistorico.Controls.Add(this.Grilla);
            this.grbHistorico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHistorico.Location = new System.Drawing.Point(7, 387);
            this.grbHistorico.Name = "grbHistorico";
            this.grbHistorico.Size = new System.Drawing.Size(646, 239);
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
            this.IdGastoGeneral,
            this.FechaRegistro,
            this.Usuario,
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
            // IdGastoGeneral
            // 
            this.IdGastoGeneral.HeaderText = "IdGastoGeneral";
            this.IdGastoGeneral.Name = "IdGastoGeneral";
            this.IdGastoGeneral.ReadOnly = true;
            this.IdGastoGeneral.Visible = false;
            // 
            // FechaRegistro
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = "-";
            this.FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 110;
            // 
            // Usuario
            // 
            this.Usuario.DividerWidth = 1;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 150;
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
            this.Valor.Width = 110;
            // 
            // grbRegistroGasto
            // 
            this.grbRegistroGasto.Controls.Add(this.dtpFechaRegsitro);
            this.grbRegistroGasto.Controls.Add(this.lblFecRegistro);
            this.grbRegistroGasto.Controls.Add(this.lblValorGastoGeneral);
            this.grbRegistroGasto.Controls.Add(this.txtValorGasto);
            this.grbRegistroGasto.Controls.Add(this.cmdSocios);
            this.grbRegistroGasto.Controls.Add(this.lblSocio);
            this.grbRegistroGasto.Controls.Add(this.cmdConceptos);
            this.grbRegistroGasto.Controls.Add(this.lblConcepto);
            this.grbRegistroGasto.Controls.Add(this.txtDescripcion);
            this.grbRegistroGasto.Controls.Add(this.lblDescripcion);
            this.grbRegistroGasto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroGasto.Location = new System.Drawing.Point(7, 65);
            this.grbRegistroGasto.Name = "grbRegistroGasto";
            this.grbRegistroGasto.Size = new System.Drawing.Size(646, 239);
            this.grbRegistroGasto.TabIndex = 13;
            this.grbRegistroGasto.TabStop = false;
            this.grbRegistroGasto.Text = "Registro del Gasto";
            // 
            // dtpFechaRegsitro
            // 
            this.dtpFechaRegsitro.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaRegsitro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegsitro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegsitro.Location = new System.Drawing.Point(508, 22);
            this.dtpFechaRegsitro.Name = "dtpFechaRegsitro";
            this.dtpFechaRegsitro.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaRegsitro.TabIndex = 10;
            this.dtpFechaRegsitro.ValueChanged += new System.EventHandler(this.dtpFechaRegsitro_ValueChanged);
            // 
            // lblFecRegistro
            // 
            this.lblFecRegistro.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecRegistro.Location = new System.Drawing.Point(390, 20);
            this.lblFecRegistro.Name = "lblFecRegistro";
            this.lblFecRegistro.Size = new System.Drawing.Size(108, 25);
            this.lblFecRegistro.TabIndex = 11;
            this.lblFecRegistro.Text = "Fecha Registro";
            this.lblFecRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorGastoGeneral
            // 
            this.lblValorGastoGeneral.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGastoGeneral.Location = new System.Drawing.Point(317, 195);
            this.lblValorGastoGeneral.Name = "lblValorGastoGeneral";
            this.lblValorGastoGeneral.Size = new System.Drawing.Size(181, 25);
            this.lblValorGastoGeneral.TabIndex = 9;
            this.lblValorGastoGeneral.Text = "Valor Gasto General";
            this.lblValorGastoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblNombreUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblNombreUsuario.Location = new System.Drawing.Point(7, 30);
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
            this.menuVentana.Size = new System.Drawing.Size(671, 24);
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
            // grbOrigenRecursos
            // 
            this.grbOrigenRecursos.Controls.Add(this.rbSocial);
            this.grbOrigenRecursos.Controls.Add(this.rbBancos);
            this.grbOrigenRecursos.Controls.Add(this.rbCaja);
            this.grbOrigenRecursos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrigenRecursos.Location = new System.Drawing.Point(7, 310);
            this.grbOrigenRecursos.Name = "grbOrigenRecursos";
            this.grbOrigenRecursos.Size = new System.Drawing.Size(646, 71);
            this.grbOrigenRecursos.TabIndex = 15;
            this.grbOrigenRecursos.TabStop = false;
            this.grbOrigenRecursos.Text = "Origen de los Recursos";
            // 
            // rbSocial
            // 
            this.rbSocial.AutoSize = true;
            this.rbSocial.Location = new System.Drawing.Point(394, 27);
            this.rbSocial.Name = "rbSocial";
            this.rbSocial.Size = new System.Drawing.Size(95, 17);
            this.rbSocial.TabIndex = 5;
            this.rbSocial.Text = "Ahorro Social";
            this.rbSocial.UseVisualStyleBackColor = true;
            // 
            // rbBancos
            // 
            this.rbBancos.AutoSize = true;
            this.rbBancos.Location = new System.Drawing.Point(273, 27);
            this.rbBancos.Name = "rbBancos";
            this.rbBancos.Size = new System.Drawing.Size(62, 17);
            this.rbBancos.TabIndex = 4;
            this.rbBancos.Text = "Bancos";
            this.rbBancos.UseVisualStyleBackColor = true;
            // 
            // rbCaja
            // 
            this.rbCaja.AutoSize = true;
            this.rbCaja.Checked = true;
            this.rbCaja.Location = new System.Drawing.Point(157, 27);
            this.rbCaja.Name = "rbCaja";
            this.rbCaja.Size = new System.Drawing.Size(47, 17);
            this.rbCaja.TabIndex = 3;
            this.rbCaja.TabStop = true;
            this.rbCaja.Text = "Caja";
            this.rbCaja.UseVisualStyleBackColor = true;
            // 
            // FrmGastosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 636);
            this.Controls.Add(this.grbOrigenRecursos);
            this.Controls.Add(this.grbHistorico);
            this.Controls.Add(this.grbRegistroGasto);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGastosGenerales";
            this.Text = "Registro de Gastos Generales";
            this.grbHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbRegistroGasto.ResumeLayout(false);
            this.grbRegistroGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorGasto)).EndInit();
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbOrigenRecursos.ResumeLayout(false);
            this.grbOrigenRecursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHistorico;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.GroupBox grbRegistroGasto;
        private System.Windows.Forms.Label lblValorGastoGeneral;
        private System.Windows.Forms.NumericUpDown txtValorGasto;
        internal System.Windows.Forms.ComboBox cmdSocios;
        private System.Windows.Forms.Label lblSocio;
        internal System.Windows.Forms.ComboBox cmdConceptos;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFechaRegsitro;
        private System.Windows.Forms.Label lblFecRegistro;
        private System.Windows.Forms.GroupBox grbOrigenRecursos;
        internal System.Windows.Forms.RadioButton rbSocial;
        internal System.Windows.Forms.RadioButton rbBancos;
        internal System.Windows.Forms.RadioButton rbCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGastoGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}