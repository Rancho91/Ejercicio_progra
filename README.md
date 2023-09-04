# ejercicio_1_6

Script Base de datos

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
constraint pk_carga primary key(id_carga),
constraint fk_tipo_carga foreign key (id_tipo_carga) references tipos_cargas(id_tipo_carga)
)

CREATE TABLE camiones_cargas (
    patente VARCHAR(15),
    id_carga INT,
    CONSTRAINT pk_camiones_cargas PRIMARY KEY (patente, id_carga),
    CONSTRAINT fk_camiones FOREIGN KEY (patente) REFERENCES camiones(patente),
    CONSTRAINT fk_cargas FOREIGN KEY (id_carga) REFERENCES cargas(id_carga)
);


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


--Lista camiones para comboBox
create proc SP_SELECT_CAMIONES

as
begin
select * from camiones
end


--Informacion del cambion
create proc SP_CAMION
@Patente varchar(20)
as
begin
select * from camiones
where patente = @patente
end



--Creacion de la carga, devuelve su id para insertar tabla intermedia del camion  en transaccion
CREATE PROCEDURE SP_CREAR_CARGA
    @descripcion VARCHAR(200),
    @peso DECIMAL(8,2),
    @id_tipo_carga INT
AS
BEGIN
    INSERT INTO cargas (descripcion, peso, id_tipo_carga)
    VALUES (@descripcion, @peso, @id_tipo_carga);

    SELECT SCOPE_IDENTITY() AS id;
END;


-- insert tabla intermedia camion-carga
create proc SP_CREAR_CAMIONCARGA
@patente varchar(15),
@idCarga int
as
begin
insert into camiones_cargas(patente, id_carga)
		values(@patente, @idCarga)
end


--Informacion de carga, con camion peso, y tipo de carga. 
create proc SP_BUSCAR_CARGAS_DEL_CAMION
@Patente varchar(20)
as
begin
select c.id_carga, c.descripcion, c.id_tipo_carga, c.Peso, tc.nombre
from camiones_cargas CC
join cargas c on CC.id_carga =c.id_carga
join tipos_cargas tc on tc.id_tipo_carga =c.id_tipo_carga
where patente = @patente

end

drop proc SP_BUSCAR_CARGAS_DEL_CAMION
