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
    public partial class FormRelatorioAulas : Form
    {
        public FormRelatorioAulas()
        {
            InitializeComponent();
        }

        private void FormRelatorioAulas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_ACADEMIADataSet.RELATORIO_AULA'. Você pode movê-la ou removê-la conforme necessário.
            this.rELATORIO_AULATableAdapter.Fill(this.bD_ACADEMIADataSet.RELATORIO_AULA);
            // TODO: esta linha de código carrega dados na tabela 'bD_ACADEMIADataSet.RELATORIO_AULA'. Você pode movê-la ou removê-la conforme necessário.
            this.rELATORIO_AULATableAdapter.Fill(this.bD_ACADEMIADataSet.RELATORIO_AULA);
            // TODO: esta linha de código carrega dados na tabela 'bD_ACADEMIADataSet.AULA'. Você pode movê-la ou removê-la conforme necessário.
            this.reportViewer1.RefreshReport();
        }
    }
}
