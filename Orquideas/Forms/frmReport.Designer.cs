namespace Orquideas {
    partial class frmReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            reportDataSource1.Name = "DataSetBalance";
            reportDataSource1.Value = null;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.rptViewer.Size = new System.Drawing.Size(1446, 583);
            // 
            // frmRepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(1446, 583);
            this.Name = "frmRepo";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
