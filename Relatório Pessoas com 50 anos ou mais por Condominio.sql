use TexteNextSoftMVC
go

--- Usar esse comando caso ainda n�o exista  a tabela UniaoTabelas

/*select  M.Nome as 'Pessoa',M.Idade as 'Idade', F.Nome as 'Fam�lia', C.Nome as "Condominio", C.Bairro as 'Bairro'
into UniaoTabelas
from Morador as M left join Familia as F on M.Id_Familia = F.Id
inner join Condominio as C on C.Id = F.Id_Condominio
go*/

select Condominio, count(Idade) as "Pessoas com 50 anos ou mais" from UniaoTabelas
where Idade >= 50
group by Condominio



