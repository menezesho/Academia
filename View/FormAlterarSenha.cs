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
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbSenhaAtual.Clear();
                tbNovaSenha.Clear();
                tbConfirmarNovaSenha.Clear();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btSalvar
            if (tbSenhaAtual.Text == "" || tbNovaSenha.Text == "" || tbConfirmarNovaSenha.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (tbNovaSenha.Text == tbConfirmarNovaSenha.Text)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlSelect1 = "";
                        if(acesso == 1)
                            sqlSelect1 = @"SELECT * FROM aluno WHERE idaluno=@id AND senha=@senha";
                        if(acesso == 2)
                            sqlSelect1 = @"SELECT * FROM professor WHERE idprofessor=@id AND senha=@senha";
                        SqlCommand comandoSelect1 = new SqlCommand(sqlSelect1, conexao);

                        comandoSelect1.Parameters.AddWithValue("@id", id);
                        comandoSelect1.Parameters.AddWithValue("@senha", tbSenhaAtual.Text);


                        conexao.Open();
                        comandoSelect1.CommandText = sqlSelect1;
                        comandoSelect1.ExecuteNonQuery();
                        SqlDataReader dados1 = comandoSelect1.ExecuteReader();
                        if (dados1.Read())
                        {
                            conexao.Close();
                            string sqlUpdate = "";
                            if (acesso == 1)
                                sqlUpdate = @"UPDATE aluno SET senha=@senha WHERE idaluno=@id";
                            if (acesso == 2)
                                sqlUpdate = @"UPDATE professor SET senha=@senha WHERE idprofessor=@id";
                            SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                            comandoUpdate.Parameters.AddWithValue("@senha", tbConfirmarNovaSenha.Text);
                            comandoUpdate.Parameters.AddWithValue("@id", id);

                            conexao.Open();
                            comandoUpdate.CommandText = sqlUpdate;
                            comandoUpdate.ExecuteNonQuery();
                            conexao.Close();

                            tbSenhaAtual.Clear();
                            tbNovaSenha.Clear();
                            tbConfirmarNovaSenha.Clear();
                            this.Close();

                            MessageBox.Show("Senha alterada com sucesso!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("A senha atual informada está incorreta.\nTente novamente!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("As senhas não correspondem.\nTente novamente!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNovaSenha.Focus();
                }
            }                
        }

        #region Ver Senha

        private void lbVerSenhaAtual_MouseCaptureChanged(object sender, EventArgs e)
        {
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
                if (MessageBox.Show("Deseja mesmo retornar para a tela de login?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Deseja mesmo retornar para a tela de login?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
