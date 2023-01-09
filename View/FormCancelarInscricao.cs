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
using System.Windows.Forms;

namespace academia.View
{
    public partial class FormCancelarInscricao : Form
    {
        Conexao conec = new Conexao();
        AulaDAO aulaDAO = new AulaDAO();
        bool carregouForm = false;
        string nome = "";
        int id = 0;
        int idAula = 0;
        int contador = 0;
        string testeContador = "";

        public FormCancelarInscricao()
        {
            InitializeComponent();
        }

        public FormCancelarInscricao(int id, string nome)
        {
            InitializeComponent();
            this.id = id;
            this.nome = nome;
        }

        private void FormEditarParticipantes_Load(object sender, EventArgs e)
        {
            cbAula.SelectedIndex = 0;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {//btCancelar
            if (mtbData.Text == "" || tbHora.Text == "" || tbProfessor.Text == "")
                MessageBox.Show("Selecione a aula que deseja se cancelar a inscrição!", "Cancelar inscrição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                    string sqlDelete = "";
                    sqlDelete = @"DELETE FROM participante WHERE id_aula = @idaula AND id_aluno = @idaluno;
                            UPDATE aula SET contador =";
                    if (testeContador == "")
                        sqlDelete = sqlDelete + " NULL WHERE idaula = @idaula;";
                    else
                        sqlDelete = sqlDelete + " @contador WHERE idaula = @idaula;";

                    SqlCommand cmdDelete = new SqlCommand(sqlDelete, cn);

                    cmdDelete.Parameters.AddWithValue("@idaula", idAula);
                    cmdDelete.Parameters.AddWithValue("@idaluno", id);
                    cmdDelete.Parameters.AddWithValue("@contador", contador - 1);

                    cn.Open();
                    cmdDelete.CommandText = sqlDelete;
                    cmdDelete.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Inscrição cancelada com sucesso!", "Cancelar inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbAula.DataSource = null;
                    cbAula.Items.Add("Selecione");
                    cbAula.SelectedIndex = 0;
                    tbProfessor.Clear();
                    mtbData.Clear();
                    tbHora.Clear();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAula_SelectedIndexChanged(object sender, EventArgs e)
        {//item changed AULA
            if (carregouForm)
            {
                if (cbAula.DataSource != null)
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                        string sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', contador AS 'Contador', professor.nome AS 'Professor'
                        FROM aula INNER JOIN professor ON professor.idprofessor = aula.id_professor WHERE idaula = @idaula";
                        SqlCommand cmd = new SqlCommand(sql, cn);

                        idAula = int.Parse(cbAula.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@idaula", int.Parse(cbAula.SelectedValue.ToString()));

                        cn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        SqlDataReader data = cmd.ExecuteReader();
                        if (data.Read())
                        {
                            tbProfessor.Text = data["Professor"].ToString();
                            mtbData.Text = data["Data"].ToString();
                            tbHora.Text = data["Horário"].ToString();
                            testeContador = data["Contador"].ToString();
                            if (testeContador != "")
                                contador = int.Parse(testeContador);
                        }
                        cn.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbAula_Click(object sender, EventArgs e)
        {//click - cbAula
            try
            {
                SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                string sql = @"SELECT * FROM participante WHERE id_aluno = @idaluno";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@idaluno", id);

                cn.Open();
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    cbAula.DataSource = aulaDAO.listarAulasFiltradas(id);
                    cbAula.ValueMember = "ID";
                    cbAula.DisplayMember = "Aula";
                    carregouForm = true;
                }
                else
                    MessageBox.Show("Nenhuma inscrição foi realizada!", "Cancelar inscrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
