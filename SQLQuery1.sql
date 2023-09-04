--https://github.com/Rancho91/ejercicio_1_6


create database ejercicio_1_6

use ejercicio_1_6

create table camiones (
patente varchar(15),
cargaMax int,
carga decimal,
Estado bit,
constraint pk_camion primary Key (patente)
)

create table tipos_cargas(
id_tipo_carga int identity(1,1),
nombre varchar(200),
constraint pk_tipo_carga primary key(id_tipo_carga)

)

create table cargas(
id_carga int identity(1,1),
descripcion varchar(200),
Peso decimal (7,2),
id_tipo_carga int,
patente varchar(15)
constraint pk_carga primary key(id_carga),
constraint fk_tipo_carga foreign key (id_tipo_carga) references tipos_cargas(id_tipo_carga),
constraint fk_carga_patente foreign key (patente) references camiones(patente),
)




--lista de tipo cargas para Combo Box
create Proc SP_ListTipoCargas
as
begin
select * from tipos_cargas
end


--topop de cargas
insert into tipos_cargas(nombre)
		values ('Packing'),('Bidon'),('Caja suelta')



-- insert Camion
create proc SP_CREAR_CAMION
@patente varchar(20),
@cargaMax int

as
begin
insert into Camiones(patente, cargaMax, carga, Estado )
		values (@patente, @cargaMax, 0, 0) 
end
go

--Lista camiones para comboBox
create proc SP_SELECT_CAMIONES

as
begin
select * from camiones
end
go

--Informacion del cambion
create proc SP_CAMION
@Patente varchar(20)
as
begin
select * from camiones
where patente = @patente
end
go


--Creacion de la carga, devuelve su id para insertar tabla intermedia del camion  en transaccion
CREATE PROCEDURE SP_CREAR_CARGA
    @descripcion VARCHAR(200),
    @peso DECIMAL(8,2),
    @id_tipo_carga INT,
	@patente varchar(15)
AS
BEGIN
    INSERT INTO cargas (descripcion, peso, id_tipo_carga, patente)
    VALUES (@descripcion, @peso, @id_tipo_carga, @patente);

    SELECT SCOPE_IDENTITY() AS id;
END;
go
drop proc SP_CREAR_CARGA
-- insert tabla intermedia camion-carga
create proc SP_CREAR_CAMIONCARGA
@patente varchar(15),
@idCarga int
as
begin
insert into camiones_cargas(patente, id_carga)
		values(@patente, @idCarga)
end
go
drop proc SP_CREAR_CAMIONCARGA
--Informacion de carga, con camion peso, y tipo de carga. 
create proc SP_BUSCAR_CARGAS_DEL_CAMION
@Patente varchar(20)
as
begin
select c.id_carga, c.descripcion, c.id_tipo_carga, c.Peso, tc.nombre
from  cargas c
join camiones ca on ca.patente = c.patente
join tipos_cargas tc on tc.id_tipo_carga =c.id_tipo_carga
where ca.patente = @patente

end
go

create proc SP_CAMBIAR_ESTADO
@Patente varchar(15)
as
begin
update camiones 
	set Estado = 1
	where patente = @patente
end
	select * from camiones