using projetofinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class FormMenuAdmin : Form
    {
        public string usuario = "";
        public string nome = "";

        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        public FormMenuAdmin(string u, string n)
        {
            InitializeComponent();
            usuario = u;
            nome = n;
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            lbMensagem.Text = "Olá, " + nome + "!";
            lbInfoUsuario.Text = "Usuário: " + usuario.ToLower() + "\nNível de acesso: 3";
        }

        #region Menu

        private void btNovoAluno_Click(object sender, EventArgs e)
        {//btNovoAluno
            FormNovoAluno Fnaluno = new FormNovoAluno();
            Fnaluno.ShowDialog();
        }

        private void btEditarAluno_Click(object sender, EventArgs e)
        {//btEditarAluno
            FormEditarAluno Feaula = new FormEditarAluno();
            Feaula.ShowDialog();
        }

        private void btNovoProfessor_Click(object sender, EventArgs e)
        {//btNovoProfessor
            FormNovoProfessor Fnp = new FormNovoProfessor();
            Fnp.ShowDialog();
        }

        private void btEditarProfessor_Click(object sender, EventArgs e)
        {//btEditarProfessor
            FormEditarProf Fep = new FormEditarProf();
            Fep.ShowDialog();
        }

        #endregion

        #region Retornar

        private void FormMenuAdmin_KeyDown(object sender, KeyEventArgs e)
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

        private void FormMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }

        #endregion

    }
}
