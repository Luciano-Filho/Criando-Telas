using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalhando_com_tela
{
    public partial class Filme : Form
    {
        public Filme()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        { 
            using (HttpClient cliente = new HttpClient())
            {
                var url = "https://jsonplaceholder.typicode.com/posts";
                try
                {
                    HttpResponseMessage response = await cliente.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    // Lê o conteúdo da resposta como string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Exibe a resposta no console
                    Console.WriteLine(responseBody);
                    txtRetornoFilmes.Text = responseBody;

                }
                catch (Exception ex)
                {
                    //
                }
            }
        }
    }
}
