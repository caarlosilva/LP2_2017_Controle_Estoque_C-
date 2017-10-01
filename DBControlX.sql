--create database controlx;
--use controlx;

CREATE TABLE fornecedor (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(64) DEFAULT NULL,
  cnpj bigint(15) DEFAULT NULL, --É 100X MELHOR FAZERMOS ESSAS PORRA COM BIGINT COM VARCHAR
  tel1 bigint(20) DEFAULT NULL,	
  tel2 bigint(20) DEFAULT NULL,
  cep bigint(10) DEFAULT NULL,
  num bigint(20) DEFAULT NULL,
  rua varchar(64) DEFAULT NULL,
  comp varchar(32) DEFAULT NULL,
  bairro varchar(64) DEFAULT NULL,
  cidade varchar(64) DEFAULT NULL,
  estado varchar(64) DEFAULT NULL,
  PRIMARY KEY (id)
);


CREATE TABLE produtos (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(64) DEFAULT NULL,
  preco double DEFAULT NULL,
  qntd int DEFAULT NULL,
 idFornecedor int,
  PRIMARY KEY (id)
, FOREIGN KEY (idFornecedor) REFERENCES fornecedor (id)
 );
