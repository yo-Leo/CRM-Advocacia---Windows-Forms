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

    public partial class formAdicionarProcesso : Form
    {

        MetodoProcesso processo = new MetodoProcesso();

        string numero, titulo, descricao, tipo, data, nomeCliente, nomeAdvogado, deschonor;
        decimal valorproces, valorhonor;

        public formAdicionarProcesso()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbxNumeroProcesso.Text) ||
                string.IsNullOrWhiteSpace(tbxTituloProcesso.Text) ||
                string.IsNullOrWhiteSpace(rtbxDesc.Text) ||
                cbxTipoProcesso.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(tbxNomeCliente.Text) ||
                string.IsNullOrWhiteSpace(tbxNomeAdvogado.Text) ||
                string.IsNullOrWhiteSpace(tbxDescHonora.Text) ||
                numValorProces.Value == 0 ||
                numValorHonor.Value == 0)
            {

                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            numero = tbxNumeroProcesso.Text;
            titulo = tbxTituloProcesso.Text;
            descricao = rtbxDesc.Text;
            tipo = cbxTipoProcesso.SelectedItem.ToString();
            data = dateInicioProcesso.Value.ToString("yyyy-MM-dd");
            nomeCliente = tbxNomeCliente.Text;
            nomeAdvogado = tbxNomeAdvogado.Text;
            valorproces = numValorProces.Value;
            deschonor = tbxDescHonora.Text;
            valorhonor = numValorHonor.Value;


            bool sucesso = processo.AdicionarProcesso(numero, titulo, descricao, tipo, data, nomeCliente, nomeAdvogado, valorproces, valorhonor, deschonor);

            if (sucesso)
            {

                MessageBox.Show("Processo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbxNumeroProcesso.Clear();
                tbxTituloProcesso.Clear();
                rtbxDesc.Clear();
                cbxTipoProcesso.SelectedIndex = -1;
                dateInicioProcesso.Value = DateTime.Now;
                tbxNomeCliente.Clear();
                tbxNomeAdvogado.Clear();
                numValorProces.Value = 0;


            }
            else
            {

                MessageBox.Show("Erro ao adicionar o processo. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void formAdicionarProcesso_Load(object sender, EventArgs e)
        {



        }
    }
}
