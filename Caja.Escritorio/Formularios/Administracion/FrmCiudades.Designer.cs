namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmCiudades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCiudades));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmdPaises = new System.Windows.Forms.ComboBox();
            this.IdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTitulo.Text = "Registro de Ciudades";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.Location = new System.Drawing.Point(185, 286);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 30);
            this.BtnGuardar.TabIndex = 165;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPais,
            this.IdCiudad,
            this.Descripcion});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(15, 66);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(276, 216);
            this.Grilla.TabIndex = 164;
            this.Grilla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellEndEdit);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(12, 39);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 17);
            this.lblPais.TabIndex = 167;
            this.lblPais.Text = "País";
            // 
            // cmdPaises
            // 
            this.cmdPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdPaises.FormattingEnabled = true;
            this.cmdPaises.Location = new System.Drawing.Point(50, 39);
            this.cmdPaises.Name = "cmdPaises";
            this.cmdPaises.Size = new System.Drawing.Size(241, 21);
            this.cmdPaises.TabIndex = 168;
            this.cmdPaises.SelectedIndexChanged += new System.EventHandler(this.CmdPaises_SelectedIndexChanged);
            // 
            // IdPais
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "-";
            this.IdPais.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdPais.HeaderText = "IdPais";
            this.IdPais.Name = "IdPais";
            this.IdPais.ReadOnly = true;
            this.IdPais.Visible = false;
            this.IdPais.Width = 50;
            // 
            // IdCiudad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = "-";
            this.IdCiudad.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdCiudad.HeaderText = "Id";
            this.IdCiudad.Name = "IdCiudad";
            this.IdCiudad.ReadOnly = true;
            this.IdCiudad.Width = 30;
            // 
            // Descripcion
            // 
            this.Descripcion.DividerWidth = 1;
            this.Descripcion.HeaderText = "Nombre Ciudad";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 205;
            // 
            // FrmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 321);
            this.Controls.Add(this.cmdPaises);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.Grilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 360);
            this.MinimumSize = new System.Drawing.Size(320, 360);
            this.Name = "FrmCiudades";
            this.Text = "Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnGuardar;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label lblPais;
        internal System.Windows.Forms.ComboBox cmdPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}