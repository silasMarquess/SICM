namespace SICM.SubForms
{
    partial class FrmDizimos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rb_Congregacao = new System.Windows.Forms.CheckBox();
            this.Cb_ListaMeses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_Anos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_atualizarTabela = new System.Windows.Forms.Button();
            this.Cb_ListaCongregacao = new System.Windows.Forms.ComboBox();
            this.Cb_ListaTemplos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Dgv_ListaDizimistas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exlcuir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.lb_Media = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_NumeroDizimo = new System.Windows.Forms.Label();
            this.btn_PrintReport = new System.Windows.Forms.Button();
            this.labe2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_tipoDizimo = new System.Windows.Forms.ComboBox();
            this.txt_PesquisarNaTabelaForNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gb_CadDizimo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descricaoDizimo = new System.Windows.Forms.TextBox();
            this.Rb_Cereais = new System.Windows.Forms.RadioButton();
            this.Rb_Monetario = new System.Windows.Forms.RadioButton();
            this.NuP_ValorDizimo = new System.Windows.Forms.NumericUpDown();
            this.txt_NomeMembro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CodigoMembro = new System.Windows.Forms.TextBox();
            this.Rb_DizExterno = new System.Windows.Forms.RadioButton();
            this.Rb_MemCad = new System.Windows.Forms.RadioButton();
            this.txt_Iddizimo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_SalvarAlterações = new System.Windows.Forms.Button();
            this.LinkLancarMembro = new System.Windows.Forms.LinkLabel();
            this.txt_PesquisaNome = new System.Windows.Forms.TextBox();
            this.Lv_ListaMembroFiltrados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_SalarioEstimado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DataHoje = new System.Windows.Forms.TextBox();
            this.btn_LançarDizimos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaDizimistas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Gb_CadDizimo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuP_ValorDizimo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Gb_CadDizimo, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.Rb_Congregacao);
            this.panel1.Controls.Add(this.Cb_ListaMeses);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cb_Anos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_atualizarTabela);
            this.panel1.Controls.Add(this.Cb_ListaCongregacao);
            this.panel1.Controls.Add(this.Cb_ListaTemplos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 61);
            this.panel1.TabIndex = 0;
            // 
            // Rb_Congregacao
            // 
            this.Rb_Congregacao.AutoSize = true;
            this.Rb_Congregacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Congregacao.Location = new System.Drawing.Point(338, 4);
            this.Rb_Congregacao.Name = "Rb_Congregacao";
            this.Rb_Congregacao.Size = new System.Drawing.Size(139, 23);
            this.Rb_Congregacao.TabIndex = 24;
            this.Rb_Congregacao.Text = "CONGREGAÇÃO:";
            this.Rb_Congregacao.UseVisualStyleBackColor = true;
            this.Rb_Congregacao.CheckedChanged += new System.EventHandler(this.Rb_Congregacao_CheckedChanged_1);
            // 
            // Cb_ListaMeses
            // 
            this.Cb_ListaMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ListaMeses.ForeColor = System.Drawing.Color.Blue;
            this.Cb_ListaMeses.FormattingEnabled = true;
            this.Cb_ListaMeses.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO ",
            "DEZEMBRO"});
            this.Cb_ListaMeses.Location = new System.Drawing.Point(739, 26);
            this.Cb_ListaMeses.Name = "Cb_ListaMeses";
            this.Cb_ListaMeses.Size = new System.Drawing.Size(219, 28);
            this.Cb_ListaMeses.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(920, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "MÊS:";
            // 
            // Cb_Anos
            // 
            this.Cb_Anos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Anos.ForeColor = System.Drawing.Color.Blue;
            this.Cb_Anos.FormattingEnabled = true;
            this.Cb_Anos.Location = new System.Drawing.Point(606, 26);
            this.Cb_Anos.MaxDropDownItems = 100;
            this.Cb_Anos.Name = "Cb_Anos";
            this.Cb_Anos.Size = new System.Drawing.Size(128, 28);
            this.Cb_Anos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ANO:";
            // 
            // btn_atualizarTabela
            // 
            this.btn_atualizarTabela.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizarTabela.FlatAppearance.BorderSize = 0;
            this.btn_atualizarTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizarTabela.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizarTabela.ForeColor = System.Drawing.Color.White;
            this.btn_atualizarTabela.Image = global::SICM.Properties.Resources.atualizar;
            this.btn_atualizarTabela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atualizarTabela.Location = new System.Drawing.Point(975, 18);
            this.btn_atualizarTabela.Name = "btn_atualizarTabela";
            this.btn_atualizarTabela.Size = new System.Drawing.Size(120, 34);
            this.btn_atualizarTabela.TabIndex = 23;
            this.btn_atualizarTabela.Text = "ATUALIZAR:";
            this.btn_atualizarTabela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizarTabela.UseVisualStyleBackColor = false;
            this.btn_atualizarTabela.Click += new System.EventHandler(this.btn_atualizarTabela_Click);
            // 
            // Cb_ListaCongregacao
            // 
            this.Cb_ListaCongregacao.Enabled = false;
            this.Cb_ListaCongregacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ListaCongregacao.ForeColor = System.Drawing.Color.Blue;
            this.Cb_ListaCongregacao.FormattingEnabled = true;
            this.Cb_ListaCongregacao.Location = new System.Drawing.Point(338, 26);
            this.Cb_ListaCongregacao.Name = "Cb_ListaCongregacao";
            this.Cb_ListaCongregacao.Size = new System.Drawing.Size(265, 28);
            this.Cb_ListaCongregacao.TabIndex = 3;
            // 
            // Cb_ListaTemplos
            // 
            this.Cb_ListaTemplos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ListaTemplos.ForeColor = System.Drawing.Color.Blue;
            this.Cb_ListaTemplos.FormattingEnabled = true;
            this.Cb_ListaTemplos.Location = new System.Drawing.Point(7, 26);
            this.Cb_ListaTemplos.Name = "Cb_ListaTemplos";
            this.Cb_ListaTemplos.Size = new System.Drawing.Size(325, 28);
            this.Cb_ListaTemplos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEMPLO SEDE:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Dgv_ListaDizimistas, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1364, 244);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Dgv_ListaDizimistas
            // 
            this.Dgv_ListaDizimistas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_ListaDizimistas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ListaDizimistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_ListaDizimistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListaDizimistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MEMBRO,
            this.DESC,
            this.VALOR,
            this.TIPO});
            this.Dgv_ListaDizimistas.EnableHeadersVisualStyles = false;
            this.Dgv_ListaDizimistas.Location = new System.Drawing.Point(3, 42);
            this.Dgv_ListaDizimistas.MultiSelect = false;
            this.Dgv_ListaDizimistas.Name = "Dgv_ListaDizimistas";
            this.Dgv_ListaDizimistas.ReadOnly = true;
            this.Dgv_ListaDizimistas.RowHeadersVisible = false;
            this.Dgv_ListaDizimistas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_ListaDizimistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ListaDizimistas.Size = new System.Drawing.Size(1352, 125);
            this.Dgv_ListaDizimistas.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // MEMBRO
            // 
            this.MEMBRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEMBRO.HeaderText = "MEMBRO";
            this.MEMBRO.Name = "MEMBRO";
            this.MEMBRO.ReadOnly = true;
            // 
            // DESC
            // 
            this.DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DESC.HeaderText = "DESCRIÇÃO";
            this.DESC.Name = "DESC";
            this.DESC.ReadOnly = true;
            this.DESC.Width = 340;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VALOR.HeaderText = "VALOR R$";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 130;
            // 
            // TIPO
            // 
            this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 120;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_exlcuir);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Controls.Add(this.lb_Media);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lb_NumeroDizimo);
            this.panel2.Controls.Add(this.btn_PrintReport);
            this.panel2.Controls.Add(this.labe2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 68);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::SICM.Properties.Resources.real;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(666, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 51);
            this.button3.TabIndex = 34;
            this.button3.Text = "/P >CAIXA";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::SICM.Properties.Resources.REPORTS;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(778, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 51);
            this.button2.TabIndex = 33;
            this.button2.Text = "PRESTAÇÃO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::SICM.Properties.Resources.NOVO;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(926, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "NOVO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_exlcuir
            // 
            this.btn_exlcuir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_exlcuir.BackColor = System.Drawing.Color.Transparent;
            this.btn_exlcuir.FlatAppearance.BorderSize = 0;
            this.btn_exlcuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exlcuir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exlcuir.ForeColor = System.Drawing.Color.White;
            this.btn_exlcuir.Image = global::SICM.Properties.Resources.excluir;
            this.btn_exlcuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exlcuir.Location = new System.Drawing.Point(1020, 16);
            this.btn_exlcuir.Name = "btn_exlcuir";
            this.btn_exlcuir.Size = new System.Drawing.Size(102, 34);
            this.btn_exlcuir.TabIndex = 31;
            this.btn_exlcuir.Text = "DELETAR";
            this.btn_exlcuir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exlcuir.UseVisualStyleBackColor = false;
            this.btn_exlcuir.Click += new System.EventHandler(this.btn_exlcuir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Image = global::SICM.Properties.Resources.editarBtn;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(1127, 17);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(98, 34);
            this.btn_Editar.TabIndex = 30;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Media
            // 
            this.lb_Media.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Media.AutoSize = true;
            this.lb_Media.BackColor = System.Drawing.Color.Yellow;
            this.lb_Media.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Media.ForeColor = System.Drawing.Color.Black;
            this.lb_Media.Location = new System.Drawing.Point(285, 4);
            this.lb_Media.Name = "lb_Media";
            this.lb_Media.Size = new System.Drawing.Size(78, 25);
            this.lb_Media.TabIndex = 29;
            this.lb_Media.Text = "0,00 R$";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(198, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "MÉDIA R$:";
            // 
            // lb_total
            // 
            this.lb_total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Yellow;
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.Black;
            this.lb_total.Location = new System.Drawing.Point(93, 35);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(78, 25);
            this.lb_total.TabIndex = 27;
            this.lb_total.Text = "0,00 R$";
            this.lb_total.Click += new System.EventHandler(this.lb_total_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "TOTAL R$:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lb_NumeroDizimo
            // 
            this.lb_NumeroDizimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_NumeroDizimo.AutoSize = true;
            this.lb_NumeroDizimo.BackColor = System.Drawing.Color.Yellow;
            this.lb_NumeroDizimo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumeroDizimo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_NumeroDizimo.Location = new System.Drawing.Point(35, 7);
            this.lb_NumeroDizimo.Name = "lb_NumeroDizimo";
            this.lb_NumeroDizimo.Size = new System.Drawing.Size(139, 20);
            this.lb_NumeroDizimo.TabIndex = 25;
            this.lb_NumeroDizimo.Text = "Nº DE DIZIMISTAS";
            // 
            // btn_PrintReport
            // 
            this.btn_PrintReport.BackColor = System.Drawing.Color.Transparent;
            this.btn_PrintReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_PrintReport.FlatAppearance.BorderSize = 0;
            this.btn_PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintReport.ForeColor = System.Drawing.Color.White;
            this.btn_PrintReport.Image = global::SICM.Properties.Resources.PrintFicha;
            this.btn_PrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrintReport.Location = new System.Drawing.Point(1232, 0);
            this.btn_PrintReport.Name = "btn_PrintReport";
            this.btn_PrintReport.Size = new System.Drawing.Size(126, 68);
            this.btn_PrintReport.TabIndex = 24;
            this.btn_PrintReport.Text = "REPORT PDF";
            this.btn_PrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PrintReport.UseVisualStyleBackColor = false;
            this.btn_PrintReport.Click += new System.EventHandler(this.btn_PrintReport_Click);
            // 
            // labe2
            // 
            this.labe2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labe2.AutoSize = true;
            this.labe2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe2.ForeColor = System.Drawing.Color.Azure;
            this.labe2.Location = new System.Drawing.Point(5, 7);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(32, 20);
            this.labe2.TabIndex = 1;
            this.labe2.Text = "Nº:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Cb_tipoDizimo);
            this.panel3.Controls.Add(this.txt_PesquisarNaTabelaForNome);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 39);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(971, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "FILTRA POR TIPO:";
            // 
            // Cb_tipoDizimo
            // 
            this.Cb_tipoDizimo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_tipoDizimo.ForeColor = System.Drawing.Color.Blue;
            this.Cb_tipoDizimo.FormattingEnabled = true;
            this.Cb_tipoDizimo.Items.AddRange(new object[] {
            "MONETARIO",
            "CEREAIS",
            "TODOS"});
            this.Cb_tipoDizimo.Location = new System.Drawing.Point(1115, 9);
            this.Cb_tipoDizimo.Name = "Cb_tipoDizimo";
            this.Cb_tipoDizimo.Size = new System.Drawing.Size(240, 25);
            this.Cb_tipoDizimo.TabIndex = 15;
            this.Cb_tipoDizimo.SelectionChangeCommitted += new System.EventHandler(this.Cb_tipoDizimo_SelectionChangeCommitted);
            // 
            // txt_PesquisarNaTabelaForNome
            // 
            this.txt_PesquisarNaTabelaForNome.BackColor = System.Drawing.SystemColors.Info;
            this.txt_PesquisarNaTabelaForNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisarNaTabelaForNome.ForeColor = System.Drawing.Color.Red;
            this.txt_PesquisarNaTabelaForNome.Location = new System.Drawing.Point(244, 5);
            this.txt_PesquisarNaTabelaForNome.Name = "txt_PesquisarNaTabelaForNome";
            this.txt_PesquisarNaTabelaForNome.Size = new System.Drawing.Size(359, 29);
            this.txt_PesquisarNaTabelaForNome.TabIndex = 14;
            this.txt_PesquisarNaTabelaForNome.Text = "Pesquisar na tabela Membro pelo Nome:";
            this.txt_PesquisarNaTabelaForNome.TextChanged += new System.EventHandler(this.txt_PesquisarNaTabelaForNome_TextChanged);
            this.txt_PesquisarNaTabelaForNome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_PesquisarNaTabelaForNome_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "LISTA DE DIZIMISTAS - TOTAL:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Gb_CadDizimo
            // 
            this.Gb_CadDizimo.Controls.Add(this.groupBox1);
            this.Gb_CadDizimo.Controls.Add(this.txt_NomeMembro);
            this.Gb_CadDizimo.Controls.Add(this.label9);
            this.Gb_CadDizimo.Controls.Add(this.txt_CodigoMembro);
            this.Gb_CadDizimo.Controls.Add(this.Rb_DizExterno);
            this.Gb_CadDizimo.Controls.Add(this.Rb_MemCad);
            this.Gb_CadDizimo.Controls.Add(this.txt_Iddizimo);
            this.Gb_CadDizimo.Controls.Add(this.label10);
            this.Gb_CadDizimo.Controls.Add(this.btn_SalvarAlterações);
            this.Gb_CadDizimo.Controls.Add(this.LinkLancarMembro);
            this.Gb_CadDizimo.Controls.Add(this.txt_PesquisaNome);
            this.Gb_CadDizimo.Controls.Add(this.Lv_ListaMembroFiltrados);
            this.Gb_CadDizimo.Controls.Add(this.txt_SalarioEstimado);
            this.Gb_CadDizimo.Controls.Add(this.label4);
            this.Gb_CadDizimo.Controls.Add(this.txt_DataHoje);
            this.Gb_CadDizimo.Controls.Add(this.btn_LançarDizimos);
            this.Gb_CadDizimo.Controls.Add(this.label7);
            this.Gb_CadDizimo.Controls.Add(this.label6);
            this.Gb_CadDizimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gb_CadDizimo.Enabled = false;
            this.Gb_CadDizimo.Location = new System.Drawing.Point(3, 320);
            this.Gb_CadDizimo.Name = "Gb_CadDizimo";
            this.Gb_CadDizimo.Size = new System.Drawing.Size(1364, 297);
            this.Gb_CadDizimo.TabIndex = 2;
            this.Gb_CadDizimo.TabStop = false;
            this.Gb_CadDizimo.Text = "NOVOS DIZIMISTA DO MÊS:";
            this.Gb_CadDizimo.Enter += new System.EventHandler(this.Gb_CadDizimo_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_descricaoDizimo);
            this.groupBox1.Controls.Add(this.Rb_Cereais);
            this.groupBox1.Controls.Add(this.Rb_Monetario);
            this.groupBox1.Controls.Add(this.NuP_ValorDizimo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(603, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 97);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE DIZIMO";
            // 
            // txt_descricaoDizimo
            // 
            this.txt_descricaoDizimo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_descricaoDizimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricaoDizimo.Enabled = false;
            this.txt_descricaoDizimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricaoDizimo.ForeColor = System.Drawing.Color.Blue;
            this.txt_descricaoDizimo.Location = new System.Drawing.Point(196, 55);
            this.txt_descricaoDizimo.Multiline = true;
            this.txt_descricaoDizimo.Name = "txt_descricaoDizimo";
            this.txt_descricaoDizimo.Size = new System.Drawing.Size(350, 28);
            this.txt_descricaoDizimo.TabIndex = 36;
            // 
            // Rb_Cereais
            // 
            this.Rb_Cereais.AutoSize = true;
            this.Rb_Cereais.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Cereais.Location = new System.Drawing.Point(196, 25);
            this.Rb_Cereais.Name = "Rb_Cereais";
            this.Rb_Cereais.Size = new System.Drawing.Size(160, 24);
            this.Rb_Cereais.TabIndex = 34;
            this.Rb_Cereais.Text = "Cereais (Descrição)";
            this.Rb_Cereais.UseVisualStyleBackColor = true;
            this.Rb_Cereais.CheckedChanged += new System.EventHandler(this.Rb_Cereais_CheckedChanged);
            // 
            // Rb_Monetario
            // 
            this.Rb_Monetario.AutoSize = true;
            this.Rb_Monetario.Checked = true;
            this.Rb_Monetario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Monetario.Location = new System.Drawing.Point(8, 24);
            this.Rb_Monetario.Name = "Rb_Monetario";
            this.Rb_Monetario.Size = new System.Drawing.Size(92, 24);
            this.Rb_Monetario.TabIndex = 33;
            this.Rb_Monetario.TabStop = true;
            this.Rb_Monetario.Text = "Montário";
            this.Rb_Monetario.UseVisualStyleBackColor = true;
            this.Rb_Monetario.CheckedChanged += new System.EventHandler(this.Rb_Monetario_CheckedChanged);
            // 
            // NuP_ValorDizimo
            // 
            this.NuP_ValorDizimo.BackColor = System.Drawing.SystemColors.Info;
            this.NuP_ValorDizimo.DecimalPlaces = 2;
            this.NuP_ValorDizimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuP_ValorDizimo.ForeColor = System.Drawing.Color.Blue;
            this.NuP_ValorDizimo.Location = new System.Drawing.Point(8, 54);
            this.NuP_ValorDizimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NuP_ValorDizimo.Name = "NuP_ValorDizimo";
            this.NuP_ValorDizimo.Size = new System.Drawing.Size(174, 29);
            this.NuP_ValorDizimo.TabIndex = 16;
            this.NuP_ValorDizimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NuP_ValorDizimo.ValueChanged += new System.EventHandler(this.NuP_ValorDizimo_ValueChanged);
            // 
            // txt_NomeMembro
            // 
            this.txt_NomeMembro.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NomeMembro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeMembro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeMembro.ForeColor = System.Drawing.Color.Blue;
            this.txt_NomeMembro.Location = new System.Drawing.Point(683, 119);
            this.txt_NomeMembro.Multiline = true;
            this.txt_NomeMembro.Name = "txt_NomeMembro";
            this.txt_NomeMembro.Size = new System.Drawing.Size(472, 28);
            this.txt_NomeMembro.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1161, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "CODIGO";
            this.label9.Visible = false;
            // 
            // txt_CodigoMembro
            // 
            this.txt_CodigoMembro.BackColor = System.Drawing.SystemColors.Info;
            this.txt_CodigoMembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoMembro.Location = new System.Drawing.Point(1161, 123);
            this.txt_CodigoMembro.Name = "txt_CodigoMembro";
            this.txt_CodigoMembro.Size = new System.Drawing.Size(85, 26);
            this.txt_CodigoMembro.TabIndex = 33;
            this.txt_CodigoMembro.Visible = false;
            // 
            // Rb_DizExterno
            // 
            this.Rb_DizExterno.AutoSize = true;
            this.Rb_DizExterno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_DizExterno.Location = new System.Drawing.Point(183, 25);
            this.Rb_DizExterno.Name = "Rb_DizExterno";
            this.Rb_DizExterno.Size = new System.Drawing.Size(150, 24);
            this.Rb_DizExterno.TabIndex = 32;
            this.Rb_DizExterno.Text = "Dizimista Externo";
            this.Rb_DizExterno.UseVisualStyleBackColor = true;
            this.Rb_DizExterno.CheckedChanged += new System.EventHandler(this.Rb_DizExterno_CheckedChanged);
            // 
            // Rb_MemCad
            // 
            this.Rb_MemCad.AutoSize = true;
            this.Rb_MemCad.Checked = true;
            this.Rb_MemCad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_MemCad.Location = new System.Drawing.Point(7, 25);
            this.Rb_MemCad.Name = "Rb_MemCad";
            this.Rb_MemCad.Size = new System.Drawing.Size(170, 24);
            this.Rb_MemCad.TabIndex = 31;
            this.Rb_MemCad.TabStop = true;
            this.Rb_MemCad.Text = "Membro Cadastrado";
            this.Rb_MemCad.UseVisualStyleBackColor = true;
            this.Rb_MemCad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_Iddizimo
            // 
            this.txt_Iddizimo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Iddizimo.Enabled = false;
            this.txt_Iddizimo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Iddizimo.ForeColor = System.Drawing.Color.Blue;
            this.txt_Iddizimo.Location = new System.Drawing.Point(1252, 123);
            this.txt_Iddizimo.Multiline = true;
            this.txt_Iddizimo.Name = "txt_Iddizimo";
            this.txt_Iddizimo.ReadOnly = true;
            this.txt_Iddizimo.Size = new System.Drawing.Size(57, 26);
            this.txt_Iddizimo.TabIndex = 30;
            this.txt_Iddizimo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1248, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "ID:";
            this.label10.Visible = false;
            // 
            // btn_SalvarAlterações
            // 
            this.btn_SalvarAlterações.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SalvarAlterações.Enabled = false;
            this.btn_SalvarAlterações.FlatAppearance.BorderSize = 0;
            this.btn_SalvarAlterações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarAlterações.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarAlterações.ForeColor = System.Drawing.Color.White;
            this.btn_SalvarAlterações.Image = global::SICM.Properties.Resources.editar;
            this.btn_SalvarAlterações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarAlterações.Location = new System.Drawing.Point(983, 227);
            this.btn_SalvarAlterações.Name = "btn_SalvarAlterações";
            this.btn_SalvarAlterações.Size = new System.Drawing.Size(172, 49);
            this.btn_SalvarAlterações.TabIndex = 28;
            this.btn_SalvarAlterações.Text = "SALVAR ALTERAÇÕES";
            this.btn_SalvarAlterações.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SalvarAlterações.UseVisualStyleBackColor = false;
            this.btn_SalvarAlterações.Click += new System.EventHandler(this.btn_SalvarAlterações_Click);
            // 
            // LinkLancarMembro
            // 
            this.LinkLancarMembro.AutoSize = true;
            this.LinkLancarMembro.BackColor = System.Drawing.Color.White;
            this.LinkLancarMembro.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLancarMembro.LinkColor = System.Drawing.Color.Blue;
            this.LinkLancarMembro.Location = new System.Drawing.Point(392, 62);
            this.LinkLancarMembro.Name = "LinkLancarMembro";
            this.LinkLancarMembro.Size = new System.Drawing.Size(181, 17);
            this.LinkLancarMembro.TabIndex = 27;
            this.LinkLancarMembro.TabStop = true;
            this.LinkLancarMembro.Text = "Lançar Selecionado>>";
            this.LinkLancarMembro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_PesquisaNome
            // 
            this.txt_PesquisaNome.BackColor = System.Drawing.SystemColors.Info;
            this.txt_PesquisaNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaNome.ForeColor = System.Drawing.Color.Blue;
            this.txt_PesquisaNome.Location = new System.Drawing.Point(8, 56);
            this.txt_PesquisaNome.Name = "txt_PesquisaNome";
            this.txt_PesquisaNome.Size = new System.Drawing.Size(378, 29);
            this.txt_PesquisaNome.TabIndex = 13;
            this.txt_PesquisaNome.Text = "Pesquisar Membro pelo Nome:";
            this.txt_PesquisaNome.TextChanged += new System.EventHandler(this.txt_PesquisaNome_TextChanged);
            this.txt_PesquisaNome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_PesquisaNome_MouseDown);
            // 
            // Lv_ListaMembroFiltrados
            // 
            this.Lv_ListaMembroFiltrados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Lv_ListaMembroFiltrados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_ListaMembroFiltrados.FullRowSelect = true;
            this.Lv_ListaMembroFiltrados.HideSelection = false;
            this.Lv_ListaMembroFiltrados.Location = new System.Drawing.Point(6, 95);
            this.Lv_ListaMembroFiltrados.Name = "Lv_ListaMembroFiltrados";
            this.Lv_ListaMembroFiltrados.Size = new System.Drawing.Size(577, 181);
            this.Lv_ListaMembroFiltrados.TabIndex = 7;
            this.Lv_ListaMembroFiltrados.UseCompatibleStateImageBehavior = false;
            this.Lv_ListaMembroFiltrados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CODIGO:";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOME";
            this.columnHeader2.Width = 477;
            // 
            // txt_SalarioEstimado
            // 
            this.txt_SalarioEstimado.BackColor = System.Drawing.SystemColors.Info;
            this.txt_SalarioEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalarioEstimado.ForeColor = System.Drawing.Color.Red;
            this.txt_SalarioEstimado.Location = new System.Drawing.Point(754, 179);
            this.txt_SalarioEstimado.Name = "txt_SalarioEstimado";
            this.txt_SalarioEstimado.ReadOnly = true;
            this.txt_SalarioEstimado.Size = new System.Drawing.Size(166, 27);
            this.txt_SalarioEstimado.TabIndex = 24;
            this.txt_SalarioEstimado.Text = "0,00";
            this.txt_SalarioEstimado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(603, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "DATA:";
            // 
            // txt_DataHoje
            // 
            this.txt_DataHoje.BackColor = System.Drawing.SystemColors.Info;
            this.txt_DataHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataHoje.ForeColor = System.Drawing.Color.Blue;
            this.txt_DataHoje.Location = new System.Drawing.Point(606, 179);
            this.txt_DataHoje.Name = "txt_DataHoje";
            this.txt_DataHoje.ReadOnly = true;
            this.txt_DataHoje.Size = new System.Drawing.Size(131, 27);
            this.txt_DataHoje.TabIndex = 14;
            this.txt_DataHoje.Text = "HOJE";
            // 
            // btn_LançarDizimos
            // 
            this.btn_LançarDizimos.BackColor = System.Drawing.Color.DimGray;
            this.btn_LançarDizimos.Enabled = false;
            this.btn_LançarDizimos.FlatAppearance.BorderSize = 0;
            this.btn_LançarDizimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LançarDizimos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LançarDizimos.ForeColor = System.Drawing.Color.White;
            this.btn_LançarDizimos.Image = global::SICM.Properties.Resources.salvar;
            this.btn_LançarDizimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LançarDizimos.Location = new System.Drawing.Point(606, 231);
            this.btn_LançarDizimos.Name = "btn_LançarDizimos";
            this.btn_LançarDizimos.Size = new System.Drawing.Size(178, 45);
            this.btn_LançarDizimos.TabIndex = 22;
            this.btn_LançarDizimos.Text = "LANÇAR DÍZIMO R$";
            this.btn_LançarDizimos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LançarDizimos.UseVisualStyleBackColor = false;
            this.btn_LançarDizimos.Click += new System.EventHandler(this.btn_LançarDizimos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(751, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "RENDIMENTO ESTIMADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "MEMBRO:";
            // 
            // FrmDizimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1370, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDizimos";
            this.Text = "FrmDizimos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaDizimistas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Gb_CadDizimo.ResumeLayout(false);
            this.Gb_CadDizimo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuP_ValorDizimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox Cb_ListaTemplos;
        public System.Windows.Forms.ComboBox Cb_ListaMeses;
        public System.Windows.Forms.TextBox txt_PesquisaNome;
        public System.Windows.Forms.TextBox txt_SalarioEstimado;
        public System.Windows.Forms.Button btn_atualizarTabela;
        public System.Windows.Forms.Button btn_LançarDizimos;
        public System.Windows.Forms.DataGridView Dgv_ListaDizimistas;
        public System.Windows.Forms.Button btn_PrintReport;
        public System.Windows.Forms.Label labe2;
        public System.Windows.Forms.ComboBox Cb_ListaCongregacao;
        public System.Windows.Forms.ComboBox Cb_Anos;
        public System.Windows.Forms.ListView Lv_ListaMembroFiltrados;
        public System.Windows.Forms.Label lb_Media;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lb_total;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lb_NumeroDizimo;
        private System.Windows.Forms.GroupBox Gb_CadDizimo;
        public System.Windows.Forms.Button btn_Editar;
        public System.Windows.Forms.CheckBox Rb_Congregacao;
        public System.Windows.Forms.NumericUpDown NuP_ValorDizimo;
        public System.Windows.Forms.TextBox txt_DataHoje;
        public System.Windows.Forms.Button btn_exlcuir;
        public System.Windows.Forms.Button btn_SalvarAlterações;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_PesquisarNaTabelaForNome;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.RadioButton Rb_MemCad;
        public System.Windows.Forms.RadioButton Rb_DizExterno;
        public System.Windows.Forms.LinkLabel LinkLancarMembro;
        public System.Windows.Forms.TextBox txt_Iddizimo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_CodigoMembro;
        public System.Windows.Forms.TextBox txt_NomeMembro;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton Rb_Cereais;
        public System.Windows.Forms.RadioButton Rb_Monetario;
        public System.Windows.Forms.TextBox txt_descricaoDizimo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Cb_tipoDizimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}