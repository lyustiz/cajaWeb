
namespace Caja.Escritorio.Formularios.Caja
{
    partial class FrmCuadreCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuadreCierre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuVentana = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.cmdProgramacion = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.lbJuego = new System.Windows.Forms.Label();
            this.grbRecaudoDinero = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.IdDefinicionMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equivalencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoSuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbResultadoSumas = new System.Windows.Forms.GroupBox();
            this.txTotalRecaudo = new System.Windows.Forms.TextBox();
            this.txTotal2 = new System.Windows.Forms.TextBox();
            this.txTotal1 = new System.Windows.Forms.TextBox();
            this.lblTotalRecaudo = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.menuVentana.SuspendLayout();
            this.grbRecaudoDinero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.grbResultadoSumas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVentana
            // 
            this.menuVentana.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuVentana.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentana.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.menuVentana.Location = new System.Drawing.Point(0, 0);
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(703, 24);
            this.menuVentana.TabIndex = 12;
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.BackColor = System.Drawing.Color.LightCoral;
            this.lblNotificacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotificacion.Location = new System.Drawing.Point(12, 34);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(477, 89);
            this.lblNotificacion.TabIndex = 13;
            this.lblNotificacion.Text = "Sólamente se puede almacenar el juego indicado a continuación. Los juegos ya cerr" +
    "ados son de consulta y los posteriores al entregado no se procesan hasta tanto n" +
    "o se  haga en orden el proceso.";
            this.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 126);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(477, 30);
            this.lblNombreUsuario.TabIndex = 14;
            this.lblNombreUsuario.Text = "{ Nombre Usuario}";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdProgramacion
            // 
            this.cmdProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdProgramacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProgramacion.FormattingEnabled = true;
            this.cmdProgramacion.Location = new System.Drawing.Point(585, 133);
            this.cmdProgramacion.Name = "cmdProgramacion";
            this.cmdProgramacion.Size = new System.Drawing.Size(107, 23);
            this.cmdProgramacion.TabIndex = 16;
            this.cmdProgramacion.SelectedIndexChanged += new System.EventHandler(this.cmdProgramacion_SelectedIndexChanged);
            // 
            // lblJuego
            // 
            this.lblJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(495, 131);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(94, 25);
            this.lblJuego.TabIndex = 15;
            this.lblJuego.Text = "Número Juego";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbJuego
            // 
            this.lbJuego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbJuego.Font = new System.Drawing.Font("Segoe UI Semilight", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJuego.ForeColor = System.Drawing.Color.Green;
            this.lbJuego.Location = new System.Drawing.Point(495, 34);
            this.lbJuego.Name = "lbJuego";
            this.lbJuego.Size = new System.Drawing.Size(197, 89);
            this.lbJuego.TabIndex = 17;
            this.lbJuego.Text = "0";
            this.lbJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbRecaudoDinero
            // 
            this.grbRecaudoDinero.Controls.Add(this.Grilla);
            this.grbRecaudoDinero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecaudoDinero.Location = new System.Drawing.Point(12, 162);
            this.grbRecaudoDinero.Name = "grbRecaudoDinero";
            this.grbRecaudoDinero.Size = new System.Drawing.Size(680, 400);
            this.grbRecaudoDinero.TabIndex = 18;
            this.grbRecaudoDinero.TabStop = false;
            this.grbRecaudoDinero.Text = "Recaudo Dinero";
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
            this.IdDefinicionMoneda,
            this.Descripcion,
            this.Nominal,
            this.Cantidad,
            this.Equivalencia,
            this.ValorTotal,
            this.GrupoSuma});
            this.Grilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grilla.GridColor = System.Drawing.SystemColors.Control;
            this.Grilla.Location = new System.Drawing.Point(9, 21);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(662, 370);
            this.Grilla.TabIndex = 6;
            this.Grilla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellEndEdit);
            // 
            // IdDefinicionMoneda
            // 
            this.IdDefinicionMoneda.HeaderText = "IdDefinicionMoneda";
            this.IdDefinicionMoneda.Name = "IdDefinicionMoneda";
            this.IdDefinicionMoneda.ReadOnly = true;
            this.IdDefinicionMoneda.Visible = false;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "-";
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 260;
            // 
            // Nominal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nominal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nominal.DividerWidth = 1;
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.Name = "Nominal";
            this.Nominal.ReadOnly = true;
            this.Nominal.Width = 120;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.DividerWidth = 1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // Equivalencia
            // 
            this.Equivalencia.HeaderText = "Equivalencia";
            this.Equivalencia.Name = "Equivalencia";
            this.Equivalencia.ReadOnly = true;
            this.Equivalencia.Visible = false;
            // 
            // ValorTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 120;
            // 
            // GrupoSuma
            // 
            this.GrupoSuma.HeaderText = "GrupoSuma";
            this.GrupoSuma.Name = "GrupoSuma";
            this.GrupoSuma.ReadOnly = true;
            this.GrupoSuma.Visible = false;
            // 
            // grbResultadoSumas
            // 
            this.grbResultadoSumas.Controls.Add(this.txTotalRecaudo);
            this.grbResultadoSumas.Controls.Add(this.txTotal2);
            this.grbResultadoSumas.Controls.Add(this.txTotal1);
            this.grbResultadoSumas.Controls.Add(this.lblTotalRecaudo);
            this.grbResultadoSumas.Controls.Add(this.lblTotal2);
            this.grbResultadoSumas.Controls.Add(this.lblTotal1);
            this.grbResultadoSumas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResultadoSumas.Location = new System.Drawing.Point(12, 568);
            this.grbResultadoSumas.Name = "grbResultadoSumas";
            this.grbResultadoSumas.Size = new System.Drawing.Size(680, 112);
            this.grbResultadoSumas.TabIndex = 19;
            this.grbResultadoSumas.TabStop = false;
            this.grbResultadoSumas.Text = "Resultado Sumas";
            // 
            // txTotalRecaudo
            // 
            this.txTotalRecaudo.Enabled = false;
            this.txTotalRecaudo.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotalRecaudo.Location = new System.Drawing.Point(445, 46);
            this.txTotalRecaudo.Name = "txTotalRecaudo";
            this.txTotalRecaudo.Size = new System.Drawing.Size(206, 39);
            this.txTotalRecaudo.TabIndex = 55;
            this.txTotalRecaudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txTotal2
            // 
            this.txTotal2.Enabled = false;
            this.txTotal2.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal2.Location = new System.Drawing.Point(233, 46);
            this.txTotal2.Name = "txTotal2";
            this.txTotal2.Size = new System.Drawing.Size(206, 39);
            this.txTotal2.TabIndex = 54;
            this.txTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txTotal1
            // 
            this.txTotal1.Enabled = false;
            this.txTotal1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal1.Location = new System.Drawing.Point(21, 46);
            this.txTotal1.Name = "txTotal1";
            this.txTotal1.Size = new System.Drawing.Size(206, 39);
            this.txTotal1.TabIndex = 53;
            this.txTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalRecaudo
            // 
            this.lblTotalRecaudo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudo.Location = new System.Drawing.Point(451, 18);
            this.lblTotalRecaudo.Name = "lblTotalRecaudo";
            this.lblTotalRecaudo.Size = new System.Drawing.Size(200, 25);
            this.lblTotalRecaudo.TabIndex = 11;
            this.lblTotalRecaudo.Text = "TOTAL RECAUDO";
            this.lblTotalRecaudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal2
            // 
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.Location = new System.Drawing.Point(233, 18);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(206, 25);
            this.lblTotal2.TabIndex = 10;
            this.lblTotal2.Text = "Total 2";
            this.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal1
            // 
            this.lblTotal1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(21, 18);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(206, 25);
            this.lblTotal1.TabIndex = 9;
            this.lblTotal1.Text = "Total 1";
            this.lblTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCuadreCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 708);
            this.Controls.Add(this.grbResultadoSumas);
            this.Controls.Add(this.grbRecaudoDinero);
            this.Controls.Add(this.lbJuego);
            this.Controls.Add(this.cmdProgramacion);
            this.Controls.Add(this.lblJuego);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.menuVentana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuadreCierre";
            this.Text = "Cuadre Cierre";
            this.menuVentana.ResumeLayout(false);
            this.menuVentana.PerformLayout();
            this.grbRecaudoDinero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.grbResultadoSumas.ResumeLayout(false);
            this.grbResultadoSumas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentana;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Label lblNombreUsuario;
        internal System.Windows.Forms.ComboBox cmdProgramacion;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Label lbJuego;
        private System.Windows.Forms.GroupBox grbRecaudoDinero;
        internal System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.GroupBox grbResultadoSumas;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblTotalRecaudo;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.TextBox txTotalRecaudo;
        private System.Windows.Forms.TextBox txTotal2;
        private System.Windows.Forms.TextBox txTotal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDefinicionMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equivalencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoSuma;
    }
}