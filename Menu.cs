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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formFilmes = new Filme();
            formFilmes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formBizagi = new Bizagi();
            formBizagi.ShowDialog();
        }
    }
}
