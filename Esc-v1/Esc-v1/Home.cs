using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esc_v1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criacao_Usuario janela = new Criacao_Usuario();
            janela.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
