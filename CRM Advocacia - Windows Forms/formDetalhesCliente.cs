using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formDetalhesCliente : Form
    {
        private Label lblNomeValor, lblDocumentoValor, lblTelefoneValor, lblEmailValor, lblContatoValor;
        private Label lblLogradouroValor, lblBairroValor, lblCidadeUFValor, lblCEPValor;
        private Label lblDescricaoValor;

        public formDetalhesCliente()
        {
            InitializeComponent();
            CriarControles();
        }

        private void CriarControles()
        {
            // Configurações do formulário
            this.Text = "Detalhes do Cliente";
            this.Width = 800;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Layout principal
            var layoutPrincipal = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(15),
                AutoScroll = true
            };
            this.Controls.Add(layoutPrincipal);

            // 🔹 GroupBox Dados Pessoais
            var gbPessoais = new GroupBox { Text = "Dados Pessoais", Dock = DockStyle.Top, Padding = new Padding(10), AutoSize = true };
            var tblPessoais = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            gbPessoais.Controls.Add(tblPessoais);

            tblPessoais.Controls.Add(new Label { Text = "Nome:", AutoSize = true, Font = FontePadrao() }, 0, 0);
            lblNomeValor = CriarLabelValor();
            tblPessoais.Controls.Add(lblNomeValor, 1, 0);

            tblPessoais.Controls.Add(new Label { Text = "Documento:", AutoSize = true, Font = FontePadrao() }, 0, 1);
            lblDocumentoValor = CriarLabelValor();
            tblPessoais.Controls.Add(lblDocumentoValor, 1, 1);

            // 🔹 GroupBox Contato
            var gbContato = new GroupBox { Text = "Contato", Dock = DockStyle.Top, Padding = new Padding(10), AutoSize = true };
            var tblContato = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            gbContato.Controls.Add(tblContato);

            tblContato.Controls.Add(new Label { Text = "Telefone:", AutoSize = true, Font = FontePadrao() }, 0, 0);
            lblTelefoneValor = CriarLabelValor();
            tblContato.Controls.Add(lblTelefoneValor, 1, 0);

            tblContato.Controls.Add(new Label { Text = "E-mail:", AutoSize = true, Font = FontePadrao() }, 0, 1);
            lblEmailValor = CriarLabelValor();
            tblContato.Controls.Add(lblEmailValor, 1, 1);

            tblContato.Controls.Add(new Label { Text = "Último Contato:", AutoSize = true, Font = FontePadrao() }, 0, 2);
            lblContatoValor = CriarLabelValor();
            tblContato.Controls.Add(lblContatoValor, 1, 2);

            // 🔹 GroupBox Endereço (quebrado em linhas)
            var gbEndereco = new GroupBox { Text = "Endereço", Dock = DockStyle.Top, Padding = new Padding(10), AutoSize = true };
            var tblEndereco = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            gbEndereco.Controls.Add(tblEndereco);

            tblEndereco.Controls.Add(new Label { Text = "Logradouro:", AutoSize = true, Font = FontePadrao() }, 0, 0);
            lblLogradouroValor = CriarLabelValor();
            tblEndereco.Controls.Add(lblLogradouroValor, 1, 0);

            tblEndereco.Controls.Add(new Label { Text = "Bairro:", AutoSize = true, Font = FontePadrao() }, 0, 1);
            lblBairroValor = CriarLabelValor();
            tblEndereco.Controls.Add(lblBairroValor, 1, 1);

            tblEndereco.Controls.Add(new Label { Text = "Cidade / UF:", AutoSize = true, Font = FontePadrao() }, 0, 2);
            lblCidadeUFValor = CriarLabelValor();
            tblEndereco.Controls.Add(lblCidadeUFValor, 1, 2);

            tblEndereco.Controls.Add(new Label { Text = "CEP:", AutoSize = true, Font = FontePadrao() }, 0, 3);
            lblCEPValor = CriarLabelValor();
            tblEndereco.Controls.Add(lblCEPValor, 1, 3);

            // 🔹 GroupBox Descrição
            var gbDescricao = new GroupBox { Text = "Descrição / Observações", Dock = DockStyle.Fill, Padding = new Padding(10) };
            lblDescricaoValor = new Label
            {
                Text = "-",
                AutoSize = false,
                Dock = DockStyle.Fill,
                Font = FontePadrao(),
                Padding = new Padding(5)
            };
            gbDescricao.Controls.Add(lblDescricaoValor);

            // Adiciona grupos ao layout principal
            layoutPrincipal.Controls.Add(gbPessoais, 0, 0);
            layoutPrincipal.Controls.Add(gbContato, 0, 1);
            layoutPrincipal.Controls.Add(gbEndereco, 0, 2);
            layoutPrincipal.Controls.Add(gbDescricao, 0, 3);
        }

        // Fonte padrão do sistema
        private Font FontePadrao()
        {
            return new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
        }

        // Helper para padronizar labels de valor
        private Label CriarLabelValor()
        {
            return new Label
            {
                Text = "-",
                AutoSize = true,
                Font = FontePadrao(),
                ForeColor = Color.Black,
                Padding = new Padding(3)
            };
        }

        // Preenche os dados do cliente
        public void CarregarDados(string nome, string documento, string telefone, string email, string descricao, DateTime contato, string cep, string logradouro, string numero, string bairro, string cidade, string uf)
        {
            lblNomeValor.Text = nome;
            lblDocumentoValor.Text = documento;
            lblTelefoneValor.Text = telefone;
            lblEmailValor.Text = email;
            lblDescricaoValor.Text = descricao;
            lblContatoValor.Text = contato.ToString("dd/MM/yyyy");

            lblLogradouroValor.Text = $"{logradouro}, {numero}";
            lblBairroValor.Text = bairro;
            lblCidadeUFValor.Text = $"{cidade} / {uf}";
            lblCEPValor.Text = cep;
        }
    }
}