
namespace Caja.Escritorio.Formularios.Juego
{
    partial class FrmDevolucionCartones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucionCartones));
            this.grbValoresActuales = new System.Windows.Forms.GroupBox();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbRegistroHojas = new System.Windows.Forms.GroupBox();
            this.lstHojas = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblHoja = new System.Windows.Forms.Label();
            this.txtHoja = new System.Windows.Forms.NumericUpDown();
            this.lblTotalHojas = new System.Windows.Forms.Label();
            this.grbValoresActuales.SuspendLayout();
            this.menuVentana.SuspendLayout();
            this.grbRegistroHojas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoja)).BeginInit();
            this.SuspendLayout();
            // 
            // grbValoresActuales
            // 
            this.grbValoresActuales.Controls.Add(this.cmdProgramacion);
            this.grbValoresActuales.Controls.Add(this.lblJuego);
            this.grbValoresActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValoresActuales.Location = new System.Drawing.Point(12, 37);
            this.grbValoresActuales.Name = "grbValoresActuales";
            this.grbValoresActuales.Size = new System.Drawing.Size(312, 57);
            this.grbValoresActuales.TabIndex = 8;
            this.grbValoresActuales.TabStop = false;
            this.grbValoresActuales.Text = "Juegos Activos";
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(120, 18);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(186, 23);
            this.cmdProgramacion.TabIndex = 2;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdProgramacion_SelectedIndexChanged);
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
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuardarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(342, 24);
            this.menuVentana.TabIndex = 7;
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripMenuItem.Image")));
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.GuardarToolStripMenuItem.Text = "Guardar";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // grbRegistroHojas
            // 
            this.grbRegistroHojas.Controls.Add(this.lstHojas);
            this.grbRegistroHojas.Controls.Add(this.btnQuitar);
            this.grbRegistroHojas.Controls.Add(this.btnAgregar);
            this.grbRegistroHojas.Controls.Add(this.lblHoja);
            this.grbRegistroHojas.Controls.Add(this.txtHoja);
            this.grbRegistroHojas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistroHojas.Location = new System.Drawing.Point(12, 100);
            this.grbRegistroHojas.Name = "grbRegistroHojas";
            this.grbRegistroHojas.Size = new System.Drawing.Size(312, 225);
            this.grbRegistroHojas.TabIndex = 9;
            this.grbRegistroHojas.TabStop = false;
            this.grbRegistroHojas.Text = "Registro de Hojas";
            // 
            // lstHojas
            // 
            this.lstHojas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHojas.FormattingEnabled = true;
            this.lstHojas.ItemHeight = 17;
            this.lstHojas.Location = new System.Drawing.Point(213, 12);
            this.lstHojas.Name = "lstHojas";
            this.lstHojas.Size = new System.Drawing.Size(93, 208);
            this.lstHojas.Sorted = true;
            this.lstHojas.TabIndex = 15;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(157, 122);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 30);
            this.btnQuitar.TabIndex = 14;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(157, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 30);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblHoja
            // 
            this.lblHoja.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoja.Location = new System.Drawing.Point(6, 51);
            this.lblHoja.Name = "lblHoja";
            this.lblHoja.Size = new System.Drawing.Size(145, 40);
            this.lblHoja.TabIndex = 11;
            this.lblHoja.Text = "Hoja";
            this.lblHoja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoja
            // 
            this.txtHoja.Font = new System.Drawing.Font("Segoe UI Semilight", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoja.Location = new System.Drawing.Point(6, 94);
            this.txtHoja.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(145, 52);
            this.txtHoja.TabIndex = 12;
            this.txtHoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHoja_KeyUp);
            // 
            // lblTotalHojas
            // 
            this.lblTotalHojas.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHojas.Location = new System.Drawing.Point(12, 344);
            this.lblTotalHojas.Name = "lblTotalHojas";
            this.lblTotalHojas.Size = new System.Drawing.Size(312, 40);
            this.lblTotalHojas.TabIndex = 16;
            this.lblTotalHojas.Text = "Total Hojas";
            this.lblTotalHojas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDevolucionCartones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 412);
            this.Controls.Add(this.lblTotalHojas);
            this.Controls.Add(this.grbRegistroHojas);
            this.Controls.Add(this.grbValoresActuales);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDevolucionCartones";
            this.Text = "Devolución de Cartones";
            this.grbValoresActuales.ResumeLayout(false);
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbRegistroHojas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbValoresActuales;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbRegistroHojas;
        private System.Windows.Forms.ListBox lstHojas;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblHoja;
        private System.Windows.Forms.NumericUpDown txtHoja;
        private System.Windows.Forms.Label lblTotalHojas;
    }
}