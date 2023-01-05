using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using academia.Class;

namespace academia.DAO
{
    public class AulaDAO
    {
        Conexao conec = new Conexao();

        public DataTable listarAulas()
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT idaula AS 'ID', nome AS 'Aula', dia AS Data, hora AS Horário, total AS 'Total', id_professor as 'Professor' FROM aula";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAulas = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAulas);
            conexao.Close();
            return tabelaAulas;
        }

        public DataTable listarAulasDisponiveis()
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT idaula AS 'ID', nome as 'Nome' FROM AULA WHERE CONTADOR < TOTAL OR TOTAL IS NULL;";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAulas = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAulas);
            conexao.Close();
            return tabelaAulas;
        }

        public DataTable listarAulasFiltradas(int id)
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = "EXEC P_FILTRAR_AULAS @id;";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAulas = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAulas);
            conexao.Close();
            return tabelaAulas;
        }

        public DataTable listarAulasProfessor(int id)
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT idaula AS 'ID', nome AS 'Aula', dia AS Data, hora AS Horário, total AS 'Total', contador AS 'Contador', id_professor as 'Professor' FROM aula WHERE id_professor = @id;";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAulas = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAulas);
            conexao.Close();
            return tabelaAulas;
        }
    }
}
