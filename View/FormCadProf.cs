using academia.Class;
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
    public partial class FormCadProf : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();

        public FormCadProf()
        {
            InitializeComponent();
        }

        private void FormCadProf_Load(object sender, EventArgs e)
        {
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

            checkApto.Checked = false;
            mtbApto.Enabled = false;
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
                tbRua.Clear();
                mtbNumero.Clear();
                mtbApto.Clear();
                tbBairro.Clear();
                tbCidade.Clear();
                cbEstado.SelectedIndex = 0;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar





            if (tbNome.Text == "" || mtbCpf.Text == "" || mtbIdade.Text == "" || mtbCelular.Text == "" || tbEmail.Text == "" || tbRua.Text == "" || mtbNumero.Text == "" || tbBairro.Text == "" || tbCidade.Text == "" || cbEstado.SelectedIndex == 0 || tbUsuario.Text == "" || tbSenha.Text == "")
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var emailVerificado = verificacao.verificarEmail(tbEmail.Text);
                var cpfVerificado = Verificacao.verificarCpf(mtbCpf.Text);
                var celularVerificado = Verificacao.verificarCelular(mtbCelular.Text);
                if (emailVerificado)
                {
                    if (cpfVerificado)
                    {
                        if (celularVerificado)
                        {
                            try
                            {
                                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                                string sqlSelect = @"SELECT * FROM aluno WHERE cpf=@cpf";
                                SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                                comandoSelect.Parameters.AddWithValue("@cpf", mtbCpf.Text);

                                conexao.Open();
                                SqlDataReader dados = comandoSelect.ExecuteReader();
                                if (dados.Read())
                                {
                                    MessageBox.Show("CPF já cadastrado, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    conexao.Close();
                                }
                                else
                                {
                                    conexao.Close();
                                    SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());

                                    //preparado para a string de insert muito louca?

                                    string sqlInsert = @"INSERT INTO aluno (nome, cpf, idade, celular, email, rua, numero, bairro, cidade, estado, usuario, senha";

                                    if (mtbApto.Text != "")
                                        sqlInsert = sqlInsert + ", apto";

                                    sqlInsert = sqlInsert + ") VALUES (@nome, @cpf, @idade, @celular, @email, @rua, @numero, @bairro, @cidade, @estado, @usuario, @senha";

                                    if (mtbApto.Text != "")
                                        sqlInsert = sqlInsert + ", '" + int.Parse(mtbApto.Text) + "'";

                                    sqlInsert = sqlInsert + ")";

                                    SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                                    comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text);
                                    comandoInsert.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                    comandoInsert.Parameters.AddWithValue("@idade", int.Parse(mtbIdade.Text));
                                    comandoInsert.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                    comandoInsert.Parameters.AddWithValue("@email", tbEmail.Text);
                                    comandoInsert.Parameters.AddWithValue("@rua", tbRua.Text);
                                    comandoInsert.Parameters.AddWithValue("@numero", mtbNumero.Text);
                                    comandoInsert.Parameters.AddWithValue("@bairro", tbBairro.Text);
                                    comandoInsert.Parameters.AddWithValue("@cidade", tbCidade.Text);
                                    comandoInsert.Parameters.AddWithValue("@estado", cbEstado.Text);
                                    comandoInsert.Parameters.AddWithValue("@usuario", tbUsuario.Text);
                                    comandoInsert.Parameters.AddWithValue("@senha", tbSenha.Text);

                                    conexao2.Open();
                                    comandoInsert.CommandText = sqlInsert;
                                    comandoInsert.ExecuteNonQuery();
                                    conexao2.Close();
                                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tpDadosPessoais.Focus();
                                }
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tpDadosPessoais.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tpDadosPessoais.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("E-mail inválido, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tpDadosPessoais.Focus();
                }
            }
        }

        private void checkApto_CheckedChanged(object sender, EventArgs e)
        {//change checkbox
            if (checkApto.Checked == true)
            {
                mtbApto.Enabled = true;
                mtbApto.Clear();
            }
            else
            {
                mtbApto.Enabled = false;
                mtbApto.Clear();
            }
        }

        #region Retornar

        private void FormCadProf_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
