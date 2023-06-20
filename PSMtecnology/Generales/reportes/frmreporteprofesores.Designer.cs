namespace PSMtecnology.Generales.reportes
{
    partial class frmreporteprofesores
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
            this.profesoresbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTG = new PSMtecnology.Generales.reportes.DSTG();
            this.profesoresTableAdapter = new PSMtecnology.Generales.reportes.DSTGTableAdapters.profesoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTG)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.profesoresbindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PSMtecnology.Generales.reportes.Reporteprofesores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // profesoresbindingSource
            // 
            this.profesoresbindingSource.DataMember = "profesores";
            this.profesoresbindingSource.DataSource = this.dSTG;
            // 
            // dSTG
            // 
            this.dSTG.DataSetName = "DSTG";
            this.dSTG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmreporteprofesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmreporteprofesores";
            this.Text = "frmreporteprofesores";
            this.Load += new System.EventHandler(this.frmreporteprofesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesoresbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSTG dSTG;
        private DSTGTableAdapters.profesoresTableAdapter profesoresTableAdapter;
        public System.Windows.Forms.BindingSource profesoresbindingSource;
    }
}