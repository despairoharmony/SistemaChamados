using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaChamados.SQLManagment
{
    public class Update
    {
        // Função para atualizar os usuários
        public static void Usuario(int usrID, string nome, string email, string setor)
        {
            using (SqlConnection dbcon = new SqlConnection(Global.DBserver))
            {
                using (SqlCommand dbcmd = new SqlCommand(Global.UpdateDB2, dbcon))
                {
                    // Definir tipo de comando para procedure
                    dbcmd.CommandType = CommandType.StoredProcedure;
                    // Adicionar parametros
                    dbcmd.Parameters.Add("@usrID", SqlDbType.Int).Value = usrID;
                    dbcmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    dbcmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    dbcmd.Parameters.Add("@setor", SqlDbType.VarChar).Value = setor;
                    // Abrir o servidor e executar o comando
                    dbcon.Open();
                    dbcmd.ExecuteNonQuery();
                }
            }
        }
        // Função para atualizar as ocorrencias
        public static void Chamado(int chID, string titulo, string sistema, string situacao, int usrID, string descricao)
        {
            using (SqlConnection dbcon = new SqlConnection(Global.DBserver))
            {
                using (SqlCommand dbcmd = new SqlCommand(Global.UpdateDB1, dbcon))
                {
                    // Definir tipo de comando para procedure
                    dbcmd.CommandType = CommandType.StoredProcedure;
                    // Adicionar parametros
                    dbcmd.Parameters.Add("@chID", SqlDbType.Int).Value = chID;
                    dbcmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
                    dbcmd.Parameters.Add("@sistema", SqlDbType.VarChar).Value = sistema;
                    dbcmd.Parameters.Add("@situacao", SqlDbType.VarChar).Value = situacao;
                    dbcmd.Parameters.Add("@usrID", SqlDbType.Int).Value = usrID;
                    dbcmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
                    // Abrir o servidor e executar o comando
                    dbcon.Open();
                    dbcmd.ExecuteNonQuery();
                }
            }
        }
    }
}
