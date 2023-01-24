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
    public partial class FormAtualizarPesoAltura : Form
    {
        Conexao conec = new Conexao();
        int id = 0;

        public FormAtualizarPesoAltura()
        {
            InitializeComponent();
        }

        public FormAtualizarPesoAltura(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {//btAtualizar
            SqlConnection cn = new SqlConnection(conec.ConexaoBD());
            string sqlUpdate = "update aluno set peso = @peso, altura = @altura where idAluno = @id";
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

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if(mtbAltura.Text != "" || mtbPeso.Text != "")
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

        private void FormAtualizarPesoAltura_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(conec.ConexaoBD());
            string sqlSelect = @"select altura,peso from ALUNO where idAluno = @id";
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
