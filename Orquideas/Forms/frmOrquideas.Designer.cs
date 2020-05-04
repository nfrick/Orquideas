namespace Orquideas {
    partial class frmOrquideas {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label generoIDLabel;
            System.Windows.Forms.Label especieLabel;
            System.Windows.Forms.Label corPrincipalLabel;
            System.Windows.Forms.Label corSecundariaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label matrizLabel;
            System.Windows.Forms.Label sequencialLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label terminoLabel;
            System.Windows.Forms.Label origemLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrquideas));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.terminoTextBox = new System.Windows.Forms.TextBox();
            this.bsOrquideas = new System.Windows.Forms.BindingSource(this.components);
            this.generoIDComboBox = new System.Windows.Forms.ComboBox();
            this.origemTextBox = new System.Windows.Forms.TextBox();
            this.especieTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFloracoes = new System.Windows.Forms.TabPage();
            this.dgvFloracoes = new SuperGrid.SuperDGV();
            this.dgvTextBoxColumnFloracaoInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumnFloracaoTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumnFloracaoHastes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumnFloracaoFlores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFloracoes = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageRepots = new System.Windows.Forms.TabPage();
            this.dgvRepots = new SuperGrid.SuperDGV();
            this.dgvTextBoxColumnRepotData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumnRepotContainer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsContainerType = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTextBoxColumnRepotXaxim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotPinus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotCascaPinus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotTronco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotSphagnum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotCarvao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotTerraVegetal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTextBoxColumnRepotAreia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsRepots = new System.Windows.Forms.BindingSource(this.components);
            this.corPrincipalTextBox = new System.Windows.Forms.TextBox();
            this.corSecundariaTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sequencialTextBox = new System.Windows.Forms.TextBox();
            this.matrizTextBox = new System.Windows.Forms.TextBox();
            this.dgvOrquideas = new SuperGrid.SuperDGV();
            this.dgvTextBoxColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTextBoxColumnOrquidea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMuda = new System.Windows.Forms.ToolStripButton();
            this.orquideaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.bsGeneros = new System.Windows.Forms.BindingSource(this.components);
            generoIDLabel = new System.Windows.Forms.Label();
            especieLabel = new System.Windows.Forms.Label();
            corPrincipalLabel = new System.Windows.Forms.Label();
            corSecundariaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            matrizLabel = new System.Windows.Forms.Label();
            sequencialLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            terminoLabel = new System.Windows.Forms.Label();
            origemLabel = new System.Windows.Forms.Label();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrquideas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageFloracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFloracoes)).BeginInit();
            this.tabPageRepots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContainerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrquideas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNav)).BeginInit();
            this.bindingNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // generoIDLabel
            // 
            generoIDLabel.AutoSize = true;
            generoIDLabel.BackColor = System.Drawing.SystemColors.ControlText;
            generoIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            generoIDLabel.Location = new System.Drawing.Point(11, 35);
            generoIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            generoIDLabel.Name = "generoIDLabel";
            generoIDLabel.Size = new System.Drawing.Size(80, 28);
            generoIDLabel.TabIndex = 1;
            generoIDLabel.Text = "Gênero:";
            // 
            // especieLabel
            // 
            especieLabel.AutoSize = true;
            especieLabel.BackColor = System.Drawing.SystemColors.ControlText;
            especieLabel.ForeColor = System.Drawing.SystemColors.Control;
            especieLabel.Location = new System.Drawing.Point(11, 74);
            especieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            especieLabel.Name = "especieLabel";
            especieLabel.Size = new System.Drawing.Size(80, 28);
            especieLabel.TabIndex = 3;
            especieLabel.Text = "Espécie:";
            // 
            // corPrincipalLabel
            // 
            corPrincipalLabel.AutoSize = true;
            corPrincipalLabel.BackColor = System.Drawing.SystemColors.ControlText;
            corPrincipalLabel.ForeColor = System.Drawing.SystemColors.Control;
            corPrincipalLabel.Location = new System.Drawing.Point(11, 113);
            corPrincipalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            corPrincipalLabel.Name = "corPrincipalLabel";
            corPrincipalLabel.Size = new System.Drawing.Size(47, 28);
            corPrincipalLabel.TabIndex = 5;
            corPrincipalLabel.Text = "Cor:";
            // 
            // corSecundariaLabel
            // 
            corSecundariaLabel.AutoSize = true;
            corSecundariaLabel.BackColor = System.Drawing.SystemColors.ControlText;
            corSecundariaLabel.ForeColor = System.Drawing.SystemColors.Control;
            corSecundariaLabel.Location = new System.Drawing.Point(275, 110);
            corSecundariaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            corSecundariaLabel.Name = "corSecundariaLabel";
            corSecundariaLabel.Size = new System.Drawing.Size(20, 28);
            corSecundariaLabel.TabIndex = 7;
            corSecundariaLabel.Text = "/";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.SystemColors.ControlText;
            dataLabel.ForeColor = System.Drawing.SystemColors.Control;
            dataLabel.Location = new System.Drawing.Point(11, 190);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(57, 28);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // matrizLabel
            // 
            matrizLabel.AutoSize = true;
            matrizLabel.BackColor = System.Drawing.SystemColors.ControlText;
            matrizLabel.ForeColor = System.Drawing.SystemColors.Control;
            matrizLabel.Location = new System.Drawing.Point(11, 222);
            matrizLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            matrizLabel.Name = "matrizLabel";
            matrizLabel.Size = new System.Drawing.Size(72, 28);
            matrizLabel.TabIndex = 11;
            matrizLabel.Text = "Matriz:";
            matrizLabel.DoubleClick += new System.EventHandler(this.matrizTextBox_DoubleClick);
            // 
            // sequencialLabel
            // 
            sequencialLabel.AutoSize = true;
            sequencialLabel.BackColor = System.Drawing.SystemColors.ControlText;
            sequencialLabel.ForeColor = System.Drawing.SystemColors.Control;
            sequencialLabel.Location = new System.Drawing.Point(202, 219);
            sequencialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sequencialLabel.Name = "sequencialLabel";
            sequencialLabel.Size = new System.Drawing.Size(20, 28);
            sequencialLabel.TabIndex = 13;
            sequencialLabel.Text = "-";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.BackColor = System.Drawing.SystemColors.ControlText;
            observacoesLabel.ForeColor = System.Drawing.SystemColors.Control;
            observacoesLabel.Location = new System.Drawing.Point(11, 290);
            observacoesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(127, 28);
            observacoesLabel.TabIndex = 15;
            observacoesLabel.Text = "Observações:";
            // 
            // terminoLabel
            // 
            terminoLabel.AutoSize = true;
            terminoLabel.BackColor = System.Drawing.SystemColors.ControlText;
            terminoLabel.ForeColor = System.Drawing.SystemColors.Control;
            terminoLabel.Location = new System.Drawing.Point(11, 257);
            terminoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            terminoLabel.Name = "terminoLabel";
            terminoLabel.Size = new System.Drawing.Size(86, 28);
            terminoLabel.TabIndex = 17;
            terminoLabel.Text = "Término:";
            terminoLabel.DoubleClick += new System.EventHandler(this.labelTermino_DoubleClick);
            // 
            // origemLabel
            // 
            origemLabel.AutoSize = true;
            origemLabel.BackColor = System.Drawing.SystemColors.ControlText;
            origemLabel.ForeColor = System.Drawing.SystemColors.Control;
            origemLabel.Location = new System.Drawing.Point(11, 146);
            origemLabel.Name = "origemLabel";
            origemLabel.Size = new System.Drawing.Size(82, 28);
            origemLabel.TabIndex = 34;
            origemLabel.Text = "Origem:";
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStripContainer.ContentPanel.Controls.Add(this.tlpMain);
            this.toolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1223, 696);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1223, 743);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1223, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.17247F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.82753F));
            this.tlpMain.Controls.Add(this.panel1, 1, 0);
            this.tlpMain.Controls.Add(this.dgvOrquideas, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1223, 696);
            this.tlpMain.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(observacoesLabel);
            this.panel1.Controls.Add(this.terminoTextBox);
            this.panel1.Controls.Add(this.generoIDComboBox);
            this.panel1.Controls.Add(origemLabel);
            this.panel1.Controls.Add(generoIDLabel);
            this.panel1.Controls.Add(this.origemTextBox);
            this.panel1.Controls.Add(this.especieTextBox);
            this.panel1.Controls.Add(this.pictureBoxFoto);
            this.panel1.Controls.Add(especieLabel);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.corPrincipalTextBox);
            this.panel1.Controls.Add(terminoLabel);
            this.panel1.Controls.Add(corPrincipalLabel);
            this.panel1.Controls.Add(this.corSecundariaTextBox);
            this.panel1.Controls.Add(this.observacoesTextBox);
            this.panel1.Controls.Add(corSecundariaLabel);
            this.panel1.Controls.Add(sequencialLabel);
            this.panel1.Controls.Add(this.dataDateTimePicker);
            this.panel1.Controls.Add(this.sequencialTextBox);
            this.panel1.Controls.Add(dataLabel);
            this.panel1.Controls.Add(matrizLabel);
            this.panel1.Controls.Add(this.matrizTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(396, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 690);
            this.panel1.TabIndex = 1;
            // 
            // terminoTextBox
            // 
            this.terminoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "Termino", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.terminoTextBox.Location = new System.Drawing.Point(138, 253);
            this.terminoTextBox.Name = "terminoTextBox";
            this.terminoTextBox.ReadOnly = true;
            this.terminoTextBox.Size = new System.Drawing.Size(133, 34);
            this.terminoTextBox.TabIndex = 36;
            this.terminoTextBox.DoubleClick += new System.EventHandler(this.terminoTextBox_DoubleClick);
            // 
            // bsOrquideas
            // 
            this.bsOrquideas.DataSource = typeof(DataLayer.Orquidea);
            // 
            // generoIDComboBox
            // 
            this.generoIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOrquideas, "GeneroID", true));
            this.generoIDComboBox.FormattingEnabled = true;
            this.generoIDComboBox.Location = new System.Drawing.Point(138, 32);
            this.generoIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.generoIDComboBox.Name = "generoIDComboBox";
            this.generoIDComboBox.Size = new System.Drawing.Size(300, 36);
            this.generoIDComboBox.TabIndex = 2;
            // 
            // origemTextBox
            // 
            this.origemTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.origemTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "Origem", true));
            this.origemTextBox.Location = new System.Drawing.Point(138, 143);
            this.origemTextBox.Name = "origemTextBox";
            this.origemTextBox.Size = new System.Drawing.Size(133, 34);
            this.origemTextBox.TabIndex = 35;
            this.origemTextBox.TextChanged += new System.EventHandler(this.textBoxOrigem_TextChanged);
            // 
            // especieTextBox
            // 
            this.especieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "Especie", true));
            this.especieTextBox.Location = new System.Drawing.Point(138, 71);
            this.especieTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.especieTextBox.Name = "especieTextBox";
            this.especieTextBox.Size = new System.Drawing.Size(300, 34);
            this.especieTextBox.TabIndex = 4;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(445, 32);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(367, 251);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 34;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.DoubleClick += new System.EventHandler(this.pictureBoxFoto_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFloracoes);
            this.tabControl1.Controls.Add(this.tabPageRepots);
            this.tabControl1.Location = new System.Drawing.Point(9, 463);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 230);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPageFloracoes
            // 
            this.tabPageFloracoes.AutoScroll = true;
            this.tabPageFloracoes.Controls.Add(this.dgvFloracoes);
            this.tabPageFloracoes.Location = new System.Drawing.Point(4, 37);
            this.tabPageFloracoes.Name = "tabPageFloracoes";
            this.tabPageFloracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFloracoes.Size = new System.Drawing.Size(795, 189);
            this.tabPageFloracoes.TabIndex = 0;
            this.tabPageFloracoes.Text = "Florações";
            this.tabPageFloracoes.UseVisualStyleBackColor = true;
            // 
            // dgvFloracoes
            // 
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFloracoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvFloracoes.AutoGenerateColumns = false;
            this.dgvFloracoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFloracoes.BackgroundColor = System.Drawing.Color.Black;
            this.dgvFloracoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFloracoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvFloracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFloracoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextBoxColumnFloracaoInicio,
            this.dgvTextBoxColumnFloracaoTermino,
            this.dgvTextBoxColumnFloracaoHastes,
            this.dgvTextBoxColumnFloracaoFlores});
            this.dgvFloracoes.DataSource = this.bsFloracoes;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFloracoes.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvFloracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFloracoes.EnableHeadersVisualStyles = false;
            this.dgvFloracoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvFloracoes.Location = new System.Drawing.Point(3, 3);
            this.dgvFloracoes.Name = "dgvFloracoes";
            this.dgvFloracoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFloracoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvFloracoes.RowHeadersWidth = 20;
            this.dgvFloracoes.RowTemplate.Height = 24;
            this.dgvFloracoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFloracoes.Size = new System.Drawing.Size(789, 183);
            this.dgvFloracoes.TabIndex = 0;
            // 
            // dgvTextBoxColumnFloracaoInicio
            // 
            this.dgvTextBoxColumnFloracaoInicio.DataPropertyName = "FloracaoInicio";
            this.dgvTextBoxColumnFloracaoInicio.HeaderText = "Início";
            this.dgvTextBoxColumnFloracaoInicio.Name = "dgvTextBoxColumnFloracaoInicio";
            // 
            // dgvTextBoxColumnFloracaoTermino
            // 
            this.dgvTextBoxColumnFloracaoTermino.DataPropertyName = "FloracaoTermino";
            this.dgvTextBoxColumnFloracaoTermino.HeaderText = "Término";
            this.dgvTextBoxColumnFloracaoTermino.Name = "dgvTextBoxColumnFloracaoTermino";
            // 
            // dgvTextBoxColumnFloracaoHastes
            // 
            this.dgvTextBoxColumnFloracaoHastes.DataPropertyName = "Hastes";
            this.dgvTextBoxColumnFloracaoHastes.HeaderText = "Hastes";
            this.dgvTextBoxColumnFloracaoHastes.Name = "dgvTextBoxColumnFloracaoHastes";
            // 
            // dgvTextBoxColumnFloracaoFlores
            // 
            this.dgvTextBoxColumnFloracaoFlores.DataPropertyName = "Flores";
            this.dgvTextBoxColumnFloracaoFlores.HeaderText = "Flores";
            this.dgvTextBoxColumnFloracaoFlores.Name = "dgvTextBoxColumnFloracaoFlores";
            // 
            // bsFloracoes
            // 
            this.bsFloracoes.DataMember = "Floracoes";
            this.bsFloracoes.DataSource = this.bsOrquideas;
            // 
            // tabPageRepots
            // 
            this.tabPageRepots.AutoScroll = true;
            this.tabPageRepots.Controls.Add(this.dgvRepots);
            this.tabPageRepots.Location = new System.Drawing.Point(4, 25);
            this.tabPageRepots.Name = "tabPageRepots";
            this.tabPageRepots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRepots.Size = new System.Drawing.Size(795, 201);
            this.tabPageRepots.TabIndex = 1;
            this.tabPageRepots.Text = "Repots";
            this.tabPageRepots.UseVisualStyleBackColor = true;
            // 
            // dgvRepots
            // 
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRepots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvRepots.AutoGenerateColumns = false;
            this.dgvRepots.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRepots.BackgroundColor = System.Drawing.Color.Black;
            this.dgvRepots.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvRepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextBoxColumnRepotData,
            this.dgvTextBoxColumnRepotContainer,
            this.dgvTextBoxColumnRepotXaxim,
            this.dgvTextBoxColumnRepotPinus,
            this.dgvTextBoxColumnRepotCascaPinus,
            this.dgvTextBoxColumnRepotTronco,
            this.dgvTextBoxColumnRepotSphagnum,
            this.dgvTextBoxColumnRepotCarvao,
            this.dgvTextBoxColumnRepotTerraVegetal,
            this.dgvTextBoxColumnRepotAreia});
            this.dgvRepots.DataSource = this.bsRepots;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRepots.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvRepots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepots.EnableHeadersVisualStyles = false;
            this.dgvRepots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvRepots.Location = new System.Drawing.Point(3, 3);
            this.dgvRepots.Name = "dgvRepots";
            this.dgvRepots.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepots.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvRepots.RowHeadersWidth = 20;
            this.dgvRepots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepots.Size = new System.Drawing.Size(789, 195);
            this.dgvRepots.TabIndex = 0;
            // 
            // dgvTextBoxColumnRepotData
            // 
            this.dgvTextBoxColumnRepotData.DataPropertyName = "Data";
            this.dgvTextBoxColumnRepotData.HeaderText = "Data";
            this.dgvTextBoxColumnRepotData.Name = "dgvTextBoxColumnRepotData";
            // 
            // dgvTextBoxColumnRepotContainer
            // 
            this.dgvTextBoxColumnRepotContainer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTextBoxColumnRepotContainer.DataPropertyName = "Container";
            this.dgvTextBoxColumnRepotContainer.DataSource = this.bsContainerType;
            this.dgvTextBoxColumnRepotContainer.DisplayMember = "Container";
            this.dgvTextBoxColumnRepotContainer.HeaderText = "Container";
            this.dgvTextBoxColumnRepotContainer.Name = "dgvTextBoxColumnRepotContainer";
            this.dgvTextBoxColumnRepotContainer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTextBoxColumnRepotContainer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvTextBoxColumnRepotContainer.ValueMember = "ContainerID";
            // 
            // bsContainerType
            // 
            this.bsContainerType.DataSource = typeof(DataLayer.ContainerType);
            // 
            // dgvTextBoxColumnRepotXaxim
            // 
            this.dgvTextBoxColumnRepotXaxim.DataPropertyName = "Xaxim";
            this.dgvTextBoxColumnRepotXaxim.HeaderText = "Xaxim";
            this.dgvTextBoxColumnRepotXaxim.Name = "dgvTextBoxColumnRepotXaxim";
            this.dgvTextBoxColumnRepotXaxim.Width = 70;
            // 
            // dgvTextBoxColumnRepotPinus
            // 
            this.dgvTextBoxColumnRepotPinus.DataPropertyName = "Pinus";
            this.dgvTextBoxColumnRepotPinus.HeaderText = "Pinus";
            this.dgvTextBoxColumnRepotPinus.Name = "dgvTextBoxColumnRepotPinus";
            this.dgvTextBoxColumnRepotPinus.Width = 70;
            // 
            // dgvTextBoxColumnRepotCascaPinus
            // 
            this.dgvTextBoxColumnRepotCascaPinus.DataPropertyName = "CascaPinus";
            this.dgvTextBoxColumnRepotCascaPinus.HeaderText = "Casca Pinus";
            this.dgvTextBoxColumnRepotCascaPinus.Name = "dgvTextBoxColumnRepotCascaPinus";
            this.dgvTextBoxColumnRepotCascaPinus.Width = 70;
            // 
            // dgvTextBoxColumnRepotTronco
            // 
            this.dgvTextBoxColumnRepotTronco.DataPropertyName = "TroncoCentral";
            this.dgvTextBoxColumnRepotTronco.HeaderText = "Tronco Central";
            this.dgvTextBoxColumnRepotTronco.Name = "dgvTextBoxColumnRepotTronco";
            this.dgvTextBoxColumnRepotTronco.Width = 70;
            // 
            // dgvTextBoxColumnRepotSphagnum
            // 
            this.dgvTextBoxColumnRepotSphagnum.DataPropertyName = "Sphagnum";
            this.dgvTextBoxColumnRepotSphagnum.HeaderText = "Sphagnum";
            this.dgvTextBoxColumnRepotSphagnum.Name = "dgvTextBoxColumnRepotSphagnum";
            this.dgvTextBoxColumnRepotSphagnum.Width = 70;
            // 
            // dgvTextBoxColumnRepotCarvao
            // 
            this.dgvTextBoxColumnRepotCarvao.DataPropertyName = "Carvao";
            this.dgvTextBoxColumnRepotCarvao.HeaderText = "Carvão";
            this.dgvTextBoxColumnRepotCarvao.Name = "dgvTextBoxColumnRepotCarvao";
            this.dgvTextBoxColumnRepotCarvao.Width = 70;
            // 
            // dgvTextBoxColumnRepotTerraVegetal
            // 
            this.dgvTextBoxColumnRepotTerraVegetal.DataPropertyName = "TerraVegetal";
            this.dgvTextBoxColumnRepotTerraVegetal.HeaderText = "Terra Vegetal";
            this.dgvTextBoxColumnRepotTerraVegetal.Name = "dgvTextBoxColumnRepotTerraVegetal";
            this.dgvTextBoxColumnRepotTerraVegetal.Width = 70;
            // 
            // dgvTextBoxColumnRepotAreia
            // 
            this.dgvTextBoxColumnRepotAreia.DataPropertyName = "Areia";
            this.dgvTextBoxColumnRepotAreia.HeaderText = "Areia";
            this.dgvTextBoxColumnRepotAreia.Name = "dgvTextBoxColumnRepotAreia";
            this.dgvTextBoxColumnRepotAreia.Width = 70;
            // 
            // bsRepots
            // 
            this.bsRepots.DataMember = "Repots";
            this.bsRepots.DataSource = this.bsOrquideas;
            // 
            // corPrincipalTextBox
            // 
            this.corPrincipalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "CorPrincipal", true));
            this.corPrincipalTextBox.Location = new System.Drawing.Point(138, 107);
            this.corPrincipalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.corPrincipalTextBox.Name = "corPrincipalTextBox";
            this.corPrincipalTextBox.Size = new System.Drawing.Size(133, 34);
            this.corPrincipalTextBox.TabIndex = 6;
            // 
            // corSecundariaTextBox
            // 
            this.corSecundariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "CorSecundaria", true));
            this.corSecundariaTextBox.Location = new System.Drawing.Point(299, 107);
            this.corSecundariaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.corSecundariaTextBox.Name = "corSecundariaTextBox";
            this.corSecundariaTextBox.Size = new System.Drawing.Size(139, 34);
            this.corSecundariaTextBox.TabIndex = 8;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(138, 290);
            this.observacoesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacoesTextBox.Size = new System.Drawing.Size(674, 166);
            this.observacoesTextBox.TabIndex = 16;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrquideas, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(138, 179);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(133, 34);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // sequencialTextBox
            // 
            this.sequencialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "Sequencial", true));
            this.sequencialTextBox.Enabled = false;
            this.sequencialTextBox.Location = new System.Drawing.Point(223, 216);
            this.sequencialTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sequencialTextBox.Name = "sequencialTextBox";
            this.sequencialTextBox.Size = new System.Drawing.Size(48, 34);
            this.sequencialTextBox.TabIndex = 14;
            // 
            // matrizTextBox
            // 
            this.matrizTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrquideas, "Matriz", true));
            this.matrizTextBox.Enabled = false;
            this.matrizTextBox.Location = new System.Drawing.Point(138, 216);
            this.matrizTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrizTextBox.Name = "matrizTextBox";
            this.matrizTextBox.Size = new System.Drawing.Size(64, 34);
            this.matrizTextBox.TabIndex = 12;
            this.matrizTextBox.DoubleClick += new System.EventHandler(this.matrizTextBox_DoubleClick);
            // 
            // dgvOrquideas
            // 
            this.dgvOrquideas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrquideas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvOrquideas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOrquideas.AutoGenerateColumns = false;
            this.dgvOrquideas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrquideas.BackgroundColor = System.Drawing.Color.Black;
            this.dgvOrquideas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrquideas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvOrquideas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrquideas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextBoxColumnID,
            this.dgvTextBoxColumnOrquidea});
            this.dgvOrquideas.DataSource = this.bsOrquideas;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrquideas.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvOrquideas.EnableHeadersVisualStyles = false;
            this.dgvOrquideas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvOrquideas.Location = new System.Drawing.Point(4, 9);
            this.dgvOrquideas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrquideas.Name = "dgvOrquideas";
            this.dgvOrquideas.ReadOnly = true;
            this.dgvOrquideas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrquideas.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvOrquideas.RowHeadersWidth = 20;
            this.dgvOrquideas.RowTemplate.Height = 24;
            this.dgvOrquideas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrquideas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrquideas.Size = new System.Drawing.Size(385, 683);
            this.dgvOrquideas.TabIndex = 0;
            this.dgvOrquideas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrquideas_CellFormatting);
            this.dgvOrquideas.SelectionChanged += new System.EventHandler(this.dgvOrquideas_SelectionChanged);
            // 
            // dgvTextBoxColumnID
            // 
            this.dgvTextBoxColumnID.DataPropertyName = "OrquideaID";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvTextBoxColumnID.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvTextBoxColumnID.HeaderText = "ID";
            this.dgvTextBoxColumnID.Name = "dgvTextBoxColumnID";
            this.dgvTextBoxColumnID.ReadOnly = true;
            this.dgvTextBoxColumnID.Width = 40;
            // 
            // dgvTextBoxColumnOrquidea
            // 
            this.dgvTextBoxColumnOrquidea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTextBoxColumnOrquidea.DataPropertyName = "Descricao";
            this.dgvTextBoxColumnOrquidea.HeaderText = "Orquídea";
            this.dgvTextBoxColumnOrquidea.Name = "dgvTextBoxColumnOrquidea";
            this.dgvTextBoxColumnOrquidea.ReadOnly = true;
            // 
            // bindingNav
            // 
            this.bindingNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNav.BindingSource = this.bsOrquideas;
            this.bindingNav.CountItem = this.bindingNavigatorCountItem;
            this.bindingNav.CountItemFormat = "de {0}";
            this.bindingNav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNav.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButtonMuda,
            this.bindingNavigatorDeleteItem,
            this.orquideaBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButtonExcel,
            this.toolStripButtonReport});
            this.bindingNav.Location = new System.Drawing.Point(0, 0);
            this.bindingNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNav.Name = "bindingNav";
            this.bindingNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNav.Size = new System.Drawing.Size(1223, 30);
            this.bindingNav.TabIndex = 1;
            this.bindingNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorAddNewItem.Text = "Nova";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 27);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(60, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMoveNextItem.Text = "Próxima";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMoveLastItem.Text = "Última";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripButtonMuda
            // 
            this.toolStripButtonMuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMuda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMuda.Image")));
            this.toolStripButtonMuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMuda.Name = "toolStripButtonMuda";
            this.toolStripButtonMuda.Size = new System.Drawing.Size(58, 27);
            this.toolStripButtonMuda.Text = "Muda";
            this.toolStripButtonMuda.Click += new System.EventHandler(this.toolStripButtonMuda_Click);
            // 
            // orquideaBindingNavigatorSaveItem
            // 
            this.orquideaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orquideaBindingNavigatorSaveItem.Enabled = false;
            this.orquideaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orquideaBindingNavigatorSaveItem.Image")));
            this.orquideaBindingNavigatorSaveItem.Name = "orquideaBindingNavigatorSaveItem";
            this.orquideaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 27);
            this.orquideaBindingNavigatorSaveItem.Text = "Salvar";
            this.orquideaBindingNavigatorSaveItem.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripButtonExcel
            // 
            this.toolStripButtonExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExcel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExcel.Image")));
            this.toolStripButtonExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcel.Name = "toolStripButtonExcel";
            this.toolStripButtonExcel.Size = new System.Drawing.Size(52, 27);
            this.toolStripButtonExcel.Text = "Excel";
            this.toolStripButtonExcel.Click += new System.EventHandler(this.toolStripButtonExcel_Click);
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReport.Image")));
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(82, 27);
            this.toolStripButtonReport.Text = "Relatório";
            this.toolStripButtonReport.Click += new System.EventHandler(this.toolStripButtonReport_Click);
            // 
            // bsGeneros
            // 
            this.bsGeneros.DataSource = typeof(DataLayer.Genero);
            // 
            // frmOrquideas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 743);
            this.Controls.Add(this.bindingNav);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrquideas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrquideas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrquideas_FormClosing);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrquideas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFloracoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFloracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFloracoes)).EndInit();
            this.tabPageRepots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContainerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrquideas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNav)).EndInit();
            this.bindingNav.ResumeLayout(false);
            this.bindingNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGeneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.BindingSource bsOrquideas;
        private System.Windows.Forms.BindingNavigator bindingNav;
        private SuperGrid.SuperDGV dgvOrquideas;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orquideaBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox generoIDComboBox;
        private System.Windows.Forms.TextBox especieTextBox;
        private System.Windows.Forms.TextBox corPrincipalTextBox;
        private System.Windows.Forms.TextBox corSecundariaTextBox;
        private System.Windows.Forms.TextBox matrizTextBox;
        private System.Windows.Forms.TextBox sequencialTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.BindingSource bsContainerType;
        private System.Windows.Forms.BindingSource bsGeneros;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFloracoes;
        private System.Windows.Forms.TabPage tabPageRepots;
        private SuperGrid.SuperDGV dgvRepots;
        private System.Windows.Forms.BindingSource bsFloracoes;
        private System.Windows.Forms.BindingSource bsRepots;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.TextBox origemTextBox;
        private System.Windows.Forms.TextBox terminoTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcel;
        private System.Windows.Forms.ToolStripButton toolStripButtonReport;
        private System.Windows.Forms.ToolStripButton toolStripButtonMuda;
        private SuperGrid.SuperDGV dgvFloracoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnRepotData;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvTextBoxColumnRepotContainer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotXaxim;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotPinus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotCascaPinus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotTronco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotSphagnum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotCarvao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotTerraVegetal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvTextBoxColumnRepotAreia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnOrquidea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnFloracaoInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnFloracaoTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnFloracaoHastes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextBoxColumnFloracaoFlores;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}