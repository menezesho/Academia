namespace academia
{
    partial class FormMenuAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAluno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btInscrever = new System.Windows.Forms.Button();
            this.btCancelarInscricao = new System.Windows.Forms.Button();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbInfoUsuario = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.btAtualizarInformacoes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btInscrever
            // 
            this.btInscrever.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInscrever.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btInscrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInscrever.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btInscrever.ForeColor = System.Drawing.Color.White;
            this.btInscrever.Location = new System.Drawing.Point(677, 215);
            this.btInscrever.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInscrever.Name = "btInscrever";
            this.btInscrever.Size = new System.Drawing.Size(461, 92);
            this.btInscrever.TabIndex = 0;
            this.btInscrever.Text = "&INSCREVER-SE";
            this.toolTip1.SetToolTip(this.btInscrever, "Realizar inscrição");
            this.btInscrever.UseVisualStyleBackColor = false;
            this.btInscrever.Click += new System.EventHandler(this.btRealizarInscrição_Click);
            // 
            // btCancelarInscricao
            // 
            this.btCancelarInscricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelarInscricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btCancelarInscricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarInscricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarInscricao.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btCancelarInscricao.ForeColor = System.Drawing.Color.White;
            this.btCancelarInscricao.Location = new System.Drawing.Point(677, 318);
            this.btCancelarInscricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancelarInscricao.Name = "btCancelarInscricao";
            this.btCancelarInscricao.Size = new System.Drawing.Size(461, 92);
            this.btCancelarInscricao.TabIndex = 1;
            this.btCancelarInscricao.Text = "&CANCELAR INSCRIÇÃO";
            this.toolTip1.SetToolTip(this.btCancelarInscricao, "Cancelar inscrição");
            this.btCancelarInscricao.UseVisualStyleBackColor = false;
            this.btCancelarInscricao.Click += new System.EventHandler(this.btCancelarInscrição_Click);
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btAlterarSenha.Location = new System.Drawing.Point(949, 420);
            this.btAlterarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(189, 62);
            this.btAlterarSenha.TabIndex = 3;
            this.btAlterarSenha.Text = "ALTERAR SENHA";
            this.toolTip1.SetToolTip(this.btAlterarSenha, "Alterar senha");
            this.btAlterarSenha.UseVisualStyleBackColor = false;
            this.btAlterarSenha.Click += new System.EventHandler(this.btRedefinirSenha_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbMensagem.Location = new System.Drawing.Point(211, 256);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(405, 32);
            this.lbMensagem.TabIndex = 60;
            this.lbMensagem.Text = "Mensagem...";
            this.lbMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInfoUsuario
            // 
            this.lbInfoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbInfoUsuario.Location = new System.Drawing.Point(1140, 11);
            this.lbInfoUsuario.Name = "lbInfoUsuario";
            this.lbInfoUsuario.Size = new System.Drawing.Size(225, 48);
            this.lbInfoUsuario.TabIndex = 61;
            this.lbInfoUsuario.Text = "Usuário...";
            this.lbInfoUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(1319, 649);
            this.lbSair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(47, 43);
            this.lbSair.TabIndex = 62;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // btAtualizarInformacoes
            // 
            this.btAtualizarInformacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAtualizarInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btAtualizarInformacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAtualizarInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarInformacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btAtualizarInformacoes.ForeColor = System.Drawing.Color.White;
            this.btAtualizarInformacoes.Location = new System.Drawing.Point(677, 420);
            this.btAtualizarInformacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAtualizarInformacoes.Name = "btAtualizarInformacoes";
            this.btAtualizarInformacoes.Size = new System.Drawing.Size(264, 62);
            this.btAtualizarInformacoes.TabIndex = 2;
            this.btAtualizarInformacoes.Text = "ATUALIZAR INFORMAÇÕES";
            this.toolTip1.SetToolTip(this.btAtualizarInformacoes, "Atualizar peso e altura");
            this.btAtualizarInformacoes.UseVisualStyleBackColor = false;
            this.btAtualizarInformacoes.Click += new System.EventHandler(this.btAtualizarPesoAltura_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 4800;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 96;
            // 
            // FormMenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 703);
            this.Controls.Add(this.btAtualizarInformacoes);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.lbInfoUsuario);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btAlterarSenha);
            this.Controls.Add(this.btInscrever);
            this.Controls.Add(this.btCancelarInscricao);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1396, 742);
            this.Name = "FormMenuAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuAluno_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenuAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btInscrever;
        internal System.Windows.Forms.Button btCancelarInscricao;
        internal System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Label lbInfoUsuario;
        private System.Windows.Forms.Label lbSair;
        internal System.Windows.Forms.Button btAtualizarInformacoes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}