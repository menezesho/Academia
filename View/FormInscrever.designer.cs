﻿namespace academia
{
    partial class FormInscrever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscrever));
            this.tbHora = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInscrever = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.aULABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_ACADEMIADataSet = new academia.BD_ACADEMIADataSet();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbNovaInscricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSair = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.aULATableAdapter = new academia.BD_ACADEMIADataSetTableAdapters.AULATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aULABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACADEMIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHora
            // 
            this.tbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHora.BackColor = System.Drawing.Color.White;
            this.tbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHora.Enabled = false;
            this.tbHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbHora.Location = new System.Drawing.Point(291, 308);
            this.tbHora.Margin = new System.Windows.Forms.Padding(2);
            this.tbHora.MaxLength = 100;
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(94, 29);
            this.tbHora.TabIndex = 8;
            this.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbData
            // 
            this.mtbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbData.BackColor = System.Drawing.Color.White;
            this.mtbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbData.Enabled = false;
            this.mtbData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbData.Location = new System.Drawing.Point(99, 308);
            this.mtbData.Margin = new System.Windows.Forms.Padding(2);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(126, 29);
            this.mtbData.TabIndex = 7;
            this.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbData.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbHorario.Location = new System.Drawing.Point(299, 281);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(78, 25);
            this.lbHorario.TabIndex = 131;
            this.lbHorario.Text = "Horário";
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbData.Location = new System.Drawing.Point(135, 281);
            this.lbData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(55, 25);
            this.lbData.TabIndex = 130;
            this.lbData.Text = "Data";
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(99, 381);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(286, 40);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInscrever
            // 
            this.btInscrever.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInscrever.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btInscrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscrever.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btInscrever.ForeColor = System.Drawing.Color.White;
            this.btInscrever.Location = new System.Drawing.Point(99, 425);
            this.btInscrever.Margin = new System.Windows.Forms.Padding(2);
            this.btInscrever.Name = "btInscrever";
            this.btInscrever.Size = new System.Drawing.Size(286, 40);
            this.btInscrever.TabIndex = 0;
            this.btInscrever.Text = "&Inscrever";
            this.btInscrever.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btInscrever.UseVisualStyleBackColor = false;
            this.btInscrever.Click += new System.EventHandler(this.btInscrever_Click);
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lb2.Location = new System.Drawing.Point(99, 213);
            this.lb2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(52, 25);
            this.lb2.TabIndex = 125;
            this.lb2.Text = "Aula";
            // 
            // cbAula
            // 
            this.cbAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAula.BackColor = System.Drawing.Color.White;
            this.cbAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAula.DataSource = this.aULABindingSource;
            this.cbAula.DisplayMember = "NOME";
            this.cbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Location = new System.Drawing.Point(99, 240);
            this.cbAula.Margin = new System.Windows.Forms.Padding(2);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(286, 29);
            this.cbAula.TabIndex = 4;
            this.cbAula.ValueMember = "IDAULA";
            this.cbAula.SelectedIndexChanged += new System.EventHandler(this.cbAula_SelectedIndexChanged);
            // 
            // aULABindingSource
            // 
            this.aULABindingSource.DataMember = "AULA";
            this.aULABindingSource.DataSource = this.bD_ACADEMIADataSet;
            // 
            // bD_ACADEMIADataSet
            // 
            this.bD_ACADEMIADataSet.DataSetName = "BD_ACADEMIADataSet";
            this.bD_ACADEMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lb1.Location = new System.Drawing.Point(99, 145);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(65, 25);
            this.lb1.TabIndex = 123;
            this.lb1.Text = "Nome";
            // 
            // lbNovaInscricao
            // 
            this.lbNovaInscricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNovaInscricao.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbNovaInscricao.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbNovaInscricao.Location = new System.Drawing.Point(92, 62);
            this.lbNovaInscricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNovaInscricao.Name = "lbNovaInscricao";
            this.lbNovaInscricao.Size = new System.Drawing.Size(293, 43);
            this.lbNovaInscricao.TabIndex = 138;
            this.lbNovaInscricao.Text = "NOVA INSCRIÇÃO";
            this.lbNovaInscricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(440, 561);
            this.lbSair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 140;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbNome.Location = new System.Drawing.Point(99, 172);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(286, 29);
            this.tbNome.TabIndex = 141;
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aULATableAdapter
            // 
            this.aULATableAdapter.ClearBeforeFill = true;
            // 
            // FormInscrever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 605);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNovaInscricao);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btInscrever);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.cbAula);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(502, 644);
            this.Name = "FormInscrever";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Inscrição";
            this.Load += new System.EventHandler(this.FormInserirNaAula_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInscreverAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.aULABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ACADEMIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInscrever;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbNovaInscricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.TextBox tbNome;
        private BD_ACADEMIADataSet bD_ACADEMIADataSet;
        private System.Windows.Forms.BindingSource aULABindingSource;
        private BD_ACADEMIADataSetTableAdapters.AULATableAdapter aULATableAdapter;
    }
}