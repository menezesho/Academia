CREATE DATABASE BD_ACADEMIA;
GO

USE BD_ACADEMIA;
GO

CREATE TABLE PROFESSOR(
	IDPROFESSOR		INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOME			VARCHAR(50) NOT NULL,
	CPF				CHAR(11) NOT NULL, --UNIQUE
	IDADE			INT NOT NULL,
	CELULAR			CHAR(11) NOT NULL,
	EMAIL			VARCHAR(50) NOT NULL,	
	USUARIO			VARCHAR(30) NOT NULL,
	SENHA			VARCHAR(30) NOT NULL,

	RUA				VARCHAR(100) NOT NULL,
	NUMERO			INT NOT NULL,
	APTO			VARCHAR(5),
	BAIRRO			VARCHAR(50) NOT NULL,
	CIDADE			VARCHAR(50) NOT NULL,
	ESTADO			CHAR(2) NOT NULL
);
GO

CREATE TABLE ALUNO(
	IDALUNO		INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOME			VARCHAR(50) NOT NULL,
	CPF				CHAR(11) NOT NULL, --UNIQUE
	IDADE			INT NOT NULL,
	CELULAR			CHAR(11) NOT NULL,
	EMAIL			VARCHAR(50) NOT NULL,
	USUARIO			VARCHAR(30) NOT NULL,
	SENHA			VARCHAR(30) NOT NULL,
	PESO			INT,
	ALTURA			INT,

	RUA				VARCHAR(100) NOT NULL,
	NUMERO			INT NOT NULL,
	APTO			VARCHAR(5),
	BAIRRO			VARCHAR(50) NOT NULL,
	CIDADE			VARCHAR(50) NOT NULL,
	ESTADO			CHAR(2) NOT NULL
);
GO

CREATE TABLE AULA(
	IDAULA			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NOME			VARCHAR(50) NOT NULL,
	DIA				DATE NOT NULL,
	HORA			CHAR(3) NOT NULL,
	TOTAL			INT,
	CONTADOR		INT,
	ID_PROFESSOR	INT,

	FOREIGN KEY (ID_PROFESSOR) REFERENCES PROFESSOR(IDPROFESSOR)
);
GO

CREATE TABLE PARTICIPANTE(
	IDPARTICIPANTE	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ID_AULA			INT NOT NULL,
	ID_ALUNO		INT NOT NULL,
	ID_PROFESSOR	INT NOT NULL,

	FOREIGN KEY (ID_AULA) REFERENCES AULA(IDAULA),
	FOREIGN KEY (ID_ALUNO) REFERENCES ALUNO(IDALUNO),
	FOREIGN KEY (ID_PROFESSOR) REFERENCES PROFESSOR(IDPROFESSOR),
);
GO

SELECT * FROM PROFESSOR;
SELECT * FROM ALUNO;
SELECT * FROM AULA;
SELECT * FROM PARTICIPANTE;

/*
INSERT INTO ALUNO (NOME, CPF, IDADE, CELULAR, EMAIL, USUARIO, SENHA, PESO, ALTURA, RUA, NUMERO, BAIRRO, CIDADE, ESTADO) VALUES
('Gabriel Souza de Jesus', '48597562356', 19, '35998625985', 'gabriel@gmail.com', 'gabriel-sj', '321654', 65, 178, 'Rua Uruguai', 30, 'Jardim das Aroeiras', 'Brasilia', 'DF'),
('Maria Eduarda Garcia', '35685745241', 35, '56978546524', 'maria@gmail.com', 'maria-eg', '321654', 75, NULL, 'Rua Geral da Silva', 123, 'Centro', 'Passos', 'MG'),
('Evangelista Cruz Marcos', '98656782465', 26, '96978524620', 'evangelista@gmail.com', 'evangelista-cm', '321654', 82, 182, 'Avenida Poços de Caldas', 802, 'Centro', 'Passos', 'MG'),
('Tiago Betânia Inácio', '37546825920', 44, '45902452623', 'tiago@gmail.com', 'tiago-bi', '321654', 45, 156, 'Rua Hellen Ribeiro', 950, 'Jardim Centenário', 'Ribeirão Preto', 'SP'),
('Dênis Martim Aparecida', '24685987562', 52, '85665248562', 'denis@gmail.com', 'denis-ma', '321654', NULL, NULL, 'Avenida Europa', 5621, 'Centro', 'São Paulo', 'SP'),
('Juliana Francisca Abílio', '32012480256', 17, '36920452084', 'juliana@gmail.com', 'juliana-fa', '321654', NULL, 176, 'Avenida da Moda', 653, 'Centro', 'Passos', 'MG');

INSERT INTO PROFESSOR (NOME, CPF, IDADE, CELULAR, EMAIL, USUARIO, SENHA, RUA, NUMERO, BAIRRO, CIDADE, ESTADO) VALUES
('João da Silva', '24025689562', 19, '35998625985', 'gabriel@gmail.com', 'joao-ds', '321654', 'Rua Uruguai', 30, 'Jardim das Aroeiras', 'Brasilia', 'DF'),
('Joana Souza Valério', '78502456230', 35, '56978546524', 'maria@gmail.com', 'joana-sv', '321654', 'Rua Geral da Silva', 123, 'Centro', 'Passos', 'MG'),
('Gabriela Fagundes da Silveira', '96575202352', 26, '96978524620', 'evangelista@gmail.com', 'gabriela-fs', '321654', 'Avenida Poços de Caldas', 802, 'Centro', 'Passos', 'MG'),
('Yuri Leite Reis', '63458526203', 44, '45902452623', 'tiago@gmail.com', 'yuri-lr', '321654', 'Rua Hellen Ribeiro', 950, 'Jardim Centenário', 'Ribeirão Preto', 'SP'),
('Kelton James Lemos', '89567524032', 52, '85665248562', 'denis@gmail.com', 'kelton-jl', '321654', 'Avenida Europa', 5621, 'Centro', 'São Paulo', 'SP'),
('Maria Eduarda Ribeiro', '56785945210', 17, '36920452084', 'juliana@gmail.com', 'maria-er', '321654', 'Avenida da Moda', 653, 'Centro', 'Passos', 'MG');

INSERT INTO AULA (NOME, DIA, HORA, TOTAL, CONTADOR, ID_PROFESSOR) VALUES
('Box', '2023-02-15', '09h', NULL, 0, 1),
('Funcional', '2023-02-15', '11h', 2, 0, 1),
('Bicicleta', '2023-02-15', '12h', 10, 0, 2),
('Dança', '2023-02-15', '13h', NULL, 0, 2),
('Box', '2023-02-15', '16h', 3, 0, 2);
*/

SELECT * FROM PROFESSOR;
SELECT * FROM ALUNO;
SELECT * FROM AULA;
SELECT * FROM PARTICIPANTE;
