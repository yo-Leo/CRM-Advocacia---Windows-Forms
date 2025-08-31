using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CRM_Advocacia___Windows_Forms
{
    public partial class formDocumentos : Form
    {

        private DataRow processo;

        public formDocumentos(DataRow processo)
        {
            InitializeComponent();
            this.processo = processo;
            CarregarDoc();
        }

        public void CarregarDoc()
        {
            using (var conn = ConexaoBD.ObterConexao())
            {

                string sql = @"SELECT d.id_documento, d.titulo, d.data_upload, p.titulo AS processo
                       FROM Documento d
                       INNER JOIN Processo p ON d.id_processo = p.id_processo";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDocumentos.DataSource = dt;

                dgvDocumentos.Columns["id_documento"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Arquivos PDF|*.pdf";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string caminho = abrir.FileName;
                string nomeArquivo = Path.GetFileNameWithoutExtension(caminho);
                byte[] bytesArquivo = File.ReadAllBytes(caminho);

                int idProcesso = 1;

                using (var conn = ConexaoBD.ObterConexao())
                {

                    string sql = "INSERT INTO Documento (id_processo, titulo, arquivo) VALUES (@id_processo, @titulo, @arquivo)";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_processo", idProcesso);
                    cmd.Parameters.AddWithValue("@titulo", nomeArquivo);
                    cmd.Parameters.AddWithValue("@arquivo", bytesArquivo);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("PDF armazenado no banco com sucesso!");
            }

            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"SELECT d.id_documento, d.titulo, d.data_upload, p.titulo AS processo
                       FROM Documento d
                       INNER JOIN Processo p ON d.id_processo = p.id_processo";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDocumentos.DataSource = dt;

                dgvDocumentos.Columns["id_documento"].Visible = false;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um documento para abrir.");
                return;
            }

            int idDoc = Convert.ToInt32(dgvDocumentos.SelectedRows[0].Cells["id_documento"].Value);

            using (var conn = ConexaoBD.ObterConexao())
            {

                string sql = "SELECT titulo, arquivo FROM Documento WHERE id_documento=@id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idDoc);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string titulo = dr["titulo"].ToString();
                        byte[] bytesArquivo = (byte[])dr["arquivo"];

                        string caminhoTemp = Path.Combine(Path.GetTempPath(), titulo + ".pdf");
                        File.WriteAllBytes(caminhoTemp, bytesArquivo);

                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = caminhoTemp,
                            UseShellExecute = true
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                }
            }
        }
    }
}
