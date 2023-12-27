create database Clinica

use Clinica

create table Paciente(Id_Paciente int primary key, 
Nombre varchar (50) not null,
Apellido varchar (50) not null,
Cedula varchar (50) not null,
Telefono varchar (50) not null,
Direccion varchar(50));
EXEC sp_rename 'Paciente.Nombre', 'Nombre_Paciente', 'COLUMN'
EXEC sp_rename 'Paciente.Apellido', 'Apellido_Paciente', 'COLUMN'

create table AreaMedica(Id_Area int primary key,
nombre_Area varchar(50) not null);


create table Colaborador_Medico(Id_Empleado int primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Telefono varchar(50) not null,
Id_Area_Medica int null,
constraint fk_Area_Medica foreign key (Id_Area_Medica) references Area_Medica(Id_Area) 
)
alter table Colaborador_Medico drop constraint fk_Area_Medica
alter table Colaborador_Medico add foreign key (Id_Area_Medica) references Area_Medica(Id_Area) on delete cascade 

EXEC sp_rename 'Colaborador_Medico.Id_Empleado', 'Id_Medico', 'COLUMN'
EXEC sp_rename 'Colaborador_Medico.Nombre', 'Nombre_Medico', 'COLUMN'
EXEC sp_rename 'Colaborador_Medico.Apellido', 'Apellido_Medico', 'COLUMN'

create table Consultas_Medicas(Id_Consulta int primary key,
Fecha_Consulta date not null,
Padecimiento varchar(50) not null,
Estado_Consulta varchar(50) not null,
Total float not null,
Id_Paciente int not null,
Id_Medico int not null,
constraint fk_Paciente foreign key (Id_Paciente) references Paciente(Id_Paciente)
on delete cascade ,
constraint fk_Colaborador_Medico foreign key (Id_Medico) references Colaborador_Medico(Id_Medico)
on delete cascade 
)


select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico

insert into Consultas_Medicas values(105,'07-07-2022', 'Dolor de Cabeza', 'No Pendiente',35.50, 111, 123)
insert into Consultas_Medicas values(155,'10-02-2022', 'Fiebre', 'No Pendiente',25.50, 192,123)

insert into Colaborador_Medico values (961, 'Angel', 'Rodriguez', '6372-7294', 998)
insert into Colaborador_Medico values (321, 'Romulo', 'Diaz', '6998-7709',null)


select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area 


select * from AreaMedica
select * from Colaborador_Medico
select *from Consultas_Medicas

--Procedimiento listar areas
CREATE PROCEDURE ListarAreasM
as 
select * from Area_Medica

CREATE PROCEDURE ListarPaciente
as 
select * from Paciente

create procedure ListarColabMedicoss
as
select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area or a.Id_Area_Medica is null

create procedure ListarConsultass
as
select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico, d.nombre_Area
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico
inner join Area_Medica d
on c.Id_Area_Medica = d.Id_Area

select * from Consultas_Medicas
insert into Area_Medica values (323, 'Laboratorios')
insert into Area_Medica values (109, 'Julio')

insert into Paciente values (111, 'Angel', 'Herrera', '8-972-1037','6372-7294','Panama,San Miguelito, San Antonio')
insert into Paciente values (192, 'Xiomara', 'Parker', '8-932-201','6755-7709','Panama, Don Bosco, Las Acacias')
select * from Area_Medica


select * from Area_Medica
where Id_Area LIKE 'M%'

select * from Paciente
where Nombre LIKE 'M%'

select * from Paciente
where Apellido LIKE 'M%'

select * from Paciente
where Cedula LIKE 'M%'


select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area
where a.Nombre_Medico like 'M%'

select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area
where a.Apellido_Medico like 'M%'

select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area
where b.nombre_Area like 'M%'

select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico, d.nombre_Area
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico
inner join Area_Medica d
on c.Id_Area_Medica = d.Id_Area
where a.Padecimiento like'M%'
--Procedimiento para Buscar Areas medicas
create procedure BuscarId_Area
@codigo int
as
select * from Area_Medica
where Id_Area = @codigo

create procedure BuscarId_Paciente
@codigo int
as
select * from Paciente
where Id_Paciente = @codigo

create procedure BuscarId_Medico 
@codigo int
as
select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area
where a.Id_Medico = @codigo

create procedure BuscarId_AreaM 
@codigo int
as
select a.Id_Medico, a.Nombre_Medico, a.Apellido_Medico, a.Telefono, a.Id_Area_Medica, b.nombre_Area
from Colaborador_Medico a inner join  Area_Medica b
on a.Id_Area_Medica = b.Id_Area
where a.Id_Area_Medica = @codigo

