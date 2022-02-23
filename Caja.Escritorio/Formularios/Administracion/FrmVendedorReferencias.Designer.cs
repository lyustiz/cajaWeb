namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmVendedorReferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedorReferencias));
            this.grbDatosReferencia = new System.Windows.Forms.GroupBox();
            this.cmdPaises = new System.Windows.Forms.ComboBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cmdCiudades = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmdTipoRelacion = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblTipoRelacion = new System.Windows.Forms.Label();
            this.grbReferenciasVendedor = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoRelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.menuVendedor = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbVendedor = new System.Windows.Forms.GroupBox();
            this.grbDatosReferencia.SuspendLayout();
            this.grbReferenciasVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.menuVendedor.SuspendLayout();
            this.grbVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosReferencia
            // 
            this.grbDatosReferencia.Controls.Add(this.cmdPaises);
            this.grbDatosReferencia.Controls.Add(this.txtCelular);
            this.grbDatosReferencia.Controls.Add(this.lblCelular);
            this.grbDatosReferencia.Controls.Add(this.txtDocumento);
            this.grbDatosReferencia.Controls.Add(this.lblDocumento);
            this.grbDatosReferencia.Controls.Add(this.cmdCiudades);
            this.grbDatosReferencia.Controls.Add(this.lblCiudad);
            this.grbDatosReferencia.Controls.Add(this.cmdTipoRelacion);
            this.grbDatosReferencia.Controls.Add(this.lblPais);
            this.grbDatosReferencia.Controls.Add(this.txtTelefono);
            this.grbDatosReferencia.Controls.Add(this.lblTelefono);
            this.grbDatosReferencia.Controls.Add(this.txtDireccion);
            this.grbDatosReferencia.Controls.Add(this.lblDireccion);
            this.grbDatosReferencia.Controls.Add(this.lblApellidos);
            this.grbDatosReferencia.Controls.Add(this.txtApellidos);
            this.grbDatosReferencia.Controls.Add(this.lblNombres);
            this.grbDatosReferencia.Controls.Add(this.txtNombres);
            this.grbDatosReferencia.Controls.Add(this.lblTipoRelacion);
            this.grbDatosReferencia.Enabled = false;
            this.grbDatosReferencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosReferencia.Location = new System.Drawing.Point(11, 82);
            this.grbDatosReferencia.Name = "grbDatosReferencia";
            this.grbDatosReferencia.Size = new System.Drawing.Size(823, 165);
            this.grbDatosReferencia.TabIndex = 0;
            this.grbDatosReferencia.TabStop = false;
            this.grbDatosReferencia.Text = "Datos Referencia";
            // 
            // cmdPaises
            // 
            this.cmdPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdPaises.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPaises.FormattingEnabled = true;
            this.cmdPaises.Location = new System.Drawing.Point(90, 95);
            this.cmdPaises.Name = "cmdPaises";
            this.cmdPaises.Size = new System.Drawing.Size(150, 23);
            this.cmdPaises.TabIndex = 195;
            this.cmdPaises.SelectedIndexChanged += new System.EventHandler(this.cmdPaises_SelectedIndexChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(90, 130);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(150, 25);
            this.txtCelular.TabIndex = 198;
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(10, 130);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(75, 25);
            this.lblCelular.TabIndex = 209;
            this.lblCelular.Text = "Celular";
            this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(615, 60);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 25);
            this.txtDocumento.TabIndex = 194;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(530, 60);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(75, 25);
            this.lblDocumento.TabIndex = 207;
            this.lblDocumento.Text = "Documento";
            this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCiudades
            // 
            this.cmdCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdCiudades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCiudades.FormattingEnabled = true;
            this.cmdCiudades.Location = new System.Drawing.Point(325, 95);
            this.cmdCiudades.Name = "cmdCiudades";
            this.cmdCiudades.Size = new System.Drawing.Size(200, 23);
            this.cmdCiudades.TabIndex = 196;
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
            // cmdTipoRelacion
            // 
            this.cmdTipoRelacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdTipoRelacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTipoRelacion.FormattingEnabled = true;
            this.cmdTipoRelacion.Location = new System.Drawing.Point(90, 25);
            this.cmdTipoRelacion.Name = "cmdTipoRelacion";
            this.cmdTipoRelacion.Size = new System.Drawing.Size(150, 23);
            this.cmdTipoRelacion.TabIndex = 190;
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
            this.txtTelefono.Location = new System.Drawing.Point(615, 95);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 25);
            this.txtTelefono.TabIndex = 197;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(530, 95);
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
            this.txtDireccion.TabIndex = 193;
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
            this.txtApellidos.TabIndex = 192;
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
            // lblTipoRelacion
            // 
            this.lblTipoRelacion.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRelacion.Location = new System.Drawing.Point(10, 25);
            this.lblTipoRelacion.Name = "lblTipoRelacion";
            this.lblTipoRelacion.Size = new System.Drawing.Size(75, 25);
            this.lblTipoRelacion.TabIndex = 190;
            this.lblTipoRelacion.Text = "Relación";
            this.lblTipoRelacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbReferenciasVendedor
            // 
            this.grbReferenciasVendedor.Controls.Add(this.Grilla);
            this.grbReferenciasVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbReferenciasVendedor.Location = new System.Drawing.Point(11, 250);
            this.grbReferenciasVendedor.Name = "grbReferenciasVendedor";
            this.grbReferenciasVendedor.Size = new System.Drawing.Size(823, 270);
            this.grbReferenciasVendedor.TabIndex = 1;
            this.grbReferenciasVendedor.TabStop = false;
            this.grbReferenciasVendedor.Text = "Referencias Vendedor";
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
            this.IdTipoRelacion});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(10, 22);
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
            this.Nombres.Width = 180;
            // 
            // Apellidos
            // 
            this.Apellidos.DividerWidth = 1;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 180;
            // 
            // Celular
            // 
            this.Celular.DividerWidth = 1;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 95;
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Telefono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Width = 95;
            // 
            // IdTipoRelacion
            // 
            this.IdTipoRelacion.HeaderText = "Relación";
            this.IdTipoRelacion.Name = "IdTipoRelacion";
            this.IdTipoRelacion.ReadOnly = true;
            this.IdTipoRelacion.Width = 110;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(10, 18);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(807, 25);
            this.lblNombreVendedor.TabIndex = 167;
            this.lblNombreVendedor.Text = "Criterio de Búsqueda";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuVendedor
            // 
            this.menuVendedor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem});
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
            // grbVendedor
            // 
            this.grbVendedor.Controls.Add(this.lblNombreVendedor);
            this.grbVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVendedor.Location = new System.Drawing.Point(11, 27);
            this.grbVendedor.Name = "grbVendedor";
            this.grbVendedor.Size = new System.Drawing.Size(823, 49);
            this.grbVendedor.TabIndex = 211;
            this.grbVendedor.TabStop = false;
            this.grbVendedor.Text = "Nombre del Vendedor";
            // 
            // FrmVendedorReferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 534);
            this.Controls.Add(this.grbVendedor);
            this.Controls.Add(this.grbReferenciasVendedor);
            this.Controls.Add(this.grbDatosReferencia);
            this.Controls.Add(this.menuVendedor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuVendedor;
            this.Name = "FrmVendedorReferencias";
            this.Text = "Administración de Referencias Vendedor";
            this.grbDatosReferencia.ResumeLayout(false);
            this.grbDatosReferencia.PerformLayout();
            this.grbReferenciasVendedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.menuVendedor.ResumeLayout(false);
            this.menuVendedor.PerformLayout();
            this.grbVendedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosReferencia;
        private System.Windows.Forms.GroupBox grbReferenciasVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblTipoRelacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPais;
        internal System.Windows.Forms.ComboBox cmdCiudades;
        private System.Windows.Forms.Label lblCiudad;
        internal System.Windows.Forms.ComboBox cmdTipoRelacion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.MenuStrip menuVendedor;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbVendedor;
        internal System.Windows.Forms.ComboBox cmdPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoRelacion;
    }
}