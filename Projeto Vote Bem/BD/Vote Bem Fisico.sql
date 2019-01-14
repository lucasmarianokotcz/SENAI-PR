--DATABASE PROJETO VOTE BEM - QUIZ (Guilherme Vieira, Lucas Mariano, Luiz Gustavo, Manuele Faquette)
--Criando e utilizando base de dados 'votebem'
CREATE DATABASE votebem;
GO
USE votebem;
GO

--Criando tabela 'jogador'
CREATE TABLE jogador(
  COD_JOGADOR	INT			NOT NULL IDENTITY(1,1) PRIMARY KEY,
  NOME			VARCHAR(60) NOT NULL,
  EMAIL			VARCHAR(60) NULL,
  IDADE			CHAR(12)	NOT NULL,
  PONTUACAO		TINYINT		NOT NULL,
);
GO

--Criando tabela 'questao'
CREATE TABLE questao(
  COD_QUESTAO			INT		NOT NULL IDENTITY(1,1) PRIMARY KEY,
  DESCRICAO				TEXT	NOT NULL,
  RESPOSTA_CORRETA		TEXT	NOT NULL,
  RESPOSTA_INCORRETA	TEXT	NOT NULL,
);
GO

--Criando tabela jogador_questao, que liga as tabelas 'jogador' e 'questao'
CREATE TABLE jogador_questao(
  COD_JOGADOR		INT		NOT NULL FOREIGN KEY (COD_JOGADOR) REFERENCES jogador(COD_JOGADOR),
  COD_QUESTAO		INT		NOT NULL FOREIGN KEY (COD_QUESTAO) REFERENCES questao(COD_QUESTAO),  
  RESPOSTA_JOGADOR	TEXT	NOT NULL
);

--Testando o banco de dados inserindo valores
/*
SELECT * FROM jogador;
SELECT * FROM questao;
SELECT * FROM jogador_questao;

INSERT INTO jogador VALUES(
'LUCAS MARIANO',
'lucas@gmail.com',
'16 A 17 ANOS',
6
);

INSERT INTO jogador VALUES(
'ANA CARVALHO',
NULL,
'12 A 15 ANOS',
4
);

INSERT INTO questao VALUES(
'QUEM DESCOBRIU O BRASIL?',
'PEDRO �LVARES CABRAL',
'DOM PEDRO I'
);

INSERT INTO questao VALUES(
'QUAL A PRIMEIRA CAPITAL BRASILEIRA?',
'SALVADOR',
'S�O PAULO'
);

INSERT INTO jogador_questao VALUES(
1,
1,
'PEDRO �LVARES CABRAL'
);

INSERT INTO jogador_questao VALUES(
1,
2,
'S�O PAULO'
);

INSERT INTO jogador_questao VALUES(
2,
1,
'DOM PEDRO I'
);

INSERT INTO jogador_questao VALUES(
2,
2,
'SALVADOR'
);
*/

--Selects para busca dos resultados passados pelo ID do jogador
/*
SELECT questao.DESCRICAO AS 'DESCRI��O', questao.RESPOSTA_CORRETA AS 'RESPOSTA CORRETA',
		jogador_questao.RESPOSTA_JOGADOR AS 'SUA RESPOSTA' FROM
		jogador, questao, jogador_questao WHERE
		jogador.COD_JOGADOR = 1 AND jogador_questao.COD_JOGADOR = 1 AND jogador_questao.COD_QUESTAO = questao.COD_QUESTAO;
*/

--Select para buscar uma quest�o aleat�ria
/*
SELECT TOP 6 * FROM questao ORDER BY NEWID();
*/

--SELECT jogador.COD_JOGADOR AS 'C�DIGO DO JOGADOR', jogador.NOME, jogador.IDADE AS 'FAIXA ET�RIA', jogador.PONTUACAO AS 'PONTUA��O' FROM jogador WHERE jogador.COD_JOGADOR = 1;

