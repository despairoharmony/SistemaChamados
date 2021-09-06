using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaChamados.SQLManagment
{
    public class Delete
    {
        // Função para deletar os usuários
        public static void Usuario(int uid)
        {
            using (SqlConnection dbcon = new SqlConnection(Global.DBserver))
            {
                using (SqlCommand dbcmd = new SqlCommand(Global.DeleteDB2, dbcon))
                {
                    // Definir tipo de comando para procedure
                    dbcmd.CommandType = CommandType.StoredProcedure;
                    // Adicionar parametros
                    dbcmd.Parameters.Add("@usrID", SqlDbType.Int).Value = uid;
                    // Abrir o servidor e executar o comando
                    dbcon.Open();
                    dbcmd.ExecuteNonQuery();
                }
            }
        }
        // Função para deletar as ocorrencias
        public static void Chamado(int cid)
        {
            using (SqlConnection dbcon = new SqlConnection(Global.DBserver))
            {
                using (SqlCommand dbcmd = new SqlCommand(Global.DeleteDB1, dbcon))
                {
                    // Definir tipo de comando para procedure
                    dbcmd.CommandType = CommandType.StoredProcedure;
                    // Adicionar parametros
                    dbcmd.Parameters.Add("@chID", SqlDbType.Int).Value = cid;
                    // Abrir o servidor e executar o comando
                    dbcon.Open();
                    dbcmd.ExecuteNonQuery();
                }
            }
        }
    }
}
