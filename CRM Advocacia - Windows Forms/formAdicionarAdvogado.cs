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
    public partial class formAdicionarAdvogado : Form
    {
        
        MetodosEquipe equipe = new MetodosEquipe();
        string nome, email, telefone, oab, especialidade, caminho;

        public formAdicionarAdvogado()
        {
            InitializeComponent();
        }

        private void formAdicionarAdvogado_Load(object sender, EventArgs e)
        {

            cbxTipoAdvogado.SelectedIndex = 0;

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
                string.IsNullOrWhiteSpace(tbxOAB.Text) ||
                cbxTipoAdvogado.SelectedIndex == -1)

            {
              
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            nome = tbxNome.Text;
            email = tbxEmail.Text;
            telefone = tbxTelefone.Text;
            oab = tbxOAB.Text;
            especialidade = cbxTipoAdvogado.SelectedItem.ToString();

            bool sucesso = equipe.AdicionarColaboradorAdvog(nome, email, telefone, "Advogado", oab, especialidade, caminho);

            if (sucesso)
            {

                MessageBox.Show("Advogado adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tbxNome.Clear();
                tbxEmail.Clear();
                tbxTelefone.Clear();
                tbxOAB.Clear();
                cbxTipoAdvogado.SelectedIndex = -1;

            }
            else
            {

                MessageBox.Show("Falha ao adicionar advogado. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

    }
}
