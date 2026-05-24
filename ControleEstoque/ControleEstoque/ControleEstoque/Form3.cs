using System;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();

            foreach (string produto in DadosGlobais.produtos)
            {
                lstProdutos.Items.Add(produto);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}