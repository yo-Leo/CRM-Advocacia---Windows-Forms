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
    public partial class formEditarAdvogado : Form
    {

        public DataRow advogado;
        public string caminho;

        public formEditarAdvogado(DataRow advogado)
        {

            InitializeComponent();
            this.advogado = advogado;
            CarregarDados();

        }

        private void CarregarDados()
        {

            if (advogado == null) return;

            // Coleta os dados do advogado e preenche os campos do formulário
            tbxNome.Text = advogado["nome"].ToString();
            tbxEmail.Text = advogado["email"].ToString();
            tbxTelefone.Text = advogado["telefone"].ToString();
            tbxOAB.Text = advogado["oab"] != DBNull.Value ? advogado["oab"].ToString() : "";
            cbxTipoAdvogado.Text = advogado["especialidade"] != DBNull.Value ? advogado["especialidade"].ToString() : "";
            cbxAtividade.SelectedItem = (Convert.ToBoolean(advogado["ativo"])) ? "Ativo" : "Inativo";

            // Valida a foto no banco de dados e adiciona no picture box
            if (advogado["foto"] != DBNull.Value)
            {
                byte[] bytesFoto = (byte[])advogado["foto"];

                if (bytesFoto.Length > 0)
                {
                    try
                    {

                        // Funções de ajuste da imagem
                        using (MemoryStream ms = new MemoryStream(bytesFoto))
                        {
                            pbxFoto.Image = Image.FromStream(ms);
                            pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao converter imagem: " + ex.Message);
                    }
                }
                else
                {
                    pbxFoto.Image = null;
                }
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

            int idcolaborador = Convert.ToInt32(advogado["id_colaborador"]);
            string nome = tbxNome.Text.Trim();
            string email = tbxEmail.Text.Trim();
            string telefone = tbxTelefone.Text.Trim();
            string oab = tbxOAB.Text.Trim();
            string especialidade = cbxTipoAdvogado.SelectedItem?.ToString() ?? "";
            bool status = cbxAtividade.SelectedItem.ToString() == "Ativo" ? true : false; ;

            // caminho da nova foto (se o usuário selecionou)
            string caminhoFoto = caminho;

            if (MetodoEquipe.AtualizarColaboradorAdvogado(idcolaborador, nome, email, telefone, oab, especialidade, status, caminhoFoto))
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
