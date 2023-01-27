
namespace projetofinal
{
    partial class FormMenuProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuProfessor));
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEditarAula = new System.Windows.Forms.Button();
            this.btNovaAula = new System.Windows.Forms.Button();
            this.btVerParticipantes = new System.Windows.Forms.Button();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbInfoUsuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(988, 527);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 37;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btEditarAula
            // 
            this.btEditarAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btEditarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarAula.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btEditarAula.ForeColor = System.Drawing.Color.White;
            this.btEditarAula.Location = new System.Drawing.Point(508, 258);
            this.btEditarAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEditarAula.Name = "btEditarAula";
            this.btEditarAula.Size = new System.Drawing.Size(346, 75);
            this.btEditarAula.TabIndex = 1;
            this.btEditarAula.Text = "&EDITAR AULA";
            this.toolTip1.SetToolTip(this.btEditarAula, "Editar aula");
            this.btEditarAula.UseVisualStyleBackColor = false;
            this.btEditarAula.Click += new System.EventHandler(this.btEditarAula_Click);
            // 
            // btNovaAula
            // 
            this.btNovaAula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNovaAula.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btNovaAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovaAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaAula.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btNovaAula.ForeColor = System.Drawing.Color.White;
            this.btNovaAula.Location = new System.Drawing.Point(508, 175);
            this.btNovaAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNovaAula.Name = "btNovaAula";
            this.btNovaAula.Size = new System.Drawing.Size(346, 75);
            this.btNovaAula.TabIndex = 0;
            this.btNovaAula.Text = "&NOVA AULA";
            this.toolTip1.SetToolTip(this.btNovaAula, "Nova aula");
            this.btNovaAula.UseVisualStyleBackColor = false;
            this.btNovaAula.Click += new System.EventHandler(this.btNovaAula_Click);
            // 
            // btVerParticipantes
            // 
            this.btVerParticipantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btVerParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btVerParticipantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVerParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerParticipantes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btVerParticipantes.ForeColor = System.Drawing.Color.White;
            this.btVerParticipantes.Location = new System.Drawing.Point(508, 341);
            this.btVerParticipantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btVerParticipantes.Name = "btVerParticipantes";
            this.btVerParticipantes.Size = new System.Drawing.Size(198, 50);
            this.btVerParticipantes.TabIndex = 2;
            this.btVerParticipantes.Text = "&VER PARTICIPANTES";
            this.toolTip1.SetToolTip(this.btVerParticipantes, "Visualizar participantes e aulas");
            this.btVerParticipantes.UseVisualStyleBackColor = false;
            this.btVerParticipantes.Click += new System.EventHandler(this.btVerInscritos_Click);
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btAlterarSenha.Location = new System.Drawing.Point(712, 341);
            this.btAlterarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(142, 50);
            this.btAlterarSenha.TabIndex = 3;
            this.btAlterarSenha.Text = "&ALTERAR SENHA";
            this.toolTip1.SetToolTip(this.btAlterarSenha, "Alterar senha");
            this.btAlterarSenha.UseVisualStyleBackColor = false;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbMensagem.Location = new System.Drawing.Point(158, 208);
            this.lbMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(304, 26);
            this.lbMensagem.TabIndex = 59;
            this.lbMensagem.Text = "Mensagem...";
            this.lbMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInfoUsuario
            // 
            this.lbInfoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbInfoUsuario.Location = new System.Drawing.Point(854, 9);
            this.lbInfoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfoUsuario.Name = "lbInfoUsuario";
            this.lbInfoUsuario.Size = new System.Drawing.Size(169, 39);
            this.lbInfoUsuario.TabIndex = 62;
            this.lbInfoUsuario.Text = "Usuário...";
            this.lbInfoUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 4800;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 96;
            // 
            // FormMenuProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 571);
            this.Controls.Add(this.lbInfoUsuario);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btAlterarSenha);
            this.Controls.Add(this.btVerParticipantes);
            this.Controls.Add(this.btEditarAula);
            this.Controls.Add(this.btNovaAula);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1051, 610);
            this.Name = "FormMenuProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Professor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btEditarAula;
        internal System.Windows.Forms.Button btNovaAula;
        internal System.Windows.Forms.Button btVerParticipantes;
        internal System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Label lbInfoUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}