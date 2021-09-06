  IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'BaseOcorrencias')
  BEGIN
	CREATE DATABASE BaseOcorrencias
END

GO

DROP TABLE IF EXISTS chamados
DROP TABLE IF EXISTS usuarios

USE BaseOcorrencias

BEGIN TRAN CRIAR_DB

	if not exists (select * from sysobjects where name='chamados' and xtype='U')
	BEGIN
		CREATE TABLE chamados(
			ChamadoID int identity(1,1) not null primary key,
			titulo varchar(255) not null,
			sistema varchar(100) not null,
			situacao varchar(100) not null,
			UsuarioID int not null,
			dia smalldatetime not null,
			atualizacao smalldatetime not null,
			descricao text not null,
		)
	END

	if not exists (select * from sysobjects where name='usuarios' and xtype='U')
	BEGIN
		CREATE TABLE usuarios(
			UsuarioID int identity(1,1) not null primary key,
			nome varchar(255) not null,
			email varchar(255) not null,
			setor varchar(100) not null,
			cadastro smalldatetime not null,
		)
	END

GO

COMMIT TRAN CRIAR_DB

GO