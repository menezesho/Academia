using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using academia.Class;
using academia.DAO;
using academia.Properties;

namespace projetofinal
{
    public partial class FormLogin : Form
    {
        Conexao conec = new Conexao();
        string selecionado = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbUsuario.Text = " Usuário";
            tbUsuario.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
            tbSenha.Text = " Senha";
            tbSenha.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
            tbSenha.UseSystemPasswordChar = false;

            //temporário
            tbUsuario.Text = "joao-ds";
            tbSenha.Text = "321654";
            selecionado = "professor";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {//btLogin
            if (selecionado != "")
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sql = "";
                    if (selecionado == "aluno")
                        sql = @"SELECT * FROM aluno WHERE usuario=@usuario AND senha=@senha";
                    else
                        sql = @"SELECT * FROM professor WHERE usuario=@usuario AND senha=@senha";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@usuario", tbUsuario.Text);
                    comando.Parameters.AddWithValue("@senha", tbSenha.Text);

                    conexao.Open();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        MessageBox.Show("Login autenticado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPrincipal Fp = new FormPrincipal(tbUsuario.Text);
                        tbUsuario.Clear();
                        tbSenha.Clear();
                        conexao.Close();
                        this.Hide();

                        if(selecionado == "aluno")
                        {
                            Fp.btCadAula.Visible = false;
                            Fp.btCadAluno.Visible = false;
                            Fp.btCadProf.Visible = false;
                            Fp.btEditAula.Visible = false;
                            Fp.btEditAluno.Visible = false;
                            Fp.btEditProf.Visible = false;
                            Fp.btInscrever.Visible = false;
                            Fp.btEditParticipantes.Visible = false;

                        }
                        else
                        {

                        }

                        tbUsuario.Text = " Usuário";
                        tbUsuario.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                        tbSenha.Text = " Senha";
                        tbSenha.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                        tbSenha.UseSystemPasswordChar = false;
                        Fp.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexao.Close();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Selecione a área para realizar o login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #region Sair

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

        #region Area do Aluno/Professor

        private void btAreaAluno_Click(object sender, EventArgs e)
        {//btAreaAluno
            btAreaProf.BackColor = Color.FromArgb(68, 68, 68);
            btAreaProf.Height = 30;
            btAreaAluno.BackColor = Color.MediumSeaGreen;
            btAreaAluno.Height = 35;
            selecionado = "aluno";
        }

        private void btAreaProf_Click(object sender, EventArgs e)
        {//btAreaProf
            btAreaAluno.BackColor = Color.FromArgb(68, 68, 68);
            btAreaAluno.Height = 30;
            btAreaProf.BackColor = Color.MediumSeaGreen;
            btAreaProf.Height = 35;
            selecionado = "professor";
        }

        #endregion

        #region Máscara Usuário

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "" || tbUsuario.Text == " Usuário")
            {
                tbUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular);
                tbUsuario.Text = "";
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = " Usuário";
                tbUsuario.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
            }
        }

        #endregion

        #region Máscara Senha

        private void tbSenha_Enter(object sender, EventArgs e)
        {
            if (tbSenha.Text == "" || tbSenha.Text == " Senha")
            {
                tbSenha.Text = "";
                tbSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular);
                tbSenha.UseSystemPasswordChar = true;
            }
        }

        private void tbSenha_Leave(object sender, EventArgs e)
        {
            if (tbSenha.Text == "")
            {
                tbSenha.Text = " Senha";
                tbSenha.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                tbSenha.UseSystemPasswordChar = false;
            }
        }

        #endregion
    }
}