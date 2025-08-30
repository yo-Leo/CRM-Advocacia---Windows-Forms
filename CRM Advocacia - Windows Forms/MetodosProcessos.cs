using MySql.Data.MySqlClient;
using System.Data;
using System.Text;


namespace CRM_Advocacia___Windows_Forms
{

    // Classe reservada para os metodos relacionados a processos e suas ações
    public class MetodosProcessos
    {
        //Adicona processo
        public bool AdicionarProcesso(string numero, string titulo, string descricao, string tipo, string data, string nomecliente, string nomeadv, decimal valor)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                try
                {

                    // 1 - Buscar ID do cliente
                    int idCliente = 0;
                    using (var cmdCliente = new MySqlCommand("SELECT id_cliente FROM Cliente WHERE nome_razao = @nome", conn))
                    {
                        cmdCliente.Parameters.AddWithValue("@nome", nomecliente);
                        var result = cmdCliente.ExecuteScalar();
                        if (result == null)
                            return false; // Cliente não encontrado
                        idCliente = Convert.ToInt32(result);
                    }

                    // 2 - Buscar ID do advogado
                    int idAdvogado = 0;
                    using (var cmdAdv = new MySqlCommand(@"SELECT a.id_colaborador FROM Advogado a INNER JOIN Colaborador c ON a.id_colaborador = c.id_colaborador WHERE c.nome = @nomeAdvogado", conn))
                    {
                        cmdAdv.Parameters.AddWithValue("@nomeAdvogado", nomeadv);
                        var result = cmdAdv.ExecuteScalar();
                        if (result == null)
                            return false; // Advogado não encontrado
                        idAdvogado = Convert.ToInt32(result);
                    }

                    // 3 - Inserir processo
                    string sqlInsert = @"INSERT INTO Processo (numero, titulo, descricao, area_direito, id_cliente, id_advogado, valor, data_inicio) VALUES (@numero, @titulo, @descricao, @area, @idCliente, @idAdvogado, @valor, @data)";

                    using (var cmdInsert = new MySqlCommand(sqlInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@numero", numero);
                        cmdInsert.Parameters.AddWithValue("@titulo", titulo);
                        cmdInsert.Parameters.AddWithValue("@descricao", descricao);
                        cmdInsert.Parameters.AddWithValue("@area", tipo);
                        cmdInsert.Parameters.AddWithValue("@idCliente", idCliente);
                        cmdInsert.Parameters.AddWithValue("@idAdvogado", idAdvogado);
                        cmdInsert.Parameters.AddWithValue("@valor", valor);
                        cmdInsert.Parameters.AddWithValue("@data", DateTime.Parse(data));

                        int linhasAfetadas = cmdInsert.ExecuteNonQuery();

                        return linhasAfetadas > 0; // true se inseriu
                    }
                }
                catch
                {
                    return false; // qualquer erro retorna false
                }
            }
        }

        public static class MetodosProcesso
        {
            public static DataTable BuscarProcessos(string filtroTipo, string pesquisa, string fase, string status)
            {
                DataTable dt = new DataTable();

                using (var conn = ConexaoBD.ObterConexao())
                {

                    string sql = @"SELECT p.id_processo, p.numero, p.titulo, p.descricao, p.area_direito, p.valor, p.fase, p.status_processo, p.data_inicio, c.nome_razao AS cliente, col.nome AS advogado
                                   FROM Processo p INNER JOIN Cliente c ON p.id_cliente = c.id_cliente INNER JOIN Advogado a ON p.id_advogado = a.id_colaborador INNER JOIN Colaborador col ON a.id_colaborador = col.id_colaborador
                                    WHERE 1=1";

                    if (filtroTipo != "Todos")
                        sql += " AND p.area_direito = @tipo ";

                    if (!string.IsNullOrEmpty(pesquisa))
                        sql += " AND (p.numero LIKE @pesquisa OR p.titulo LIKE @pesquisa OR c.nome_razao LIKE @pesquisa) ";

                    if (fase != "Todos")
                        sql += " AND p.fase = @fase ";

                    if (status != "Todos")
                        sql += " AND p.status_processo = @status ";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        if (filtroTipo != "Todos")
                            cmd.Parameters.AddWithValue("@tipo", filtroTipo);

                        if (!string.IsNullOrEmpty(pesquisa))
                            cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                        if (fase != "Todos")
                            cmd.Parameters.AddWithValue("@fase", fase);

                        if (status != "Todos")
                            cmd.Parameters.AddWithValue("@status", status);

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                return dt;
            }
        }

        public static DataRow BuscarProcessoPorId(int idProcesso)
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string query = @"SELECT p.id_processo, p.numero, p.titulo, p.descricao, p.valor, p.area_direito, p.fase, p.status_processo, p.data_inicio, c.id_cliente, c.nome_razao AS cliente_nome, c.cpf_cnpj AS cliente_documento,
                                c.telefone AS cliente_telefone, c.email AS cliente_email, a.id_advogado, col.nome AS advogado_nome, a.oab AS advogado_oab, a.especialidade AS advogado_especialidade
                                FROM Processo p INNER JOIN Cliente c ON c.id_cliente = p.id_cliente INNER JOIN Advogado a ON a.id_colaborador = p.id_advogado INNER JOIN Colaborador col ON col.id_colaborador = a.id_colaborador
                                WHERE p.id_processo = @idProcesso";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idProcesso", idProcesso);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
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
    }
}
