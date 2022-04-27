use TexteNextSoftMVC
go

--- Usar esse comando caso ainda não exista  a tabela UniaoTabelas

/*select  M.Nome as 'Pessoa',M.Idade as 'Idade', F.Nome as 'Família', C.Nome as "Condominio", C.Bairro as 'Bairro'
into UniaoTabelas
from Morador as M left join Familia as F on M.Id_Familia = F.Id
inner join Condominio as C on C.Id = F.Id_Condominio
go*/

select Bairro, AVG(Idade) as "Media Idade" from UniaoTabelas
group by Bairro