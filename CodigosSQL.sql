use MusicFlow;

Create database MusicFlow;

/*drop database MusicFlow;*/

create table Evento 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	DataCadastro datetime not null,
	DataEvento date not null,
	HoraEvento time,
	Observacao varchar(500),
	Status char,
	constraint pk_Evento primary key (Id)
);

/*Drop table Evento;*/

create table Musica 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	VozPrincipal int not null,
	Versao varchar(100) not null,
	DataCadastro datetime,
	Observacao varchar(500),
	BPM int,
	Compasso varchar(10) not null,
	Tom varchar(5) not null,
	TemVS int not null,
	TomOriginal int not null,
	LinkVideo varchar(200), 
	LinkCifra varchar(200),
	Status char not null,
	constraint pk_Musica primary key (Id),
	Foreign key (VozPrincipal) references IntegranteBanda(Id),
);

/*Drop Table Musica;*/

create table IntegranteBanda 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	DataAniversario date not null,
	DataCadastro datetime not null,
	Fone varchar(15),
	Status char not null,
	constraint pk_IntegranteBanda primary key (Id)
);

/*Drop table IntegranteBanda;*/

create table Funcao 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	DataCadastro datetime not null,
	Status char not null,
	constraint pk_Funcao primary key (Id)
);

/*Drop Table Funcao;*/

-- Tabelas de Relacionamento

create table MusicoFuncao 
(
	Id int identity(1,1),
	IdFuncao int not null,
	IdMusico int not null,
	constraint pk_MusicoFuncao primary key (Id),
	Foreign key (IdFuncao) references Funcao(Id),
	Foreign key (IdMusico) references IntegranteBanda(Id)
);

/*Drop Table MusicoFuncao;*/

create table EventoSetlist 
(
	Id int identity(1,1),
	IdEvento int not null,
	IdMusica int not null,
	constraint pk_EventoSetlist primary key (Id),
	Foreign key (IdEvento) references Evento(Id),
	Foreign key (IdMusica) references Musica(Id)
);

/*Drop Table EventoSetlist;*/

create table EventoBanda
(
	Id int identity(1,1),
	IdEvento int not null,
	IdMusico int not null,
	constraint pk_EventoBanda primary key (Id),
	Foreign key (IdEvento) references Evento(Id),
	Foreign key (IdMusico) references IntegranteBanda(Id)
);

/*Drop Table EventoBanda;*/