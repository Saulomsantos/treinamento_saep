CREATE DATABASE Lan_House;

USE Lan_House;

CREATE TABLE TipoDefeito(
	tipoDefeitoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,Titulo VARCHAR(255) NOT NULL
);

CREATE TABLE Equipamento(
	equipamentoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,nome VARCHAR(255)
);

CREATE TABLE Defeito(
	defeitoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,dataDefeito DATETIME2 NOT NULL
	,equipamentoId INT FOREIGN KEY REFERENCES Equipamento(equipamentoId)
	,tipoDefeitoId INT FOREIGN KEY REFERENCES TipoDefeito(tipoDefeitoId)
	,observacao VARCHAR(255) NOT NULL
);

CREATE TABLE Usuario(
	usuarioId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,email VARCHAR(255) NOT NULL
	,senha VARCHAR(255) NOT NULL
);

INSERT INTO Usuario
VALUES ('admin@email.com', '123456');

BULK INSERT Equipamento
FROM 'E:\Works\Cursos\senai_desenvolvimento\2s2019\treinamento_SAEP\treinamento-razor-lanhouse\csv\tipo_equipamento.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);

BULK INSERT TipoDefeito
FROM 'E:\Works\Cursos\senai_desenvolvimento\2s2019\treinamento_SAEP\treinamento-razor-lanhouse\csv\defeito.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);

BULK INSERT Defeito
FROM 'E:\Works\Cursos\senai_desenvolvimento\2s2019\treinamento_SAEP\treinamento-razor-lanhouse\csv\registro_defeito.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);