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
    public partial class FormNovoProfessor : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();

        public FormNovoProfessor()
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
                tbUsuario.Clear();
                tbSenha.Clear();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text.Trim() == "" || mtbCpf.Text == "" || mtbIdade.Text == "" || mtbCelular.Text == "" || tbEmail.Text.Trim() == "" || tbRua.Text.Trim() == "" || mtbNumero.Text == "" || tbBairro.Text.Trim() == "" || tbCidade.Text.Trim() == "" || cbEstado.SelectedIndex == 0 || tbUsuario.Text.Trim() == "" || tbSenha.Text == "")
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var emailVerificado = verificacao.verificarEmail(tbEmail.Text.Trim());
                var cpfVerificado = Verificacao.verificarCpf(mtbCpf.Text);
                var celularVerificado = Verificacao.verificarCelular(mtbCelular.Text);
                if (cpfVerificado)
                {
                    epValida.Clear();
                    if (celularVerificado)
                    {
                        epValida.Clear();
                        if (emailVerificado)
                        {
                            epValida.Clear();
                            try
                            {
                                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                                string sqlSelect = @"SELECT * FROM professor WHERE cpf=@cpf";
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

                                    string sqlInsert = @"INSERT INTO professor (nome, cpf, idade, celular, email, rua, numero, bairro, cidade, estado, usuario, senha";

                                    if (mtbApto.Text != "")
                                        sqlInsert = sqlInsert + ", apto";

                                    sqlInsert = sqlInsert + ") VALUES (@nome, @cpf, @idade, @celular, @email, @rua, @numero, @bairro, @cidade, @estado, @usuario, @senha";

                                    if (mtbApto.Text != "")
                                        sqlInsert = sqlInsert + ", '" + int.Parse(mtbApto.Text) + "'";

                                    sqlInsert = sqlInsert + ")";

                                    SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                                    comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                                    comandoInsert.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                    comandoInsert.Parameters.AddWithValue("@idade", int.Parse(mtbIdade.Text));
                                    comandoInsert.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                    comandoInsert.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                                    comandoInsert.Parameters.AddWithValue("@rua", tbRua.Text.Trim());
                                    comandoInsert.Parameters.AddWithValue("@numero", mtbNumero.Text);
                                    comandoInsert.Parameters.AddWithValue("@bairro", tbBairro.Text.Trim());
                                    comandoInsert.Parameters.AddWithValue("@cidade", tbCidade.Text.Trim());
                                    comandoInsert.Parameters.AddWithValue("@estado", cbEstado.Text);
                                    comandoInsert.Parameters.AddWithValue("@usuario", tbUsuario.Text.Trim());
                                    comandoInsert.Parameters.AddWithValue("@senha", tbSenha.Text);

                                    conexao2.Open();
                                    comandoInsert.CommandText = sqlInsert;
                                    comandoInsert.ExecuteNonQuery();
                                    conexao2.Close();
                                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tcDados.SelectedTab = tpDadosPessoais;
                                    epValida.Clear();
                                }
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail inválido, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tcDados.SelectedTab = tpDadosPessoais;
                            tbEmail.Focus();
                            epValida.SetError(tbEmail, "O campo deve conter um e-mail válido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tcDados.SelectedTab = tpDadosPessoais;
                        mtbCelular.Focus();
                        epValida.SetError(mtbCelular, "O campo deve ser preenchido por completo!");
                    }
                }
                else
                {
                    MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tcDados.SelectedTab = tpDadosPessoais;
                    mtbCpf.Focus();
                    epValida.SetError(mtbCpf, "O campo deve ser preenchido por completo!");
                }
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
