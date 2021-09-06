using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaChamados.SQLManagment
{
    public class Insert
    {
        // Função para adicionar os usuarios
        public static void Usuario(string nome, string email, string setor)
        {
            using (SqlConnection dbcon = new SqlConnection(Global.DBserver)) 
            {
                using (SqlCommand dbcmd = new SqlCommand(Global.InsertDB2, dbcon))
                {
                    // Definir tipo de comando para procedure
                    dbcmd.CommandType = CommandType.StoredProcedure;
                    // Adicionar parametros
                    dbcmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    dbcmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    dbcmd.Parameters.Add("@setor", SqlDbType.VarChar).Value = setor;
                    // Abrir o servidor e executar o comando
                    dbcon.Open();
                    dbcmd.ExecuteNonQuery();
                }
            }
        }
        // Função para adicionar as ocorrencias
        public static void Chamado(string titulo, string sistema, string situacao, int usrID, string descricao)
        {
            using(SqlConnection dbcon = new SqlConnection(Global.DBserver)) 
            {
                using (SqlCommand dbcmd = new SqlCommand(Global.InsertDB1, dbcon))
                {
                    // Definir tipo de comando para procedure
                    dbcmd.CommandType = CommandType.StoredProcedure;
                    // Adicionar parametros
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
