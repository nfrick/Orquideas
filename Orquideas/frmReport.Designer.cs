namespace MoneyBin {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonListagem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCatálogo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxSelecao = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxFormato = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxOrdem = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rptViewer);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(724, 558);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(724, 583);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Value = null;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewer.LocalReport.EnableExternalImages = true;
            this.rptViewer.LocalReport.ReportEmbeddedResource = "";
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.rptViewer.Size = new System.Drawing.Size(724, 558);
            this.rptViewer.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonListagem,
            this.toolStripButtonCatálogo,
            this.toolStripSeparator1,
            this.toolStripComboBoxSelecao,
            this.toolStripComboBoxFormato,
            this.toolStripComboBoxOrdem});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(382, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonListagem
            // 
            this.toolStripButtonListagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripButtonListagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonListagem.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonListagem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonListagem.Image")));
            this.toolStripButtonListagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListagem.Name = "toolStripButtonListagem";
            this.toolStripButtonListagem.Size = new System.Drawing.Size(59, 22);
            this.toolStripButtonListagem.Tag = "Listagem";
            this.toolStripButtonListagem.Text = "Listagem";
            this.toolStripButtonListagem.Click += new System.EventHandler(this.ToolStripButtonReport_Click);
            // 
            // toolStripButtonCatálogo
            // 
            this.toolStripButtonCatálogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripButtonCatálogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCatálogo.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonCatálogo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCatálogo.Image")));
            this.toolStripButtonCatálogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCatálogo.Name = "toolStripButtonCatálogo";
            this.toolStripButtonCatálogo.Size = new System.Drawing.Size(59, 22);
            this.toolStripButtonCatálogo.Tag = "Catalogo";
            this.toolStripButtonCatálogo.Text = "Catálogo";
            this.toolStripButtonCatálogo.Click += new System.EventHandler(this.ToolStripButtonReport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxSelecao
            // 
            this.toolStripComboBoxSelecao.Items.AddRange(new object[] {
            "Todas",
            "Vivas",
            "Terminadas"});
            this.toolStripComboBoxSelecao.Name = "toolStripComboBoxSelecao";
            this.toolStripComboBoxSelecao.Size = new System.Drawing.Size(80, 25);
            this.toolStripComboBoxSelecao.Text = "Vivas";
            // 
            // toolStripComboBoxFormato
            // 
            this.toolStripComboBoxFormato.Items.AddRange(new object[] {
            "Normal",
            "Resumido"});
            this.toolStripComboBoxFormato.Name = "toolStripComboBoxFormato";
            this.toolStripComboBoxFormato.Size = new System.Drawing.Size(80, 25);
            this.toolStripComboBoxFormato.Text = "Normal";
            // 
            // toolStripComboBoxOrdem
            // 
            this.toolStripComboBoxOrdem.Items.AddRange(new object[] {
            "Alfabética",
            "Numérica"});
            this.toolStripComboBoxOrdem.Name = "toolStripComboBoxOrdem";
            this.toolStripComboBoxOrdem.Size = new System.Drawing.Size(80, 25);
            this.toolStripComboBoxOrdem.Text = "Numérica";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 583);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.Form_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonListagem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCatálogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSelecao;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFormato;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxOrdem;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}