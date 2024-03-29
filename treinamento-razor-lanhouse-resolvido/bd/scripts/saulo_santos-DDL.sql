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
	,equipamentoId INT FOREIGN KEY REFERENCES Equipamento(equipamentoId) NOT NULL
	,tipoDefeitoId INT FOREIGN KEY REFERENCES TipoDefeito(tipoDefeitoId) NOT NULL
	,observacao VARCHAR(255) NOT NULL
);

CREATE TABLE Usuario(
	usuarioId INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,email VARCHAR(255) NOT NULL
	,senha VARCHAR(255) NOT NULL
);