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
'PEDRO ÁLVARES CABRAL',
'DOM PEDRO I'
);

INSERT INTO questao VALUES(
'QUAL A PRIMEIRA CAPITAL BRASILEIRA?',
'SALVADOR',
'SÃO PAULO'
);

INSERT INTO jogador_questao VALUES(
1,
1,
'PEDRO ÁLVARES CABRAL'
);

INSERT INTO jogador_questao VALUES(
1,
2,
'SÃO PAULO'
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
SELECT questao.DESCRICAO AS 'DESCRIÇÃO', questao.RESPOSTA_CORRETA AS 'RESPOSTA CORRETA',
		jogador_questao.RESPOSTA_JOGADOR AS 'SUA RESPOSTA' FROM
		jogador, questao, jogador_questao WHERE
		jogador.COD_JOGADOR = 1 AND jogador_questao.COD_JOGADOR = 1 AND jogador_questao.COD_QUESTAO = questao.COD_QUESTAO;
*/

--Select para buscar uma questão aleatória
/*
SELECT TOP 6 * FROM questao ORDER BY NEWID();
*/

--SELECT jogador.COD_JOGADOR AS 'CÓDIGO DO JOGADOR', jogador.NOME, jogador.IDADE AS 'FAIXA ETÁRIA', jogador.PONTUACAO AS 'PONTUAÇÃO' FROM jogador WHERE jogador.COD_JOGADOR = 1;

--Cadastrando questões no banco
/*
INSERT INTO questao VALUES(
'Qual a principal função do sistema Judiciário?',
'Defender os direitos de cada cidadão',
'Criar leis que favoreçam o cidadão brasileiro'
);

INSERT INTO questao VALUES(
'O poder judiciário não está unicamente centralizado nas mãos do Judiciário. A Constituição Federal Brasileira garante meios alternativos a todos os cidadãos. Quais são esses meios?',
'Ministério Público, Defensoria Pública e advogados particulares',
'Policia Civil, Presidente da República e Governadores'
);

INSERT INTO questao VALUES(
'Quem foi o criador da ideia dos modelos dos três poderes (Executivo, Legislativo e Judiciário)?',
'Charles-Louis de Secondat, mais conhecido como Montesquieu',
'Karl Marx'
);

INSERT INTO questao VALUES(
'Quem são os órgãos responsáveis por executar, fiscalizar e gerir as leis de um país do Poder Executivo?',
'Presidência da República, Ministérios, Secretarias da Presidência, Órgãos da Administração Pública e os Conselhos de Políticas Públicas',
'Deputados, Governadores e Delegados'
);

INSERT INTO questao VALUES(
'Qual o modelo de estado que o Brasil possui?',
'Republicano',
'Capitalista'
);

INSERT INTO questao VALUES(
'Qual é o nível do poder exercido pelos prefeitos?',
'Nível municipal',
'Nível regional'
);

INSERT INTO questao VALUES(
'Qual parte do poder executivo toma decisões referentes a construção de escolas, creches, hospitais e outros itens?',
'Governadores e Prefeitos',
'Senadores e Presidente'
);

INSERT INTO questao VALUES(
'Qual é o mais antigo entre os três poderes?',
'Judiciário',
'Legislativo '
);

INSERT INTO questao VALUES(
'Em que ano a Constituição Brasileira adotou a Tripartição de Poderes?',
'No ano de 1891',
'No ano de 1918'
);

INSERT INTO questao VALUES(
'Quais são os 3 poderes que regem o Brasil?',
'Executivo, Legislativo, Judiciário',
'Democrático, Legislativo, Federal'
);

INSERT INTO questao VALUES(
'O Presidente faz parte de qual dos 3 poderes?',
'Executivo',
'Legislativo'
);

INSERT INTO questao VALUES(
'A Polícia Civil faz parte de qual dos 3 poderes?',
'Judiciário',
'Executivo'
);

INSERT INTO questao VALUES(
'O Congresso Nacional é uma instituição política que exerce qual poder?',
'Poder Legislativo',
'Poder Executivo'
);

INSERT INTO questao VALUES(
'Qual instituição que aprova o Presidente da República em atos militares?',
'Congresso Nacional',
'União das Nações Unidas (ONU)'
);

INSERT INTO questao VALUES(
'O que significa a sigla STF?',
'Supremo Tribunal Federal',
'Supremo Tribunal Funcional'
);

INSERT INTO questao VALUES(
'O que significa a sigla TCU?',
'Tribunal de Contas da União',
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

--Select de perguntas nível difícil
/*
SELECT TOP 6 * FROM questao WHERE questao.COD_QUESTAO <= 9 ORDER BY NEWID();
*/

--Select de perguntas nível fácil
/*
SELECT TOP 6 * FROM questao WHERE questao.COD_QUESTAO >= 10 ORDER BY NEWID();
*/

--Select para buscar último jogador que respondeu ao Quiz
/*
SELECT MAX(COD_JOGADOR) AS 'ULTIMO ID' FROM jogador
*/