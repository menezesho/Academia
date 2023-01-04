using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace academia
{
    public partial class FormInscrever : Form
    {
        Conexao conec = new Conexao();
        AulaDAO aulaDAO = new AulaDAO();
        bool carregouForm = false;
        string nome = "";
        int id = 0;
        int idAula = 0;
        int contador = 0;
        string testeContador = "";

        public FormInscrever()
        {
            InitializeComponent();
        }

        public FormInscrever(int id, string nome)
        {
            InitializeComponent();
            this.id = id;
            this.nome = nome;
        }

        //public void tempoMsgBox()
        //{
        //    Thread.Sleep(TimeSpan.FromSeconds(1));
        //    SendKeys.SendWait("{ENTER}");
        //}

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            cbAula.SelectedIndex = 0;
        }

        private void btInscrever_Click(object sender, EventArgs e)
        {//btInscrever
            if(mtbData.Text == "" || tbHora.Text == "" || tbProfessor.Text == "")
                MessageBox.Show("Selecione a aula que deseja se inscrever!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sqlSelect = @"SELECT * FROM participante WHERE id_aula = @idaula AND id_aluno = @idaluno";
                    SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                    comandoSelect.Parameters.AddWithValue("@idaluno", id);
                    comandoSelect.Parameters.AddWithValue("@idaula", idAula);

                    conexao.Open();
                    SqlDataReader dados = comandoSelect.ExecuteReader();
                    if (dados.Read())
                    {
                        MessageBox.Show("Você já está inscrito nesta aula!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexao.Close();
                    }
                    else
                    {
                        conexao.Close();
                        SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                        string sqlInsert = "";
                        sqlInsert = @"INSERT INTO participante (id_aula, id_aluno) VALUES (@idaula, @idaluno);
                            UPDATE aula SET contador =";
                        if (testeContador == "")
                            sqlInsert = sqlInsert + " NULL WHERE idaula = @idaula;";
                        else
                            sqlInsert = sqlInsert + " @contador WHERE idaula = @idaula;";

                        SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                        comandoInsert.Parameters.AddWithValue("@idaula", idAula);
                        comandoInsert.Parameters.AddWithValue("@idaluno", id);
                        comandoInsert.Parameters.AddWithValue("@contador", contador + 1);

                        conexao2.Open();
                        comandoInsert.CommandText = sqlInsert;
                        comandoInsert.ExecuteNonQuery();
                        conexao2.Close();
                        MessageBox.Show("Inscrição realizada com sucesso!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            if (carregouForm)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', contador AS 'Contador', professor.nome AS 'Professor'
                        FROM aula INNER JOIN professor ON professor.idprofessor = aula.id_professor WHERE idaula=@idaula";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    idAula = int.Parse(cbAula.SelectedValue.ToString());
                    comando.Parameters.AddWithValue("@idaula", idAula);

                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        tbProfessor.Text = dados["Professor"].ToString();
                        mtbData.Text = dados["Data"].ToString();
                        tbHora.Text = dados["Horário"].ToString();
                        testeContador = dados["Contador"].ToString();
                        if (testeContador != "")
                            contador = int.Parse(testeContador);
                    }
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAula_Click(object sender, EventArgs e)
        {
            if (!carregouForm)
            {
                cbAula.DataSource = aulaDAO.listarAulasDisponiveis();
                cbAula.ValueMember = "ID";
                cbAula.DisplayMember = "Nome";
                carregouForm = true;
            }
        }

        #region Retornar

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void FormInscreverAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        #endregion

    }
}
