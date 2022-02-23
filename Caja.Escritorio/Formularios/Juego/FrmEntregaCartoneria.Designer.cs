namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmEntregaCartoneria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntregaCartoneria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBusquedaVendedor = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProgramacionJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosVendedor = new System.Windows.Forms.GroupBox();
            this.lblCartones = new System.Windows.Forms.Label();
            this.lblCortesia = new System.Windows.Forms.Label();
            this.txtCortesia = new System.Windows.Forms.NumericUpDown();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.txtCartones = new System.Windows.Forms.NumericUpDown();
            this.grbRegistroHojas = new System.Windows.Forms.GroupBox();
            this.lstHojas = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblHoja = new System.Windows.Forms.Label();
            this.txtHoja = new System.Windows.Forms.NumericUpDown();
            this.menuVentana.SuspendLayout();
            this.grbBusquedaVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbDatosVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCortesia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartones)).BeginInit();
            this.grbRegistroHojas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoja)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(803, 24);
            this.menuVentana.TabIndex = 3;
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir Planilla";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // grbBusquedaVendedor
            // 
            this.grbBusquedaVendedor.Controls.Add(this.Grilla);
            this.grbBusquedaVendedor.Controls.Add(this.cmdProgramacion);
            this.grbBusquedaVendedor.Controls.Add(this.lblJuego);
            this.grbBusquedaVendedor.Controls.Add(this.BtnBuscar);
            this.grbBusquedaVendedor.Controls.Add(this.txtFiltro);
            this.grbBusquedaVendedor.Controls.Add(this.lblTitulo);
            this.grbBusquedaVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaVendedor.Location = new System.Drawing.Point(7, 30);
            this.grbBusquedaVendedor.Name = "grbBusquedaVendedor";
            this.grbBusquedaVendedor.Size = new System.Drawing.Size(786, 244);
            this.grbBusquedaVendedor.TabIndex = 2;
            this.grbBusquedaVendedor.TabStop = false;
            this.grbBusquedaVendedor.Text = "Búsqueda Vendedor";
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
            this.IdVendedor,
            this.Codigo,
            this.Nombres,
            this.Apellidos,
            this.IdProgramacionJuego,
            this.CantidadHojas});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(9, 47);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(767, 187);
            this.Grilla.TabIndex = 190;
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellClick);
            // 
            // IdVendedor
            // 
            this.IdVendedor.HeaderText = "IdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.ReadOnly = true;
            this.IdVendedor.Visible = false;
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "-";
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.HeaderText = "Código Vendedor";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 130;
            // 
            // Nombres
            // 
            this.Nombres.DividerWidth = 1;
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 200;
            // 
            // Apellidos
            // 
            this.Apellidos.DividerWidth = 1;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 200;
            // 
            // IdProgramacionJuego
            // 
            this.IdProgramacionJuego.HeaderText = "Juego";
            this.IdProgramacionJuego.Name = "IdProgramacionJuego";
            this.IdProgramacionJuego.ReadOnly = true;
            // 
            // CantidadHojas
            // 
            this.CantidadHojas.DividerWidth = 1;
            this.CantidadHojas.HeaderText = "No. Hojas";
            this.CantidadHojas.Name = "CantidadHojas";
            this.CantidadHojas.ReadOnly = true;
            this.CantidadHojas.Width = 95;
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(616, 18);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(160, 23);
            this.cmdProgramacion.TabIndex = 5;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.CmdProgramacion_SelectedIndexChanged);
            // 
            // lblJuego
            // 
            this.lblJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(510, 18);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(100, 25);
            this.lblJuego.TabIndex = 4;
            this.lblJuego.Text = "Número Juego";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(399, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 25);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Filtrar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(128, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(265, 25);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(125, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Criterio de Búsqueda";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbDatosVendedor
            // 
            this.grbDatosVendedor.Controls.Add(this.lblCartones);
            this.grbDatosVendedor.Controls.Add(this.lblCortesia);
            this.grbDatosVendedor.Controls.Add(this.txtCortesia);
            this.grbDatosVendedor.Controls.Add(this.lblNombreVendedor);
            this.grbDatosVendedor.Controls.Add(this.txtCartones);
            this.grbDatosVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosVendedor.Location = new System.Drawing.Point(7, 280);
            this.grbDatosVendedor.Name = "grbDatosVendedor";
            this.grbDatosVendedor.Size = new System.Drawing.Size(468, 157);
            this.grbDatosVendedor.TabIndex = 1;
            this.grbDatosVendedor.TabStop = false;
            this.grbDatosVendedor.Text = "Datos del Vendedor";
            // 
            // lblCartones
            // 
            this.lblCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartones.Location = new System.Drawing.Point(9, 49);
            this.lblCartones.Name = "lblCartones";
            this.lblCartones.Size = new System.Drawing.Size(290, 40);
            this.lblCartones.TabIndex = 7;
            this.lblCartones.Text = "Total Cartones";
            this.lblCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCortesia
            // 
            this.lblCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCortesia.Location = new System.Drawing.Point(9, 102);
            this.lblCortesia.Name = "lblCortesia";
            this.lblCortesia.Size = new System.Drawing.Size(290, 40);
            this.lblCortesia.TabIndex = 9;
            this.lblCortesia.Text = "Cartones de Cortesía";
            this.lblCortesia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCortesia
            // 
            this.txtCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCortesia.Location = new System.Drawing.Point(305, 99);
            this.txtCortesia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCortesia.Name = "txtCortesia";
            this.txtCortesia.Size = new System.Drawing.Size(150, 47);
            this.txtCortesia.TabIndex = 10;
            this.txtCortesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Green;
            this.lblNombreVendedor.Location = new System.Drawing.Point(9, 14);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(446, 30);
            this.lblNombreVendedor.TabIndex = 6;
            this.lblNombreVendedor.Text = "{ Nombre Vendedor }";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCartones
            // 
            this.txtCartones.Enabled = false;
            this.txtCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartones.Location = new System.Drawing.Point(305, 46);
            this.txtCartones.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCartones.Name = "txtCartones";
            this.txtCartones.Size = new System.Drawing.Size(150, 47);
            this.txtCartones.TabIndex = 8;
            this.txtCartones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbRegistroHojas
            // 
            this.grbRegistroHojas.Controls.Add(this.lstHojas);
            this.grbRegistroHojas.Controls.Add(this.btnQuitar);
            this.grbRegistroHojas.Controls.Add(this.btnAgregar);
            this.grbRegistroHojas.Controls.Add(this.lblHoja);
            this.grbRegistroHojas.Controls.Add(this.txtHoja);
            this.grbRegistroHojas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroHojas.Location = new System.Drawing.Point(481, 280);
            this.grbRegistroHojas.Name = "grbRegistroHojas";
            this.grbRegistroHojas.Size = new System.Drawing.Size(312, 157);
            this.grbRegistroHojas.TabIndex = 0;
            this.grbRegistroHojas.TabStop = false;
            this.grbRegistroHojas.Text = "Registro de Hojas";
            // 
            // lstHojas
            // 
            this.lstHojas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHojas.FormattingEnabled = true;
            this.lstHojas.ItemHeight = 17;
            this.lstHojas.Location = new System.Drawing.Point(213, 12);
            this.lstHojas.Name = "lstHojas";
            this.lstHojas.Size = new System.Drawing.Size(93, 140);
            this.lstHojas.Sorted = true;
            this.lstHojas.TabIndex = 15;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(157, 94);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 30);
            this.btnQuitar.TabIndex = 14;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(157, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 30);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblHoja
            // 
            this.lblHoja.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoja.Location = new System.Drawing.Point(6, 23);
            this.lblHoja.Name = "lblHoja";
            this.lblHoja.Size = new System.Drawing.Size(145, 40);
            this.lblHoja.TabIndex = 11;
            this.lblHoja.Text = "Hoja";
            this.lblHoja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoja
            // 
            this.txtHoja.Font = new System.Drawing.Font("Segoe UI Semilight", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoja.Location = new System.Drawing.Point(6, 66);
            this.txtHoja.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(145, 52);
            this.txtHoja.TabIndex = 12;
            this.txtHoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHoja_KeyUp);
            // 
            // FrmEntregaCartoneria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 444);
            this.Controls.Add(this.grbRegistroHojas);
            this.Controls.Add(this.grbDatosVendedor);
            this.Controls.Add(this.grbBusquedaVendedor);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntregaCartoneria";
            this.Text = "Entrega Cartonería";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbBusquedaVendedor.ResumeLayout(false);
            this.grbBusquedaVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbDatosVendedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCortesia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartones)).EndInit();
            this.grbRegistroHojas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbBusquedaVendedor;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.GroupBox grbDatosVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.NumericUpDown txtCartones;
        private System.Windows.Forms.Label lblCartones;
        private System.Windows.Forms.Label lblCortesia;
        private System.Windows.Forms.NumericUpDown txtCortesia;
        private System.Windows.Forms.GroupBox grbRegistroHojas;
        private System.Windows.Forms.Label lblHoja;
        private System.Windows.Forms.NumericUpDown txtHoja;
        private System.Windows.Forms.ListBox lstHojas;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProgramacionJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHojas;
    }
}