--Cadastrando quest�es no banco
/*
INSERT INTO questao VALUES(
'Qual a principal fun��o do sistema Judici�rio?',
'Defender os direitos de cada cidad�o',
'Criar leis que favore�am o cidad�o brasileiro'
);

INSERT INTO questao VALUES(
'O poder judici�rio n�o est� unicamente centralizado nas m�os do Judici�rio. A Constitui��o Federal Brasileira garante meios alternativos a todos os cidad�os. Quais s�o esses meios?',
'Minist�rio P�blico, Defensoria P�blica e advogados particulares',
'Policia Civil, Presidente da Rep�blica e Governadores'
);

INSERT INTO questao VALUES(
'Quem foi o criador da ideia dos modelos dos tr�s poderes (Executivo, Legislativo e Judici�rio)?',
'Charles-Louis de Secondat, mais conhecido como Montesquieu',
'Karl Marx'
);

INSERT INTO questao VALUES(
'Quem s�o os �rg�os respons�veis por executar, fiscalizar e gerir as leis de um pa�s do Poder Executivo?',
'Presid�ncia da Rep�blica, Minist�rios, Secretarias da Presid�ncia, �rg�os da Administra��o P�blica e os Conselhos de Pol�ticas P�blicas',
'Deputados, Governadores e Delegados'
);

INSERT INTO questao VALUES(
'Qual o modelo de estado que o Brasil possui?',
'Republicano',
'Capitalista'
);

INSERT INTO questao VALUES(
'Qual � o n�vel do poder exercido pelos prefeitos?',
'N�vel municipal',
'N�vel regional'
);

INSERT INTO questao VALUES(
'Qual parte do poder executivo toma decis�es referentes a constru��o de escolas, creches, hospitais e outros itens?',
'Governadores e Prefeitos',
'Senadores e Presidente'
);

INSERT INTO questao VALUES(
'Qual � o mais antigo entre os tr�s poderes?',
'Judici�rio',
'Legislativo '
);

INSERT INTO questao VALUES(
'Em que ano a Constitui��o Brasileira adotou a Triparti��o de Poderes?',
'No ano de 1891',
'No ano de 1918'
);

INSERT INTO questao VALUES(
'Quais s�o os 3 poderes que regem o Brasil?',
'Executivo, Legislativo, Judici�rio',
'Democr�tico, Legislativo, Federal'
);

INSERT INTO questao VALUES(
'O Presidente faz parte de qual dos 3 poderes?',
'Executivo',
'Legislativo'
);

INSERT INTO questao VALUES(
'A Pol�cia Civil faz parte de qual dos 3 poderes?',
'Judici�rio',
'Executivo'
);

INSERT INTO questao VALUES(
'O Congresso Nacional � uma institui��o pol�tica que exerce qual poder?',
'Poder Legislativo',
'Poder Executivo'
);

INSERT INTO questao VALUES(
'Qual institui��o que aprova o Presidente da Rep�blica em atos militares?',
'Congresso Nacional',
'Uni�o das Na��es Unidas (ONU)'
);

INSERT INTO questao VALUES(
'O que significa a sigla STF?',
'Supremo Tribunal Federal',
'Supremo Tribunal Funcional'
);

INSERT INTO questao VALUES(
'O que significa a sigla TCU?',
'Tribunal de Contas da Uni�o',
'Tribunal de Cotas Unidas'
);

INSERT INTO questao VALUES(
'O que significa a sigla TRE?',
'Tribunal Regional Eleitoral',
'Tribunal Regente Eleitoral'
);

INSERT INTO questao VALUES(
'O que significa a sigla TCE?',
'Tribunal de Contas do Estado',
'Tribunal de Contas Exterior'
);
*/

--Select de perguntas n�vel dif�cil
/*
SELECT TOP 6 * FROM questao WHERE questao.COD_QUESTAO <= 9 ORDER BY NEWID();
*/

--Select de perguntas n�vel f�cil
/*
SELECT TOP 6 * FROM questao WHERE questao.COD_QUESTAO >= 10 ORDER BY NEWID();
*/

--Select para buscar �ltimo jogador que respondeu ao Quiz
/*
SELECT MAX(COD_JOGADOR) AS 'ULTIMO ID' FROM jogador
*/