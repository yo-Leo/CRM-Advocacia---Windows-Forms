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

    }
}
