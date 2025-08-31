using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodoHonorario
    {

        public static DataTable BuscarHonorarios(string pesquisa = "", string filtroStatus = "Todos")
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"SELECT id_honorario, descricao, valor, data_emissao, pago 
                       FROM Honorario
                       WHERE 1=1";

                if (!string.IsNullOrEmpty(pesquisa))
                    sql += " AND descricao LIKE @pesquisa";

                if (!string.IsNullOrEmpty(filtroStatus) && filtroStatus != "Todos")
                {
                    if (filtroStatus == "Pago")
                        sql += " AND pago = true";
                    if (filtroStatus == "Pendente")
                        sql += " AND pago = false";
                }

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(pesquisa))
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }

        public static bool AtualizarHonorarioParaPago(int idHonorario)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string sql = "UPDATE Honorario SET pago = true WHERE id_honorario = @idHonorario";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idHonorario", idHonorario);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar honorário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
