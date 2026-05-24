using System.Windows.Forms;

namespace ControleEstoque
{
    partial class Form1
    {
        private Label lblTitulo;
        private Button btnCadastrar;
        private Button btnRelatorio;

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.btnCadastrar = new Button();
            this.btnRelatorio = new Button();

            this.SuspendLayout();

      
            lblTitulo.Text = "Controle de Estoque";
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new System.Drawing.Point(90, 30);

       
            btnCadastrar.Text = "Cadastrar Novo Item";
            btnCadastrar.Location = new System.Drawing.Point(70, 80);
            btnCadastrar.Size = new System.Drawing.Size(180, 40);
            btnCadastrar.Click += btnCadastrar_Click;

        
            btnRelatorio.Text = "Exibir Relatório";
            btnRelatorio.Location = new System.Drawing.Point(70, 140);
            btnRelatorio.Size = new System.Drawing.Size(180, 40);
            btnRelatorio.Click += btnRelatorio_Click;

        
            this.Text = "Controle de Estoque";
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnRelatorio);
            this.Load += Form1_Load;

            this.ResumeLayout(false);
        }
    }
}