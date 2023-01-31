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
    public partial class FormAtualizarInformacoes : Form
    {
        Conexao conec = new Conexao();
        int id = 0;

        public FormAtualizarInformacoes()
        {
            InitializeComponent();
        }

        public FormAtualizarInformacoes(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormAtualizarPesoAltura_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(conec.ConexaoBD());
            string sqlSelect = @"SELECT altura, peso FROM aluno WHERE idaluno = @id;";
            SqlCommand cmdSelect = new SqlCommand(sqlSelect, cn);
            cmdSelect.Parameters.AddWithValue("@id", id);
            cn.Open();
            cmdSelect.CommandText = sqlSelect;
            cmdSelect.ExecuteNonQuery();
            SqlDataReader data = cmdSelect.ExecuteReader();
            if (data.Read())
            {
                mtbPeso.Text = data["peso"].ToString();
                mtbAltura.Text = data["altura"].ToString();
            }
            cn.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (mtbAltura.Text != "" || mtbPeso.Text != "")
            {
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mtbPeso.Clear();
                    mtbAltura.Clear();
                }
            }
            else
            {
                mtbPeso.Clear();
                mtbAltura.Clear();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {//btAtualizar
            #region Verificação de espaços

            try
            {
                if (mtbPeso.Text != "")
                {
                    int testePeso = int.Parse(mtbPeso.Text);
                }
                if (mtbAltura.Text != "")
                {
                    int testeAltura = int.Parse(mtbAltura.Text);
                }
            }
            catch
            {
                MessageBox.Show("Verifique se todos os campos numéricos foram preenchidos corretamente!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            #endregion

            try
            {
                SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                string sqlUpdate = "UPDATE aluno SET ";
                if (mtbPeso.Text != "")
                    sqlUpdate = sqlUpdate + "peso = @peso,";
                else
                    sqlUpdate = sqlUpdate + "peso = NULL,";
                if (mtbAltura.Text != "")
                    sqlUpdate = sqlUpdate + "altura = @altura";
                else
                    sqlUpdate = sqlUpdate + "altura = NULL";
                sqlUpdate = sqlUpdate + " WHERE idaluno = @id;";

                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn);
                cmdUpdate.Parameters.AddWithValue("id", id);
                cmdUpdate.Parameters.AddWithValue("altura", mtbAltura.Text);
                cmdUpdate.Parameters.AddWithValue("peso", mtbPeso.Text);
                cn.Open();
                cmdUpdate.CommandText = sqlUpdate;
                cmdUpdate.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Dados alterados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Retornar

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            Close();
        }

        private void FormInscreverAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                Close();
        }

        #endregion
    }
}
