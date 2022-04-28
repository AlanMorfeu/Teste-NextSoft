use TexteNextSoftMVC
go
insert into Condominio(Nome,Bairro) 
values ('Serra Negra','Vila Nova'),
	   ('Casa Branca','Moema'),
	   ('Bom Recanto','Vila Guarani'),
	   ('Imaré','Capuava'),
	   ('Andorinha','Jardim América')
go
insert into Familia(Nome,Id_Condominio,Apto) 
values ('Silva',2,10),
       ('Novaes',2,45),
       ('Nobrega',4,110),
       ('Campineli',1,712),
       ('Souza',1,715),
       ('Gonçalvez',3,640),
       ('Camargo',3,301),
       ('Brito',5,507),
       ('Oliveira',3,530),
       ('Jovanelli',4,507),
       ('Vieira',5,310)
go
insert into Morador(Id_Familia,Nome,Idade) 
values (1,'Valmir',65),
       (3,'Lúcia',27),
       (2,'Marcelo',35),
       (2,'Irene',78),
       (5,'Marta',31),
       (11,'Alberto',56),
       (8,'Lucas',10),
       (4,'Maria',25),
       (9,'Mateus',5),
       (10,'Julia',9),
       (5,'Bernardo',2),
       (7,'Rosa',18),
       (3,'Helena',23),
       (1,'Willian',15),
       (1,'José',42),
       (3,'Priscila',13),
       (7,'Amanda',29),
       (5,'Guilherme',22),
       (4,'Roberta',2),
       (4,'Ricardo',30),
       (6,'Giovane',81),
       (6,'Flavia',11),
       (11,'Fabiana',43),
       (8,'Marcio',20),
       (7,'Roberto',1),
       (9,'Marcos',4),
       (4,'Rafael',3),
       (10,'Bruna',1)
