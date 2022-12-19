using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Policy;
using academia.Class;

namespace academia.DAO
{
    public class AlunoDAO
    {
        Conexao conec = new Conexao();

        public DataTable listarAlunos()
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail', peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro, cidade AS Cidade, estado AS Estado FROM aluno";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAlunos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAlunos);
            conexao.Close();
            return tabelaAlunos;
        }

        public DataTable listarAlunosEspecificos(int id)
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT ALUNO.IDALUNO AS 'ID', ALUNO.NOME AS 'Nome', ALUNO.CPF AS 'CPF' FROM ALUNO JOIN PARTICIPANTE ON PARTICIPANTE.ID_ALUNO = ALUNO.IDALUNO WHERE PARTICIPANTE.ID_AULA = @id";
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaAlunos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaAlunos);
            conexao.Close();
            return tabelaAlunos;
        }
    }
}
