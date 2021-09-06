# Sistema de Chamados
Um Sistema desenvolvido em C# com scripts de SQL para cadastrar, editar, excluir e pesquisar chamados em um Banco de Dados.

## Requisitos
Para compilar este programa é necessário o Visula Studio 2019 com o .NET Framework 4.7.2

Para a utilização deste programa é necessário um servidor SQL, sendo necessário tambem executar os seguintes scripts dentro da pasta "ServidorSQL" dentro do servidor para criar o banco de dados, as tabelas e os procedimentos armazenados.

* CriarDB.sql
* Inserir.sql
* Deletar.sql
* Atualiza.sql
* Pesquisa.sql

Para alterar o endereço do servidor edite em *App.config* o parametro `connectionString=`, e em *Global.cs* a variavel `DBserver`
