using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formAdicionarCliente : Form
    {

        MetodosBD MetodosBD = new MetodosBD();

        string nome, tipodoc, cpfcnpj, email, telefone, data, descricao, cep, estado, cidade, bairro, logradouro, numero, tiporesiden, compl;

        public formAdicionarCliente()
        {

            InitializeComponent();

        }

        private void formAdicionarCliente_Load(object sender, EventArgs e)
        {



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

                nome = tbxNomeCliente.Text;
                tipodoc = cbxTipoCliente.SelectedItem.ToString();
                cpfcnpj = tbxDocumento.Text;
                email = tbxEmail.Text;
                telefone = tbxTelefone.Text;
                data = dateContatoCliente.Value.ToString("yyyy-MM-dd");
                descricao = rtbxDesc.Text;
                cep = tbxCEP.Text.Replace("-", "").Trim();



              MetodosBD.AdicionarCliente(nome, cpfcnpj, tipodoc, telefone, email, descricao, data);

                tbxNomeCliente.Clear();
                tbxDocumento.Clear();
                tbxEmail.Clear();
                tbxTelefone.Clear();
                rtbxDesc.Clear();
                cbxTipoCliente.SelectedIndex = -1;
                dateContatoCliente.Value = DateTime.Now;

        }
    }
}
