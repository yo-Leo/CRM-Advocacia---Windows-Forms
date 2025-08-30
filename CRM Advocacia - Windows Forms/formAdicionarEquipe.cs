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
    public partial class formAdicionarEquipe : Form
    {

        MetodosEquipe equipe = new MetodosEquipe();
        string nome, email, telefone, oab, cargo, caminho;

        public formAdicionarEquipe()
        {
            InitializeComponent();
        }

        private void formAdicionarEquipe_Load(object sender, EventArgs e)
        {

            cbxTipoEquipe.SelectedIndex = 0;

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Title = "Selecione uma foto";
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxFoto.Image = Image.FromFile(ofd.FileName);

                    caminho = ofd.FileName;
                }
            }

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbxNome.Text) ||
                string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(tbxTelefone.Text) ||
                cbxTipoEquipe.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nome = tbxNome.Text;
            email = tbxEmail.Text;  
            telefone = tbxTelefone.Text;
            cargo = cbxTipoEquipe.SelectedItem.ToString();

            bool sucesso = equipe.AdicionarColaboradorEquipe(nome, email, telefone, "Equipe", cargo, caminho);

            if (sucesso)
            {
                MessageBox.Show("Membro da equipe adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbxNome.Clear();
                tbxEmail.Clear();
                tbxTelefone.Clear();
                cbxTipoEquipe.SelectedIndex = 0;


            }
            else
            {
                MessageBox.Show("Falha ao adicionar membro da equipe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
