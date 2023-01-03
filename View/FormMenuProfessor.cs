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
    public partial class FormMenuProfessor : Form
    {
        public string usuario = "";
        public string nome = "";
        public int id = 0;

        public FormMenuProfessor()
        {
            InitializeComponent();
        }

        public FormMenuProfessor(string usuario, string nome, int id)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.nome = nome;
            this.id = id;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lbMensagem.Text = "Olá, " + nome + "!";
            lbInfoUsuario.Text = "Usuário: " + usuario.ToLower() + "\nNível de acesso: 2";
        }

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

        #region Menu

        private void btNovaAula_Click(object sender, EventArgs e)
        {//btNovaAula
            FormNovaAula Fnaula = new FormNovaAula(id);
            Fnaula.ShowDialog();
        }

        private void btEditarAula_Click(object sender, EventArgs e)
        {//btEditarAula

        }

        private void btVerParticipantes_Click(object sender, EventArgs e)
        {//btVerParticipantes

        }

        private void btAjustes_Click(object sender, EventArgs e)
        {//btAjustes

        }

        #endregion

    }
}
