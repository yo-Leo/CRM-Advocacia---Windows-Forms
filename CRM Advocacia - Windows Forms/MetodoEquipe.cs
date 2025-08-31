using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodoEquipe
    {

        public bool AdicionarColaboradorAdvog(string nome, string email, string telefone, string tipo, string oab, string especialidade, string caminho)
        {

            using (var conn = ConexaoBD.ObterConexao())
            {

                using (var transaction = conn.BeginTransaction())
                {

                    try
                    {

                        int idcolaborador;

                        string sqlColaborador = "INSERT INTO Colaborador (nome, email, telefone, tipo, foto) VALUES (@nome, @email, @telefone, @tipo, @foto); SELECT LAST_INSERT_ID();";

                        using (var cmdColaborador = new MySqlCommand(sqlColaborador, conn, transaction))
                        {
                            cmdColaborador.Parameters.AddWithValue("@nome", nome);
                            cmdColaborador.Parameters.AddWithValue("@email", email);
                            cmdColaborador.Parameters.AddWithValue("@telefone", telefone);
                            cmdColaborador.Parameters.AddWithValue("@tipo", tipo);
                            cmdColaborador.Parameters.AddWithValue("@foto", caminho);

                            idcolaborador = Convert.ToInt32(cmdColaborador.ExecuteScalar());

                        }

                        string sqlAdvogado = "INSERT INTO Advogado (id_colaborador, oab, especialidade) VALUES (@idcolaborador, @oab, @especialidade); SELECT LAST_INSERT_ID();";

                        using (var cmdAdvogado = new MySqlCommand(sqlAdvogado, conn, transaction))
                        {

                            cmdAdvogado.Parameters.AddWithValue("@idcolaborador", idcolaborador);
                            cmdAdvogado.Parameters.AddWithValue("@oab", oab);
                            cmdAdvogado.Parameters.AddWithValue("@especialidade", especialidade);

                            cmdAdvogado.ExecuteNonQuery();

                        }

                        transaction.Commit();
                        return true;

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao adicionar advogado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
            }
        }

        public bool AdicionarColaboradorEquipe(string nome, string email, string telefone, string tipo, string cargo, string caminho)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int idcolaborador;

                        // Primeiro insere no Colaborador
                        string sqlColaborador = @"INSERT INTO Colaborador (nome, email, telefone, tipo, foto) VALUES (@nome, @email, @telefone, @tipo, @foto); SELECT LAST_INSERT_ID();";

                        using (var cmdColaborador = new MySqlCommand(sqlColaborador, conn, transaction))
                        {
                            cmdColaborador.Parameters.AddWithValue("@nome", nome);
                            cmdColaborador.Parameters.AddWithValue("@email", email);
                            cmdColaborador.Parameters.AddWithValue("@telefone", telefone);
                            cmdColaborador.Parameters.AddWithValue("@tipo", tipo);
                            cmdColaborador.Parameters.AddWithValue("@foto", caminho);

                            idcolaborador = Convert.ToInt32(cmdColaborador.ExecuteScalar());
                        }

                        string sqlEquipe = @"INSERT INTO Equipe (id_colaborador, cargo) VALUES (@idcolaborador, @cargo);";

                        using (var cmdEquipe = new MySqlCommand(sqlEquipe, conn, transaction))
                        {
                            cmdEquipe.Parameters.AddWithValue("@idcolaborador", idcolaborador);
                            cmdEquipe.Parameters.AddWithValue("@cargo", cargo);

                            cmdEquipe.ExecuteNonQuery();
                        }

                        // Confirma transação
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // desfaz se der erro
                        MessageBox.Show("Erro ao adicionar membro da equipe: " + ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public static DataTable BuscarEquipe(string filtroTipo = "", string pesquisa = "", string atividade = "")
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                // Seleciona colaboradores com JOIN nas tabelas específicas
                string sql = @"SELECT c.id_colaborador, c.nome, c.telefone, c.email, c.tipo, c.ativo, a.especialidade, e.cargo FROM Colaborador c LEFT JOIN Advogado a ON c.id_colaborador = a.id_colaborador LEFT JOIN Equipe e ON c.id_colaborador = e.id_colaborador WHERE 1=1";

                if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Todos")
                    sql += " AND c.tipo = @filtroTipo";

                if (!string.IsNullOrEmpty(atividade) && atividade != "Todos")
                    sql += " AND c.ativo = @ativo";

                if (!string.IsNullOrEmpty(pesquisa))
                    sql += " AND c.nome LIKE @pesquisa";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(filtroTipo) && filtroTipo != "Todos")
                        cmd.Parameters.AddWithValue("@filtroTipo", filtroTipo);

                    if (!string.IsNullOrEmpty(atividade) && atividade != "Todos")
                    {
                        bool ativoBool = atividade.Equals("Ativo", StringComparison.OrdinalIgnoreCase);
                        cmd.Parameters.AddWithValue("@ativo", ativoBool);
                    }

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

        public static DataRow BuscarColaboradorPorId(int idColaborador)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"
            SELECT c.id_colaborador, c.nome, c.telefone, c.email, c.ativo, c.foto, c.tipo,
                   a.oab, a.especialidade,
                   e.cargo
            FROM Colaborador c
            LEFT JOIN Advogado a ON c.id_colaborador = a.id_colaborador
            LEFT JOIN Equipe e ON c.id_colaborador = e.id_colaborador
            WHERE c.id_colaborador = @idColaborador
        ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idColaborador", idColaborador);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        else
                            return null;
                    }
                }
            }
        }


        //Atualiza os dados dos advogados
        public bool AtualizarAdvogado(int idAdvogado, string nome, string oab, string telefone, string email,
        string descricao, bool ativo)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlSelect = @"SELECT nome, oab, telefone, email, descricao, ativo 
                                     FROM Advogado WHERE id_advogado = @idAdvogado";

                        var currentData = new Dictionary<string, string>();

                        using (var cmdSelect = new MySqlCommand(sqlSelect, conn, transaction))
                        {
                            cmdSelect.Parameters.AddWithValue("@idAdvogado", idAdvogado);
                            using (var reader = cmdSelect.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentData["nome"] = reader["nome"].ToString();
                                    currentData["oab"] = reader["oab"].ToString();
                                    currentData["telefone"] = reader["telefone"].ToString();
                                    currentData["email"] = reader["email"].ToString();
                                    currentData["descricao"] = reader["descricao"].ToString();
                                    currentData["ativo"] = reader["ativo"].ToString();
                                }
                                else
                                {
                                    throw new Exception("Advogado não encontrado.");
                                }
                            }
                        }

                        string sqlUpdate = @"UPDATE Advogado
                                     SET nome = @nome, oab = @oab, telefone = @telefone,
                                         email = @email, descricao = @descricao, ativo = @ativo
                                     WHERE id_advogado = @idAdvogado;";

                        using (var cmdUpdate = new MySqlCommand(sqlUpdate, conn, transaction))
                        {
                            cmdUpdate.Parameters.AddWithValue("@nome", nome);
                            cmdUpdate.Parameters.AddWithValue("@oab", oab);
                            cmdUpdate.Parameters.AddWithValue("@telefone", telefone);
                            cmdUpdate.Parameters.AddWithValue("@email", email);
                            cmdUpdate.Parameters.AddWithValue("@descricao", descricao);
                            cmdUpdate.Parameters.AddWithValue("@ativo", ativo);
                            cmdUpdate.Parameters.AddWithValue("@idAdvogado", idAdvogado);

                            int rowsAffected = cmdUpdate.ExecuteNonQuery();

                            if (rowsAffected == 0)
                                throw new Exception("Nenhum dado foi atualizado no advogado.");
                        }

                        var logMessage = new StringBuilder();

                        if (currentData["nome"] != nome)
                            logMessage.AppendLine($"Nome alterado para: {nome}");

                        if (currentData["oab"] != oab)
                            logMessage.AppendLine($"OAB alterada para: {oab}");

                        if (currentData["telefone"] != telefone)
                            logMessage.AppendLine($"Telefone alterado para: {telefone}");

                        if (currentData["email"] != email)
                            logMessage.AppendLine($"Email alterado para: {email}");

                        if (currentData["descricao"] != descricao)
                            logMessage.AppendLine("Descrição alterada.");

                        if (currentData["ativo"] != ativo.ToString())
                            logMessage.AppendLine($"Status alterado para: {(ativo ? "Ativo" : "Inativo")}");

                        if (logMessage.Length > 0)
                            RegistrarLog(conn, transaction, "UPDATE", "Advogado", idAdvogado, logMessage.ToString());

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao atualizar advogado: " + ex.Message,
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public void RegistrarLog(MySqlConnection conn, MySqlTransaction transaction, string operacao, string tabelaAfetada, int idRegistro, string descricao)
        {
            string sqlLog = @"INSERT INTO LogOperacoes 
            (operacao, tabela_afetada, id_registro, descricao)
            VALUES (@operacao, @tabelaAfetada, @idRegistro, @descricao);";

            using (var cmdLog = new MySqlCommand(sqlLog, conn, transaction))
            {

                cmdLog.Parameters.AddWithValue("@operacao", operacao);
                cmdLog.Parameters.AddWithValue("@tabelaAfetada", tabelaAfetada);
                cmdLog.Parameters.AddWithValue("@idRegistro", idRegistro);
                cmdLog.Parameters.AddWithValue("@descricao", descricao);

                cmdLog.ExecuteNonQuery();


            }
        }
    }
}
