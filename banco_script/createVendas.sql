create database vendas;

use vendas;

create table entrada(
    ent_ir int primary key NOT NULL,
    ent_prod_id int not null,
    ent_cli_id int not null,
    ent_status char,-- limitar o uso de caracteres expecificos
    ent_data datetime2,
    ent_valor money,
    ent_desc money,
    ent_formaPag char -- limitar o uso de caracteres expecificos
);

create table produtos(
    prod_id int primary key not null,
    prod_nome nvarchar(255) not null,
    prod_rec_id int not null,
    prod_preco money not null,
    prod_status char not null,
    prod_dt_cad DATETIME2 not null
);

create table receita(
    rec_id int primary key not null,
    rec_item_qtd float not null,
    rec_status CHAR not NULl,
    rec_dt_cad DATETIME2 not null
);

create table apresentacao(
    ape_id int primary key not null,
    ape_nome nvarchar(50) not null,
    ape_sigla char(2) not null
);

create table item(
    ite_id int primary key not null,
    ite_nome nvarchar(255) not null,
    ite_ape_id int not null,
);

create table entrada_mat(
    emat_id int PRIMARY KEY NOT NULL,
    emat_cod_barra int not NULL,
    emat_item_id int not NULL,
    emat_qtd FLOAT Not NULL,
    emat_dt_cad DATETIME2 not null
);