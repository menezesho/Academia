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
                    string sqlSelect = @"SELECT * FROM aula WHERE dia=@data AND hora=@hora";
                    SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                    comandoSelect.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                    comandoSelect.Parameters.AddWithValue("@hora", cbHora.Text);

                    conexao.Open();
                    SqlDataReader dados = comandoSelect.ExecuteReader();
                    if (dados.Read())
                    {
                        MessageBox.Show("Conflito de data e hora, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexao.Close();
                    }
                    else
                    {
                        conexao.Close();
                        SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                        string sqlInsert = "";
                        sqlInsert = "INSERT INTO aula (nome, dia, hora, id_professor";
                        SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                        if (mtbTotal.Text != "")
                            sqlInsert = sqlInsert + ", total) VALUES(@nome, @data, @hora, @idprofessor, @total)";
                        else
                            sqlInsert = sqlInsert + ") VALUES(@nome, @data, @hora, @idprofessor)";

                        comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text);
                        comandoInsert.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                        comandoInsert.Parameters.AddWithValue("@hora", cbHora.Text);
                        comandoInsert.Parameters.AddWithValue("@idprofessor", id);
                        comandoInsert.Parameters.AddWithValue("@total", mtbTotal.Text);

                        conexao2.Open();
                        comandoInsert.CommandText = sqlInsert;
                        comandoInsert.ExecuteNonQuery();
                        conexao2.Close();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', professor.nome AS 'Professor' FROM aula INNER JOIN professor
                        ON professor.idprofessor = aula.id_professor
                        WHERE idaula=@idaula";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    int idAula = int.Parse(cbAula.SelectedValue.ToString());
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
                cbAula.DataSource = aulaDAO.listarAulas();
                cbAula.ValueMember = "ID";
                cbAula.DisplayMember = "Aula";
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
