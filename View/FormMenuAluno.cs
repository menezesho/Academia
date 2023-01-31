using academia.View;
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
    public partial class FormMenuAluno : Form
    {
        public string usuario = "";
        public string nome = "";
        public int id = 0;
        public int acesso = 1;

        public FormMenuAluno()
        {
            InitializeComponent();
        }

        public FormMenuAluno(string usuario, string nome, int id)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.nome = nome;
            this.id = id;
        }

        private void FormMenuAluno_Load(object sender, EventArgs e)
        {
            lbMensagem.Text = "Olá, " + nome + "!";
            lbInfoUsuario.Text = "Usuário: " + usuario.ToLower() + "\nNível de acesso: 1";
        }

        #region Menu

        private void btRealizarInscrição_Click(object sender, EventArgs e)
        {//btRealizarInscrição
            FormInscrever Fi = new FormInscrever(id, nome);
            Fi.ShowDialog();
        }

        private void btCancelarInscrição_Click(object sender, EventArgs e)
        {//btCancelarInscricao
            FormCancelarInscricao Fci = new FormCancelarInscricao(id, nome);
            Fci.ShowDialog();
        }

        private void btAtualizarPesoAltura_Click(object sender, EventArgs e)
        {//btAtualizarPesoAltura
            FormAtualizarInformacoes Fapa = new FormAtualizarInformacoes(id);
            Fapa.ShowDialog();
        }

        private void btRedefinirSenha_Click(object sender, EventArgs e)
        {//btAlterarSenha
            FormAlterarSenha Frs = new FormAlterarSenha(id, acesso);
            Frs.ShowDialog();
        }

        #endregion

        #region Retornar

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Deseja mesmo retornar para a tela de login?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void FormMenuAluno_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Deseja mesmo retornar para a tela de login?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void FormMenuAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }


        #endregion

    }
}
