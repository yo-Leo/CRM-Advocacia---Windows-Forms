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

                        string sqlColaborador = @"INSERT INTO Colaborador (nome, email, telefone, tipo, foto) 
                                          VALUES (@nome, @email, @telefone, @tipo, @foto); 
                                          SELECT LAST_INSERT_ID();";

                        using (var cmdColaborador = new MySqlCommand(sqlColaborador, conn, transaction))
                        {
                            cmdColaborador.Parameters.AddWithValue("@nome", nome);
                            cmdColaborador.Parameters.AddWithValue("@email", email);
                            cmdColaborador.Parameters.AddWithValue("@telefone", telefone);
                            cmdColaborador.Parameters.AddWithValue("@tipo", tipo);

                            // Aqui ocorre a conversão da imagem para byte, isso corrige o erro da imagem não ser exibida no forms
                            byte[] bytesFoto = File.ReadAllBytes(caminho);
                            cmdColaborador.Parameters.Add("@foto", MySqlDbType.Blob).Value = bytesFoto;

                            idcolaborador = Convert.ToInt32(cmdColaborador.ExecuteScalar());
                        }

                        string sqlAdvogado = @"INSERT INTO Advogado (id_colaborador, oab, especialidade) 
                                       VALUES (@idcolaborador, @oab, @especialidade);";

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

                        string sqlColaborador = @"INSERT INTO Colaborador (nome, email, telefone, tipo, foto) 
                                          VALUES (@nome, @email, @telefone, @tipo, @foto); 
                                          SELECT LAST_INSERT_ID();";

                        using (var cmdColaborador = new MySqlCommand(sqlColaborador, conn, transaction))
                        {
                            cmdColaborador.Parameters.AddWithValue("@nome", nome);
                            cmdColaborador.Parameters.AddWithValue("@email", email);
                            cmdColaborador.Parameters.AddWithValue("@telefone", telefone);
                            cmdColaborador.Parameters.AddWithValue("@tipo", tipo);

                            // Aqui ocorre a conversão da imagem para byte, isso corrige o erro da imagem não ser exibida no forms
                            byte[] bytesFoto = File.ReadAllBytes(caminho);
                            cmdColaborador.Parameters.Add("@foto", MySqlDbType.Blob).Value = bytesFoto;

                            idcolaborador = Convert.ToInt32(cmdColaborador.ExecuteScalar());
                        }

                        string sqlEquipe = @"INSERT INTO Equipe (id_colaborador, cargo) 
                                     VALUES (@idcolaborador, @cargo);";

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
                string sql = @"SELECT c.id_colaborador, c.nome, c.telefone, c.email, c.ativo, c.foto, c.tipo, a.oab, a.especialidade, e.cargo
                              FROM Colaborador c LEFT JOIN Advogado a ON c.id_colaborador = a.id_colaborador LEFT JOIN Equipe e ON c.id_colaborador = e.id_colaborador
                              WHERE c.id_colaborador = @idColaborador";

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
        public static bool AtualizarColaboradorAdvogado(int idColaborador, string nome, string email, string telefone, string oab, string especialidade, bool stauts, string caminho)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Atualiza Colaborador
                        string sqlColaborador = @"UPDATE Colaborador 
                                          SET nome = @nome, email = @email, telefone = @telefone, foto = @foto, ativo = @ativo
                                          WHERE id_colaborador = @idColaborador;";

                        using (var cmdColaborador = new MySqlCommand(sqlColaborador, conn, transaction))
                        {
                            cmdColaborador.Parameters.AddWithValue("@nome", nome);
                            cmdColaborador.Parameters.AddWithValue("@email", email);
                            cmdColaborador.Parameters.AddWithValue("@telefone", telefone);
                            cmdColaborador.Parameters.AddWithValue("@idColaborador", idColaborador);
                            cmdColaborador.Parameters.AddWithValue("@ativo", stauts);

                            // Se caminho foi fornecido, carrega a nova imagem
                            if (!string.IsNullOrEmpty(caminho))
                            {
                                byte[] bytesFoto = File.ReadAllBytes(caminho);
                                cmdColaborador.Parameters.Add("@foto", MySqlDbType.Blob).Value = bytesFoto;
                            }
                            else
                            {
                                // mantém a foto anterior
                                cmdColaborador.Parameters.Add("@foto", MySqlDbType.Blob).Value = DBNull.Value;
                            }

                            cmdColaborador.ExecuteNonQuery();
                        }

                        // Atualiza Advogado
                        string sqlAdvogado = @"UPDATE Advogado 
                                       SET oab = @oab, especialidade = @especialidade 
                                       WHERE id_colaborador = @idColaborador;";

                        using (var cmdAdvogado = new MySqlCommand(sqlAdvogado, conn, transaction))
                        {
                            cmdAdvogado.Parameters.AddWithValue("@idColaborador", idColaborador);
                            cmdAdvogado.Parameters.AddWithValue("@oab", oab);
                            cmdAdvogado.Parameters.AddWithValue("@especialidade", especialidade);

                            cmdAdvogado.ExecuteNonQuery();
                        }

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

        public static bool AtualizarColaboradorEquipe(int idColaborador, string nome, string email, string telefone, string especialidade, bool stauts, string caminho)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Atualiza Colaborador
                        string sqlColaborador = @"UPDATE Colaborador 
                                          SET nome = @nome, email = @email, telefone = @telefone, foto = @foto, ativo = @ativo
                                          WHERE id_colaborador = @idColaborador;";

                        using (var cmdColaborador = new MySqlCommand(sqlColaborador, conn, transaction))
                        {
                            cmdColaborador.Parameters.AddWithValue("@nome", nome);
                            cmdColaborador.Parameters.AddWithValue("@email", email);
                            cmdColaborador.Parameters.AddWithValue("@telefone", telefone);
                            cmdColaborador.Parameters.AddWithValue("@idColaborador", idColaborador);
                            cmdColaborador.Parameters.AddWithValue("@ativo", stauts);

                            // Se caminho foi fornecido, carrega a nova imagem
                            if (!string.IsNullOrEmpty(caminho))
                            {
                                byte[] bytesFoto = File.ReadAllBytes(caminho);
                                cmdColaborador.Parameters.Add("@foto", MySqlDbType.Blob).Value = bytesFoto;
                            }
                            else
                            {
                                // mantém a foto anterior
                                cmdColaborador.Parameters.Add("@foto", MySqlDbType.Blob).Value = DBNull.Value;
                            }

                            cmdColaborador.ExecuteNonQuery();
                        }

                        // Atualiza Advogado
                        string sqlAdvogado = @"UPDATE Equipe 
                                       SET cargo = @especialidade 
                                       WHERE id_colaborador = @idColaborador;";

                        using (var cmdAdvogado = new MySqlCommand(sqlAdvogado, conn, transaction))
                        {
                            cmdAdvogado.Parameters.AddWithValue("@idColaborador", idColaborador);
                            cmdAdvogado.Parameters.AddWithValue("@especialidade", especialidade);

                            cmdAdvogado.ExecuteNonQuery();
                        }

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
