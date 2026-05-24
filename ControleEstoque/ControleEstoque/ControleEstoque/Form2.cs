using System;
using System.IO;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class Form2 : Form
    {
        string caminhoArquivo = "dados.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            string linha = txtNome.Text + " | " +
                           cmbCategoria.SelectedItem.ToString();

            DadosGlobais.produtos.Add(linha);

            File.AppendAllText(caminhoArquivo,
                               linha + Environment.NewLine);

            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}