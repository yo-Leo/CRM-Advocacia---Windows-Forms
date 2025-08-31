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
    public partial class formAdicionarPrazo : Form
    {

        MetodoPrazo prazo = new MetodoPrazo();
        string numero, tipo, data, descricao;

        public formAdicionarPrazo()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbxNumero.Text) ||
                cbxTipo.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbxDesc.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            numero = tbxNumero.Text;
            tipo = cbxTipo.SelectedItem.ToString();
            data = datePrazo.Value.ToString("yyyy-MM-dd");
            descricao = rtbxDesc.Text;

            bool sucesso = prazo.CriarPrazo(numero, tipo, data, descricao);

            if (sucesso)
            {
                MessageBox.Show("Prazo criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbxNumero.Clear();
                cbxTipo.SelectedIndex = 0;
                rtbxDesc.Clear();


            }
            else
            {

                MessageBox.Show("Erro ao criar o prazo. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
