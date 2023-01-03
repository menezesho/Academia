using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace academia
{
    public partial class FormInscrever : Form
    {
        Conexao conec = new Conexao();
        AulaDAO aulaDAO = new AulaDAO();
        AlunoDAO alunoDAO = new AlunoDAO();
        ProfessorDAO professorDAO = new ProfessorDAO();
        string nome = "";

        public FormInscrever()
        {
            InitializeComponent();
        }

        public FormInscrever(string nome)
        {
            InitializeComponent();
            this.nome = nome;
        }

        //public void tempoMsgBox()
        //{
        //    Thread.Sleep(TimeSpan.FromSeconds(1));
        //    SendKeys.SendWait("{ENTER}");
        //}

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            this.aULATableAdapter.Fill(this.bD_ACADEMIADataSet.AULA);
            tbNome.Text = nome;
            cbAula.Text = "Selecione";
            mtbData.Clear();
            tbHora.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cbAula.SelectedIndex = 0;
                mtbData.Clear();
                tbHora.Clear();
            }
        }

        private void btInscrever_Click(object sender, EventArgs e)
        {//btInscrever

        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            try
            {
                SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                string sql = @"SELECT * FROM aula WHERE idaula=@idaula";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));

                conexao.Open();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                SqlDataReader dados = comando.ExecuteReader();
                if (dados.Read())
                {
                    mtbData.Text = dados["dia"].ToString();
                    tbHora.Text = dados["hora"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region Retornar

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void FormInscreverAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        #endregion

    }
}
