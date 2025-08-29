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
            flpClientes.Controls.Clear();

            DataTable clientes = MetodosCliente.BuscarClientes(cbxFiltro.Text, tbxPesquisa.Text, cbxAtividade.Text);

            foreach (DataRow row in clientes.Rows)
            {
                Panel card = new Panel
                {
                    Width = 280,
                    Height = 180,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.WhiteSmoke
                };

                // Nome
                Label lblNome = new Label
                {
                    Text = row["nome_razao"].ToString(),
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                // Documento
                Label lblDoc = new Label
                {
                    Text = $"Doc: {row["cpf_cnpj"]}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                // Contato
                Label lblContato = new Label
                {
                    Text = $"📞 {row["telefone"]} | ✉ {row["email"]}",
                    Location = new Point(10, 65),
                    AutoSize = true
                };

                // Último contato
                Label lblData = new Label
                {
                    Text = $"Último contato: {Convert.ToDateTime(row["contato_em"]).ToString("dd/MM/yyyy")}",
                    Location = new Point(10, 90),
                    AutoSize = true
                };

                // Status (Ativo/Inativo)
                bool ativo = Convert.ToBoolean(row["ativo"]);
                Label lblStatus = new Label
                {
                    Text = ativo ? "Status: Ativo ✅" : "Status: Inativo ❌",
                    ForeColor = ativo ? Color.Green : Color.Red,
                    Location = new Point(10, 115),
                    AutoSize = true
                };

                // Botão Detalhes
                Button btnDetalhes = new Button
                {
                    Text = "Detalhes",
                    Size = new Size(80, 30),
                    Location = new Point(10, 140)
                };
                btnDetalhes.Click += (s, e) => AbrirDetalhesCliente((int)row["id_cliente"]);

                // Botão Editar
                Button btnEditar = new Button
                {
                    Text = "Editar",
                    Size = new Size(80, 30),
                    Location = new Point(100, 140)
                };
                btnEditar.Click += (s, e) => AbrirEditarCliente((int)row["id_cliente"]);

                // Adiciona ao card
                card.Controls.Add(lblNome);
                card.Controls.Add(lblDoc);
                card.Controls.Add(lblContato);
                card.Controls.Add(lblData);
                card.Controls.Add(lblStatus);
                card.Controls.Add(btnDetalhes);
                card.Controls.Add(btnEditar);

                // Adiciona ao painel
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
            // Busca os dados do cliente e endereço no banco
            DataTable cliente = MetodosCliente.BuscarClienteId(idCliente);

            if (cliente.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = cliente.Rows[0];

            formEditarCliente editar = new formEditarCliente(idCliente);

            editar.CarregarDados(
                row["nome_razao"].ToString(),
                row["tipo"].ToString(),                           
                row["cpf_cnpj"].ToString(),
                row["telefone"].ToString(),
                row["email"].ToString(),
                row["descricao"].ToString(),
                Convert.ToDateTime(row["contato_em"]),
                row["cep"].ToString(),
                row["estado"].ToString(),
                row["cidade"].ToString(),
                row["bairro"].ToString(),
                row["logradouro"].ToString(),
                row["numero"].ToString(),
                row.Table.Columns.Contains("tipo_endereco") ? row["tipo_endereco"].ToString() : "Residencial", 
                row.Table.Columns.Contains("complemento") ? row["complemento"].ToString() : "",
                row.Table.Columns.Contains("ativo") ? (Convert.ToBoolean(row["ativo"]) ? "Ativo" : "Inativo") : "Ativo" 

            );

            editar.ShowDialog();
        }

    }
}
