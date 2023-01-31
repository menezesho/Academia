using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void tempoMsgBox()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait("{ENTER}");
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
        {//cbAula click
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

        private void lbLimparBusca_Click(object sender, EventArgs e)
        {//lbLimparBusca
            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            dgalunos.DataSource = alunoDAO.listarAlunosEspecificos(idAula);
            lbBuscar.Focus();
        }

        private void lbTipoFiltro_Click(object sender, EventArgs e)
        {//lbTipoFiltro
            lbTipoFiltro.Text = "";
            cbFiltro.SelectedItem = null;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {//index change cbTipoFiltro
            if (cbFiltro.SelectedIndex == 0)
                lbTipoFiltro.Text = "x Nome";
            if (cbFiltro.SelectedIndex == 1)
                lbTipoFiltro.Text = "x CPF";
            if (cbFiltro.SelectedIndex == 2)
                lbTipoFiltro.Text = "x E-mail";
            if (cbFiltro.SelectedIndex == 3)
                lbTipoFiltro.Text = "x Usuário";
        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {//lbBuscar
            if (cbFiltro.SelectedItem == null)
                MessageBox.Show("Selecione o filtro!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (tbBusca.Text == "" || tbBusca.Text == " Busca...")
                    MessageBox.Show("Digite o que deseja buscar!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                        string sql = "";
                        if (cbFiltro.SelectedIndex == 0)
                        {
                            sql = @"SELECT aluno.idaluno AS 'ID', aluno.nome AS 'Nome', aluno.cpf AS 'CPF', aluno.email AS 'E-mail', aluno.usuario AS 'Usuário' FROM participante
                                INNER JOIN aluno ON participante.id_aluno = aluno.idaluno
                                WHERE participante.id_aula = @idaula AND nome LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 1)
                        {
                            sql = @"SELECT aluno.idaluno AS 'ID', aluno.nome AS 'Nome', aluno.cpf AS 'CPF', aluno.email AS 'E-mail', aluno.usuario AS 'Usuário' FROM participante
                                INNER JOIN aluno ON participante.id_aluno = aluno.idaluno
                                WHERE participante.id_aula = @idaula AND cpf LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 2)
                        {
                            sql = @"SELECT aluno.idaluno AS 'ID', aluno.nome AS 'Nome', aluno.cpf AS 'CPF', aluno.email AS 'E-mail', aluno.usuario AS 'Usuário' FROM participante
                                INNER JOIN aluno ON participante.id_aluno = aluno.idaluno
                                WHERE participante.id_aula = @idaula AND email LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 3)
                        {
                            sql = @"SELECT aluno.idaluno AS 'ID', aluno.nome AS 'Nome', aluno.cpf AS 'CPF', aluno.email AS 'E-mail', aluno.usuario AS 'Usuário' FROM participante
                                INNER JOIN aluno ON participante.id_aluno = aluno.idaluno
                                WHERE participante.id_aula = @idaula AND usuario LIKE @busca ORDER BY nome";
                        }
                        SqlCommand cmd = new SqlCommand(sql, cn);

                        cmd.Parameters.AddWithValue("@idaula", idAula);
                        cmd.Parameters.AddWithValue("@busca", "%" + tbBusca.Text + "%");

                        Thread click = new Thread(new ThreadStart(tempoMsgBox));
                        click.Start();
                        MessageBox.Show("Buscando...", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        click.Abort();

                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgalunos.DataSource = ds.Tables[0];
                        cn.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {//btRelatorio
            if (cbAula.DataSource != null)
            {
                if (MessageBox.Show("Deseja gerar um relatório de todos os alunos inscritos nesta aula?", "Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                    string endereco = "C:\\Sistemas\\academia\\Relatórios\\relatorio-alunos-aula.csv";
                    using (StreamWriter writer = new StreamWriter(endereco, false, Encoding.GetEncoding("iso-8859-15")))
                    {
                        writer.WriteLine("ID;Nome;CPF;E-mail;Usuário");
                        using (SqlConnection conn = new SqlConnection(conec.ConexaoBD()))
                        {
                            string query = "SELECT * FROM ALUNO INNER JOIN PARTICIPANTE ON PARTICIPANTE.ID_ALUNO = ALUNO.IDALUNO WHERE PARTICIPANTE.ID_AULA = @IDAULA;";
                            SqlCommand sqlComand = new SqlCommand(query, conn);
                            sqlComand.Parameters.AddWithValue("@idaula", idAula);
                            conn.Open();
                            using (IDataReader reader = sqlComand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    writer.WriteLine(Convert.ToString(reader["idaluno"]) + ";" +
                                        Convert.ToString(reader["nome"]) + ";" +
                                        Convert.ToString(reader["cpf"]) + ";" +
                                        Convert.ToString(reader["email"]) + ";" +
                                        Convert.ToString(reader["usuario"]));
                                }
                            }
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Relatório gerado com sucesso!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Nenhuma aula foi selecionada!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        #region Máscara - Busca

        private void tbBusca_Enter(object sender, EventArgs e)
        {
            if (tbBusca.Text == "" || tbBusca.Text == " Busca...")
            {
                tbBusca.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                tbBusca.Text = "";
            }
        }

        private void tbBusca_Leave(object sender, EventArgs e)
        {
            if (tbBusca.Text == "")
            {
                tbBusca.Text = " Busca...";
                tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            }
        }

        #endregion

    }
}
