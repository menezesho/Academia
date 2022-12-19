using academia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace academia
{
    public partial class FormEditAula : Form
    {
        public FormEditAula()
        {
            InitializeComponent();
        }

        private void FormEditAula_Load(object sender, EventArgs e)
        {
            AulaDAO aulaDAO = new AulaDAO();
            dgaulas.DataSource = aulaDAO.listarAulas();

            dgaulas.Columns["ID"].Width = 50;
            dgaulas.Columns["Nome"].Width = 420;
            dgaulas.Columns["Data"].Width = 120;
            dgaulas.Columns["Horário"].Width = 80;

            tbId.Clear();
            tbNome.Clear();
            tbId.Clear();
            dtpData.Text = "";
            cbHora.SelectedIndex = 0;
            tbId.Enabled = false;
            tbNome.Enabled = false;
            dtpData.Enabled = false;
            cbHora.Enabled = false;
            btEditar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            tbBusca.Clear();
        }

        #region Retornar

        private void FormEditAula_KeyDown(object sender, KeyEventArgs e)
        {//ESC para retornar
            if (e.KeyValue.Equals(27))
                if (MessageBox.Show("Todos os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Close();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {//lbSair
            if (MessageBox.Show("Os dados não salvos serão perdidos\nDeseja mesmo retornar?", "Retornar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        #endregion

    }
}
