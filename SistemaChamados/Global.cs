using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaChamados
{
    public static class Global
    {
        // Servidor SQL
        public const string DBserver = @"Server=localhost\SQLEXPRESS;Database=BaseOcorrencias;Trusted_Connection=True;";
        // Procedures dentro do servidor
        public const string InsertDB1 = "InserirCadastro";
        public const string InsertDB2 = "InserirUsuario";
        public const string DeleteDB1 = "DeletarCadastro";
        public const string DeleteDB2 = "DeletarUsuario";
        public const string UpdateDB1 = "AtualizaCadastro";
        public const string UpdateDB2 = "AtualizaUsuario";
        public const string SearchDB1 = "PesquisaCadastro";
        public const string SearchDB2 = "PesquisaUsuario";
        // Mensagens do sistema
        public const string MsgOcAdd = "Ocorrência cadastrada com sucesso.";
        public const string MsgUsrAdd = "Usuário cadastrado com sucesso.";
        public const string MsgOcEdit = "Selecione uma Ocorrência para editar.";
        public const string MsgUsrEdit = "Selecione um Usuário para editar.";
        public const string MsgOcDel = "Selecione uma Ocorrência para excluir.";
        public const string MsgUsrDel = "Selecione um Usuário para excluir.";
        public const string MsgNoUsr = "Não existe nenhum Usuário Cadastrado.";
        public const string MsgFinish = "Operação concluida com Sucesso";
        public const string MsgConfirm = "Confrimação";
        public const string MsgFill = "Há espaços em branco\nPreencha todos os espaços para seguir com a solicitação.";
        public const string MsgDelUsr1 = "Voce deseja apagar os dados de:\n";
        public const string MsgDelUsr2 = "\n\nIsso implicará na exclusão de todas as ocorrencias cadastradas neste usuário.";
        public const string MsgDelOc = "Você deseja apagar os dados da ocorrência:\n";
    }
}
