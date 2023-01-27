using academia.Class;
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
    public partial class FormAlterarSenha : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();
        int id = 0;
        int acesso = 0;

        public FormAlterarSenha()
        {
            InitializeComponent();
        }

        public FormAlterarSenha(int id, int acesso)
        {
            InitializeComponent();
            this.id = id;
            this.acesso = acesso;
        }

        private void FormAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            tbSenhaAtual.Clear();
            tbNovaSenha.Clear();
            tbConfirmarNovaSenha.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar
            if (tbSenhaAtual.Text == "" || tbNovaSenha.Text == "" || tbConfirmarNovaSenha.Text == "")
                MessageBox.Show("Preencha os campos obrigatórios!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (tbNovaSenha.Text == tbConfirmarNovaSenha.Text)
                {
                    bool senhaVerificada = verificacao.verificarSenha(tbNovaSenha.Text);
                    if (senhaVerificada)
                    {
                        try
                        {
                            SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                            string sqlVerificaSenhaAtual = "";
                            if (acesso == 1)
                                sqlVerificaSenhaAtual = @"SELECT * FROM aluno WHERE idaluno=@id AND senha=@senha";
                            if (acesso == 2)
                                sqlVerificaSenhaAtual = @"SELECT * FROM professor WHERE idprofessor=@id AND senha=@senha";
                            SqlCommand cmdVerificaSenhaAtual = new SqlCommand(sqlVerificaSenhaAtual, cn);

                            cmdVerificaSenhaAtual.Parameters.AddWithValue("@id", id);
                            cmdVerificaSenhaAtual.Parameters.AddWithValue("@senha", tbSenhaAtual.Text);

                            cn.Open();
                            cmdVerificaSenhaAtual.CommandText = sqlVerificaSenhaAtual;
                            cmdVerificaSenhaAtual.ExecuteNonQuery();
                            SqlDataReader dataVerificaSenhaAtual = cmdVerificaSenhaAtual.ExecuteReader();
                            if (dataVerificaSenhaAtual.Read())
                            {
                                if (tbSenhaAtual.Text == tbNovaSenha.Text)
                                {
                                    MessageBox.Show("A senha digitada é a mesma da anterior!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbNovaSenha.Focus();
                                }
                                else
                                {
                                    cn.Close();
                                    string sqlUpdate = "";
                                    if (acesso == 1)
                                        sqlUpdate = @"UPDATE aluno SET senha=@senha WHERE idaluno=@id";
                                    if (acesso == 2)
                                        sqlUpdate = @"UPDATE professor SET senha=@senha WHERE idprofessor=@id";
                                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn);

                                    cmdUpdate.Parameters.AddWithValue("@senha", tbConfirmarNovaSenha.Text);
                                    cmdUpdate.Parameters.AddWithValue("@id", id);

                                    cn.Open();
                                    cmdUpdate.CommandText = sqlUpdate;
                                    cmdUpdate.ExecuteNonQuery();
                                    cn.Close();

                                    tbSenhaAtual.Clear();
                                    tbNovaSenha.Clear();
                                    tbConfirmarNovaSenha.Clear();
                                    this.Close();
                                    MessageBox.Show("Senha alterada com sucesso!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("A senha atual informada está incorreta!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbSenhaAtual.Focus();
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNovaSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não correspondem!", "Alterar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNovaSenha.Focus();
                }
            }                
        }

        #region Ver Senha

        private void lbVerSenhaAtual_MouseCaptureChanged(object sender, EventArgs e)
        {//lbVerSenhaAtual
            if (tbSenhaAtual.UseSystemPasswordChar.Equals(true))
                tbSenhaAtual.UseSystemPasswordChar = false;
            else
                tbSenhaAtual.UseSystemPasswordChar = true;
        }

        private void lbVerNovaSenha_MouseCaptureChanged(object sender, EventArgs e)
        {//btVerNovaSenha
            if (tbNovaSenha.UseSystemPasswordChar.Equals(true))
                tbNovaSenha.UseSystemPasswordChar = false;
            else
                tbNovaSenha.UseSystemPasswordChar = true;
        }

        private void lbVerConfirmarNovaSenha_MouseCaptureChanged(object sender, EventArgs e)
        {//btVerConfirmarNovaSenha
            if (tbConfirmarNovaSenha.UseSystemPasswordChar.Equals(true))
                tbConfirmarNovaSenha.UseSystemPasswordChar = false;
            else
                tbConfirmarNovaSenha.UseSystemPasswordChar = true;
        }

        #endregion

        #region Retornar

        private void FormAlterarSenha_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            Close();
        }

        #endregion

    }
}
