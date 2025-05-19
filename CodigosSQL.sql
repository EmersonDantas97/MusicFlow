use MusicFlow;

create table Evento 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	DataCadastro datetime not null,
	DataEvento date not null,
	HoraEvento time, -- Pode não ser descrita a hora.
	Observacao varchar(500),
	Status char,
	constraint pk_Evento primary key (Id)
);

create table Musica 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	Interprete int,
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
	constraint pk_Musica primary key (Id)
);

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

create table Funcao 
(
	Id int identity(1,1),
	Nome varchar(100) not null,
	DataCadastro datetime not null,
	Status char not null,
	constraint pk_Funcao primary key (Id)
);

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

create table EventoSetlist 
(
	Id int identity(1,1),
	IdEvento int not null,
	IdMusica int not null,
	constraint pk_EventoSetlist primary key (Id),
	Foreign key (IdEvento) references Evento(Id),
	Foreign key (IdMusica) references Musica(Id)
);
create table EventoBanda
(
	Id int identity(1,1),
	IdEvento int not null,
	IdMusico int not null,
	constraint pk_EventoBanda primary key (Id),
	Foreign key (IdEvento) references Evento(Id),
	Foreign key (IdMusico) references IntegranteBanda(Id)
);


drop table Evento;
drop table IntegranteBanda;
drop table Musica;
drop table Funcao;
drop table MusicoFuncao;
drop table EventoSetlist;
drop table EventoBanda;



