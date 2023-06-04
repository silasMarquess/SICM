namespace SICM.SubForms
{
    partial class FrmCadCaixas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Rb_IgrejaSel = new System.Windows.Forms.RadioButton();
            this.CB_ListaSede = new System.Windows.Forms.ComboBox();
            this.Cbb_ListaCongregacao = new System.Windows.Forms.ComboBox();
            this.Gb_CaixaIgreja = new System.Windows.Forms.GroupBox();
            this.Rb_ListaCongregacao = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gb_CaixaDepartamento = new System.Windows.Forms.GroupBox();
            this.Cbox_ListaCongCaixaDepart = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_Departamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_ListaSedeDepart = new System.Windows.Forms.ComboBox();
            this.CB_ListaCoongDepart = new System.Windows.Forms.ComboBox();
            this.Rb_Departamento = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Rb_OutroTipo = new System.Windows.Forms.RadioButton();
            this.txt_NomeCaixa = new System.Windows.Forms.TextBox();
            this.btn_CadCaixa = new System.Windows.Forms.Button();
            this.Nup_SaldoAtual = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Gb_CaixaIgreja.SuspendLayout();
            this.Gb_CaixaDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_SaldoAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO ENTIDADE DE VINCULAÇÃO:";
            // 
            // Rb_IgrejaSel
            // 
            this.Rb_IgrejaSel.AutoSize = true;
            this.Rb_IgrejaSel.Location = new System.Drawing.Point(297, 18);
            this.Rb_IgrejaSel.Name = "Rb_IgrejaSel";
            this.Rb_IgrejaSel.Size = new System.Drawing.Size(79, 21);
            this.Rb_IgrejaSel.TabIndex = 1;
            this.Rb_IgrejaSel.Text = "(IGREJA)";
            this.Rb_IgrejaSel.UseVisualStyleBackColor = true;
            this.Rb_IgrejaSel.CheckedChanged += new System.EventHandler(this.Rb_IgrejaSel_CheckedChanged);
            // 
            // CB_ListaSede
            // 
            this.CB_ListaSede.FormattingEnabled = true;
            this.CB_ListaSede.Location = new System.Drawing.Point(8, 44);
            this.CB_ListaSede.Name = "CB_ListaSede";
            this.CB_ListaSede.Size = new System.Drawing.Size(292, 25);
            this.CB_ListaSede.TabIndex = 5;
            this.CB_ListaSede.SelectionChangeCommitted += new System.EventHandler(this.CB_ListaSede_SelectionChangeCommitted);
            // 
            // Cbb_ListaCongregacao
            // 
            this.Cbb_ListaCongregacao.Enabled = false;
            this.Cbb_ListaCongregacao.FormattingEnabled = true;
            this.Cbb_ListaCongregacao.Location = new System.Drawing.Point(306, 44);
            this.Cbb_ListaCongregacao.Name = "Cbb_ListaCongregacao";
            this.Cbb_ListaCongregacao.Size = new System.Drawing.Size(290, 25);
            this.Cbb_ListaCongregacao.TabIndex = 6;
            this.Cbb_ListaCongregacao.SelectedIndexChanged += new System.EventHandler(this.Cbb_ListaCongregacao_SelectedIndexChanged);
            this.Cbb_ListaCongregacao.SelectionChangeCommitted += new System.EventHandler(this.Cbb_ListaCongregacao_SelectionChangeCommitted);
            // 
            // Gb_CaixaIgreja
            // 
            this.Gb_CaixaIgreja.Controls.Add(this.Rb_ListaCongregacao);
            this.Gb_CaixaIgreja.Controls.Add(this.label2);
            this.Gb_CaixaIgreja.Controls.Add(this.Cbb_ListaCongregacao);
            this.Gb_CaixaIgreja.Controls.Add(this.CB_ListaSede);
            this.Gb_CaixaIgreja.Enabled = false;
            this.Gb_CaixaIgreja.Location = new System.Drawing.Point(42, 49);
            this.Gb_CaixaIgreja.Name = "Gb_CaixaIgreja";
            this.Gb_CaixaIgreja.Size = new System.Drawing.Size(602, 94);
            this.Gb_CaixaIgreja.TabIndex = 7;
            this.Gb_CaixaIgreja.TabStop = false;
            this.Gb_CaixaIgreja.Text = "IGREJA";
            // 
            // Rb_ListaCongregacao
            // 
            this.Rb_ListaCongregacao.AutoSize = true;
            this.Rb_ListaCongregacao.Location = new System.Drawing.Point(306, 17);
            this.Rb_ListaCongregacao.Name = "Rb_ListaCongregacao";
            this.Rb_ListaCongregacao.Size = new System.Drawing.Size(111, 21);
            this.Rb_ListaCongregacao.TabIndex = 10;
            this.Rb_ListaCongregacao.Text = "Congregação:";
            this.Rb_ListaCongregacao.UseVisualStyleBackColor = true;
            this.Rb_ListaCongregacao.CheckedChanged += new System.EventHandler(this.Rb_ListaCongregacao_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEDE:";
            // 
            // Gb_CaixaDepartamento
            // 
            this.Gb_CaixaDepartamento.Controls.Add(this.Cbox_ListaCongCaixaDepart);
            this.Gb_CaixaDepartamento.Controls.Add(this.label4);
            this.Gb_CaixaDepartamento.Controls.Add(this.Cb_Departamento);
            this.Gb_CaixaDepartamento.Controls.Add(this.label3);
            this.Gb_CaixaDepartamento.Controls.Add(this.Cb_ListaSedeDepart);
            this.Gb_CaixaDepartamento.Controls.Add(this.CB_ListaCoongDepart);
            this.Gb_CaixaDepartamento.Location = new System.Drawing.Point(42, 145);
            this.Gb_CaixaDepartamento.Name = "Gb_CaixaDepartamento";
            this.Gb_CaixaDepartamento.Size = new System.Drawing.Size(602, 146);
            this.Gb_CaixaDepartamento.TabIndex = 8;
            this.Gb_CaixaDepartamento.TabStop = false;
            this.Gb_CaixaDepartamento.Text = "DEPARTAMENTO";
            // 
            // Cbox_ListaCongCaixaDepart
            // 
            this.Cbox_ListaCongCaixaDepart.AutoSize = true;
            this.Cbox_ListaCongCaixaDepart.Location = new System.Drawing.Point(320, 18);
            this.Cbox_ListaCongCaixaDepart.Name = "Cbox_ListaCongCaixaDepart";
            this.Cbox_ListaCongCaixaDepart.Size = new System.Drawing.Size(140, 21);
            this.Cbox_ListaCongCaixaDepart.TabIndex = 15;
            this.Cbox_ListaCongCaixaDepart.Text = "Lista Congregação";
            this.Cbox_ListaCongCaixaDepart.UseVisualStyleBackColor = true;
            this.Cbox_ListaCongCaixaDepart.CheckedChanged += new System.EventHandler(this.Cbox_ListaCongCaixaDepart_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome do Departamento:";
            // 
            // Cb_Departamento
            // 
            this.Cb_Departamento.FormattingEnabled = true;
            this.Cb_Departamento.Location = new System.Drawing.Point(8, 99);
            this.Cb_Departamento.Name = "Cb_Departamento";
            this.Cb_Departamento.Size = new System.Drawing.Size(306, 25);
            this.Cb_Departamento.TabIndex = 8;
            this.Cb_Departamento.SelectedIndexChanged += new System.EventHandler(this.Cb_Departamento_SelectedIndexChanged);
            this.Cb_Departamento.SelectionChangeCommitted += new System.EventHandler(this.Cb_Departamento_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "SEDE:";
            // 
            // Cb_ListaSedeDepart
            // 
            this.Cb_ListaSedeDepart.FormattingEnabled = true;
            this.Cb_ListaSedeDepart.Location = new System.Drawing.Point(9, 42);
            this.Cb_ListaSedeDepart.Name = "Cb_ListaSedeDepart";
            this.Cb_ListaSedeDepart.Size = new System.Drawing.Size(305, 25);
            this.Cb_ListaSedeDepart.TabIndex = 10;
            this.Cb_ListaSedeDepart.SelectionChangeCommitted += new System.EventHandler(this.Cb_ListaSedeDepart_SelectionChangeCommitted);
            // 
            // CB_ListaCoongDepart
            // 
            this.CB_ListaCoongDepart.Enabled = false;
            this.CB_ListaCoongDepart.FormattingEnabled = true;
            this.CB_ListaCoongDepart.Location = new System.Drawing.Point(320, 42);
            this.CB_ListaCoongDepart.Name = "CB_ListaCoongDepart";
            this.CB_ListaCoongDepart.Size = new System.Drawing.Size(276, 25);
            this.CB_ListaCoongDepart.TabIndex = 11;
            this.CB_ListaCoongDepart.SelectionChangeCommitted += new System.EventHandler(this.CB_ListaCoongDepart_SelectionChangeCommitted);
            // 
            // Rb_Departamento
            // 
            this.Rb_Departamento.AutoSize = true;
            this.Rb_Departamento.Checked = true;
            this.Rb_Departamento.Location = new System.Drawing.Point(384, 18);
            this.Rb_Departamento.Name = "Rb_Departamento";
            this.Rb_Departamento.Size = new System.Drawing.Size(140, 21);
            this.Rb_Departamento.TabIndex = 7;
            this.Rb_Departamento.TabStop = true;
            this.Rb_Departamento.Text = "(DEPARTAMENTO)";
            this.Rb_Departamento.UseVisualStyleBackColor = true;
            this.Rb_Departamento.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "NOME (Definito Automaticamente):";
            // 
            // Rb_OutroTipo
            // 
            this.Rb_OutroTipo.AutoSize = true;
            this.Rb_OutroTipo.Location = new System.Drawing.Point(529, 18);
            this.Rb_OutroTipo.Name = "Rb_OutroTipo";
            this.Rb_OutroTipo.Size = new System.Drawing.Size(115, 21);
            this.Rb_OutroTipo.TabIndex = 10;
            this.Rb_OutroTipo.TabStop = true;
            this.Rb_OutroTipo.Text = "(OUTRO TIPO)";
            this.Rb_OutroTipo.UseVisualStyleBackColor = true;
            this.Rb_OutroTipo.CheckedChanged += new System.EventHandler(this.Rb_OutroTipo_CheckedChanged);
            // 
            // txt_NomeCaixa
            // 
            this.txt_NomeCaixa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeCaixa.ForeColor = System.Drawing.Color.Blue;
            this.txt_NomeCaixa.Location = new System.Drawing.Point(42, 311);
            this.txt_NomeCaixa.Name = "txt_NomeCaixa";
            this.txt_NomeCaixa.Size = new System.Drawing.Size(449, 27);
            this.txt_NomeCaixa.TabIndex = 11;
            this.txt_NomeCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NomeCaixa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_NomeCaixa_MouseDown);
            // 
            // btn_CadCaixa
            // 
            this.btn_CadCaixa.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CadCaixa.FlatAppearance.BorderSize = 0;
            this.btn_CadCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadCaixa.ForeColor = System.Drawing.Color.Blue;
            this.btn_CadCaixa.Image = global::SICM.Properties.Resources.SALVAR01;
            this.btn_CadCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadCaixa.Location = new System.Drawing.Point(42, 355);
            this.btn_CadCaixa.Name = "btn_CadCaixa";
            this.btn_CadCaixa.Size = new System.Drawing.Size(187, 39);
            this.btn_CadCaixa.TabIndex = 14;
            this.btn_CadCaixa.Text = "CADASTRAR CAIXA>>";
            this.btn_CadCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CadCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CadCaixa.UseVisualStyleBackColor = false;
            this.btn_CadCaixa.Click += new System.EventHandler(this.btn_CadCaixa_Click);
            // 
            // Nup_SaldoAtual
            // 
            this.Nup_SaldoAtual.DecimalPlaces = 2;
            this.Nup_SaldoAtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nup_SaldoAtual.ForeColor = System.Drawing.Color.Blue;
            this.Nup_SaldoAtual.Location = new System.Drawing.Point(497, 310);
            this.Nup_SaldoAtual.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.Nup_SaldoAtual.Name = "Nup_SaldoAtual";
            this.Nup_SaldoAtual.Size = new System.Drawing.Size(141, 29);
            this.Nup_SaldoAtual.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "SALDO ATUAL R$:";
            // 
            // FrmCadCaixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(700, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_CadCaixa);
            this.Controls.Add(this.Nup_SaldoAtual);
            this.Controls.Add(this.txt_NomeCaixa);
            this.Controls.Add(this.Rb_OutroTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rb_Departamento);
            this.Controls.Add(this.Gb_CaixaDepartamento);
            this.Controls.Add(this.Rb_IgrejaSel);
            this.Controls.Add(this.Gb_CaixaIgreja);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadCaixas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE NOVOS CAIXAS R$";
            this.Gb_CaixaIgreja.ResumeLayout(false);
            this.Gb_CaixaIgreja.PerformLayout();
            this.Gb_CaixaDepartamento.ResumeLayout(false);
            this.Gb_CaixaDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_SaldoAtual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton Rb_IgrejaSel;
        public System.Windows.Forms.RadioButton Rb_Departamento;
        public System.Windows.Forms.RadioButton Rb_OutroTipo;
        public System.Windows.Forms.ComboBox Cbb_ListaCongregacao;
        public System.Windows.Forms.ComboBox Cb_ListaSedeDepart;
        public System.Windows.Forms.ComboBox CB_ListaCoongDepart;
        public System.Windows.Forms.ComboBox Cb_Departamento;
        public System.Windows.Forms.Button btn_CadCaixa;
        public System.Windows.Forms.ComboBox CB_ListaSede;
        public System.Windows.Forms.GroupBox Gb_CaixaIgreja;
        public System.Windows.Forms.GroupBox Gb_CaixaDepartamento;
        public System.Windows.Forms.TextBox txt_NomeCaixa;
        private System.Windows.Forms.CheckBox Rb_ListaCongregacao;
        public System.Windows.Forms.CheckBox Cbox_ListaCongCaixaDepart;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown Nup_SaldoAtual;
    }
}