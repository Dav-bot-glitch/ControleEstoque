using System.Windows.Forms;

namespace ControleEstoque
{
    partial class Form3
    {
        private ListBox lstProdutos;
        private Button btnVoltar;

        private void InitializeComponent()
        {
            this.lstProdutos = new ListBox();
            this.btnVoltar = new Button();

            this.SuspendLayout();

            // lstProdutos
            lstProdutos.Location = new System.Drawing.Point(20, 20);
            lstProdutos.Size = new System.Drawing.Size(250, 150);

            // btnVoltar
            btnVoltar.Text = "Voltar";
            btnVoltar.Location = new System.Drawing.Point(100, 180);
            btnVoltar.Click += btnVoltar_Click;

            // Form3
            this.Text = "Relatório";
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(lstProdutos);
            this.Controls.Add(btnVoltar);
            this.Load += Form3_Load;

            this.ResumeLayout(false);
        }
    }
}