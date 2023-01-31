namespace academia
{
    partial class FormAtualizarInformacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarInformacoes));
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.mtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtbPeso = new System.Windows.Forms.MaskedTextBox();
            this.lbaltura = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.lbkg = new System.Windows.Forms.Label();
            this.lbcm = new System.Windows.Forms.Label();
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
            this.btLimpar.Location = new System.Drawing.Point(65, 177);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(248, 49);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAtualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btAtualizar.ForeColor = System.Drawing.Color.White;
            this.btAtualizar.Location = new System.Drawing.Point(319, 177);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(248, 49);
            this.btAtualizar.TabIndex = 7;
            this.btAtualizar.Text = "&Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // mtbAltura
            // 
            this.mtbAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbAltura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbAltura.HidePromptOnLeave = true;
            this.mtbAltura.Location = new System.Drawing.Point(361, 85);
            this.mtbAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbAltura.Mask = "000";
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.Size = new System.Drawing.Size(153, 29);
            this.mtbAltura.TabIndex = 4;
            this.mtbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbAltura.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbAltura.ValidatingType = typeof(System.DateTime);
            // 
            // mtbPeso
            // 
            this.mtbPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPeso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbPeso.HidePromptOnLeave = true;
            this.mtbPeso.Location = new System.Drawing.Point(65, 85);
            this.mtbPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbPeso.Mask = "000";
            this.mtbPeso.Name = "mtbPeso";
            this.mtbPeso.Size = new System.Drawing.Size(153, 29);
            this.mtbPeso.TabIndex = 1;
            this.mtbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPeso.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPeso.ValidatingType = typeof(System.DateTime);
            // 
            // lbaltura
            // 
            this.lbaltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbaltura.AutoSize = true;
            this.lbaltura.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbaltura.Location = new System.Drawing.Point(393, 50);
            this.lbaltura.Name = "lbaltura";
            this.lbaltura.Size = new System.Drawing.Size(66, 25);
            this.lbaltura.TabIndex = 3;
            this.lbaltura.Text = "Altura";
            // 
            // lbpeso
            // 
            this.lbpeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbpeso.AutoSize = true;
            this.lbpeso.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbpeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbpeso.Location = new System.Drawing.Point(107, 50);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(52, 25);
            this.lbpeso.TabIndex = 0;
            this.lbpeso.Text = "Peso";
            // 
            // lbkg
            // 
            this.lbkg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbkg.AutoSize = true;
            this.lbkg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbkg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbkg.Location = new System.Drawing.Point(223, 87);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(33, 25);
            this.lbkg.TabIndex = 2;
            this.lbkg.Text = "kg";
            // 
            // lbcm
            // 
            this.lbcm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcm.AutoSize = true;
            this.lbcm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbcm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbcm.Location = new System.Drawing.Point(519, 87);
            this.lbcm.Name = "lbcm";
            this.lbcm.Size = new System.Drawing.Size(38, 25);
            this.lbcm.TabIndex = 5;
            this.lbcm.Text = "cm";
            // 
            // FormAtualizarPesoAltura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 284);
            this.Controls.Add(this.mtbAltura);
            this.Controls.Add(this.mtbPeso);
            this.Controls.Add(this.lbaltura);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbkg);
            this.Controls.Add(this.lbcm);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btAtualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(653, 323);
            this.Name = "FormAtualizarPesoAltura";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Informações";
            this.Load += new System.EventHandler(this.FormAtualizarPesoAltura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInscreverAluno_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.MaskedTextBox mtbAltura;
        private System.Windows.Forms.MaskedTextBox mtbPeso;
        private System.Windows.Forms.Label lbaltura;
        private System.Windows.Forms.Label lbpeso;
        private System.Windows.Forms.Label lbkg;
        private System.Windows.Forms.Label lbcm;
    }
}