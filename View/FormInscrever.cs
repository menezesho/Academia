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
        bool carregouForm = false;
        string nome = "";
        int id = 0;

        public FormInscrever()
        {
            InitializeComponent();
        }

        public FormInscrever(int id, string nome)
        {
            InitializeComponent();
            this.id = id;
            this.nome = nome;
        }

        //public void tempoMsgBox()
        //{
        //    Thread.Sleep(TimeSpan.FromSeconds(1));
        //    SendKeys.SendWait("{ENTER}");
        //}

        private void FormInserirNaAula_Load(object sender, EventArgs e)
        {
            cbAula.SelectedIndex = 0;
        }

        private void btInscrever_Click(object sender, EventArgs e)
        {//btInscrever

        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            if (carregouForm)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.ConexaoBD());
                    string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', professor.nome AS 'Professor' FROM aula INNER JOIN professor
                        ON professor.idprofessor = aula.id_professor
                        WHERE idaula=@idaula";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));

                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    SqlDataReader dados = comando.ExecuteReader();
                    if (dados.Read())
                    {
                        tbProfessor.Text = dados["Professor"].ToString();
                        mtbData.Text = dados["Data"].ToString();
                        tbHora.Text = dados["Horário"].ToString();
                    }
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAula_Click(object sender, EventArgs e)
        {
            if (!carregouForm)
            {
                cbAula.DataSource = aulaDAO.listarAulas();
                cbAula.ValueMember = "ID";
                cbAula.DisplayMember = "Aula";
                carregouForm = true;
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
