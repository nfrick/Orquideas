using DataLayer;
using Microsoft.Reporting.WinForms;
using Orquideas.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Orquideas {
    public partial class frmReportOld : Form {
        private readonly OrquideasEntities _ctx = new OrquideasEntities();
        private static string _rptPath;

        public frmReportOld() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            _rptPath = AppDomain.CurrentDomain.BaseDirectory + @"Reports\rpt{0}{1}.rdlc";
        }

        private void ToolStripButtonReport_Click(object sender, EventArgs e) {
            var rptName = (string)((ToolStripButton)sender).Tag;
            var rptEngine = rptViewer.LocalReport;
            rptEngine.DataSources.Clear();
            rptEngine.ReportPath = string.Format(_rptPath, rptName, toolStripComboBoxFormato.Text);
            rptEngine.DisplayName =
                $"Qrquídeas {rptName} {toolStripComboBoxSelecao.Text} ordem {toolStripComboBoxOrdem.Text}";

            if (rptName == "Catálogo") {
                var parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("FotosPath", Settings.Default.FotosPath);
                rptEngine.SetParameters(parameters);
            }

            var preselecionadas =
                toolStripComboBoxSelecao.Text == "Todas"
                    ? _ctx.Orquideas
                    : (toolStripComboBoxSelecao.Text == "Vivas"
                        ? _ctx.Orquideas.Where(o => o.Termino == null)
                        : _ctx.Orquideas.Where(o => o.Termino != null));

            if (toolStripComboBoxOrdem.Text == "Numérica") {
                rptEngine.DataSources.Add(new ReportDataSource(@"DataSet1",
                    preselecionadas.OrderBy(o => o.OrquideaID).ToList()));
            }
            else {
                rptEngine.DataSources.Add(new ReportDataSource(@"DataSet1",
                    preselecionadas.OrderBy(o => o.Genero.Nome)
                    .ThenBy(o => o.Especie).ThenBy(o => o.OrquideaID)
                    .ToList()));
            }

            rptViewer.LocalReport.EnableExternalImages = true;
            rptViewer.RefreshReport();
        }
    }
}