CREATE DATABASE BaseDeDatosII
go

use BaseDeDatosII
go


CREATE TABLE tblPersona(			
IdPersona					INT				PRIMARY KEY
,Cedula						INT				NULL
,Nombres					VARCHAR(50)		NOT NULL	
,Apellidos					VARCHAR(50)		NOT NULL	
,FechaNacimiento			DATE			NOT NULL	
,Sexo						CHAR(1)			NOT NULL		CHECK(Sexo IN('M','F'))
)

CREATE TABLE tblFamilia(	
IdFamilia					INT				PRIMARY KEY	
,Apellidos					CHAR(20)		NOT NULL	
)

CREATE TABLE tblHorario(		
IdHorario					INT				PRIMARY KEY	
,Tanda						CHAR(1)			NOT NULL	
,HoraInicio					TIME			NOT NULL	
,HoraFinal					TIME			NOT NULL	
)

CREATE TABLE tblAula(		
IdAula						INT				PRIMARY KEY	
,Codigo						CHAR(10)		NOT NULL	
,Tipo						CHAR(1)			NOT NULL	
)

CREATE TABLE tblAsignatura(	
IdAsignatura				INT				PRIMARY KEY	
,Nombre						CHAR(20)		NOT NULL	
,Codigo						CHAR(10)		NOT NULL	
,IdHorario					INT				NOT NULL		FOREIGN KEY	REFERENCES tblHorario(IdHorario)
,IdAula						INT				NOT NULL		FOREIGN KEY	REFERENCES tblAula(IdAula)
,IdMaestro					INT				NOT NULL		FOREIGN KEY	REFERENCES tblPersona(IdPersona)
)

CREATE TABLE tblGrado(		
IdGrado						INT				PRIMARY KEY	
--IdAula					CHAR(6)			NOT NULL	
,TipoGrado					CHAR(1)			NOT NULL		Check(TipoGrado in ('P','S')) --'p' = primaria y 's' = secundaria	
)

CREATE TABLE tblSeccion(			
IdSeccion					INT				PRIMARY KEY	
,Codigo						CHAR(1)			NOT NULL		CHECK(Codigo IN('A','B'))
,IdGrado					INT				NOT NULL		FOREIGN KEY REFERENCES tblGrado(IdGrado)
,IdMaestroEncargado			INT				NOT NULL		FOREIGN KEY REFERENCES tblPersona(IdPersona)
)

CREATE TABLE tblEstudianteH(			
IdEstudianteH				INT				PRIMARY KEY	
,IdTutor					INT				NOT NULL
,FechaRgistro				DATE			NOT NULL
,Estado						VARCHAR(1)		NOT NULL		Check(Estado in ('A', 'I', 'S')) -- 'A' = activo , 'I' = inactivo y 'S' = suspendido
,IdPersona					INT				NOT NULL		FOREIGN KEY	REFERENCES tblPersona(IdPersona)
,Idcurso					INT				NOT NULL		FOREIGN KEY	REFERENCES tblPersona(IdPersona)
,IdFamilia					INT				NOT NULL		FOREIGN KEY	REFERENCES tblFamilia(IdFamilia)
)
			
CREATE TABLE tblEstudianteD(			
IdEstudianteD				INT				PRIMARY KEY	
,ScholarYear				DATE			NOT NULL	
,IdSeccion					INT				NOT NULL		FOREIGN KEY	REFERENCES tblSeccion(IdSeccion)
)


