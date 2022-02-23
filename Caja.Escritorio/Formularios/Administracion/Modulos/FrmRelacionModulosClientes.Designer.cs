namespace Caja.Escritorio.Formularios.Administracion.Modulos
{
    partial class FrmRelacionModulosClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelacionModulosClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbListadoClientes = new System.Windows.Forms.GroupBox();
            this.grbBuscarPorModulo = new System.Windows.Forms.GroupBox();
            this.BtnBuscarModulo = new System.Windows.Forms.Button();
            this.lblCriterioBusquedaModulo = new System.Windows.Forms.Label();
            this.txtModuloAsignado = new System.Windows.Forms.NumericUpDown();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblCriterioBusqueda = new System.Windows.Forms.Label();
            this.grbClienteSeleccionado = new System.Windows.Forms.GroupBox();
            this.txtNumeroModulo = new System.Windows.Forms.NumericUpDown();
            this.grbModulosAsociados = new System.Windows.Forms.GroupBox();
            this.GrillaModulos = new System.Windows.Forms.DataGridView();
            this.lblTotalModulos = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.IdClienteModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbListadoClientes.SuspendLayout();
            this.grbBuscarPorModulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtModuloAsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbClienteSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroModulo)).BeginInit();
            this.grbModulosAsociados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListadoClientes
            // 
            this.grbListadoClientes.Controls.Add(this.grbBuscarPorModulo);
            this.grbListadoClientes.Controls.Add(this.Grilla);
            this.grbListadoClientes.Controls.Add(this.BtnBuscar);
            this.grbListadoClientes.Controls.Add(this.txtFiltro);
            this.grbListadoClientes.Controls.Add(this.lblCriterioBusqueda);
            this.grbListadoClientes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListadoClientes.Location = new System.Drawing.Point(12, 12);
            this.grbListadoClientes.Name = "grbListadoClientes";
            this.grbListadoClientes.Size = new System.Drawing.Size(645, 328);
            this.grbListadoClientes.TabIndex = 8;
            this.grbListadoClientes.TabStop = false;
            this.grbListadoClientes.Text = "Listado de Clientes";
            // 
            // grbBuscarPorModulo
            // 
            this.grbBuscarPorModulo.Controls.Add(this.BtnBuscarModulo);
            this.grbBuscarPorModulo.Controls.Add(this.lblCriterioBusquedaModulo);
            this.grbBuscarPorModulo.Controls.Add(this.txtModuloAsignado);
            this.grbBuscarPorModulo.Location = new System.Drawing.Point(10, 259);
            this.grbBuscarPorModulo.Name = "grbBuscarPorModulo";
            this.grbBuscarPorModulo.Size = new System.Drawing.Size(629, 58);
            this.grbBuscarPorModulo.TabIndex = 192;
            this.grbBuscarPorModulo.TabStop = false;
            this.grbBuscarPorModulo.Text = "Buscar Módulo Asignado";
            // 
            // BtnBuscarModulo
            // 
            this.BtnBuscarModulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscarModulo.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnBuscarModulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscarModulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarModulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarModulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarModulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscarModulo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarModulo.Image")));
            this.BtnBuscarModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarModulo.Location = new System.Drawing.Point(511, 25);
            this.BtnBuscarModulo.Name = "BtnBuscarModulo";
            this.BtnBuscarModulo.Size = new System.Drawing.Size(100, 25);
            this.BtnBuscarModulo.TabIndex = 193;
            this.BtnBuscarModulo.Text = "Filtrar";
            this.BtnBuscarModulo.UseVisualStyleBackColor = false;
            this.BtnBuscarModulo.Click += new System.EventHandler(this.BtnBuscarModulo_Click);
            // 
            // lblCriterioBusquedaModulo
            // 
            this.lblCriterioBusquedaModulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioBusquedaModulo.Location = new System.Drawing.Point(10, 25);
            this.lblCriterioBusquedaModulo.Name = "lblCriterioBusquedaModulo";
            this.lblCriterioBusquedaModulo.Size = new System.Drawing.Size(125, 25);
            this.lblCriterioBusquedaModulo.TabIndex = 190;
            this.lblCriterioBusquedaModulo.Text = "Número Modulo";
            this.lblCriterioBusquedaModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModuloAsignado
            // 
            this.txtModuloAsignado.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuloAsignado.Location = new System.Drawing.Point(140, 25);
            this.txtModuloAsignado.Name = "txtModuloAsignado";
            this.txtModuloAsignado.Size = new System.Drawing.Size(365, 25);
            this.txtModuloAsignado.TabIndex = 191;
            this.txtModuloAsignado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtModuloAsignado_KeyUp);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToOrderColumns = true;
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVendedor,
            this.Nombre,
            this.Celular,
            this.Barrio});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(10, 49);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(629, 204);
            this.Grilla.TabIndex = 189;
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellClick);
            // 
            // IdVendedor
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "-";
            this.IdVendedor.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdVendedor.HeaderText = "Id";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.Visible = false;
            this.IdVendedor.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Cliente";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 237;
            // 
            // Celular
            // 
            this.Celular.DividerWidth = 1;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.Width = 150;
            // 
            // Barrio
            // 
            this.Barrio.DividerWidth = 1;
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.Width = 200;
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
            this.BtnBuscar.Location = new System.Drawing.Point(539, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 25);
            this.BtnBuscar.TabIndex = 188;
            this.BtnBuscar.Text = "Filtrar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(134, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(399, 25);
            this.txtFiltro.TabIndex = 168;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // lblCriterioBusqueda
            // 
            this.lblCriterioBusqueda.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioBusqueda.Location = new System.Drawing.Point(10, 18);
            this.lblCriterioBusqueda.Name = "lblCriterioBusqueda";
            this.lblCriterioBusqueda.Size = new System.Drawing.Size(125, 25);
            this.lblCriterioBusqueda.TabIndex = 167;
            this.lblCriterioBusqueda.Text = "Criterio de Búsqueda";
            this.lblCriterioBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbClienteSeleccionado
            // 
            this.grbClienteSeleccionado.Controls.Add(this.txtNumeroModulo);
            this.grbClienteSeleccionado.Controls.Add(this.grbModulosAsociados);
            this.grbClienteSeleccionado.Controls.Add(this.lblFechaFin);
            this.grbClienteSeleccionado.Controls.Add(this.dtpFechaFin);
            this.grbClienteSeleccionado.Controls.Add(this.lblFechaInicio);
            this.grbClienteSeleccionado.Controls.Add(this.dtpFechaInicio);
            this.grbClienteSeleccionado.Controls.Add(this.BtnAgregar);
            this.grbClienteSeleccionado.Controls.Add(this.lblModulo);
            this.grbClienteSeleccionado.Controls.Add(this.txtNombre);
            this.grbClienteSeleccionado.Controls.Add(this.lblNombreCliente);
            this.grbClienteSeleccionado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClienteSeleccionado.Location = new System.Drawing.Point(12, 346);
            this.grbClienteSeleccionado.Name = "grbClienteSeleccionado";
            this.grbClienteSeleccionado.Size = new System.Drawing.Size(645, 277);
            this.grbClienteSeleccionado.TabIndex = 9;
            this.grbClienteSeleccionado.TabStop = false;
            this.grbClienteSeleccionado.Text = "Cliente Seleccionado";
            // 
            // txtNumeroModulo
            // 
            this.txtNumeroModulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroModulo.Location = new System.Drawing.Point(10, 93);
            this.txtNumeroModulo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtNumeroModulo.Name = "txtNumeroModulo";
            this.txtNumeroModulo.Size = new System.Drawing.Size(278, 25);
            this.txtNumeroModulo.TabIndex = 210;
            // 
            // grbModulosAsociados
            // 
            this.grbModulosAsociados.Controls.Add(this.GrillaModulos);
            this.grbModulosAsociados.Controls.Add(this.lblTotalModulos);
            this.grbModulosAsociados.Location = new System.Drawing.Point(294, 13);
            this.grbModulosAsociados.Name = "grbModulosAsociados";
            this.grbModulosAsociados.Size = new System.Drawing.Size(345, 258);
            this.grbModulosAsociados.TabIndex = 209;
            this.grbModulosAsociados.TabStop = false;
            this.grbModulosAsociados.Text = "Módulos Asignados";
            // 
            // GrillaModulos
            // 
            this.GrillaModulos.AllowUserToAddRows = false;
            this.GrillaModulos.AllowUserToDeleteRows = false;
            this.GrillaModulos.AllowUserToOrderColumns = true;
            this.GrillaModulos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrillaModulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrillaModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClienteModulo,
            this.NumeroModulo,
            this.FechaInicio,
            this.FechaFin,
            this.Eliminar});
            this.GrillaModulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaModulos.GridColor = System.Drawing.SystemColors.Control;
            this.GrillaModulos.Location = new System.Drawing.Point(6, 19);
            this.GrillaModulos.Name = "GrillaModulos";
            this.GrillaModulos.ReadOnly = true;
            this.GrillaModulos.Size = new System.Drawing.Size(332, 204);
            this.GrillaModulos.TabIndex = 193;
            this.GrillaModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaModulos_CellClick);
            // 
            // lblTotalModulos
            // 
            this.lblTotalModulos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalModulos.Location = new System.Drawing.Point(177, 227);
            this.lblTotalModulos.Name = "lblTotalModulos";
            this.lblTotalModulos.Size = new System.Drawing.Size(160, 25);
            this.lblTotalModulos.TabIndex = 204;
            this.lblTotalModulos.Text = "Total Módulos: {0}";
            this.lblTotalModulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(158, 120);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(100, 20);
            this.lblFechaFin.TabIndex = 208;
            this.lblFechaFin.Text = "Fecha Fin";
            this.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(158, 140);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(130, 23);
            this.dtpFechaFin.TabIndex = 207;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(10, 120);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.lblFechaInicio.TabIndex = 206;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(10, 140);
            this.dtpFechaInicio.MinDate = new System.DateTime(2021, 2, 11, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(130, 23);
            this.dtpFechaInicio.TabIndex = 205;
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
            this.BtnAgregar.Location = new System.Drawing.Point(188, 169);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 25);
            this.BtnAgregar.TabIndex = 194;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblModulo
            // 
            this.lblModulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(10, 70);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(75, 20);
            this.lblModulo.TabIndex = 192;
            this.lblModulo.Text = "Módulo";
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(10, 40);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(278, 25);
            this.txtNombre.TabIndex = 190;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(10, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(75, 20);
            this.lblNombreCliente.TabIndex = 190;
            this.lblNombreCliente.Text = "Nombre Cliente";
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdClienteModulo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = "-";
            this.IdClienteModulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdClienteModulo.HeaderText = "Id";
            this.IdClienteModulo.Name = "IdClienteModulo";
            this.IdClienteModulo.ReadOnly = true;
            this.IdClienteModulo.Visible = false;
            this.IdClienteModulo.Width = 30;
            // 
            // NumeroModulo
            // 
            this.NumeroModulo.HeaderText = "Módulo";
            this.NumeroModulo.Name = "NumeroModulo";
            this.NumeroModulo.ReadOnly = true;
            this.NumeroModulo.Width = 60;
            // 
            // FechaInicio
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaInicio.HeaderText = "Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaFin.HeaderText = "Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 30;
            // 
            // FrmRelacionModulosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 633);
            this.Controls.Add(this.grbClienteSeleccionado);
            this.Controls.Add(this.grbListadoClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelacionModulosClientes";
            this.Text = "Relación de Módulos Clientes";
            this.grbListadoClientes.ResumeLayout(false);
            this.grbListadoClientes.PerformLayout();
            this.grbBuscarPorModulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtModuloAsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbClienteSeleccionado.ResumeLayout(false);
            this.grbClienteSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroModulo)).EndInit();
            this.grbModulosAsociados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaModulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListadoClientes;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox grbClienteSeleccionado;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTotalModulos;
        private System.Windows.Forms.GroupBox grbBuscarPorModulo;
        private System.Windows.Forms.Button BtnBuscarModulo;
        private System.Windows.Forms.Label lblCriterioBusquedaModulo;
        private System.Windows.Forms.NumericUpDown txtModuloAsignado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCriterioBusqueda;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox grbModulosAsociados;
        internal System.Windows.Forms.DataGridView GrillaModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.NumericUpDown txtNumeroModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClienteModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}