using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{
    public class MetodosBD
    {

        // ================== CLIENTE ==================

        // Método para adicionar um novo cliente ao banco de dados
        public void AdicionarCliente(string nome, string cpfCnpj, string tipo, string telefone, string email, string descricao, string data)
        {

            try
            {

                using (var conn = ConexaoBD.ObterConexao())
                {

                    conn.Open();

                    string sql = @"INSERT INTO Cliente 
                          (nome_razao, cpf_cnpj, tipo, telefone, email, descricao, contato_em) 
                          VALUES (@nome, @cpfCnpj, @tipo, @telefone, @email, @descricao, @data);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpfCnpj", cpfCnpj);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@data", data);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar dados do cliente: " + ex.Message);

            }
        }

        public void AdicionarEndereco(string idcliente, string cep, string estado, string cidade, string bairro, string logradouro, string numero, string tipo = "Residencial", string complemento = "")
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string sql = @"INSERT INTO Endereco 
                           (id_cliente, cep, estado, cidade, bairro, logradouro, numero, tipo, complemento)
                           VALUES (@idCliente, @cep, @estado, @cidade, @bairro, @logradouro, @numero, @tipo, @complemento);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idcliente);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@logradouro", logradouro);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@complemento", complemento);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Endereço cadastrado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar endereço: " + ex.Message);

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
