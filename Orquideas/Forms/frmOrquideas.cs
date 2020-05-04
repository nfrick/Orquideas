using DataLayer;
using DbContextExtensions;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using Orquideas.Properties;
using SuperPrompt;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Orquideas {
    public partial class frmOrquideas : Form {

        private readonly OrquideasEntities _ctx = new OrquideasEntities();
        private Orquidea OrquideaAtual => (Orquidea)bsOrquideas.Current;

        private readonly string[] _cores;
        private readonly string[] _origens;

        private string _fotosPath = Settings.Default.FotosPath;

        public frmOrquideas() {
            InitializeComponent();
            _ctx.Orquideas.Load();
            bsOrquideas.DataSource = _ctx.Orquideas.Local.ToBindingList();

            _ctx.ContainerTypes.Load();
            bsContainerType.DataSource = _ctx.ContainerTypes.Local.ToBindingList();
            bsContainerType.Sort = "Container";

            _ctx.Generos.Load();
            bsGeneros.DataSource = _ctx.Generos.Local.ToBindingList();
            bsGeneros.Sort = "Nome";
            generoIDComboBox.DataSource = bsGeneros;
            generoIDComboBox.ValueMember = "GeneroID";
            generoIDComboBox.DisplayMember = "Nome";

            _cores = _ctx.spCores().ToArray();
            _origens = _ctx.spOrigens().ToArray();

            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";
            SFD.FileName = "Orquideas.xlsx";

            dgvOrquideas.AutoGenerateColumns = false;

            dgvOrquideas.SetFont(null, 12);
            dgvRepots.SetFont(null, 12);
            dgvFloracoes.SetFont(null, 12);

            bsOrquideas.Sort = "Descricao";

            // https://stackoverflow.com/questions/9830093/how-to-pass-blank-textbox-value-as-null-to-binded-datetime
            terminoTextBox.DataBindings["Text"].NullValue = "";

            while (!Directory.Exists(_fotosPath)) {
                if (FBD.ShowDialog() == DialogResult.Cancel) {
                    return;
                }
                _fotosPath = FBD.SelectedPath + @"\";
                Settings.Default.FotosPath = _fotosPath;
                Settings.Default.Save();
            }
        }
        
        private void frmOrquideas_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_ctx.ChangeTracker.HasChanges()) {
                return;
            }
            switch (MessageBox.Show(_ctx.TextoSalvar(), "Orquídeas",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    e.Cancel = !SalvarAlteracoes();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        #region DATAGRIDVIEW -------------------------

        private void dgvOrquideas_SelectionChanged(object sender, EventArgs e) {
            if (OrquideaAtual == null) {
                return;
            }

            var file = OrquideaAtual.Foto(_fotosPath);
            pictureBoxFoto.ImageLocation = File.Exists(file) ? file : string.Empty;
            pictureBoxFoto.Visible = !string.IsNullOrEmpty(pictureBoxFoto.ImageLocation);

            orquideaBindingNavigatorSaveItem.Enabled = _ctx.ChangeTracker.HasChanges();
        }

        private void dgvOrquideas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var orquidea = (Orquidea)dgvOrquideas.Rows[e.RowIndex].DataBoundItem;
            if (orquidea?.Termino != null) {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }

        #endregion DATAGRIDVIEW -------------------------

        #region TOOLSTRIP -------------------------------

        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            SalvarAlteracoes();
            orquideaBindingNavigatorSaveItem.Enabled = _ctx.ChangeTracker.HasChanges();
        }

        private bool SalvarAlteracoes() {
            var result = _ctx.SaveChanges(out var message);
            if (!result) {
                MessageBox.Show(message, "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        private void toolStripButtonMuda_Click(object sender, EventArgs e) {
            if (MessageBox.Show($"Confirma criação de muda para\n\n{OrquideaAtual.Descricao}?",
                    "Muda", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) {
                return;
            }

            _ctx.Orquideas.Local.Add(OrquideaAtual.Muda());

            dgvOrquideas.ClearSelection(); //If you want
            var nRowIndex = dgvOrquideas.Rows.Count - 2;

            dgvOrquideas.Rows[nRowIndex].Selected = true;
            dgvOrquideas.Rows[nRowIndex].Cells[0].Selected = true;

            //In case if you want to scroll down as well.
            dgvOrquideas.FirstDisplayedScrollingRowIndex = nRowIndex;
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

                var row = 1;
                var col = 1;
                ws.Cells[row, col++].Value = "ID";
                ws.Cells[row, col++].Value = "Gênero";
                ws.Cells[row, col++].Value = "Espécie";
                ws.Cells[row, col++].Value = "Cor Principal";
                ws.Cells[row, col++].Value = "Cor Secundária";
                ws.Cells[row, col++].Value = "Data";
                ws.Cells[row, col++].Value = "Matriz";
                ws.Cells[row, col++].Value = "Sequencial";
                ws.Cells[row, col++].Value = "Termino";
                ws.Cells[row, col].Value = "Image [image]";


                foreach (var orquidea in _ctx.Orquideas.Local) {
                    row++;
                    col = 1;
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

        private void toolStripButtonReport_Click(object sender, EventArgs e) {
            var frm = new frmReport();
            frm.ShowDialog();
        }

        #endregion TOOLSTRIP ----------------------------

        #region CONTROLS --------------------------------

        private void textBoxOrigem_TextChanged(object sender, EventArgs e) {
            var t = sender as TextBox;
            //say you want to do a search when user types 3 or more chars
            if (!(t?.Text.Length >= 3)) {
                return;
            }
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(_origens);
            t.AutoCompleteCustomSource = collection;
        }

        private void labelTermino_DoubleClick(object sender, EventArgs e) {
            terminoTextBox.Text = null;
            OrquideaAtual.Termino = null;
        }

        private void terminoTextBox_DoubleClick(object sender, EventArgs e) {
            var data = DateTime.Today;
            if (PromptDialog.InputDate(OrquideaAtual.Descricao,
                    "Data de término", ref data) == DialogResult.OK) {
                terminoTextBox.Text = data.ToShortDateString();
            }
        }

        private void pictureBoxFoto_DoubleClick(object sender, EventArgs e) {
            var frm = new frmZoom(OrquideaAtual.Descricao, pictureBoxFoto.ImageLocation);
            frm.Show();
        }

        private void matrizTextBox_DoubleClick(object sender, EventArgs e) {
            var matrizes = OutrasDaMesmaEspecie();
            switch (matrizes.Count()) {
                case 0:
                    MessageBox.Show("Nenhuma matriz encontrada.", "Matriz",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case 1:
                    var matriz = matrizes.First();
                    if (matriz.OrquideaID == OrquideaAtual.Matriz) {
                        return;
                    }
                    OrquideaAtual.OrquideaMatriz = matriz;
                    OrquideaAtual.Sequencial = matriz.UltimoSequencial + 1;
                    break;

                default:
                    var lista = matrizes.Select(o => o.OrquideaID.ToString()).ToArray();
                    if (PromptDialog.InputList("Matriz",
                            $"Orquidea matriz para {OrquideaAtual.Descricao}:",
                            lista, out var id) == DialogResult.Cancel) {
                        return;
                    }
                    matrizTextBox.Text = id;
                    break;
            }
        }

        private IEnumerable<Orquidea> OutrasDaMesmaEspecie() {
            return _ctx.Orquideas.Local
                .Where(o => o.OrquideaID != OrquideaAtual.OrquideaID &&
                            o.Matriz != OrquideaAtual.OrquideaID &&
                            o.GeneroID == OrquideaAtual.GeneroID &&
                            o.Especie == OrquideaAtual.Especie &&
                            o.Data < OrquideaAtual.Data)
                .OrderBy(o => o.OrquideaID);
        }


        #endregion CONTROLS -----------------------------

    }
}
