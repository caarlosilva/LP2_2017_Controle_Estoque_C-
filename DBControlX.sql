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

--FORNECEDORES

INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Gustavo Nunes INFO','15236987458214','1633663366','0','18273725','4002','Praça Professora Magaly Azambuja de Toledo','','Parque Residencial Colina das Estrelas','Tatuí','SP');
	
INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Fabricio Monitores','56910480235479','1634128965','19965821236','12239030','646','Rua Ouvídio Machado da Silva','','Residencial União','São José dos Campos','SP');
	
INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Carlus Magnus','72845698321045','1633661367','16982452762','13574170','256','Rua Coronel Leopoldo Prado','','Vila Prado','São Carlos','SP');
	
INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Lucas C Sharps','56855124789201','1640028922','0','13575702','13','Rua Ângelo Provinciali','','Jardim Bicão','São Carlos','SP');	

--PRODUTO
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Monitor de 144Hz',1500.00,'5',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Formatação PC',49.90,'1',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Curso Avançado de C#',499.90,'20',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Tampa',19.90,'20',3);
