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
    public class MetodosBD
    {
        // ================== CLIENTE ==================
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

                        // 1 - Inserir Cliente
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

                        // 2 - Inserir Endereço
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

        public static DataTable BuscarClientes(string filtro = "", string pesquisa = "")
        {

            using (var conn = ConexaoBD.ObterConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM Cliente";
                if (!string.IsNullOrEmpty(filtro) && !string.IsNullOrEmpty(pesquisa))
                {

                    sql += $" WHERE {filtro} LIKE @pesquisa";

                }
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(filtro) && !string.IsNullOrEmpty(pesquisa))
                    {
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                    }
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }

        }

        // ================== PROCESSO ==================
        public void AdicionarPrazo(string numero, string titulo, int idCliente, string area, string descricao, decimal valor, string fase, string status)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    conn.Open();

                    string sql = @"INSERT INTO Processo 
                                  (numero, titulo, id_cliente, area_direito, descricao, valor, fase, status_processo)
                                  VALUES (@numero, @titulo, @idCliente, @area, @descricao, @valor, @fase, @status);";

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

        // ================== OUTROS MÉTODOS ==================
        public void Remover(string tabela, string coluna, object valor)
        {



        }

        public void Atualizar(string tabela, string colunaAlvo, object novoValor, string colunaFiltro, object valorFiltro)
        {



        }

        public void Buscar(string tabela, string coluna, object valor)
        {



        }

    }
}
