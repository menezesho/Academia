using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Policy;
using academia.Class;

namespace academia.DAO
{
    public class ProfessorDAO
    {
        Conexao conec = new Conexao();

        public DataTable listarProfs()
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT idprofessor AS 'ID', nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro, cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM professor";
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaProfs = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaProfs);
            conexao.Close();
            return tabelaProfs;
        }

        public DataTable listarProfsEspecificos(int id)
        {
            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
            string sql = @"SELECT PROFESSOR.IDPROFESSOR AS 'ID', PROFESSOR.NOME AS 'Nome', PROFESSOR.CPF AS 'CPF' FROM PROFESSOR JOIN PARTICIPANTE ON PARTICIPANTE.ID_PROFESSOR = PROFESSOR.IDPROFESSOR WHERE PARTICIPANTE.ID_AULA = @id";
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
