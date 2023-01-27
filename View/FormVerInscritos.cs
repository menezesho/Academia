using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class FormVerInscritos : Form
    {
        Conexao conec = new Conexao();
        AulaDAO aulaDAO = new AulaDAO();
        AlunoDAO alunoDAO = new AlunoDAO();
        bool carregouForm = false;
        int id = 0;
        int idAula = 0;

        public FormVerInscritos()
        {
            InitializeComponent();
        }

        public FormVerInscritos(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormVerInscritos_Load(object sender, EventArgs e)
        {
            cbAula.SelectedIndex = 0;
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
                        string sqlSelectAula = @"SELECT dia AS 'Data', hora AS 'Horário' FROM aula WHERE idaula = @idaula";
                        SqlCommand cmdSelectAula = new SqlCommand(sqlSelectAula, cn);

                        idAula = int.Parse(cbAula.SelectedValue.ToString());
                        cmdSelectAula.Parameters.AddWithValue("@idaula", idAula);

                        cn.Open();
                        cmdSelectAula.CommandText = sqlSelectAula;
                        cmdSelectAula.ExecuteNonQuery();
                        SqlDataReader dataSelectAula = cmdSelectAula.ExecuteReader();
                        if (dataSelectAula.Read())
                        {
                            mtbData.Text = dataSelectAula["Data"].ToString();
                            tbHora.Text = dataSelectAula["Horário"].ToString();

                            cn.Close();

                            string sqlSelectAlunos = @"SELECT aluno.idaluno AS 'ID', aluno.nome AS 'Nome', aluno.cpf AS 'CPF', aluno.email AS 'E-mail', aluno.usuario AS 'Usuário' FROM participante
                                INNER JOIN aluno ON participante.id_aluno = aluno.idaluno
                                WHERE participante.id_aula = @idaula;";
                            SqlCommand cmdSelectAlunos = new SqlCommand(sqlSelectAlunos, cn);

                            idAula = int.Parse(cbAula.SelectedValue.ToString());
                            cmdSelectAlunos.Parameters.AddWithValue("@idaula", cbAula.SelectedValue);

                            cn.Open();
                            cmdSelectAlunos.CommandText = sqlSelectAlunos;
                            cmdSelectAlunos.ExecuteNonQuery();
                            SqlDataReader dataSelectAlunos = cmdSelectAlunos.ExecuteReader();
                            if (dataSelectAlunos.Read())
                            {
                                dgalunos.DataSource = alunoDAO.listarAlunosEspecificos(idAula);

                                dgalunos.Columns["ID"].Width = 40;
                                dgalunos.Columns["Nome"].Width = 200;
                                dgalunos.Columns["CPF"].Width = 90;
                                dgalunos.Columns["E-mail"].Width = 150;
                                dgalunos.Columns["Usuário"].Width = 120;
                            }
                            else
                            {
                                dgalunos.DataSource = null;
                                cbAula.DataSource = null;
                                cbAula.Items.Add("Selecione");
                                cbAula.SelectedIndex = 0;
                                mtbData.Clear();
                                tbHora.Clear();
                                carregouForm = false;
                                MessageBox.Show("Não há alunos inscritos nesta aula!", "Inscritos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
                string sqlSelect = @"SELECT * FROM AULA WHERE ID_PROFESSOR = @id";
                SqlCommand cmdSelect = new SqlCommand(sqlSelect, cn);

                cmdSelect.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader data = cmdSelect.ExecuteReader();
                if (data.Read())
                {
                    cbAula.DataSource = aulaDAO.listarAulasProfessor(id);
                    cbAula.ValueMember = "ID";
                    cbAula.DisplayMember = "Aula";
                    carregouForm = true;
                }
                else
                    MessageBox.Show("Nenhuma aula foi criada!", "Inscritos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
