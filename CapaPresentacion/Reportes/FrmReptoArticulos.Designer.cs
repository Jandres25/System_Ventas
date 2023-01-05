
namespace CapaPresentacion.Reportes
{
    partial class FrmReptoArticulos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spmostrar_articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.Reportes.dsPrincipal();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spmostrar_articuloTableAdapter = new CapaPresentacion.Reportes.dsPrincipalTableAdapters.spmostrar_articuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spmostrar_articuloBindingSource
            // 
            this.spmostrar_articuloBindingSource.DataMember = "spmostrar_articulo";
            this.spmostrar_articuloBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataset";
            reportDataSource1.Value = this.spmostrar_articuloBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptArticulos.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1016, 504);
            this.reportViewer.TabIndex = 0;
            // 
            // spmostrar_articuloTableAdapter
            // 
            this.spmostrar_articuloTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReptoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 504);
            this.Controls.Add(this.reportViewer);
            this.Name = "FrmReptoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Articulos";
            this.Load += new System.EventHandler(this.FrmReptoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource spmostrar_articuloBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spmostrar_articuloTableAdapter spmostrar_articuloTableAdapter;
    }
}