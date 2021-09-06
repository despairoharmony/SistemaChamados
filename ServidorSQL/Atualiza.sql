CREATE PROCEDURE AtualizaCadastro 
	@chID int,
	@titulo nvarchar(255),
	@sistema nvarchar(100),
	@situacao nvarchar(100),
	@usrID int,
	@descricao text
	AS
		UPDATE chamados
		SET
			titulo = @titulo, 
			sistema = @sistema, 
			situacao = @situacao, 
			UsuarioID = @usrID, 
			atualizacao = getdate(), 
			descricao = @descricao 
		WHERE ChamadoID = @chID
	GO

CREATE PROCEDURE AtualizaUsuario
	@usrID int,
	@nome nvarchar(255),
	@email nvarchar(255),
	@setor nvarchar(100)
	AS
		UPDATE usuarios
		SET
			nome = @nome, 
			email = @email, 
			setor = @setor 
		WHERE UsuarioID = @usrID
	GO