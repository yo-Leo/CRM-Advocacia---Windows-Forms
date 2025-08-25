using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formAdicionarCliente : Form
    {

        MetodosBD MetodosBD = new MetodosBD();
        MetodoCoringa coringa = new MetodoCoringa();

        string nome, tipodoc, cpfcnpj, email, telefone, data, descricao, cep, estado, cidade, bairro, logradouro, numero, tiporesiden, compl;

        public formAdicionarCliente()
        {

            InitializeComponent();

        }

        private void formAdicionarCliente_Load(object sender, EventArgs e)
        {

            cbxTipoCliente.SelectedIndex = 0;

        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoCliente.SelectedItem.ToString() == "Pessoa Física")
            {

                tbxDocumento.Mask = "000.000.000-00";
                tbxDocumento.Text = "";
                tbxDocumento.PromptChar = '_';

                lbDocumento.Text = "CPF:";

            }

            else if (cbxTipoCliente.SelectedItem.ToString() == "Pessoa Jurídica")
            {
                tbxDocumento.Mask = "00.000.000/0000-00";
                tbxDocumento.Text = "";
                tbxDocumento.PromptChar = '_';

                lbDocumento.Text = "CNPJ:";

            }
        }

        private async void tbxCEP_Leave(object sender, EventArgs e)
        {

            cep = tbxCEP.Text.Replace("-", "").Trim();

            if (!string.IsNullOrEmpty(cep) && cep.Length == 8)
            {

                try
                {

                    using (HttpClient client = new HttpClient())
                    {

                        string url = $"https://viacep.com.br/ws/{cep}/json/";
                        var response = await client.GetStringAsync(url);

                        JObject endereco = JObject.Parse(response);

                        if (endereco["erro"] == null)
                        {

                            tbxLogradouro.Text = endereco["logradouro"]?.ToString();
                            tbxBairro.Text = endereco["bairro"]?.ToString();
                            tbxCidade.Text = endereco["localidade"]?.ToString();
                            tbxEstado.Text = endereco["uf"]?.ToString();

                        }

                        else
                        {

                            MessageBox.Show("CEP não encontrado!");

                        }
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao buscar CEP: " + ex.Message);

                }
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbxNomeCliente.Text) ||
                cbxTipoCliente.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(tbxDocumento.Text.Replace("_", "").Trim()) ||
                string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(tbxTelefone.Text) ||
                string.IsNullOrWhiteSpace(tbxCEP.Text.Replace("-", "").Replace("_", "").Trim()) ||
                string.IsNullOrWhiteSpace(tbxEstado.Text) ||
                string.IsNullOrWhiteSpace(tbxCidade.Text) ||
                string.IsNullOrWhiteSpace(tbxBairro.Text) ||
                string.IsNullOrWhiteSpace(tbxLogradouro.Text) ||
                string.IsNullOrWhiteSpace(tbxNumero.Text) ||
                cbxTipo.SelectedIndex == -1)
            {

                MessageBox.Show("Preencha todos os campos antes de continuar!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            nome = tbxNomeCliente.Text;
            tipodoc = cbxTipoCliente.SelectedItem.ToString();
            cpfcnpj = coringa.RemoverMascara(tbxDocumento.Text);
            email = tbxEmail.Text;
            telefone = tbxTelefone.Text;
            data = dateContatoCliente.Value.ToString("yyyy-MM-dd");
            descricao = rtbxDesc.Text;
            cep = coringa.RemoverMascara(tbxCEP.Text);
            estado = tbxEstado.Text;
            cidade = tbxCidade.Text;
            bairro = tbxBairro.Text;
            logradouro = tbxLogradouro.Text;
            numero = tbxNumero.Text;
            tiporesiden = cbxTipo.Text;
            compl = tbxComplemento.Text;

            bool sucesso = MetodosBD.AdicionarClienteComEndereco(
        nome, cpfcnpj, tipodoc, telefone, email, descricao, data,
        cep, estado, cidade, bairro, logradouro, numero, tiporesiden, compl);

            if (sucesso)
            {
                MessageBox.Show("Cliente e endereço cadastrados com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Só limpa os campos se deu certo
                tbxNomeCliente.Clear();
                tbxDocumento.Clear();
                tbxEmail.Clear();
                tbxTelefone.Clear();
                rtbxDesc.Clear();
                cbxTipoCliente.SelectedIndex = 0;
                dateContatoCliente.Value = DateTime.Now;
                tbxCEP.Clear();
                tbxEstado.Clear();
                tbxCidade.Clear();
                tbxBairro.Clear();
                tbxLogradouro.Clear();
                tbxNumero.Clear();
                cbxTipo.SelectedIndex = -1;
                tbxComplemento.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar. Nenhum dado foi salvo.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
