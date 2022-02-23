namespace Caja.Escritorio.Formularios.Administracion.Modulos
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.grbListadoClientes = new System.Windows.Forms.GroupBox();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDefinicionClientes = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.menuVendedor = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbListadoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbDefinicionClientes.SuspendLayout();
            this.menuVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListadoClientes
            // 
            this.grbListadoClientes.Controls.Add(this.lblTotalClientes);
            this.grbListadoClientes.Controls.Add(this.Grilla);
            this.grbListadoClientes.Controls.Add(this.BtnBuscar);
            this.grbListadoClientes.Controls.Add(this.txtFiltro);
            this.grbListadoClientes.Controls.Add(this.lblTitulo);
            this.grbListadoClientes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListadoClientes.Location = new System.Drawing.Point(8, 208);
            this.grbListadoClientes.Name = "grbListadoClientes";
            this.grbListadoClientes.Size = new System.Drawing.Size(612, 312);
            this.grbListadoClientes.TabIndex = 7;
            this.grbListadoClientes.TabStop = false;
            this.grbListadoClientes.Text = "Listado de Clientes";
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(437, 282);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(164, 25);
            this.lblTotalClientes.TabIndex = 195;
            this.lblTotalClientes.Text = "Total Clientes: {0}";
            this.lblTotalClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Grilla.Size = new System.Drawing.Size(591, 230);
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
            this.Nombre.Width = 200;
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
            this.BtnBuscar.Location = new System.Drawing.Point(501, 18);
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
            this.txtFiltro.Size = new System.Drawing.Size(363, 25);
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
            // grbDefinicionClientes
            // 
            this.grbDefinicionClientes.Controls.Add(this.BtnGuardar);
            this.grbDefinicionClientes.Controls.Add(this.lblBarrio);
            this.grbDefinicionClientes.Controls.Add(this.txtBarrio);
            this.grbDefinicionClientes.Controls.Add(this.lblCelular);
            this.grbDefinicionClientes.Controls.Add(this.txtCelular);
            this.grbDefinicionClientes.Controls.Add(this.txtNombre);
            this.grbDefinicionClientes.Controls.Add(this.lblNombreCliente);
            this.grbDefinicionClientes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDefinicionClientes.Location = new System.Drawing.Point(8, 26);
            this.grbDefinicionClientes.Name = "grbDefinicionClientes";
            this.grbDefinicionClientes.Size = new System.Drawing.Size(612, 176);
            this.grbDefinicionClientes.TabIndex = 6;
            this.grbDefinicionClientes.TabStop = false;
            this.grbDefinicionClientes.Text = "Definición de Clientes";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.Olive;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(400, 133);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 25);
            this.BtnGuardar.TabIndex = 194;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblBarrio
            // 
            this.lblBarrio.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(88, 102);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(75, 25);
            this.lblBarrio.TabIndex = 194;
            this.lblBarrio.Text = "Barrio";
            this.lblBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.Location = new System.Drawing.Point(168, 102);
            this.txtBarrio.MaxLength = 50;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(332, 25);
            this.txtBarrio.TabIndex = 193;
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(88, 67);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(75, 25);
            this.lblCelular.TabIndex = 192;
            this.lblCelular.Text = "Celular";
            this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(168, 67);
            this.txtCelular.MaxLength = 20;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(332, 25);
            this.txtCelular.TabIndex = 191;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(168, 32);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 25);
            this.txtNombre.TabIndex = 190;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(88, 32);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(75, 25);
            this.lblNombreCliente.TabIndex = 190;
            this.lblNombreCliente.Text = "Nombre Cliente";
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuVendedor
            // 
            this.menuVendedor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuVendedor.Location = new System.Drawing.Point(0, 0);
            this.menuVendedor.Name = "menuVendedor";
            this.menuVendedor.Size = new System.Drawing.Size(634, 24);
            this.menuVendedor.TabIndex = 8;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 532);
            this.Controls.Add(this.grbListadoClientes);
            this.Controls.Add(this.grbDefinicionClientes);
            this.Controls.Add(this.menuVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.Text = "Administración de Clientes";
            this.grbListadoClientes.ResumeLayout(false);
            this.grbListadoClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbDefinicionClientes.ResumeLayout(false);
            this.grbDefinicionClientes.PerformLayout();
            this.menuVendedor.ResumeLayout(false);
            this.menuVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListadoClientes;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbDefinicionClientes;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.MenuStrip menuVendedor;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.Label lblTotalClientes;
    }
}