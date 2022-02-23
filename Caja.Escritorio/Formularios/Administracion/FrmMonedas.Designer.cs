namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmMonedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            this.grbFormato = new System.Windows.Forms.GroupBox();
            this.txtDecimales = new System.Windows.Forms.TextBox();
            this.grbTiposMoneda = new System.Windows.Forms.GroupBox();
            this.rbtEuros = new System.Windows.Forms.RadioButton();
            this.rbtDolares = new System.Windows.Forms.RadioButton();
            this.rbtPesos = new System.Windows.Forms.RadioButton();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.grbFormato.SuspendLayout();
            this.grbTiposMoneda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFormato
            // 
            this.grbFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFormato.Controls.Add(this.txtDecimales);
            this.grbFormato.Location = new System.Drawing.Point(335, 12);
            this.grbFormato.Name = "grbFormato";
            this.grbFormato.Size = new System.Drawing.Size(131, 71);
            this.grbFormato.TabIndex = 5;
            this.grbFormato.TabStop = false;
            this.grbFormato.Text = "Formato";
            // 
            // txtDecimales
            // 
            this.txtDecimales.Enabled = false;
            this.txtDecimales.Location = new System.Drawing.Point(16, 32);
            this.txtDecimales.MaxLength = 1;
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(99, 22);
            this.txtDecimales.TabIndex = 0;
            this.txtDecimales.Text = "0";
            this.txtDecimales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbTiposMoneda
            // 
            this.grbTiposMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTiposMoneda.Controls.Add(this.rbtEuros);
            this.grbTiposMoneda.Controls.Add(this.rbtDolares);
            this.grbTiposMoneda.Controls.Add(this.rbtPesos);
            this.grbTiposMoneda.Location = new System.Drawing.Point(12, 12);
            this.grbTiposMoneda.Name = "grbTiposMoneda";
            this.grbTiposMoneda.Size = new System.Drawing.Size(317, 71);
            this.grbTiposMoneda.TabIndex = 3;
            this.grbTiposMoneda.TabStop = false;
            this.grbTiposMoneda.Text = "Tipo de Moneda";
            // 
            // rbtEuros
            // 
            this.rbtEuros.AutoSize = true;
            this.rbtEuros.Location = new System.Drawing.Point(236, 32);
            this.rbtEuros.Name = "rbtEuros";
            this.rbtEuros.Size = new System.Drawing.Size(64, 17);
            this.rbtEuros.TabIndex = 2;
            this.rbtEuros.Text = "Euro (€)";
            this.rbtEuros.UseVisualStyleBackColor = true;
            this.rbtEuros.CheckedChanged += new System.EventHandler(this.RbtEuro_CheckedChanged);
            // 
            // rbtDolares
            // 
            this.rbtDolares.AutoSize = true;
            this.rbtDolares.Location = new System.Drawing.Point(121, 32);
            this.rbtDolares.Name = "rbtDolares";
            this.rbtDolares.Size = new System.Drawing.Size(93, 17);
            this.rbtDolares.TabIndex = 1;
            this.rbtDolares.Text = "Dolares (US$)";
            this.rbtDolares.UseVisualStyleBackColor = true;
            this.rbtDolares.CheckedChanged += new System.EventHandler(this.RbtDolares_CheckedChanged);
            // 
            // rbtPesos
            // 
            this.rbtPesos.AutoSize = true;
            this.rbtPesos.Checked = true;
            this.rbtPesos.Location = new System.Drawing.Point(16, 32);
            this.rbtPesos.Name = "rbtPesos";
            this.rbtPesos.Size = new System.Drawing.Size(69, 17);
            this.rbtPesos.TabIndex = 0;
            this.rbtPesos.TabStop = true;
            this.rbtPesos.Text = "Pesos ($)";
            this.rbtPesos.UseVisualStyleBackColor = true;
            this.rbtPesos.CheckedChanged += new System.EventHandler(this.RbtPesos_CheckedChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.Location = new System.Drawing.Point(361, 102);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 30);
            this.BtnGuardar.TabIndex = 161;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 141);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.grbFormato);
            this.Controls.Add(this.grbTiposMoneda);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 180);
            this.MinimumSize = new System.Drawing.Size(500, 180);
            this.Name = "FrmMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definición de Monedas";
            this.grbFormato.ResumeLayout(false);
            this.grbFormato.PerformLayout();
            this.grbTiposMoneda.ResumeLayout(false);
            this.grbTiposMoneda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbFormato;
        internal System.Windows.Forms.TextBox txtDecimales;
        internal System.Windows.Forms.GroupBox grbTiposMoneda;
        internal System.Windows.Forms.RadioButton rbtEuros;
        internal System.Windows.Forms.RadioButton rbtDolares;
        internal System.Windows.Forms.RadioButton rbtPesos;
        private System.Windows.Forms.Button BtnGuardar;
    }
}