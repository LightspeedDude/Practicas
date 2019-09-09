use BaseDeDatosI
go

Crear un campo 
Alter table tblPersona
Add Phonenumber int;

Eliminacion de un campo
Alter table tblPersona
Drop Column Phone number;

Select * from tblPersona

Insertar datos 
Insert into tblAula values (1,'AJ201','T') -Teoria
Insert into tblAula values (2,'FD303','L') -Lab

Borrar un registro con una condicion
Delete from tblAula where Codigo = 'AJ201'

Update tblAula set Codigo = 'FD301' where Tipo = 'L'

Delete from tblAula

Drop table tblGrado

Select * from tblAula