create procedure BuscarId_Consulta 
@codigo int
as
select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico, d.nombre_Area
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico
inner join Area_Medica d
on c.Id_Area_Medica = d.Id_Area
where a.Id_Consulta = @codigo

create procedure BuscarId_MedConsulta
@codigo int
as
select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico, d.nombre_Area
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico
inner join Area_Medica d
on c.Id_Area_Medica = d.Id_Area
where a.Id_Medico = @codigo


create procedure BuscarId_PacConsulta
@codigo int
as
select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico, d.nombre_Area
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico
inner join Area_Medica d
on c.Id_Area_Medica = d.Id_Area
where a.Id_Paciente = @codigo

create procedure BuscarId_MedConsulta
@codigo int
as
select a.Id_Consulta, a.Fecha_Consulta, a.Padecimiento,a.Estado_Consulta,a.Total, a.Id_Paciente, b.Nombre_Paciente, b.Apellido_Paciente, a.Id_Medico, c.Nombre_Medico, c.Apellido_Medico, d.nombre_Area
from Consultas_Medicas a inner join Paciente b
on a.Id_Paciente = b.Id_Paciente
inner join Colaborador_Medico c
on a.Id_Medico = c.Id_Medico
inner join Area_Medica d
on c.Id_Area_Medica = d.Id_Area
where a.Id_Medico = @codigo

--Procedimiento para insertar Areas medicas
create procedure Insertar_AreasMedicas
@Id int,
@nombre varchar(30)
as
insert into Area_Medica values (@Id, @nombre)

create procedure Insertar_ColabMedicos
@Id int,
@nombre varchar(50),
@apellido varchar(50),
@telefono varchar(50),
@idArea int
as
insert into Colaborador_Medico values (@Id, @nombre, @apellido, @telefono, @idArea)

create procedure Insertar_Pacientes
@Id int,
@nombre varchar(30),
@apellido varchar(30),
@cedula varchar(30),
@tel varchar(30),
@direc varchar(100)
as
insert into Paciente values (@Id, @nombre, @apellido, @cedula, @tel, @direc)

create procedure Insertar_Consultas
@Id int,
@dia date,
@padecimiento varchar(30),
@estadoconsulta varchar(30),
@total float,
@idPac int,
@idMed int
as
insert into Consultas_Medicas values (@Id, @dia, @padecimiento, @estadoconsulta, @total, @idPac,@idMed)

--Procedimiento para actualizar Areas medicas
create procedure Actualizar_AreasMedicas
@Id int,
@nombre varchar(30)
as
update Area_Medica
set nombre_Area = @nombre
where Id_Area = @Id

create procedure Actualizar_Pacientess
@Id int,
@nombre varchar(30),
@apellido varchar(30),
@cedula varchar(30),
@tel varchar(30),
@direc varchar(100)
as
update Paciente
set  Nombre_Paciente = @nombre, Apellido_Paciente = @apellido, Cedula = @cedula, Telefono = @tel, Direccion = @direc
where Id_Paciente = @Id


create procedure Actualizar_ColabMedicos
@Id int,
@nombre varchar(50),
@apellido varchar(50),
@telefono varchar(50),
@idArea int
as
update Colaborador_Medico
set Nombre_Medico = @nombre, Apellido_Medico = @apellido, Telefono = @telefono, Id_Area_Medica = @idArea
where Id_Medico = @Id

create procedure Actualizar_Consultas
@Id int,
@dia date,
@padecimiento varchar(30),
@estadoconsulta varchar(30),
@total float,
@idPac int,
@idMed int
as
update Consultas_Medicas
set  Fecha_Consulta = @dia, Padecimiento = @padecimiento, Estado_Consulta = @estadoconsulta, total = @total, Id_Paciente= @idPac, Id_Medico=@idMed
where Id_Consulta = @Id

--Procedimiento para eliminar 
create procedure Eliminar_AreasMedicass
@Id int
as
delete from Area_Medica
where Id_Area = @Id 

create procedure Eliminar_Paciente
@Id int
as
delete from Paciente
where Id_Paciente = @Id

create procedure Eliminar_Medicos
@Id int
as
delete from Colaborador_Medico
where Id_Medico = @Id

create procedure Eliminar_Consultas
@Id int
as
delete from Consultas_Medicas
where Id_Consulta = @Id