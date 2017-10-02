create database controlx;
use controlx;

CREATE TABLE fornecedor (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(64) DEFAULT NULL,
  cnpj varchar(15) DEFAULT NULL, 
  tel1 varchar(11) DEFAULT NULL,	
  tel2 varchar(11) DEFAULT NULL,
  cep varchar(10) DEFAULT NULL,
  num int(6) DEFAULT NULL,
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
  PRIMARY KEY (id),
  FOREIGN KEY (idFornecedor) REFERENCES fornecedor (id)
 );
