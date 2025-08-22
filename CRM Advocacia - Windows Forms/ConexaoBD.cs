using MySql.Data.MySqlClient;

namespace CRM_Advocacia___Windows_Forms
{
    public class ConexaoBD
    {


                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
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

        //Adicionando prazo
        public void AdicionarPrazo(string numero, string titulo, int idCliente, string area, string descricao, decimal valor, string fase, string status)
        {
            try
            {
                using (var conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql = @"INSERT INTO Processo (numero, titulo, id_cliente, area_direito, descricao, valor, fase, status_processo)
                         VALUES (@numero, @titulo, @idCliente, @area, @descricao, @valor, @fase, @status); SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        conn.Open();
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

        public void remover()
        {
          
        }

        public void atualizar()
        {

        }

        public void buscar()
        {

        }
    }
}



/*
 
create database crm_advocacia;
use crm_advocacia;

-- ======================
-- CLIENTES
-- ======================

create table Cliente (

    id_cliente bigint primary key auto_increment,
    nome_razao varchar(200) not null,
    cpf_cnpj varchar(20) unique not null,
    tipo enum('Pessoa Física', 'Pessoa Jurídica') not null,
    telefone varchar(30),
    email varchar(100),
    descricao text,
    contato_em datetime not null default current_timestamp

);

create table Endereco (

    id_endereco bigint primary key auto_increment,
    id_cliente bigint not null,
    logradouro varchar(200) not null,
    numero varchar(20),
    complemento varchar(100),
    bairro varchar(100),
    cidade varchar(100) not null,
    estado char(2) not null,
    cep varchar(15),
    tipo enum('Residencial','Comercial','Outro') default 'Residencial',
    foreign key (id_cliente) references Cliente(id_cliente)
);

-- ======================
-- PROCESSOS
-- ======================

create table Processo (

    id_processo bigint primary key auto_increment,
    numero varchar(40) unique,  -- número oficial do processo
    titulo varchar(100) not null,
    id_cliente bigint not null,
    area_direito enum('Trabalhista','Cível','Criminal','Tributário','Família','Outros') not null,
    descricao text,
    valor decimal(15, 2),
    fase enum('Conhecimento','Execução','Recursal','Arquivado') not null default 'Conhecimento',
    status_processo enum('Ativo','Suspenso','Encerrado') not null default 'Ativo',
    data_inicio datetime not null default current_timestamp,
    foreign key (id_cliente) references Cliente(id_cliente)

);

create table Prazo (

    id_prazo bigint primary key auto_increment,
    id_processo bigint not null,
    tipo enum('Audiência','Protocolo','Prazo Recursal','Outro') not null,
    data_prazo date not null,
    cumprido bool default false,
    observacao varchar(200),
    foreign key (id_processo) references Processo(id_processo)

);

create table Documento (

    id_documento bigint primary key auto_increment,
    id_processo bigint not null,
    titulo varchar(100) not null,
    caminho_arquivo varchar(255) not null, -- caminho do arquivo no servidor/local
    data_upload datetime default current_timestamp,
    foreign key (id_processo) references Processo(id_processo)

);

create table Honorario (

    id_honorario bigint primary key auto_increment,
    id_processo bigint not null,
    descricao varchar(200),
    valor decimal(10,2) not null,
    data_emissao date not null,
    pago bool default false,
    foreign key (id_processo) references Processo(id_processo)

);

-- ======================
-- COLABORADORES (Advogados + Equipe)
-- ======================

create table Colaborador (

    id_colaborador bigint primary key auto_increment,
    nome varchar(200) not null,
    telefone varchar(30),
    email varchar(100),
    ativo bool default true,
    foto longblob,
    tipo enum('Advogado','Equipe') not null
);

-- Subtabela para ADVOGADOS

create table Advogado (

    id_advogado bigint primary key auto_increment,
    id_colaborador bigint not null unique,
    oab varchar(30) unique not null,
    especialidade enum('Trabalhista','Cível','Criminal','Tributário','Família','Outros') not null,
    foreign key (id_colaborador) references Colaborador(id_colaborador)
);

-- Subtabela para Equipe administrativa

create table Equipe (

    id_equipe bigint primary key auto_increment,
    id_colaborador bigint not null unique,
    cargo enum('Secretário','Estagiário','Financeiro','RH','Outro') not null default 'Outro',
    foreign key (id_colaborador) references Colaborador(id_colaborador)

);

-- ======================
-- RELAÇÃO PROCESSO X COLABORADOR
-- ======================

create table Processo_Colaborador (

    id_processo bigint not null,
    id_colaborador bigint not null,
    papel enum('Principal','Assistente','Estagiário','Suporte') default 'Principal',
    primary key (id_processo, id_colaborador),
    foreign key (id_processo) references Processo(id_processo),
    foreign key (id_colaborador) references Colaborador(id_colaborador)

);
 
 */