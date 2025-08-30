using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{

    // Classe reservada para os metodos relacionados a processos e suas ações
    public class MetodosProcessos
    {

        //Adiciona advogado
        public bool AdicionarAdvogado(string nome, string telefone, string email, string oab, string especialidade)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                try
                {
                    string sql = @"INSERT INTO Advogado 
                    (nome, telefone, email, oab, especialidade) 
                    VALUES (@nome, @telefone, @email, @oab, @especialidade);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@oab", oab);
                        cmd.Parameters.AddWithValue("@especialidade", especialidade);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar advogado: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
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

        //Adcionando registro no log
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



        // Metodo para adicionar um novo prazo ao banco de dados
        public void AdicionarPrazo(string numero, string titulo, int idCliente, string area, string descricao, decimal valor, string fase, string status)
        {

            try
            {

                using (var conn = ConexaoBD.ObterConexao())
                {

                    conn.Open();

                    string sql = @"INSERT INTO Processo (numero, titulo, id_cliente, area_direito, descricao, valor, fase, status_processo) VALUES (@numero, @titulo, @idCliente, @area, @descricao, @valor, @fase, @status);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.Parameters.AddWithValue("@area", area);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@valor", valor);
                        cmd.Parameters.AddWithValue("@fase", fase);
                        cmd.Parameters.AddWithValue("@status", status);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Processo criado com sucesso!");

                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao criar processo: " + ex.Message);

            }
        }

        //Adicionando o prazo
        public bool AdicionarPrazo(int idProcesso, string tipo, DateTime dataPrazo, string observacao)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                try
                {
                    string sql = @"INSERT INTO Prazo 
                    (id_processo, tipo, data_prazo, observacao) 
                    VALUES (@idProcesso, @tipo, @dataPrazo, @observacao);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idProcesso", idProcesso);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@dataPrazo", dataPrazo);
                        cmd.Parameters.AddWithValue("@observacao", observacao ?? "");

                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar prazo: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        //Listar documentos 
        public void ListarDocumentos(int idProcesso, DataGridView grid)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = "SELECT id_documento, titulo, caminho_arquivo, data_upload FROM Documento WHERE id_processo = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idProcesso);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new System.Data.DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
        }

    }
}
