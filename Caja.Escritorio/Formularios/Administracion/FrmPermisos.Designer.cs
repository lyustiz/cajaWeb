namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmPermisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdPerfilPermisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmdPerfil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 17);
            this.lblTitulo.TabIndex = 166;
            this.lblTitulo.Text = "Registro de Permisos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.Location = new System.Drawing.Point(351, 490);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 30);
            this.BtnGuardar.TabIndex = 165;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.IdPerfilPermisos,
            this.Descripcion,
            this.Habilitado});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(15, 66);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(441, 418);
            this.Grilla.TabIndex = 164;
            this.Grilla.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Grilla_CellBeginEdit);
            this.Grilla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grilla_CellMouseClick);
            // 
            // IdPerfilPermisos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "-";
            this.IdPerfilPermisos.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdPerfilPermisos.HeaderText = "IdPerfilPermisos";
            this.IdPerfilPermisos.Name = "IdPerfilPermisos";
            this.IdPerfilPermisos.ReadOnly = true;
            this.IdPerfilPermisos.Visible = false;
            this.IdPerfilPermisos.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.DividerWidth = 1;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Habilitado
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Habilitado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Habilitado.HeaderText = "Permiso";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(12, 39);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(51, 17);
            this.lblPerfil.TabIndex = 167;
            this.lblPerfil.Text = "Perfiles";
            // 
            // cmdPerfil
            // 
            this.cmdPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdPerfil.FormattingEnabled = true;
            this.cmdPerfil.Location = new System.Drawing.Point(69, 39);
            this.cmdPerfil.Name = "cmdPerfil";
            this.cmdPerfil.Size = new System.Drawing.Size(241, 21);
            this.cmdPerfil.TabIndex = 168;
            this.cmdPerfil.SelectedIndexChanged += new System.EventHandler(this.cmdPerfil_SelectedIndexChanged);
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 524);
            this.Controls.Add(this.cmdPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.Grilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPermisos";
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label lblPerfil;
        internal System.Windows.Forms.ComboBox cmdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfilPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitado;
    }
}