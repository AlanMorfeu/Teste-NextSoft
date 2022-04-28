USE TexteNextSoftMVC
GO

SELECT M.Nome AS 'Pessoa', F.Nome AS 'Família', C.Nome AS 'Condomínio' 
FROM Morador AS M 
INNER JOIN Familia AS F ON M.Id_Familia = F.Id
INNER JOIN Condominio AS C ON C.Id = F.Id_Condominio
