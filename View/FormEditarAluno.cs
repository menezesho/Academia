using academia.Class;
using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormEditarAluno : Form
    {
        Conexao conec = new Conexao();
        Verificacao verificacao = new Verificacao();
        AlunoDAO alunoDAO = new AlunoDAO();
        int id = 0;

        public FormEditarAluno()
        {
            InitializeComponent();
        }

        public void tempoMsgBox()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            SendKeys.SendWait("{ENTER}");
        }

        private void FormEditAluno_Load(object sender, EventArgs e)
        {
            dgalunos.DataSource = alunoDAO.listarAlunos();

            //set
            //dgalunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgalunos.Columns["ID"].Width = 40;
            dgalunos.Columns["Nome"].Width = 200;
            dgalunos.Columns["CPF"].Width = 90;
            dgalunos.Columns["Idade"].Width = 40;
            dgalunos.Columns["Celular"].Width = 90;
            dgalunos.Columns["E-mail"].Width = 200;
            dgalunos.Columns["Peso(kg)"].Width = 60;
            dgalunos.Columns["Altura(cm)"].Width = 70;
            dgalunos.Columns["Rua"].Width = 160;
            dgalunos.Columns["Num."].Width = 40;
            dgalunos.Columns["Apto."].Width = 40;
            dgalunos.Columns["Bairro"].Width = 160;
            dgalunos.Columns["Cidade"].Width = 160;
            dgalunos.Columns["Estado"].Width = 50;
            dgalunos.Columns["Usuário"].Width = 100;
            dgalunos.Columns["Senha"].Visible = false;

            //min
            //dgalunos.Columns["ID"].MinimumWidth = 40;
            //dgalunos.Columns["Nome"].MinimumWidth = 200;
            //dgalunos.Columns["CPF"].MinimumWidth = 90;
            //dgalunos.Columns["Idade"].MinimumWidth = 40;
            //dgalunos.Columns["Celular"].MinimumWidth = 90;
            //dgalunos.Columns["E-mail"].MinimumWidth = 200;
            //dgalunos.Columns["Peso(kg)"].MinimumWidth = 60;
            //dgalunos.Columns["Altura(cm)"].MinimumWidth = 70;
            //dgalunos.Columns["Rua"].MinimumWidth = 160;
            //dgalunos.Columns["Num."].MinimumWidth = 40;
            //dgalunos.Columns["Apto."].MinimumWidth = 40;
            //dgalunos.Columns["Bairro"].MinimumWidth = 160;
            //dgalunos.Columns["Cidade"].MinimumWidth = 160;
            //dgalunos.Columns["Estado"].MinimumWidth = 50;
            //dgalunos.Columns["Usuário"].MinimumWidth = 100;

            id = 0;
            tbNome.Clear();
            mtbCpf.Clear();
            mtbIdade.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
            mtbPeso.Clear();
            mtbAltura.Clear();
            tbRua.Clear();
            mtbNumero.Clear();
            mtbApto.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedIndex = 0;
            tbUsuario.Clear();
            tbSenha.Clear();

            tbNome.Enabled = false;
            mtbIdade.Enabled = false;
            mtbCelular.Enabled = false;
            tbEmail.Enabled = false;
            mtbPeso.Enabled = false;
            mtbAltura.Enabled = false;
            tbRua.Enabled = false;
            mtbNumero.Enabled = false;
            mtbApto.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            cbEstado.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;

            tbBusca.Clear();

            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
        }

        public void dgalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            id = int.Parse(dgalunos.CurrentRow.Cells[0].Value.ToString());
            tbNome.Text = dgalunos.CurrentRow.Cells[1].Value.ToString();
            mtbCpf.Text = dgalunos.CurrentRow.Cells[2].Value.ToString();
            mtbIdade.Text = dgalunos.CurrentRow.Cells[3].Value.ToString();
            mtbCelular.Text = dgalunos.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = dgalunos.CurrentRow.Cells[5].Value.ToString();
            mtbPeso.Text = dgalunos.CurrentRow.Cells[6].Value.ToString();
            mtbAltura.Text = dgalunos.CurrentRow.Cells[7].Value.ToString();
            tbRua.Text = dgalunos.CurrentRow.Cells[8].Value.ToString();
            mtbNumero.Text = dgalunos.CurrentRow.Cells[9].Value.ToString();
            mtbApto.Text = dgalunos.CurrentRow.Cells[10].Value.ToString();
            tbBairro.Text = dgalunos.CurrentRow.Cells[11].Value.ToString();
            tbCidade.Text = dgalunos.CurrentRow.Cells[12].Value.ToString();
            cbEstado.Text = dgalunos.CurrentRow.Cells[13].Value.ToString();
            tbUsuario.Text = dgalunos.CurrentRow.Cells[14].Value.ToString();
            tbSenha.Text = dgalunos.CurrentRow.Cells[15].Value.ToString();

            tbNome.Enabled = true;
            mtbIdade.Enabled = true;
            mtbCelular.Enabled = true;
            tbEmail.Enabled = true;
            mtbPeso.Enabled = true;
            mtbAltura.Enabled = true;
            tbRua.Enabled = true;
            mtbNumero.Enabled = true;
            mtbApto.Enabled = true;
            tbBairro.Enabled = true;
            tbCidade.Enabled = true;
            cbEstado.Enabled = true;
            tbUsuario.Enabled = true;
            tbSenha.Enabled = true;

            tcDados.SelectedTab = tpDadosPessoais;
        }

        private void lbLimparBusca_Click(object sender, EventArgs e)
        {//lbLimparBusca
            tbBusca.Text = " Busca...";
            tbBusca.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            dgalunos.DataSource = alunoDAO.listarAlunos();
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
                lbTipoFiltro.Text = "x CPF";
            if (cbFiltro.SelectedIndex == 2)
                lbTipoFiltro.Text = "x E-mail";
            if (cbFiltro.SelectedIndex == 3)
                lbTipoFiltro.Text = "x Usuário";
        }

        private void lbBuscar_Click(object sender, EventArgs e)
        {//lbBuscar
            if (cbFiltro.SelectedItem == null)
                MessageBox.Show("Selecione o filtro!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE nome LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 1)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE cpf LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 2)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE email LIKE @busca ORDER BY nome";
                        }
                        if (cbFiltro.SelectedIndex == 3)
                        {
                            sql = @"SELECT idaluno AS ID, nome AS Nome, cpf AS CPF, idade AS Idade, celular AS Celular, email AS 'E-mail',
                                peso AS 'Peso(kg)', altura AS 'Altura(cm)', rua AS Rua, numero AS 'Num.', apto AS 'Apto.', bairro AS Bairro,
                                cidade AS Cidade, estado AS Estado, usuario AS Usuário, senha AS Senha FROM aluno WHERE usuario LIKE @busca ORDER BY nome";
                        }
                        SqlCommand cmd = new SqlCommand(sql, cn);

                        cmd.Parameters.AddWithValue("@busca", "%" + tbBusca.Text + "%");

                        Thread click = new Thread(new ThreadStart(tempoMsgBox));
                        click.Start();
                        MessageBox.Show("Buscando...", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        click.Abort();

                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dgalunos.DataSource = ds.Tables[0];
                        cn.Close();
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
                id = 0;
                tbNome.Clear();
                mtbCpf.Clear();
                mtbIdade.Clear();
                mtbCelular.Clear();
                tbEmail.Clear();
                mtbPeso.Clear();
                mtbAltura.Clear();
                tbRua.Clear();
                mtbNumero.Clear();
                mtbApto.Clear();
                tbBairro.Clear();
                tbCidade.Clear();
                cbEstado.SelectedIndex = 0;
                tbUsuario.Clear();
                tbSenha.Clear();

                tbNome.Enabled = false;
                mtbIdade.Enabled = false;
                mtbCelular.Enabled = false;
                tbEmail.Enabled = false;
                mtbPeso.Enabled = false;
                mtbAltura.Enabled = false;
                tbRua.Enabled = false;
                mtbNumero.Enabled = false;
                mtbApto.Enabled = false;
                tbBairro.Enabled = false;
                tbCidade.Enabled = false;
                cbEstado.Enabled = false;
                tbUsuario.Enabled = false;
                tbSenha.Enabled = false;

                tcDados.SelectedTab = tpDadosPessoais;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {//btExcluir
            if (id == 0)
                MessageBox.Show("Nenhum aluno foi selecionado!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Deseja mesmo excluir o cadastro deste aluno?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(conec.ConexaoBD());

                        string sqlDelete = @"DELETE FROM aluno WHERE IDALUNO = @idaluno;
                            DELETE FROM participante WHERE id_aluno = @idaluno;";
                        SqlCommand cmdDelete = new SqlCommand(sqlDelete, cn);

                        cmdDelete.Parameters.AddWithValue("@idaluno", id);

                        cn.Open();
                        cmdDelete.CommandText = sqlDelete;
                        cmdDelete.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Cadastro excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgalunos.DataSource = alunoDAO.listarAlunos();

                        id = 0;
                        tbNome.Clear();
                        mtbCpf.Clear();
                        mtbIdade.Clear();
                        mtbCelular.Clear();
                        tbEmail.Clear();
                        mtbPeso.Clear();
                        mtbAltura.Clear();
                        tbRua.Clear();
                        mtbNumero.Clear();
                        mtbApto.Clear();
                        tbBairro.Clear();
                        tbCidade.Clear();
                        cbEstado.SelectedIndex = 0;
                        tbUsuario.Clear();
                        tbSenha.Clear();

                        tbNome.Enabled = false;
                        mtbIdade.Enabled = false;
                        mtbCelular.Enabled = false;
                        tbEmail.Enabled = false;
                        mtbPeso.Enabled = false;
                        mtbAltura.Enabled = false;
                        tbRua.Enabled = false;
                        mtbNumero.Enabled = false;
                        mtbApto.Enabled = false;
                        tbBairro.Enabled = false;
                        tbCidade.Enabled = false;
                        cbEstado.Enabled = false;
                        tbUsuario.Enabled = false;
                        tbSenha.Enabled = false;

                        tcDados.SelectedTab = tpDadosPessoais;
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
            if (id == 0)
                MessageBox.Show("Nenhum aluno foi selecionado!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (tbNome.Text.Trim() == "" || mtbCpf.Text == "" || mtbIdade.Text == "" || mtbCelular.Text == "" || tbEmail.Text.Trim() == "" || tbRua.Text.Trim() == "" || mtbNumero.Text == "" || tbBairro.Text.Trim() == "" || tbCidade.Text.Trim() == "" || cbEstado.SelectedIndex == 0 || tbUsuario.Text.Trim() == "" || tbSenha.Text == "")
                    MessageBox.Show("Os campos obrigatórios não foram preenchidos!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    #region Verificação de espaços

                    try
                    {
                        int testeIdade = int.Parse(mtbIdade.Text);
                        int testeNumero = int.Parse(mtbNumero.Text);
                        if (mtbPeso.Text != "")
                        {
                            int testePeso = int.Parse(mtbPeso.Text);
                        }
                        if (mtbAltura.Text != "")
                        {
                            int testeAltura = int.Parse(mtbAltura.Text);
                        }
                        if (mtbApto.Text != "")
                        {
                            int testeApto = int.Parse(mtbApto.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Verifique se todos os campos numéricos foram preenchidos corretamente!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                    #endregion

                    var emailVerificado = verificacao.verificarEmail(tbEmail.Text.Trim());
                    var cpfVerificado = Verificacao.verificarCpf(mtbCpf.Text);
                    var celularVerificado = Verificacao.verificarCelular(mtbCelular.Text);
                    if (cpfVerificado)
                    {
                        if (celularVerificado)
                        {
                            if (emailVerificado)
                            {
                                try
                                {
                                    SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                                    string sqlValidaUsuario = @"SELECT usuario FROM aluno WHERE usuario = @usuario AND idaluno != @id;";
                                    SqlCommand cmdValidaUsuario = new SqlCommand(sqlValidaUsuario, cn);

                                    cmdValidaUsuario.Parameters.AddWithValue("@id", id);
                                    cmdValidaUsuario.Parameters.AddWithValue("@usuario", tbUsuario.Text);

                                    cn.Open();
                                    cmdValidaUsuario.CommandText = sqlValidaUsuario;
                                    cmdValidaUsuario.ExecuteNonQuery();
                                    SqlDataReader dataValidaUsuario = cmdValidaUsuario.ExecuteReader();
                                    if (dataValidaUsuario.Read())
                                    {
                                        cn.Close();
                                        MessageBox.Show("Este usuário já está em uso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        cn.Close();
                                        //preparado para a string de insert muito louca?

                                        string sqlUpdate = @"UPDATE aluno SET nome=@nome, idade=@idade, celular=@celular, email=@email, rua=@rua, numero=@numero, bairro=@bairro, cidade=@cidade, estado=@estado, usuario=@usuario, senha=@senha";

                                        if (mtbPeso.Text != "")
                                            sqlUpdate = sqlUpdate + ", peso='" + int.Parse(mtbPeso.Text) + "'";
                                        else
                                            sqlUpdate = sqlUpdate + ", peso=NULL";
                                        if (mtbAltura.Text != "")
                                            sqlUpdate = sqlUpdate + ", altura='" + int.Parse(mtbAltura.Text) + "'";
                                        else
                                            sqlUpdate = sqlUpdate + ", altura=NULL";
                                        if (mtbApto.Text != "")
                                            sqlUpdate = sqlUpdate + ", apto='" + int.Parse(mtbApto.Text) + "'";
                                        else
                                            sqlUpdate = sqlUpdate + ", apto=NULL";

                                        sqlUpdate = sqlUpdate + " WHERE idaluno=@idaluno";

                                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn);

                                        cmdUpdate.Parameters.AddWithValue("@idaluno", id);
                                        cmdUpdate.Parameters.AddWithValue("@nome", tbNome.Text.Trim());
                                        cmdUpdate.Parameters.AddWithValue("@idade", int.Parse(mtbIdade.Text));
                                        cmdUpdate.Parameters.AddWithValue("@celular", mtbCelular.Text);
                                        cmdUpdate.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                                        cmdUpdate.Parameters.AddWithValue("@rua", tbRua.Text.Trim());
                                        cmdUpdate.Parameters.AddWithValue("@numero", mtbNumero.Text);
                                        cmdUpdate.Parameters.AddWithValue("@bairro", tbBairro.Text.Trim());
                                        cmdUpdate.Parameters.AddWithValue("@cidade", tbCidade.Text.Trim());
                                        cmdUpdate.Parameters.AddWithValue("@estado", cbEstado.Text);
                                        cmdUpdate.Parameters.AddWithValue("@usuario", tbUsuario.Text.Trim());
                                        cmdUpdate.Parameters.AddWithValue("@senha", tbSenha.Text);

                                        cn.Open();
                                        cmdUpdate.CommandText = sqlUpdate;
                                        cmdUpdate.ExecuteNonQuery();
                                        cn.Close();
                                        MessageBox.Show("Dados alterados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        dgalunos.DataSource = alunoDAO.listarAlunos();

                                        id = 0;
                                        tbNome.Clear();
                                        mtbCpf.Clear();
                                        mtbIdade.Clear();
                                        mtbCelular.Clear();
                                        tbEmail.Clear();
                                        mtbPeso.Clear();
                                        mtbAltura.Clear();
                                        tbRua.Clear();
                                        mtbNumero.Clear();
                                        mtbApto.Clear();
                                        tbBairro.Clear();
                                        tbCidade.Clear();
                                        cbEstado.SelectedIndex = 0;
                                        tbUsuario.Clear();
                                        tbSenha.Clear();

                                        tbNome.Enabled = false;
                                        mtbIdade.Enabled = false;
                                        mtbCelular.Enabled = false;
                                        tbEmail.Enabled = false;
                                        mtbPeso.Enabled = false;
                                        mtbAltura.Enabled = false;
                                        tbRua.Enabled = false;
                                        mtbNumero.Enabled = false;
                                        mtbApto.Enabled = false;
                                        tbBairro.Enabled = false;
                                        tbCidade.Enabled = false;
                                        cbEstado.Enabled = false;
                                        tbUsuario.Enabled = false;
                                        tbSenha.Enabled = false;

                                        tcDados.SelectedTab = tpDadosPessoais;
                                    }
                                }
                                catch (Exception erro)
                                {
                                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("O E-mail informado é inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tcDados.SelectedTab = tpDadosPessoais;
                                tbEmail.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("O número de celular informado é inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tcDados.SelectedTab = tpDadosPessoais;
                            mtbCelular.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O CPF informado é inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tcDados.SelectedTab = tpDadosPessoais;
                        mtbCpf.Focus();
                    }
                }
            }
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {//btRelatorio
            if (MessageBox.Show("Deseja gerar um relatório de todos os alunos?", "Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(conec.ConexaoBD());
                string endereco = "C:\\Sistemas\\academia\\Relatórios\\relatorio-alunos.csv";
                using (StreamWriter writer = new StreamWriter(endereco, false, Encoding.GetEncoding("iso-8859-15")))
                {
                    writer.WriteLine("ID;Nome;CPF;Idade;Celular;E-mail;Usuário;Peso;Altura;Rua;Número;Apto;Bairro;Cidade;Estado");
                    using (SqlConnection conn = new SqlConnection(conec.ConexaoBD()))
                    {
                        string query = "SELECT * FROM ALUNO;";
                        SqlCommand sqlComand = new SqlCommand(query, conn);
                        conn.Open();
                        using (IDataReader reader = sqlComand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                writer.WriteLine(Convert.ToString(reader["idaluno"]) + ";" +
                                    Convert.ToString(reader["nome"]) + ";" +
                                    Convert.ToString(reader["cpf"]) + ";" +
                                    Convert.ToString(reader["idade"]) + ";" +
                                    Convert.ToString(reader["celular"]) + ";" +
                                    Convert.ToString(reader["email"]) + ";" +
                                    Convert.ToString(reader["usuario"]) + ";" +
                                    Convert.ToString(reader["peso"]) + ";" +
                                    Convert.ToString(reader["altura"]) + ";" +
                                    Convert.ToString(reader["rua"]) + ";" +
                                    Convert.ToString(reader["numero"]) + ";" +
                                    Convert.ToString(reader["apto"]) + ";" +
                                    Convert.ToString(reader["bairro"]) + ";" +
                                    Convert.ToString(reader["cidade"]) + ";" +
                                    Convert.ToString(reader["estado"]));
                            }
                        }
                        conn.Close();
                    }
                }
                MessageBox.Show("Relatório gerado com sucesso!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Retornar

        private void FormListAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (tbNome.Text == "" && mtbCpf.Text == "" && mtbCelular.Text == "" && mtbIdade.Text == "" && tbEmail.Text == "" && tbRua.Text == "" && mtbNumero.Text == "" && mtbApto.Text == "" && cbEstado.SelectedIndex == 0 && tbCidade.Text == "" && tbBairro.Text == "" && mtbPeso.Text == "" && mtbAltura.Text == "" && tbUsuario.Text == "" && tbSenha.Text == "")
                    Close();
                else
                {
                    if (MessageBox.Show("Os dados não salvos serão perdidos!\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        Close();
                }
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (tbNome.Text == "" && mtbCpf.Text == "" && mtbCelular.Text == "" && mtbIdade.Text == "" && tbEmail.Text == "" && tbRua.Text == "" && mtbNumero.Text == "" && mtbApto.Text == "" && cbEstado.SelectedIndex == 0 && tbCidade.Text == "" && tbBairro.Text == "" && mtbPeso.Text == "" && mtbAltura.Text == "" && tbUsuario.Text == "" && tbSenha.Text == "")
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

    }
}
