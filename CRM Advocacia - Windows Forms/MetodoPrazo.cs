using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodoPrazo
    {

        public bool CriarPrazo(string numeroProcesso, string tipoPrazo, string dataPrazoStr, string observacao)
        {
            using (var conn = ConexaoBD.ObterConexao())
            using (var transaction = conn.BeginTransaction())
            {
                try
                {

                    if (!DateTime.TryParse(dataPrazoStr, out DateTime dataPrazo))
                    {
                        MessageBox.Show("Data inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    int idProcesso = 0;
                    using (var cmdProc = new MySqlCommand(
                        @"SELECT id_processo FROM Processo WHERE numero = @numeroProcesso", conn, transaction))
                    {
                        cmdProc.Parameters.AddWithValue("@numeroProcesso", numeroProcesso);
                        var result = cmdProc.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Processo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        idProcesso = Convert.ToInt32(result);
                    }

                    string sqlInsertPrazo = @"INSERT INTO Prazo (id_processo, tipo, data_prazo, cumprido, observacao) VALUES (@idProcesso, @tipo, @dataPrazo, @cumprido, @observacao);";

                    using (var cmdPrazo = new MySqlCommand(sqlInsertPrazo, conn, transaction))
                    {
                        cmdPrazo.Parameters.AddWithValue("@idProcesso", idProcesso);
                        cmdPrazo.Parameters.AddWithValue("@tipo", tipoPrazo);
                        cmdPrazo.Parameters.AddWithValue("@dataPrazo", dataPrazo.Date);
                        cmdPrazo.Parameters.AddWithValue("@cumprido", false);
                        cmdPrazo.Parameters.AddWithValue("@observacao", observacao ?? string.Empty);

                        cmdPrazo.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao criar prazo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static DataTable BuscarPrazos(string filtroTipo = "", string data = "", string status = "")
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"SELECT p.id_prazo, p.tipo, p.data_prazo, p.cumprido, p.observacao, pr.numero AS processo_numero
                       FROM Prazo p
                       INNER JOIN Processo pr ON p.id_processo = pr.id_processo
                       WHERE 1=1";

                if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Todos")
                    sql += " AND p.tipo = @tipo";

                if (!string.IsNullOrEmpty(data))
                    sql += " AND p.data_prazo = @dataPrazo";

                if (!string.IsNullOrEmpty(status) && status != "Todos")
                {
                    if (status == "Cumprido")
                        sql += " AND p.cumprido = true";
                    if (status == "Pendente")
                        sql += " AND p.cumprido = false";
                }

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Todos")
                        cmd.Parameters.AddWithValue("@tipo", filtroTipo);

                    if (!string.IsNullOrEmpty(data))
                        cmd.Parameters.AddWithValue("@dataPrazo", data);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        return tabela;
                    }
                }
            }
        }

        // Método para marcar prazo como cumprido
        public static bool MarcarPrazoCumprido(int idPrazo)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string sql = "UPDATE Prazo SET cumprido = true WHERE id_prazo = @idPrazo";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPrazo", idPrazo);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar prazo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
