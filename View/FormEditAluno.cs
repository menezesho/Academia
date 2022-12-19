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

        public FormEditAluno()
        {
            InitializeComponent();
        }

        private void FormEditAluno_Load(object sender, EventArgs e)
        {
            AlunoDAO alunoDAO = new AlunoDAO();
            dgalunos.DataSource = alunoDAO.listarAlunos();

            dgalunos.Columns["ID"].Width = 50;
            dgalunos.Columns["Nome"].Width = 220;
            dgalunos.Columns["CPF"].Width = 110;
            dgalunos.Columns["Idade"].Width = 50;
            dgalunos.Columns["Celular"].Width = 110;
            dgalunos.Columns["E-mail"].Width = 220;
            dgalunos.Columns["Peso(kg)"].Width = 70;
            dgalunos.Columns["Altura(cm)"].Width = 80;
            dgalunos.Columns["Rua"].Width = 180;
            dgalunos.Columns["Num."].Width = 60;
            dgalunos.Columns["Apto."].Width = 60;
            dgalunos.Columns["Bairro"].Width = 180;
            dgalunos.Columns["Cidade"].Width = 180;
            dgalunos.Columns["Estado"].Width = 60;

            tbId.Clear();
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbPeso.Clear();
            tbAltura.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbApto.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedIndex = 0;

            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbPeso.Enabled = false;
            tbAltura.Enabled = false;
            tbRua.Enabled = false;
            tbNumero.Enabled = false;
            tbApto.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            cbEstado.Enabled = false;

            checkApto.Enabled = false;
            checkApto.Checked = false;

            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            tbBusca.Clear();
        }

        public void dgalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbId.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            tbIdade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            mtbCelular.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            tbPeso.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            tbAltura.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbRua.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();
            tbNumero.Text = dgalunos.CurrentRow.Cells[9].Value.ToString();
            tbApto.Text = dgalunos.CurrentRow.Cells[10].Value.ToString();
            tbBairro.Text = dgalunos.CurrentRow.Cells[11].Value.ToString();
            tbCidade.Text = dgalunos.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgalunos.CurrentRow.Cells[13].Value.ToString();

            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbPeso.Enabled = false;
            tbAltura.Enabled = false;
            tbRua.Enabled = false;
            tbNumero.Enabled = false;
            tbApto.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            cbEstado.Enabled = false;

            checkApto.Enabled = false;
            checkApto.Checked = false;

            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {//busca automática
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

        private void btEditar_Click(object sender, EventArgs e)
        {//btEditar
            if (tbId.Text != "")
            {
                tbNome.Enabled = true;
                tbIdade.Enabled = true;
                mtbCelular.Enabled = true;
                tbEmail.Enabled = true;
                tbPeso.Enabled = true;
                tbAltura.Enabled = true;
                tbRua.Enabled = true;
                tbNumero.Enabled = true;
                tbBairro.Enabled = true;
                tbCidade.Enabled = true;
                cbEstado.Enabled = true;

                if (tbApto.Text != "")
                {
                    checkApto.Checked = true;
                    checkApto.Enabled = true;
                }
                else
                {
                    checkApto.Checked = false;
                    checkApto.Enabled = true;
                }

                btEditar.Enabled = false;
                btCancelar.Enabled = true;
                btSalvar.Enabled = true;
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar

            tbNome.Enabled = false;
            tbIdade.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbPeso.Enabled = false;
            tbAltura.Enabled = false;
            tbRua.Enabled = false;
            tbNumero.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            cbEstado.Enabled = false;

            checkApto.Enabled = false;
            checkApto.Checked = false;

            btEditar.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

            tbId.Text = dgalunos.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            tbIdade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            mtbCelular.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            tbPeso.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            tbAltura.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbRua.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();
            tbNumero.Text = dgalunos.CurrentRow.Cells[9].Value.ToString();
            tbApto.Text = dgalunos.CurrentRow.Cells[10].Value.ToString();
            tbBairro.Text = dgalunos.CurrentRow.Cells[11].Value.ToString();
            tbCidade.Text = dgalunos.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgalunos.CurrentRow.Cells[13].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (tbId.Text != "")
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM aluno WHERE idaluno=@idaluno";
                        SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexao);

                        comandoDelete.Parameters.AddWithValue("@idaluno", tbId.Text);

                        conexao.Open();
                        comandoDelete.CommandText = sqlDelete;
                        comandoDelete.ExecuteNonQuery();
                        conexao.Close();

                        MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    AlunoDAO alunoDAO = new AlunoDAO();
                    dgalunos.DataSource = alunoDAO.listarAlunos();

                    tbId.Clear();
                    tbNome.Clear();
                    mtbCpf.Clear();
                    tbIdade.Clear();
                    mtbCelular.Clear();
                    tbEmail.Clear();
                    tbPeso.Clear();
                    tbAltura.Clear();
                    tbRua.Clear();
                    tbNumero.Clear();
                    tbApto.Clear();
                    tbBairro.Clear();
                    tbCidade.Clear();
                    cbEstado.SelectedIndex = 0;

                    tbNome.Enabled = false;
                    tbIdade.Enabled = false;
                    mtbCelular.Enabled = false;
                    tbEmail.Enabled = false;
                    tbPeso.Enabled = false;
                    tbAltura.Enabled = false;
                    tbRua.Enabled = false;
                    tbNumero.Enabled = false;
                    tbApto.Enabled = false;
                    tbBairro.Enabled = false;
                    tbCidade.Enabled = false;
                    cbEstado.Enabled = false;

                    checkApto.Enabled = false;
                    checkApto.Checked = false;

                    btEditar.Enabled = true;
                    btSalvar.Enabled = false;
                    btCancelar.Enabled = false;
                }
            }
            else
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar
            if (tbNome.Text == "" || mtbCpf.Text == "" || tbIdade.Text == "" || mtbCelular.Text == "" || tbEmail.Text == "" || tbRua.Text == "" || tbNumero.Text == "" || tbBairro.Text == "" || tbCidade.Text == "" || cbEstado.SelectedIndex == 0)
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var cpfVerificado = Verificacao.verificarCpf(mtbCpf.Text);
                var celularVerificado = Verificacao.verificarCelular(mtbCelular.Text);
                if (cpfVerificado)
                {
                    if (celularVerificado)
                    {
                        try
                        {
                            SqlConnection conexao = new SqlConnection(conec.ConexaoBD());

                            //preparado para a string de insert muito louca?

                            string sqlUpdate = @"UPDATE aluno SET nome=@nome, cpf=@cpf, idade=@idade, celular=@celular, email=@email, rua=@rua, numero=@numero, bairro=@bairro, cidade=@cidade, estado=@estado";

                            if (tbPeso.Text != "")
                                sqlUpdate = sqlUpdate + ", peso='" + int.Parse(tbPeso.Text) + "'";
                            if (tbAltura.Text != "")
                                sqlUpdate = sqlUpdate + ", altura='" + int.Parse(tbAltura.Text) + "'";
                            if (checkApto.Checked == true)
                                sqlUpdate = sqlUpdate + ", apto='" + int.Parse(tbApto.Text) + "'";
                            if (checkApto.Checked == false)
                                sqlUpdate = sqlUpdate + ", apto=NULL";

                            sqlUpdate = sqlUpdate + " WHERE idaluno=@idaluno";

                            SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                            comandoUpdate.Parameters.AddWithValue("@idaluno", tbId.Text);
                            comandoUpdate.Parameters.AddWithValue("@nome", tbNome.Text);
                            comandoUpdate.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                            comandoUpdate.Parameters.AddWithValue("@idade", int.Parse(tbIdade.Text));
                            comandoUpdate.Parameters.AddWithValue("@celular", mtbCelular.Text);
                            comandoUpdate.Parameters.AddWithValue("@email", tbEmail.Text);
                            comandoUpdate.Parameters.AddWithValue("@rua", tbRua.Text);
                            comandoUpdate.Parameters.AddWithValue("@numero", tbNumero.Text);
                            comandoUpdate.Parameters.AddWithValue("@bairro", tbBairro.Text);
                            comandoUpdate.Parameters.AddWithValue("@cidade", tbCidade.Text);
                            comandoUpdate.Parameters.AddWithValue("@estado", cbEstado.Text);

                            conexao.Open();
                            comandoUpdate.CommandText = sqlUpdate;
                            comandoUpdate.ExecuteNonQuery();
                            conexao.Close();
                            MessageBox.Show("Dados alterados com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        AlunoDAO alunoDAO = new AlunoDAO();
                        dgalunos.DataSource = alunoDAO.listarAlunos();

                        tbId.Clear();
                        tbNome.Clear();
                        mtbCpf.Clear();
                        tbIdade.Clear();
                        mtbCelular.Clear();
                        tbEmail.Clear();
                        tbPeso.Clear();
                        tbAltura.Clear();
                        tbRua.Clear();
                        tbNumero.Clear();
                        tbApto.Clear();
                        tbBairro.Clear();
                        tbCidade.Clear();
                        cbEstado.SelectedIndex = 0;

                        tbNome.Enabled = false;
                        tbIdade.Enabled = false;
                        mtbCelular.Enabled = false;
                        tbEmail.Enabled = false;
                        tbPeso.Enabled = false;
                        tbAltura.Enabled = false;
                        tbRua.Enabled = false;
                        tbNumero.Enabled = false;
                        tbApto.Enabled = false;
                        tbBairro.Enabled = false;
                        tbCidade.Enabled = false;
                        cbEstado.Enabled = false;

                        checkApto.Enabled = false;
                        checkApto.Checked = false;

                        btEditar.Enabled = true;
                        btCancelar.Enabled = false;
                        btSalvar.Enabled = false;
                    }
                    else
                        MessageBox.Show("Insira o número de celular corretamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Insira o CPF corretamente!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkApto_CheckedChanged(object sender, EventArgs e)
        {//change checkbox
            if (checkApto.Checked == true)
                tbApto.Enabled = true;
            else
                tbApto.Enabled = false;
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
            if (MessageBox.Show("Os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
