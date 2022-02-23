namespace Caja.Escritorio.Formularios.Administracion.Modulos
{
    partial class FrmDefinicionModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDefinicionModulos));
            this.grbListadoModulos = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carton1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carton2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carton3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carton4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carton5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carton6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDefinicionModulos = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblCarton6 = new System.Windows.Forms.Label();
            this.txtCarton6 = new System.Windows.Forms.TextBox();
            this.lblCarton5 = new System.Windows.Forms.Label();
            this.txtCarton5 = new System.Windows.Forms.TextBox();
            this.lblCarton4 = new System.Windows.Forms.Label();
            this.txtCarton4 = new System.Windows.Forms.TextBox();
            this.lblCarton3 = new System.Windows.Forms.Label();
            this.txtCarton3 = new System.Windows.Forms.TextBox();
            this.lblCarton2 = new System.Windows.Forms.Label();
            this.txtCarton2 = new System.Windows.Forms.TextBox();
            this.lblCarton1 = new System.Windows.Forms.Label();
            this.txtCarton1 = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.menuVendedor = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbListadoModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbDefinicionModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.menuVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListadoModulos
            // 
            this.grbListadoModulos.Controls.Add(this.Grilla);
            this.grbListadoModulos.Controls.Add(this.BtnBuscar);
            this.grbListadoModulos.Controls.Add(this.txtFiltro);
            this.grbListadoModulos.Controls.Add(this.lblTitulo);
            this.grbListadoModulos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListadoModulos.Location = new System.Drawing.Point(8, 174);
            this.grbListadoModulos.Name = "grbListadoModulos";
            this.grbListadoModulos.Size = new System.Drawing.Size(913, 289);
            this.grbListadoModulos.TabIndex = 4;
            this.grbListadoModulos.TabStop = false;
            this.grbListadoModulos.Text = "Listado de Módulos";
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
            this.Numero,
            this.Carton1,
            this.Serie1,
            this.Carton2,
            this.Serie2,
            this.Carton3,
            this.Serie3,
            this.Carton4,
            this.Serie4,
            this.Carton5,
            this.Serie5,
            this.Carton6,
            this.Serie6});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(10, 49);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(892, 230);
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
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 70;
            // 
            // Carton1
            // 
            this.Carton1.DividerWidth = 1;
            this.Carton1.HeaderText = "Cartón 1";
            this.Carton1.Name = "Carton1";
            this.Carton1.ReadOnly = true;
            this.Carton1.Width = 80;
            // 
            // Serie1
            // 
            this.Serie1.DividerWidth = 1;
            this.Serie1.HeaderText = "Serie 1";
            this.Serie1.Name = "Serie1";
            this.Serie1.ReadOnly = true;
            this.Serie1.Width = 50;
            // 
            // Carton2
            // 
            this.Carton2.DividerWidth = 1;
            this.Carton2.HeaderText = "Cartón 2";
            this.Carton2.Name = "Carton2";
            this.Carton2.ReadOnly = true;
            this.Carton2.Width = 80;
            // 
            // Serie2
            // 
            this.Serie2.HeaderText = "Serie2";
            this.Serie2.Name = "Serie2";
            this.Serie2.ReadOnly = true;
            this.Serie2.Width = 50;
            // 
            // Carton3
            // 
            this.Carton3.HeaderText = "Cartón 3";
            this.Carton3.Name = "Carton3";
            this.Carton3.ReadOnly = true;
            this.Carton3.Width = 80;
            // 
            // Serie3
            // 
            this.Serie3.HeaderText = "Serie 3";
            this.Serie3.Name = "Serie3";
            this.Serie3.ReadOnly = true;
            this.Serie3.Width = 50;
            // 
            // Carton4
            // 
            this.Carton4.HeaderText = "Cartón 4";
            this.Carton4.Name = "Carton4";
            this.Carton4.ReadOnly = true;
            this.Carton4.Width = 80;
            // 
            // Serie4
            // 
            this.Serie4.HeaderText = "Serie 4";
            this.Serie4.Name = "Serie4";
            this.Serie4.ReadOnly = true;
            this.Serie4.Width = 50;
            // 
            // Carton5
            // 
            this.Carton5.HeaderText = "Cartón 5";
            this.Carton5.Name = "Carton5";
            this.Carton5.ReadOnly = true;
            this.Carton5.Width = 80;
            // 
            // Serie5
            // 
            this.Serie5.HeaderText = "Serie 5";
            this.Serie5.Name = "Serie5";
            this.Serie5.ReadOnly = true;
            this.Serie5.Width = 50;
            // 
            // Carton6
            // 
            this.Carton6.HeaderText = "Cartón 6";
            this.Carton6.Name = "Carton6";
            this.Carton6.ReadOnly = true;
            this.Carton6.Width = 80;
            // 
            // Serie6
            // 
            this.Serie6.HeaderText = "Serie 6";
            this.Serie6.Name = "Serie6";
            this.Serie6.ReadOnly = true;
            this.Serie6.Width = 50;
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
            this.BtnBuscar.Location = new System.Drawing.Point(802, 19);
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
            this.txtFiltro.Size = new System.Drawing.Size(662, 25);
            this.txtFiltro.TabIndex = 168;
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
            // grbDefinicionModulos
            // 
            this.grbDefinicionModulos.Controls.Add(this.BtnGuardar);
            this.grbDefinicionModulos.Controls.Add(this.lblCarton6);
            this.grbDefinicionModulos.Controls.Add(this.txtCarton6);
            this.grbDefinicionModulos.Controls.Add(this.lblCarton5);
            this.grbDefinicionModulos.Controls.Add(this.txtCarton5);
            this.grbDefinicionModulos.Controls.Add(this.lblCarton4);
            this.grbDefinicionModulos.Controls.Add(this.txtCarton4);
            this.grbDefinicionModulos.Controls.Add(this.lblCarton3);
            this.grbDefinicionModulos.Controls.Add(this.txtCarton3);
            this.grbDefinicionModulos.Controls.Add(this.lblCarton2);
            this.grbDefinicionModulos.Controls.Add(this.txtCarton2);
            this.grbDefinicionModulos.Controls.Add(this.lblCarton1);
            this.grbDefinicionModulos.Controls.Add(this.txtCarton1);
            this.grbDefinicionModulos.Controls.Add(this.txtNumero);
            this.grbDefinicionModulos.Controls.Add(this.lblNumero);
            this.grbDefinicionModulos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDefinicionModulos.Location = new System.Drawing.Point(8, 32);
            this.grbDefinicionModulos.Name = "grbDefinicionModulos";
            this.grbDefinicionModulos.Size = new System.Drawing.Size(913, 133);
            this.grbDefinicionModulos.TabIndex = 3;
            this.grbDefinicionModulos.TabStop = false;
            this.grbDefinicionModulos.Text = "Definición de Módulos";
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
            this.BtnGuardar.Location = new System.Drawing.Point(802, 79);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 25);
            this.BtnGuardar.TabIndex = 202;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblCarton6
            // 
            this.lblCarton6.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton6.Location = new System.Drawing.Point(802, 16);
            this.lblCarton6.Name = "lblCarton6";
            this.lblCarton6.Size = new System.Drawing.Size(100, 25);
            this.lblCarton6.TabIndex = 202;
            this.lblCarton6.Text = "Cartón 6";
            this.lblCarton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarton6
            // 
            this.txtCarton6.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarton6.Location = new System.Drawing.Point(802, 46);
            this.txtCarton6.Name = "txtCarton6";
            this.txtCarton6.Size = new System.Drawing.Size(100, 25);
            this.txtCarton6.TabIndex = 201;
            // 
            // lblCarton5
            // 
            this.lblCarton5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton5.Location = new System.Drawing.Point(696, 16);
            this.lblCarton5.Name = "lblCarton5";
            this.lblCarton5.Size = new System.Drawing.Size(100, 25);
            this.lblCarton5.TabIndex = 200;
            this.lblCarton5.Text = "Cartón 5";
            this.lblCarton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarton5
            // 
            this.txtCarton5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarton5.Location = new System.Drawing.Point(696, 46);
            this.txtCarton5.Name = "txtCarton5";
            this.txtCarton5.Size = new System.Drawing.Size(100, 25);
            this.txtCarton5.TabIndex = 199;
            // 
            // lblCarton4
            // 
            this.lblCarton4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton4.Location = new System.Drawing.Point(590, 16);
            this.lblCarton4.Name = "lblCarton4";
            this.lblCarton4.Size = new System.Drawing.Size(100, 25);
            this.lblCarton4.TabIndex = 198;
            this.lblCarton4.Text = "Cartón 4";
            this.lblCarton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarton4
            // 
            this.txtCarton4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarton4.Location = new System.Drawing.Point(590, 46);
            this.txtCarton4.Name = "txtCarton4";
            this.txtCarton4.Size = new System.Drawing.Size(100, 25);
            this.txtCarton4.TabIndex = 197;
            // 
            // lblCarton3
            // 
            this.lblCarton3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton3.Location = new System.Drawing.Point(484, 16);
            this.lblCarton3.Name = "lblCarton3";
            this.lblCarton3.Size = new System.Drawing.Size(100, 25);
            this.lblCarton3.TabIndex = 196;
            this.lblCarton3.Text = "Cartón 3";
            this.lblCarton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarton3
            // 
            this.txtCarton3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarton3.Location = new System.Drawing.Point(484, 46);
            this.txtCarton3.Name = "txtCarton3";
            this.txtCarton3.Size = new System.Drawing.Size(100, 25);
            this.txtCarton3.TabIndex = 195;
            // 
            // lblCarton2
            // 
            this.lblCarton2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton2.Location = new System.Drawing.Point(378, 16);
            this.lblCarton2.Name = "lblCarton2";
            this.lblCarton2.Size = new System.Drawing.Size(100, 25);
            this.lblCarton2.TabIndex = 194;
            this.lblCarton2.Text = "Cartón 2";
            this.lblCarton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarton2
            // 
            this.txtCarton2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarton2.Location = new System.Drawing.Point(378, 46);
            this.txtCarton2.Name = "txtCarton2";
            this.txtCarton2.Size = new System.Drawing.Size(100, 25);
            this.txtCarton2.TabIndex = 193;
            // 
            // lblCarton1
            // 
            this.lblCarton1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton1.Location = new System.Drawing.Point(272, 16);
            this.lblCarton1.Name = "lblCarton1";
            this.lblCarton1.Size = new System.Drawing.Size(100, 25);
            this.lblCarton1.TabIndex = 192;
            this.lblCarton1.Text = "Cartón 1";
            this.lblCarton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCarton1
            // 
            this.txtCarton1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarton1.Location = new System.Drawing.Point(272, 46);
            this.txtCarton1.Name = "txtCarton1";
            this.txtCarton1.Size = new System.Drawing.Size(100, 25);
            this.txtCarton1.TabIndex = 191;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(90, 45);
            this.txtNumero.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(164, 25);
            this.txtNumero.TabIndex = 190;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(10, 45);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(75, 25);
            this.lblNumero.TabIndex = 190;
            this.lblNumero.Text = "Número";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuVendedor
            // 
            this.menuVendedor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVendedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuVendedor.Location = new System.Drawing.Point(0, 0);
            this.menuVendedor.Name = "menuVendedor";
            this.menuVendedor.Size = new System.Drawing.Size(934, 24);
            this.menuVendedor.TabIndex = 5;
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // FrmDefinicionModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 475);
            this.Controls.Add(this.grbListadoModulos);
            this.Controls.Add(this.grbDefinicionModulos);
            this.Controls.Add(this.menuVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDefinicionModulos";
            this.Text = "Definición de Modulos";
            this.grbListadoModulos.ResumeLayout(false);
            this.grbListadoModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbDefinicionModulos.ResumeLayout(false);
            this.grbDefinicionModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.menuVendedor.ResumeLayout(false);
            this.menuVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListadoModulos;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbDefinicionModulos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblCarton6;
        private System.Windows.Forms.TextBox txtCarton6;
        private System.Windows.Forms.Label lblCarton5;
        private System.Windows.Forms.TextBox txtCarton5;
        private System.Windows.Forms.Label lblCarton4;
        private System.Windows.Forms.TextBox txtCarton4;
        private System.Windows.Forms.Label lblCarton3;
        private System.Windows.Forms.TextBox txtCarton3;
        private System.Windows.Forms.Label lblCarton2;
        private System.Windows.Forms.TextBox txtCarton2;
        private System.Windows.Forms.Label lblCarton1;
        private System.Windows.Forms.TextBox txtCarton1;
        private System.Windows.Forms.NumericUpDown txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MenuStrip menuVendedor;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie6;
    }
}