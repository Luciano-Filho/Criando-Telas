using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalhando_com_tela
{
    public partial class Bizagi : Form
    {
        public Bizagi()
        {
            InitializeComponent();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para essa aplicação só é possível realizar chamadas do tipo GET.", "",
                                                MessageBoxButtons.OK);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }
    }
}
