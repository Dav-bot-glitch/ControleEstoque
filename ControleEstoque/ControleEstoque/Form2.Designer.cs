using System.Windows.Forms;

namespace ControleEstoque
{
    partial class Form2
    {
        private Label lblNome;
        private Label lblCategoria;
        private TextBox txtNome;
        private ComboBox cmbCategoria;
        private Button btnAdicionar;

        private void InitializeComponent()
        {
            this.lblNome = new Label();
            this.lblCategoria = new Label();
            this.txtNome = new TextBox();
            this.cmbCategoria = new ComboBox();
            this.btnAdicionar = new Button();

            this.SuspendLayout();

            // lblNome
            lblNome.Text = "Nome do Produto";
            lblNome.Location = new System.Drawing.Point(30, 20);

            // txtNome
            txtNome.Location = new System.Drawing.Point(30, 45);
            txtNome.Width = 200;

            // lblCategoria
            lblCategoria.Text = "Categoria";
            lblCategoria.Location = new System.Drawing.Point(30, 80);

            // cmbCategoria
            cmbCategoria.Location = new System.Drawing.Point(30, 105);
            cmbCategoria.Width = 200;
            cmbCategoria.Items.AddRange(new object[]
            {
                "Alimentos",
                "Bebidas",
                "Higiene",
                "Limpeza"
            });

            // btnAdicionar
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Location = new System.Drawing.Point(30, 150);
            btnAdicionar.Click += btnAdicionar_Click;

            // Form2
            this.Text = "Cadastro";
            this.ClientSize = new System.Drawing.Size(300, 230);
            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            this.Controls.Add(lblCategoria);
            this.Controls.Add(cmbCategoria);
            this.Controls.Add(btnAdicionar);

            this.ResumeLayout(false);
        }
    }
}