namespace PSMtecnology.Generales.reportes
{
    partial class frmreportepi
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSTG = new PSMtecnology.Generales.reportes.DSTG();
            this.piBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piTableAdapter = new PSMtecnology.Generales.reportes.DSTGTableAdapters.piTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.piBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSMtecnology.Generales.reportes.REPORTEPI.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSTG
            // 
            this.dSTG.DataSetName = "DSTG";
            this.dSTG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // piBindingSource
            // 
            this.piBindingSource.DataMember = "pi";
            this.piBindingSource.DataSource = this.dSTG;
            // 
            // piTableAdapter
            // 
            this.piTableAdapter.ClearBeforeFill = true;
            // 
            // frmreportepi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmreportepi";
            this.Text = "frmreportepi";
            this.Load += new System.EventHandler(this.frmreportepi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource piBindingSource;
        private DSTG dSTG;
        private DSTGTableAdapters.piTableAdapter piTableAdapter;
    }
}