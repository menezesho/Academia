
namespace projetofinal
{
    partial class FormEditarAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarAluno));
            this.dgalunos = new System.Windows.Forms.DataGridView();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.tcDados = new System.Windows.Forms.TabControl();
            this.tpDadosPessoais = new System.Windows.Forms.TabPage();
            this.mtbIdade = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbidade = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tpEndereco = new System.Windows.Forms.TabPage();
            this.mtbApto = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbApto = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tpInfoAdicionais = new System.Windows.Forms.TabPage();
            this.mtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtbPeso = new System.Windows.Forms.MaskedTextBox();
            this.lbaltura = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.lbkg = new System.Windows.Forms.Label();
            this.lbcm = new System.Windows.Forms.Label();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbListaAlunos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbSair = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbLimparBusca = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.lbTipoFiltro = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btRelatorio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).BeginInit();
            this.tcDados.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            this.tpInfoAdicionais.SuspendLayout();
            this.tpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgalunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgalunos.Location = new System.Drawing.Point(39, 154);
            this.dgalunos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgalunos.MultiSelect = false;
            this.dgalunos.Name = "dgalunos";
            this.dgalunos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgalunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgalunos.RowHeadersVisible = false;
            this.dgalunos.RowHeadersWidth = 51;
            this.dgalunos.RowTemplate.Height = 29;
            this.dgalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalunos.Size = new System.Drawing.Size(552, 358);
            this.dgalunos.TabIndex = 7;
            this.dgalunos.TabStop = false;
            this.dgalunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgalunos_CellClick);
            // 
            // tbBusca
            // 
            this.tbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbBusca.Location = new System.Drawing.Point(86, 111);
            this.tbBusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBusca.MaxLength = 100;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(471, 29);
            this.tbBusca.TabIndex = 4;
            this.tbBusca.Enter += new System.EventHandler(this.tbBusca_Enter);
            this.tbBusca.Leave += new System.EventHandler(this.tbBusca_Leave);
            // 
            // tcDados
            // 
            this.tcDados.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tcDados.Controls.Add(this.tpDadosPessoais);
            this.tcDados.Controls.Add(this.tpEndereco);
            this.tcDados.Controls.Add(this.tpInfoAdicionais);
            this.tcDados.Controls.Add(this.tpLogin);
            this.tcDados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDados.Location = new System.Drawing.Point(616, 111);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(519, 356);
            this.tcDados.TabIndex = 8;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpDadosPessoais.Controls.Add(this.mtbIdade);
            this.tpDadosPessoais.Controls.Add(this.mtbCelular);
            this.tpDadosPessoais.Controls.Add(this.lbnome);
            this.tpDadosPessoais.Controls.Add(this.lbcpf);
            this.tpDadosPessoais.Controls.Add(this.lbidade);
            this.tpDadosPessoais.Controls.Add(this.tbNome);
            this.tpDadosPessoais.Controls.Add(this.lbcelular);
            this.tpDadosPessoais.Controls.Add(this.lbemail);
            this.tpDadosPessoais.Controls.Add(this.tbEmail);
            this.tpDadosPessoais.Controls.Add(this.mtbCpf);
            this.tpDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 30);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpDadosPessoais.Size = new System.Drawing.Size(511, 322);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "DADOS PESSOAIS";
            // 
            // mtbIdade
            // 
            this.mtbIdade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbIdade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbIdade.HidePromptOnLeave = true;
            this.mtbIdade.Location = new System.Drawing.Point(387, 160);
            this.mtbIdade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbIdade.Mask = "000";
            this.mtbIdade.Name = "mtbIdade";
            this.mtbIdade.Size = new System.Drawing.Size(63, 29);
            this.mtbIdade.TabIndex = 7;
            this.mtbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbIdade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbIdade.ValidatingType = typeof(System.DateTime);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCelular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbCelular.Location = new System.Drawing.Point(217, 160);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(143, 29);
            this.mtbCelular.TabIndex = 5;
            this.mtbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbnome
            // 
            this.lbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbnome.Location = new System.Drawing.Point(60, 62);
            this.lbnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(73, 25);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome*";
            // 
            // lbcpf
            // 
            this.lbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbcpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbcpf.Location = new System.Drawing.Point(102, 132);
            this.lbcpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(53, 25);
            this.lbcpf.TabIndex = 2;
            this.lbcpf.Text = "CPF*";
            // 
            // lbidade
            // 
            this.lbidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbidade.AutoSize = true;
            this.lbidade.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbidade.Location = new System.Drawing.Point(388, 132);
            this.lbidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbidade.Name = "lbidade";
            this.lbidade.Size = new System.Drawing.Size(69, 25);
            this.lbidade.TabIndex = 6;
            this.lbidade.Text = "Idade*";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbNome.Location = new System.Drawing.Point(60, 90);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(390, 29);
            this.tbNome.TabIndex = 1;
            // 
            // lbcelular
            // 
            this.lbcelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcelular.AutoSize = true;
            this.lbcelular.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbcelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbcelular.Location = new System.Drawing.Point(252, 132);
            this.lbcelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(81, 25);
            this.lbcelular.TabIndex = 4;
            this.lbcelular.Text = "Celular*";
            // 
            // lbemail
            // 
            this.lbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbemail.Location = new System.Drawing.Point(60, 202);
            this.lbemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(76, 25);
            this.lbemail.TabIndex = 8;
            this.lbemail.Text = "E-mail*";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbEmail.Location = new System.Drawing.Point(60, 230);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(390, 29);
            this.tbEmail.TabIndex = 9;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCpf.Enabled = false;
            this.mtbCpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbCpf.Location = new System.Drawing.Point(60, 160);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(129, 29);
            this.mtbCpf.TabIndex = 3;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tpEndereco
            // 
            this.tpEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpEndereco.Controls.Add(this.mtbApto);
            this.tpEndereco.Controls.Add(this.mtbNumero);
            this.tpEndereco.Controls.Add(this.tbRua);
            this.tpEndereco.Controls.Add(this.lbRua);
            this.tpEndereco.Controls.Add(this.lbBairro);
            this.tpEndereco.Controls.Add(this.tbBairro);
            this.tpEndereco.Controls.Add(this.lbCidade);
            this.tpEndereco.Controls.Add(this.tbCidade);
            this.tpEndereco.Controls.Add(this.lbApto);
            this.tpEndereco.Controls.Add(this.lbNum);
            this.tpEndereco.Controls.Add(this.lbEstado);
            this.tpEndereco.Controls.Add(this.cbEstado);
            this.tpEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tpEndereco.Location = new System.Drawing.Point(4, 30);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpEndereco.Size = new System.Drawing.Size(511, 322);
            this.tpEndereco.TabIndex = 1;
            this.tpEndereco.Text = "ENDEREÇO";
            // 
            // mtbApto
            // 
            this.mtbApto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbApto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbApto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbApto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbApto.HidePromptOnLeave = true;
            this.mtbApto.Location = new System.Drawing.Point(204, 122);
            this.mtbApto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbApto.Mask = "00000";
            this.mtbApto.Name = "mtbApto";
            this.mtbApto.Size = new System.Drawing.Size(85, 29);
            this.mtbApto.TabIndex = 5;
            this.mtbApto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbApto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbApto.ValidatingType = typeof(System.DateTime);
            // 
            // mtbNumero
            // 
            this.mtbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbNumero.HidePromptOnLeave = true;
            this.mtbNumero.Location = new System.Drawing.Point(58, 122);
            this.mtbNumero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbNumero.Mask = "00000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(85, 29);
            this.mtbNumero.TabIndex = 3;
            this.mtbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumero.ValidatingType = typeof(System.DateTime);
            // 
            // tbRua
            // 
            this.tbRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbRua.Location = new System.Drawing.Point(58, 52);
            this.tbRua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbRua.MaxLength = 100;
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(393, 29);
            this.tbRua.TabIndex = 1;
            // 
            // lbRua
            // 
            this.lbRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbRua.Location = new System.Drawing.Point(58, 24);
            this.lbRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(54, 25);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua*";
            // 
            // lbBairro
            // 
            this.lbBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbBairro.Location = new System.Drawing.Point(58, 234);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(73, 25);
            this.lbBairro.TabIndex = 10;
            this.lbBairro.Text = "Bairro*";
            // 
            // tbBairro
            // 
            this.tbBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbBairro.Location = new System.Drawing.Point(58, 262);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBairro.MaxLength = 50;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(393, 29);
            this.tbBairro.TabIndex = 11;
            // 
            // lbCidade
            // 
            this.lbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbCidade.Location = new System.Drawing.Point(58, 164);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(80, 25);
            this.lbCidade.TabIndex = 8;
            this.lbCidade.Text = "Cidade*";
            // 
            // tbCidade
            // 
            this.tbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbCidade.Location = new System.Drawing.Point(59, 192);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCidade.MaxLength = 50;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(392, 29);
            this.tbCidade.TabIndex = 9;
            // 
            // lbApto
            // 
            this.lbApto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbApto.AutoSize = true;
            this.lbApto.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbApto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbApto.Location = new System.Drawing.Point(217, 95);
            this.lbApto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApto.Name = "lbApto";
            this.lbApto.Size = new System.Drawing.Size(59, 25);
            this.lbApto.TabIndex = 4;
            this.lbApto.Text = "Apto.";
            // 
            // lbNum
            // 
            this.lbNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbNum.Location = new System.Drawing.Point(70, 94);
            this.lbNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(68, 25);
            this.lbNum.TabIndex = 2;
            this.lbNum.Text = "Num.*";
            // 
            // lbEstado
            // 
            this.lbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbEstado.Location = new System.Drawing.Point(365, 95);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(78, 25);
            this.lbEstado.TabIndex = 6;
            this.lbEstado.Text = "Estado*";
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Selecione",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(349, 122);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(102, 29);
            this.cbEstado.TabIndex = 7;
            // 
            // tpInfoAdicionais
            // 
            this.tpInfoAdicionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpInfoAdicionais.Controls.Add(this.mtbAltura);
            this.tpInfoAdicionais.Controls.Add(this.mtbPeso);
            this.tpInfoAdicionais.Controls.Add(this.lbaltura);
            this.tpInfoAdicionais.Controls.Add(this.lbpeso);
            this.tpInfoAdicionais.Controls.Add(this.lbkg);
            this.tpInfoAdicionais.Controls.Add(this.lbcm);
            this.tpInfoAdicionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tpInfoAdicionais.Location = new System.Drawing.Point(4, 30);
            this.tpInfoAdicionais.Name = "tpInfoAdicionais";
            this.tpInfoAdicionais.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpInfoAdicionais.Size = new System.Drawing.Size(511, 322);
            this.tpInfoAdicionais.TabIndex = 2;
            this.tpInfoAdicionais.Text = "INFORMAÇÕES ADICIONAIS";
            // 
            // mtbAltura
            // 
            this.mtbAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbAltura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbAltura.HidePromptOnLeave = true;
            this.mtbAltura.Location = new System.Drawing.Point(217, 179);
            this.mtbAltura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbAltura.Mask = "000";
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.Size = new System.Drawing.Size(85, 29);
            this.mtbAltura.TabIndex = 15;
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
            this.mtbPeso.Location = new System.Drawing.Point(217, 109);
            this.mtbPeso.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtbPeso.Mask = "000";
            this.mtbPeso.Name = "mtbPeso";
            this.mtbPeso.Size = new System.Drawing.Size(85, 29);
            this.mtbPeso.TabIndex = 14;
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
            this.lbaltura.Location = new System.Drawing.Point(217, 151);
            this.lbaltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbaltura.Name = "lbaltura";
            this.lbaltura.Size = new System.Drawing.Size(66, 25);
            this.lbaltura.TabIndex = 13;
            this.lbaltura.Text = "Altura";
            // 
            // lbpeso
            // 
            this.lbpeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbpeso.AutoSize = true;
            this.lbpeso.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbpeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbpeso.Location = new System.Drawing.Point(217, 81);
            this.lbpeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(52, 25);
            this.lbpeso.TabIndex = 12;
            this.lbpeso.Text = "Peso";
            // 
            // lbkg
            // 
            this.lbkg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbkg.AutoSize = true;
            this.lbkg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbkg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbkg.Location = new System.Drawing.Point(305, 111);
            this.lbkg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbkg.Name = "lbkg";
            this.lbkg.Size = new System.Drawing.Size(33, 25);
            this.lbkg.TabIndex = 18;
            this.lbkg.Text = "kg";
            // 
            // lbcm
            // 
            this.lbcm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcm.AutoSize = true;
            this.lbcm.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbcm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbcm.Location = new System.Drawing.Point(305, 181);
            this.lbcm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcm.Name = "lbcm";
            this.lbcm.Size = new System.Drawing.Size(38, 25);
            this.lbcm.TabIndex = 19;
            this.lbcm.Text = "cm";
            // 
            // tpLogin
            // 
            this.tpLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpLogin.Controls.Add(this.lbSenha);
            this.tpLogin.Controls.Add(this.tbSenha);
            this.tpLogin.Controls.Add(this.lbUsuario);
            this.tpLogin.Controls.Add(this.tbUsuario);
            this.tpLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tpLogin.Location = new System.Drawing.Point(4, 30);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Size = new System.Drawing.Size(511, 322);
            this.tpLogin.TabIndex = 3;
            this.tpLogin.Text = "LOGIN";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbSenha.Location = new System.Drawing.Point(65, 169);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(73, 25);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha*";
            // 
            // tbSenha
            // 
            this.tbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbSenha.Location = new System.Drawing.Point(65, 197);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSenha.MaxLength = 30;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(390, 29);
            this.tbSenha.TabIndex = 17;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbUsuario.Location = new System.Drawing.Point(64, 99);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(86, 25);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuário*";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbUsuario.Location = new System.Drawing.Point(64, 127);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUsuario.MaxLength = 30;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(390, 29);
            this.tbUsuario.TabIndex = 16;
            // 
            // lbListaAlunos
            // 
            this.lbListaAlunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbListaAlunos.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbListaAlunos.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbListaAlunos.Location = new System.Drawing.Point(39, 26);
            this.lbListaAlunos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListaAlunos.Name = "lbListaAlunos";
            this.lbListaAlunos.Size = new System.Drawing.Size(1161, 43);
            this.lbListaAlunos.TabIndex = 0;
            this.lbListaAlunos.Text = "LISTA DE ALUNOS";
            this.lbListaAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(551, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // lbSair
            // 
            this.lbSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSair.Image = ((System.Drawing.Image)(resources.GetObject("lbSair.Image")));
            this.lbSair.Location = new System.Drawing.Point(1194, 575);
            this.lbSair.Name = "lbSair";
            this.lbSair.Size = new System.Drawing.Size(35, 35);
            this.lbSair.TabIndex = 12;
            this.lbSair.Click += new System.EventHandler(this.lbSair_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("lbBuscar.Image")));
            this.lbBuscar.Location = new System.Drawing.Point(562, 111);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(29, 29);
            this.lbBuscar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lbBuscar, "Buscar");
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // lbLimparBusca
            // 
            this.lbLimparBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLimparBusca.BackColor = System.Drawing.SystemColors.Window;
            this.lbLimparBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimparBusca.Image = ((System.Drawing.Image)(resources.GetObject("lbLimparBusca.Image")));
            this.lbLimparBusca.Location = new System.Drawing.Point(532, 115);
            this.lbLimparBusca.Name = "lbLimparBusca";
            this.lbLimparBusca.Size = new System.Drawing.Size(20, 20);
            this.lbLimparBusca.TabIndex = 5;
            this.lbLimparBusca.Click += new System.EventHandler(this.lbLimparBusca_Click);
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
            "CPF",
            "E-mail",
            "Usuário"});
            this.cbFiltro.Location = new System.Drawing.Point(39, 111);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(43, 29);
            this.cbFiltro.TabIndex = 2;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // lbFiltro
            // 
            this.lbFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.lbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFiltro.Image = ((System.Drawing.Image)(resources.GetObject("lbFiltro.Image")));
            this.lbFiltro.Location = new System.Drawing.Point(39, 113);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(25, 25);
            this.lbFiltro.TabIndex = 1;
            // 
            // lbTipoFiltro
            // 
            this.lbTipoFiltro.AutoSize = true;
            this.lbTipoFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTipoFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbTipoFiltro.Location = new System.Drawing.Point(89, 96);
            this.lbTipoFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoFiltro.Name = "lbTipoFiltro";
            this.lbTipoFiltro.Size = new System.Drawing.Size(10, 13);
            this.lbTipoFiltro.TabIndex = 3;
            this.lbTipoFiltro.Text = " ";
            this.lbTipoFiltro.Click += new System.EventHandler(this.lbTipoFiltro_Click);
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
            this.btRelatorio.Location = new System.Drawing.Point(617, 472);
            this.btRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(40, 40);
            this.btRelatorio.TabIndex = 9;
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btRelatorio, "Gerar relatório");
            this.btRelatorio.UseVisualStyleBackColor = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(900, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Salvar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.button1, "Salvar alterações");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(661, 472);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(235, 40);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btExcluir, "Excluir cadastro");
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FormEditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 619);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTipoFiltro);
            this.Controls.Add(this.lbLimparBusca);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.lbSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbListaAlunos);
            this.Controls.Add(this.tcDados);
            this.Controls.Add(this.tbBusca);
            this.Controls.Add(this.dgalunos);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1257, 658);
            this.Name = "FormEditarAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.FormEditAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgalunos)).EndInit();
            this.tcDados.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            this.tpInfoAdicionais.ResumeLayout(false);
            this.tpInfoAdicionais.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgalunos;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.TabControl tcDados;
        private System.Windows.Forms.TabPage tpDadosPessoais;
        private System.Windows.Forms.MaskedTextBox mtbIdade;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TabPage tpEndereco;
        private System.Windows.Forms.MaskedTextBox mtbApto;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbApto;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TabPage tpInfoAdicionais;
        private System.Windows.Forms.MaskedTextBox mtbAltura;
        private System.Windows.Forms.MaskedTextBox mtbPeso;
        private System.Windows.Forms.Label lbaltura;
        private System.Windows.Forms.Label lbpeso;
        private System.Windows.Forms.Label lbkg;
        private System.Windows.Forms.Label lbcm;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbListaAlunos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbSair;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lbLimparBusca;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label lbTipoFiltro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btRelatorio;
    }
}