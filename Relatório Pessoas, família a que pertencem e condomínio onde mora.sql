use TexteNextSoftMVC
select M.Nome as 'Pessoa', F.Nome as 'Fam�lia', C.Nome as 'Condom�nio' from Morador as M left join Familia as F on M.Id_Familia = F.Id
inner join Condominio as C on C.Id = F.Id_Condominio
