namespace SICM.SubForms
{
    partial class FrmGerenteIgrejas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ListaTemplos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_OpcoesTabIgreja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERINFORMAÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTUALIZARTABELAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cnpjTemplo = new System.Windows.Forms.MaskedTextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_DataFund = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_BairroCong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CidadeCong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_RuaCong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lv_ListaCongregacoes = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.C_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cms_OpcoesGons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTUALIZARLISTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_CapMediCong = new System.Windows.Forms.TextBox();
            this.txt_NumMemCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dirigente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_CapMedio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NumCong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumDepart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumMembros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaTemplos)).BeginInit();
            this.Cms_OpcoesTabIgreja.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Cms_OpcoesGons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ListaTemplos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TABELA DE DADOS";
            // 
            // dgv_ListaTemplos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaTemplos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListaTemplos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaTemplos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.Rua,
            this.Bairro,
            this.CIDADE,
            this.dtaFund});
            this.dgv_ListaTemplos.ContextMenuStrip = this.Cms_OpcoesTabIgreja;
            this.dgv_ListaTemplos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListaTemplos.EnableHeadersVisualStyles = false;
            this.dgv_ListaTemplos.Location = new System.Drawing.Point(3, 25);
            this.dgv_ListaTemplos.MultiSelect = false;
            this.dgv_ListaTemplos.Name = "dgv_ListaTemplos";
            this.dgv_ListaTemplos.ReadOnly = true;
            this.dgv_ListaTemplos.RowHeadersVisible = false;
            this.dgv_ListaTemplos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ListaTemplos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListaTemplos.Size = new System.Drawing.Size(813, 129);
            this.dgv_ListaTemplos.TabIndex = 0;
            this.dgv_ListaTemplos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaTemplos_CellClick);
            this.dgv_ListaTemplos.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgv_ListaTemplos_CellParsing);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rua.HeaderText = "RUA";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            this.Rua.Width = 175;
            // 
            // Bairro
            // 
            this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Bairro.HeaderText = "BAIRRO";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 170;
            // 
            // CIDADE
            // 
            this.CIDADE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Width = 220;
            // 
            // dtaFund
            // 
            this.dtaFund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dtaFund.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtaFund.HeaderText = "DTA.FUND.";
            this.dtaFund.Name = "dtaFund";
            this.dtaFund.ReadOnly = true;
            this.dtaFund.Width = 130;
            // 
            // Cms_OpcoesTabIgreja
            // 
            this.Cms_OpcoesTabIgreja.BackColor = System.Drawing.SystemColors.Info;
            this.Cms_OpcoesTabIgreja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Cms_OpcoesTabIgreja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITARToolStripMenuItem,
            this.dELETARToolStripMenuItem,
            this.vERINFORMAÇÕESToolStripMenuItem,
            this.aTUALIZARTABELAToolStripMenuItem});
            this.Cms_OpcoesTabIgreja.Name = "Cms_OpcoesTabIgreja";
            this.Cms_OpcoesTabIgreja.Size = new System.Drawing.Size(241, 156);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Image = global::SICM.Properties.Resources.editar;
            this.eDITARToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eDITARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.eDITARToolStripMenuItem.Text = "1. EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
            // 
            // dELETARToolStripMenuItem
            // 
            this.dELETARToolStripMenuItem.Image = global::SICM.Properties.Resources.excluir;
            this.dELETARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
            this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.dELETARToolStripMenuItem.Text = "2. DELETAR";
            this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.dELETARToolStripMenuItem_Click);
            // 
            // vERINFORMAÇÕESToolStripMenuItem
            // 
            this.vERINFORMAÇÕESToolStripMenuItem.Image = global::SICM.Properties.Resources.NOVO;
            this.vERINFORMAÇÕESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vERINFORMAÇÕESToolStripMenuItem.Name = "vERINFORMAÇÕESToolStripMenuItem";
            this.vERINFORMAÇÕESToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.vERINFORMAÇÕESToolStripMenuItem.Text = "3. NOVO";
            this.vERINFORMAÇÕESToolStripMenuItem.Click += new System.EventHandler(this.vERINFORMAÇÕESToolStripMenuItem_Click);
            // 
            // aTUALIZARTABELAToolStripMenuItem
            // 
            this.aTUALIZARTABELAToolStripMenuItem.Image = global::SICM.Properties.Resources.atualizar;
            this.aTUALIZARTABELAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aTUALIZARTABELAToolStripMenuItem.Name = "aTUALIZARTABELAToolStripMenuItem";
            this.aTUALIZARTABELAToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
            this.aTUALIZARTABELAToolStripMenuItem.Text = "4. ATUALIZAR TABELA";
            this.aTUALIZARTABELAToolStripMenuItem.Click += new System.EventHandler(this.aTUALIZARTABELAToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cnpjTemplo);
            this.groupBox2.Controls.Add(this.txt_codigo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txt_CapMedio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_NumCong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_NumDepart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_NumMembros);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DA IGREJA SELECIONADA";
            // 
            // txt_cnpjTemplo
            // 
            this.txt_cnpjTemplo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_cnpjTemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnpjTemplo.ForeColor = System.Drawing.Color.Blue;
            this.txt_cnpjTemplo.Location = new System.Drawing.Point(68, 75);
            this.txt_cnpjTemplo.Mask = "##,###,###/####-##";
            this.txt_cnpjTemplo.Name = "txt_cnpjTemplo";
            this.txt_cnpjTemplo.Size = new System.Drawing.Size(151, 27);
            this.txt_cnpjTemplo.TabIndex = 32;
            this.txt_cnpjTemplo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo.ForeColor = System.Drawing.Color.Blue;
            this.txt_codigo.Location = new System.Drawing.Point(93, 32);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(203, 26);
            this.txt_codigo.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "CODIGO:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_DataFund);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_BairroCong);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_CidadeCong);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_num2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_RuaCong);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Lv_ListaCongregacoes);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.txt_CapMediCong);
            this.groupBox3.Controls.Add(this.txt_NumMemCong);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_dirigente);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(316, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 306);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS CONGREGACIONAIS:";
            // 
            // txt_DataFund
            // 
            this.txt_DataFund.BackColor = System.Drawing.SystemColors.Info;
            this.txt_DataFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataFund.ForeColor = System.Drawing.Color.Blue;
            this.txt_DataFund.Location = new System.Drawing.Point(375, 267);
            this.txt_DataFund.Mask = "00/00/0000";
            this.txt_DataFund.Name = "txt_DataFund";
            this.txt_DataFund.Size = new System.Drawing.Size(97, 29);
            this.txt_DataFund.TabIndex = 48;
            this.txt_DataFund.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_DataFund.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "Dta.Fund.";
            // 
            // txt_BairroCong
            // 
            this.txt_BairroCong.BackColor = System.Drawing.SystemColors.Info;
            this.txt_BairroCong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_BairroCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BairroCong.ForeColor = System.Drawing.Color.Blue;
            this.txt_BairroCong.Location = new System.Drawing.Point(62, 271);
            this.txt_BairroCong.Name = "txt_BairroCong";
            this.txt_BairroCong.Size = new System.Drawing.Size(288, 24);
            this.txt_BairroCong.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Bairro:";
            // 
            // txt_CidadeCong
            // 
            this.txt_CidadeCong.BackColor = System.Drawing.SystemColors.Info;
            this.txt_CidadeCong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CidadeCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CidadeCong.ForeColor = System.Drawing.Color.Blue;
            this.txt_CidadeCong.Location = new System.Drawing.Point(64, 232);
            this.txt_CidadeCong.Name = "txt_CidadeCong";
            this.txt_CidadeCong.Size = new System.Drawing.Size(274, 24);
            this.txt_CidadeCong.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Cidade:";
            // 
            // txt_num2
            // 
            this.txt_num2.BackColor = System.Drawing.SystemColors.Info;
            this.txt_num2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num2.ForeColor = System.Drawing.Color.Blue;
            this.txt_num2.Location = new System.Drawing.Point(375, 193);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(106, 24);
            this.txt_num2.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nº:";
            // 
            // txt_RuaCong
            // 
            this.txt_RuaCong.BackColor = System.Drawing.SystemColors.Info;
            this.txt_RuaCong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_RuaCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RuaCong.ForeColor = System.Drawing.Color.Blue;
            this.txt_RuaCong.Location = new System.Drawing.Point(50, 193);
            this.txt_RuaCong.Name = "txt_RuaCong";
            this.txt_RuaCong.Size = new System.Drawing.Size(288, 24);
            this.txt_RuaCong.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Rua:";
            // 
            // Lv_ListaCongregacoes
            // 
            this.Lv_ListaCongregacoes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Lv_ListaCongregacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_ListaCongregacoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.C_Nome});
            this.Lv_ListaCongregacoes.ContextMenuStrip = this.Cms_OpcoesGons;
            this.Lv_ListaCongregacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_ListaCongregacoes.FullRowSelect = true;
            this.Lv_ListaCongregacoes.HideSelection = false;
            this.Lv_ListaCongregacoes.Location = new System.Drawing.Point(6, 22);
            this.Lv_ListaCongregacoes.MultiSelect = false;
            this.Lv_ListaCongregacoes.Name = "Lv_ListaCongregacoes";
            this.Lv_ListaCongregacoes.Size = new System.Drawing.Size(287, 118);
            this.Lv_ListaCongregacoes.TabIndex = 38;
            this.Lv_ListaCongregacoes.UseCompatibleStateImageBehavior = false;
            this.Lv_ListaCongregacoes.View = System.Windows.Forms.View.Details;
            this.Lv_ListaCongregacoes.SelectedIndexChanged += new System.EventHandler(this.Lv_ListaCongregacoes_SelectedIndexChanged);
            this.Lv_ListaCongregacoes.Click += new System.EventHandler(this.Lv_ListaCongregacoes_Click);
            // 
            // codigo
            // 
            this.codigo.Text = "CODIGO";
            this.codigo.Width = 80;
            // 
            // C_Nome
            // 
            this.C_Nome.Text = "NOME";
            this.C_Nome.Width = 200;
            // 
            // Cms_OpcoesGons
            // 
            this.Cms_OpcoesGons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem1,
            this.excluirToolStripMenuItem,
            this.novaToolStripMenuItem,
            this.aTUALIZARLISTAToolStripMenuItem});
            this.Cms_OpcoesGons.Name = "Cms_OpcoesGons";
            this.Cms_OpcoesGons.Size = new System.Drawing.Size(194, 156);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = global::SICM.Properties.Resources.editar;
            this.editarToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(193, 38);
            this.editarToolStripMenuItem1.Text = "1.Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = global::SICM.Properties.Resources.excluir;
            this.excluirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(193, 38);
            this.excluirToolStripMenuItem.Text = "2.Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.Image = global::SICM.Properties.Resources.NOVO;
            this.novaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(193, 38);
            this.novaToolStripMenuItem.Text = "3.Nova";
            this.novaToolStripMenuItem.Click += new System.EventHandler(this.novaToolStripMenuItem_Click);
            // 
            // aTUALIZARLISTAToolStripMenuItem
            // 
            this.aTUALIZARLISTAToolStripMenuItem.Image = global::SICM.Properties.Resources.atualizar;
            this.aTUALIZARLISTAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aTUALIZARLISTAToolStripMenuItem.Name = "aTUALIZARLISTAToolStripMenuItem";
            this.aTUALIZARLISTAToolStripMenuItem.Size = new System.Drawing.Size(193, 38);
            this.aTUALIZARLISTAToolStripMenuItem.Text = "4. ATUALIZAR LISTA";
            this.aTUALIZARLISTAToolStripMenuItem.Click += new System.EventHandler(this.aTUALIZARLISTAToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::SICM.Properties.Resources.real;
            this.pictureBox2.Location = new System.Drawing.Point(451, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 38);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // txt_CapMediCong
            // 
            this.txt_CapMediCong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_CapMediCong.BackColor = System.Drawing.SystemColors.Info;
            this.txt_CapMediCong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CapMediCong.Enabled = false;
            this.txt_CapMediCong.ForeColor = System.Drawing.Color.Blue;
            this.txt_CapMediCong.Location = new System.Drawing.Point(299, 102);
            this.txt_CapMediCong.Name = "txt_CapMediCong";
            this.txt_CapMediCong.Size = new System.Drawing.Size(146, 23);
            this.txt_CapMediCong.TabIndex = 36;
            // 
            // txt_NumMemCong
            // 
            this.txt_NumMemCong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_NumMemCong.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NumMemCong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NumMemCong.Enabled = false;
            this.txt_NumMemCong.ForeColor = System.Drawing.Color.Blue;
            this.txt_NumMemCong.Location = new System.Drawing.Point(302, 42);
            this.txt_NumMemCong.Name = "txt_NumMemCong";
            this.txt_NumMemCong.Size = new System.Drawing.Size(173, 23);
            this.txt_NumMemCong.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Capital Médio:";
            // 
            // txt_dirigente
            // 
            this.txt_dirigente.BackColor = System.Drawing.SystemColors.Info;
            this.txt_dirigente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dirigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dirigente.ForeColor = System.Drawing.Color.Blue;
            this.txt_dirigente.Location = new System.Drawing.Point(75, 155);
            this.txt_dirigente.Name = "txt_dirigente";
            this.txt_dirigente.Size = new System.Drawing.Size(354, 24);
            this.txt_dirigente.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nº Membros:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Dirigente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "CNPJ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::SICM.Properties.Resources.real;
            this.pictureBox1.Location = new System.Drawing.Point(115, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txt_CapMedio
            // 
            this.txt_CapMedio.BackColor = System.Drawing.SystemColors.Info;
            this.txt_CapMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CapMedio.Enabled = false;
            this.txt_CapMedio.ForeColor = System.Drawing.Color.Blue;
            this.txt_CapMedio.Location = new System.Drawing.Point(156, 240);
            this.txt_CapMedio.Name = "txt_CapMedio";
            this.txt_CapMedio.Size = new System.Drawing.Size(133, 26);
            this.txt_CapMedio.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Capital Médio:";
            // 
            // txt_NumCong
            // 
            this.txt_NumCong.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NumCong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NumCong.Enabled = false;
            this.txt_NumCong.ForeColor = System.Drawing.Color.Blue;
            this.txt_NumCong.Location = new System.Drawing.Point(169, 196);
            this.txt_NumCong.Name = "txt_NumCong";
            this.txt_NumCong.Size = new System.Drawing.Size(128, 26);
            this.txt_NumCong.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(9, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nº de Congregações:";
            // 
            // txt_NumDepart
            // 
            this.txt_NumDepart.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NumDepart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NumDepart.Enabled = false;
            this.txt_NumDepart.ForeColor = System.Drawing.Color.Blue;
            this.txt_NumDepart.Location = new System.Drawing.Point(182, 154);
            this.txt_NumDepart.Name = "txt_NumDepart";
            this.txt_NumDepart.Size = new System.Drawing.Size(128, 26);
            this.txt_NumDepart.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nº de Departamentos:";
            // 
            // txt_NumMembros
            // 
            this.txt_NumMembros.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NumMembros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NumMembros.Enabled = false;
            this.txt_NumMembros.ForeColor = System.Drawing.Color.Blue;
            this.txt_NumMembros.Location = new System.Drawing.Point(115, 115);
            this.txt_NumMembros.Name = "txt_NumMembros";
            this.txt_NumMembros.Size = new System.Drawing.Size(156, 26);
            this.txt_NumMembros.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Membros:";
            // 
            // FrmGerenteIgrejas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerenteIgrejas";
            this.Text = "FrmGerenteIgrejas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaTemplos)).EndInit();
            this.Cms_OpcoesTabIgreja.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Cms_OpcoesGons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ContextMenuStrip Cms_OpcoesTabIgreja;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERINFORMAÇÕESToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgv_ListaTemplos;
        public System.Windows.Forms.TextBox txt_NumMembros;
        public System.Windows.Forms.TextBox txt_NumCong;
        public System.Windows.Forms.TextBox txt_CapMedio;
        public System.Windows.Forms.TextBox txt_NumDepart;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txt_BairroCong;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txt_CidadeCong;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_RuaCong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txt_CapMediCong;
        public System.Windows.Forms.TextBox txt_NumMemCong;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_dirigente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txt_codigo;
        public System.Windows.Forms.ListView Lv_ListaCongregacoes;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader C_Nome;
        public System.Windows.Forms.MaskedTextBox txt_cnpjTemplo;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox txt_DataFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtaFund;
        public System.Windows.Forms.ContextMenuStrip Cms_OpcoesGons;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTUALIZARTABELAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTUALIZARLISTAToolStripMenuItem;
    }
}