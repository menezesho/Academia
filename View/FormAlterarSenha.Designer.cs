﻿namespace academia
{
    partial class FormAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarSenha));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.lbConfirmarNovaSenha = new System.Windows.Forms.Label();
            this.tbConfirmarNovaSenha = new System.Windows.Forms.TextBox();
            this.lbSenhaAtual = new System.Windows.Forms.Label();
            this.tbSenhaAtual = new System.Windows.Forms.TextBox();
            this.lbVerSenhaAtual = new System.Windows.Forms.Label();
            this.lbVerNovaSenha = new System.Windows.Forms.Label();
            this.lbVerConfirmarNovaSenha = new System.Windows.Forms.Label();
            this.lbAlterarSenha = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbSair = new System.Windows.Forms.Label();
            this.lbMaximo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(207, 487);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbNovaSenha.Location = new System.Drawing.Point(89, 214);
            this.lbNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(115, 25);
            this.lbNovaSenha.TabIndex = 144;
            this.lbNovaSenha.Text = "Nova senha";
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNovaSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbNovaSenha.Location = new System.Drawing.Point(89, 242);
            this.tbNovaSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNovaSenha.MaxLength = 30;
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.Size = new System.Drawing.Size(336, 29);
            this.tbNovaSenha.TabIndex = 1;
            this.tbNovaSenha.UseSystemPasswordChar = true;
            // 
            // lbConfirmarNovaSenha
            // 
            this.lbConfirmarNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbConfirmarNovaSenha.AutoSize = true;
            this.lbConfirmarNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbConfirmarNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbConfirmarNovaSenha.Location = new System.Drawing.Point(89, 274);
            this.lbConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmarNovaSenha.Name = "lbConfirmarNovaSenha";
            this.lbConfirmarNovaSenha.Size = new System.Drawing.Size(203, 25);
            this.lbConfirmarNovaSenha.TabIndex = 146;
            this.lbConfirmarNovaSenha.Text = "Confirmar nova senha";
            // 
            // tbConfirmarNovaSenha
            // 
            this.tbConfirmarNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfirmarNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmarNovaSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbConfirmarNovaSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbConfirmarNovaSenha.Location = new System.Drawing.Point(89, 302);
            this.tbConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbConfirmarNovaSenha.MaxLength = 30;
            this.tbConfirmarNovaSenha.Name = "tbConfirmarNovaSenha";
            this.tbConfirmarNovaSenha.Size = new System.Drawing.Size(336, 29);
            this.tbConfirmarNovaSenha.TabIndex = 2;
            this.tbConfirmarNovaSenha.UseSystemPasswordChar = true;
            // 
            // lbSenhaAtual
            // 
            this.lbSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSenhaAtual.AutoSize = true;
            this.lbSenhaAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbSenhaAtual.Location = new System.Drawing.Point(89, 154);
            this.lbSenhaAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSenhaAtual.Name = "lbSenhaAtual";
            this.lbSenhaAtual.Size = new System.Drawing.Size(115, 25);
            this.lbSenhaAtual.TabIndex = 148;
            this.lbSenhaAtual.Text = "Senha atual";
            // 
            // tbSenhaAtual
            // 
            this.tbSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenhaAtual.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbSenhaAtual.Location = new System.Drawing.Point(89, 182);
            this.tbSenhaAtual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSenhaAtual.MaxLength = 30;
            this.tbSenhaAtual.Name = "tbSenhaAtual";
            this.tbSenhaAtual.Size = new System.Drawing.Size(336, 29);
            this.tbSenhaAtual.TabIndex = 0;
            this.tbSenhaAtual.UseSystemPasswordChar = true;
            // 
            // lbVerSenhaAtual
            // 
            this.lbVerSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVerSenhaAtual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerSenhaAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbVerSenhaAtual.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVerSenhaAtual.Image = ((System.Drawing.Image)(resources.GetObject("lbVerSenhaAtual.Image")));
            this.lbVerSenhaAtual.Location = new System.Drawing.Point(425, 182);
            this.lbVerSenhaAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerSenhaAtual.Name = "lbVerSenhaAtual";
            this.lbVerSenhaAtual.Size = new System.Drawing.Size(29, 29);
            this.lbVerSenhaAtual.TabIndex = 150;
            this.lbVerSenhaAtual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVerSenhaAtual.MouseCaptureChanged += new System.EventHandler(this.lbVerSenhaAtual_MouseCaptureChanged);
            // 
            // lbVerNovaSenha
            // 
            this.lbVerNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVerNovaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbVerNovaSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVerNovaSenha.Image = ((System.Drawing.Image)(resources.GetObject("lbVerNovaSenha.Image")));
            this.lbVerNovaSenha.Location = new System.Drawing.Point(425, 242);
            this.lbVerNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerNovaSenha.Name = "lbVerNovaSenha";
            this.lbVerNovaSenha.Size = new System.Drawing.Size(29, 29);
            this.lbVerNovaSenha.TabIndex = 151;
            this.lbVerNovaSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVerNovaSenha.MouseCaptureChanged += new System.EventHandler(this.lbVerNovaSenha_MouseCaptureChanged);
            // 
            // lbVerConfirmarNovaSenha
            // 
            this.lbVerConfirmarNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVerConfirmarNovaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbVerConfirmarNovaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.lbVerConfirmarNovaSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVerConfirmarNovaSenha.Image = ((System.Drawing.Image)(resources.GetObject("lbVerConfirmarNovaSenha.Image")));
            this.lbVerConfirmarNovaSenha.Location = new System.Drawing.Point(425, 302);
            this.lbVerConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVerConfirmarNovaSenha.Name = "lbVerConfirmarNovaSenha";
            this.lbVerConfirmarNovaSenha.Size = new System.Drawing.Size(29, 29);
            this.lbVerConfirmarNovaSenha.TabIndex = 152;
            this.lbVerConfirmarNovaSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbVerConfirmarNovaSenha.MouseCaptureChanged += new System.EventHandler(this.lbVerConfirmarNovaSenha_MouseCaptureChanged);
            // 
            // lbAlterarSenha
            // 
            this.lbAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAlterarSenha.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbAlterarSenha.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbAlterarSenha.Location = new System.Drawing.Point(89, 71);
            this.lbAlterarSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAlterarSenha.Name = "lbAlterarSenha";
            this.lbAlterarSenha.Size = new System.Drawing.Size(336, 43);
            this.lbAlterarSenha.TabIndex = 153;
            this.lbAlterarSenha.Text = "ALTERAR SENHA";
            this.lbAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(89, 401);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(166, 40);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(259, 401);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(166, 40);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(470, 540);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 156;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // lbMaximo
            // 
            this.lbMaximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbMaximo.Location = new System.Drawing.Point(128, 334);
            this.lbMaximo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(258, 24);
            this.lbMaximo.TabIndex = 157;
            this.lbMaximo.Text = "A senha deve conter mínimo de 8 caracteres,\r\nincluindo uma letra maiúscula e um c" +
    "aractere especial!\r\n";
            this.lbMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 584);
            this.Controls.Add(this.lbMaximo);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbAlterarSenha);
            this.Controls.Add(this.lbVerConfirmarNovaSenha);
            this.Controls.Add(this.lbVerNovaSenha);
            this.Controls.Add(this.tbSenhaAtual);
            this.Controls.Add(this.lbVerSenhaAtual);
            this.Controls.Add(this.lbSenhaAtual);
            this.Controls.Add(this.lbConfirmarNovaSenha);
            this.Controls.Add(this.tbConfirmarNovaSenha);
            this.Controls.Add(this.lbNovaSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(533, 623);
            this.Name = "FormAlterarSenha";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.FormAlterarSenha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAlterarSenha_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Label lbConfirmarNovaSenha;
        private System.Windows.Forms.TextBox tbConfirmarNovaSenha;
        private System.Windows.Forms.Label lbSenhaAtual;
        private System.Windows.Forms.TextBox tbSenhaAtual;
        private System.Windows.Forms.Label lbVerSenhaAtual;
        private System.Windows.Forms.Label lbVerNovaSenha;
        private System.Windows.Forms.Label lbVerConfirmarNovaSenha;
        private System.Windows.Forms.Label lbAlterarSenha;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Label lbMaximo;
    }
}