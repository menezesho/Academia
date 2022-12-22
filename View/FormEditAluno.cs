using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormEditAluno : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();
        AlunoDAO alunoDAO = new AlunoDAO();
        int id = 0;

        public FormEditAluno()
        {
            InitializeComponent();
        }

        private void FormEditAluno_Load(object sender, EventArgs e)
        {
            dgalunos.DataSource = alunoDAO.listarAlunos();

            dgalunos.Columns["ID"].Width = 40;
            dgalunos.Columns["Nome"].Width = 200;
            dgalunos.Columns["CPF"].Width = 90;
            dgalunos.Columns["Idade"].Width = 40;
            dgalunos.Columns["Celular"].Width = 90;
            dgalunos.Columns["E-mail"].Width = 200;
            dgalunos.Columns["Peso(kg)"].Width = 60;
            dgalunos.Columns["Altura(cm)"].Width = 70;
            dgalunos.Columns["Rua"].Width = 160;
            dgalunos.Columns["Num."].Width = 40;
            dgalunos.Columns["Apto."].Width = 40;
            dgalunos.Columns["Bairro"].Width = 160;
            dgalunos.Columns["Cidade"].Width = 160;
            dgalunos.Columns["Estado"].Width = 50;
            dgalunos.Columns["Usuário"].Width = 100;
            dgalunos.Columns["Senha"].Visible = false;


            id = 0;
            tbNome.Clear();
            mtbCpf.Clear();
            mtbIdade.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            mtbPeso.Clear();
            mtbAltura.Clear();
            tbRua.Clear();
            mtbNumero.Clear();
            mtbApto.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedIndex = 0;
            tbUsuario.Clear();
            tbSenha.Clear();

            checkApto.Checked = false;

            tbBusca.Clear();
        }

        public void dgalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            id = int.Parse(dgalunos.CurrentRow.Cells[0].Value.ToString());
            tbNome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            mtbIdade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            mtbCelular.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            mtbPeso.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            mtbAltura.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbRua.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();
            mtbNumero.Text = dgalunos.CurrentRow.Cells[9].Value.ToString();
            mtbApto.Text = dgalunos.CurrentRow.Cells[10].Value.ToString();
            tbBairro.Text = dgalunos.CurrentRow.Cells[11].Value.ToString();
            tbCidade.Text = dgalunos.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgalunos.CurrentRow.Cells[13].Value.ToString();
            tbUsuario.Text = dgalunos.CurrentRow.Cells[14].Value.ToString();
            tbSenha.Text = dgalunos.CurrentRow.Cells[15].Value.ToString();
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {//btBusca
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail', peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Núm.', apto AS 'Apto.', bairro AS Bairro, cidade AS Cidade, estado AS Estado
                    FROM aluno WHERE nome LIKE @nome ORDER BY nome";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", "%" + tbBusca.Text + "%");

                conexao.Open();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet resultado = new DataSet();
                da.Fill(resultado);
                dgalunos.DataSource = resultado.Tables[0];
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbNome.Clear();
                mtbCpf.Clear();
                mtbIdade.Clear();
                mtbCelular.Clear();
                tbEmail.Clear();
                mtbPeso.Clear();
                mtbAltura.Clear();
                tbRua.Clear();
                mtbNumero.Clear();
                mtbApto.Clear();
                tbBairro.Clear();
                tbCidade.Clear();
                cbEstado.SelectedIndex = 0;
                tbUsuario.Clear();
                tbSenha.Clear();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (id != 0)
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM aluno WHERE idaluno=@idaluno";
                        SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexao);

                        comandoDelete.Parameters.AddWithValue("@idaluno", id);

                        conexao.Open();
                        comandoDelete.CommandText = sqlDelete;
                        comandoDelete.ExecuteNonQuery();
                        conexao.Close();

                        MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgalunos.DataSource = alunoDAO.listarAlunos();

                        id = 0;
                        tbNome.Clear();
                        mtbCpf.Clear();
                        mtbIdade.Clear();
                        mtbCelular.Clear();
                        tbEmail.Clear();
                        mtbPeso.Clear();
                        mtbAltura.Clear();
                        tbRua.Clear();
                        mtbNumero.Clear();
                        mtbApto.Clear();
                        tbBairro.Clear();
                        tbCidade.Clear();
                        cbEstado.SelectedIndex = 0;
                        tbUsuario.Clear();
                        tbSenha.Clear();

                        checkApto.Checked = false;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar
            if (tbNome.Text == "" || mtbCpf.Text == "" || mtbIdade.Text == "" || mtbCelular.Text == "" || tbEmail.Text == "" || tbRua.Text == "" || mtbNumero.Text == "" || tbBairro.Text == "" || tbCidade.Text == "" || cbEstado.SelectedIndex == 0 || tbUsuario.Text == "" || tbSenha.Text == "")
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var emailVerificado = verificacao.verificarEmail(tbEmail.Text);
                var cpfVerificado = Verificacao.verificarCpf(mtbCpf.Text);
                var celularVerificado = Verificacao.verificarCelular(mtbCelular.Text);
                if (cpfVerificado)
                {
                    if (celularVerificado)
                    {
                        if (emailVerificado)
                        {
                            try
                            {
                                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());

                                //preparado para a string de insert muito louca?

                                string sqlUpdate = @"UPDATE aluno SET nome=@nome, cpf=@cpf, idade=@idade, celular=@celular, email=@email, rua=@rua, numero=@numero, bairro=@bairro, cidade=@cidade, estado=@estado";

                                if (mtbPeso.Text != "")
                                    sqlUpdate = sqlUpdate + ", peso='" + int.Parse(mtbPeso.Text) + "'";
                                if (mtbAltura.Text != "")
                                    sqlUpdate = sqlUpdate + ", altura='" + int.Parse(mtbAltura.Text) + "'";
                                if (checkApto.Checked == true)
                                    sqlUpdate = sqlUpdate + ", apto='" + int.Parse(mtbApto.Text) + "'";
                                if (checkApto.Checked == false)
                                    sqlUpdate = sqlUpdate + ", apto=NULL";

                                sqlUpdate = sqlUpdate + " WHERE idaluno=@idaluno";

                                SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                                comandoUpdate.Parameters.AddWithValue("@idaluno", id);
                                comandoUpdate.Parameters.AddWithValue("@nome", tbNome.Text);
                                comandoUpdate.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                comandoUpdate.Parameters.AddWithValue("@idade", int.Parse(mtbIdade.Text));
                                comandoUpdate.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                comandoUpdate.Parameters.AddWithValue("@email", tbEmail.Text);
                                comandoUpdate.Parameters.AddWithValue("@rua", tbRua.Text);
                                comandoUpdate.Parameters.AddWithValue("@numero", mtbNumero.Text);
                                comandoUpdate.Parameters.AddWithValue("@bairro", tbBairro.Text);
                                comandoUpdate.Parameters.AddWithValue("@cidade", tbCidade.Text);
                                comandoUpdate.Parameters.AddWithValue("@estado", cbEstado.Text);
                                comandoUpdate.Parameters.AddWithValue("@usuario", tbUsuario.Text);
                                comandoUpdate.Parameters.AddWithValue("@senha", tbSenha.Text);

                                conexao.Open();
                                comandoUpdate.CommandText = sqlUpdate;
                                comandoUpdate.ExecuteNonQuery();
                                conexao.Close();
                                MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                dgalunos.DataSource = alunoDAO.listarAlunos();

                                id = 0;
                                tbNome.Clear();
                                mtbCpf.Clear();
                                mtbIdade.Clear();
                                mtbCelular.Clear();
                                tbEmail.Clear();
                                mtbPeso.Clear();
                                mtbAltura.Clear();
                                tbRua.Clear();
                                mtbNumero.Clear();
                                mtbApto.Clear();
                                tbBairro.Clear();
                                tbCidade.Clear();
                                cbEstado.SelectedIndex = 0;
                                tbUsuario.Clear();
                                tbSenha.Clear();
                                
                                checkApto.Checked = false;
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail inválido, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tpDadosPessoais.Focus();
                            tbEmail.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tpDadosPessoais.Focus();
                        mtbCelular.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tpDadosPessoais.Focus();
                    mtbCpf.Focus();
                }
            }
        }

        private void checkApto_CheckedChanged(object sender, EventArgs e)
        {//change checkbox
            if (checkApto.Checked == true)
                mtbApto.Enabled = true;
            else
                mtbApto.Enabled = false;
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

        #region Máscara Busca

        private void tbBusca_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "" || tbUsuario.Text == " Busca...")
            {
                tbUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular);
                tbUsuario.Text = "";
            }
        }

        private void tbBusca_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = " Busca...";
                tbUsuario.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
            }
        }

        #endregion

        
    }
}
