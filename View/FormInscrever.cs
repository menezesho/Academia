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
        int idProfessor = 0;

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

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            cbAula.SelectedIndex = 0;
        }

        private void btInscrever_Click(object sender, EventArgs e)
        {//btInscrever
            if(mtbData.Text == "" || tbHora.Text == "" || tbProfessor.Text == "")
                MessageBox.Show("Nenhuma aula foi selecionada!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                    string sqlVerificaDuplicidade = @"SELECT * FROM participante WHERE id_aula = @idaula AND id_aluno = @idaluno";
                    SqlCommand cmdVerificaDuplicidade = new SqlCommand(sqlVerificaDuplicidade, cn);

                    cmdVerificaDuplicidade.Parameters.AddWithValue("@idaluno", id);
                    cmdVerificaDuplicidade.Parameters.AddWithValue("@idaula", idAula);

                    cn.Open();
                    SqlDataReader dataVerificaDuplicidade = cmdVerificaDuplicidade.ExecuteReader();
                    if (dataVerificaDuplicidade.Read())
                    {
                        MessageBox.Show("Já inscrito nesta aula!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cn.Close();
                    }
                    else
                    {
                        cn.Close();
                        string sqlVerificaIdProfessor = @"SELECT id_professor AS 'ID_PROFESSOR' FROM aula WHERE idaula = @idaula;";
                        SqlCommand cmdVerificaIdProfessor = new SqlCommand(sqlVerificaIdProfessor, cn);

                        cmdVerificaIdProfessor.Parameters.AddWithValue("@idaula", idAula);

                        cn.Open();
                        SqlDataReader dataVerificaIdProfessor = cmdVerificaIdProfessor.ExecuteReader();
                        if (dataVerificaIdProfessor.Read())
                        {
                            idProfessor = (int)dataVerificaIdProfessor["ID_PROFESSOR"];

                            cn.Close();
                            string sqlInsert = "";
                            sqlInsert = @"INSERT INTO participante (id_aula, id_aluno, id_professor) VALUES (@idaula, @idaluno, @idprofessor);
                            UPDATE aula SET contador =";
                            if (testeContador == "")
                                sqlInsert = sqlInsert + " NULL WHERE idaula = @idaula;";
                            else
                                sqlInsert = sqlInsert + " @contador WHERE idaula = @idaula;";

                            SqlCommand cmdInsert = new SqlCommand(sqlInsert, cn);

                            cmdInsert.Parameters.AddWithValue("@idaula", idAula);
                            cmdInsert.Parameters.AddWithValue("@idaluno", id);
                            cmdInsert.Parameters.AddWithValue("@idprofessor", idProfessor);
                            cmdInsert.Parameters.AddWithValue("@contador", contador + 1);

                            cn.Open();
                            cmdInsert.CommandText = sqlInsert;
                            cmdInsert.ExecuteNonQuery();
                            cn.Close();

                            MessageBox.Show("Inscrição realizada com sucesso!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbAula.DataSource = null;
                            cbAula.Items.Add("Selecione");
                            cbAula.SelectedIndex = 0;
                            tbProfessor.Clear();
                            mtbData.Clear();
                            tbHora.Clear();
                        }
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
                if (cbAula.DataSource != null)
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                        string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', contador AS 'Contador', professor.nome AS 'Professor'
                        FROM aula INNER JOIN professor ON professor.idprofessor = aula.id_professor WHERE idaula = @idaula";
                        SqlCommand cmd = new SqlCommand(sql, cn);

                        idAula = int.Parse(cbAula.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@idaula", idAula);

                        cn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        SqlDataReader data = cmd.ExecuteReader();
                        if (data.Read())
                        {
                            tbProfessor.Text = data["Professor"].ToString();
                            mtbData.Text = data["Data"].ToString();
                            tbHora.Text = data["Horário"].ToString();
                            testeContador = data["Contador"].ToString();
                            if (testeContador != "")
                                contador = int.Parse(testeContador);
                        }
                        cn.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbAula_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                string sqlSelect = @"SELECT * FROM AULA WHERE (CONTADOR < TOTAL) OR TOTAL IS NULL;";
                SqlCommand cmdSelect = new SqlCommand(sqlSelect, cn);

                cn.Open();
                SqlDataReader data = cmdSelect.ExecuteReader();
                if (data.Read())
                {
                    cbAula.DataSource = aulaDAO.listarAulasDisponiveis();
                    cbAula.ValueMember = "ID";
                    cbAula.DisplayMember = "Nome";
                    carregouForm = true;
                }
                else
                    MessageBox.Show("Nenhuma aula está disponível para inscrições no momento!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Retornar

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            Close();
        }

        private void FormInscreverAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                Close();
        }

        #endregion

    }
}
