using academia.Class;
using projetofinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace academia
{
    public partial class FormNovaAula : Form
    {
        Conexao conec = new Conexao();
        int id = 0;

        public FormNovaAula()
        {
            InitializeComponent();
        }

        public FormNovaAula(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormCadAula_Load(object sender, EventArgs e)
        {
            tbNome.Clear();
            dtpData.Text = "";
            cbHora.SelectedIndex = 0;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbNome.Clear();
                dtpData.Text = "";
                cbHora.SelectedIndex = 0;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar
            if (tbNome.Text == "" || cbHora.Text == "Selecione")
                MessageBox.Show("Preencha os campos vazios!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (int.Parse(mtbTotal.Text) != 0)
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                        string sqlSelect = @"SELECT * FROM aula WHERE dia=@data AND hora=@hora";
                        SqlCommand comandoSelect = new SqlCommand(sqlSelect, conexao);

                        comandoSelect.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                        comandoSelect.Parameters.AddWithValue("@hora", cbHora.Text);

                        conexao.Open();
                        SqlDataReader dados = comandoSelect.ExecuteReader();
                        if (dados.Read())
                        {
                            MessageBox.Show("Conflito de data e hora, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            SqlConnection conexao2 = new SqlConnection(conec.ConexaoBD());
                            string sqlInsert = "";
                            sqlInsert = "INSERT INTO aula (nome, dia, hora, id_professor";
                            SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexao2);

                            if (mtbTotal.Text != "")
                                sqlInsert = sqlInsert + ", total, contador) VALUES(@nome, @data, @hora, @idprofessor, @total, 0)";
                            else
                                sqlInsert = sqlInsert + ", contador) VALUES(@nome, @data, @hora, @idprofessor, 0)";

                            comandoInsert.Parameters.AddWithValue("@nome", tbNome.Text);
                            comandoInsert.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                            comandoInsert.Parameters.AddWithValue("@hora", cbHora.Text);
                            comandoInsert.Parameters.AddWithValue("@idprofessor", id);
                            comandoInsert.Parameters.AddWithValue("@total", mtbTotal.Text);

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
                    MessageBox.Show("O máximo de alunos não pode ser 0, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        #region Retornar

        private void FormCadAula_KeyDown(object sender, KeyEventArgs e)
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
