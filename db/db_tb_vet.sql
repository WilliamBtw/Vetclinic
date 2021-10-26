use vet
go
create table Gender
(
	IdGender nvarchar(3) primary key not null,
	NameGender nvarchar(60) not null
)
go
create table [Role]
(
	IdRole int identity(1,1) primary key not null,
	RoleName nvarchar(255) not null
)
go
create table [Position]
(
	IdPosition int identity(1,1) primary key not null,
	PositionName nvarchar(255) not null
)
create table [User]
(
	IdUser int identity(1,1) primary key not null,
	FirstName nvarchar(255) not null,
	LastName nvarchar(255) not null,
	Patronymic nvarchar (255) null,
	Birthday date not null,
	Email nvarchar(255) null,
	[Address] nvarchar(max) not null,
	PassportNumber nchar(4) not null,
	PassportSeries NCHAR(6) not null,
	Gender nvarchar(3) not null,
	foreign key(Gender) references Gender(IdGender)
)
go
create table Auth 
(
	IdAuth int identity(1,1) primary key not null,
	IdUser int not null,
	[Login] nvarchar(255) not null,
	[Password] nvarchar (255)  not null,
	foreign key(IdUser)  references [User](IdUser)
)
go
create table Client
(
	IdClient int identity(1,1) primary key not null,
	IdUser int not null,
	foreign key (IdUser) references [User](IdUser)
)
go
create table TypePet
(
	IdTypePet int identity(1,1) primary key not null,
	NameTypePet nvarchar(255) not null
)
create table Pet
(
	IdPet int identity (1,1) primary key not null,
	IdTypePet int not null,
	NamePet nvarchar(255) not null,
	IdGender nvarchar(3) not null,
	Birthday date null,
	foreign key (IdTypePet) references TypePet(IdTypePet),
	foreign Key (IdGender) references Gender(IdGender)
)
go
Create table Staff
(
	IdStaff int Identity(1,1) primary key not null,
	IdUser Int not null,
	IdRole int not null,
	IdPosition int not null,
	foreign key (IdUser) references [User](IdUser),
	foreign key (IdRole) references [Role](IdRole),
	foreign key (IdPosition) references Position(IdPosition)
)
go
create table VetClinic
(
	IdVetClinic int identity(1,1) primary key not null,
	NameDepartment nvarchar(max) not null,
	[Address] nvarchar(max) not null
)
go
create table Cabinet
(
	IdCabinet int identity(1,1) primary key not null,
	NameCabinet nvarchar(255) not null,
	NumberCabinet int not null,
	IdStaff int null,
	IdVetClinic int not null,
	Foreign Key (IdStaff) references Staff(IdStaff),
	foreign key (IdVetClinic) references VetClinic(IdVetClinic)
)
go
create table MedicalCard
(
	IdMedicalCard int identity(1,1) primary key not null,
	IdClient int not null,
	IdPet int not null,
	foreign key (IdClient) references Client(IdClient),
	foreign key (IdPet) references Pet(IdPet)
)
go
create table Diagnosis
(
	IdDiagnosis int identity(1,1) primary key not null,
	NameDIagnosis nvarchar(255) not null,
	CodeDiagnosis nvarchar(6) null,
	[DescriptionDIagnosis] nvarchar(max) null
)
go
create table [Procedure]
(
	IdProcedure int identity(1,1) primary key not null,
	NameProcedure nvarchar(255) not null,
	Cost decimal(10,2) not null,
	IdCabinet int not null,
	DurationInSeconds int null,
	foreign key (IdCabinet) references Cabinet(IdCabinet)
)
go
create table MedicalExamination
(
	IdMedicalExamination int identity(1,1) PRIMARY KEY NOT NULL,
	IdDiagnosis int null,
	IdProcedure int null,
	IdCabinet int not null,
	IdStaff int not null,
	DateTimeMedicalExamination datetime not null,
	DateTimeStartProcedure datetime null,
	DateTimeEndProcedure datetime null,
	foreign key (IdDiagnosis) references Diagnosis(IdDiagnosis),
	foreign key (IdProcedure) references [Procedure](IdProcedure),
	foreign key (IdCabinet) references Cabinet(IdCabinet),
	foreign key (IdStaff) references Staff (IdStaff)
)