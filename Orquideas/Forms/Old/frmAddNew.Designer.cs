namespace Orquideas {
    partial class frmAddNew {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNew));
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrigem = new System.Windows.Forms.TextBox();
            this.textBoxCorSecundaria = new System.Windows.Forms.TextBox();
            this.textBoxCorPrincipal = new System.Windows.Forms.TextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 40;
            this.label6.Tag = "";
            this.label6.Text = "/";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCompra.Location = new System.Drawing.Point(89, 117);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(129, 29);
            this.dateTimePickerCompra.TabIndex = 30;
            this.dateTimePickerCompra.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 38;
            this.label7.Tag = "";
            this.label7.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 37;
            this.label5.Tag = "";
            this.label5.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 36;
            this.label2.Tag = "";
            this.label2.Text = "Espécie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 35;
            this.label1.Tag = "";
            this.label1.Text = "Gênero";
            // 
            // textBoxOrigem
            // 
            this.textBoxOrigem.Location = new System.Drawing.Point(224, 117);
            this.textBoxOrigem.Name = "textBoxOrigem";
            this.textBoxOrigem.Size = new System.Drawing.Size(220, 29);
            this.textBoxOrigem.TabIndex = 31;
            this.textBoxOrigem.Tag = "";
            // 
            // textBoxCorSecundaria
            // 
            this.textBoxCorSecundaria.Location = new System.Drawing.Point(270, 82);
            this.textBoxCorSecundaria.Name = "textBoxCorSecundaria";
            this.textBoxCorSecundaria.Size = new System.Drawing.Size(173, 29);
            this.textBoxCorSecundaria.TabIndex = 29;
            this.textBoxCorSecundaria.Tag = "1";
            // 
            // textBoxCorPrincipal
            // 
            this.textBoxCorPrincipal.Location = new System.Drawing.Point(89, 82);
            this.textBoxCorPrincipal.Name = "textBoxCorPrincipal";
            this.textBoxCorPrincipal.Size = new System.Drawing.Size(163, 29);
            this.textBoxCorPrincipal.TabIndex = 28;
            this.textBoxCorPrincipal.Tag = "1";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(89, 12);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(354, 29);
            this.comboBoxGenero.TabIndex = 26;
            this.comboBoxGenero.Tag = "1";
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Location = new System.Drawing.Point(89, 47);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(354, 29);
            this.textBoxEspecie.TabIndex = 27;
            this.textBoxEspecie.Tag = "1";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ForeColor = System.Drawing.Color.Black;
            this.buttonOK.Image = global::Orquideas.Properties.Resources.Actions_dialog_ok_icon;
            this.buttonOK.Location = new System.Drawing.Point(459, 15);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 61);
            this.buttonOK.TabIndex = 41;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = global::Orquideas.Properties.Resources.Actions_edit_delete_icon;
            this.buttonCancel.Location = new System.Drawing.Point(459, 88);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 58);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Cancela";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddNew
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(546, 158);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrigem);
            this.Controls.Add(this.textBoxCorSecundaria);
            this.Controls.Add(this.textBoxCorPrincipal);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.textBoxEspecie);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Orquídea";
            this.Load += new System.EventHandler(this.frmAddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxGenero;
        public System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        public System.Windows.Forms.TextBox textBoxOrigem;
        public System.Windows.Forms.TextBox textBoxCorSecundaria;
        public System.Windows.Forms.TextBox textBoxCorPrincipal;
        public System.Windows.Forms.TextBox textBoxEspecie;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}