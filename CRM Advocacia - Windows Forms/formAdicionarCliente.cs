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
    public partial class formAdicionarCliente : Form
    {



        public formAdicionarCliente()
        {

            InitializeComponent();

        }

        private void formAdicionarCliente_Load(object sender, EventArgs e)
        {

            cbxTipoCliente.SelectedIndex = 0;

        }

        private void comboTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxTipoCliente.SelectedItem.ToString() == "Pessoa Física")
            {

                tbxCNPJ.Visible = false;
                tbxCPF.Enabled = true;
                tbxCNPJ.Enabled = false;
                tbxCNPJ.Clear();

            }

            else if (cbxTipoCliente.SelectedItem.ToString() == "Pessoa Jurídica")
            {

                tbxCNPJ.Visible = true;
                tbxCPF.Enabled = false;
                tbxCNPJ.Enabled = true;
                tbxCPF.Clear();

            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            try
            {

                string nome = tbxNomeCliente.Text;
                string tipo = cbxTipoCliente.SelectedItem.ToString();
                string cpfcnpj = tbxCPF.Visible ? tbxCPF.Text : tbxCNPJ.Text;
                string email = tbxEmail.Text;
                string telefone = tbxTelefone.Text;
                string data = dateContatoCliente.Value.ToString("yyyy-MM-dd");
                string descricao = rtbxDesc.Text;

                ConexaoBD.AdicionarCliente(nome, cpfcnpj, tipo, telefone, email, descricao, data);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbxNomeCliente.Clear();
                tbxCPF.Clear();
                tbxCNPJ.Clear();
                tbxEmail.Clear();
                tbxTelefone.Clear();
                rtbxDesc.Clear();
                cbxTipoCliente.SelectedIndex = -1;
                dateContatoCliente.Value = DateTime.Now;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
