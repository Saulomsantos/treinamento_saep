CREATE DATABASE Sisdef_saulo;

USE Sisdef_saulo;

CREATE TABLE TipoDefeito(
	tipoDefeitoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,titulo VARCHAR(255) NOT NULL
);

CREATE TABLE TipoEquipamento(
	tipoEquipamentoId INT IDENTITY (1,1) PRIMARY KEY NOT NULL
	,nome VARCHAR(255) NOT NULL
);

CREATE TABLE Equipamento(
	equipamentoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,tipoEquipamentoId INT FOREIGN KEY REFERENCES TipoEquipamento(tipoEquipamentoId)
	,dataHora DATETIME
);

CREATE TABLE Defeito(
	defeitoId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,dataDefeito DATETIME2 NOT NULL
	,equipamentoId INT FOREIGN KEY REFERENCES Equipamento(equipamentoId)
	,tipoDefeitoId INT FOREIGN KEY REFERENCES TipoDefeito(tipoDefeitoId)
	,dataInicio TIME NOT NULL
	,dataFinal TIME NOT NULL
);


CREATE TABLE Usuario(
	usuarioId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,email VARCHAR(255) NOT NULL
	,senha VARCHAR(255) NOT NULL
);

INSERT INTO Usuario
VALUES ('admin@email.com', '123456');

BULK INSERT TipoEquipamento
FROM 'C:\prova_pratica_saep\tipo_equipamento.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);

BULK INSERT TipoDefeito
FROM 'C:\prova_pratica_saep\defeito.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);

INSERT INTO Equipamento (tipoEquipamentoId)
VALUES		(1)
			,(2)

INSERT INTO Equipamento (TipoEquipamentoId, dataHora)
VALUES			(3,'2017-01-03 00:00:00');

INSERT INTO Defeito (dataDefeito, equipamentoId, tipoDefeitoId, dataInicio, dataFinal)
VALUES		('2017-01-03', 1, 1, '09:15:00', '10:00:00')
			,('2018-01-03', 2, 2, '13:50:00', '15:00:00')
			,('2019-01-03', 1, 3, '13:10:00', '17:30:00')
			,('2019-02-03', 3, 4, '08:00:00', '09:15:00')
			,('2016-01-03', 2, 5, '07:45:00', '08:50:00')
			,('2018-01-03', 3, 6, '07:50:00', '11:00:00')
			,('2019-01-03', 1, 1, '15:00:00', '15:50:00')
			,('2019-01-03', 1, 1, '16:00:00', '17:00:00')
			,('2019-03-03', 1, 1, '16:30:00', '18:15:00')
			,('2017-01-05', 1, 1, '09:00:00', '15:15:00')
			,('2017-02-03', 1, 1, '11:00:00', '11:15:00')
			,('2018-01-03', 2, 2, '09:45:00', '10:45:00')
			,('2017-01-03', 2, 3, '01:01:00', '03:03:00')
			,('2018-01-03', 2, 2, '09:15:00', '22:45:00')
			,('2017-01-03', 3, 6, '05:05:00', '06:06:00');

SELECT * FROM Defeito