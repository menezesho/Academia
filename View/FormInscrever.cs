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
        AlunoDAO alunoDAO = new AlunoDAO();
        ProfessorDAO professorDAO = new ProfessorDAO();
        bool carregouForm = false;
        string selecionado = "";

        public FormInscrever()
        {
            InitializeComponent();
        }

        public void tempoMsgBox()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait("{ENTER}");
        }

            private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();

            cbNome.Enabled = false;
            cbAula.Enabled = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                carregouForm = false;

                cbNome.DataSource = null;
                cbNome.Items.Add("Selecione");
                cbNome.SelectedIndex = 0;
                mtbCpf.Clear();
                mtbCelular.Clear();

                cbAula.DataSource = null;
                cbAula.Items.Add("Selecione");
                cbAula.SelectedIndex = 0;
                mtbData.Clear();
                tbHora.Clear();

                cbNome.Enabled = false;
                cbAula.Enabled = false;
                selecionado = "";
                btAluno.BackColor = Color.FromArgb(68, 68, 68);
                btAluno.Height = 30;
                btProf.BackColor = Color.FromArgb(68, 68, 68);
                btProf.Height = 30;
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {//btInserir
            if (mtbCpf.Text == "" || tbHora.Text == "")
                MessageBox.Show("Preencha todos os campos!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (selecionado != "")
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlSelect = "";
                        if (selecionado == "aluno")
                            sqlSelect = @"SELECT * FROM participante WHERE id_aula=@idaula AND id_aluno=@idpessoa";
                        else
                            sqlSelect = @"SELECT * FROM participante WHERE id_aula=@idaula AND id_professor=@idpessoa";
                        SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                        comandoSelect.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));
                        comandoSelect.Parameters.AddWithValue("@idpessoa", int.Parse(cbNome.SelectedValue.ToString()));

                        conexao.Open();
                        SqlDataReader dados = comandoSelect.ExecuteReader();
                        if (dados.Read())
                        {
                            MessageBox.Show("'" + cbNome.Text + "' já está inscrito nesta aula!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                            string sqlInsert = "";
                            if (selecionado == "aluno")
                                sqlInsert = @"INSERT INTO participante (id_aula, id_aluno) VALUES (@idaula, @idpessoa)";
                            else
                                sqlInsert = @"INSERT INTO participante (id_aula, id_professor) VALUES (@idaula, @idpessoa)";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                            comandoInsert.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));
                            comandoInsert.Parameters.AddWithValue("@idpessoa", int.Parse(cbNome.SelectedValue.ToString()));

                            conexao2.Open();
                            comandoInsert.CommandText = sqlInsert;
                            comandoInsert.ExecuteNonQuery();
                            conexao2.Close();
                            MessageBox.Show("Concluído com sucesso\n'" + cbNome.Text + "' foi inserido na aula '" + cbAula.Text + "'!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Selecione uma das opções de inscrição!", "Inscrever", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed NOME
            if (carregouForm)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sql = "";
                    if (selecionado == "aluno")
                        sql = @"SELECT * FROM aluno WHERE idaluno=@idpessoa";
                    else
                        sql = @"SELECT * FROM professor WHERE idprofessor=@idpessoa";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idpessoa", int.Parse(cbNome.SelectedValue.ToString()));

                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        mtbCpf.Text = dados["cpf"].ToString();
                        mtbCelular.Text = dados["celular"].ToString();
                    }
                    conexao.Close();
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
                    string sql = "";
                    if (selecionado == "aluno") 
                        sql = @"SELECT * FROM aula WHERE idaula=@idaula";
                    else
                        sql = @"SELECT * FROM aula WHERE idaula=@idaula";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));

                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        mtbData.Text = dados["dia"].ToString();
                        tbHora.Text = dados["hora"].ToString();
                    }
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        #region Area do Aluno/Professor

        private void btAreaAluno_Click(object sender, EventArgs e)
        {//btAreaAluno
            btProf.BackColor = Color.FromArgb(68, 68, 68);
            btProf.Height = 30;
            btAluno.BackColor = Color.MediumSeaGreen;
            btAluno.Height = 35;
            selecionado = "aluno";

            cbNome.DataSource = alunoDAO.listarAlunos();
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "ID";

            cbAula.DataSource = aulaDAO.listarAulas();
            cbAula.DisplayMember = "Nome";
            cbAula.ValueMember = "ID";

            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();

            cbNome.Enabled = true;
            cbAula.Enabled = true;
            carregouForm = true;

            Thread msgBoxTemp = new Thread(new ThreadStart(tempoMsgBox));
            msgBoxTemp.Start();
            MessageBox.Show("Lista de cadastros atualizada!", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            msgBoxTemp.Abort();
        }

        private void btAreaProf_Click(object sender, EventArgs e)
        {//btAreaProf
            btAluno.BackColor = Color.FromArgb(68, 68, 68);
            btAluno.Height = 30;
            btProf.BackColor = Color.MediumSeaGreen;
            btProf.Height = 35;
            selecionado = "professor";

            cbNome.DataSource = professorDAO.listarProfs();
            cbNome.DisplayMember = "Nome";
            cbNome.ValueMember = "ID";

            cbAula.DataSource = aulaDAO.listarAulas();
            cbAula.DisplayMember = "Nome";
            cbAula.ValueMember = "ID";

            cbNome.Text = "Selecione";
            mtbCpf.Clear();
            mtbCelular.Clear();
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();

            cbNome.Enabled = true;
            cbAula.Enabled = true;
            carregouForm = true;

            Thread msgBoxTemp = new Thread(new ThreadStart(tempoMsgBox));
            msgBoxTemp.Start();
            MessageBox.Show("Lista de cadastros atualizada!", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            msgBoxTemp.Abort();
        }

        #endregion
    }
}
