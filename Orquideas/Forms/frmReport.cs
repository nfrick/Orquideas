using DataLayer;
using Microsoft.Reporting.WinForms;
using Orquideas.Properties;
using System;
using System.Windows.Forms;

namespace Orquideas {
    public partial class frmReport : SuperReport.SuperReportViewer {

        private readonly OrquideasEntities _ctx = new OrquideasEntities();

        readonly ToolStripButton _toolStripButtonListagem = new ToolStripButton {
            BackColor = System.Drawing.Color.FromArgb(255, 255,
                192),
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            ForeColor = System.Drawing.Color.Black,
            ImageTransparentColor = System.Drawing.Color.Magenta,
            Name = "toolStripButtonListagem",
            Size = new System.Drawing.Size(59, 22),
            Tag = "Listagem",
            Text = "Listagem"
        };

        readonly ToolStripButton _toolStripButtonCatálogo = new ToolStripButton {
            BackColor = System.Drawing.Color.FromArgb(255, 224, 192),
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            ForeColor = System.Drawing.Color.Black,
            ImageTransparentColor = System.Drawing.Color.Magenta,
            Name = "toolStripButtonCatálogo",
            Size = new System.Drawing.Size(59, 22),
            Tag = "Catálogo",
            Text = "Catálogo"
        };

        readonly ToolStripButton _toolStripButtonConferencia = new ToolStripButton {
            BackColor = System.Drawing.Color.FromArgb(224, 255, 192),
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            ForeColor = System.Drawing.Color.Black,
            ImageTransparentColor = System.Drawing.Color.Magenta,
            Name = "toolStripButtonConferencia",
            Size = new System.Drawing.Size(59, 22),
            Tag = "Conferência",
            Text = "Conferência"
        };

        readonly ToolStripComboBox _toolStripComboBoxSelecao = new ToolStripComboBox {
            Name = "toolStripComboBoxSelecao",
            Size = new System.Drawing.Size(80, 25),
            Text = "Vivas"
        };

        readonly ToolStripComboBox _toolStripComboBoxFormato = new ToolStripComboBox {
            Name = "toolStripComboBoxFormato",
            Size = new System.Drawing.Size(80, 25),
            Text = "Normal"
        };

        readonly ToolStripComboBox _toolStripComboBoxOrdem = new ToolStripComboBox {
            Name = "toolStripComboBoxOrdem",
            Size = new System.Drawing.Size(80, 25),
            Text = "Numérica"
        };

        public frmReport() {
            InitializeComponent();
            RptPath = AppDomain.CurrentDomain.BaseDirectory + @"Reports\rpt{0}{1}.rdlc";

            toolStripMenu.Items.Add(_toolStripButtonListagem);
            _toolStripButtonListagem.Click += ToolStripButtonReport_Click;

            toolStripMenu.Items.Add(_toolStripButtonCatálogo);
            _toolStripButtonCatálogo.Click += ToolStripButtonReport_Click;

            toolStripMenu.Items.Add(_toolStripButtonConferencia);
            _toolStripButtonConferencia.Click += ToolStripButtonReport_Click;

            toolStripMenu.Items.Add(new ToolStripSeparator {
                Name = "toolStripSeparator1",
                Size = new System.Drawing.Size(6, 25)
            });

            _toolStripComboBoxSelecao.Items.AddRange(new object[] {
                "Todas", "Vivas", "Terminadas"});
            toolStripMenu.Items.Add(_toolStripComboBoxSelecao);

            _toolStripComboBoxFormato.Items.AddRange(new object[] {
                "Normal", "Resumido"});
            toolStripMenu.Items.Add(_toolStripComboBoxFormato);

            _toolStripComboBoxOrdem.Items.AddRange(new object[] {
                "Alfabética", "Numérica"});
            toolStripMenu.Items.Add(_toolStripComboBoxOrdem);
        }

        private void ToolStripButtonReport_Click(object sender, EventArgs e) {
			var rptName = (string)((ToolStripButton)sender).Tag;
			var displayName = $"Qrquídeas {rptName} {_toolStripComboBoxSelecao.Text} ordem {_toolStripComboBoxOrdem.Text}";

            ReportParameter[] parameters = null;

            if (rptName == "Catálogo") {
                EnableExternalImages = true;
                parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("FotosPath", Settings.Default.FotosPath);
            }

            var orquideas = _ctx.spOrquideas(_toolStripComboBoxSelecao.Text, 
                    _toolStripComboBoxOrdem.Text);

            SetLocalReport(new string[] { rptName, _toolStripComboBoxFormato.Text },
              displayName, @"DataSet1", orquideas, parameters);

            //SetReport(new string[] { "Listagem", "Simples" }, displayName, @"DataSet1", orquideas, parameters);
        }
    }
}
