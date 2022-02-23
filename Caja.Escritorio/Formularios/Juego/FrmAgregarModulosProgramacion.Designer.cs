
namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmAgregarModulosProgramacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarModulosProgramacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.EliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCantidadVendedor = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lstModulos = new System.Windows.Forms.ListBox();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GrillaBusqueda = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txBusqueda = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txModulo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.menuVentana.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBusqueda)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EliminarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuVentana.Size = new System.Drawing.Size(1058, 24);
            this.menuVentana.TabIndex = 5;
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EliminarToolStripMenuItem.Image")));
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.EliminarToolStripMenuItem.Text = "Eliminar Módulos";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnBuscar);
            this.GroupBox1.Controls.Add(this.lbCantidadVendedor);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.lstModulos);
            this.GroupBox1.Controls.Add(this.cmbJuegos);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.GrillaBusqueda);
            this.GroupBox1.Controls.Add(this.txBusqueda);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(8, 38);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1037, 357);
            this.GroupBox1.TabIndex = 46;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Búsqueda Vendedor";
            // 
            // lbCantidadVendedor
            // 
            this.lbCantidadVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCantidadVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadVendedor.Location = new System.Drawing.Point(931, 18);
            this.lbCantidadVendedor.Name = "lbCantidadVendedor";
            this.lbCantidadVendedor.Size = new System.Drawing.Size(99, 39);
            this.lbCantidadVendedor.TabIndex = 50;
            this.lbCantidadVendedor.Text = "0";
            this.lbCantidadVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.Label3.Location = new System.Drawing.Point(705, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(155, 21);
            this.Label3.TabIndex = 49;
            this.Label3.Text = "# Modulos Vendedor";
            // 
            // lstModulos
            // 
            this.lstModulos.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lstModulos.FormattingEnabled = true;
            this.lstModulos.ItemHeight = 17;
            this.lstModulos.Location = new System.Drawing.Point(709, 68);
            this.lstModulos.Name = "lstModulos";
            this.lstModulos.Size = new System.Drawing.Size(320, 276);
            this.lstModulos.TabIndex = 36;
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.Location = new System.Drawing.Point(603, 26);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(75, 28);
            this.cmbJuegos.TabIndex = 35;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.Label5.Location = new System.Drawing.Point(439, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(158, 25);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Número de Juego";
            // 
            // GrillaBusqueda
            // 
            this.GrillaBusqueda.AllowUserToAddRows = false;
            this.GrillaBusqueda.AllowUserToDeleteRows = false;
            this.GrillaBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataGridViewTextBoxColumn1,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Celular});
            this.GrillaBusqueda.Location = new System.Drawing.Point(10, 61);
            this.GrillaBusqueda.Name = "GrillaBusqueda";
            this.GrillaBusqueda.ReadOnly = true;
            this.GrillaBusqueda.Size = new System.Drawing.Size(668, 288);
            this.GrillaBusqueda.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Codigo Vendedor";
            this.DataGridViewTextBoxColumn1.MaxInputLength = 5;
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // Documento
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle1;
            this.Documento.HeaderText = "Juego";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Visible = false;
            this.Documento.Width = 120;
            // 
            // Celular
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Celular.DefaultCellStyle = dataGridViewCellStyle2;
            this.Celular.HeaderText = "No. Hojas";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Visible = false;
            this.Celular.Width = 90;
            // 
            // txBusqueda
            // 
            this.txBusqueda.Location = new System.Drawing.Point(133, 27);
            this.txBusqueda.Name = "txBusqueda";
            this.txBusqueda.Size = new System.Drawing.Size(194, 23);
            this.txBusqueda.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 31);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(116, 15);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Criterio de Búsqueda";
            // 
            // lbTotal
            // 
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lbTotal.Location = new System.Drawing.Point(815, 442);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(116, 39);
            this.lbTotal.TabIndex = 55;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.Label1.Location = new System.Drawing.Point(717, 404);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(320, 36);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "# Modulos en juego";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txModulo
            // 
            this.txModulo.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.txModulo.Location = new System.Drawing.Point(528, 447);
            this.txModulo.MaxLength = 100;
            this.txModulo.Name = "txModulo";
            this.txModulo.Size = new System.Drawing.Size(93, 32);
            this.txModulo.TabIndex = 51;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.Label2.Location = new System.Drawing.Point(474, 404);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(212, 36);
            this.Label2.TabIndex = 50;
            this.Label2.Text = "Agregar Módulo al Juego";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblNombreVendedor);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.GroupBox2.Location = new System.Drawing.Point(8, 404);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(460, 92);
            this.GroupBox2.TabIndex = 56;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Vendedor";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Green;
            this.lblNombreVendedor.Location = new System.Drawing.Point(10, 29);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(444, 35);
            this.lblNombreVendedor.TabIndex = 1;
            this.lblNombreVendedor.Text = "{ Nombre Vendedor }";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnBuscar.Location = new System.Drawing.Point(333, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 25);
            this.BtnBuscar.TabIndex = 190;
            this.BtnBuscar.Text = "Filtrar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmAgregarModulosProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 516);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txModulo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuVentana);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarModulosProgramacion";
            this.Text = "Agregar Módulos Programación";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBusqueda)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem EliminarToolStripMenuItem;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lbCantidadVendedor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox lstModulos;
        internal System.Windows.Forms.ComboBox cmbJuegos;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DataGridView GrillaBusqueda;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Id;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        internal System.Windows.Forms.TextBox txBusqueda;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lbTotal;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txModulo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Button BtnBuscar;
    }
}