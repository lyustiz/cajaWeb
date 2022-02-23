
namespace Caja.Escritorio.Formularios.Caja
{
    partial class FrmDineroBancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDineroBancos));
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.AlmacenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.cmdMeses = new System.Windows.Forms.ComboBox();
            this.cmdAnios = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txJuego = new System.Windows.Forms.TextBox();
            this.txPremios = new System.Windows.Forms.TextBox();
            this.txAyuda = new System.Windows.Forms.TextBox();
            this.txGastos = new System.Windows.Forms.TextBox();
            this.txIngresos = new System.Windows.Forms.TextBox();
            this.txCuadreCierre = new System.Windows.Forms.TextBox();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.txBancos = new System.Windows.Forms.TextBox();
            this.txEfectivo = new System.Windows.Forms.TextBox();
            this.grbValores = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txInicial = new System.Windows.Forms.TextBox();
            this.menuVentana.SuspendLayout();
            this.grbValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlmacenarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(522, 36);
            this.menuVentana.TabIndex = 13;
            // 
            // AlmacenarToolStripMenuItem
            // 
            this.AlmacenarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlmacenarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AlmacenarToolStripMenuItem.Image")));
            this.AlmacenarToolStripMenuItem.Name = "AlmacenarToolStripMenuItem";
            this.AlmacenarToolStripMenuItem.Size = new System.Drawing.Size(155, 32);
            this.AlmacenarToolStripMenuItem.Text = "ALMACENAR";
            this.AlmacenarToolStripMenuItem.Click += new System.EventHandler(this.AlmacenarToolStripMenuItem_Click);
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(358, 136);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(155, 36);
            this.cmdProgramacion.TabIndex = 18;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdProgramacion_SelectedIndexChanged);
            // 
            // cmdMeses
            // 
            this.cmdMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdMeses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMeses.FormattingEnabled = true;
            this.cmdMeses.Location = new System.Drawing.Point(358, 94);
            this.cmdMeses.Name = "cmdMeses";
            this.cmdMeses.Size = new System.Drawing.Size(155, 36);
            this.cmdMeses.TabIndex = 102;
            this.cmdMeses.SelectedIndexChanged += new System.EventHandler(this.cmdMeses_SelectedIndexChanged);
            // 
            // cmdAnios
            // 
            this.cmdAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdAnios.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnios.FormattingEnabled = true;
            this.cmdAnios.Location = new System.Drawing.Point(98, 92);
            this.cmdAnios.Name = "cmdAnios";
            this.cmdAnios.Size = new System.Drawing.Size(155, 36);
            this.cmdAnios.TabIndex = 100;
            this.cmdAnios.SelectedIndexChanged += new System.EventHandler(this.cmdAnios_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(2, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(518, 47);
            this.lblTitulo.TabIndex = 104;
            this.lblTitulo.Text = "Direccionamiento de Dinero";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.LightCoral;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMensaje.Location = new System.Drawing.Point(2, 200);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(518, 36);
            this.lblMensaje.TabIndex = 105;
            this.lblMensaje.Text = "NO";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txJuego
            // 
            this.txJuego.Enabled = false;
            this.txJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txJuego.Location = new System.Drawing.Point(285, 254);
            this.txJuego.Name = "txJuego";
            this.txJuego.Size = new System.Drawing.Size(206, 39);
            this.txJuego.TabIndex = 109;
            this.txJuego.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txPremios
            // 
            this.txPremios.Enabled = false;
            this.txPremios.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPremios.Location = new System.Drawing.Point(285, 299);
            this.txPremios.Name = "txPremios";
            this.txPremios.Size = new System.Drawing.Size(206, 39);
            this.txPremios.TabIndex = 110;
            this.txPremios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txAyuda
            // 
            this.txAyuda.Enabled = false;
            this.txAyuda.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAyuda.Location = new System.Drawing.Point(285, 344);
            this.txAyuda.Name = "txAyuda";
            this.txAyuda.Size = new System.Drawing.Size(206, 39);
            this.txAyuda.TabIndex = 111;
            this.txAyuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txGastos
            // 
            this.txGastos.Enabled = false;
            this.txGastos.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txGastos.Location = new System.Drawing.Point(285, 389);
            this.txGastos.Name = "txGastos";
            this.txGastos.Size = new System.Drawing.Size(206, 39);
            this.txGastos.TabIndex = 112;
            this.txGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txIngresos
            // 
            this.txIngresos.Enabled = false;
            this.txIngresos.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIngresos.Location = new System.Drawing.Point(285, 434);
            this.txIngresos.Name = "txIngresos";
            this.txIngresos.Size = new System.Drawing.Size(206, 39);
            this.txIngresos.TabIndex = 113;
            this.txIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txCuadreCierre
            // 
            this.txCuadreCierre.Enabled = false;
            this.txCuadreCierre.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCuadreCierre.Location = new System.Drawing.Point(285, 479);
            this.txCuadreCierre.Name = "txCuadreCierre";
            this.txCuadreCierre.Size = new System.Drawing.Size(206, 39);
            this.txCuadreCierre.TabIndex = 114;
            this.txCuadreCierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txTotal
            // 
            this.txTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txTotal.Enabled = false;
            this.txTotal.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.Location = new System.Drawing.Point(285, 524);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(206, 39);
            this.txTotal.TabIndex = 115;
            this.txTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txBancos
            // 
            this.txBancos.Enabled = false;
            this.txBancos.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBancos.Location = new System.Drawing.Point(279, 21);
            this.txBancos.Name = "txBancos";
            this.txBancos.Size = new System.Drawing.Size(206, 39);
            this.txBancos.TabIndex = 116;
            this.txBancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txEfectivo
            // 
            this.txEfectivo.Enabled = false;
            this.txEfectivo.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEfectivo.Location = new System.Drawing.Point(279, 66);
            this.txEfectivo.Name = "txEfectivo";
            this.txEfectivo.Size = new System.Drawing.Size(206, 39);
            this.txEfectivo.TabIndex = 117;
            this.txEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbValores
            // 
            this.grbValores.Controls.Add(this.label8);
            this.grbValores.Controls.Add(this.label7);
            this.grbValores.Controls.Add(this.txBancos);
            this.grbValores.Controls.Add(this.txEfectivo);
            this.grbValores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValores.Location = new System.Drawing.Point(6, 565);
            this.grbValores.Name = "grbValores";
            this.grbValores.Size = new System.Drawing.Size(507, 112);
            this.grbValores.TabIndex = 118;
            this.grbValores.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 39);
            this.label8.TabIndex = 121;
            this.label8.Text = "Valor en Efectivo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 39);
            this.label7.TabIndex = 120;
            this.label7.Text = "Valor para Consignar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal2
            // 
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.Location = new System.Drawing.Point(6, 254);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(245, 39);
            this.lblTotal2.TabIndex = 10;
            this.lblTotal2.Text = "Total Movimiento Juego";
            this.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 119;
            this.label1.Text = "Total Premios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 39);
            this.label2.TabIndex = 120;
            this.label2.Text = "Ayuda Social";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 39);
            this.label3.TabIndex = 121;
            this.label3.Text = "Gastos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 39);
            this.label4.TabIndex = 122;
            this.label4.Text = "Ingresos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 39);
            this.label5.TabIndex = 123;
            this.label5.Text = "Diferencia Cuadre Cierre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 39);
            this.label6.TabIndex = 124;
            this.label6.Text = "Total Dinero en Caja";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 34);
            this.label9.TabIndex = 125;
            this.label9.Text = "Año";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 35);
            this.label10.TabIndex = 126;
            this.label10.Text = "Mes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 35);
            this.label11.TabIndex = 127;
            this.label11.Text = "Juego para Revisar";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txInicial
            // 
            this.txInicial.Enabled = false;
            this.txInicial.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInicial.Location = new System.Drawing.Point(229, 168);
            this.txInicial.Name = "txInicial";
            this.txInicial.Size = new System.Drawing.Size(85, 29);
            this.txInicial.TabIndex = 128;
            this.txInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txInicial.Visible = false;
            // 
            // FrmDineroBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 689);
            this.Controls.Add(this.txInicial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdAnios);
            this.Controls.Add(this.cmdMeses);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.grbValores);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.txCuadreCierre);
            this.Controls.Add(this.txIngresos);
            this.Controls.Add(this.txGastos);
            this.Controls.Add(this.txAyuda);
            this.Controls.Add(this.txPremios);
            this.Controls.Add(this.txJuego);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdProgramacion);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDineroBancos";
            this.Text = "Direccionamiento de Dinero";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbValores.ResumeLayout(false);
            this.grbValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem AlmacenarToolStripMenuItem;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        internal System.Windows.Forms.ComboBox cmdMeses;
        internal System.Windows.Forms.ComboBox cmdAnios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txJuego;
        private System.Windows.Forms.TextBox txPremios;
        private System.Windows.Forms.TextBox txAyuda;
        private System.Windows.Forms.TextBox txGastos;
        private System.Windows.Forms.TextBox txIngresos;
        private System.Windows.Forms.TextBox txCuadreCierre;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.TextBox txBancos;
        private System.Windows.Forms.TextBox txEfectivo;
        private System.Windows.Forms.GroupBox grbValores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txInicial;
    }
}