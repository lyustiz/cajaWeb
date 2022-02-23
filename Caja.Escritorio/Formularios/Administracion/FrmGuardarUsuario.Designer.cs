namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmGuardarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuardarUsuario));
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbPerfiles = new System.Windows.Forms.GroupBox();
            this.chkPerfiles = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtClaveAjustes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVerClave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbPerfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(190, 120);
            this.txtConfirmarClave.MaxLength = 15;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(172, 26);
            this.txtConfirmarClave.TabIndex = 123;
            this.txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(190, 90);
            this.txtClave.MaxLength = 15;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(172, 26);
            this.txtClave.TabIndex = 121;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(190, 60);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(172, 26);
            this.txtLogin.TabIndex = 119;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(190, 30);
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(363, 26);
            this.txtNombreCompleto.TabIndex = 117;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Location = new System.Drawing.Point(490, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 125;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnVerClave);
            this.groupBox1.Controls.Add(this.grbPerfiles);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.txtClaveAjustes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConfirmarClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 376);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Usuario";
            // 
            // grbPerfiles
            // 
            this.grbPerfiles.Controls.Add(this.chkPerfiles);
            this.grbPerfiles.Location = new System.Drawing.Point(6, 210);
            this.grbPerfiles.Name = "grbPerfiles";
            this.grbPerfiles.Size = new System.Drawing.Size(586, 155);
            this.grbPerfiles.TabIndex = 173;
            this.grbPerfiles.TabStop = false;
            this.grbPerfiles.Text = "Perfiles";
            // 
            // chkPerfiles
            // 
            this.chkPerfiles.CheckOnClick = true;
            this.chkPerfiles.FormattingEnabled = true;
            this.chkPerfiles.Location = new System.Drawing.Point(6, 17);
            this.chkPerfiles.Name = "chkPerfiles";
            this.chkPerfiles.Size = new System.Drawing.Size(574, 124);
            this.chkPerfiles.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 172;
            this.label9.Text = "Clave Ajustes";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 25);
            this.label8.TabIndex = 171;
            this.label8.Text = "Confirmar Clave";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 170;
            this.label7.Text = "Clave";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 169;
            this.label6.Text = "Código";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 25);
            this.lblTitulo.TabIndex = 168;
            this.lblTitulo.Text = "Nombre Completo";
            // 
            // txtClaveAjustes
            // 
            this.txtClaveAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveAjustes.Location = new System.Drawing.Point(190, 150);
            this.txtClaveAjustes.MaxLength = 15;
            this.txtClaveAjustes.Name = "txtClaveAjustes";
            this.txtClaveAjustes.Size = new System.Drawing.Size(172, 26);
            this.txtClaveAjustes.TabIndex = 166;
            this.txtClaveAjustes.UseSystemPasswordChar = true;
            this.txtClaveAjustes.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(365, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 26);
            this.label5.TabIndex = 165;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(365, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 26);
            this.label4.TabIndex = 164;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(365, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 163;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(15, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 162;
            this.label3.Text = "* Maximo 15 caracteres, sin espacios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BtnVerClave
            // 
            this.BtnVerClave.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnVerClave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerClave.BackgroundImage")));
            this.BtnVerClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVerClave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVerClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerClave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVerClave.Location = new System.Drawing.Point(367, 131);
            this.BtnVerClave.Name = "BtnVerClave";
            this.BtnVerClave.Size = new System.Drawing.Size(39, 15);
            this.BtnVerClave.TabIndex = 127;
            this.BtnVerClave.UseVisualStyleBackColor = false;
            this.BtnVerClave.Click += new System.EventHandler(this.BtnVerClave_Click);
            // 
            // FrmGuardarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGuardarUsuario";
            this.Text = "Nuevo Usuario";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmGuardarUsuario_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbPerfiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkPerfiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveAjustes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbPerfiles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnVerClave;
    }
}