namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedores));
            this.grbDatosVendedor = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cmdEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecNacimiento = new System.Windows.Forms.Label();
            this.cmdCiudades = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmdPaises = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbVendedores = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuVendedor = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDatosVendedor.SuspendLayout();
            this.grbVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.menuVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosVendedor
            // 
            this.grbDatosVendedor.Controls.Add(this.txtCelular);
            this.grbDatosVendedor.Controls.Add(this.lblCelular);
            this.grbDatosVendedor.Controls.Add(this.txtDocumento);
            this.grbDatosVendedor.Controls.Add(this.lblDocumento);
            this.grbDatosVendedor.Controls.Add(this.cmdEstadoCivil);
            this.grbDatosVendedor.Controls.Add(this.lblEstadoCivil);
            this.grbDatosVendedor.Controls.Add(this.dtpNacimiento);
            this.grbDatosVendedor.Controls.Add(this.lblFecNacimiento);
            this.grbDatosVendedor.Controls.Add(this.cmdCiudades);
            this.grbDatosVendedor.Controls.Add(this.lblCiudad);
            this.grbDatosVendedor.Controls.Add(this.cmdPaises);
            this.grbDatosVendedor.Controls.Add(this.lblPais);
            this.grbDatosVendedor.Controls.Add(this.txtTelefono);
            this.grbDatosVendedor.Controls.Add(this.lblTelefono);
            this.grbDatosVendedor.Controls.Add(this.txtDireccion);
            this.grbDatosVendedor.Controls.Add(this.lblDireccion);
            this.grbDatosVendedor.Controls.Add(this.lblApellidos);
            this.grbDatosVendedor.Controls.Add(this.txtApellidos);
            this.grbDatosVendedor.Controls.Add(this.lblNombres);
            this.grbDatosVendedor.Controls.Add(this.txtNombres);
            this.grbDatosVendedor.Controls.Add(this.txtCodigo);
            this.grbDatosVendedor.Controls.Add(this.lblCodigo);
            this.grbDatosVendedor.Enabled = false;
            this.grbDatosVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosVendedor.Location = new System.Drawing.Point(11, 28);
            this.grbDatosVendedor.Name = "grbDatosVendedor";
            this.grbDatosVendedor.Size = new System.Drawing.Size(823, 165);
            this.grbDatosVendedor.TabIndex = 0;
            this.grbDatosVendedor.TabStop = false;
            this.grbDatosVendedor.Text = "Datos del Vendedor";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(615, 130);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 25);
            this.txtCelular.TabIndex = 210;
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(530, 130);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(75, 25);
            this.lblCelular.TabIndex = 209;
            this.lblCelular.Text = "Celular";
            this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(325, 130);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 25);
            this.txtDocumento.TabIndex = 208;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(245, 130);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(75, 25);
            this.lblDocumento.TabIndex = 207;
            this.lblDocumento.Text = "Documento";
            this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdEstadoCivil
            // 
            this.cmdEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEstadoCivil.FormattingEnabled = true;
            this.cmdEstadoCivil.Location = new System.Drawing.Point(90, 130);
            this.cmdEstadoCivil.Name = "cmdEstadoCivil";
            this.cmdEstadoCivil.Size = new System.Drawing.Size(150, 23);
            this.cmdEstadoCivil.TabIndex = 206;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(10, 130);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(75, 25);
            this.lblEstadoCivil.TabIndex = 205;
            this.lblEstadoCivil.Text = "Estado Civil";
            this.lblEstadoCivil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(615, 95);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpNacimiento.TabIndex = 204;
            // 
            // lblFecNacimiento
            // 
            this.lblFecNacimiento.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecNacimiento.Location = new System.Drawing.Point(530, 95);
            this.lblFecNacimiento.Name = "lblFecNacimiento";
            this.lblFecNacimiento.Size = new System.Drawing.Size(85, 25);
            this.lblFecNacimiento.TabIndex = 203;
            this.lblFecNacimiento.Text = "F. Nacimiento";
            this.lblFecNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCiudades
            // 
            this.cmdCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdCiudades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCiudades.FormattingEnabled = true;
            this.cmdCiudades.Location = new System.Drawing.Point(325, 95);
            this.cmdCiudades.Name = "cmdCiudades";
            this.cmdCiudades.Size = new System.Drawing.Size(200, 23);
            this.cmdCiudades.TabIndex = 202;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(245, 95);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(75, 25);
            this.lblCiudad.TabIndex = 201;
            this.lblCiudad.Text = "Ciudad";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdPaises
            // 
            this.cmdPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdPaises.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPaises.FormattingEnabled = true;
            this.cmdPaises.Location = new System.Drawing.Point(90, 95);
            this.cmdPaises.Name = "cmdPaises";
            this.cmdPaises.Size = new System.Drawing.Size(150, 23);
            this.cmdPaises.TabIndex = 200;
            this.cmdPaises.SelectedIndexChanged += new System.EventHandler(this.CmdPaises_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(10, 95);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(75, 25);
            this.lblPais.TabIndex = 199;
            this.lblPais.Text = "País";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(615, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 25);
            this.txtTelefono.TabIndex = 198;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(530, 60);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 25);
            this.lblTelefono.TabIndex = 197;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(90, 60);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(437, 25);
            this.txtDireccion.TabIndex = 196;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(10, 60);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 25);
            this.lblDireccion.TabIndex = 195;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(530, 25);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(75, 25);
            this.lblApellidos.TabIndex = 194;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(615, 25);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 25);
            this.txtApellidos.TabIndex = 193;
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(245, 25);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 25);
            this.lblNombres.TabIndex = 192;
            this.lblNombres.Text = "Nombres";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(325, 25);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 25);
            this.txtNombres.TabIndex = 191;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(90, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 25);
            this.txtCodigo.TabIndex = 190;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 190;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbVendedores
            // 
            this.grbVendedores.Controls.Add(this.Grilla);
            this.grbVendedores.Controls.Add(this.BtnBuscar);
            this.grbVendedores.Controls.Add(this.txtFiltro);
            this.grbVendedores.Controls.Add(this.lblTitulo);
            this.grbVendedores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVendedores.Location = new System.Drawing.Point(11, 196);
            this.grbVendedores.Name = "grbVendedores";
            this.grbVendedores.Size = new System.Drawing.Size(823, 289);
            this.grbVendedores.TabIndex = 1;
            this.grbVendedores.TabStop = false;
            this.grbVendedores.Text = "Vendedores";
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
            this.Documento,
            this.Nombres,
            this.Apellidos,
            this.Celular,
            this.Teléfono,
            this.Estado});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(10, 49);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(802, 230);
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
            this.IdVendedor.ReadOnly = true;
            this.IdVendedor.Visible = false;
            this.IdVendedor.Width = 30;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DividerWidth = 1;
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 190;
            // 
            // Apellidos
            // 
            this.Apellidos.DividerWidth = 1;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 190;
            // 
            // Celular
            // 
            this.Celular.DividerWidth = 1;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Telefono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
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
            this.BtnBuscar.Location = new System.Drawing.Point(711, 18);
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
            this.txtFiltro.Size = new System.Drawing.Size(570, 25);
            this.txtFiltro.TabIndex = 168;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(125, 25);
            this.lblTitulo.TabIndex = 167;
            this.lblTitulo.Text = "Criterio de Búsqueda";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuVendedor
            // 
            this.menuVendedor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.referenciasToolStripMenuItem,
            this.inactivarToolStripMenuItem});
            this.menuVendedor.Location = new System.Drawing.Point(0, 0);
            this.menuVendedor.Name = "menuVendedor";
            this.menuVendedor.Size = new System.Drawing.Size(847, 24);
            this.menuVendedor.TabIndex = 2;
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
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // referenciasToolStripMenuItem
            // 
            this.referenciasToolStripMenuItem.Enabled = false;
            this.referenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("referenciasToolStripMenuItem.Image")));
            this.referenciasToolStripMenuItem.Name = "referenciasToolStripMenuItem";
            this.referenciasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.referenciasToolStripMenuItem.Text = "Referencias";
            this.referenciasToolStripMenuItem.Click += new System.EventHandler(this.referenciasToolStripMenuItem_Click);
            // 
            // inactivarToolStripMenuItem
            // 
            this.inactivarToolStripMenuItem.Enabled = false;
            this.inactivarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inactivarToolStripMenuItem.Image")));
            this.inactivarToolStripMenuItem.Name = "inactivarToolStripMenuItem";
            this.inactivarToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.inactivarToolStripMenuItem.Text = "Inactivar";
            this.inactivarToolStripMenuItem.Click += new System.EventHandler(this.inactivarToolStripMenuItem_Click);
            // 
            // FrmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 490);
            this.Controls.Add(this.grbVendedores);
            this.Controls.Add(this.grbDatosVendedor);
            this.Controls.Add(this.menuVendedor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuVendedor;
            this.Name = "FrmVendedores";
            this.Text = "Administración de Vendedores";
            this.grbDatosVendedor.ResumeLayout(false);
            this.grbDatosVendedor.PerformLayout();
            this.grbVendedores.ResumeLayout(false);
            this.grbVendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.menuVendedor.ResumeLayout(false);
            this.menuVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosVendedor;
        private System.Windows.Forms.GroupBox grbVendedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPais;
        internal System.Windows.Forms.ComboBox cmdCiudades;
        private System.Windows.Forms.Label lblCiudad;
        internal System.Windows.Forms.ComboBox cmdPaises;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblFecNacimiento;
        private System.Windows.Forms.Label lblEstadoCivil;
        internal System.Windows.Forms.ComboBox cmdEstadoCivil;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.MenuStrip menuVendedor;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactivarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}