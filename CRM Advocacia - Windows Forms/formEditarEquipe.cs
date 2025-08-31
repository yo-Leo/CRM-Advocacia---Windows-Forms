using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formEditarEquipe : Form
    {

        private DataRow equipe;
        public string caminho;

        public formEditarEquipe(DataRow equipe)
        {

            InitializeComponent();
            this.equipe = equipe;
            CarregarDados();

        }

        private void CarregarDados()
        {
            if (equipe == null) return;

            tbxNome.Text = equipe["nome"].ToString();
            tbxEmail.Text = equipe["email"].ToString();
            tbxTelefone.Text = equipe["telefone"].ToString();

            cbxTipoEquipe.Text = equipe["cargo"] != DBNull.Value ? equipe["cargo"].ToString() : "";

            cbxAtividade.SelectedItem = (Convert.ToBoolean(equipe["ativo"])) ? "Ativo" : "Inativo";

            if (equipe["foto"] != DBNull.Value)
            {
                try
                {
                    byte[] bytesFoto = (byte[])equipe["foto"];
                    using (MemoryStream ms = new MemoryStream(bytesFoto))
                    {
                        pbxFoto.Image = Image.FromStream(ms);
                        pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                }
            }
            else
            {
                pbxFoto.Image = null;
            }

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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            int idcolaborador = Convert.ToInt32(equipe["id_colaborador"]);
            string nome = tbxNome.Text.Trim();
            string email = tbxEmail.Text.Trim();
            string telefone = tbxTelefone.Text.Trim();
            string cargo = cbxTipoEquipe.SelectedItem?.ToString() ?? "";
            bool status = cbxAtividade.SelectedItem.ToString() == "Ativo" ? true : false; ;

            string caminhoFoto = caminho;

            if (MetodoEquipe.AtualizarColaboradorEquipe(idcolaborador, nome, email, telefone, cargo, status, caminhoFoto))
            {
                MessageBox.Show("Advogado atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao atualizar advogado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
