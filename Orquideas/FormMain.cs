﻿using DataLayer;
using GridAndChartStyleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MoneyBin;
using Orquideas.Properties;

namespace Orquideas {
    public partial class FormMain : Form {
        private Orquidea OrquideaAtual => (Orquidea)dgvOrquideas.CurrentRow?.DataBoundItem;

        public FormMain() {
            
            InitializeComponent();
            dgvOrquideas.AutoGenerateColumns = false;

            GridStyles.FormatGrid(dgvOrquideas);
            GridStyles.FormatGrid(dgvRepots);
            GridStyles.FormatGrid(dgvFloracoes);


            SetFontSize(dgvOrquideas, 12);
            SetFontSize(dgvRepots, 12);
            SetFontSize(dgvFloracoes, 12);

            var generos =
                from Genero g in entityDataSource1.EntitySets["Generos"]
                orderby g.Nome
                select g;

            // assign BindingList to grid
            comboBoxGenero.DataSource = generos.ToList();
            comboBoxGenero.ValueMember = "GeneroID";
            comboBoxGenero.DisplayMember = "Nome";

            var containers = from ContainerType c in entityDataSource1.EntitySets["ContainerTypes"]
                             orderby c.Container
                             select c;

            containerDataGridViewComboBoxColumn.DataSource = containers.ToList();
            containerDataGridViewComboBoxColumn.ValueMember = "ContainerID";
            containerDataGridViewComboBoxColumn.DisplayMember = "Container";

            dgvOrquideas.Sort(dgvOrquideas.Columns[1], ListSortDirection.Ascending);
        }

        private void SetFontSize(DataGridView dgv, float size) {
            var font = new Font("Segoe UI", size);
            for (var i = 0; i < dgv.ColumnCount; i++) {
                dgv.Columns[i].DefaultCellStyle.Font = font;
            }
        }

        private IOrderedQueryable<Orquidea> OutrasDaMesmaEspecie() {
            return from Orquidea o in entityDataSource1.EntitySets["Orquideas"]
                   where o.GeneroID == OrquideaAtual.GeneroID &&
                         o.Especie == OrquideaAtual.Especie &&
                         o.OrquideaID != OrquideaAtual.OrquideaID &&
                         o.Matriz != OrquideaAtual.OrquideaID
                   orderby o.Genero.GeneroAbrev, o.Especie, o.CorPrincipal, o.CorSecundaria, o.Numero, o.Sequencial
                   select o;
        }

        private void buttonMatriz_Click(object sender, System.EventArgs e) {
            var orquideas = OutrasDaMesmaEspecie();
            switch (orquideas.Count()) {
                case 0:
                    MessageBox.Show("Nenhuma matriz encontrada.", "Matriz", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case 1:
                    OrquideaAtual.Matriz = orquideas.First().OrquideaID;
                    OrquideaAtual.Numero = 1;
                    OrquideaAtual.Sequencial = 1;
                    orquideas.First().Numero = 1;
                    break;
                default:
                    // create BindingList (sortable/filterable)
                    var bindingListOrquideas = entityDataSource1.CreateView(orquideas);

                    // assign BindingList to grid
                    listBoxMatriz.DataSource = bindingListOrquideas;
                    listBoxMatriz.ValueMember = "OrquideaID";
                    listBoxMatriz.DisplayMember = "OrquideaID";
                    listBoxMatriz.Visible = true;
                    buttonMatrizCancel.Visible = true;
                    buttonMatrizOK.Visible = true;
                    break;
            }
        }

        private void buttonMatrizOK_Click(object sender, System.EventArgs e) {
            listBoxMatriz.Visible = false;
            buttonMatrizCancel.Visible = false;
            buttonMatrizOK.Visible = false;
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

        private void dgvOrquideas_SelectionChanged(object sender, System.EventArgs e) {
            if (OrquideaAtual == null) {
                return;
            }
            var file = $"{Resources.FotosPath}{OrquideaAtual.OrquideaID:0000}.jpg";
            pictureBoxFoto.ImageLocation = File.Exists(file) ? file : string.Empty;
        }

        private void toolStripButtonSave_Click(object sender, System.EventArgs e) {
            entityDataSource1.SaveChanges();
        }

        private void dgvOrquideas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var orquidea = (Orquidea)dgvOrquideas.Rows[e.RowIndex].DataBoundItem;
            if (orquidea.Termino != null) {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }

        private void toolStripButtonNew_Click(object sender, System.EventArgs e) {
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
                GeneroID = (int)((Genero)frm.comboBoxGenero.SelectedItem).GeneroID,
                Especie = frm.textBoxEspecie.Text,
                CorPrincipal = frm.textBoxCorPrincipal.Text,
                CorSecundaria = frm.textBoxCorSecundaria.Text,
                Data = frm.dateTimePickerCompra.Value,
                Origem = frm.textBoxOrigem.Text
            };
            SalvarOrquidea(o);
        }

        private void toolStripButtonMuda_Click(object sender, System.EventArgs e) {
                var o = new Orquidea {
                    GeneroID = OrquideaAtual.GeneroID,
                    Especie = OrquideaAtual.Especie,
                    CorPrincipal = OrquideaAtual.CorPrincipal,
                    CorSecundaria = OrquideaAtual.CorSecundaria,
                    Data = DateTime.Today,
                    Origem = "casa",
                    Matriz = OrquideaAtual.OrquideaID,
                    Sequencial = OrquideaAtual.UltimoSequencial + 1
                };
                SalvarOrquidea(o);
        }

        private void SalvarOrquidea(Orquidea o) {
            using (var ctx = new OrquideasEntities()) {
                ctx.Orquideas.Add(o);
                ctx.SaveChanges();
            }
            entityDataSource1.Refresh();
            var row = dgvOrquideas.Rows.Cast<DataGridViewRow>().First(r => (int) r.Cells[0].Value == o.OrquideaID).Index;
            dgvOrquideas.CurrentCell = dgvOrquideas.Rows[row].Cells[0];
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e) {
            var frm = new frmReport();
            frm.ShowDialog();
        }
    }
}