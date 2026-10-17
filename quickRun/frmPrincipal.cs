using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;

namespace quickRun
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new();

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            IniciarBat();

            bool config = await Config();

            chkAuto.Checked = config;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Saida();
        }

        private async Task<bool> Config()
        {
            HttpResponseMessage resposta = await client.GetAsync("http://localhost:4040/config");

            string resultado = await resposta.Content.ReadAsStringAsync();

            return bool.Parse(resultado);
        }

        async private void Saida()
        {
            HttpResponseMessage resposta = await client.GetAsync("http://localhost:4040/");

            string resultado = await resposta.Content.ReadAsStringAsync();

            JsonDocument json = JsonDocument.Parse(resultado);
            lblSaida.Text = json.RootElement.GetProperty("mensagem").GetString();
        }

        async private void Iniciar()
        {
            HttpResponseMessage resposta = await client.PostAsync("http://localhost:4040/iniciar", null);

            string resultado = await resposta.Content.ReadAsStringAsync();

            JsonDocument json = JsonDocument.Parse(resultado);
            lblSaida.Text = json.RootElement.GetProperty("mensagem").GetString();

            Console.WriteLine(resultado);
        }

        async private void Fechar()
        {
            HttpResponseMessage resposta = await client.PostAsync("http://localhost:4040/parar", null);

            string resultado = await resposta.Content.ReadAsStringAsync();

            JsonDocument json = JsonDocument.Parse(resultado);
            lblSaida.Text = json.RootElement.GetProperty("mensagem").GetString();

            Console.WriteLine(resultado);
        }

        // Cria a inicialização da api, colocando um arquivo na inicilização do windows
        private void IniciarBat()
        {
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
                    $"pm2 start server.js";

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private async void chkAuto_CheckedChanged(object sender, EventArgs e)
        {            
            if (chkAuto.Checked)
            {
                chkAuto.Enabled = false;

                HttpResponseMessage resposta = await client.PostAsync("http://localhost:4040/config/start", null);

                string resultado = await resposta.Content.ReadAsStringAsync();

                Console.WriteLine(resultado);

                JsonDocument json = JsonDocument.Parse(resultado);
                lblSaida.Text = json.RootElement.GetProperty("mensagem").GetString();
            }

            if (!chkAuto.Checked)
            {
                chkAuto.Enabled = false;

                HttpResponseMessage resposta = await client.PostAsync("http://localhost:4040/config/notStart", null);

                string resultado = await resposta.Content.ReadAsStringAsync();

                Console.WriteLine(resultado);

                JsonDocument json = JsonDocument.Parse(resultado);
                lblSaida.Text = json.RootElement.GetProperty("mensagem").GetString();
            }

            await Task.Delay(1000);

            chkAuto.Enabled = true;
        }
    }
}