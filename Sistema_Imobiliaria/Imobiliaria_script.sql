--Criação da base de dados IMOBILIARIA
CREATE DATABASE imobiliaria;

--Usando base criada
USE imobiliaria;

--Criação da tabela dos administradores
CREATE TABLE admin (
  LOGIN VARCHAR(20) NOT NULL PRIMARY KEY,
  SENHA VARCHAR(20) NOT NULL,
);

--Criação da tabela dos clientes
CREATE TABLE cliente (
  ID_CLIENTE INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  NOME VARCHAR(100) NOT NULL,
  EMAIL VARCHAR(100) NOT NULL,
  ENDERECO VARCHAR(100) NOT NULL,
  COMPLEMENTO VARCHAR(20) NULL,
  CIDADE VARCHAR(45) NOT NULL,
  ESTADO CHAR(2) NOT NULL,
  TELEFONE VARCHAR(20) NOT NULL,
  DATA_NASC DATE NOT NULL,
);

--Criação da tabela dos imóveis
CREATE TABLE imovel (
  ID_CLIENTE INT NOT NULL FOREIGN KEY REFERENCES cliente(ID_CLIENTE),
  ENDERECO VARCHAR(100) NOT NULL,
  CIDADE VARCHAR(45) NOT NULL,
  ESTADO CHAR(2) NOT NULL,
  TIPO VARCHAR(20) NOT NULL,
  VALOR DECIMAL(10,2) NOT NULL,
  DATA_AQUISICAO DATE NOT NULL,
);

-- Inserindo Admins a tabela ADMIN
INSERT INTO admin VALUES(
'lucasmariano',
'lucas123'
);

INSERT INTO admin VALUES(
'josesilva',
'jose123'
);

INSERT INTO admin VALUES(
'camilafranco',
'camila123'
);

-- Inserindo dois clientes na tabela CLIENTE
INSERT INTO cliente VALUES(
'João Rocha',
'rocha@gmail.com',
'R. das Flores, 71',
'Casa',
'Curitiba',
'PR',
'41992581521',
'04/07/1970'
);

INSERT INTO cliente VALUES(
'Francisco Souza',
'souza@gmail.com',
'R. do Biscoito, 99',
'Casa',
'São Paulo',
'SP',
'11988887777',
'04/07/1980'
);

--Inserindo dois imoveis na tabela IMOVEL associando ao cliente ID 1
INSERT INTO imovel VALUES(
1,
'R. das Bananas, 28',
'São José dos Pinhais',
'PR',
'Apartamento B21',
140000.00,
'02/02/2002'
);

INSERT INTO imovel VALUES(
1,
'R. das Laranjas, 33',
'Colombo',
'PR',
'Casa',
100000.00,
'12/05/2005'
);

--Inserindo um imovel na tabela IMOVEL associando ao cliente ID 2
INSERT INTO imovel VALUES(
2,
'Av. Doce, 2233',
'São Bernardo do Campo',
'SP',
'Apartamento A5',
223000.00,
'12/05/2010'
);

--Mostrando tudo das tabelas
SELECT * FROM admin;
SELECT * FROM cliente;
SELECT * FROM imovel;