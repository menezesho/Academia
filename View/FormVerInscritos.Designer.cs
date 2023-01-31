namespace academia
{
    partial class FormVerInscritos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerInscritos));
            this.lbListaDeInscritos = new System.Windows.Forms.Label();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.dgalunos = new System.Windows.Forms.DataGridView();
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTipoFiltro = new System.Windows.Forms.Label();
            this.lbLimparBusca = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListaDeInscritos
            // 
            this.lbListaDeInscritos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbListaDeInscritos.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbListaDeInscritos.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbListaDeInscritos.Location = new System.Drawing.Point(86, 33);
            this.lbListaDeInscritos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListaDeInscritos.Name = "lbListaDeInscritos";
            this.lbListaDeInscritos.Size = new System.Drawing.Size(447, 43);
            this.lbListaDeInscritos.TabIndex = 157;
            this.lbListaDeInscritos.Text = "LISTA DE INSCRITOS";
            this.lbListaDeInscritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHora
            // 
            this.tbHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHora.BackColor = System.Drawing.Color.White;
            this.tbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHora.Enabled = false;
            this.tbHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbHora.Location = new System.Drawing.Point(460, 143);
            this.tbHora.Margin = new System.Windows.Forms.Padding(2);
            this.tbHora.MaxLength = 100;
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(73, 29);
            this.tbHora.TabIndex = 2;
            this.tbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbData
            // 
            this.mtbData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbData.BackColor = System.Drawing.Color.White;
            this.mtbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbData.Enabled = false;
            this.mtbData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbData.Location = new System.Drawing.Point(330, 143);
            this.mtbData.Margin = new System.Windows.Forms.Padding(2);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(126, 29);
            this.mtbData.TabIndex = 1;
            this.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbData.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbHorario.Location = new System.Drawing.Point(458, 116);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(78, 25);
            this.lbHorario.TabIndex = 174;
            this.lbHorario.Text = "Horário";
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbData.Location = new System.Drawing.Point(366, 116);
            this.lbData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(55, 25);
            this.lbData.TabIndex = 173;
            this.lbData.Text = "Data";
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lb2.Location = new System.Drawing.Point(86, 116);
            this.lb2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(52, 25);
            this.lb2.TabIndex = 172;
            this.lb2.Text = "Aula";
            // 
            // cbAula
            // 
            this.cbAula.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.cbAula.Location = new System.Drawing.Point(86, 143);
            this.cbAula.Margin = new System.Windows.Forms.Padding(2);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(210, 29);
            this.cbAula.TabIndex = 0;
            this.cbAula.ValueMember = "IDAULA";
            this.cbAula.SelectedIndexChanged += new System.EventHandler(this.cbAula_SelectedIndexChanged);
            this.cbAula.Click += new System.EventHandler(this.cbAula_Click);
            // 
            // dgalunos
            // 
            this.dgalunos.AllowUserToAddRows = false;
            this.dgalunos.AllowUserToDeleteRows = false;
            this.dgalunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgalunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgalunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgalunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgalunos.Location = new System.Drawing.Point(86, 262);
            this.dgalunos.Margin = new System.Windows.Forms.Padding(2);
            this.dgalunos.MultiSelect = false;
            this.dgalunos.Name = "dgalunos";
            this.dgalunos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgalunos.RowHeadersVisible = false;
            this.dgalunos.RowHeadersWidth = 51;
            this.dgalunos.RowTemplate.Height = 29;
            this.dgalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalunos.Size = new System.Drawing.Size(447, 333);
            this.dgalunos.TabIndex = 3;
            this.dgalunos.TabStop = false;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(583, 711);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 4;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 684);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 176;
            this.pictureBox2.TabStop = false;
            // 
            // lbTipoFiltro
            // 
            this.lbTipoFiltro.AutoSize = true;
            this.lbTipoFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTipoFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbTipoFiltro.Location = new System.Drawing.Point(136, 214);
            this.lbTipoFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoFiltro.Name = "lbTipoFiltro";
            this.lbTipoFiltro.Size = new System.Drawing.Size(10, 13);
            this.lbTipoFiltro.TabIndex = 179;
            this.lbTipoFiltro.Text = " ";
            this.lbTipoFiltro.Click += new System.EventHandler(this.lbTipoFiltro_Click);
            // 
            // lbLimparBusca
            // 
            this.lbLimparBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLimparBusca.BackColor = System.Drawing.SystemColors.Window;
            this.lbLimparBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("lbLimparBusca.Image")));
            this.lbLimparBusca.Location = new System.Drawing.Point(474, 233);
            this.lbLimparBusca.Name = "lbLimparBusca";
            this.lbLimparBusca.Size = new System.Drawing.Size(20, 20);
            this.lbLimparBusca.TabIndex = 181;
            this.lbLimparBusca.Click += new System.EventHandler(this.lbLimparBusca_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("lbBuscar.Image")));
            this.lbBuscar.Location = new System.Drawing.Point(504, 229);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(29, 29);
            this.lbBuscar.TabIndex = 182;
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbBusca.Location = new System.Drawing.Point(133, 229);
            this.tbBusca.Margin = new System.Windows.Forms.Padding(2);
            this.tbBusca.MaxLength = 100;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(366, 29);
            this.tbBusca.TabIndex = 180;
            this.tbBusca.Enter += new System.EventHandler(this.tbBusca_Enter);
            this.tbBusca.Leave += new System.EventHandler(this.tbBusca_Leave);
            // 
            // lbFiltro
            // 
            this.lbFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.lbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFiltro.Image = ((System.Drawing.Image)(resources.GetObject("lbFiltro.Image")));
            this.lbFiltro.Location = new System.Drawing.Point(86, 231);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(25, 25);
            this.lbFiltro.TabIndex = 177;
            // 
            // cbFiltro
            // 
            this.cbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.DropDownWidth = 100;
            this.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.IntegralHeight = false;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "E-mail",
            "Usuário"});
            this.cbFiltro.Location = new System.Drawing.Point(86, 229);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(43, 29);
            this.cbFiltro.TabIndex = 178;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // btRelatorio
            // 
            this.btRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btRelatorio.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btRelatorio.ForeColor = System.Drawing.Color.White;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.Location = new System.Drawing.Point(347, 599);
            this.btRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btRelatorio.Size = new System.Drawing.Size(186, 40);
            this.btRelatorio.TabIndex = 183;
            this.btRelatorio.Text = "Gerar &Relatório ";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRelatorio.UseVisualStyleBackColor = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // FormVerInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 755);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.lbTipoFiltro);
            this.Controls.Add(this.lbLimparBusca);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgalunos);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.cbAula);
            this.Controls.Add(this.lbListaDeInscritos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(646, 754);
            this.Name = "FormVerInscritos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Participantes";
            this.Load += new System.EventHandler(this.FormVerInscritos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInscreverAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListaDeInscritos;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.DataGridView dgalunos;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTipoFiltro;
        private System.Windows.Forms.Label lbLimparBusca;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btRelatorio;
    }
}