using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orquideas {
    public partial class frmAddNew : Form {
        public bool Lock { get; set; }
        public frmAddNew() {
            InitializeComponent();
        }

        private void frmAddNew_Load(object sender, EventArgs e) {
            if (!Lock) return;
            foreach (var ctl in Controls.Cast<Control>().Where(c=> !string.IsNullOrEmpty((string)c.Tag))) {
                ctl.Enabled = false;
            }
        }
    }
}
