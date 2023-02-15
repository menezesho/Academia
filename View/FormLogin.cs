using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using academia;
using academia.Class;
using academia.DAO;
using academia.Properties;

namespace projetofinal
{
    public partial class FormLogin : Form
    {
        Conexao conec = new Conexao();
        int selecionado = 0;
        string nome = "";
        string usuario = "";
        int id = 0;

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
        }

        private void btLogin_Click(object sender, EventArgs e)
        {//btLogin
            if (selecionado != 0)
            {
                if (selecionado == 3)
                {
                    if (tbUsuario.Text.Trim().ToLower() == "admin" && tbSenha.Text == "admin")
                    {
                        nome = "Administrador";
                        usuario = "admin";
                        MessageBox.Show("Login autenticado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbUsuario.Text = " Usuário";
                        tbUsuario.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                        tbSenha.Text = " Senha";
                        tbSenha.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                        tbSenha.UseSystemPasswordChar = false;
                        this.Hide();
                        FormMenuAdmin Fmadmin = new FormMenuAdmin(usuario, nome);
                        Fmadmin.Show();
                    }
                    else
                        MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                        string sql = "";
                        if (selecionado == 1)
                            sql = @"SELECT * FROM aluno WHERE usuario=@usuario AND senha=@senha";
                        if (selecionado == 2)
                            sql = @"SELECT * FROM professor WHERE usuario=@usuario AND senha=@senha";
                        SqlCommand cmd = new SqlCommand(sql, cn);

                        cmd.Parameters.AddWithValue("@usuario", tbUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", tbSenha.Text);

                        cn.Open();
                        SqlDataReader data = cmd.ExecuteReader();
                        if (data.Read())
                        {
                            nome = data["Nome"].ToString();
                            id = (int)data[0];
                            usuario = tbUsuario.Text.Trim();
                            MessageBox.Show("Login autenticado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbUsuario.Text = " Usuário";
                            tbUsuario.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                            tbSenha.Text = " Senha";
                            tbSenha.Font = new Font("Segoe UI Light", 14F, FontStyle.Italic);
                            tbSenha.UseSystemPasswordChar = false;

                            if (selecionado == 1)
                            {
                                FormMenuAluno Fma = new FormMenuAluno(usuario, nome, id);
                                cn.Close();
                                this.Hide();
                                Fma.Show();
                            }
                            if (selecionado == 2)
                            {
                                FormMenuProfessor Fmp = new FormMenuProfessor(usuario, nome, id);
                                cn.Close();
                                this.Hide();
                                Fmp.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos, tente novamente!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cn.Close();
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Nenhuma área foi selecionada!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #region Sair

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo finalziar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Application.Exit();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Deseja mesmo finalziar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

        #region Area do Aluno/Professor

        /*
            1. Área do Aluno
            2. Área do Professor
            3. Área do Administrador
        */

        private void btAreaAluno_Click(object sender, EventArgs e)
        {//btAreaAluno
            btAreaProf.BackColor = Color.FromArgb(68, 68, 68);
            btAreaProf.Height = 30;
            btAreaAdmin.BackColor = Color.FromArgb(68, 68, 68);
            btAreaAdmin.Height = 30;
            btAreaAluno.BackColor = Color.MediumSeaGreen;
            btAreaAluno.Height = 35;
            selecionado = 1;
        }

        private void btAreaProf_Click(object sender, EventArgs e)
        {//btAreaProf
            btAreaAluno.BackColor = Color.FromArgb(68, 68, 68);
            btAreaAluno.Height = 30;
            btAreaAdmin.BackColor = Color.FromArgb(68, 68, 68);
            btAreaAdmin.Height = 30;
            btAreaProf.BackColor = Color.MediumSeaGreen;
            btAreaProf.Height = 35;
            selecionado = 2;
        }

        private void btAreaAdmin_Click(object sender, EventArgs e)
        {//btAreaAdmin
            btAreaAluno.BackColor = Color.FromArgb(68, 68, 68);
            btAreaAluno.Height = 30;
            btAreaProf.BackColor = Color.FromArgb(68, 68, 68);
            btAreaProf.Height = 30;
            btAreaAdmin.BackColor = Color.MediumSeaGreen;
            btAreaAdmin.Height = 35;
            selecionado = 3;
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