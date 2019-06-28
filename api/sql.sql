create database banco
go 
use banco

create table paciente(
	cartao bigint constraint pk_cartao primary key identity(10000,1),
	nome varchar(30),
	dtNascimento date
);

create table medico(
	crm bigint constraint pk_crm primary key identity(1,1),
	nome varchar (30)
);

create table solicitacoes(
	id bigint constraint pk_id_solicitacoes primary key identity(1,1),
	cartao bigint constraint fk_cartao_paciente foreign key references paciente(cartao),
	crm bigint constraint fk_crm_medico foreign key  references medico(crm),
	dtAtendimento date default sysdatetime()
);

create table frequencias(
	id bigint constraint pk_id_frequencias primary key identity(1,1),
	solicitacoes bigint constraint fk_id_solicitacoes foreign key references solicitacoes(id),
	dtVerificacao date default sysdatetime(),
	batimentoCardiaco bigint,
	pressaoMaximo bigint,
	pressaoMinimo bigint,
	check (pressaoMaximo>pressaoMinimo),
	sintoma varchar(200),
	medicamento varchar(50)
);