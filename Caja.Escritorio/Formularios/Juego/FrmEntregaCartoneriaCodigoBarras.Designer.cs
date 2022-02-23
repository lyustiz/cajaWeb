
namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmEntregaCartoneriaCodigoBarras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntregaCartoneriaCodigoBarras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txHoja = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chkDevoluciones = new System.Windows.Forms.CheckBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProgramacionJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumaDeNumeroHoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.txHoja);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.GroupBox3.Location = new System.Drawing.Point(451, 383);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(268, 80);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Registro de Hojas";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.Label3.Location = new System.Drawing.Point(6, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 37);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Hoja";
            // 
            // txHoja
            // 
            this.txHoja.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.txHoja.Location = new System.Drawing.Point(82, 26);
            this.txHoja.Name = "txHoja";
            this.txHoja.Size = new System.Drawing.Size(176, 43);
            this.txHoja.TabIndex = 15;
            this.txHoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txHoja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txHoja_KeyUp);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblNombreVendedor);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.GroupBox2.Location = new System.Drawing.Point(7, 383);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(440, 80);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Vendedor";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Green;
            this.lblNombreVendedor.Location = new System.Drawing.Point(9, 25);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(425, 30);
            this.lblNombreVendedor.TabIndex = 1;
            this.lblNombreVendedor.Text = "{ Nombre Vendedor }";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnBuscar);
            this.GroupBox1.Controls.Add(this.txtFiltro);
            this.GroupBox1.Controls.Add(this.lblTitulo);
            this.GroupBox1.Controls.Add(this.chkDevoluciones);
            this.GroupBox1.Controls.Add(this.Grilla);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.GroupBox1.Location = new System.Drawing.Point(7, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(712, 371);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Búsqueda Vendedor";
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
            this.BtnBuscar.Location = new System.Drawing.Point(424, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 25);
            this.BtnBuscar.TabIndex = 189;
            this.BtnBuscar.Text = "Filtrar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(137, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(281, 25);
            this.txtFiltro.TabIndex = 170;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(125, 25);
            this.lblTitulo.TabIndex = 169;
            this.lblTitulo.Text = "Criterio de Búsqueda";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkDevoluciones
            // 
            this.chkDevoluciones.AutoSize = true;
            this.chkDevoluciones.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.chkDevoluciones.Location = new System.Drawing.Point(530, 21);
            this.chkDevoluciones.Name = "chkDevoluciones";
            this.chkDevoluciones.Size = new System.Drawing.Size(172, 21);
            this.chkDevoluciones.TabIndex = 6;
            this.chkDevoluciones.Text = "ACTIVAR DEVOLUCIONES";
            this.chkDevoluciones.UseVisualStyleBackColor = true;
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVendedor,
            this.Codigo,
            this.Nombres,
            this.Apellidos,
            this.IdProgramacionJuego,
            this.SumaDeNumeroHoja});
            this.Grilla.Location = new System.Drawing.Point(9, 53);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(693, 305);
            this.Grilla.TabIndex = 5;
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaBusqueda_CellClick);
            // 
            // IdVendedor
            // 
            this.IdVendedor.HeaderText = "Id";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.ReadOnly = true;
            this.IdVendedor.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Vendedor";
            this.Codigo.MaxInputLength = 5;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 170;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellido";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 170;
            // 
            // IdProgramacionJuego
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdProgramacionJuego.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdProgramacionJuego.HeaderText = "Juego No.";
            this.IdProgramacionJuego.Name = "IdProgramacionJuego";
            this.IdProgramacionJuego.ReadOnly = true;
            this.IdProgramacionJuego.Width = 120;
            // 
            // SumaDeNumeroHoja
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SumaDeNumeroHoja.DefaultCellStyle = dataGridViewCellStyle2;
            this.SumaDeNumeroHoja.HeaderText = "No. Hojas";
            this.SumaDeNumeroHoja.Name = "SumaDeNumeroHoja";
            this.SumaDeNumeroHoja.ReadOnly = true;
            this.SumaDeNumeroHoja.Width = 90;
            // 
            // FrmEntregaCartoneriaCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 474);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntregaCartoneriaCodigoBarras";
            this.Text = "Entrega de Cartonería por Codigo de Barras";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txHoja;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkDevoluciones;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProgramacionJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumaDeNumeroHoja;
        private System.Windows.Forms.Label lblNombreVendedor;
    }
}