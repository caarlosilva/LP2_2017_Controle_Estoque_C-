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

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Mouse Razer',799.99,'2',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Teclado CK104',149.90,'6',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aula de Drift king',1800,'10',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Porção de batata',7.50,'6',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('PC MASTER RACE', 15000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Limpeza de PC MASTER RACE',49.90,'1',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('FACTOR MEMES',800,'10',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('AULA DE GITHUB',400,'15',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao TAM', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Notebook Lenovo G475',700.90,'1',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CNH FALSIFICADA',1,'100',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('SOTWARE BIBLIOTECA IFSP',9400.00,'1',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao GOL', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Manutenção de Notebook',49.90,'10',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CNH ORIGINAL',1700.00,'100',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('SOTWARE DE TODO TIPO',7400.00,'100',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao AZUL', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('AK-47 RED LINE(CS GO)',70.90,'1',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('IRINEU VC NAO SABE NEM EU',100,'100',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CAFÉ GRANDE(POR DIA)',1.50,'14',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao ROXO', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('AWP RED LINE(CS GO)',89.90,'1',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CADE A TAMPA?',50,'100',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CAFÉ PEQUENO',1.00,'2',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao AMARELO', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('PLACA DE VIDEO 1050 TI',700.90,'1',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('PUBG',55,'1',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('QUERO CAFÉÉÉÉÉ',1.50,'500',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao CYAN', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CG 150(TURBO)',4000.90,'2',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('REVOLVER',500,'100',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('CAPETA',666,'666',3);

INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('Aviao ROXO MEIO AMARELO', 150000.00,'1',2);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('RAGE',2.90,'500',1);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('SOU UM BOSTA MEU IRMAO',500,'100',4);
INSERT INTO produtos(nome, preco, qntd, idFornecedor) values ('PANIQUETE',2500,'3',3);

