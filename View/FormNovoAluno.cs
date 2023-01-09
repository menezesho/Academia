using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using academia.Class;
using academia;

namespace projetofinal
{
    public partial class FormNovoAluno : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();

        public FormNovoAluno()
        {
            InitializeComponent();
        }

        private void FormCadAluno_Load(object sender, EventArgs e)
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text.Trim() == "" || mtbCpf.Text == "" || mtbIdade.Text.Trim() == "" || mtbCelular.Text == "" || tbEmail.Text.Trim() == "" || tbRua.Text.Trim() == "" || mtbNumero.Text == "" || tbBairro.Text.Trim() == "" || tbCidade.Text.Trim() == "" || cbEstado.SelectedIndex == 0 || tbUsuario.Text.Trim() == "" || tbSenha.Text == "")
                MessageBox.Show("Os campos obrigatórios não foram preenchidos!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                                string sqlVerificaCpf = @"SELECT * FROM aluno WHERE cpf=@cpf";
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
                                    string sqlInsert = @"INSERT INTO aluno (nome, cpf, idade, celular, email, rua, numero, bairro, cidade, estado, usuario, senha";

                                    if (mtbPeso.Text != "")
                                        sqlInsert = sqlInsert + ", peso";
                                    if (mtbAltura.Text != "")
                                        sqlInsert = sqlInsert + ", altura";
                                    if (mtbApto.Text != "")
                                        sqlInsert = sqlInsert + ", apto";

                                    sqlInsert = sqlInsert + ") VALUES (@nome, @cpf, @idade, @celular, @email, @rua, @numero, @bairro, @cidade, @estado, @usuario, @senha";

                                    if (mtbPeso.Text != "")
                                        sqlInsert = sqlInsert + ", '" + int.Parse(mtbPeso.Text) + "'";
                                    if (mtbAltura.Text != "")
                                        sqlInsert = sqlInsert + ", '" + int.Parse(mtbAltura.Text) + "'";
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
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O E-mail informado é inválido!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tcDados.SelectedTab = tpDadosPessoais;
                            tbEmail.Focus();
                            epValida.SetError(tbEmail, "O campo deve conter um e-mail válido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O número de celular informado é inválido!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tcDados.SelectedTab = tpDadosPessoais;
                        mtbCelular.Focus();
                        epValida.SetError(mtbCelular, "O campo deve ser preenchido por completo!");
                    }
                }
                else
                {
                    MessageBox.Show("O CPF informado é inválido!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tcDados.SelectedTab = tpDadosPessoais;
                    mtbCpf.Focus();
                    epValida.SetError(mtbCpf, "O campo deve ser preenchido por completo!");
                }
            }
        }

        #region Retornar

        private void FormCadAluno_KeyDown(object sender, KeyEventArgs e)
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
