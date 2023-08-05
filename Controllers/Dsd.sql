create database Dsd;
GO

create table ficha ( id int primary key, nome varchar(50), email varchar(50),cpf varchar(50),paciente varchar (50) );
GO

insert into ficha values (1,'Gustavo', 'Gustavo@gmail.com','298.209.297-00','Theo');

insert into ficha values (2,'Juliano', 'Juliano@gmail.com','198.208.389-09','Zeus');

insert into ficha values (3,'Joaquina', 'Joaquina@gmail.com','234.297.298-28','Luck');

Select * from ficha;