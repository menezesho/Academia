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
    public partial class FormEditarAula : Form
    {
        Conexao conec = new Conexao();
        AulaDAO aulaDAO = new AulaDAO();
        int id = 0;
        int contador = 0;
        int idAula = 0;
        int totalAtual = 0;

        public FormEditarAula()
        {
            InitializeComponent();
        }

        public FormEditarAula(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormEditarAula_Load(object sender, EventArgs e)
        {
            dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);

            dgaulas.Columns["ID"].Width = 40;
            dgaulas.Columns["Aula"].Width = 200;
            dgaulas.Columns["Data"].Width = 90;
            dgaulas.Columns["Horário"].Width = 40;
            dgaulas.Columns["Total"].Width = 200;
            dgaulas.Columns["Professor"].Width = 90;
            dgaulas.Columns["Contador"].Visible = false;

            idAula = 0;
            tbNome.Clear();
            mtbTotal.Clear();
            cbHora.SelectedIndex = 0;

            tbNome.Enabled = false;
            mtbTotal.Enabled = false;
            dtpData.Enabled = false;
            cbHora.Enabled = false;

            tbBusca.Clear();

            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
        }

        private void dgaulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            idAula = int.Parse(dgaulas.CurrentRow.Cells[0].Value.ToString());
            tbNome.Text = dgaulas.CurrentRow.Cells[1].Value.ToString();
            dtpData.Text = dgaulas.CurrentRow.Cells[2].Value.ToString();
            cbHora.Text = dgaulas.CurrentRow.Cells[3].Value.ToString();
            mtbTotal.Text = dgaulas.CurrentRow.Cells[4].Value.ToString();
            if (dgaulas.CurrentRow.Cells[4].Value.ToString() != "")
                totalAtual = int.Parse(dgaulas.CurrentRow.Cells[4].Value.ToString());
            if (dgaulas.CurrentRow.Cells[5].Value.ToString() != "")
                contador = int.Parse(dgaulas.CurrentRow.Cells[5].Value.ToString());

            tbNome.Enabled = true;
            mtbTotal.Enabled = true;
            dtpData.Enabled = true;
            cbHora.Enabled = true;
        }

        private void lbLimparBusca_Click(object sender, EventArgs e)
        {//lbLimparBusca
            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);
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
                lbTipoFiltro.Text = "x Data";
        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {//lbBuscar
            if (cbFiltro.SelectedItem == null)
                MessageBox.Show("Selecione o filtro!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (tbBusca.Text == "" || tbBusca.Text == " Busca...")
                    MessageBox.Show("Nenhum dado foi digitado!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    { /*
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sql = "";
                        if (cbFiltro.SelectedIndex == 0)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE nome LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 1)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE cpf LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 2)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE email LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 3)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE usuario LIKE @busca ORDER BY nome";
                        }
                        SqlCommand comando = new SqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@busca", "%" + tbBusca.Text + "%");

                        conexao.Open();
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataSet resultado = new DataSet();
                        da.Fill(resultado);
                        dgaulas.DataSource = resultado.Tables[0];
                        conexao.Close();
                        */
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                idAula = 0;
                tbNome.Clear();
                mtbTotal.Clear();
                cbHora.SelectedIndex = 0;

                tbNome.Enabled = false;
                mtbTotal.Enabled = false;
                dtpData.Enabled = false;
                cbHora.Enabled = false;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (idAula == 0)
                MessageBox.Show("Nenhuma aula foi selecionada, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Deseja mesmo excluir esta aula?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM aula WHERE idaula=@idaula";
                        SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexao);

                        comandoDelete.Parameters.AddWithValue("@idaula", idAula);

                        conexao.Open();
                        comandoDelete.CommandText = sqlDelete;
                        comandoDelete.ExecuteNonQuery();
                        conexao.Close();

                        MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);

                        idAula = 0;
                        tbNome.Clear();
                        mtbTotal.Clear();
                        cbHora.SelectedIndex = 0;

                        tbNome.Enabled = false;
                        mtbTotal.Enabled = false;
                        dtpData.Enabled = false;
                        cbHora.Enabled = false;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar
            if (idAula == 0)
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (tbNome.Text == "" || cbHora.SelectedIndex == 0)
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlUpdate = @"UPDATE aula SET nome=@nome, dia=@data, hora=@hora,";

                        if (mtbTotal.Text != "")
                        {
                            //contador = int.Parse(contador.ToString());
                            //sqlUpdate = sqlUpdate + "contador = @contador,";

                            if (contador <= int.Parse(mtbTotal.Text))
                            {
                                sqlUpdate = sqlUpdate + " total = " + int.Parse(mtbTotal.Text);
                            }
                            else
                            {
                                sqlUpdate = sqlUpdate + " total = " + totalAtual;
                                MessageBox.Show("O máximo de alunos informado não é válido, pois já existem " + contador + " inscritos!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            sqlUpdate = sqlUpdate + " total = NULL";
                        }
                        sqlUpdate = sqlUpdate + " WHERE idaula=@idaula";

                        SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                        comandoUpdate.Parameters.AddWithValue("@idaula", idAula);
                        comandoUpdate.Parameters.AddWithValue("@nome", tbNome.Text);
                        comandoUpdate.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                        comandoUpdate.Parameters.AddWithValue("@hora", cbHora.Text);
                        comandoUpdate.Parameters.AddWithValue("@contador", contador);

                        conexao.Open();
                        comandoUpdate.CommandText = sqlUpdate;
                        comandoUpdate.ExecuteNonQuery();
                        conexao.Close();
                        MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);

                        idAula = 0;
                        tbNome.Clear();
                        mtbTotal.Clear();
                        cbHora.SelectedIndex = 0;

                        tbNome.Enabled = false;
                        mtbTotal.Enabled = false;
                        dtpData.Enabled = false;
                        cbHora.Enabled = false;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region Retornar

        private void FormListAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
