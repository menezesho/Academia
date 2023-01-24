using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class FormEditarAula : Form
    {
        Conexao conec = new Conexao();
        AulaDAO aulaDAO = new AulaDAO();
        int id = 0;
        int contador = 0;
        int idAula = 0;
        int totalAtual = 0;

        public FormEditarAula()
        {
            InitializeComponent();
        }

        public FormEditarAula(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void tempoMsgBox()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait("{ENTER}");
        }

        private void FormEditarAula_Load(object sender, EventArgs e)
        {
            dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);

            //set
            dgaulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgaulas.Columns["ID"].Width = 40;
            dgaulas.Columns["Aula"].Width = 250;
            dgaulas.Columns["Data"].Width = 90;
            dgaulas.Columns["Horário"].Width = 60;
            dgaulas.Columns["Máx. Alunos"].Width = 60;
            dgaulas.Columns["Professor"].Width = 150;
            dgaulas.Columns["Contador"].Visible = false;

            idAula = 0;
            tbNome.Clear();
            mtbTotal.Clear();
            cbHora.SelectedIndex = 0;

            tbNome.Enabled = false;
            mtbTotal.Enabled = false;
            dtpData.Enabled = false;
            cbHora.Enabled = false;

            tbBusca.Clear();

            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
        }

        private void dgaulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            idAula = int.Parse(dgaulas.CurrentRow.Cells[0].Value.ToString());
            tbNome.Text = dgaulas.CurrentRow.Cells[1].Value.ToString();
            dtpData.Text = dgaulas.CurrentRow.Cells[2].Value.ToString();
            cbHora.Text = dgaulas.CurrentRow.Cells[3].Value.ToString();
            mtbTotal.Text = dgaulas.CurrentRow.Cells[4].Value.ToString();
            if (dgaulas.CurrentRow.Cells[4].Value.ToString() != "")
                totalAtual = int.Parse(dgaulas.CurrentRow.Cells[4].Value.ToString());
            if (dgaulas.CurrentRow.Cells[5].Value.ToString() != "")
                contador = int.Parse(dgaulas.CurrentRow.Cells[5].Value.ToString());

            tbNome.Enabled = true;
            mtbTotal.Enabled = true;
            dtpData.Enabled = true;
            cbHora.Enabled = true;
        }

        private void lbLimparBusca_Click(object sender, EventArgs e)
        {//lbLimparBusca
            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);
            dgaulas.Columns["Contador"].Visible = false;
            lbBuscar.Focus();
        }

        private void lbTipoFiltro_Click(object sender, EventArgs e)
        {//lbTipoFiltro
            lbTipoFiltro.Text = "";
            cbFiltro.SelectedItem = null;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {//index change cbTipoFiltro
            if (cbFiltro.SelectedIndex == 0)
                lbTipoFiltro.Text = "x Nome";
            if (cbFiltro.SelectedIndex == 1)
                lbTipoFiltro.Text = "x Data";
        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {//lbBuscar
            if (cbFiltro.SelectedItem == null)
                MessageBox.Show("Nenhum filtro foi selecionado!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (tbBusca.Text == "" || tbBusca.Text == " Busca...")
                    MessageBox.Show("Digite o que deseja buscar!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    { 
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                        string sql = "";
                        if (cbFiltro.SelectedIndex == 0)
                        {
                            sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', aula.total AS 'Máx. Alunos', p.nome AS 'Professor', aula.contador AS 'Contador'
                                FROM aula inner JOIN professor AS p ON aula.id_professor = p.idprofessor
                                WHERE aula.id_professor = @id AND aula.nome LIKE @busca ORDER BY aula.nome";
                        }
                        if (cbFiltro.SelectedIndex == 1)
                        {
                            sql = @"SELECT aula.idaula AS 'ID', aula.nome AS 'Aula', aula.dia AS 'Data', aula.hora AS 'Horário', aula.total AS 'Máx. Alunos', p.nome AS 'Professor', aula.contador AS 'Contador'
                                FROM aula inner JOIN professor AS p ON aula.id_professor = p.idprofessor
                                WHERE aula.id_professor = @id AND aula.dia LIKE @busca ORDER BY aula.nome";
                        }
                        SqlCommand cmd = new SqlCommand(sql, cn);

                        cmd.Parameters.AddWithValue("@busca", "%" + tbBusca.Text + "%");
                        cmd.Parameters.AddWithValue("@id", id);

                        Thread click = new Thread(new ThreadStart(tempoMsgBox));
                        click.Start();
                        MessageBox.Show("Buscando...", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        click.Abort();

                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgaulas.DataSource = ds.Tables[0];
                        cn.Close();
                        dgaulas.Columns["Contador"].Visible = false;

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                idAula = 0;
                tbNome.Clear();
                mtbTotal.Clear();
                cbHora.SelectedIndex = 0;

                tbNome.Enabled = false;
                mtbTotal.Enabled = false;
                dtpData.Enabled = false;
                cbHora.Enabled = false;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (idAula == 0)
                MessageBox.Show("Nenhuma aula foi selecionada!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Deseja mesmo excluir esta aula?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                        string sqlDelete = @"DELETE FROM aula WHERE idaula = @idaula";
                        SqlCommand cmdDelete = new SqlCommand(sqlDelete, cn);

                        cmdDelete.Parameters.AddWithValue("@idaula", idAula);

                        cn.Open();
                        cmdDelete.CommandText = sqlDelete;
                        cmdDelete.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Aula excluída com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);
                        dgaulas.Columns["Contador"].Visible = false;

                        idAula = 0;
                        tbNome.Clear();
                        mtbTotal.Clear();
                        cbHora.SelectedIndex = 0;

                        tbNome.Enabled = false;
                        mtbTotal.Enabled = false;
                        dtpData.Enabled = false;
                        cbHora.Enabled = false;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar

            #region Verificação de espaços
            if (mtbTotal.Text != "")
            {
                try
                {
                    int testeTotal = int.Parse(mtbTotal.Text);
                }
                catch
                {
                    MessageBox.Show("O máximo de alunos informado não é válido, tente novamente!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            #endregion 

            if (idAula == 0)
                MessageBox.Show("Nenhuma aula foi selecionada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (tbNome.Text.Trim() == "" || cbHora.SelectedIndex == 0)
                    MessageBox.Show("Os campos obrigatórios não foram preenchidos!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                        string sqlVerificaDiaHora = @"SELECT * FROM aula WHERE (dia = @data AND hora = @hora) AND idaula != @idaula";
                        SqlCommand cmdVerificaDiaHora = new SqlCommand(sqlVerificaDiaHora, cn);

                        cmdVerificaDiaHora.Parameters.AddWithValue("@idaula", idAula);
                        cmdVerificaDiaHora.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                        cmdVerificaDiaHora.Parameters.AddWithValue("@hora", cbHora.Text);

                        cn.Open();
                        SqlDataReader dataVerificaDataHora = cmdVerificaDiaHora.ExecuteReader();
                        if (dataVerificaDataHora.Read())
                        {
                            MessageBox.Show("Conflito de data e hora, tente novamente!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cn.Close();
                        }
                        else
                        {
                            cn.Close();
                            string sqlUpdate = @"UPDATE aula SET nome = @nome, dia = @data, hora = @hora,";
                            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn);

                            if (mtbTotal.Text != "")
                            {
                                if (contador <= int.Parse(mtbTotal.Text))
                                {
                                    if (int.Parse(mtbTotal.Text) != 0)
                                        sqlUpdate = sqlUpdate + " total = " + int.Parse(mtbTotal.Text);
                                    else
                                    {
                                        MessageBox.Show("O máximo de alunos deve ser maior que zero!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }
                                }
                                else
                                {
                                    sqlUpdate = sqlUpdate + " total = " + totalAtual;
                                    MessageBox.Show("O máximo de alunos informado não é válido, pois já existem " + contador + " alunos inscritos!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                sqlUpdate = sqlUpdate + " total = NULL";
                            }
                            sqlUpdate = sqlUpdate + " WHERE idaula = @idaula";

                            cmdUpdate.Parameters.AddWithValue("@idaula", idAula);
                            cmdUpdate.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                            cmdUpdate.Parameters.AddWithValue("@data", Convert.ToDateTime(dtpData.Text));
                            cmdUpdate.Parameters.AddWithValue("@hora", cbHora.Text);
                            cmdUpdate.Parameters.AddWithValue("@contador", contador);

                            cn.Open();
                            cmdUpdate.CommandText = sqlUpdate;
                            cmdUpdate.ExecuteNonQuery();
                            cn.Close();

                            MessageBox.Show("Dados alterados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgaulas.DataSource = aulaDAO.listarAulasProfessor(id);
                            dgaulas.Columns["Contador"].Visible = false;
                            idAula = 0;
                            tbNome.Clear();
                            mtbTotal.Clear();
                            cbHora.SelectedIndex = 0;
                            tbNome.Enabled = false;
                            mtbTotal.Enabled = false;
                            dtpData.Enabled = false;
                            cbHora.Enabled = false;
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region Retornar

        private void FormListAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (tbNome.Text == "" && cbHora.SelectedIndex == 0 && mtbTotal.Text == "")
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

        #region Máscara - Busca

        private void tbBusca_Enter(object sender, EventArgs e)
        {
            if (tbBusca.Text == "" || tbBusca.Text == " Busca...")
            {
                tbBusca.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                tbBusca.Text = "";
            }
        }

        private void tbBusca_Leave(object sender, EventArgs e)
        {
            if (tbBusca.Text == "")
            {
                tbBusca.Text = " Busca...";
                tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            }
        }

        #endregion

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
