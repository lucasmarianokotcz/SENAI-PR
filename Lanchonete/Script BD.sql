CREATE DATABASE lanchonete;
USE lanchonete;

CREATE TABLE [dbo].[registro](
	[COD_REGISTRO] [char](10) NOT NULL,
	[JA_UTILIZADA] [bit] NULL,
 CONSTRAINT [PK_registro] PRIMARY KEY CLUSTERED 
(
	[COD_REGISTRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [lanchonete] SET  READ_WRITE 
GO

--Códigos úteis
/*
USE lanchonete;

SELECT * FROM registro;

INSERT INTO registro VALUES(
'ABCDE12345',
'FALSE'
);

INSERT INTO registro VALUES(
'ZZZZZ11111',
'FALSE'
);

INSERT INTO registro VALUES(
'QWERT09876',
'FALSE'
);

INSERT INTO registro VALUES(
'LLLLL55555',
'TRUE'
);

--SELECT JA_UTILIZADA FROM registro WHERE COD_REGISTRO = 'LLLLL55555';

--UPDATE registro SET JA_UTILIZADA = 'FALSE';
*/

--TABELA PEDIDO
CREATE TABLE pedido(
COD_PEDIDO INT NOT NULL PRIMARY KEY IDENTITY(1,1),
VALOR_PEDIDO DECIMAL(11,2) NOT NULL,
PRECO_CACHORRO_QUENTE DECIMAL(10,2) NOT NULL,
QTD_CACHORRO_QUENTE INT NOT NULL,
PRECO_HAMBURGER DECIMAL(10,2) NOT NULL,
QTD_HAMBURGER INT NOT NULL,
PRECO_REFRI_1L DECIMAL(10,2) NOT NULL,
QTD_REFRI_1L INT NOT NULL,
PRECO_REFRI_2L DECIMAL(10,2) NOT NULL,
QTD_REFRI_2L INT NOT NULL,
);

--SELECT * FROM pedido;

/*
INSERT INTO pedido VALUES(
11.45,
1.1,
1,
2.2,
2,
3.3,
3,
4.4,
4
);
*/

--INSERT INTO pedido (VALOR_PEDIDO, PRECO_CACHORRO_QUENTE, QTD_CACHORRO_QUENTE, PRECO_HAMBURGER, QTD_HAMBURGER, PRECO_REFRI_1L, QTD_REFRI_1L, PRECO_REFRI_2L, QTD_REFRI_2L)
                               -- VALUES (11.5, 2.2, 1, 2.2, 1, 4.4, 4, 5.5, 5)
