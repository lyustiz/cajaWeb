namespace Caja.Escritorio
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panLogging = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.xpDockingLabel1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblFechaRelease = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panLogging.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLogging
            // 
            this.panLogging.BackColor = System.Drawing.Color.Transparent;
            this.panLogging.Controls.Add(this.lblUsuario);
            this.panLogging.Controls.Add(this.txtPassword);
            this.panLogging.Controls.Add(this.txtUsuario);
            this.panLogging.Controls.Add(this.xpDockingLabel1);
            this.panLogging.Location = new System.Drawing.Point(9, 135);
            this.panLogging.Name = "panLogging";
            this.panLogging.Size = new System.Drawing.Size(316, 50);
            this.panLogging.TabIndex = 0;
            this.panLogging.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblUsuario.Location = new System.Drawing.Point(35, 5);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(97, 26);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(97, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(216, 21);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // xpDockingLabel1
            // 
            this.xpDockingLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpDockingLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.xpDockingLabel1.Location = new System.Drawing.Point(3, 26);
            this.xpDockingLabel1.Name = "xpDockingLabel1";
            this.xpDockingLabel1.Size = new System.Drawing.Size(88, 21);
            this.xpDockingLabel1.TabIndex = 6;
            this.xpDockingLabel1.Text = "Contraseña:";
            this.xpDockingLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblVersion.Location = new System.Drawing.Point(5, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(202, 24);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Versión 1.0.1 - 1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreApp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNombreApp.Location = new System.Drawing.Point(3, 27);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(270, 24);
            this.lblNombreApp.TabIndex = 8;
            this.lblNombreApp.Text = "Caja Studio 2020";
            this.lblNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNota
            // 
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(4, 270);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(332, 24);
            this.lblNota.TabIndex = 9;
            this.lblNota.Text = "Este programa está protegido con las leyes de propiedad intelectual.\r\nEstá prohib" +
    "ida su copia parcial o total.\r\n\r\n";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Green;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCerrar.Location = new System.Drawing.Point(7, 271);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 24);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblFechaRelease
            // 
            this.lblFechaRelease.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRelease.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRelease.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblFechaRelease.Location = new System.Drawing.Point(101, 3);
            this.lblFechaRelease.Name = "lblFechaRelease";
            this.lblFechaRelease.Size = new System.Drawing.Size(172, 24);
            this.lblFechaRelease.TabIndex = 11;
            this.lblFechaRelease.Text = "Fecha Release";
            this.lblFechaRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lblFechaRelease);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblNombreApp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 299);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panLogging);
            this.panel2.Controls.Add(this.lblNota);
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 299);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Iniciar Sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.panLogging.ResumeLayout(false);
            this.panLogging.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label xpDockingLabel1;
        internal System.Windows.Forms.Panel panLogging;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFechaRelease;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}