CREATE PROCEDURE PesquisaCadastro
	@busca nvarchar(255)
	AS
		SELECT 
			ChamadoID, titulo, sistema, situacao, UsuarioID, dia, atualizacao, descricao
		FROM 
			chamados 
		WHERE
			titulo LIKE @busca
		OR 
			sistema LIKE @busca
		OR 
			situacao LIKE @busca
	GO

CREATE PROCEDURE PesquisaUsuario
		@busca nvarchar(255)
	AS
		SELECT 
			UsuarioID, nome, email, setor, cadastro
		FROM 
			usuarios 
		WHERE 
			nome LIKE @busca
		OR 
			email LIKE @busca
		OR 
			setor LIKE @busca
	GO