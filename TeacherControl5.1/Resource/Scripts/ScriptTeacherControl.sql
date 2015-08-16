CREATE DATABASE TeacherControlDB;
go
use TeacherControlDB;
go
 CREATE TABLE TiposUsuarios(
  IdTipoUsuario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  Descripcion NVARCHAR(50) NOT NULL
  );

go
CREATE TABLE Usuarios(
	IdUsuario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
	Clave NVARCHAR(50) NOT NULL,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios(IdTipoUsuario) NOT NULL,
	Estatus INT
);
go
 CREATE TABLE TiposDocumentos(
	IdTipoDocumento INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Descripcion NVARCHAR(100) NOT NULL
  );

 
  go
CREATE TABLE Estudiantes (
  IdEstudiante INT PRIMARY KEY FOREIGN KEY REFERENCES Usuarios(IdUsuario) NOT NULL,
  Matricula varchar(9) NOT NULL,
  Nombres NVARCHAR(100) NOT NULL,
  Apellidos NVARCHAR(100) NOT NULL,
  Genero int,
   IdTipoDocumento INT FOREIGN KEY REFERENCES TiposDocumentos(IdTipoDocumento) NOT NULL,
  Documento NVARCHAR(45),
  Email NVARCHAR(255) ,
  Telefono NVARCHAR(12) 
  );
 go
CREATE TABLE Profesores(
  IdProfesor INT PRIMARY KEY FOREIGN KEY REFERENCES Usuarios(IdUsuario) NOT NULL,
  Nombres NVARCHAR(100) NOT NULL,
  Apellidos NVARCHAR(100) NOT NULL,
  Genero int,
  Email NVARCHAR(255) ,
  Telefono nvarchar(12) ,
   IdTipoDocumento INT FOREIGN KEY REFERENCES TiposDocumentos(IdTipoDocumento) NOT NULL,
  Documento NVARCHAR(45)
 );

 go

  CREATE TABLE Semestres (
  IdSemestre int identity(1,1) primary key not null,
  Periodo NVARCHAR(6) NULL,
  Descripcion NVARCHAR(50) NOT NULL,
  Fechainicio DATE NOT NULL,
  Fechafin DATE NOT NULL,
  IdProfesor INT FOREIGN KEY REFERENCES Profesores(IdProfesor) NOT NULL,
  );
    go
CREATE TABLE Asignaturas (
  IdAsignatura int identity(1,1) primary key not null,
  CodigoAsignatura VARCHAR(7)  NULL,
  Descripcion VARCHAR(100) NOT NULL,
  Creditos INT NULL,
  IdProfesor INT FOREIGN KEY REFERENCES Profesores(IdProfesor) NOT NULL,

 );
  go

CREATE TABLE Grupos (
  IdGrupo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdSemestre int FOREIGN KEY REFERENCES Semestres(IdSemestre) NOT NULL,
  IdAsignatura int FOREIGN KEY REFERENCES Asignaturas(IdAsignatura) NOT NULL,
  IdProfesor INT FOREIGN KEY REFERENCES Profesores(IdProfesor) NOT NULL,
  Estatus int NULL --'Abierto','Cerrado','Terminado'
  );
  go
   CREATE TABLE DiasSemana(
  IdDia INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  Descripcion NVARCHAR(50) NOT NULL
  );
  go

  CREATE TABLE Horarios (
  IdHorario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdGrupo INT  FOREIGN KEY REFERENCES Grupos(IdGrupo)NOT NULL,
  IdDia INT FOREIGN KEY REFERENCES DiasSemana(IdDia) NOT NULL,
  HoraInicio NVARCHAR(5) NOT NULL,
  HoraFin NVARCHAR(5) NOT NULL,
  );
 
  go
  CREATE TABLE Inscripciones (
  IdInscripcion INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
   IdEstudiante INT FOREIGN KEY REFERENCES Estudiantes(IdEstudiante) NOT NULL,
   IdGrupo INT FOREIGN KEY REFERENCES Grupos(IdGrupo) NOT NULL,
   Estatus  int NULL --DEFAULT 'Inscrito' 'Inscrito','Retirado'
  );
  go
  CREATE TABLE TiposEvaluaciones (
  IdTipoEvaluacion INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  Descripcion NVARCHAR(50) NOT NULL,
  IdProfesor INT FOREIGN KEY REFERENCES Profesores(IdProfesor) NOT NULL,
  Estatus int NOT NULL 
  );
  go

  CREATE TABLE EvaluacionesGrupos (
  IdEvaluacionGrupo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdGrupo INT FOREIGN KEY REFERENCES Grupos(IdGrupo) NOT NULL,
  IdTipoEvaluacion INT FOREIGN KEY REFERENCES TiposEvaluaciones(IdTipoEvaluacion) NOT NULL,
  CantidadEvaluaciones INT
  );
  go

  CREATE TABLE EvaluacionesGruposDetalle (
	IdEvaluacionesDetalle INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdEvaluacionGrupo INT FOREIGN KEY REFERENCES EvaluacionesGrupos(IdEvaluacionGrupo) NOT NULL,
	Descripcion NVARCHAR(45),
	TipoAsignacion int,
	FechaAsignacion DATE NOT NULL,
	FechaEntrega DATE NOT NULL,
	PoderacionEvaluacion INT , 
	Estatus int NOT NULL 
  );
  go

  CREATE TABLE CalificacionesEstudiantes (
  IdCalificacion INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  IdEvaluacionesDetalle INT FOREIGN KEY REFERENCES EvaluacionesGruposDetalle(IdEvaluacionesDetalle) NOT NULL,
  IdEstudiante INT FOREIGN KEY REFERENCES Estudiantes(IdEstudiante) NOT NULL,
  Calificacion FLOAT,
  FechaEntregada DATE, 
  Enlace1 NVARCHAR(255),
  Enlace2 NVARCHAR(255),
   PuedenCalificar bit
  );
go
create table CalificacionesCompaneros(
IdCalificacionCompanero int identity(1,1) primary key not null,
IdCalificacion int foreign key references CalificacionesEstudiantes(IdCalificacion),
IdEstudianteC int foreign key references Estudiantes(IdEstudiante),
Calificacion FLOAT,
Observacion nvarchar(140)
)
  
  go
insert into  TiposUsuarios(Descripcion)values('Administrador');
insert into  TiposUsuarios(Descripcion)values('Profesor');
insert into  TiposUsuarios(Descripcion)values('Estudiante');
go
insert into TiposDocumentos(Descripcion)values('Cedula');
insert into TiposDocumentos(Descripcion)values('Pasaporte');
insert into TiposDocumentos(Descripcion)values('Ninguno');
go
insert into DiasSemana(Descripcion)values('Lunes')
insert into DiasSemana(Descripcion)values('Martes')
insert into DiasSemana(Descripcion)values('Miercoles')
insert into DiasSemana(Descripcion)values('Jueves')
insert into DiasSemana(Descripcion)values('Viernes')
insert into DiasSemana(Descripcion)values('Sábado')
insert into DiasSemana(Descripcion)values('Domingo')