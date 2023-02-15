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
                MessageBox.Show("Os campos obrigatórios não foram preenchidos!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                #region Verificação de espaços

                try
                {
                    int testeIdade = int.Parse(mtbIdade.Text);
                    int testeNumero = int.Parse(mtbNumero.Text);
                    if (mtbApto.Text != "")
                    {
                        int testeApto = int.Parse(mtbApto.Text);
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique se todos os campos numéricos foram preenchidos corretamente!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                #endregion

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
                                SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                                string sqlVerificaCpf = @"SELECT * FROM professor WHERE cpf=@cpf";
                                SqlCommand cmdVerificaCpf = new SqlCommand(sqlVerificaCpf, cn);

                                cmdVerificaCpf.Parameters.AddWithValue("@cpf", mtbCpf.Text);

                                cn.Open();
                                SqlDataReader dataVerificaCpf = cmdVerificaCpf.ExecuteReader();
                                if (dataVerificaCpf.Read())
                                {
                                    MessageBox.Show("CPF já cadastrado!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cn.Close();
                                }
                                else
                                {
                                    cn.Close();
                                    string sqlValidaUsuario = @"SELECT usuario FROM professor WHERE usuario = @usuario;";
                                    SqlCommand cmdValidaUsuario = new SqlCommand(sqlValidaUsuario, cn);

                                    cmdValidaUsuario.Parameters.AddWithValue("@usuario", tbUsuario.Text);

                                    cn.Open();
                                    cmdValidaUsuario.CommandText = sqlValidaUsuario;
                                    cmdValidaUsuario.ExecuteNonQuery();
                                    SqlDataReader dataValidaUsuario = cmdValidaUsuario.ExecuteReader();
                                    if (dataValidaUsuario.Read())
                                    {
                                        cn.Close();
                                        MessageBox.Show("Este usuário já está em uso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        tbUsuario.Focus();
                                    }
                                    else
                                    {
                                        cn.Close();
                                        string sqlInsert = @"INSERT INTO professor (nome, cpf, idade, celular, email, rua, numero, bairro, cidade, estado, usuario, senha";

                                        if (mtbApto.Text != "")
                                            sqlInsert = sqlInsert + ", apto";

                                        sqlInsert = sqlInsert + ") VALUES (@nome, @cpf, @idade, @celular, @email, @rua, @numero, @bairro, @cidade, @estado, @usuario, @senha";

                                        if (mtbApto.Text != "")
                                            sqlInsert = sqlInsert + ", '" + int.Parse(mtbApto.Text) + "'";

                                        sqlInsert = sqlInsert + ")";

                                        SqlCommand cmdInsert = new SqlCommand(sqlInsert, cn);

                                        cmdInsert.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                                        cmdInsert.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                        cmdInsert.Parameters.AddWithValue("@idade", int.Parse(mtbIdade.Text));
                                        cmdInsert.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                        cmdInsert.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                                        cmdInsert.Parameters.AddWithValue("@rua", tbRua.Text.Trim());
                                        cmdInsert.Parameters.AddWithValue("@numero", mtbNumero.Text);
                                        cmdInsert.Parameters.AddWithValue("@bairro", tbBairro.Text.Trim());
                                        cmdInsert.Parameters.AddWithValue("@cidade", tbCidade.Text.Trim());
                                        cmdInsert.Parameters.AddWithValue("@estado", cbEstado.Text);
                                        cmdInsert.Parameters.AddWithValue("@usuario", tbUsuario.Text.Trim());
                                        cmdInsert.Parameters.AddWithValue("@senha", tbSenha.Text);

                                        cn.Open();
                                        cmdInsert.CommandText = sqlInsert;
                                        cmdInsert.ExecuteNonQuery();
                                        cn.Close();
                                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tcDados.SelectedTab = tpDadosPessoais;
                                        epValida.Clear();
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
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O E-mail informado é inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tcDados.SelectedTab = tpDadosPessoais;
                            tbEmail.Focus();
                            epValida.SetError(tbEmail, "O campo deve conter um e-mail válido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O número de celular informado é inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tcDados.SelectedTab = tpDadosPessoais;
                        mtbCelular.Focus();
                        epValida.SetError(mtbCelular, "O campo deve ser preenchido por completo!");
                    }
                }
                else
                {
                    MessageBox.Show("O CPF informado é inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (tbNome.Text == "" && mtbCpf.Text == "" && mtbCelular.Text == "" && mtbIdade.Text == "" && tbEmail.Text == "" && tbRua.Text == "" && mtbNumero.Text == "" && mtbApto.Text == "" && cbEstado.SelectedIndex == 0 && tbCidade.Text == "" && tbBairro.Text == "" && tbUsuario.Text == "" && tbSenha.Text == "")
                    Close();
                else
                {
                    if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        Close();
                }
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (tbNome.Text == "" && mtbCpf.Text == "" && mtbCelular.Text == "" && mtbIdade.Text == "" && tbEmail.Text == "" && tbRua.Text == "" && mtbNumero.Text == "" && mtbApto.Text == "" && cbEstado.SelectedIndex == 0 && tbCidade.Text == "" && tbBairro.Text == "" && tbUsuario.Text == "" && tbSenha.Text == "")
                Close();
            else
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
            }
        }

        #endregion
    }
}
