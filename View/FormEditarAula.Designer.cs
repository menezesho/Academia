﻿namespace academia
{
    partial class FormEditarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarAula));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTipoFiltro = new System.Windows.Forms.Label();
            this.lbLimparBusca = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbListaAulas = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgaulas = new System.Windows.Forms.DataGridView();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.lbLimite = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgaulas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTipoFiltro
            // 
            this.lbTipoFiltro.AutoSize = true;
            this.lbTipoFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTipoFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbTipoFiltro.Location = new System.Drawing.Point(89, 119);
            this.lbTipoFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoFiltro.Name = "lbTipoFiltro";
            this.lbTipoFiltro.Size = new System.Drawing.Size(10, 13);
            this.lbTipoFiltro.TabIndex = 151;
            this.lbTipoFiltro.Text = " ";
            this.lbTipoFiltro.Click += new System.EventHandler(this.lbTipoFiltro_Click);
            // 
            // lbLimparBusca
            // 
            this.lbLimparBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLimparBusca.BackColor = System.Drawing.SystemColors.Window;
            this.lbLimparBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("lbLimparBusca.Image")));
            this.lbLimparBusca.Location = new System.Drawing.Point(532, 138);
            this.lbLimparBusca.Name = "lbLimparBusca";
            this.lbLimparBusca.Size = new System.Drawing.Size(20, 20);
            this.lbLimparBusca.TabIndex = 160;
            this.lbLimparBusca.Click += new System.EventHandler(this.lbLimparBusca_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("lbBuscar.Image")));
            this.lbBuscar.Location = new System.Drawing.Point(562, 134);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(29, 29);
            this.lbBuscar.TabIndex = 159;
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(1194, 575);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 158;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(569, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 157;
            this.pictureBox2.TabStop = false;
            // 
            // lbListaAulas
            // 
            this.lbListaAulas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbListaAulas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbListaAulas.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbListaAulas.Location = new System.Drawing.Point(39, 49);
            this.lbListaAulas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListaAulas.Name = "lbListaAulas";
            this.lbListaAulas.Size = new System.Drawing.Size(1161, 43);
            this.lbListaAulas.TabIndex = 156;
            this.lbListaAulas.Text = "LISTA DE AULAS";
            this.lbListaAulas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbnome.Location = new System.Drawing.Point(680, 226);
            this.lbnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(73, 25);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome*";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbNome.Location = new System.Drawing.Point(680, 254);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(426, 29);
            this.tbNome.TabIndex = 3;
            // 
            // btRelatorio
            // 
            this.btRelatorio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btRelatorio.ForeColor = System.Drawing.Color.White;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.Location = new System.Drawing.Point(1140, 165);
            this.btRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(60, 69);
            this.btRelatorio.TabIndex = 152;
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRelatorio.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(1140, 331);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(60, 69);
            this.btExcluir.TabIndex = 154;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(1140, 414);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(60, 69);
            this.btSalvar.TabIndex = 155;
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbBusca.Location = new System.Drawing.Point(86, 134);
            this.tbBusca.Margin = new System.Windows.Forms.Padding(2);
            this.tbBusca.MaxLength = 100;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(471, 29);
            this.tbBusca.TabIndex = 148;
            this.tbBusca.Enter += new System.EventHandler(this.tbBusca_Enter);
            this.tbBusca.Leave += new System.EventHandler(this.tbBusca_Leave);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.Location = new System.Drawing.Point(1140, 248);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(60, 69);
            this.btLimpar.TabIndex = 153;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgaulas
            // 
            this.dgaulas.AllowUserToAddRows = false;
            this.dgaulas.AllowUserToDeleteRows = false;
            this.dgaulas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgaulas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgaulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgaulas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgaulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgaulas.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgaulas.Location = new System.Drawing.Point(39, 177);
            this.dgaulas.Margin = new System.Windows.Forms.Padding(2);
            this.dgaulas.MultiSelect = false;
            this.dgaulas.Name = "dgaulas";
            this.dgaulas.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgaulas.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgaulas.RowHeadersVisible = false;
            this.dgaulas.RowHeadersWidth = 51;
            this.dgaulas.RowTemplate.Height = 29;
            this.dgaulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgaulas.Size = new System.Drawing.Size(552, 313);
            this.dgaulas.TabIndex = 150;
            this.dgaulas.TabStop = false;
            this.dgaulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgaulas_CellClick);
            // 
            // lbFiltro
            // 
            this.lbFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.lbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFiltro.Image = ((System.Drawing.Image)(resources.GetObject("lbFiltro.Image")));
            this.lbFiltro.Location = new System.Drawing.Point(39, 136);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(25, 25);
            this.lbFiltro.TabIndex = 161;
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
            "Data"});
            this.cbFiltro.Location = new System.Drawing.Point(39, 134);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(43, 29);
            this.cbFiltro.TabIndex = 147;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // mtbTotal
            // 
            this.mtbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTotal.Enabled = false;
            this.mtbTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbTotal.HidePromptOnLeave = true;
            this.mtbTotal.Location = new System.Drawing.Point(1020, 358);
            this.mtbTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbTotal.Mask = "000";
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(86, 29);
            this.mtbTotal.TabIndex = 164;
            this.mtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTotal.ValidatingType = typeof(System.DateTime);
            // 
            // lbLimite
            // 
            this.lbLimite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbLimite.Location = new System.Drawing.Point(1022, 331);
            this.lbLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(82, 25);
            this.lbLimite.TabIndex = 167;
            this.lbLimite.Text = "Máximo";
            this.lbLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpData.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.dtpData.Font = new System.Drawing.Font("Segoe UI Semilight", 13.2F, System.Drawing.FontStyle.Italic);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(680, 358);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpData.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(128, 31);
            this.dtpData.TabIndex = 162;
            this.dtpData.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
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
            this.cbHora.Location = new System.Drawing.Point(858, 358);
            this.cbHora.Margin = new System.Windows.Forms.Padding(2);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(115, 29);
            this.cbHora.TabIndex = 163;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbHorario.Location = new System.Drawing.Point(872, 331);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(86, 25);
            this.lbHorario.TabIndex = 166;
            this.lbHorario.Text = "Horário*";
            this.lbHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbData.Location = new System.Drawing.Point(717, 331);
            this.lbData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(63, 25);
            this.lbData.TabIndex = 165;
            this.lbData.Text = "Data*";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEditarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 619);
            this.Controls.Add(this.mtbTotal);
            this.Controls.Add(this.lbLimite);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbTipoFiltro);
            this.Controls.Add(this.lbLimparBusca);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbListaAulas);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.dgaulas);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1257, 658);
            this.Name = "FormEditarAula";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditarAula_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgaulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoFiltro;
        private System.Windows.Forms.Label lbLimparBusca;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbListaAulas;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgaulas;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbData;
    }
}