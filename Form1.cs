namespace Trabalhando_com_tela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text.Equals("luciano") && txt_senha.Text.Equals("1234"))
                {
                    var menu = new Menu();
                    menu.Show(this);

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!", "Erro", MessageBoxButtons.OK,
                                                                    MessageBoxIcon.Error);
                    txt_usuario.Focus(); //O cursor volta para esse campo
                    txt_senha.Text = "";
                    txt_usuario.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK,
                                                                    MessageBoxIcon.Error);
            }

        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.LightYellow;
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {

            txt_usuario.BackColor = Color.White;
        }
    }
}
