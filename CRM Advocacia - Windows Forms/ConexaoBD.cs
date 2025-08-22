using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Advocacia___Windows_Forms
{
    public class ConexaoBD
    {
        //bdbdbdbdbbdbdbbdbdbbddadada


    }
}

/*
 
create database crm_advocacia;
use crm_advocacia;

create table Usuario (

    id_usuario bigint primary key auto_increment,
    nome_usuario varchar(100) unique not null,
    senha varchar(255) not null,
    nivel_acesso enum('Baixo','Medio','Alto') not null default 'Baixo',
    ativo bool default true,
    data_criacao datetime not null default current_timestamp,
    foto longblob

);

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
    data_upload datetime default current_timestamp,
    arquivo longblob,  -- arquivo do documento armazenado no banco
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

create table Advogado (

    id_advogado bigint primary key auto_increment,
    nome varchar(200) not null,
    oab varchar(30) unique not null,
    especialidade enum('Trabalhista','Cível','Criminal','Tributário','Família','Outros') not null,
    telefone varchar(30),
    email varchar(100),
    ativo bool default true,
    foto longblob

);

create table Processo_Advogado (

    id_processo bigint not null,
    id_advogado bigint not null,
    papel enum('Principal','Assistente','Estagiário') default 'Principal',
    primary key (id_processo, id_advogado),
    foreign key (id_processo) references Processo(id_processo),
    foreign key (id_advogado) references Advogado(id_advogado)

);

 
 */