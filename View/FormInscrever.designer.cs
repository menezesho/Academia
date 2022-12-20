namespace academia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscrever));
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbcpf = new System.Windows.Forms.Label();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbNovaInscricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSair = new System.Windows.Forms.Label();
            this.btAluno = new System.Windows.Forms.Button();
            this.btProf = new System.Windows.Forms.Button();
            this.lbcelular = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbSelecione = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCpf.BackColor = System.Drawing.Color.White;
            this.mtbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCpf.Enabled = false;
            this.mtbCpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbCpf.Location = new System.Drawing.Point(80, 335);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(129, 29);
            this.mtbCpf.TabIndex = 5;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbcpf
            // 
            this.lbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbcpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbcpf.Location = new System.Drawing.Point(122, 308);
            this.lbcpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(45, 25);
            this.lbcpf.TabIndex = 136;
            this.lbcpf.Text = "CPF";
            // 
            // tbHora
            // 
            this.tbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHora.BackColor = System.Drawing.Color.White;
            this.tbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHora.Enabled = false;
            this.tbHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbHora.Location = new System.Drawing.Point(516, 335);
            this.tbHora.Margin = new System.Windows.Forms.Padding(2);
            this.tbHora.MaxLength = 100;
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(78, 29);
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
            this.mtbData.Location = new System.Drawing.Point(396, 335);
            this.mtbData.Margin = new System.Windows.Forms.Padding(2);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(103, 29);
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
            this.lbHorario.Location = new System.Drawing.Point(516, 308);
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
            this.lbData.Location = new System.Drawing.Point(420, 308);
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
            this.btLimpar.Location = new System.Drawing.Point(80, 408);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(255, 40);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInserir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btInserir.ForeColor = System.Drawing.Color.White;
            this.btInserir.Location = new System.Drawing.Point(339, 408);
            this.btInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(255, 40);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lb2.Location = new System.Drawing.Point(396, 240);
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
            this.cbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Items.AddRange(new object[] {
            "Selecione"});
            this.cbAula.Location = new System.Drawing.Point(396, 267);
            this.cbAula.Margin = new System.Windows.Forms.Padding(2);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(198, 29);
            this.cbAula.TabIndex = 4;
            this.cbAula.SelectedIndexChanged += new System.EventHandler(this.cbAula_SelectedIndexChanged);
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lb1.Location = new System.Drawing.Point(80, 240);
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
            this.lbNovaInscricao.Location = new System.Drawing.Point(80, 62);
            this.lbNovaInscricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNovaInscricao.Name = "lbNovaInscricao";
            this.lbNovaInscricao.Size = new System.Drawing.Size(514, 43);
            this.lbNovaInscricao.TabIndex = 138;
            this.lbNovaInscricao.Text = "NOVA INSCRIÇÃO";
            this.lbNovaInscricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 493);
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
            this.lbSair.Location = new System.Drawing.Point(630, 545);
            this.lbSair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 140;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // btAluno
            // 
            this.btAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btAluno.ForeColor = System.Drawing.Color.White;
            this.btAluno.Location = new System.Drawing.Point(216, 168);
            this.btAluno.Margin = new System.Windows.Forms.Padding(2);
            this.btAluno.Name = "btAluno";
            this.btAluno.Size = new System.Drawing.Size(120, 30);
            this.btAluno.TabIndex = 1;
            this.btAluno.Text = "Aluno";
            this.btAluno.UseVisualStyleBackColor = false;
            this.btAluno.Click += new System.EventHandler(this.btAreaAluno_Click);
            // 
            // btProf
            // 
            this.btProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProf.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btProf.ForeColor = System.Drawing.Color.White;
            this.btProf.Location = new System.Drawing.Point(336, 168);
            this.btProf.Margin = new System.Windows.Forms.Padding(2);
            this.btProf.Name = "btProf";
            this.btProf.Size = new System.Drawing.Size(120, 30);
            this.btProf.TabIndex = 2;
            this.btProf.Text = "Professor";
            this.btProf.UseVisualStyleBackColor = false;
            this.btProf.Click += new System.EventHandler(this.btAreaProf_Click);
            // 
            // lbcelular
            // 
            this.lbcelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcelular.AutoSize = true;
            this.lbcelular.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbcelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbcelular.Location = new System.Drawing.Point(258, 308);
            this.lbcelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(73, 25);
            this.lbcelular.TabIndex = 137;
            this.lbcelular.Text = "Celular";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCelular.BackColor = System.Drawing.Color.White;
            this.mtbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCelular.Enabled = false;
            this.mtbCelular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbCelular.Location = new System.Drawing.Point(223, 335);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(143, 29);
            this.mtbCelular.TabIndex = 6;
            this.mtbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbSelecione
            // 
            this.lbSelecione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSelecione.AutoSize = true;
            this.lbSelecione.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbSelecione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbSelecione.Location = new System.Drawing.Point(297, 145);
            this.lbSelecione.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelecione.Name = "lbSelecione";
            this.lbSelecione.Size = new System.Drawing.Size(81, 21);
            this.lbSelecione.TabIndex = 141;
            this.lbSelecione.Text = "Selecione:";
            // 
            // cbNome
            // 
            this.cbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNome.BackColor = System.Drawing.Color.White;
            this.cbNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Items.AddRange(new object[] {
            "Selecione"});
            this.cbNome.Location = new System.Drawing.Point(80, 267);
            this.cbNome.Margin = new System.Windows.Forms.Padding(2);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(286, 29);
            this.cbNome.TabIndex = 142;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // FormInscrever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 589);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.lbSelecione);
            this.Controls.Add(this.btAluno);
            this.Controls.Add(this.btProf);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNovaInscricao);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.lbcelular);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.cbAula);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(655, 610);
            this.Name = "FormInscrever";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Inscrição";
            this.Load += new System.EventHandler(this.FormInserirNaAula_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInscreverAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbNovaInscricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Button btAluno;
        private System.Windows.Forms.Button btProf;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbSelecione;
        private System.Windows.Forms.ComboBox cbNome;
    }
}