using academia.Class;
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
    public partial class FormEditarAula : Form
    {
        Conexao conec = new Conexao();
        int id = 0;

        public FormEditarAula()
        {
            InitializeComponent();
        }

        public FormEditarAula(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FormEditarAula_Load(object sender, EventArgs e)
        {

        }
    }
}
