using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_Advocacia___Windows_Forms
{
    public static class ConexaoBD 
    {
        private static string conexao = "Server=127.0.0.1;Port=3306;Database=crm_advocacia;Uid=root;Pwd=Leozin.2168;";

        public static MySqlConnection ObterConexao()
        {

            var conn = new MySqlConnection(conexao);
            conn.Open();
            return conn; 

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

    id_cliente int primary key auto_increment,
    nome_razao varchar(200) not null,
    cpf_cnpj varchar(20) unique not null,
    tipo enum('Pessoa Física', 'Pessoa Jurídica') not null default "Pessoa Física",
    telefone varchar(30),
    email varchar(100),
    descricao text,
    contato_em datetime not null default current_timestamp,
    ativo bool default true 

);

create table Endereco (

    id_endereco int primary key auto_increment,
    id_cliente int not null,
    cep varchar(15) not null,
    estado char(2) not null,
    cidade varchar(100) not null,
	bairro varchar(100) not null,
    logradouro varchar(200) not null,
    numero varchar(20) not null,
    tipo enum('Residencial','Comercial','Outro') default 'Residencial',
	complemento varchar(100),
    foreign key (id_cliente) references Cliente(id_cliente)
);

-- ======================
-- PROCESSOS
-- ======================

create table Processo (

    id_processo int primary key auto_increment,
    numero varchar(40) unique,  -- número oficial do processo
    titulo varchar(100) not null,
    id_cliente int not null,
    area_direito enum('Trabalhista','Cível','Criminal','Tributário','Família','Outros') not null,
    descricao text,
    valor decimal(15, 2),
    fase enum('Conhecimento','Execução','Recursal','Arquivado') not null default 'Conhecimento',
    status_processo enum('Ativo','Suspenso','Encerrado') not null default 'Ativo',
    data_inicio datetime not null default current_timestamp,
    foreign key (id_cliente) references Cliente(id_cliente)

);

create table Prazo (

    id_prazo int primary key auto_increment,
    id_processo int not null,
    tipo enum('Audiência','Protocolo','Prazo Recursal','Outro') not null,
    data_prazo date not null,
    cumprido bool default false,
    observacao varchar(200),
    foreign key (id_processo) references Processo(id_processo)

);

create table Documento (

    id_documento int primary key auto_increment,
    id_processo int not null,
    titulo varchar(100) not null,
    caminho_arquivo varchar(255) not null, -- caminho do arquivo no servidor/local
    data_upload datetime default current_timestamp,
    foreign key (id_processo) references Processo(id_processo)

);

create table Honorario (

    id_honorario int primary key auto_increment,
    id_processo int not null,
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

    id_colaborador int primary key auto_increment,
    nome varchar(200) not null,
    telefone varchar(30),
    email varchar(100),
    ativo bool default true,
    foto blob,
    tipo enum('Advogado','Equipe') not null
);

-- Subtabela para ADVOGADOS

create table Advogado (

    id_advogado int primary key auto_increment,
    id_colaborador int not null unique,
    oab varchar(30) unique not null,
    especialidade enum('Trabalhista','Cível','Criminal','Tributário','Família','Outros') not null,
    foreign key (id_colaborador) references Colaborador(id_colaborador)
);

-- Subtabela para EQUIPE administrativa

create table Equipe (
    id_equipe int primary key auto_increment,
    id_colaborador int not null unique,
    cargo enum('Secretário','Estagiário','Financeiro','RH','Outro') not null default 'Outro',
    foreign key (id_colaborador) references Colaborador(id_colaborador)
);

-- ======================
-- RELAÇÃO PROCESSO X COLABORADOR
-- ======================

create table Processo_Colaborador (

    id_processo int not null,
    id_colaborador int not null,
    papel enum('Principal','Assistente','Estagiário','Suporte') default 'Principal',
    primary key (id_processo, id_colaborador),
    foreign key (id_processo) references Processo(id_processo),
    foreign key (id_colaborador) references Colaborador(id_colaborador)

);
 
 */