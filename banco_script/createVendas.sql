create database vendas;

use vendas;

create table entrada(
    ent_ir int primary key NOT NULL,
    ent_prod_id int not null,
    ent_cli_id int not null,
    ent_status char not NULl,-- limitar o uso de caracteres expecificos
    ent_dt_cad datetime2 not null,
    ent_valor money not null,
    ent_desc money not null,
    ent_formaPag char not NULL -- limitar o uso de caracteres expecificos
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
    ite_clas_id int not null
);

create table entrada_mat(
    emat_id int PRIMARY KEY NOT NULL,
    emat_cod_barra int not NULL,
    emat_item_id int not NULL,
    emat_qtd FLOAT Not NULL,
    emat_dt_cad DATETIME2 not null,
    emat_nf_serie int,
    emat_nf_num int,
);

create table estoque(
    est_emat_id INT PRIMARY key,
    est_ite_id int PRIMARY KEY NOT NULL,
    est_tipo CHAR NOT NULL,
    est_dt_cad DATETIME2 not null,
    est_qtd FLOAT NOT null
)

CREATE TABLE nf(
    nf_serie int primary key not null,
    nf_num int PRIMARY key not null,
    nf_url_xml NVARCHAR(255),--ver a quantidade de caracteres
    nf_dt_ent DATETIME2 NOT NULL,
    nf_dt_cad DATETIME2 NOT NULL,
    nf_tipo char  not null
)

create table saida(
    sai_id int PRIMARY key not null,
    sai_nf_serie int PRIMARY KEY not null,
    sai_nf_num int PRIMARY KEY not null,
    sai_valor money not NULL,
    sai_formaPag char not NULL,
    sai_status char not NULL,
    sai_dt_cad DATETIME2 NOT NULL
)