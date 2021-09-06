CREATE PROCEDURE DeletarCadastro
	@chID int
	AS
		DELETE FROM dbo.chamados WHERE ChamadoID = @chID
	GO

CREATE PROCEDURE DeletarUsuario
	@usrID int
	AS
		DELETE FROM dbo.usuarios WHERE UsuarioID = @usrID
		DELETE FROM dbo.chamados WHERE UsuarioID = @usrID 
	GO