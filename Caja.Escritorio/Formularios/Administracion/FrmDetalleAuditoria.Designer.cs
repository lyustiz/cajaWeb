//using Alex75.JsonViewer.WindowsForm;

//namespace Caja.Escritorio.Formularios.Administracion
//{
//    partial class FrmAuditoria

using Alex75.JsonViewer.WindowsForm;

namespace Caja.Escritorio.Formularios.Administracion
{
    partial class FrmDetalleAuditoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleAuditoria));
            this.tpnlDetalle = new System.Windows.Forms.Panel();
            this.jsonTreeViewAnterior = new Alex75.JsonViewer.WindowsForm.JsonTreeView();
            this.pnlViejo = new System.Windows.Forms.Panel();
            this.lblResumenAuditoria = new System.Windows.Forms.Label();
            this.jsonTreeViewNuevo = new Alex75.JsonViewer.WindowsForm.JsonTreeView();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.tpnlDetalle.SuspendLayout();
            this.pnlViejo.SuspendLayout();
            this.pnlNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlDetalle
            // 
            this.tpnlDetalle.Controls.Add(this.lblResumenAuditoria);
            this.tpnlDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlDetalle.Location = new System.Drawing.Point(0, 0);
            this.tpnlDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.tpnlDetalle.Name = "tpnlDetalle";
            this.tpnlDetalle.Size = new System.Drawing.Size(739, 44);
            this.tpnlDetalle.TabIndex = 2;
            // 
            // jsonTreeViewAnterior
            // 
            this.jsonTreeViewAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonTreeViewAnterior.FullRowSelect = true;
            this.jsonTreeViewAnterior.ImageIndex = 0;
            this.jsonTreeViewAnterior.Location = new System.Drawing.Point(0, 0);
            this.jsonTreeViewAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.jsonTreeViewAnterior.Name = "jsonTreeView";
            this.jsonTreeViewAnterior.SelectedImageIndex = 0;
            this.jsonTreeViewAnterior.Size = new System.Drawing.Size(362, 466);
            this.jsonTreeViewAnterior.TabIndex = 0;
            // 
            // pnlViejo
            // 
            this.pnlViejo.Controls.Add(this.jsonTreeViewAnterior);
            this.pnlViejo.Location = new System.Drawing.Point(5, 48);
            this.pnlViejo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlViejo.Name = "pnlViejo";
            this.pnlViejo.Size = new System.Drawing.Size(362, 466);
            this.pnlViejo.TabIndex = 3;
            // 
            // lblResumenAuditoria
            // 
            this.lblResumenAuditoria.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenAuditoria.Location = new System.Drawing.Point(7, 4);
            this.lblResumenAuditoria.Name = "lblResumenAuditoria";
            this.lblResumenAuditoria.Size = new System.Drawing.Size(724, 35);
            this.lblResumenAuditoria.TabIndex = 191;
            this.lblResumenAuditoria.Text = "Nombre Cliente";
            // 
            // jsonTreeViewNuevo
            // 
            this.jsonTreeViewNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonTreeViewNuevo.FullRowSelect = true;
            this.jsonTreeViewNuevo.Location = new System.Drawing.Point(0, 0);
            this.jsonTreeViewNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.jsonTreeViewNuevo.Name = "jsonTreeView";
            this.jsonTreeViewNuevo.Size = new System.Drawing.Size(362, 466);
            this.jsonTreeViewNuevo.TabIndex = 0;
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.jsonTreeViewNuevo);
            this.pnlNuevo.Location = new System.Drawing.Point(371, 48);
            this.pnlNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(362, 466);
            this.pnlNuevo.TabIndex = 4;
            // 
            // FrmDetalleAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 521);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlViejo);
            this.Controls.Add(this.tpnlDetalle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetalleAuditoria";
            this.Text = "Detalle Registro Auditoría";
            this.tpnlDetalle.ResumeLayout(false);
            this.pnlViejo.ResumeLayout(false);
            this.pnlNuevo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JsonTreeView jsonTreeViewAnterior;
        private System.Windows.Forms.Panel tpnlDetalle;
        private System.Windows.Forms.Panel pnlViejo;
        private System.Windows.Forms.Label lblResumenAuditoria;
        private JsonTreeView jsonTreeViewNuevo;
        private System.Windows.Forms.Panel pnlNuevo;
    }
}




