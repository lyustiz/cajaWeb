namespace Caja.Escritorio.Formularios.General
{
    partial class MsgExcepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgExcepcion));
            this.lblTituloError = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloError
            // 
            this.lblTituloError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloError.Location = new System.Drawing.Point(12, 9);
            this.lblTituloError.Name = "lblTituloError";
            this.lblTituloError.Size = new System.Drawing.Size(824, 24);
            this.lblTituloError.TabIndex = 0;
            this.lblTituloError.Text = "Mensaje de Error";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCerrar.Location = new System.Drawing.Point(727, 306);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(105, 30);
            this.BtnCerrar.TabIndex = 162;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Location = new System.Drawing.Point(12, 33);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(820, 263);
            this.lblError.TabIndex = 163;
            this.lblError.Text = "Mensaje de Error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MsgExcepcion
            // 
            this.AcceptButton = this.BtnCerrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 341);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblTituloError);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 380);
            this.Name = "MsgExcepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Excepción";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloError;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label lblError;
    }
}