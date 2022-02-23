namespace Caja.Escritorio.Formularios.Reportes
{
    partial class FrmVisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisor));
            this.rvVisorReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rvVisorReportes
            // 
            this.rvVisorReportes.ActiveViewIndex = -1;
            this.rvVisorReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rvVisorReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rvVisorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvVisorReportes.Location = new System.Drawing.Point(0, 0);
            this.rvVisorReportes.Name = "rvVisorReportes";
            this.rvVisorReportes.Size = new System.Drawing.Size(931, 749);
            this.rvVisorReportes.TabIndex = 0;
            // 
            // FrmVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 749);
            this.Controls.Add(this.rvVisorReportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisor";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rvVisorReportes;
    }
}