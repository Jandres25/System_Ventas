
namespace CapaPresentacion.Reportes
{
    partial class FrmReptoStockArticulos
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
            this.spstock_articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.Reportes.dsPrincipal();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spstock_articulosTableAdapter = new CapaPresentacion.Reportes.dsPrincipalTableAdapters.spstock_articulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spstock_articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spstock_articulosBindingSource
            // 
            this.spstock_articulosBindingSource.DataMember = "spstock_articulos";
            this.spstock_articulosBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtStockArticulos";
            reportDataSource1.Value = this.spstock_articulosBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptStockArticulos.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1078, 562);
            this.reportViewer.TabIndex = 0;
            // 
            // spstock_articulosTableAdapter
            // 
            this.spstock_articulosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReptoStockArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 562);
            this.Controls.Add(this.reportViewer);
            this.Name = "FrmReptoStockArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Stock de Articulos";
            this.Load += new System.EventHandler(this.FrmReptoStockArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spstock_articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource spstock_articulosBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spstock_articulosTableAdapter spstock_articulosTableAdapter;
    }
}