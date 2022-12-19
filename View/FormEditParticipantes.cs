using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace academia.View
{
    public partial class FormEditParticipantes : Form
    {
        public FormEditParticipantes()
        {
            InitializeComponent();
        }

        private void FormEditarParticipantes_Load(object sender, EventArgs e)
        {
            AulaDAO aulaDAO = new AulaDAO();
            dgaulas.DataSource = aulaDAO.listarAulas();
            dgaulas.Columns["ID"].Visible = false;
            dgaulas.Columns["Nome"].Width = 320;
            dgaulas.Columns["Data"].Width = 150;
            dgaulas.Columns["Horário"].Width = 100;

            cbAlunos.SelectedIndex = 0;
            cbProfessores.SelectedIndex = 0;
        }

        private void dgaulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//cell click
            AlunoDAO alunoDAO = new AlunoDAO();
            int id = int.Parse(dgaulas.CurrentRow.Cells[0].Value.ToString());
            cbAlunos.DataSource = alunoDAO.listarAlunosEspecificos(id);
            cbAlunos.DisplayMember = "Nome";
            cbAlunos.ValueMember = "ID";
            cbAlunos.Text = "Selecione";

            ProfessorDAO professorDAO = new ProfessorDAO();
            cbProfessores.DataSource = professorDAO.listarProfsEspecificos(id);
            cbProfessores.DisplayMember = "Nome";
            cbProfessores.ValueMember = "ID";
            cbProfessores.Text = "Selecione";
        }
    }
}
