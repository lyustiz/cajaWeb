namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmDevolucionCodigoBarras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucionCodigoBarras));
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.grbCartones = new System.Windows.Forms.GroupBox();
            this.LstOrden = new System.Windows.Forms.ListBox();
            this.txtRelojCartones = new System.Windows.Forms.TextBox();
            this.lblRelojCartones = new System.Windows.Forms.Label();
            this.lstCartones = new System.Windows.Forms.ListBox();
            this.txtCartonesDevueltos = new System.Windows.Forms.TextBox();
            this.lblTotalCartonesDevueltos = new System.Windows.Forms.Label();
            this.grbHojas = new System.Windows.Forms.GroupBox();
            this.txtRelojHojas = new System.Windows.Forms.TextBox();
            this.lblRelojHojas = new System.Windows.Forms.Label();
            this.lstHojas = new System.Windows.Forms.ListBox();
            this.txtHojasDevueltas = new System.Windows.Forms.TextBox();
            this.lblTotalHojasDevueltas = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.grbRegistro.SuspendLayout();
            this.grbCartones.SuspendLayout();
            this.grbHojas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Green;
            this.lblNombreVendedor.Location = new System.Drawing.Point(12, 9);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(609, 30);
            this.lblNombreVendedor.TabIndex = 1;
            this.lblNombreVendedor.Text = "{ Nombre Vendedor }";
            this.lblNombreVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbRegistro
            // 
            this.grbRegistro.Controls.Add(this.BtnBorrar);
            this.grbRegistro.Controls.Add(this.BtnRegistrar);
            this.grbRegistro.Controls.Add(this.txtRegistro);
            this.grbRegistro.Controls.Add(this.lblRegistro);
            this.grbRegistro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistro.Location = new System.Drawing.Point(12, 42);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Size = new System.Drawing.Size(609, 79);
            this.grbRegistro.TabIndex = 2;
            this.grbRegistro.TabStop = false;
            this.grbRegistro.Text = "Registro";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBorrar.BackColor = System.Drawing.Color.Olive;
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Image")));
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrar.Location = new System.Drawing.Point(459, 28);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(135, 25);
            this.BtnBorrar.TabIndex = 55;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegistrar.BackColor = System.Drawing.Color.Olive;
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(318, 28);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(135, 25);
            this.BtnRegistrar.TabIndex = 54;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtRegistro
            // 
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(126, 26);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(186, 29);
            this.txtRegistro.TabIndex = 53;
            this.txtRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRegistro_KeyUp);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(11, 26);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(109, 29);
            this.lblRegistro.TabIndex = 15;
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbCartones
            // 
            this.grbCartones.Controls.Add(this.LstOrden);
            this.grbCartones.Controls.Add(this.txtRelojCartones);
            this.grbCartones.Controls.Add(this.lblRelojCartones);
            this.grbCartones.Controls.Add(this.lstCartones);
            this.grbCartones.Controls.Add(this.txtCartonesDevueltos);
            this.grbCartones.Controls.Add(this.lblTotalCartonesDevueltos);
            this.grbCartones.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCartones.Location = new System.Drawing.Point(12, 127);
            this.grbCartones.Name = "grbCartones";
            this.grbCartones.Size = new System.Drawing.Size(299, 416);
            this.grbCartones.TabIndex = 56;
            this.grbCartones.TabStop = false;
            this.grbCartones.Text = "Cartones Individuales";
            // 
            // LstOrden
            // 
            this.LstOrden.Enabled = false;
            this.LstOrden.FormattingEnabled = true;
            this.LstOrden.Location = new System.Drawing.Point(184, 55);
            this.LstOrden.Name = "LstOrden";
            this.LstOrden.Size = new System.Drawing.Size(75, 212);
            this.LstOrden.TabIndex = 57;
            this.LstOrden.Visible = false;
            // 
            // txtRelojCartones
            // 
            this.txtRelojCartones.BackColor = System.Drawing.Color.Black;
            this.txtRelojCartones.Enabled = false;
            this.txtRelojCartones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelojCartones.ForeColor = System.Drawing.Color.White;
            this.txtRelojCartones.Location = new System.Drawing.Point(150, 371);
            this.txtRelojCartones.Name = "txtRelojCartones";
            this.txtRelojCartones.Size = new System.Drawing.Size(109, 29);
            this.txtRelojCartones.TabIndex = 56;
            this.txtRelojCartones.Text = "00:00";
            this.txtRelojCartones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRelojCartones
            // 
            this.lblRelojCartones.AutoSize = true;
            this.lblRelojCartones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelojCartones.Location = new System.Drawing.Point(42, 374);
            this.lblRelojCartones.Name = "lblRelojCartones";
            this.lblRelojCartones.Size = new System.Drawing.Size(102, 24);
            this.lblRelojCartones.TabIndex = 55;
            this.lblRelojCartones.Text = "Ultimo Reg";
            // 
            // lstCartones
            // 
            this.lstCartones.FormattingEnabled = true;
            this.lstCartones.Location = new System.Drawing.Point(15, 21);
            this.lstCartones.Name = "lstCartones";
            this.lstCartones.Size = new System.Drawing.Size(267, 290);
            this.lstCartones.TabIndex = 54;
            // 
            // txtCartonesDevueltos
            // 
            this.txtCartonesDevueltos.Enabled = false;
            this.txtCartonesDevueltos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonesDevueltos.Location = new System.Drawing.Point(150, 326);
            this.txtCartonesDevueltos.Name = "txtCartonesDevueltos";
            this.txtCartonesDevueltos.Size = new System.Drawing.Size(132, 29);
            this.txtCartonesDevueltos.TabIndex = 53;
            this.txtCartonesDevueltos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalCartonesDevueltos
            // 
            this.lblTotalCartonesDevueltos.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCartonesDevueltos.Location = new System.Drawing.Point(11, 326);
            this.lblTotalCartonesDevueltos.Name = "lblTotalCartonesDevueltos";
            this.lblTotalCartonesDevueltos.Size = new System.Drawing.Size(133, 29);
            this.lblTotalCartonesDevueltos.TabIndex = 15;
            this.lblTotalCartonesDevueltos.Text = "Total Devueltos";
            this.lblTotalCartonesDevueltos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbHojas
            // 
            this.grbHojas.Controls.Add(this.txtRelojHojas);
            this.grbHojas.Controls.Add(this.lblRelojHojas);
            this.grbHojas.Controls.Add(this.lstHojas);
            this.grbHojas.Controls.Add(this.txtHojasDevueltas);
            this.grbHojas.Controls.Add(this.lblTotalHojasDevueltas);
            this.grbHojas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHojas.Location = new System.Drawing.Point(322, 127);
            this.grbHojas.Name = "grbHojas";
            this.grbHojas.Size = new System.Drawing.Size(299, 416);
            this.grbHojas.TabIndex = 57;
            this.grbHojas.TabStop = false;
            this.grbHojas.Text = "Registro de Hojas";
            // 
            // txtRelojHojas
            // 
            this.txtRelojHojas.BackColor = System.Drawing.Color.Black;
            this.txtRelojHojas.Enabled = false;
            this.txtRelojHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelojHojas.ForeColor = System.Drawing.Color.White;
            this.txtRelojHojas.Location = new System.Drawing.Point(150, 371);
            this.txtRelojHojas.Name = "txtRelojHojas";
            this.txtRelojHojas.Size = new System.Drawing.Size(109, 29);
            this.txtRelojHojas.TabIndex = 56;
            this.txtRelojHojas.Text = "00:00";
            this.txtRelojHojas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRelojHojas
            // 
            this.lblRelojHojas.AutoSize = true;
            this.lblRelojHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelojHojas.Location = new System.Drawing.Point(42, 374);
            this.lblRelojHojas.Name = "lblRelojHojas";
            this.lblRelojHojas.Size = new System.Drawing.Size(102, 24);
            this.lblRelojHojas.TabIndex = 55;
            this.lblRelojHojas.Text = "Ultimo Reg";
            // 
            // lstHojas
            // 
            this.lstHojas.FormattingEnabled = true;
            this.lstHojas.Location = new System.Drawing.Point(15, 21);
            this.lstHojas.Name = "lstHojas";
            this.lstHojas.Size = new System.Drawing.Size(267, 290);
            this.lstHojas.TabIndex = 54;
            // 
            // txtHojasDevueltas
            // 
            this.txtHojasDevueltas.Enabled = false;
            this.txtHojasDevueltas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHojasDevueltas.Location = new System.Drawing.Point(150, 326);
            this.txtHojasDevueltas.Name = "txtHojasDevueltas";
            this.txtHojasDevueltas.Size = new System.Drawing.Size(132, 29);
            this.txtHojasDevueltas.TabIndex = 53;
            this.txtHojasDevueltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalHojasDevueltas
            // 
            this.lblTotalHojasDevueltas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHojasDevueltas.Location = new System.Drawing.Point(11, 326);
            this.lblTotalHojasDevueltas.Name = "lblTotalHojasDevueltas";
            this.lblTotalHojasDevueltas.Size = new System.Drawing.Size(133, 29);
            this.lblTotalHojasDevueltas.TabIndex = 15;
            this.lblTotalHojasDevueltas.Text = "Total Devueltas";
            this.lblTotalHojasDevueltas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // FrmDevolucionCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 554);
            this.Controls.Add(this.grbHojas);
            this.Controls.Add(this.grbCartones);
            this.Controls.Add(this.grbRegistro);
            this.Controls.Add(this.lblNombreVendedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDevolucionCodigoBarras";
            this.Text = "Devolución de Cartones con Código de Barras";
            this.grbRegistro.ResumeLayout(false);
            this.grbRegistro.PerformLayout();
            this.grbCartones.ResumeLayout(false);
            this.grbCartones.PerformLayout();
            this.grbHojas.ResumeLayout(false);
            this.grbHojas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.GroupBox grbCartones;
        internal System.Windows.Forms.TextBox txtRelojCartones;
        internal System.Windows.Forms.Label lblRelojCartones;
        private System.Windows.Forms.ListBox lstCartones;
        private System.Windows.Forms.TextBox txtCartonesDevueltos;
        private System.Windows.Forms.Label lblTotalCartonesDevueltos;
        private System.Windows.Forms.GroupBox grbHojas;
        internal System.Windows.Forms.TextBox txtRelojHojas;
        internal System.Windows.Forms.Label lblRelojHojas;
        private System.Windows.Forms.ListBox lstHojas;
        private System.Windows.Forms.TextBox txtHojasDevueltas;
        private System.Windows.Forms.Label lblTotalHojasDevueltas;
        internal System.Windows.Forms.ListBox LstOrden;
        internal System.Windows.Forms.Timer tmrReloj;
    }
}