namespace academia
{
    partial class FormRelatorioAulas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioAulas));
            this.rELATORIOAULABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_ACADEMIADataSet = new academia.BD_ACADEMIADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rELATORIO_AULATableAdapter = new academia.BD_ACADEMIADataSetTableAdapters.RELATORIO_AULATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rELATORIOAULABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACADEMIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rELATORIOAULABindingSource
            // 
            this.rELATORIOAULABindingSource.DataMember = "RELATORIO_AULA";
            this.rELATORIOAULABindingSource.DataSource = this.bD_ACADEMIADataSet;
            this.rELATORIOAULABindingSource.CurrentChanged += new System.EventHandler(this.rELATORIOAULABindingSource_CurrentChanged);
            // 
            // bD_ACADEMIADataSet
            // 
            this.bD_ACADEMIADataSet.DataSetName = "BD_ACADEMIADataSet";
            this.bD_ACADEMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRelatorio";
            reportDataSource1.Value = this.rELATORIOAULABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "academia.relatorio-aulas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(804, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // rELATORIO_AULATableAdapter
            // 
            this.rELATORIO_AULATableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 649);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormRelatorioAulas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Aulas";
            this.Load += new System.EventHandler(this.FormRelatorioAulas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInscreverAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rELATORIOAULABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACADEMIADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_ACADEMIADataSet bD_ACADEMIADataSet;
        private System.Windows.Forms.BindingSource rELATORIOAULABindingSource;
        private BD_ACADEMIADataSetTableAdapters.RELATORIO_AULATableAdapter rELATORIO_AULATableAdapter;
    }
}