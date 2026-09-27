using System.Net.Http;
using System.IO;

namespace quickRun
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            IniciarBat();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Saida();
        }

        async private void Saida()
        {
            HttpResponseMessage resposta = await client.GetAsync("http://localhost:4040/");

            string resultado = await resposta.Content.ReadAsStringAsync();

            lblSaida.Text = resultado;
        }

        async private void Iniciar()
        {
            HttpResponseMessage resposta = await client.PostAsync("http://localhost:4040/iniciar", null);

            string resultado = await resposta.Content.ReadAsStringAsync();

            lblSaida.Text = resultado;

            Console.WriteLine(resultado);
        }

        private void IniciarBat() {
            try
            {
                string pasta = Path.Combine(AppContext.BaseDirectory, "api");

                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                string caminhoPasta = pasta.Replace(userProfile, "%USERPROFILE%");

                string caminhoCompleto = Path.Combine(pasta, "inicia-api.bat");
                Console.WriteLine(caminhoCompleto);

                string conteudo = 
                    $"@echo off{Environment.NewLine}" +
                    $"cd /d {caminhoPasta}{Environment.NewLine}" +
                    $"if not exist node_modules (call npm install){Environment.NewLine}" +
                    $"node server.js";

                Console.WriteLine(conteudo);

                File.WriteAllText(caminhoCompleto, conteudo);

                string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                Console.WriteLine(startup);

                File.Copy(caminhoCompleto, Path.Combine(startup, "inicia-api.bat"), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro encontrado: {ex.GetType().Name}\n\nMensagem: {ex.Message}");
            }
            
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
    }
}
