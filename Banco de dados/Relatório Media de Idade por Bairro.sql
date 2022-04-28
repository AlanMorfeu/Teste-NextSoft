USE TexteNextSoftMVC
GO

SELECT C.Bairro, AVG(M.Idade) AS 'Média de Idade'
FROM Condominio AS C
INNER JOIN Familia AS F ON C.Id = F.Id_Condominio 
INNER JOIN Morador AS M ON F.Id = M.Id_Familia
GROUP BY C.Bairro


