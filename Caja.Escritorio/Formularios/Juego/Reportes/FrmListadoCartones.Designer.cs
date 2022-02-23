
namespace Caja.Escritorio.Formularios.Juego.Reportes
{
    partial class FrmListadoCartones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCartones));
            this.grbValoresActuales = new System.Windows.Forms.GroupBox();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.grbInformacionHojasEntregadas = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.CantidadHojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbValoresActuales.SuspendLayout();
            this.grbInformacionHojasEntregadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grbValoresActuales
            // 
            this.grbValoresActuales.Controls.Add(this.cmdProgramacion);
            this.grbValoresActuales.Controls.Add(this.lblJuego);
            this.grbValoresActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbValoresActuales.Location = new System.Drawing.Point(12, 12);
            this.grbValoresActuales.Name = "grbValoresActuales";
            this.grbValoresActuales.Size = new System.Drawing.Size(461, 57);
            this.grbValoresActuales.TabIndex = 9;
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
            this.cmdProgramacion.Size = new System.Drawing.Size(326, 23);
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
            // grbInformacionHojasEntregadas
            // 
            this.grbInformacionHojasEntregadas.Controls.Add(this.Grilla);
            this.grbInformacionHojasEntregadas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacionHojasEntregadas.Location = new System.Drawing.Point(12, 75);
            this.grbInformacionHojasEntregadas.Name = "grbInformacionHojasEntregadas";
            this.grbInformacionHojasEntregadas.Size = new System.Drawing.Size(461, 379);
            this.grbInformacionHojasEntregadas.TabIndex = 10;
            this.grbInformacionHojasEntregadas.TabStop = false;
            this.grbInformacionHojasEntregadas.Text = "Información Hojas Entregadas";
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
            this.CantidadHojas,
            this.Destino});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(9, 21);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(437, 352);
            this.Grilla.TabIndex = 190;
            // 
            // CantidadHojas
            // 
            this.CantidadHojas.DividerWidth = 1;
            this.CantidadHojas.HeaderText = "No. Hojas";
            this.CantidadHojas.Name = "CantidadHojas";
            this.CantidadHojas.ReadOnly = true;
            this.CantidadHojas.Width = 95;
            // 
            // Destino
            // 
            this.Destino.DividerWidth = 1;
            this.Destino.HeaderText = "Nombres";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 300;
            // 
            // FrmListadoCartones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 462);
            this.Controls.Add(this.grbInformacionHojasEntregadas);
            this.Controls.Add(this.grbValoresActuales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoCartones";
            this.Text = "Listado de Cartones en Juego";
            this.grbValoresActuales.ResumeLayout(false);
            this.grbInformacionHojasEntregadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbValoresActuales;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.GroupBox grbInformacionHojasEntregadas;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHojas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
    }
}