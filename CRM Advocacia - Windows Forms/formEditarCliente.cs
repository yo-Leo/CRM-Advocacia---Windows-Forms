using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formEditarCliente : Form
    {
        private int idCliente;
        MetodosCliente cliente = new MetodosCliente();
        MetodoGerais coringa = new MetodoGerais();

        public formEditarCliente(int id)
        {
            InitializeComponent();
            idCliente = id;
        }

        private void formEditarCliente_Load(object sender, EventArgs e)
        {
            // Carregar os dados do cliente pelo ID
            DataTable cliente = MetodosCliente.BuscarClienteId(idCliente);

            if (cliente.Rows.Count > 0)
            {
                DataRow row = cliente.Rows[0];

                tbxNomeCliente.Text = row["nome_razao"].ToString();
                tbxDocumento.Text = row["cpf_cnpj"].ToString();
                cbxTipoCliente.SelectedItem = row["tipo"].ToString();
                tbxEmail.Text = row["email"].ToString();
                tbxTelefone.Text = row["telefone"].ToString();
                rtbxDesc.Text = row["descricao"].ToString();
                dateContatoCliente.Value = Convert.ToDateTime(row["contato_em"]);
                tbxCEP.Text = row["cep"].ToString();
                tbxEstado.Text = row["estado"].ToString();
                tbxCidade.Text = row["cidade"].ToString();
                tbxBairro.Text = row["bairro"].ToString();
                tbxLogradouro.Text = row["logradouro"].ToString();
                tbxNumero.Text = row["numero"].ToString();
                cbxTipo.SelectedItem = row["tipo"].ToString();
                tbxComplemento.Text = row.Table.Columns.Contains("complemento") ? row["complemento"].ToString() : "";

                if (row.Table.Columns.Contains("ativa"))
                {

                    bool estaAtivo = Convert.ToBoolean(row["ativa"]);
                    cbxAtividade.SelectedItem = estaAtivo ? "Ativo" : "Inativo";

                }

            }

            // Garante que a máscara do documento seja aplicada corretamente
            cbxTipoCliente_SelectedIndexChanged(null, null);
        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoCliente.SelectedItem?.ToString() == "Pessoa Física")
            {
                tbxDocumento.Mask = "000.000.000-00";
                lbDocumento.Text = "CPF:";
            }
            else if (cbxTipoCliente.SelectedItem?.ToString() == "Pessoa Jurídica")
            {
                tbxDocumento.Mask = "00.000.000/0000-00";
                lbDocumento.Text = "CNPJ:";
            }
        }

        private async void tbxCEP_Leave(object sender, EventArgs e)
        {
            string cep = tbxCEP.Text.Replace("-", "").Trim();

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

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validações mantidas como estão...

            // Captura dos dados
            string nome = tbxNomeCliente.Text;
            string tipodoc = cbxTipoCliente.SelectedItem.ToString();
            string cpfcnpj = coringa.RemoverMascara(tbxDocumento.Text);
            string email = tbxEmail.Text;
            string telefone = tbxTelefone.Text;
            string data = dateContatoCliente.Value.ToString("yyyy-MM-dd");
            string descricao = rtbxDesc.Text;
            string estado = tbxEstado.Text;
            string cidade = tbxCidade.Text;
            string bairro = tbxBairro.Text;
            string logradouro = tbxLogradouro.Text;
            string numero = tbxNumero.Text;
            string tiporesiden = cbxTipo.Text;
            string compl = tbxComplemento.Text;
            string cep = coringa.RemoverMascara(tbxCEP.Text);
            bool ativo = cbxAtividade.SelectedItem.ToString() == "Ativo" ? true : false; ;

            // Validação de CPF/CNPJ
            if (tipodoc == "Pessoa Física" && cpfcnpj.Length != 11)
            {
                MessageBox.Show("O CPF informado é inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tipodoc == "Pessoa Jurídica" && cpfcnpj.Length != 14)
            {
                MessageBox.Show("O CNPJ informado é inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chamada para o método de atualização
            bool sucesso = cliente.EditarClienteComEndereco(
                idCliente, nome, cpfcnpj, tipodoc, telefone, email, descricao, data,
                cep, estado, cidade, bairro, logradouro, numero, tiporesiden, compl, ativo
            );

            if (sucesso)
            {
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha ao atualizar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
