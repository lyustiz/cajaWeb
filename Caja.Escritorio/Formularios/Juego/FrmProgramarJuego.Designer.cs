namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmProgramarJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramarJuego));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReajustarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjustarPremiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDatosJuego = new System.Windows.Forms.GroupBox();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.dtpFechaProgramacion = new System.Windows.Forms.DateTimePicker();
            this.lblFecJuego = new System.Windows.Forms.Label();
            this.lblJuego = new System.Windows.Forms.Label();
            this.txtValorModulo = new System.Windows.Forms.NumericUpDown();
            this.lblValorModulo = new System.Windows.Forms.Label();
            this.lblValorCarton = new System.Windows.Forms.Label();
            this.txtValorCarton = new System.Windows.Forms.NumericUpDown();
            this.grbDatosSerie = new System.Windows.Forms.GroupBox();
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
            this.grbNuevaFigura = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lblValorFigura = new System.Windows.Forms.Label();
            this.cmdFiguras = new System.Windows.Forms.ComboBox();
            this.txtValorFigura = new System.Windows.Forms.NumericUpDown();
            this.lblFigura = new System.Windows.Forms.Label();
            this.grbListadoFiguras = new System.Windows.Forms.GroupBox();
            this.lblTotalPremios = new System.Windows.Forms.Label();
            this.GrillaFiguras = new System.Windows.Forms.DataGridView();
            this.IdProgramacionJuegoFigura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPremio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuVentana.SuspendLayout();
            this.grbDatosJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCarton)).BeginInit();
            this.grbDatosSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonFinal)).BeginInit();
            this.grbNuevaFigura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFigura)).BeginInit();
            this.grbListadoFiguras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFiguras)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.ReajustarValoresToolStripMenuItem,
            this.AjustarPremiosToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(784, 24);
            this.menuVentana.TabIndex = 1;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // ReajustarValoresToolStripMenuItem
            // 
            this.ReajustarValoresToolStripMenuItem.Enabled = false;
            this.ReajustarValoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReajustarValoresToolStripMenuItem.Image")));
            this.ReajustarValoresToolStripMenuItem.Name = "ReajustarValoresToolStripMenuItem";
            this.ReajustarValoresToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.ReajustarValoresToolStripMenuItem.Text = "Reajustar Valores";
            // 
            // AjustarPremiosToolStripMenuItem
            // 
            this.AjustarPremiosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AjustarPremiosToolStripMenuItem.Image")));
            this.AjustarPremiosToolStripMenuItem.Name = "AjustarPremiosToolStripMenuItem";
            this.AjustarPremiosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.AjustarPremiosToolStripMenuItem.Text = "Ajustar Premios";
            this.AjustarPremiosToolStripMenuItem.Click += new System.EventHandler(this.AjustarPremiosToolStripMenuItem_Click);
            // 
            // grbDatosJuego
            // 
            this.grbDatosJuego.Controls.Add(this.cmdProgramacion);
            this.grbDatosJuego.Controls.Add(this.dtpFechaProgramacion);
            this.grbDatosJuego.Controls.Add(this.lblFecJuego);
            this.grbDatosJuego.Controls.Add(this.lblJuego);
            this.grbDatosJuego.Controls.Add(this.txtValorModulo);
            this.grbDatosJuego.Controls.Add(this.lblValorModulo);
            this.grbDatosJuego.Controls.Add(this.lblValorCarton);
            this.grbDatosJuego.Controls.Add(this.txtValorCarton);
            this.grbDatosJuego.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosJuego.Location = new System.Drawing.Point(8, 27);
            this.grbDatosJuego.Name = "grbDatosJuego";
            this.grbDatosJuego.Size = new System.Drawing.Size(768, 85);
            this.grbDatosJuego.TabIndex = 0;
            this.grbDatosJuego.TabStop = false;
            this.grbDatosJuego.Text = "Datos del Juego";
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(120, 18);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(160, 23);
            this.cmdProgramacion.TabIndex = 2;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdJuegos_SelectedIndexChanged);
            // 
            // dtpFechaProgramacion
            // 
            this.dtpFechaProgramacion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaProgramacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaProgramacion.Location = new System.Drawing.Point(373, 18);
            this.dtpFechaProgramacion.Name = "dtpFechaProgramacion";
            this.dtpFechaProgramacion.Size = new System.Drawing.Size(147, 23);
            this.dtpFechaProgramacion.TabIndex = 3;
            // 
            // lblFecJuego
            // 
            this.lblFecJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecJuego.Location = new System.Drawing.Point(282, 18);
            this.lblFecJuego.Name = "lblFecJuego";
            this.lblFecJuego.Size = new System.Drawing.Size(85, 25);
            this.lblFecJuego.TabIndex = 4;
            this.lblFecJuego.Text = "Fecha Juego";
            this.lblFecJuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtValorModulo
            // 
            this.txtValorModulo.DecimalPlaces = 2;
            this.txtValorModulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorModulo.Location = new System.Drawing.Point(640, 53);
            this.txtValorModulo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtValorModulo.Name = "txtValorModulo";
            this.txtValorModulo.Size = new System.Drawing.Size(120, 25);
            this.txtValorModulo.TabIndex = 5;
            this.txtValorModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorModulo.ThousandsSeparator = true;
            // 
            // lblValorModulo
            // 
            this.lblValorModulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorModulo.Location = new System.Drawing.Point(530, 53);
            this.lblValorModulo.Name = "lblValorModulo";
            this.lblValorModulo.Size = new System.Drawing.Size(100, 25);
            this.lblValorModulo.TabIndex = 6;
            this.lblValorModulo.Text = "Valor Módulo";
            this.lblValorModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorCarton
            // 
            this.lblValorCarton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCarton.Location = new System.Drawing.Point(530, 18);
            this.lblValorCarton.Name = "lblValorCarton";
            this.lblValorCarton.Size = new System.Drawing.Size(100, 25);
            this.lblValorCarton.TabIndex = 7;
            this.lblValorCarton.Text = "Valor Cartón";
            this.lblValorCarton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorCarton
            // 
            this.txtValorCarton.DecimalPlaces = 2;
            this.txtValorCarton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCarton.Location = new System.Drawing.Point(640, 18);
            this.txtValorCarton.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtValorCarton.Name = "txtValorCarton";
            this.txtValorCarton.Size = new System.Drawing.Size(120, 25);
            this.txtValorCarton.TabIndex = 4;
            this.txtValorCarton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCarton.ThousandsSeparator = true;
            // 
            // grbDatosSerie
            // 
            this.grbDatosSerie.Controls.Add(this.lblConectorHojas);
            this.grbDatosSerie.Controls.Add(this.txtHojaInicial);
            this.grbDatosSerie.Controls.Add(this.lblRangoHojas);
            this.grbDatosSerie.Controls.Add(this.txtHojaFinal);
            this.grbDatosSerie.Controls.Add(this.lblConectorCartones);
            this.grbDatosSerie.Controls.Add(this.txtCartonInicial);
            this.grbDatosSerie.Controls.Add(this.cmdSeries);
            this.grbDatosSerie.Controls.Add(this.lblSerie);
            this.grbDatosSerie.Controls.Add(this.lblRangoCartones);
            this.grbDatosSerie.Controls.Add(this.txtCartonFinal);
            this.grbDatosSerie.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosSerie.Location = new System.Drawing.Point(8, 115);
            this.grbDatosSerie.Name = "grbDatosSerie";
            this.grbDatosSerie.Size = new System.Drawing.Size(768, 80);
            this.grbDatosSerie.TabIndex = 1;
            this.grbDatosSerie.TabStop = false;
            this.grbDatosSerie.Text = "Configuración de Serie";
            // 
            // lblConectorHojas
            // 
            this.lblConectorHojas.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectorHojas.Location = new System.Drawing.Point(635, 49);
            this.lblConectorHojas.Name = "lblConectorHojas";
            this.lblConectorHojas.Size = new System.Drawing.Size(21, 25);
            this.lblConectorHojas.TabIndex = 0;
            this.lblConectorHojas.Text = "al";
            this.lblConectorHojas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHojaInicial
            // 
            this.txtHojaInicial.Enabled = false;
            this.txtHojaInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaInicial.Location = new System.Drawing.Point(530, 49);
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
            this.txtHojaInicial.TabIndex = 9;
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
            this.lblRangoHojas.Location = new System.Drawing.Point(370, 49);
            this.lblRangoHojas.Name = "lblRangoHojas";
            this.lblRangoHojas.Size = new System.Drawing.Size(149, 25);
            this.lblRangoHojas.TabIndex = 10;
            this.lblRangoHojas.Text = "Rango de Hojas";
            this.lblRangoHojas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHojaFinal
            // 
            this.txtHojaFinal.Enabled = false;
            this.txtHojaFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojaFinal.Location = new System.Drawing.Point(660, 49);
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
            this.txtHojaFinal.TabIndex = 10;
            this.txtHojaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHojaFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblConectorCartones
            // 
            this.lblConectorCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectorCartones.Location = new System.Drawing.Point(635, 18);
            this.lblConectorCartones.Name = "lblConectorCartones";
            this.lblConectorCartones.Size = new System.Drawing.Size(21, 25);
            this.lblConectorCartones.TabIndex = 11;
            this.lblConectorCartones.Text = "al";
            this.lblConectorCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCartonInicial
            // 
            this.txtCartonInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonInicial.Location = new System.Drawing.Point(530, 18);
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
            this.txtCartonInicial.TabIndex = 7;
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
            this.cmdSeries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeries.FormattingEnabled = true;
            this.cmdSeries.Location = new System.Drawing.Point(120, 18);
            this.cmdSeries.Name = "cmdSeries";
            this.cmdSeries.Size = new System.Drawing.Size(245, 23);
            this.cmdSeries.TabIndex = 6;
            // 
            // lblSerie
            // 
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(10, 18);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(100, 25);
            this.lblSerie.TabIndex = 12;
            this.lblSerie.Text = "Serie";
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRangoCartones
            // 
            this.lblRangoCartones.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoCartones.Location = new System.Drawing.Point(370, 18);
            this.lblRangoCartones.Name = "lblRangoCartones";
            this.lblRangoCartones.Size = new System.Drawing.Size(149, 25);
            this.lblRangoCartones.TabIndex = 13;
            this.lblRangoCartones.Text = "Rango de Cartones";
            this.lblRangoCartones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCartonFinal
            // 
            this.txtCartonFinal.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonFinal.Location = new System.Drawing.Point(660, 18);
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
            this.txtCartonFinal.TabIndex = 8;
            this.txtCartonFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCartonFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grbNuevaFigura
            // 
            this.grbNuevaFigura.Controls.Add(this.BtnAgregar);
            this.grbNuevaFigura.Controls.Add(this.lblValorFigura);
            this.grbNuevaFigura.Controls.Add(this.cmdFiguras);
            this.grbNuevaFigura.Controls.Add(this.txtValorFigura);
            this.grbNuevaFigura.Controls.Add(this.lblFigura);
            this.grbNuevaFigura.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNuevaFigura.Location = new System.Drawing.Point(8, 197);
            this.grbNuevaFigura.Name = "grbNuevaFigura";
            this.grbNuevaFigura.Size = new System.Drawing.Size(768, 85);
            this.grbNuevaFigura.TabIndex = 2;
            this.grbNuevaFigura.TabStop = false;
            this.grbNuevaFigura.Text = "Configuración de Figuras";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.BackColor = System.Drawing.Color.Olive;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(658, 50);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 25);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblValorFigura
            // 
            this.lblValorFigura.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFigura.Location = new System.Drawing.Point(530, 19);
            this.lblValorFigura.Name = "lblValorFigura";
            this.lblValorFigura.Size = new System.Drawing.Size(100, 25);
            this.lblValorFigura.TabIndex = 14;
            this.lblValorFigura.Text = "Valor Figura";
            this.lblValorFigura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdFiguras
            // 
            this.cmdFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdFiguras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFiguras.FormattingEnabled = true;
            this.cmdFiguras.Location = new System.Drawing.Point(120, 19);
            this.cmdFiguras.Name = "cmdFiguras";
            this.cmdFiguras.Size = new System.Drawing.Size(400, 23);
            this.cmdFiguras.TabIndex = 11;
            // 
            // txtValorFigura
            // 
            this.txtValorFigura.DecimalPlaces = 2;
            this.txtValorFigura.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFigura.Location = new System.Drawing.Point(640, 19);
            this.txtValorFigura.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtValorFigura.Name = "txtValorFigura";
            this.txtValorFigura.Size = new System.Drawing.Size(120, 25);
            this.txtValorFigura.TabIndex = 12;
            this.txtValorFigura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorFigura.ThousandsSeparator = true;
            // 
            // lblFigura
            // 
            this.lblFigura.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigura.Location = new System.Drawing.Point(10, 19);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(100, 25);
            this.lblFigura.TabIndex = 15;
            this.lblFigura.Text = "Figura";
            this.lblFigura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbListadoFiguras
            // 
            this.grbListadoFiguras.Controls.Add(this.lblTotalPremios);
            this.grbListadoFiguras.Controls.Add(this.GrillaFiguras);
            this.grbListadoFiguras.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListadoFiguras.Location = new System.Drawing.Point(8, 288);
            this.grbListadoFiguras.Name = "grbListadoFiguras";
            this.grbListadoFiguras.Size = new System.Drawing.Size(768, 204);
            this.grbListadoFiguras.TabIndex = 3;
            this.grbListadoFiguras.TabStop = false;
            this.grbListadoFiguras.Text = "Listado de Figuras";
            // 
            // lblTotalPremios
            // 
            this.lblTotalPremios.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPremios.Location = new System.Drawing.Point(408, 165);
            this.lblTotalPremios.Name = "lblTotalPremios";
            this.lblTotalPremios.Size = new System.Drawing.Size(350, 30);
            this.lblTotalPremios.TabIndex = 0;
            this.lblTotalPremios.Text = "Total Premios: {0}";
            this.lblTotalPremios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GrillaFiguras
            // 
            this.GrillaFiguras.AllowUserToAddRows = false;
            this.GrillaFiguras.AllowUserToDeleteRows = false;
            this.GrillaFiguras.AllowUserToOrderColumns = true;
            this.GrillaFiguras.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrillaFiguras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaFiguras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrillaFiguras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaFiguras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProgramacionJuegoFigura,
            this.Nombre,
            this.ValorPremio,
            this.Eliminar});
            this.GrillaFiguras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaFiguras.GridColor = System.Drawing.SystemColors.Control;
            this.GrillaFiguras.Location = new System.Drawing.Point(12, 19);
            this.GrillaFiguras.Name = "GrillaFiguras";
            this.GrillaFiguras.ReadOnly = true;
            this.GrillaFiguras.Size = new System.Drawing.Size(747, 143);
            this.GrillaFiguras.TabIndex = 1;
            this.GrillaFiguras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFiguras_CellClick);
            // 
            // IdProgramacionJuegoFigura
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "-";
            this.IdProgramacionJuegoFigura.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdProgramacionJuegoFigura.HeaderText = "Id";
            this.IdProgramacionJuegoFigura.Name = "IdProgramacionJuegoFigura";
            this.IdProgramacionJuegoFigura.ReadOnly = true;
            this.IdProgramacionJuegoFigura.Visible = false;
            this.IdProgramacionJuegoFigura.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Figura";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 455;
            // 
            // ValorPremio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorPremio.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorPremio.HeaderText = "Valor Premio";
            this.ValorPremio.Name = "ValorPremio";
            this.ValorPremio.ReadOnly = true;
            this.ValorPremio.Width = 150;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FrmProgramarJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.grbDatosJuego);
            this.Controls.Add(this.grbDatosSerie);
            this.Controls.Add(this.grbNuevaFigura);
            this.Controls.Add(this.grbListadoFiguras);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProgramarJuego";
            this.Text = "Programar Juego";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbDatosJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCarton)).EndInit();
            this.grbDatosSerie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHojaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCartonFinal)).EndInit();
            this.grbNuevaFigura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFigura)).EndInit();
            this.grbListadoFiguras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFiguras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReajustarValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjustarPremiosToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbDatosJuego;
        private System.Windows.Forms.DateTimePicker dtpFechaProgramacion;
        private System.Windows.Forms.Label lblFecJuego;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.NumericUpDown txtValorModulo;
        private System.Windows.Forms.Label lblValorModulo;
        private System.Windows.Forms.Label lblValorCarton;
        private System.Windows.Forms.NumericUpDown txtValorCarton;
        private System.Windows.Forms.GroupBox grbDatosSerie;
        internal System.Windows.Forms.ComboBox cmdSeries;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblRangoCartones;
        private System.Windows.Forms.NumericUpDown txtCartonFinal;
        private System.Windows.Forms.NumericUpDown txtCartonInicial;
        private System.Windows.Forms.Label lblConectorHojas;
        private System.Windows.Forms.NumericUpDown txtHojaInicial;
        private System.Windows.Forms.Label lblRangoHojas;
        private System.Windows.Forms.NumericUpDown txtHojaFinal;
        private System.Windows.Forms.Label lblConectorCartones;
        private System.Windows.Forms.GroupBox grbNuevaFigura;
        private System.Windows.Forms.Label lblValorFigura;
        internal System.Windows.Forms.ComboBox cmdFiguras;
        private System.Windows.Forms.NumericUpDown txtValorFigura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox grbListadoFiguras;
        internal System.Windows.Forms.DataGridView GrillaFiguras;
        private System.Windows.Forms.Label lblTotalPremios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProgramacionJuegoFigura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPremio;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
    }
}