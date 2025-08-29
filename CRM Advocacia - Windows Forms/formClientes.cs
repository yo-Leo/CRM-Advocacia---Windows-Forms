using System.Data;


namespace CRM_Advocacia___Windows_Forms
{
    public partial class formClientes : Form
    {

        MetodoGerais coringa = new MetodoGerais();

        public formClientes()
        {

            InitializeComponent();

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            formAdicionarCliente formAdicionarCliente = new formAdicionarCliente();

            formAdicionarCliente.Show();

        }

        private void formClientes_Load(object sender, EventArgs e)
        {

            

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            CarregarClientes();

        }

        private void CarregarClientes()
        {

            flpClientes.Controls.Clear(); // garantia para limpar o painel

            DataTable clientes = MetodosCliente.BuscarClientes(cbxFiltro.Text, tbxPesquisa.Text);

            foreach (DataRow row in clientes.Rows) // Loop para cada cliente
            {

                // Cria o card

                Panel card = new Panel();
                card.Width = 280;
                card.Height = 160;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(10);
                card.BackColor = Color.WhiteSmoke;

                // Todos os processoa abaixo cria labels costumizados para exibir as informações do cliente
                Label lblNome = new Label();
                lblNome.Text = row["nome_razao"].ToString();
                lblNome.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblNome.Location = new Point(10, 10);
                lblNome.AutoSize = true;

                Label lblDoc = new Label();
                lblDoc.Text = $"Doc: {row["cpf_cnpj"]}";
                lblDoc.Location = new Point(10, 40);
                lblDoc.AutoSize = true;

                Label lblContato = new Label();
                lblContato.Text = $"📞 {row["telefone"]} | ✉ {row["email"]}";
                lblContato.Location = new Point(10, 65);
                lblContato.AutoSize = true;

                Label lblData = new Label();
                lblData.Text = $"Último contato: {Convert.ToDateTime(row["contato_em"]).ToString("dd/MM/yyyy")}";
                lblData.Location = new Point(10, 90);
                lblData.AutoSize = true;

                //  Botão Detalhes
                Button btnDetalhes = new Button();
                btnDetalhes.Text = "Detalhes";
                btnDetalhes.Size = new Size(80, 30);
                btnDetalhes.Location = new Point(10, 120);
                btnDetalhes.Click += (s, e) => AbrirDetalhesCliente((int)row["id_cliente"]);

                // Botão Editar
                Button btnEditar = new Button();
                btnEditar.Text = "Editar";
                btnEditar.Size = new Size(80, 30);
                btnEditar.Location = new Point(100, 120);
                btnEditar.Click += (s, e) => AbrirEditarCliente((int)row["id_cliente"]);


                // Adiciona os novos elementos em cada card
                card.Controls.Add(lblNome);
                card.Controls.Add(lblDoc); //jgjgnbvn
                card.Controls.Add(lblContato);
                card.Controls.Add(lblData);
                card.Controls.Add(btnDetalhes);
                card.Controls.Add(btnEditar);

                // Adiciona o Card ao painel de clientes
                flpClientes.Controls.Add(card);

            }
        }

        private void AbrirDetalhesCliente(int idCliente)
        {
            // Busca os dados do cliente no banco
            DataTable cliente = MetodosCliente.BuscarClienteId(idCliente);

            if (cliente.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = cliente.Rows[0];

            formDetalhesCliente detalhes = new formDetalhesCliente();
            detalhes.CarregarDados(
                row["nome_razao"].ToString(),
                row["cpf_cnpj"].ToString(),
                row["telefone"].ToString(),
                row["email"].ToString(),
                row["descricao"].ToString(),
                Convert.ToDateTime(row["contato_em"]),
                row["cep"].ToString(),
                row["logradouro"].ToString(),
                row["numero"].ToString(),
                row["bairro"].ToString(),
                row["cidade"].ToString(),
                row["estado"].ToString()
            );

            detalhes.ShowDialog();
        }

        private void AbrirEditarCliente(int idCliente)
        {

            // Busca os dados do cliente no banco
            DataTable cliente = MetodosCliente.BuscarClienteId(idCliente);

            if (cliente.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = cliente.Rows[0];

            formEditarCliente editar = new formEditarCliente(idCliente);
            editar.ShowDialog();


        }

    }
}
