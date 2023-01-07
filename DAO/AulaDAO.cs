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
            string sql = @"SELECT idaula AS 'ID', nome as 'Nome'
                FROM aula
                WHERE contador < total OR total IS NULL;";
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
            string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', pr.nome AS 'Professor', aula.dia AS 'Data', aula.hora AS 'Horário', aula.total AS 'Max. Alunos', aula.contador AS 'Contador'
                FROM aula INNER JOIN participante AS 'pa' ON p.id_aula = aula.idaula
                INNER JOIN professor AS 'pr' ON pr.idprofessor = aula.id_professor
                WHERE pa.id_aluno = @id;";
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
            string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', aula.total AS 'Máx. Alunos', aula.contador AS 'Contador', p.nome AS 'Professor'
                FROM aula INNER JOIN professor AS p ON aula.id_professor = p.idprofessor
                WHERE id_professor = @id;";
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
