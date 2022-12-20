using academia;
using academia.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormPrincipal : Form
    {
        public string usuarioAtual = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioAtual = usuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        #region Menu

        private void btCadAula_Click(object sender, EventArgs e)
        {//btCadAula
            FormCadAula Fcaula = new FormCadAula();
            Fcaula.ShowDialog();
        }

        private void btCadAluno_Click(object sender, EventArgs e)
        {//btCadAluno
            FormCadAluno Fca = new FormCadAluno();
            Fca.ShowDialog();
        }

        private void btCadProf_Click(object sender, EventArgs e)
        {//btCadProf
            FormCadProf Fcp = new FormCadProf();
            Fcp.ShowDialog();
        }

        private void btEditAula_Click(object sender, EventArgs e)
        {//btEditAula
            FormEditAula Feaula = new FormEditAula();
            Feaula.ShowDialog();
        }

        private void btEditAluno_Click(object sender, EventArgs e)
        {//btEditAluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.ShowDialog();
        }

        private void btEditProf_Click(object sender, EventArgs e)
        {//btEditProf
            FormEditProf Fep = new FormEditProf();
            Fep.ShowDialog();
        }

        private void btInscreverAluno_Click(object sender, EventArgs e)
        {//btInscreverAluno
            FormInscrever Fi = new FormInscrever();
            Fi.ShowDialog();
        }

        private void btEditParticipantes_Click(object sender, EventArgs e)
        {//btEditParticipantes
            FormEditParticipantes Feparticipantes = new FormEditParticipantes();
            Feparticipantes.ShowDialog();
        }

        #endregion

        #region Retornar

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar para a tela de login?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Deseja mesmo retornar para a tela de login?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }

        #endregion
    }
}
