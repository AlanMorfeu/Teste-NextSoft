USE TexteNextSoftMVC
GO


SELECT C.Nome AS 'Condomínio', COUNT(M.Idade) as 'Pessoas com 50 anos ou mais' 
FROM Condominio AS C 
INNER JOIN Familia AS F ON C.Id = F.Id_Condominio
INNER JOIN Morador AS M ON M.Id_Familia = F.Id
WHERE M.Idade >= 50 
GROUP BY C.Nome





