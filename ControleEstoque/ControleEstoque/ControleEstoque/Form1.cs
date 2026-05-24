using System;
using System.IO;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class Form1 : Form
    {
        string caminhoArquivo = "dados.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            DadosGlobais.produtos.Clear();

            foreach (string linha in linhas)
            {
                DadosGlobais.produtos.Add(linha);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Form3 relatorio = new Form3();
            relatorio.ShowDialog();
        }
    }
}