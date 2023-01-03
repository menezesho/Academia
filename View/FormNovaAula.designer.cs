namespace academia
{
    partial class FormNovaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaAula));
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbHorario = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNovoCadastro = new System.Windows.Forms.Label();
            this.lbLimite = new System.Windows.Forms.Label();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.lbMaximo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(80, 322);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(210, 40);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadastrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(296, 322);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(210, 40);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "&Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbHorario.Location = new System.Drawing.Point(272, 219);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(86, 25);
            this.lbHorario.TabIndex = 54;
            this.lbHorario.Text = "Horário*";
            this.lbHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbNome.Location = new System.Drawing.Point(80, 178);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(426, 29);
            this.tbNome.TabIndex = 0;
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbData.Location = new System.Drawing.Point(117, 219);
            this.lbData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(63, 25);
            this.lbData.TabIndex = 51;
            this.lbData.Text = "Data*";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbNome.Location = new System.Drawing.Point(80, 151);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(73, 25);
            this.lbNome.TabIndex = 50;
            this.lbNome.Text = "Nome*";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbHora
            // 
            this.cbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "Selecione",
            "07h",
            "08h",
            "09h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.cbHora.Location = new System.Drawing.Point(258, 246);
            this.cbHora.Margin = new System.Windows.Forms.Padding(2);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(115, 29);
            this.cbHora.TabIndex = 2;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpData.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.dtpData.Font = new System.Drawing.Font("Segoe UI Semilight", 13.2F, System.Drawing.FontStyle.Italic);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(80, 246);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpData.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(128, 31);
            this.dtpData.TabIndex = 1;
            this.dtpData.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(551, 477);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 59;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // lbNovoCadastro
            // 
            this.lbNovoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNovoCadastro.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbNovoCadastro.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbNovoCadastro.Location = new System.Drawing.Point(80, 68);
            this.lbNovoCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNovoCadastro.Name = "lbNovoCadastro";
            this.lbNovoCadastro.Size = new System.Drawing.Size(426, 43);
            this.lbNovoCadastro.TabIndex = 58;
            this.lbNovoCadastro.Text = "NOVA AULA";
            this.lbNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLimite
            // 
            this.lbLimite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbLimite.Location = new System.Drawing.Point(422, 219);
            this.lbLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(82, 25);
            this.lbLimite.TabIndex = 142;
            this.lbLimite.Text = "Máximo";
            this.lbLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbTotal
            // 
            this.mtbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbTotal.HidePromptOnLeave = true;
            this.mtbTotal.Location = new System.Drawing.Point(420, 246);
            this.mtbTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbTotal.Mask = "000";
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(86, 29);
            this.mtbTotal.TabIndex = 3;
            this.mtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTotal.ValidatingType = typeof(System.DateTime);
            // 
            // lbMaximo
            // 
            this.lbMaximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbMaximo.Location = new System.Drawing.Point(424, 278);
            this.lbMaximo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(78, 24);
            this.lbMaximo.TabIndex = 144;
            this.lbMaximo.Text = "Deseja limitar a\r\nqtd. de alunos?";
            this.lbMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNovaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 521);
            this.Controls.Add(this.lbMaximo);
            this.Controls.Add(this.mtbTotal);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbNovoCadastro);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 560);
            this.Name = "FormNovaAula";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Aula";
            this.Load += new System.EventHandler(this.FormCadAula_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadAula_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNovoCadastro;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.Label lbMaximo;
    }
}