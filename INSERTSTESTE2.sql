select * from Operacoes
SELECT * FROM Usuarios
SELECT * FROM Carteiras
SELECT * FROM Estrategias
SELECT * FROM Indicadores
SELECT * FROM Logins
SELECT * FROM perfilTraders
SELECT * FROM Traders

INSERT INTO Traders VALUES('3','Day Trader','SEG-QUINTA','20H00','20.00','100.00','400.00','10.00','50.00','200.00','EUR/USD','Resistencia','Martelo','150.00','2025-05-05')
GO
INSERT INTO perfilTraders VALUES('Day Trader','3')
GO
INSERT INTO Indicadores VALUES('Resistencia','3')
GO
INSERT INTO Carteiras VALUES ('3','300,00','10,00','10,00')
GO
INSERT INTO Estrategias VALUES('3','FIBO','TESTEONDE','TESTECOMO','TESTEPORQUE','TESTEQUANDO')
GO
INSERT INTO Operacoes VALUES ('3', 'EUR/USD', 'FIBO','07/06 - 08H30',300.00,10.00,5.89,20.00,5.89,50.00,'Compra',3.3,1)