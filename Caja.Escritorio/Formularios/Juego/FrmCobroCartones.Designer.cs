namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmCobroCartones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobroCartones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBusquedaVendedor = new System.Windows.Forms.GroupBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.BtnRecibirCartones = new System.Windows.Forms.Button();
            this.BtnRecalcular = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbResumenVendedor = new System.Windows.Forms.GroupBox();
            this.txResumenTotalRecibido = new System.Windows.Forms.TextBox();
            this.txResumenTotalPagar = new System.Windows.Forms.TextBox();
            this.txResumenGastosCortesia = new System.Windows.Forms.TextBox();
            this.txResumenAbonos = new System.Windows.Forms.TextBox();
            this.txResumenValorComision = new System.Windows.Forms.TextBox();
            this.txResumenFaltante = new System.Windows.Forms.TextBox();
            this.txResumenTotalVentas = new System.Windows.Forms.TextBox();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.lblFaltante = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblGastoCortesiaResumen = new System.Windows.Forms.Label();
            this.lblAbonos = new System.Windows.Forms.Label();
            this.lblValorComision = new System.Windows.Forms.Label();
            this.txResumenCartonesDevueltos = new System.Windows.Forms.NumericUpDown();
            this.lblCartonesDeveltosResumen = new System.Windows.Forms.Label();
            this.txResumenCartonesCortesia = new System.Windows.Forms.NumericUpDown();
            this.lblCartonesCortesiaResumen = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.grbModulos = new System.Windows.Forms.GroupBox();
            this.lblInfoModulos = new System.Windows.Forms.Label();
            this.txResumenTotalCartonesEfectivos = new System.Windows.Forms.NumericUpDown();
            this.lblCartonesEfectivos = new System.Windows.Forms.Label();
            this.txtResumenTotalCartones = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCartones = new System.Windows.Forms.Label();
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.txtRegistroGastosCortesia = new System.Windows.Forms.NumericUpDown();
            this.lblGastosCortesia = new System.Windows.Forms.Label();
            this.txtRegistroCartonesCortesia = new System.Windows.Forms.NumericUpDown();
            this.lblCartonesCortesia = new System.Windows.Forms.Label();
            this.txtRegistroPorcentajaComision = new System.Windows.Forms.NumericUpDown();
            this.lblPorcentajeComision = new System.Windows.Forms.Label();
            this.txtRegistroHojasDevueltas = new System.Windows.Forms.NumericUpDown();
            this.lblHojasEntregadas = new System.Windows.Forms.Label();
            this.txtRegistroCartonesDevueltos = new System.Windows.Forms.NumericUpDown();
            this.lblCartonesDevueltos = new System.Windows.Forms.Label();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuVentana.SuspendLayout();
            this.grbBusquedaVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbResumenVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txResumenCartonesDevueltos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txResumenCartonesCortesia)).BeginInit();
            this.grbModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txResumenTotalCartonesEfectivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResumenTotalCartones)).BeginInit();
            this.grbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroGastosCortesia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroCartonesCortesia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroPorcentajaComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroHojasDevueltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroCartonesDevueltos)).BeginInit();
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
            this.menuVentana.Size = new System.Drawing.Size(1073, 24);
            this.menuVentana.TabIndex = 4;
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
            this.grbBusquedaVendedor.Controls.Add(this.lblNombreVendedor);
            this.grbBusquedaVendedor.Controls.Add(this.BtnRecibirCartones);
            this.grbBusquedaVendedor.Controls.Add(this.BtnRecalcular);
            this.grbBusquedaVendedor.Controls.Add(this.Grilla);
            this.grbBusquedaVendedor.Controls.Add(this.cmdProgramacion);
            this.grbBusquedaVendedor.Controls.Add(this.lblJuego);
            this.grbBusquedaVendedor.Controls.Add(this.BtnBuscar);
            this.grbBusquedaVendedor.Controls.Add(this.txtFiltro);
            this.grbBusquedaVendedor.Controls.Add(this.lblTitulo);
            this.grbBusquedaVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaVendedor.Location = new System.Drawing.Point(7, 28);
            this.grbBusquedaVendedor.Name = "grbBusquedaVendedor";
            this.grbBusquedaVendedor.Size = new System.Drawing.Size(666, 361);
            this.grbBusquedaVendedor.TabIndex = 0;
            this.grbBusquedaVendedor.TabStop = false;
            this.grbBusquedaVendedor.Text = "Búsqueda Vendedor";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Green;
            this.lblNombreVendedor.Location = new System.Drawing.Point(6, 86);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(446, 30);
            this.lblNombreVendedor.TabIndex = 0;
            this.lblNombreVendedor.Text = "{ Nombre Vendedor }";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRecibirCartones
            // 
            this.BtnRecibirCartones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRecibirCartones.BackColor = System.Drawing.Color.Olive;
            this.BtnRecibirCartones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRecibirCartones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecibirCartones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRecibirCartones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecibirCartones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRecibirCartones.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecibirCartones.Image")));
            this.BtnRecibirCartones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecibirCartones.Location = new System.Drawing.Point(516, 21);
            this.BtnRecibirCartones.Name = "BtnRecibirCartones";
            this.BtnRecibirCartones.Size = new System.Drawing.Size(135, 25);
            this.BtnRecibirCartones.TabIndex = 0;
            this.BtnRecibirCartones.Text = "Recibir Cartones";
            this.BtnRecibirCartones.UseVisualStyleBackColor = false;
            this.BtnRecibirCartones.Click += new System.EventHandler(this.BtnRecibirCartones_Click);
            // 
            // BtnRecalcular
            // 
            this.BtnRecalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRecalcular.BackColor = System.Drawing.Color.Olive;
            this.BtnRecalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRecalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRecalcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecalcular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRecalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecalcular.Image")));
            this.BtnRecalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecalcular.Location = new System.Drawing.Point(516, 56);
            this.BtnRecalcular.Name = "BtnRecalcular";
            this.BtnRecalcular.Size = new System.Drawing.Size(135, 25);
            this.BtnRecalcular.TabIndex = 0;
            this.BtnRecalcular.Text = "Re-Calcular";
            this.BtnRecalcular.UseVisualStyleBackColor = false;
            this.BtnRecalcular.Click += new System.EventHandler(this.BtnRecalcular_Click);
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
            this.Documento,
            this.Cobrado});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(9, 121);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(642, 234);
            this.Grilla.TabIndex = 0;
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellClick);
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(128, 24);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(265, 23);
            this.cmdProgramacion.TabIndex = 1;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdProgramacion_SelectedIndexChanged);
            // 
            // lblJuego
            // 
            this.lblJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(6, 21);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(100, 25);
            this.lblJuego.TabIndex = 0;
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
            this.BtnBuscar.Location = new System.Drawing.Point(397, 56);
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
            this.txtFiltro.Location = new System.Drawing.Point(128, 55);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(265, 25);
            this.txtFiltro.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(125, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Criterio de Búsqueda";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbResumenVendedor
            // 
            this.grbResumenVendedor.Controls.Add(this.txResumenTotalRecibido);
            this.grbResumenVendedor.Controls.Add(this.txResumenTotalPagar);
            this.grbResumenVendedor.Controls.Add(this.txResumenGastosCortesia);
            this.grbResumenVendedor.Controls.Add(this.txResumenAbonos);
            this.grbResumenVendedor.Controls.Add(this.txResumenValorComision);
            this.grbResumenVendedor.Controls.Add(this.txResumenFaltante);
            this.grbResumenVendedor.Controls.Add(this.txResumenTotalVentas);
            this.grbResumenVendedor.Controls.Add(this.lblRecibido);
            this.grbResumenVendedor.Controls.Add(this.lblFaltante);
            this.grbResumenVendedor.Controls.Add(this.lblTotalPagar);
            this.grbResumenVendedor.Controls.Add(this.lblGastoCortesiaResumen);
            this.grbResumenVendedor.Controls.Add(this.lblAbonos);
            this.grbResumenVendedor.Controls.Add(this.lblValorComision);
            this.grbResumenVendedor.Controls.Add(this.txResumenCartonesDevueltos);
            this.grbResumenVendedor.Controls.Add(this.lblCartonesDeveltosResumen);
            this.grbResumenVendedor.Controls.Add(this.txResumenCartonesCortesia);
            this.grbResumenVendedor.Controls.Add(this.lblCartonesCortesiaResumen);
            this.grbResumenVendedor.Controls.Add(this.lblTotalVentas);
            this.grbResumenVendedor.Controls.Add(this.grbModulos);
            this.grbResumenVendedor.Controls.Add(this.txResumenTotalCartonesEfectivos);
            this.grbResumenVendedor.Controls.Add(this.lblCartonesEfectivos);
            this.grbResumenVendedor.Controls.Add(this.txtResumenTotalCartones);
            this.grbResumenVendedor.Controls.Add(this.lblTotalCartones);
            this.grbResumenVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResumenVendedor.Location = new System.Drawing.Point(679, 28);
            this.grbResumenVendedor.Name = "grbResumenVendedor";
            this.grbResumenVendedor.Size = new System.Drawing.Size(382, 556);
            this.grbResumenVendedor.TabIndex = 0;
            this.grbResumenVendedor.TabStop = false;
            this.grbResumenVendedor.Text = "Resumen del vendedor";
            // 
            // txResumenTotalRecibido
            // 
            this.txResumenTotalRecibido.Enabled = false;
            this.txResumenTotalRecibido.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenTotalRecibido.Location = new System.Drawing.Point(227, 511);
            this.txResumenTotalRecibido.Name = "txResumenTotalRecibido";
            this.txResumenTotalRecibido.Size = new System.Drawing.Size(140, 39);
            this.txResumenTotalRecibido.TabIndex = 52;
            this.txResumenTotalRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txResumenTotalPagar
            // 
            this.txResumenTotalPagar.Enabled = false;
            this.txResumenTotalPagar.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenTotalPagar.Location = new System.Drawing.Point(227, 395);
            this.txResumenTotalPagar.Name = "txResumenTotalPagar";
            this.txResumenTotalPagar.Size = new System.Drawing.Size(140, 34);
            this.txResumenTotalPagar.TabIndex = 51;
            this.txResumenTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txResumenGastosCortesia
            // 
            this.txResumenGastosCortesia.Enabled = false;
            this.txResumenGastosCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenGastosCortesia.Location = new System.Drawing.Point(227, 355);
            this.txResumenGastosCortesia.Name = "txResumenGastosCortesia";
            this.txResumenGastosCortesia.Size = new System.Drawing.Size(140, 34);
            this.txResumenGastosCortesia.TabIndex = 50;
            this.txResumenGastosCortesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txResumenAbonos
            // 
            this.txResumenAbonos.Enabled = false;
            this.txResumenAbonos.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenAbonos.Location = new System.Drawing.Point(227, 315);
            this.txResumenAbonos.Name = "txResumenAbonos";
            this.txResumenAbonos.Size = new System.Drawing.Size(140, 34);
            this.txResumenAbonos.TabIndex = 49;
            this.txResumenAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txResumenValorComision
            // 
            this.txResumenValorComision.Enabled = false;
            this.txResumenValorComision.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenValorComision.Location = new System.Drawing.Point(227, 275);
            this.txResumenValorComision.Name = "txResumenValorComision";
            this.txResumenValorComision.Size = new System.Drawing.Size(140, 34);
            this.txResumenValorComision.TabIndex = 48;
            this.txResumenValorComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txResumenFaltante
            // 
            this.txResumenFaltante.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenFaltante.Location = new System.Drawing.Point(227, 435);
            this.txResumenFaltante.Name = "txResumenFaltante";
            this.txResumenFaltante.Size = new System.Drawing.Size(140, 34);
            this.txResumenFaltante.TabIndex = 47;
            this.txResumenFaltante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txResumenTotalVentas
            // 
            this.txResumenTotalVentas.Enabled = false;
            this.txResumenTotalVentas.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenTotalVentas.Location = new System.Drawing.Point(227, 155);
            this.txResumenTotalVentas.Name = "txResumenTotalVentas";
            this.txResumenTotalVentas.Size = new System.Drawing.Size(140, 34);
            this.txResumenTotalVentas.TabIndex = 4;
            this.txResumenTotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecibido
            // 
            this.lblRecibido.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibido.Location = new System.Drawing.Point(15, 475);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(352, 34);
            this.lblRecibido.TabIndex = 46;
            this.lblRecibido.Text = "TOTAL RECIBIDO";
            this.lblRecibido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaltante
            // 
            this.lblFaltante.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltante.Location = new System.Drawing.Point(15, 435);
            this.lblFaltante.Name = "lblFaltante";
            this.lblFaltante.Size = new System.Drawing.Size(206, 34);
            this.lblFaltante.TabIndex = 44;
            this.lblFaltante.Text = "Faltante";
            this.lblFaltante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(15, 395);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(206, 34);
            this.lblTotalPagar.TabIndex = 42;
            this.lblTotalPagar.Text = "TOTAL A PAGAR";
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGastoCortesiaResumen
            // 
            this.lblGastoCortesiaResumen.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoCortesiaResumen.Location = new System.Drawing.Point(15, 355);
            this.lblGastoCortesiaResumen.Name = "lblGastoCortesiaResumen";
            this.lblGastoCortesiaResumen.Size = new System.Drawing.Size(206, 34);
            this.lblGastoCortesiaResumen.TabIndex = 40;
            this.lblGastoCortesiaResumen.Text = "Gasto Cortesia";
            this.lblGastoCortesiaResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAbonos
            // 
            this.lblAbonos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonos.Location = new System.Drawing.Point(15, 315);
            this.lblAbonos.Name = "lblAbonos";
            this.lblAbonos.Size = new System.Drawing.Size(206, 34);
            this.lblAbonos.TabIndex = 38;
            this.lblAbonos.Text = "Abonos";
            this.lblAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorComision
            // 
            this.lblValorComision.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorComision.Location = new System.Drawing.Point(15, 275);
            this.lblValorComision.Name = "lblValorComision";
            this.lblValorComision.Size = new System.Drawing.Size(206, 34);
            this.lblValorComision.TabIndex = 36;
            this.lblValorComision.Text = "Valor Comisión";
            this.lblValorComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txResumenCartonesDevueltos
            // 
            this.txResumenCartonesDevueltos.Enabled = false;
            this.txResumenCartonesDevueltos.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenCartonesDevueltos.Location = new System.Drawing.Point(227, 235);
            this.txResumenCartonesDevueltos.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txResumenCartonesDevueltos.Name = "txResumenCartonesDevueltos";
            this.txResumenCartonesDevueltos.Size = new System.Drawing.Size(140, 34);
            this.txResumenCartonesDevueltos.TabIndex = 33;
            this.txResumenCartonesDevueltos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCartonesDeveltosResumen
            // 
            this.lblCartonesDeveltosResumen.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonesDeveltosResumen.Location = new System.Drawing.Point(15, 235);
            this.lblCartonesDeveltosResumen.Name = "lblCartonesDeveltosResumen";
            this.lblCartonesDeveltosResumen.Size = new System.Drawing.Size(206, 34);
            this.lblCartonesDeveltosResumen.TabIndex = 34;
            this.lblCartonesDeveltosResumen.Text = "Cartones Devueltos";
            this.lblCartonesDeveltosResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txResumenCartonesCortesia
            // 
            this.txResumenCartonesCortesia.Enabled = false;
            this.txResumenCartonesCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenCartonesCortesia.Location = new System.Drawing.Point(227, 195);
            this.txResumenCartonesCortesia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txResumenCartonesCortesia.Name = "txResumenCartonesCortesia";
            this.txResumenCartonesCortesia.Size = new System.Drawing.Size(140, 34);
            this.txResumenCartonesCortesia.TabIndex = 31;
            this.txResumenCartonesCortesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCartonesCortesiaResumen
            // 
            this.lblCartonesCortesiaResumen.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonesCortesiaResumen.Location = new System.Drawing.Point(15, 195);
            this.lblCartonesCortesiaResumen.Name = "lblCartonesCortesiaResumen";
            this.lblCartonesCortesiaResumen.Size = new System.Drawing.Size(206, 34);
            this.lblCartonesCortesiaResumen.TabIndex = 32;
            this.lblCartonesCortesiaResumen.Text = "Cartones Cortesia";
            this.lblCartonesCortesiaResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(15, 155);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(206, 34);
            this.lblTotalVentas.TabIndex = 30;
            this.lblTotalVentas.Text = "Total Ventas";
            this.lblTotalVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbModulos
            // 
            this.grbModulos.Controls.Add(this.lblInfoModulos);
            this.grbModulos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModulos.Location = new System.Drawing.Point(6, 94);
            this.grbModulos.Name = "grbModulos";
            this.grbModulos.Size = new System.Drawing.Size(370, 58);
            this.grbModulos.TabIndex = 28;
            this.grbModulos.TabStop = false;
            this.grbModulos.Text = "Módulos";
            // 
            // lblInfoModulos
            // 
            this.lblInfoModulos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoModulos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInfoModulos.Location = new System.Drawing.Point(15, 20);
            this.lblInfoModulos.Name = "lblInfoModulos";
            this.lblInfoModulos.Size = new System.Drawing.Size(346, 34);
            this.lblInfoModulos.TabIndex = 25;
            this.lblInfoModulos.Text = "Cantidad: {0} Valor: {$ 0.0}";
            this.lblInfoModulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txResumenTotalCartonesEfectivos
            // 
            this.txResumenTotalCartonesEfectivos.Enabled = false;
            this.txResumenTotalCartonesEfectivos.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txResumenTotalCartonesEfectivos.Location = new System.Drawing.Point(227, 57);
            this.txResumenTotalCartonesEfectivos.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txResumenTotalCartonesEfectivos.Name = "txResumenTotalCartonesEfectivos";
            this.txResumenTotalCartonesEfectivos.Size = new System.Drawing.Size(140, 34);
            this.txResumenTotalCartonesEfectivos.TabIndex = 26;
            this.txResumenTotalCartonesEfectivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCartonesEfectivos
            // 
            this.lblCartonesEfectivos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonesEfectivos.Location = new System.Drawing.Point(15, 57);
            this.lblCartonesEfectivos.Name = "lblCartonesEfectivos";
            this.lblCartonesEfectivos.Size = new System.Drawing.Size(206, 34);
            this.lblCartonesEfectivos.TabIndex = 27;
            this.lblCartonesEfectivos.Text = "Total Cartones Efectivos";
            this.lblCartonesEfectivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResumenTotalCartones
            // 
            this.txtResumenTotalCartones.Enabled = false;
            this.txtResumenTotalCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumenTotalCartones.Location = new System.Drawing.Point(227, 20);
            this.txtResumenTotalCartones.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtResumenTotalCartones.Name = "txtResumenTotalCartones";
            this.txtResumenTotalCartones.Size = new System.Drawing.Size(140, 34);
            this.txtResumenTotalCartones.TabIndex = 24;
            this.txtResumenTotalCartones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalCartones
            // 
            this.lblTotalCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCartones.Location = new System.Drawing.Point(15, 20);
            this.lblTotalCartones.Name = "lblTotalCartones";
            this.lblTotalCartones.Size = new System.Drawing.Size(206, 34);
            this.lblTotalCartones.TabIndex = 25;
            this.lblTotalCartones.Text = "Total Cartones";
            this.lblTotalCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbRegistro
            // 
            this.grbRegistro.Controls.Add(this.txtRegistroGastosCortesia);
            this.grbRegistro.Controls.Add(this.lblGastosCortesia);
            this.grbRegistro.Controls.Add(this.txtRegistroCartonesCortesia);
            this.grbRegistro.Controls.Add(this.lblCartonesCortesia);
            this.grbRegistro.Controls.Add(this.txtRegistroPorcentajaComision);
            this.grbRegistro.Controls.Add(this.lblPorcentajeComision);
            this.grbRegistro.Controls.Add(this.txtRegistroHojasDevueltas);
            this.grbRegistro.Controls.Add(this.lblHojasEntregadas);
            this.grbRegistro.Controls.Add(this.txtRegistroCartonesDevueltos);
            this.grbRegistro.Controls.Add(this.lblCartonesDevueltos);
            this.grbRegistro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistro.Location = new System.Drawing.Point(7, 395);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Size = new System.Drawing.Size(666, 189);
            this.grbRegistro.TabIndex = 0;
            this.grbRegistro.TabStop = false;
            this.grbRegistro.Text = "Registro";
            // 
            // txtRegistroGastosCortesia
            // 
            this.txtRegistroGastosCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroGastosCortesia.Location = new System.Drawing.Point(511, 62);
            this.txtRegistroGastosCortesia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtRegistroGastosCortesia.Name = "txtRegistroGastosCortesia";
            this.txtRegistroGastosCortesia.Size = new System.Drawing.Size(140, 34);
            this.txtRegistroGastosCortesia.TabIndex = 22;
            this.txtRegistroGastosCortesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGastosCortesia
            // 
            this.lblGastosCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosCortesia.Location = new System.Drawing.Point(348, 61);
            this.lblGastosCortesia.Name = "lblGastosCortesia";
            this.lblGastosCortesia.Size = new System.Drawing.Size(149, 34);
            this.lblGastosCortesia.TabIndex = 23;
            this.lblGastosCortesia.Text = "Gastos Cortesia";
            this.lblGastosCortesia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistroCartonesCortesia
            // 
            this.txtRegistroCartonesCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroCartonesCortesia.Location = new System.Drawing.Point(511, 22);
            this.txtRegistroCartonesCortesia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtRegistroCartonesCortesia.Name = "txtRegistroCartonesCortesia";
            this.txtRegistroCartonesCortesia.Size = new System.Drawing.Size(140, 34);
            this.txtRegistroCartonesCortesia.TabIndex = 20;
            this.txtRegistroCartonesCortesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCartonesCortesia
            // 
            this.lblCartonesCortesia.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonesCortesia.Location = new System.Drawing.Point(348, 21);
            this.lblCartonesCortesia.Name = "lblCartonesCortesia";
            this.lblCartonesCortesia.Size = new System.Drawing.Size(149, 34);
            this.lblCartonesCortesia.TabIndex = 21;
            this.lblCartonesCortesia.Text = "Cartones Cortesia";
            this.lblCartonesCortesia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistroPorcentajaComision
            // 
            this.txtRegistroPorcentajaComision.Enabled = false;
            this.txtRegistroPorcentajaComision.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroPorcentajaComision.Location = new System.Drawing.Point(197, 101);
            this.txtRegistroPorcentajaComision.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtRegistroPorcentajaComision.Name = "txtRegistroPorcentajaComision";
            this.txtRegistroPorcentajaComision.Size = new System.Drawing.Size(140, 34);
            this.txtRegistroPorcentajaComision.TabIndex = 18;
            this.txtRegistroPorcentajaComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentajeComision
            // 
            this.lblPorcentajeComision.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeComision.Location = new System.Drawing.Point(11, 101);
            this.lblPorcentajeComision.Name = "lblPorcentajeComision";
            this.lblPorcentajeComision.Size = new System.Drawing.Size(180, 34);
            this.lblPorcentajeComision.TabIndex = 19;
            this.lblPorcentajeComision.Text = "Porcentaje Comisión";
            this.lblPorcentajeComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistroHojasDevueltas
            // 
            this.txtRegistroHojasDevueltas.Enabled = false;
            this.txtRegistroHojasDevueltas.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroHojasDevueltas.Location = new System.Drawing.Point(197, 61);
            this.txtRegistroHojasDevueltas.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtRegistroHojasDevueltas.Name = "txtRegistroHojasDevueltas";
            this.txtRegistroHojasDevueltas.Size = new System.Drawing.Size(140, 34);
            this.txtRegistroHojasDevueltas.TabIndex = 16;
            this.txtRegistroHojasDevueltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHojasEntregadas
            // 
            this.lblHojasEntregadas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHojasEntregadas.Location = new System.Drawing.Point(11, 62);
            this.lblHojasEntregadas.Name = "lblHojasEntregadas";
            this.lblHojasEntregadas.Size = new System.Drawing.Size(180, 34);
            this.lblHojasEntregadas.TabIndex = 17;
            this.lblHojasEntregadas.Text = "No. Hojas Entregadas";
            this.lblHojasEntregadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistroCartonesDevueltos
            // 
            this.txtRegistroCartonesDevueltos.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroCartonesDevueltos.Location = new System.Drawing.Point(197, 21);
            this.txtRegistroCartonesDevueltos.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtRegistroCartonesDevueltos.Name = "txtRegistroCartonesDevueltos";
            this.txtRegistroCartonesDevueltos.Size = new System.Drawing.Size(140, 34);
            this.txtRegistroCartonesDevueltos.TabIndex = 14;
            this.txtRegistroCartonesDevueltos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCartonesDevueltos
            // 
            this.lblCartonesDevueltos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonesDevueltos.Location = new System.Drawing.Point(11, 22);
            this.lblCartonesDevueltos.Name = "lblCartonesDevueltos";
            this.lblCartonesDevueltos.Size = new System.Drawing.Size(180, 34);
            this.lblCartonesDevueltos.TabIndex = 15;
            this.lblCartonesDevueltos.Text = "Cartones Devueltos";
            this.lblCartonesDevueltos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
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
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 120;
            // 
            // Cobrado
            // 
            this.Cobrado.HeaderText = "Cobrado";
            this.Cobrado.Name = "Cobrado";
            this.Cobrado.ReadOnly = true;
            this.Cobrado.Visible = false;
            // 
            // FrmCobroCartones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 591);
            this.Controls.Add(this.grbRegistro);
            this.Controls.Add(this.grbResumenVendedor);
            this.Controls.Add(this.grbBusquedaVendedor);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCobroCartones";
            this.Text = "Cobro de Cartones";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbBusquedaVendedor.ResumeLayout(false);
            this.grbBusquedaVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbResumenVendedor.ResumeLayout(false);
            this.grbResumenVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txResumenCartonesDevueltos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txResumenCartonesCortesia)).EndInit();
            this.grbModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txResumenTotalCartonesEfectivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResumenTotalCartones)).EndInit();
            this.grbRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroGastosCortesia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroCartonesCortesia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroPorcentajaComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroHojasDevueltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroCartonesDevueltos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbBusquedaVendedor;
        internal System.Windows.Forms.DataGridView Grilla;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnRecibirCartones;
        private System.Windows.Forms.Button BtnRecalcular;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.GroupBox grbResumenVendedor;
        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.NumericUpDown txtRegistroGastosCortesia;
        private System.Windows.Forms.Label lblGastosCortesia;
        private System.Windows.Forms.NumericUpDown txtRegistroCartonesCortesia;
        private System.Windows.Forms.Label lblCartonesCortesia;
        private System.Windows.Forms.NumericUpDown txtRegistroPorcentajaComision;
        private System.Windows.Forms.Label lblPorcentajeComision;
        private System.Windows.Forms.NumericUpDown txtRegistroHojasDevueltas;
        private System.Windows.Forms.Label lblHojasEntregadas;
        private System.Windows.Forms.NumericUpDown txtRegistroCartonesDevueltos;
        private System.Windows.Forms.Label lblCartonesDevueltos;
        private System.Windows.Forms.NumericUpDown txtResumenTotalCartones;
        private System.Windows.Forms.Label lblTotalCartones;
        private System.Windows.Forms.GroupBox grbModulos;
        private System.Windows.Forms.Label lblInfoModulos;
        private System.Windows.Forms.NumericUpDown txResumenTotalCartonesEfectivos;
        private System.Windows.Forms.Label lblCartonesEfectivos;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.Label lblFaltante;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblGastoCortesiaResumen;
        private System.Windows.Forms.Label lblAbonos;
        private System.Windows.Forms.Label lblValorComision;
        private System.Windows.Forms.NumericUpDown txResumenCartonesDevueltos;
        private System.Windows.Forms.Label lblCartonesDeveltosResumen;
        private System.Windows.Forms.NumericUpDown txResumenCartonesCortesia;
        private System.Windows.Forms.Label lblCartonesCortesiaResumen;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.TextBox txResumenTotalVentas;
        private System.Windows.Forms.TextBox txResumenFaltante;
        private System.Windows.Forms.TextBox txResumenTotalRecibido;
        private System.Windows.Forms.TextBox txResumenTotalPagar;
        private System.Windows.Forms.TextBox txResumenGastosCortesia;
        private System.Windows.Forms.TextBox txResumenAbonos;
        private System.Windows.Forms.TextBox txResumenValorComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobrado;
    }
}