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

        //Adicionar advogado
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
