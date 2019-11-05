USE Lan_House;

INSERT INTO Usuario
VALUES ('admin@email.com', '123456');

BULK INSERT Equipamento
FROM 'C:\treinamento-razor-lanhouse\csv\tipo_equipamento.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);

BULK INSERT TipoDefeito
FROM 'C:\treinamento-razor-lanhouse\csv\defeito.csv'
WITH (
	FIELDTERMINATOR = ',',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 1,
	CODEPAGE = 'acp'
);

INSERT INTO Defeito (dataDefeito, observacao, tipoDefeitoId, equipamentoId)
VALUES		('2017-01-03 00:00:00', 'Aparelho não liga, fonte ligada',1,1),
			('2018-01-03 00:00:00', 'O aparelho desliga do nada',2,2),
			('2019-01-03 00:00:00', 'Não da sinal de imagem',3,1),
			('2019-02-03 00:00:00', 'Não conecta a internet',4,3),
			('2016-01-03 00:00:00', 'Fonte não liga',5,2),
			('2018-01-03 00:00:00', 'HD cheio',6,3);