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
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormEditProf : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();
        ProfessorDAO professorDAO = new ProfessorDAO();
        int id = 0;

        public FormEditProf()
        {
            InitializeComponent();
        }

        private void FormEditProf_Load(object sender, EventArgs e)
        {
            dgprofs.DataSource = professorDAO.listarProfs();

            dgprofs.Columns["ID"].Width = 40;
            dgprofs.Columns["Nome"].Width = 200;
            dgprofs.Columns["CPF"].Width = 90;
            dgprofs.Columns["Idade"].Width = 40;
            dgprofs.Columns["Celular"].Width = 90;
            dgprofs.Columns["E-mail"].Width = 200;
            dgprofs.Columns["Rua"].Width = 160;
            dgprofs.Columns["Num."].Width = 40;
            dgprofs.Columns["Apto."].Width = 40;
            dgprofs.Columns["Bairro"].Width = 160;
            dgprofs.Columns["Cidade"].Width = 160;
            dgprofs.Columns["Estado"].Width = 50;
            dgprofs.Columns["Usuário"].Width = 100;
            dgprofs.Columns["Senha"].Visible = false;

            id = 0;
            tbNome.Clear();
            mtbCpf.Clear();
            mtbIdade.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbRua.Clear();
            mtbNumero.Clear();
            mtbApto.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedIndex = 0;
            tbUsuario.Clear();
            tbSenha.Clear();

            tbNome.Enabled = false;
            mtbIdade.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            tbRua.Enabled = false;
            mtbNumero.Enabled = false;
            mtbApto.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            cbEstado.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;

            tbBusca.Clear();

            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
        }

        private void dgprofs_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            id = int.Parse(dgprofs.CurrentRow.Cells[0].Value.ToString());
            tbNome.Text = dgprofs.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgprofs.CurrentRow.Cells[2].Value.ToString();
            mtbIdade.Text = dgprofs.CurrentRow.Cells[3].Value.ToString();
            mtbCelular.Text = dgprofs.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgprofs.CurrentRow.Cells[5].Value.ToString();
            tbRua.Text = dgprofs.CurrentRow.Cells[6].Value.ToString();
            mtbNumero.Text = dgprofs.CurrentRow.Cells[7].Value.ToString();
            mtbApto.Text = dgprofs.CurrentRow.Cells[8].Value.ToString();
            tbBairro.Text = dgprofs.CurrentRow.Cells[9].Value.ToString();
            tbCidade.Text = dgprofs.CurrentRow.Cells[10].Value.ToString();
            cbEstado.Text = dgprofs.CurrentRow.Cells[11].Value.ToString();
            tbUsuario.Text = dgprofs.CurrentRow.Cells[12].Value.ToString();
            tbSenha.Text = dgprofs.CurrentRow.Cells[13].Value.ToString();

            tbNome.Enabled = true;
            mtbIdade.Enabled = true;
            mtbCelular.Enabled = true;
            tbEmail.Enabled = true;
            tbRua.Enabled = true;
            mtbNumero.Enabled = true;
            mtbApto.Enabled = true;
            tbBairro.Enabled = true;
            tbCidade.Enabled = true;
            cbEstado.Enabled = true;
            tbUsuario.Enabled = true;
            tbSenha.Enabled = true;

            tcDados.SelectedTab = tpDadosPessoais;
        }

        private void lbLimparBusca_Click(object sender, EventArgs e)
        {//lbLimparBusca
            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            dgprofs.DataSource = professorDAO.listarProfs();
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
                    MessageBox.Show("Nenhum dado foi digitado!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sql = "";
                        if (cbFiltro.SelectedIndex == 0)
                        {
                            sql = @"SELECT idprofessor AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM professor WHERE nome LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 1)
                        {
                            sql = @"SELECT idprofessor AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM professor WHERE cpf LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 2)
                        {
                            sql = @"SELECT idprofessor AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM professor WHERE email LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 3)
                        {
                            sql = @"SELECT idprofessor AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM professor WHERE usuario LIKE @busca ORDER BY nome";
                        }
                        SqlCommand comando = new SqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@busca", "%" + tbBusca.Text + "%");

                        conexao.Open();
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataSet resultado = new DataSet();
                        da.Fill(resultado);
                        dgprofs.DataSource = resultado.Tables[0];
                        conexao.Close();
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
                id = 0;
                tbNome.Clear();
                mtbCpf.Clear();
                mtbIdade.Clear();
                mtbCelular.Clear();
                tbEmail.Clear();
                tbRua.Clear();
                mtbNumero.Clear();
                mtbApto.Clear();
                tbBairro.Clear();
                tbCidade.Clear();
                cbEstado.SelectedIndex = 0;
                tbUsuario.Clear();
                tbSenha.Clear();

                tbNome.Enabled = false;
                mtbIdade.Enabled = false;
                mtbCelular.Enabled = false;
                tbEmail.Enabled = false;
                tbRua.Enabled = false;
                mtbNumero.Enabled = false;
                mtbApto.Enabled = false;
                tbBairro.Enabled = false;
                tbCidade.Enabled = false;
                cbEstado.Enabled = false;
                tbUsuario.Enabled = false;
                tbSenha.Enabled = false;

                tcDados.SelectedTab = tpDadosPessoais;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (id == 0)
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM professor WHERE idprofessor=@idprofessor";
                        SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexao);

                        comandoDelete.Parameters.AddWithValue("@idprofessor", id);

                        conexao.Open();
                        comandoDelete.CommandText = sqlDelete;
                        comandoDelete.ExecuteNonQuery();
                        conexao.Close();

                        MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgprofs.DataSource = professorDAO.listarProfs();

                        id = 0;
                        tbNome.Clear();
                        mtbCpf.Clear();
                        mtbIdade.Clear();
                        mtbCelular.Clear();
                        tbEmail.Clear();
                        tbRua.Clear();
                        mtbNumero.Clear();
                        mtbApto.Clear();
                        tbBairro.Clear();
                        tbCidade.Clear();
                        cbEstado.SelectedIndex = 0;
                        tbUsuario.Clear();
                        tbSenha.Clear();

                        tbNome.Enabled = false;
                        mtbIdade.Enabled = false;
                        mtbCelular.Enabled = false;
                        tbEmail.Enabled = false;
                        tbRua.Enabled = false;
                        mtbNumero.Enabled = false;
                        mtbApto.Enabled = false;
                        tbBairro.Enabled = false;
                        tbCidade.Enabled = false;
                        cbEstado.Enabled = false;
                        tbUsuario.Enabled = false;
                        tbSenha.Enabled = false;

                        tcDados.SelectedTab = tpDadosPessoais;
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
            if (id == 0)
                MessageBox.Show("Nenhum cadastro foi selecionado, tente novamente!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
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

                                    string sqlUpdate = @"UPDATE professor SET nome=@nome, idade=@idade, celular=@celular, email=@email, rua=@rua, numero=@numero, bairro=@bairro, cidade=@cidade, estado=@estado, usuario=@usuario, senha=@senha";

                                    if (mtbApto.Text != "")
                                        sqlUpdate = sqlUpdate + ", apto='" + int.Parse(mtbApto.Text) + "'";
                                    else
                                        sqlUpdate = sqlUpdate + ", apto=NULL";

                                    sqlUpdate = sqlUpdate + " WHERE idprofessor=@idprofessor";

                                    SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                                    comandoUpdate.Parameters.AddWithValue("@idprofessor", id);
                                    comandoUpdate.Parameters.AddWithValue("@nome", tbNome.Text);
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

                                    dgprofs.DataSource = professorDAO.listarProfs();

                                    id = 0;
                                    tbNome.Clear();
                                    mtbCpf.Clear();
                                    mtbIdade.Clear();
                                    mtbCelular.Clear();
                                    tbEmail.Clear();
                                    tbRua.Clear();
                                    mtbNumero.Clear();
                                    mtbApto.Clear();
                                    tbBairro.Clear();
                                    tbCidade.Clear();
                                    cbEstado.SelectedIndex = 0;
                                    tbUsuario.Clear();
                                    tbSenha.Clear();

                                    tbNome.Enabled = false;
                                    mtbIdade.Enabled = false;
                                    mtbCelular.Enabled = false;
                                    tbEmail.Enabled = false;
                                    tbRua.Enabled = false;
                                    mtbNumero.Enabled = false;
                                    mtbApto.Enabled = false;
                                    tbBairro.Enabled = false;
                                    tbCidade.Enabled = false;
                                    cbEstado.Enabled = false;
                                    tbUsuario.Enabled = false;
                                    tbSenha.Enabled = false;

                                    tcDados.SelectedTab = tpDadosPessoais;
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
        }

        #region Retornar

        private void FormEditProf_KeyDown(object sender, KeyEventArgs e)
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
