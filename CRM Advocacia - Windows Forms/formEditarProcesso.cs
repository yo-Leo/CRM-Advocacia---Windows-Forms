using MySql.Data.MySqlClient;
using System.Data;
using System.Text;


namespace CRM_Advocacia___Windows_Forms
{
    public partial class formEditarProcesso : Form
    {

        private DataRow processo;

        public formEditarProcesso(DataRow processo)
        {

            InitializeComponent();
            this.processo = processo;
            CarregarDados();

        }

        private void CarregarDados()
        {

            if (processo == null) return;

            cbxFaseAtual.SelectedItem = processo["fase"].ToString();
            cbxStatusAtual.SelectedItem = processo["status_processo"].ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            if (cbxFaseAtual.SelectedItem == null || cbxStatusAtual.SelectedItem == null)
            {
                MessageBox.Show("Selecione a fase e o status do processo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string novaFase = cbxFaseAtual.SelectedItem.ToString();
            string novoStatus = cbxStatusAtual.SelectedItem.ToString();
            int idProcesso = Convert.ToInt32(processo["id_processo"]);

            if (MetodoProcesso.AtualizarProcesso(idProcesso, novaFase, novoStatus))
            {
                MessageBox.Show("Processo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
