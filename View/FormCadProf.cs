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

        public FormCadProf()
        {
            InitializeComponent();
        }

        private void FormCadProf_Load(object sender, EventArgs e)
        {
            tbNome.Clear();
            mtbCpf.Clear();
            tbIdade.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            tbSenha.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbApto.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedIndex = 0;

            checkApto.Checked = false;
            tbApto.Enabled = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbNome.Clear();
                mtbCpf.Clear();
                tbIdade.Clear();
                mtbCelular.Clear();
                tbEmail.Clear();
                tbSenha.Clear();
                tbRua.Clear();
                tbNumero.Clear();
                tbApto.Clear();
                tbBairro.Clear();
                tbCidade.Clear();
                cbEstado.SelectedIndex = 0;

                checkApto.Checked = false;
                tbApto.Enabled = false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text == "" || mtbCpf.Text == "" || tbIdade.Text == "" || mtbCelular.Text == "" || tbEmail.Text == "" || tbSenha.Text == ""|| tbRua.Text == "" || tbNumero.Text == "" || tbBairro.Text == "" || tbCidade.Text == "" || cbEstado.SelectedIndex == 0)
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

                                string sqlInsert = @"INSERT INTO professor (nome, cpf, idade, celular, email, senha, rua, numero, bairro, cidade, estado";
                                
                                if (tbApto.Text != "")
                                    sqlInsert = sqlInsert + ", apto";

                                sqlInsert = sqlInsert + ") VALUES (@nome, @cpf, @idade, @celular, @email, @senha, @rua, @numero, @bairro, @cidade, @estado";

                                if (tbApto.Text != "")
                                    sqlInsert = sqlInsert + ", '" + int.Parse(tbApto.Text) + "'";

                                sqlInsert = sqlInsert + ")";

                                SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                                comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text);
                                comandoInsert.Parameters.AddWithValue("@cpf", mtbCpf.Text);
                                comandoInsert.Parameters.AddWithValue("@idade", int.Parse(tbIdade.Text));
                                comandoInsert.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                comandoInsert.Parameters.AddWithValue("@email", tbEmail.Text);
                                comandoInsert.Parameters.AddWithValue("@senha", tbSenha.Text);
                                comandoInsert.Parameters.AddWithValue("@rua", tbRua.Text);
                                comandoInsert.Parameters.AddWithValue("@numero", tbNumero.Text);
                                comandoInsert.Parameters.AddWithValue("@bairro", tbBairro.Text);
                                comandoInsert.Parameters.AddWithValue("@cidade", tbCidade.Text);
                                comandoInsert.Parameters.AddWithValue("@estado", cbEstado.Text);

                                conexao2.Open();
                                comandoInsert.CommandText = sqlInsert;
                                comandoInsert.ExecuteNonQuery();
                                conexao2.Close();
                                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Insira o número de celular corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Insira o CPF corretamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbVerSenha_Click(object sender, EventArgs e)
        {//lbVerSenha
            if (tbSenha.UseSystemPasswordChar.Equals(false))
                tbSenha.UseSystemPasswordChar = true;
            else
                tbSenha.UseSystemPasswordChar = false;
        }

        private void checkApto_CheckedChanged(object sender, EventArgs e)
        {//change checkbox
            if (checkApto.Checked == true)
            {
                tbApto.Enabled = true;
                tbApto.Clear();
            }
            else
            {
                tbApto.Enabled = false;
                tbApto.Clear();
            }
        }

        #region Retornar

        private void FormCadProf_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
