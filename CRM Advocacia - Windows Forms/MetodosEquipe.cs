using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodosEquipe
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

    }
}
