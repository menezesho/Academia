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
    public partial class FormCancelarInscricao : Form
    {
        AulaDAO aulaDAO = new AulaDAO();
        string nome = "";
        int id = 0;

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
            tbNome.Text = nome;
            cbAula.DataSource = aulaDAO.listarAulasFiltradas(id);
            cbAula.ValueMember = "ID";
            cbAula.DisplayMember = "Name";
        }
    }
}
