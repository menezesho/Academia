
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
            this.btEditAluno = new System.Windows.Forms.Button();
            this.btCadAluno = new System.Windows.Forms.Button();
            this.btEditAula = new System.Windows.Forms.Button();
            this.btCadAula = new System.Windows.Forms.Button();
            this.btInscrever = new System.Windows.Forms.Button();
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
            this.btEditProf.Location = new System.Drawing.Point(690, 269);
            this.btEditProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditProf.Name = "btEditProf";
            this.btEditProf.Size = new System.Drawing.Size(60, 60);
            this.btEditProf.TabIndex = 5;
            this.btEditProf.UseVisualStyleBackColor = false;
            this.btEditProf.Click += new System.EventHandler(this.btEditProf_Click);
            // 
            // btCadProf
            // 
            this.btCadProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadProf.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btCadProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btCadProf.ForeColor = System.Drawing.Color.White;
            this.btCadProf.Location = new System.Drawing.Point(446, 269);
            this.btCadProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadProf.Name = "btCadProf";
            this.btCadProf.Size = new System.Drawing.Size(238, 60);
            this.btCadProf.TabIndex = 4;
            this.btCadProf.Text = "CADASTRAR &PROFESSOR";
            this.btCadProf.UseVisualStyleBackColor = false;
            this.btCadProf.Click += new System.EventHandler(this.btCadProf_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(837, 477);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 37;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
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
            this.btEditAluno.Location = new System.Drawing.Point(690, 201);
            this.btEditAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditAluno.Name = "btEditAluno";
            this.btEditAluno.Size = new System.Drawing.Size(60, 60);
            this.btEditAluno.TabIndex = 3;
            this.btEditAluno.UseVisualStyleBackColor = false;
            this.btEditAluno.Click += new System.EventHandler(this.btEditAluno_Click);
            // 
            // btCadAluno
            // 
            this.btCadAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadAluno.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btCadAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btCadAluno.ForeColor = System.Drawing.Color.White;
            this.btCadAluno.Location = new System.Drawing.Point(446, 201);
            this.btCadAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadAluno.Name = "btCadAluno";
            this.btCadAluno.Size = new System.Drawing.Size(238, 60);
            this.btCadAluno.TabIndex = 2;
            this.btCadAluno.Text = "CADASTRAR &ALUNO";
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
            this.btEditAula.Location = new System.Drawing.Point(690, 133);
            this.btEditAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditAula.Name = "btEditAula";
            this.btEditAula.Size = new System.Drawing.Size(60, 60);
            this.btEditAula.TabIndex = 1;
            this.btEditAula.UseVisualStyleBackColor = false;
            this.btEditAula.Click += new System.EventHandler(this.btEditAula_Click);
            // 
            // btCadAula
            // 
            this.btCadAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCadAula.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btCadAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadAula.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btCadAula.ForeColor = System.Drawing.Color.White;
            this.btCadAula.Location = new System.Drawing.Point(446, 133);
            this.btCadAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCadAula.Name = "btCadAula";
            this.btCadAula.Size = new System.Drawing.Size(238, 60);
            this.btCadAula.TabIndex = 0;
            this.btCadAula.Text = "&NOVA AULA";
            this.btCadAula.UseVisualStyleBackColor = false;
            this.btCadAula.Click += new System.EventHandler(this.btCadAula_Click);
            // 
            // btInscrever
            // 
            this.btInscrever.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInscrever.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btInscrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscrever.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btInscrever.ForeColor = System.Drawing.Color.White;
            this.btInscrever.Location = new System.Drawing.Point(446, 337);
            this.btInscrever.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInscrever.Name = "btInscrever";
            this.btInscrever.Size = new System.Drawing.Size(238, 60);
            this.btInscrever.TabIndex = 6;
            this.btInscrever.Text = "&INSCREVER NA AULA";
            this.btInscrever.UseVisualStyleBackColor = false;
            this.btInscrever.Click += new System.EventHandler(this.btInscreverAluno_Click);
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
            this.btEditParticipantes.Location = new System.Drawing.Point(690, 337);
            this.btEditParticipantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditParticipantes.Name = "btEditParticipantes";
            this.btEditParticipantes.Size = new System.Drawing.Size(60, 60);
            this.btEditParticipantes.TabIndex = 7;
            this.btEditParticipantes.UseVisualStyleBackColor = false;
            this.btEditParticipantes.Click += new System.EventHandler(this.btEditParticipantes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.btEditParticipantes);
            this.Controls.Add(this.btInscrever);
            this.Controls.Add(this.btEditAula);
            this.Controls.Add(this.btCadAula);
            this.Controls.Add(this.btEditAluno);
            this.Controls.Add(this.btCadAluno);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.btEditProf);
            this.Controls.Add(this.btCadProf);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 560);
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
        internal System.Windows.Forms.Button btEditAluno;
        internal System.Windows.Forms.Button btCadAluno;
        internal System.Windows.Forms.Button btEditAula;
        internal System.Windows.Forms.Button btCadAula;
        internal System.Windows.Forms.Button btInscrever;
        internal System.Windows.Forms.Button btEditParticipantes;
    }
}