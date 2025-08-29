using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodosCliente
    {
        //Adcionar cliente
        public bool AdicionarClienteComEndereco(
        string nome, string cpfCnpj, string tipo, string telefone, string email, string descricao, string data,
        string cep, string estado, string cidade, string bairro, string logradouro, string numero, string tiporesiden, string compl)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {

                using (var transaction = conn.BeginTransaction())
                {

                    try
                    {

                        int idCliente;

                        string sqlCliente = @"INSERT INTO Cliente 
                        (nome_razao, cpf_cnpj, tipo, telefone, email, descricao, contato_em) 
                        VALUES (@nome, @cpfCnpj, @tipo, @telefone, @email, @descricao, @data);
                        SELECT LAST_INSERT_ID();";

                        using (var cmdCliente = new MySqlCommand(sqlCliente, conn, transaction))
                        {

                            cmdCliente.Parameters.AddWithValue("@nome", nome);
                            cmdCliente.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);
                            cmdCliente.Parameters.AddWithValue("@tipo", tipo);
                            cmdCliente.Parameters.AddWithValue("@telefone", telefone);
                            cmdCliente.Parameters.AddWithValue("@email", email);
                            cmdCliente.Parameters.AddWithValue("@descricao", descricao);
                            cmdCliente.Parameters.AddWithValue("@data", data);

                            idCliente = Convert.ToInt32(cmdCliente.ExecuteScalar());

                        }

                        string sqlEndereco = @"INSERT INTO Endereco 
                    (id_cliente, cep, estado, cidade, bairro, logradouro, numero, tipo, complemento) 
                    VALUES (@idCliente, @cep, @estado, @cidade, @bairro, @logradouro, @numero, @tipo, @complemento);";

                        using (var cmdEndereco = new MySqlCommand(sqlEndereco, conn, transaction))
                        {

                            cmdEndereco.Parameters.AddWithValue("@idCliente", idCliente);
                            cmdEndereco.Parameters.AddWithValue("@cep", cep);
                            cmdEndereco.Parameters.AddWithValue("@estado", estado);
                            cmdEndereco.Parameters.AddWithValue("@cidade", cidade);
                            cmdEndereco.Parameters.AddWithValue("@bairro", bairro);
                            cmdEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                            cmdEndereco.Parameters.AddWithValue("@numero", numero);
                            cmdEndereco.Parameters.AddWithValue("@tipo", tiporesiden);
                            cmdEndereco.Parameters.AddWithValue("@complemento", compl);

                            cmdEndereco.ExecuteNonQuery();

                        }

                        transaction.Commit();
                        return true;

                    }

                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        MessageBox.Show("Erro ao cadastrar cliente e endereço: " + ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
            }
        }

        //Busca o cliente pelo nome
        public static DataTable BuscarClientes(string filtro = "", string pesquisa = "")
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = "SELECT id_cliente, nome_razao, cpf_cnpj, tipo, telefone, email, contato_em FROM Cliente WHERE 1=1";

                if (!string.IsNullOrEmpty(filtro) && filtro != "Todos")
                {

                    sql += " AND tipo = @filtro";

                }

                if (!string.IsNullOrEmpty(pesquisa))
                {

                    sql += " AND nome_razao LIKE @pesquisa";

                }

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(filtro) && filtro != "Todos")
                    {

                        cmd.Parameters.AddWithValue("@filtro", filtro);

                    }

                    if (!string.IsNullOrEmpty(pesquisa)) 
                    {

                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                    }

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {

                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);



                        return tabela;
                    }
                }
            }
        }

        //?????????????
        public static DataTable BuscarClienteId(int idCliente)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"
            SELECT c.id_cliente, c.nome_razao, c.cpf_cnpj, c.telefone, c.email, 
                   c.descricao, c.contato_em,
                   e.cep, e.logradouro, e.numero, e.bairro, e.cidade, e.estado
            FROM Cliente c
            LEFT JOIN Endereco e ON c.id_cliente = e.id_cliente
            WHERE c.id_cliente = @idCliente;
        ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /*
        //PROCESSO 
        public void AdicionarPrazo(string numero, string titulo, int idCliente, string area, string descricao, decimal valor, string fase, string status)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Atualizar Cliente
                        string sqlCliente = @"UPDATE Cliente SET nome_razao = @nome, cpf_cnpj = @cpfCnpj, tipo = @tipo, telefone = @telefone, email = @email, descricao = @descricao, contato_em = @data, ativo = @ativo
                        WHERE id_cliente = @idCliente;";

                        using (var cmdCliente = new MySqlCommand(sqlCliente, conn, transaction))
                        {
                            cmdCliente.Parameters.AddWithValue("@idCliente", idCliente);
                            cmdCliente.Parameters.AddWithValue("@nome", nome);
                            cmdCliente.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);
                            cmdCliente.Parameters.AddWithValue("@tipo", tipo);
                            cmdCliente.Parameters.AddWithValue("@telefone", telefone);
                            cmdCliente.Parameters.AddWithValue("@email", email);
                            cmdCliente.Parameters.AddWithValue("@descricao", descricao);
                            cmdCliente.Parameters.AddWithValue("@data", data);
                            cmdCliente.Parameters.AddWithValue("@ativo", ativo);

                            cmdCliente.ExecuteNonQuery();
                        }

                        // Atualizar Endereço
                        string sqlEndereco = @"UPDATE Endereco SET cep = @cep, estado = @estado, cidade = @cidade, bairro = @bairro, logradouro = @logradouro, numero = @numero, tipo = @tipo, complemento = @complemento
                        WHERE id_cliente = @idCliente;";

                        using (var cmdEndereco = new MySqlCommand(sqlEndereco, conn, transaction))
                        {
                            cmdEndereco.Parameters.AddWithValue("@idCliente", idCliente);
                            cmdEndereco.Parameters.AddWithValue("@cep", cep);
                            cmdEndereco.Parameters.AddWithValue("@estado", estado);
                            cmdEndereco.Parameters.AddWithValue("@cidade", cidade);
                            cmdEndereco.Parameters.AddWithValue("@bairro", bairro);
                            cmdEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                            cmdEndereco.Parameters.AddWithValue("@numero", numero);
                            cmdEndereco.Parameters.AddWithValue("@tipo", tiporesiden);
                            cmdEndereco.Parameters.AddWithValue("@complemento", compl);

                            cmdEndereco.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao atualizar cliente e endereço: " + ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        */

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

        //Atualizando dados cadastrais e inserindo modificações realiazadas no log dinâmico 
        public bool AtualizarClienteComEndereco(int idCliente, string nome, string cpfCnpj, string tipo, string telefone, string email,
        string descricao, string data, string cep, string estado, string cidade, string bairro, string logradouro, string numero, string tiporesiden, string compl)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlClienteSelect = @"SELECT nome_razao, cpf_cnpj, telefone, email, descricao, contato_em 
                                                FROM Cliente WHERE id_cliente = @idCliente";

                        var currentData = new Dictionary<string, string>();

                        using (var cmdSelect = new MySqlCommand(sqlClienteSelect, conn, transaction))
                        {
                            cmdSelect.Parameters.AddWithValue("@idCliente", idCliente);
                            using (var reader = cmdSelect.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentData["nome"] = reader["nome_razao"].ToString();
                                    currentData["cpf"] = reader["cpf_cnpj"].ToString();
                                    currentData["telefone"] = reader["telefone"].ToString();
                                    currentData["email"] = reader["email"].ToString();
                                    currentData["descricao"] = reader["descricao"].ToString();
                                }
                            }
                        }

                        string sqlCliente = @"UPDATE Cliente
                                        SET nome_razao = @nome, cpf_cnpj = @cpfCnpj, tipo = @tipo, telefone = @telefone,
                                        email = @email, descricao = @descricao, contato_em = @data
                                        WHERE id_cliente = @idCliente;";

                        using (var cmdCliente = new MySqlCommand(sqlCliente, conn, transaction))
                        {
                            cmdCliente.Parameters.AddWithValue("@nome", nome);
                            cmdCliente.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);
                            cmdCliente.Parameters.AddWithValue("@tipo", tipo);
                            cmdCliente.Parameters.AddWithValue("@telefone", telefone);
                            cmdCliente.Parameters.AddWithValue("@email", email);
                            cmdCliente.Parameters.AddWithValue("@descricao", descricao);
                            cmdCliente.Parameters.AddWithValue("@data", data);
                            cmdCliente.Parameters.AddWithValue("@idCliente", idCliente);

                            int rowsAffected = cmdCliente.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                throw new Exception("Cliente não encontrado.");
                            }

                            var logMessage = new StringBuilder();

                            if (currentData["nome"] != nome)
                            {
                                logMessage.AppendLine($"Nome alterado para: {nome}");
                            }

                            if (currentData["cpf"] != cpfCnpj)
                            {
                                logMessage.AppendLine($"CPF alterado para: {cpfCnpj}");
                            }

                            if (currentData["telefone"] != telefone)
                            {
                                logMessage.AppendLine($"Telefone alterado para: {telefone}");
                            }

                            if (currentData["email"] != email)
                            {
                                logMessage.AppendLine($"Email alterado para: {email}");
                            }

                            if (currentData["descricao"] != descricao)
                            {
                                logMessage.AppendLine($"Descrição alterada.");
                            }

                            if (logMessage.Length > 0)
                            {
                                RegistrarLog(conn, transaction, "UPDATE", "Cliente", idCliente, logMessage.ToString());
                            }
                        }

                        string sqlEndereco = @"UPDATE Endereco
                                        SET cep = @cep, estado = @estado, cidade = @cidade, bairro = @bairro, logradouro = @logradouro,
                                        numero = @numero, tipo = @tipo, complemento = @complemento
                                        WHERE id_cliente = @idCliente;";

                        using (var cmdEndereco = new MySqlCommand(sqlEndereco, conn, transaction))
                        {
                            cmdEndereco.Parameters.AddWithValue("@idCliente", idCliente);
                            cmdEndereco.Parameters.AddWithValue("@cep", cep);
                            cmdEndereco.Parameters.AddWithValue("@estado", estado);
                            cmdEndereco.Parameters.AddWithValue("@cidade", cidade);
                            cmdEndereco.Parameters.AddWithValue("@bairro", bairro);
                            cmdEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                            cmdEndereco.Parameters.AddWithValue("@numero", numero);
                            cmdEndereco.Parameters.AddWithValue("@tipo", tiporesiden);
                            cmdEndereco.Parameters.AddWithValue("@complemento", compl);

                            int rowsAffectedEndereco = cmdEndereco.ExecuteNonQuery();

                            if (rowsAffectedEndereco == 0)
                            {
                                throw new Exception("Endereço não encontrado para o cliente.");
                            }

                            RegistrarLog(conn, transaction, "UPDATE", "Endereco", idCliente, "Endereço alterado.");
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao atualizar cliente e endereço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void Buscar(string tabela, string coluna, object valor)
        {



        }
    }
}
