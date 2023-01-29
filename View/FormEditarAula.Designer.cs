namespace academia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarAula));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTipoFiltro = new System.Windows.Forms.Label();
            this.lbLimparBusca = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbSair = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbListaAulas = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.dgaulas = new System.Windows.Forms.DataGridView();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.lbLimite = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.dgalunos = new System.Windows.Forms.DataGridView();
            this.tcDados = new System.Windows.Forms.TabControl();
            this.tpDadosGerais = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgaulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).BeginInit();
            this.tcDados.SuspendLayout();
            this.tpDadosGerais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTipoFiltro
            // 
            this.lbTipoFiltro.AutoSize = true;
            this.lbTipoFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTipoFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbTipoFiltro.Location = new System.Drawing.Point(161, 118);
            this.lbTipoFiltro.Name = "lbTipoFiltro";
            this.lbTipoFiltro.Size = new System.Drawing.Size(10, 13);
            this.lbTipoFiltro.TabIndex = 3;
            this.lbTipoFiltro.Text = " ";
            this.lbTipoFiltro.Click += new System.EventHandler(this.lbTipoFiltro_Click);
            // 
            // lbLimparBusca
            // 
            this.lbLimparBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLimparBusca.BackColor = System.Drawing.SystemColors.Window;
            this.lbLimparBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("lbLimparBusca.Image")));
            this.lbLimparBusca.Location = new System.Drawing.Point(752, 142);
            this.lbLimparBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLimparBusca.Name = "lbLimparBusca";
            this.lbLimparBusca.Size = new System.Drawing.Size(27, 25);
            this.lbLimparBusca.TabIndex = 5;
            this.lbLimparBusca.Click += new System.EventHandler(this.lbLimparBusca_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("lbBuscar.Image")));
            this.lbBuscar.Location = new System.Drawing.Point(792, 137);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(39, 36);
            this.lbBuscar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lbBuscar, "Buscar");
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(1592, 708);
            this.lbSair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(47, 43);
            this.lbSair.TabIndex = 12;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(796, 686);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 157;
            this.pictureBox2.TabStop = false;
            // 
            // lbListaAulas
            // 
            this.lbListaAulas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbListaAulas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbListaAulas.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbListaAulas.Location = new System.Drawing.Point(95, 32);
            this.lbListaAulas.Name = "lbListaAulas";
            this.lbListaAulas.Size = new System.Drawing.Size(1461, 53);
            this.lbListaAulas.TabIndex = 0;
            this.lbListaAulas.Text = "LISTA DE AULAS";
            this.lbListaAulas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbnome.Location = new System.Drawing.Point(59, 102);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(73, 25);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome*";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbNome.Location = new System.Drawing.Point(59, 137);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(567, 29);
            this.tbNome.TabIndex = 1;
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbBusca.Location = new System.Drawing.Point(157, 137);
            this.tbBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBusca.MaxLength = 100;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(627, 29);
            this.tbBusca.TabIndex = 4;
            this.tbBusca.Enter += new System.EventHandler(this.tbBusca_Enter);
            this.tbBusca.Leave += new System.EventHandler(this.tbBusca_Leave);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgaulas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgaulas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgaulas.Location = new System.Drawing.Point(95, 190);
            this.dgaulas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgaulas.MultiSelect = false;
            this.dgaulas.Name = "dgaulas";
            this.dgaulas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgaulas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgaulas.RowHeadersVisible = false;
            this.dgaulas.RowHeadersWidth = 51;
            this.dgaulas.RowTemplate.Height = 29;
            this.dgaulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgaulas.Size = new System.Drawing.Size(736, 441);
            this.dgaulas.TabIndex = 7;
            this.dgaulas.TabStop = false;
            this.dgaulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgaulas_CellClick);
            // 
            // lbFiltro
            // 
            this.lbFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.lbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFiltro.Image = ((System.Drawing.Image)(resources.GetObject("lbFiltro.Image")));
            this.lbFiltro.Location = new System.Drawing.Point(95, 139);
            this.lbFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(33, 31);
            this.lbFiltro.TabIndex = 1;
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
            "Data (YYYY-MM-DD)"});
            this.cbFiltro.Location = new System.Drawing.Point(95, 137);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(56, 29);
            this.cbFiltro.TabIndex = 2;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // mtbTotal
            // 
            this.mtbTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mtbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTotal.Enabled = false;
            this.mtbTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbTotal.HidePromptOnLeave = true;
            this.mtbTotal.Location = new System.Drawing.Point(512, 265);
            this.mtbTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTotal.Mask = "000";
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(114, 29);
            this.mtbTotal.TabIndex = 7;
            this.mtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTotal.ValidatingType = typeof(System.DateTime);
            // 
            // lbLimite
            // 
            this.lbLimite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbLimite.AutoSize = true;
            this.lbLimite.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbLimite.Location = new System.Drawing.Point(515, 231);
            this.lbLimite.Name = "lbLimite";
            this.lbLimite.Size = new System.Drawing.Size(82, 25);
            this.lbLimite.TabIndex = 6;
            this.lbLimite.Text = "Máximo";
            this.lbLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpData.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.dtpData.Font = new System.Drawing.Font("Segoe UI Semilight", 13.2F, System.Drawing.FontStyle.Italic);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(59, 265);
            this.dtpData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpData.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(169, 31);
            this.dtpData.TabIndex = 3;
            this.dtpData.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            // 
            // cbHora
            // 
            this.cbHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.cbHora.Location = new System.Drawing.Point(296, 265);
            this.cbHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(152, 29);
            this.cbHora.TabIndex = 5;
            // 
            // lbHorario
            // 
            this.lbHorario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbHorario.Location = new System.Drawing.Point(315, 231);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(86, 25);
            this.lbHorario.TabIndex = 4;
            this.lbHorario.Text = "Horário*";
            this.lbHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbData
            // 
            this.lbData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbData.Location = new System.Drawing.Point(108, 231);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(63, 25);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data*";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgalunos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgalunos.Location = new System.Drawing.Point(95, 190);
            this.dgalunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgalunos.MultiSelect = false;
            this.dgalunos.Name = "dgalunos";
            this.dgalunos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgalunos.RowHeadersVisible = false;
            this.dgalunos.RowHeadersWidth = 51;
            this.dgalunos.RowTemplate.Height = 29;
            this.dgalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalunos.Size = new System.Drawing.Size(736, 385);
            this.dgalunos.TabIndex = 168;
            this.dgalunos.TabStop = false;
            // 
            // tcDados
            // 
            this.tcDados.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tcDados.Controls.Add(this.tpDadosGerais);
            this.tcDados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDados.Location = new System.Drawing.Point(864, 137);
            this.tcDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(692, 438);
            this.tcDados.TabIndex = 8;
            // 
            // tpDadosGerais
            // 
            this.tpDadosGerais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpDadosGerais.Controls.Add(this.tbNome);
            this.tpDadosGerais.Controls.Add(this.mtbTotal);
            this.tpDadosGerais.Controls.Add(this.lbnome);
            this.tpDadosGerais.Controls.Add(this.lbLimite);
            this.tpDadosGerais.Controls.Add(this.lbData);
            this.tpDadosGerais.Controls.Add(this.dtpData);
            this.tpDadosGerais.Controls.Add(this.lbHorario);
            this.tpDadosGerais.Controls.Add(this.cbHora);
            this.tpDadosGerais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tpDadosGerais.Location = new System.Drawing.Point(4, 30);
            this.tpDadosGerais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDadosGerais.Name = "tpDadosGerais";
            this.tpDadosGerais.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDadosGerais.Size = new System.Drawing.Size(684, 404);
            this.tpDadosGerais.TabIndex = 0;
            this.tpDadosGerais.Text = "DADOS GERAIS";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 4800;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 96;
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
            this.btRelatorio.Location = new System.Drawing.Point(865, 581);
            this.btRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(53, 49);
            this.btRelatorio.TabIndex = 9;
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btRelatorio, "Gerar relatório");
            this.btRelatorio.UseVisualStyleBackColor = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(924, 581);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(313, 49);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btExcluir, "Excluir cadastro");
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
            this.btSalvar.Location = new System.Drawing.Point(1243, 581);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(313, 49);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar alterações");
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FormEditarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 762);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tcDados);
            this.Controls.Add(this.lbTipoFiltro);
            this.Controls.Add(this.lbLimparBusca);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbListaAulas);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.dgaulas);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.dgalunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1671, 801);
            this.Name = "FormEditarAula";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditarAula_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgaulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).EndInit();
            this.tcDados.ResumeLayout(false);
            this.tpDadosGerais.ResumeLayout(false);
            this.tpDadosGerais.PerformLayout();
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
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.DataGridView dgaulas;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.Label lbLimite;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DataGridView dgalunos;
        private System.Windows.Forms.TabControl tcDados;
        private System.Windows.Forms.TabPage tpDadosGerais;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
    }
}