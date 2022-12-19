namespace academia.View
{
    partial class FormEditParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditParticipantes));
            this.cbAlunos = new System.Windows.Forms.ComboBox();
            this.cbProfessores = new System.Windows.Forms.ComboBox();
            this.dgaulas = new System.Windows.Forms.DataGridView();
            this.btCancelarAluno = new System.Windows.Forms.Button();
            this.btCancelarProf = new System.Windows.Forms.Button();
            this.lbAulasCadastradas = new System.Windows.Forms.Label();
            this.lbAlunosInscritos = new System.Windows.Forms.Label();
            this.lbProfessoresInscritos = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.btbuscar = new System.Windows.Forms.Button();
            this.lbbusca = new System.Windows.Forms.Label();
            this.tbBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgaulas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAlunos
            // 
            this.cbAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAlunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlunos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlunos.ForeColor = System.Drawing.Color.DimGray;
            this.cbAlunos.FormattingEnabled = true;
            this.cbAlunos.Items.AddRange(new object[] {
            "Selecione"});
            this.cbAlunos.Location = new System.Drawing.Point(732, 233);
            this.cbAlunos.Name = "cbAlunos";
            this.cbAlunos.Size = new System.Drawing.Size(377, 36);
            this.cbAlunos.TabIndex = 1;
            // 
            // cbProfessores
            // 
            this.cbProfessores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfessores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProfessores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfessores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProfessores.ForeColor = System.Drawing.Color.DimGray;
            this.cbProfessores.FormattingEnabled = true;
            this.cbProfessores.Items.AddRange(new object[] {
            "Selecione"});
            this.cbProfessores.Location = new System.Drawing.Point(732, 480);
            this.cbProfessores.Name = "cbProfessores";
            this.cbProfessores.Size = new System.Drawing.Size(377, 36);
            this.cbProfessores.TabIndex = 3;
            // 
            // dgaulas
            // 
            this.dgaulas.AllowUserToAddRows = false;
            this.dgaulas.AllowUserToDeleteRows = false;
            this.dgaulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgaulas.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgaulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgaulas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgaulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgaulas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgaulas.Location = new System.Drawing.Point(91, 243);
            this.dgaulas.MultiSelect = false;
            this.dgaulas.Name = "dgaulas";
            this.dgaulas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgaulas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgaulas.RowHeadersVisible = false;
            this.dgaulas.RowHeadersWidth = 51;
            this.dgaulas.RowTemplate.Height = 29;
            this.dgaulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgaulas.Size = new System.Drawing.Size(569, 345);
            this.dgaulas.TabIndex = 0;
            this.dgaulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgaulas_CellContentClick);
            // 
            // btCancelarAluno
            // 
            this.btCancelarAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelarAluno.BackColor = System.Drawing.Color.DimGray;
            this.btCancelarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarAluno.FlatAppearance.BorderSize = 2;
            this.btCancelarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarAluno.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelarAluno.ForeColor = System.Drawing.Color.White;
            this.btCancelarAluno.Location = new System.Drawing.Point(795, 296);
            this.btCancelarAluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelarAluno.Name = "btCancelarAluno";
            this.btCancelarAluno.Size = new System.Drawing.Size(254, 45);
            this.btCancelarAluno.TabIndex = 2;
            this.btCancelarAluno.Text = "Cancelar Inscrição";
            this.btCancelarAluno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelarAluno.UseVisualStyleBackColor = false;
            // 
            // btCancelarProf
            // 
            this.btCancelarProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelarProf.BackColor = System.Drawing.Color.DimGray;
            this.btCancelarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarProf.FlatAppearance.BorderSize = 2;
            this.btCancelarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarProf.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelarProf.ForeColor = System.Drawing.Color.White;
            this.btCancelarProf.Location = new System.Drawing.Point(795, 543);
            this.btCancelarProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelarProf.Name = "btCancelarProf";
            this.btCancelarProf.Size = new System.Drawing.Size(254, 45);
            this.btCancelarProf.TabIndex = 4;
            this.btCancelarProf.Text = "Cancelar Inscrição";
            this.btCancelarProf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelarProf.UseVisualStyleBackColor = false;
            // 
            // lbAulasCadastradas
            // 
            this.lbAulasCadastradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAulasCadastradas.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAulasCadastradas.ForeColor = System.Drawing.Color.DimGray;
            this.lbAulasCadastradas.Location = new System.Drawing.Point(91, 175);
            this.lbAulasCadastradas.Name = "lbAulasCadastradas";
            this.lbAulasCadastradas.Size = new System.Drawing.Size(569, 45);
            this.lbAulasCadastradas.TabIndex = 134;
            this.lbAulasCadastradas.Text = "AULAS CADASTRADAS";
            this.lbAulasCadastradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAlunosInscritos
            // 
            this.lbAlunosInscritos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAlunosInscritos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAlunosInscritos.ForeColor = System.Drawing.Color.DimGray;
            this.lbAlunosInscritos.Location = new System.Drawing.Point(732, 175);
            this.lbAlunosInscritos.Name = "lbAlunosInscritos";
            this.lbAlunosInscritos.Size = new System.Drawing.Size(377, 45);
            this.lbAlunosInscritos.TabIndex = 135;
            this.lbAlunosInscritos.Text = "ALUNOS INSCRITOS";
            this.lbAlunosInscritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProfessoresInscritos
            // 
            this.lbProfessoresInscritos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProfessoresInscritos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProfessoresInscritos.ForeColor = System.Drawing.Color.DimGray;
            this.lbProfessoresInscritos.Location = new System.Drawing.Point(732, 422);
            this.lbProfessoresInscritos.Name = "lbProfessoresInscritos";
            this.lbProfessoresInscritos.Size = new System.Drawing.Size(377, 45);
            this.lbProfessoresInscritos.TabIndex = 136;
            this.lbProfessoresInscritos.Text = "PROFESSORES INSCRITOS";
            this.lbProfessoresInscritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(1160, 620);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(40, 37);
            this.lbSair.TabIndex = 137;
            // 
            // btbuscar
            // 
            this.btbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbuscar.BackgroundImage")));
            this.btbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.FlatAppearance.BorderSize = 0;
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscar.Location = new System.Drawing.Point(625, 119);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(35, 34);
            this.btbuscar.TabIndex = 167;
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // lbbusca
            // 
            this.lbbusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbbusca.AutoSize = true;
            this.lbbusca.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbbusca.ForeColor = System.Drawing.Color.DimGray;
            this.lbbusca.Location = new System.Drawing.Point(91, 84);
            this.lbbusca.Name = "lbbusca";
            this.lbbusca.Size = new System.Drawing.Size(74, 31);
            this.lbbusca.TabIndex = 166;
            this.lbbusca.Text = "Busca";
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBusca.ForeColor = System.Drawing.Color.DimGray;
            this.tbBusca.Location = new System.Drawing.Point(91, 118);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(528, 34);
            this.tbBusca.TabIndex = 165;
            // 
            // FormEditarParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1212, 666);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.lbbusca);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.lbProfessoresInscritos);
            this.Controls.Add(this.lbAlunosInscritos);
            this.Controls.Add(this.lbAulasCadastradas);
            this.Controls.Add(this.btCancelarProf);
            this.Controls.Add(this.btCancelarAluno);
            this.Controls.Add(this.dgaulas);
            this.Controls.Add(this.cbProfessores);
            this.Controls.Add(this.cbAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1182, 674);
            this.Name = "FormEditarParticipantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes de Inscrições";
            this.Load += new System.EventHandler(this.FormEditarParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgaulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAlunos;
        private System.Windows.Forms.ComboBox cbProfessores;
        private System.Windows.Forms.DataGridView dgaulas;
        private System.Windows.Forms.Button btCancelarAluno;
        private System.Windows.Forms.Button btCancelarProf;
        private System.Windows.Forms.Label lbAulasCadastradas;
        private System.Windows.Forms.Label lbAlunosInscritos;
        private System.Windows.Forms.Label lbProfessoresInscritos;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label lbbusca;
        private System.Windows.Forms.TextBox tbBusca;
    }
}