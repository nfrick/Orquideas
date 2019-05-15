using System.Windows.Forms;

namespace Orquideas {
    public partial class frmZoom : Form {
        public frmZoom(string descricao, string path) {
            InitializeComponent();
            label1.Text = descricao;
            pictureBox1.ImageLocation = path;
        }
    }
}
