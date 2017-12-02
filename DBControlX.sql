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
  deleted_at date DEFAULT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE categoria (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(64),
  deleted_at date,
  PRIMARY KEY (id)
 );

CREATE TABLE produtos (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(64) DEFAULT NULL,
  preco double DEFAULT NULL,
  qntd double DEFAULT NULL,
  tipoUn varchar(5),
  estoqueMin double DEFAULT 20,
  idFornecedor int,
  idCategoria int,
  deleted_at date DEFAULT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (idFornecedor) REFERENCES fornecedor (id),
  FOREIGN KEY (idCategoria) REFERENCES categoria (id)
 );

 CREATE TABLE usuario (
	id int NOT NULL AUTO_INCREMENT,
	nome varchar(64),
	cpf varchar(11),
	sexo varchar(1),
	dataNasc date,
	tel1 varchar(11),
	tel2 varchar(11),
	cep varchar(10),
	num int(6),
	rua varchar(64),
	comp varchar(32),
	bairro varchar(64),
	cidade varchar(64),
	estado varchar(64),
	cargo varchar(32),
	login varchar(32),
	senha varchar(32),
	deleted_at date DEFAULT NULL,
	PRIMARY KEY (id)	
 );

 CREATE TABLE compras (
	id int NOT NULL AUTO_INCREMENT,
	nome_usuario varchar(64),
	valor double,
	status int,
	dataCompra datetime,
	dataEntrega datetime,
	dataFinal datetime DEFAULT NULL,
	PRIMARY KEY (id)
);
 
 
 CREATE TABLE produtos_compra(
 	idCompra int NOT NULL,
	idProduto int NOT NULL,
	qtdProduto double,
	precoUnProduto double,
	PRIMARY KEY(idCompra,idProduto),
	FOREIGN KEY (idCompra) REFERENCES compras (id),
	FOREIGN KEY (idProduto) REFERENCES produtos (id)
);

 CREATE TABLE vendas (
	id int NOT NULL AUTO_INCREMENT,
	nome_usuario varchar(64),
	valor double,
	dataVenda datetime,
	PRIMARY KEY (id)
);
 
 
 CREATE TABLE produtos_venda(
 	idVenda int NOT NULL,
	idProduto int NOT NULL,
	qtdProduto double DEFAULT 0,
	precoUnProduto double,
	PRIMARY KEY(idVenda,idProduto),
	FOREIGN KEY (idVenda) REFERENCES vendas (id),
	FOREIGN KEY (idProduto) REFERENCES produtos (id)
);

INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Gustavo Nunes INFO','15236987458214','1633663366','0','18273725','4002','Praça Professora Magaly Azambuja de Toledo','','Parque Residencial Colina das Estrelas','Tatuí','SP');
	
INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Fabricio Monitores','56910480235479','1634128965','19965821236','12239030','646','Rua Ouvídio Machado da Silva','','Residencial União','São José dos Campos','SP');
	
INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Carlus Magnus','72845698321045','1633661367','16982452762','13574170','256','Rua Coronel Leopoldo Prado','','Vila Prado','São Carlos','SP');
	
INSERT INTO fornecedor(nome, cnpj, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado) 
	values ('Lucas C Sharps','56855124789201','1640028922','0','13575702','13','Rua Ângelo Provinciali','','Jardim Bicão','São Carlos','SP');	


INSERT INTO categoria(nome) values ('Tubulações');
INSERT INTO categoria(nome) values ('Aviões');
INSERT INTO categoria(nome) values ('Carros');
INSERT INTO categoria(nome) values ('Ronaldo');
INSERT INTO categoria(nome) values ('Irineu');
INSERT INTO categoria(nome) values ('Tubulações');


INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Monitor de 144Hz', 1500.00, 5,'UN', 2, 1);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Formatação PC',49.90, 1,'UN', 1, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Tampa',19.90, 20,'UN', 3, 3);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Curso Avançado de C#', 499.90, 20,'UN', 4, 4);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Mouse Razer', 799.99, 2,'UN', 2, 5);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Teclado CK104', 149.90, 6,'UN', 1, 6);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Aula de Drift', 1800, 10,'UN', 3, 1);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Porção de batata', 7.50, 6,'UN', 4, 2);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('PC MASTER RACE', 15000, 1,'UN', 2, 3);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Limpeza de PC MASTER RACE', 49.90, 1,'UN', 1, 4);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Factor Memes', 800, 10,'UN', 3, 5);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Aula de GitHub', 400, 15,'UN', 4, 6);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Avião TAM', 85000000, 1 ,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Notebook Lenovo G475',700.90, 1,'UN', 1, 1);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('CNH Falsificada', 3400, 1,'UN', 3, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Software biblioteca IFSP', 150000, 1 ,'UN', 4, 3);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Avião GOL', 65000000, 1,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Manutenção de Notebook', 49.90, 1,'UN', 1, 4);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('CNH Original', 5600, 1,'UN', 3, 5);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Software de todo tipo', 2000, 5,'UN', 4, 6);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Aviao AZUL', 42000000, 1,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('AK-47 RED LINE(CS GO)',70.90, 1 ,'UN', 1, 1);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Irineu, você não sabe nem eu', 74.99, 17,'UN', 3, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Café Grande(Por Dia)', 1.50, 1,'UN', 4, 3);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Avião ROXO', 50000000 ,1,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('AWP RED LINE(CS GO)', 89.90, 1,'UN', 1, 4);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Sabonete Phebo', 2.99, 138,'UN', 3, 5);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Cafézinhozinho', 1.00, 175,'UN', 4, 6);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Avião AMARELO', 25000000, 1,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Placa de vídeo 1050 TI', 700.90, 5,'UN', 1, 1);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('PUBG', 55.59, 1,'UN', 3, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('QUERO CAFÉÉÉÉÉ', 1.50, 250,'UN', 4, 3);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Avião CYAN', 7500000, 1,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('CG 150(TURBO)', 3999.90, 2,'UN', 1, 4);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Revólvi', 500, 7,'UN', 3, 5);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Kpeta', 666, 666,'UN', 4, 6);

INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Avião ROXO MEIO AMARELO', 999999999.99, 1,'UN', 2, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Rage', 999.99, 1,'UN', 1, 1);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Tenis para Mesa de Tenis de Mesa', 899.99, 12,'UN', 3, 2);
INSERT INTO produtos(nome, preco, qntd, tipoUn, idFornecedor, idCategoria) values ('Panicat', 150000.00, 5.5,'KG', 4, 3);




INSERT INTO usuario(nome, cpf, sexo, dataNasc, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado, cargo, login, senha) 
	values ('Gustavo Nunes','46760818806','M','1997-09-24','1633667070','0','13563340',666,'Rua Albino Triques','','Parque Santa Felícia Jardim','São Carlos','SP','Administrador','gnunesinfo','gustavo4990');
	

INSERT INTO usuario(nome, cpf, sexo, dataNasc, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado, cargo, login, senha) 
	values ('Carlos Silva','44691492844','M','1996-12-06','1633661367','16982472564','13573059',882,'Rua Joaquim Garcia de Oliveira ','','Cidade Aracy ','São Carlos','SP','Administrador','csilva','hitlerdidnothingwrong');
	
	
INSERT INTO usuario(nome, cpf, sexo, dataNasc, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado, cargo, login, senha) 
	values ('Administrador','31313131313','M','1990-10-16','1633333333','16982472564','13573059',882,'Rua Joaquim Garcia de Oliveira ','','Cidade Aracy ','São Carlos','SP','Administrador','admin','admin');

INSERT INTO usuario(nome, cpf, sexo, dataNasc, tel1, tel2, cep, num, rua, comp, bairro, cidade, estado, cargo, login, senha) 
	values ('Joanete','313131313132','F','1990-10-26','1633333333','16982472564','13573059',882,'Rua Joaquim Garcia de Oliveira ','','Cidade Aracy ','São Carlos','SP','Caixa','caixa','caixa');
