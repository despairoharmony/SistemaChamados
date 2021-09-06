CREATE PROCEDURE InserirCadastro 
	@titulo nvarchar(255),
	@sistema nvarchar(100),
	@situacao nvarchar(100),
	@usrID int,
	@descricao text
	AS
		INSERT INTO chamados(
			titulo, 
			sistema, 
			situacao, 
			UsuarioID, 
			dia,
			atualizacao, 
			descricao) 
		VALUES(
			@titulo, 
			@sistema, 
			@situacao, 
			@usrID, 
			getdate(), 
			getdate(), 
			@descricao
		)
	GO

CREATE PROCEDURE InserirUsuario
	@nome nvarchar(255),
	@email nvarchar(255),
	@setor nvarchar(100)
	AS
		INSERT INTO usuarios(
			nome, 
			email, 
			setor, 
			cadastro) 
		VALUES(
			@nome, 
			@email, 
			@setor, 
			getdate()
		)
	GO