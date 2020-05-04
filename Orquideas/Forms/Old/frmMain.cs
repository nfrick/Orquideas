using DataLayer;
using DbContextExtensions;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using Orquideas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Orquideas {
    public partial class frmMain : Form {
        private Orquidea OrquideaAtual => (Orquidea)bsOrquideas.Current;

        private readonly OrquideasEntities _ctx = new OrquideasEntities();
        private readonly string[] _Cores;
        private readonly string[] _Origens;

        public frmMain() {
            InitializeComponent();
            _ctx.Orquideas.Load();
            bsOrquideas.DataSource = _ctx.Orquideas.Local.ToBindingList();
            _ctx.ContainerTypes.Load();
            bsContainerType.DataSource = _ctx.ContainerTypes.Local.ToBindingList();
            bsContainerType.Sort = "Container";

            _Cores = _ctx.spCores().ToArray();
            _Origens = _ctx.spOrigens().ToArray();

            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";
            SFD.FileName = "Orquideas.xlsx";

            dgvOrquideas.AutoGenerateColumns = false;

            dgvOrquideas.SetFont(null, 12);
            dgvRepots.SetFont(null, 12);
            dgvFloracoes.SetFont(null, 12);

            // assign BindingList to grid
            comboBoxGenero.DataSource = _ctx.Generos.OrderBy(g => g.Nome).ToList();
            comboBoxGenero.ValueMember = "GeneroID";
            comboBoxGenero.DisplayMember = "Nome";

            listBoxMatriz.ValueMember = "OrquideaID";
            listBoxMatriz.DisplayMember = "OrquideaID";

            //dgvOrquideas.Sort(dgvOrquideas.Columns[1], ListSortDirection.Ascending);
            bsOrquideas.Sort = "Descricao";
        }

        private IOrderedEnumerable<Orquidea> OutrasDaMesmaEspecie() {
            return from Orquidea o in _ctx.Orquideas.Local
                   where o.OrquideaID != OrquideaAtual.OrquideaID &&
                         o.GeneroID == OrquideaAtual.GeneroID &&
                         o.Especie == OrquideaAtual.Especie &&
                         o.Matriz != OrquideaAtual.OrquideaID &&
                         o.Data < OrquideaAtual.Data
                   orderby o.OrquideaID
                   select o;
        }

        private void buttonMatriz_Click(object sender, EventArgs e) {
            var orquideas = OutrasDaMesmaEspecie();
            switch (orquideas.Count()) {
                case 0:
                    MessageBox.Show("Nenhuma matriz encontrada.", "Matriz",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 1:
                    OrquideaAtual.Numero = 1;
                    OrquideaAtual.Sequencial = 1;
                    var first = orquideas.First();
                    OrquideaAtual.Matriz = first.OrquideaID;
                    first.Numero = 1;
                    break;
                default:
                    listBoxMatriz.DataSource = orquideas.ToList();
                    MatrizControlsVisible(true);
                    break;
            }
        }

        private void MatrizControlsVisible(bool visible) {
            listBoxMatriz.Visible = visible;
            buttonMatrizCancel.Visible = visible;
            buttonMatrizOK.Visible = visible;
        }

        private void buttonMatrizOKCancel_Click(object sender, EventArgs e) {
            MatrizControlsVisible(false);
            var btn = (Button)sender;
            var selected = (Orquidea)listBoxMatriz.SelectedItem;
            if (btn.Name.Contains("Cancel") || OrquideaAtual.Matriz == selected.OrquideaID) {
                return;
            }
            OrquideaAtual.Matriz = selected.OrquideaID;
            textBoxMatriz.Text = OrquideaAtual.Matriz.ToString();

            var list = (IEnumerable<Orquidea>)listBoxMatriz.DataSource;
            var max = list.Where(o => o.Matriz == selected.OrquideaID).OrderByDescending(o => o.Sequencial)
                .FirstOrDefault();

            OrquideaAtual.Sequencial = (byte?)(max?.Sequencial + 1 ?? 1);
            textBoxSequencial.Text = OrquideaAtual.Sequencial.ToString();
        }

        private void dgvOrquideas_SelectionChanged(object sender, EventArgs e) {
            if (OrquideaAtual == null) {
                return;
            }

            var fotosPath = Settings.Default.FotosPath;
            while (!Directory.Exists(fotosPath)) {
                if (FBD.ShowDialog() == DialogResult.Cancel) {
                    return;
                }
                fotosPath = FBD.SelectedPath + @"\";
                Settings.Default.FotosPath = fotosPath;
                Settings.Default.Save();
            }

            var file = $"{fotosPath}{OrquideaAtual.OrquideaID:0000}.jpg";
            pictureBoxFoto.ImageLocation = File.Exists(file) ? file : string.Empty;
            pictureBoxFoto.Visible = !string.IsNullOrEmpty(pictureBoxFoto.ImageLocation);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            if (!_ctx.SaveChanges(out var message)) {
                MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvOrquideas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var orquidea = (Orquidea)dgvOrquideas.Rows[e.RowIndex].DataBoundItem;
            if (orquidea.Termino != null) {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e) {
            var btn = (ToolStripButton)sender;
            var frm = new frmAddNew {
                comboBoxGenero = {
                    DataSource = comboBoxGenero.DataSource,
                    ValueMember = comboBoxGenero.ValueMember,
                    DisplayMember = comboBoxGenero.DisplayMember
                }
            };
            if (!btn.Name.EndsWith("New")) {
                frm.Lock = true;
                frm.comboBoxGenero.SelectedItem = comboBoxGenero.SelectedItem;
                frm.textBoxEspecie.Text = textBoxEspecie.Text;
                frm.textBoxCorPrincipal.Text = textBoxCorPrincipal.Text;
                frm.textBoxCorSecundaria.Text = textBoxCorSecundaria.Text;
            }
            if (frm.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            var o = new Orquidea {
                GeneroID = ((Genero)frm.comboBoxGenero.SelectedItem).GeneroID,
                Especie = frm.textBoxEspecie.Text,
                CorPrincipal = frm.textBoxCorPrincipal.Text,
                CorSecundaria = frm.textBoxCorSecundaria.Text,
                Data = frm.dateTimePickerCompra.Value,
                Origem = frm.textBoxOrigem.Text
            };
            SalvarOrquidea(o);
        }

        private void toolStripButtonMuda_Click(object sender, EventArgs e) {
            if (MessageBox.Show($"Confirma criação de muda para\n\n{OrquideaAtual.Descricao}?",
                    "Muda", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) {
                return;
            }

            var o = OrquideaAtual.Muda();

            SalvarOrquidea(o);
        }

        private void SalvarOrquidea(Orquidea o) {
            _ctx.Orquideas.Local.Add(o);
            if (!_ctx.SaveChanges(out var message)) {
                MessageBox.Show(message, "Muda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            var row = dgvOrquideas.Rows.Cast<DataGridViewRow>().First(r => (int)r.Cells[0].Value == o.OrquideaID).Index;
            dgvOrquideas.CurrentCell = dgvOrquideas.Rows[row].Cells[0];
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e) {
            var frm = new frmReportOld();
            frm.ShowDialog();
        }

        private void textBoxCorOuOrigem_TextChanged(object sender, EventArgs e) {
            var t = sender as TextBox;
            //say you want to do a search when user types 3 or more chars
            if (!(t?.Text.Length >= 3)) {
                return;
            }
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(t.Name.Contains("Cor") ? _Cores : _Origens);
            t.AutoCompleteCustomSource = collection;
        }

        private void pictureBoxFoto_DoubleClick(object sender, EventArgs e) {
            var frm = new frmZoom(OrquideaAtual.Descricao, pictureBoxFoto.ImageLocation);
            frm.Show();
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e) {
            var oneDrivePath = Environment.GetEnvironmentVariable("OneDrive");
            var oneDriveFotoPath = $@"{oneDrivePath}\Orquídeas\Fotos";

            SFD.InitialDirectory = $@"{oneDrivePath}\Orquídeas";
            if (SFD.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            if (!Directory.Exists(oneDriveFotoPath)) {
                Directory.CreateDirectory(oneDriveFotoPath);
            }

            using (var pck = new ExcelPackage(new FileInfo(SFD.FileName))) {
                while (pck.Workbook.Worksheets.Count > 0) {
                    pck.Workbook.Worksheets.Delete(1);
                }

                var ws = pck.Workbook.Worksheets.Add("Orquídeas");
                ws.View.ShowGridLines = false;

                var col = 1;
                ws.Cells[1, col++].Value = "ID";
                ws.Cells[1, col++].Value = "Gênero";
                ws.Cells[1, col++].Value = "Espécie";
                ws.Cells[1, col++].Value = "Cor Principal";
                ws.Cells[1, col++].Value = "Cor Secundária";
                ws.Cells[1, col++].Value = "Data";
                ws.Cells[1, col++].Value = "Matriz";
                ws.Cells[1, col++].Value = "Sequencial";
                ws.Cells[1, col++].Value = "Termino";
                ws.Cells[1, col].Value = "Image [image]";

                foreach (DataGridViewRow linha in dgvOrquideas.Rows) {
                    var orquidea = (Orquidea)linha.DataBoundItem;
                    col = 1;
                    var row = linha.Index + 2;
                    ws.Cells[row, col++].Value = orquidea.OrquideaID;
                    ws.Cells[row, col++].Value = orquidea.GeneroNome;
                    ws.Cells[row, col++].Value = orquidea.Especie;
                    ws.Cells[row, col++].Value = orquidea.CorPrincipal;
                    ws.Cells[row, col++].Value = orquidea.CorSecundaria;
                    ws.Cells[row, col++].Value = orquidea.Data;
                    ws.Cells[row, col++].Value = orquidea.Matriz;
                    ws.Cells[row, col++].Value = orquidea.Sequencial;
                    ws.Cells[row, col++].Value = orquidea.Termino;

                    var foto = $"{Settings.Default.FotosPath}{orquidea.OrquideaID:0000}.jpg";
                    if (File.Exists(foto)) {
                        ws.Cells[row, col].Value = $"./Fotos/{orquidea.OrquideaID:0000}.jpg";
                        // Copy file to OneDrive if newer
                        var target = $@"{oneDrivePath}\Orquídeas\Fotos\{orquidea.OrquideaID:0000}.jpg";
                        if (File.Exists(target)) {
                            var fotoInfo = new FileInfo(foto);
                            var targetInfo = new FileInfo(target);
                            if (fotoInfo.LastWriteTimeUtc <= targetInfo.LastWriteTimeUtc) {
                                continue;
                            }
                            File.Delete(target);
                            File.Copy(foto, target);
                        }
                        else {
                            File.Copy(foto, target);
                        }
                    }
                    else {
                        ws.Cells[row, col].Value = $"./Fotos/0000.jpg";
                    }
                }

                ws.Cells[2, 6,
                    dgvOrquideas.RowCount + 1, 6].Style.Numberformat.Format = "dd/MM/yyyy";
                ws.Cells[2, 9,
                    dgvOrquideas.RowCount + 1, 9].Style.Numberformat.Format = "dd/MM/yyyy";
                ws.Cells.AutoFitColumns(0);

                var range = ws.Cells[1, 1, dgvOrquideas.RowCount + 1, 10];
                var table = ws.Tables.Add(range, "tblOrquideas");
                table.ShowTotal = false;
                table.TableStyle = TableStyles.Light1;

                ws.View.FreezePanes(2, 1);
                pck.Save();
            }

            MessageBox.Show(@"Orquídeas exportadas.", @"Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxTermino_Validating(object sender, CancelEventArgs e) {
            textBoxTermino.Text = textBoxTermino.Text.Trim();
            var termino = textBoxTermino.Text;
            if (string.IsNullOrEmpty(termino)) {
                OrquideaAtual.Termino = null;
                return;
            }
            e.Cancel = !DateTime.TryParse(termino, out var data);
        }

        private void labelTermino_DoubleClick(object sender, EventArgs e) {
            OrquideaAtual.Termino = null;
        }

        private void dgvRepots_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show(e.Exception.Message, "DGV Data Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void toolStripButtonFiltrar_Click(object sender, EventArgs e) {
            bsOrquideas.Filter = $"Descricao = {toolStripTextBoxFiltro.Text}";
            dgvOrquideas.Refresh();
        }
    }
}