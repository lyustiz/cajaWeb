namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmConsultarAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarAuditoria));
            this.grbFiltro = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.grbListadoAuditoria = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbFiltro.SuspendLayout();
            this.grbListadoAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFiltro
            // 
            this.grbFiltro.Controls.Add(this.BtnBuscar);
            this.grbFiltro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltro.Location = new System.Drawing.Point(12, 12);
            this.grbFiltro.Name = "grbFiltro";
            this.grbFiltro.Size = new System.Drawing.Size(1073, 55);
            this.grbFiltro.TabIndex = 7;
            this.grbFiltro.TabStop = false;
            this.grbFiltro.Text = "Filtros de Búsqueda";
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
            this.BtnBuscar.Location = new System.Drawing.Point(963, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 25);
            this.BtnBuscar.TabIndex = 189;
            this.BtnBuscar.Text = "Filtrar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // grbListadoAuditoria
            // 
            this.grbListadoAuditoria.Controls.Add(this.Grilla);
            this.grbListadoAuditoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListadoAuditoria.Location = new System.Drawing.Point(12, 73);
            this.grbListadoAuditoria.Name = "grbListadoAuditoria";
            this.grbListadoAuditoria.Size = new System.Drawing.Size(1073, 430);
            this.grbListadoAuditoria.TabIndex = 8;
            this.grbListadoAuditoria.TabStop = false;
            this.grbListadoAuditoria.Text = "Listado de Acciones";
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
            this.IdAuditoria,
            this.FechaAuditoria,
            this.IdUsuario,
            this.Tabla,
            this.Accion,
            this.RegistroAnterior,
            this.RegistroNuevo,
            this.Ver});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(10, 21);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(1053, 403);
            this.Grilla.TabIndex = 189;
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellClick);
            // 
            // IdAuditoria
            // 
            this.IdAuditoria.Frozen = true;
            this.IdAuditoria.HeaderText = "Id";
            this.IdAuditoria.Name = "IdAuditoria";
            this.IdAuditoria.ReadOnly = true;
            this.IdAuditoria.Width = 70;
            // 
            // FechaAuditoria
            // 
            this.FechaAuditoria.Frozen = true;
            this.FechaAuditoria.HeaderText = "Fecha Auditoría";
            this.FechaAuditoria.Name = "FechaAuditoria";
            this.FechaAuditoria.ReadOnly = true;
            this.FechaAuditoria.Width = 140;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Frozen = true;
            this.IdUsuario.HeaderText = "Usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Tabla
            // 
            this.Tabla.Frozen = true;
            this.Tabla.HeaderText = "Tabla";
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            this.Tabla.Width = 150;
            // 
            // Accion
            // 
            this.Accion.Frozen = true;
            this.Accion.HeaderText = "Acción";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // RegistroAnterior
            // 
            this.RegistroAnterior.Frozen = true;
            this.RegistroAnterior.HeaderText = "Registro Anterior";
            this.RegistroAnterior.Name = "RegistroAnterior";
            this.RegistroAnterior.ReadOnly = true;
            this.RegistroAnterior.Width = 200;
            // 
            // RegistroNuevo
            // 
            this.RegistroNuevo.Frozen = true;
            this.RegistroNuevo.HeaderText = "Registro Nuevo";
            this.RegistroNuevo.Name = "RegistroNuevo";
            this.RegistroNuevo.ReadOnly = true;
            this.RegistroNuevo.Width = 200;
            // 
            // Ver
            // 
            this.Ver.Frozen = true;
            this.Ver.HeaderText = "";
            this.Ver.Image = ((System.Drawing.Image)(resources.GetObject("Ver.Image")));
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ver.Width = 50;
            // 
            // FrmConsultarAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 515);
            this.Controls.Add(this.grbListadoAuditoria);
            this.Controls.Add(this.grbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultarAuditoria";
            this.Text = "Consultar Auditoría";
            this.grbFiltro.ResumeLayout(false);
            this.grbListadoAuditoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltro;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox grbListadoAuditoria;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroNuevo;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
    }
}