
namespace projetofinal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btEditProf = new System.Windows.Forms.Button();
            this.btCadProf = new System.Windows.Forms.Button();
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbInscrever = new System.Windows.Forms.Label();
            this.btEditAluno = new System.Windows.Forms.Button();
            this.btCadAluno = new System.Windows.Forms.Button();
            this.btEditAula = new System.Windows.Forms.Button();
            this.btCadAula = new System.Windows.Forms.Button();
            this.btInscreverAluno = new System.Windows.Forms.Button();
            this.btInscreverProf = new System.Windows.Forms.Button();
            this.btEditParticipantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditProf
            // 
            this.btEditProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditProf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btEditProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditProf.Image = ((System.Drawing.Image)(resources.GetObject("btEditProf.Image")));
            this.btEditProf.Location = new System.Drawing.Point(691, 238);
            this.btEditProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditProf.Name = "btEditProf";
            this.btEditProf.Size = new System.Drawing.Size(60, 60);
            this.btEditProf.TabIndex = 3;
            this.btEditProf.UseVisualStyleBackColor = false;
            this.btEditProf.Click += new System.EventHandler(this.btEditProf_Click);
            // 
            // btCadProf
            // 
            this.btCadProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btCadProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btCadProf.ForeColor = System.Drawing.Color.White;
            this.btCadProf.Location = new System.Drawing.Point(447, 238);
            this.btCadProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadProf.Name = "btCadProf";
            this.btCadProf.Size = new System.Drawing.Size(238, 60);
            this.btCadProf.TabIndex = 2;
            this.btCadProf.Text = "CADASTRAR PROFESSOR";
            this.btCadProf.UseVisualStyleBackColor = false;
            this.btCadProf.Click += new System.EventHandler(this.btCadProf_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(843, 480);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 37;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lbInscrever
            // 
            this.lbInscrever.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInscrever.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbInscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInscrever.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbInscrever.ForeColor = System.Drawing.Color.White;
            this.lbInscrever.Location = new System.Drawing.Point(447, 312);
            this.lbInscrever.Name = "lbInscrever";
            this.lbInscrever.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbInscrever.Size = new System.Drawing.Size(304, 115);
            this.lbInscrever.TabIndex = 134;
            this.lbInscrever.Text = "INSCREVER";
            this.lbInscrever.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btEditAluno
            // 
            this.btEditAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btEditAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditAluno.Image = ((System.Drawing.Image)(resources.GetObject("btEditAluno.Image")));
            this.btEditAluno.Location = new System.Drawing.Point(691, 170);
            this.btEditAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditAluno.Name = "btEditAluno";
            this.btEditAluno.Size = new System.Drawing.Size(60, 60);
            this.btEditAluno.TabIndex = 137;
            this.btEditAluno.UseVisualStyleBackColor = false;
            this.btEditAluno.Click += new System.EventHandler(this.btEditAluno_Click);
            // 
            // btCadAluno
            // 
            this.btCadAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btCadAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btCadAluno.ForeColor = System.Drawing.Color.White;
            this.btCadAluno.Location = new System.Drawing.Point(447, 170);
            this.btCadAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadAluno.Name = "btCadAluno";
            this.btCadAluno.Size = new System.Drawing.Size(238, 60);
            this.btCadAluno.TabIndex = 136;
            this.btCadAluno.Text = "CADASTRAR ALUNO";
            this.btCadAluno.UseVisualStyleBackColor = false;
            this.btCadAluno.Click += new System.EventHandler(this.btCadAluno_Click);
            // 
            // btEditAula
            // 
            this.btEditAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditAula.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btEditAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditAula.Image = ((System.Drawing.Image)(resources.GetObject("btEditAula.Image")));
            this.btEditAula.Location = new System.Drawing.Point(691, 102);
            this.btEditAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditAula.Name = "btEditAula";
            this.btEditAula.Size = new System.Drawing.Size(60, 60);
            this.btEditAula.TabIndex = 139;
            this.btEditAula.UseVisualStyleBackColor = false;
            this.btEditAula.Click += new System.EventHandler(this.btEditAula_Click);
            // 
            // btCadAula
            // 
            this.btCadAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btCadAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadAula.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btCadAula.ForeColor = System.Drawing.Color.White;
            this.btCadAula.Location = new System.Drawing.Point(447, 102);
            this.btCadAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadAula.Name = "btCadAula";
            this.btCadAula.Size = new System.Drawing.Size(238, 60);
            this.btCadAula.TabIndex = 138;
            this.btCadAula.Text = "CADASTRAR AULA";
            this.btCadAula.UseVisualStyleBackColor = false;
            this.btCadAula.Click += new System.EventHandler(this.btCadAula_Click);
            // 
            // btInscreverAluno
            // 
            this.btInscreverAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInscreverAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btInscreverAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscreverAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscreverAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btInscreverAluno.ForeColor = System.Drawing.Color.White;
            this.btInscreverAluno.Location = new System.Drawing.Point(456, 357);
            this.btInscreverAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInscreverAluno.Name = "btInscreverAluno";
            this.btInscreverAluno.Size = new System.Drawing.Size(107, 60);
            this.btInscreverAluno.TabIndex = 140;
            this.btInscreverAluno.Text = "ALUNO";
            this.btInscreverAluno.UseVisualStyleBackColor = false;
            this.btInscreverAluno.Click += new System.EventHandler(this.btInscreverAluno_Click);
            // 
            // btInscreverProf
            // 
            this.btInscreverProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInscreverProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btInscreverProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscreverProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscreverProf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btInscreverProf.ForeColor = System.Drawing.Color.White;
            this.btInscreverProf.Location = new System.Drawing.Point(635, 357);
            this.btInscreverProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInscreverProf.Name = "btInscreverProf";
            this.btInscreverProf.Size = new System.Drawing.Size(107, 60);
            this.btInscreverProf.TabIndex = 141;
            this.btInscreverProf.Text = "PROFESSOR";
            this.btInscreverProf.UseVisualStyleBackColor = false;
            this.btInscreverProf.Click += new System.EventHandler(this.btInscreverProf_Click);
            // 
            // btEditParticipantes
            // 
            this.btEditParticipantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditParticipantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditParticipantes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btEditParticipantes.ForeColor = System.Drawing.Color.White;
            this.btEditParticipantes.Image = ((System.Drawing.Image)(resources.GetObject("btEditParticipantes.Image")));
            this.btEditParticipantes.Location = new System.Drawing.Point(569, 357);
            this.btEditParticipantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditParticipantes.Name = "btEditParticipantes";
            this.btEditParticipantes.Size = new System.Drawing.Size(60, 60);
            this.btEditParticipantes.TabIndex = 142;
            this.btEditParticipantes.UseVisualStyleBackColor = false;
            this.btEditParticipantes.Click += new System.EventHandler(this.btEditParticipantes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 524);
            this.Controls.Add(this.btEditParticipantes);
            this.Controls.Add(this.btInscreverProf);
            this.Controls.Add(this.btInscreverAluno);
            this.Controls.Add(this.btEditAula);
            this.Controls.Add(this.btCadAula);
            this.Controls.Add(this.btEditAluno);
            this.Controls.Add(this.btCadAluno);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.btEditProf);
            this.Controls.Add(this.btCadProf);
            this.Controls.Add(this.lbInscrever);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btEditProf;
        internal System.Windows.Forms.Button btCadProf;
        internal System.Windows.Forms.Label lbInscrever;
        internal System.Windows.Forms.Button btEditAluno;
        internal System.Windows.Forms.Button btCadAluno;
        internal System.Windows.Forms.Button btEditAula;
        internal System.Windows.Forms.Button btCadAula;
        internal System.Windows.Forms.Button btInscreverAluno;
        internal System.Windows.Forms.Button btInscreverProf;
        internal System.Windows.Forms.Button btEditParticipantes;
    }
}