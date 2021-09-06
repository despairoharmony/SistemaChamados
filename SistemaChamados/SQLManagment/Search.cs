using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaChamados.SQLManagment
{
    public class Search
    {
        // Função de busca para os usuarios
        public static void Usuario(DataGridView dataview, string busca)
        {
            // Adiconar % na string para a busca no servidor encontrar sentenças imcompletas
            busca = "%" + busca + "%";
            // Verificar se a string chegou vazia
            busca = (busca.Length == 2) ? "%" : busca;

            using (SqlConnection dbcon = new SqlConnection(Global.DBserver))
            {
                using (DataTable dt = new DataTable())
                {
                    dbcon.Open();
                    using (SqlCommand dbcmd = new SqlCommand(Global.SearchDB2, dbcon))
                    {
                        // Definir tipo de comando para procedure e adiconar o parametro
                        dbcmd.CommandType = CommandType.StoredProcedure;
                        dbcmd.Parameters.Add("@busca", SqlDbType.VarChar).Value = busca;
                        // Escrever os dados filtrados na tabela
                        using (SqlDataAdapter dbadapt = new SqlDataAdapter())
                        {
                            dbadapt.SelectCommand = dbcmd;
                            dbadapt.Fill(dt);
                            dataview.DataSource = dt;
                        }
                    }
                }
            }
        }
        // Função de busca para as ocorrencias
        public static void Chamado(DataGridView dataview, string busca)
        {
            // Adiconar % na string para a busca no servidor encontrar sentenças imcompletas
            busca = "%" + busca + "%";
            // Verificar se a string chegou vazia
            busca = (busca.Length == 2) ? "%" : busca;

            using (SqlConnection dbcon = new SqlConnection(Global.DBserver))
            {
                using (DataTable dt = new DataTable())
                {
                    dbcon.Open();
                    using (SqlCommand dbcmd = new SqlCommand(Global.SearchDB1, dbcon))
                    {
                        // Definir tipo de comando para procedure e adiconar o parametro
                        dbcmd.CommandType = CommandType.StoredProcedure;
                        dbcmd.Parameters.Add("@busca", SqlDbType.VarChar).Value = busca;
                        // Escrever os dados filtrados na tabela
                        using (SqlDataAdapter dbadapt = new SqlDataAdapter())
                        {
                            dbadapt.SelectCommand = dbcmd;
                            dbadapt.Fill(dt);
                            dataview.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
