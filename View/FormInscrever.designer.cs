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
            this.tbProfessor = new System.Windows.Forms.TextBox();
            this.lbProfessor = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNovaInscricao = new System.Windows.Forms.Label();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btInscrever = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.cbAula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProfessor
            // 
            this.tbProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProfessor.BackColor = System.Drawing.Color.White;
            this.tbProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProfessor.Enabled = false;
            this.tbProfessor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbProfessor.Location = new System.Drawing.Point(123, 321);
            this.tbProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProfessor.MaxLength = 100;
            this.tbProfessor.Name = "tbProfessor";
            this.tbProfessor.Size = new System.Drawing.Size(467, 29);
            this.tbProfessor.TabIndex = 4;
            this.tbProfessor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbProfessor
            // 
            this.lbProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProfessor.AutoSize = true;
            this.lbProfessor.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbProfessor.Location = new System.Drawing.Point(123, 288);
            this.lbProfessor.Name = "lbProfessor";
            this.lbProfessor.Size = new System.Drawing.Size(91, 25);
            this.lbProfessor.TabIndex = 3;
            this.lbProfessor.Text = "Professor";
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(652, 690);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(47, 43);
            this.lbSair.TabIndex = 10;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 601);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 164;
            this.pictureBox1.TabStop = false;
            // 
            // lbNovaInscricao
            // 
            this.lbNovaInscricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNovaInscricao.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbNovaInscricao.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbNovaInscricao.Location = new System.Drawing.Point(123, 101);
            this.lbNovaInscricao.Name = "lbNovaInscricao";
            this.lbNovaInscricao.Size = new System.Drawing.Size(468, 53);
            this.lbNovaInscricao.TabIndex = 0;
            this.lbNovaInscricao.Text = "NOVA INSCRIÇÃO";
            this.lbNovaInscricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHora
            // 
            this.tbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHora.BackColor = System.Drawing.Color.White;
            this.tbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHora.Enabled = false;
            this.tbHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbHora.Location = new System.Drawing.Point(465, 406);
            this.tbHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHora.MaxLength = 100;
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(125, 29);
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
            this.mtbData.Location = new System.Drawing.Point(123, 406);
            this.mtbData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(167, 29);
            this.mtbData.TabIndex = 6;
            this.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbData.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbHorario.Location = new System.Drawing.Point(476, 373);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(78, 25);
            this.lbHorario.TabIndex = 7;
            this.lbHorario.Text = "Horário";
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbData.Location = new System.Drawing.Point(171, 373);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(55, 25);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Data";
            // 
            // btInscrever
            // 
            this.btInscrever.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInscrever.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btInscrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscrever.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btInscrever.ForeColor = System.Drawing.Color.White;
            this.btInscrever.Location = new System.Drawing.Point(123, 496);
            this.btInscrever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInscrever.Name = "btInscrever";
            this.btInscrever.Size = new System.Drawing.Size(468, 49);
            this.btInscrever.TabIndex = 9;
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
            this.lb2.Location = new System.Drawing.Point(123, 203);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(52, 25);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Aula";
            // 
            // cbAula
            // 
            this.cbAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAula.BackColor = System.Drawing.Color.White;
            this.cbAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAula.DisplayMember = "NOME";
            this.cbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAula.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Items.AddRange(new object[] {
            "Selecione"});
            this.cbAula.Location = new System.Drawing.Point(123, 236);
            this.cbAula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(467, 29);
            this.cbAula.TabIndex = 2;
            this.cbAula.ValueMember = "IDAULA";
            this.cbAula.SelectedIndexChanged += new System.EventHandler(this.cbAula_SelectedIndexChanged);
            this.cbAula.Click += new System.EventHandler(this.cbAula_Click);
            // 
            // FormInscrever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 745);
            this.Controls.Add(this.tbProfessor);
            this.Controls.Add(this.lbProfessor);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNovaInscricao);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btInscrever);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.cbAula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(729, 784);
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

        private System.Windows.Forms.TextBox tbProfessor;
        private System.Windows.Forms.Label lbProfessor;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNovaInscricao;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btInscrever;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox cbAula;
    }
}