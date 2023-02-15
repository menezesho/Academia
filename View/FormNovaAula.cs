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
                cbHora.SelectedIndex = 0;
                mtbTotal.Clear();
                dtpData.ResetText();

            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {//btCadastrar

            #region Verificação de espaços
            if (mtbTotal.Text != "")
            {
                try
                {
                    int testeTotal = int.Parse(mtbTotal.Text);
                }
                catch
                {
                    MessageBox.Show("O máximo de alunos informado não é válido, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            #endregion

            if (tbNome.Text.Trim() == "" || cbHora.SelectedIndex == 0)
                MessageBox.Show("Os campos obrigatórios não foram preenchidos!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                    string sqlVerificaDiaHora = @"SELECT * FROM aula WHERE dia = @data AND hora = @hora";
                    SqlCommand cmdVerificaDiaHora = new SqlCommand(sqlVerificaDiaHora, cn);

                    cmdVerificaDiaHora.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                    cmdVerificaDiaHora.Parameters.AddWithValue("@hora", cbHora.Text);

                    cn.Open();
                    SqlDataReader dataVerificaDiaHora = cmdVerificaDiaHora.ExecuteReader();
                    if (dataVerificaDiaHora.Read())
                    {
                        MessageBox.Show("Conflito de data e hora, tente novamente!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cn.Close();
                    }
                    else
                    {
                        cn.Close();
                        string sqlInsert = "";
                        sqlInsert = "INSERT INTO aula (nome, dia, hora, id_professor";
                        SqlCommand cmdInsert = new SqlCommand(sqlInsert, cn);

                        if (mtbTotal.Text != "")
                        {
                            if (int.Parse(mtbTotal.Text) != 0)
                                sqlInsert = sqlInsert + ", total, contador) VALUES(@nome, @data, @hora, @idprofessor, @total, 0)";
                            else
                            {
                                MessageBox.Show("O máximo de alunos deve ser maior que zero!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                            sqlInsert = sqlInsert + ", contador) VALUES(@nome, @data, @hora, @idprofessor, 0)";

                        cmdInsert.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                        cmdInsert.Parameters.AddWithValue("@hora", cbHora.Text);
                        cmdInsert.Parameters.AddWithValue("@idprofessor", id);
                        cmdInsert.Parameters.AddWithValue("@total", mtbTotal.Text);

                        cn.Open();
                        cmdInsert.CommandText = sqlInsert;
                        cmdInsert.ExecuteNonQuery();
                        cn.Close();

                        tbNome.Clear();
                        mtbTotal.Clear();
                        cbHora.SelectedIndex = 0;
                        dtpData.ResetText();

                        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Retornar

        private void FormCadAula_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (tbNome.Text == "" && cbHora.Text == "" && mtbTotal.Text == "")
                    Close();
                else
                {
                    if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        Close();
                }
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (tbNome.Text == "" && cbHora.SelectedIndex == 0 && mtbTotal.Text == "")
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
