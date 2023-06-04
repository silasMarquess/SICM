namespace SICM.SubForms
{
    partial class FrmCadIgreja
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
            this.Rb_TemploSede = new System.Windows.Forms.RadioButton();
            this.Rb_CadCongregacao = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DataFund = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nup_Numero = new System.Windows.Forms.NumericUpDown();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoIgreja = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_CancelarDados = new System.Windows.Forms.Button();
            this.btn_SalvarDados = new System.Windows.Forms.Button();
            this.txt_dirigentes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CB_ListaSede = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Numero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO:";
            // 
            // Rb_TemploSede
            // 
            this.Rb_TemploSede.AutoSize = true;
            this.Rb_TemploSede.Checked = true;
            this.Rb_TemploSede.Location = new System.Drawing.Point(90, 60);
            this.Rb_TemploSede.Name = "Rb_TemploSede";
            this.Rb_TemploSede.Size = new System.Drawing.Size(121, 24);
            this.Rb_TemploSede.TabIndex = 1;
            this.Rb_TemploSede.TabStop = true;
            this.Rb_TemploSede.Text = "Templo Sede";
            this.Rb_TemploSede.UseVisualStyleBackColor = true;
            this.Rb_TemploSede.CheckedChanged += new System.EventHandler(this.Rb_TemploSede_CheckedChanged);
            // 
            // Rb_CadCongregacao
            // 
            this.Rb_CadCongregacao.AutoSize = true;
            this.Rb_CadCongregacao.Location = new System.Drawing.Point(217, 60);
            this.Rb_CadCongregacao.Name = "Rb_CadCongregacao";
            this.Rb_CadCongregacao.Size = new System.Drawing.Size(123, 24);
            this.Rb_CadCongregacao.TabIndex = 2;
            this.Rb_CadCongregacao.TabStop = true;
            this.Rb_CadCongregacao.Text = "Congregação";
            this.Rb_CadCongregacao.UseVisualStyleBackColor = true;
            this.Rb_CadCongregacao.CheckedChanged += new System.EventHandler(this.Rb_CadCongregacao_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_bairro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Cidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_DataFund);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Nup_Numero);
            this.groupBox1.Controls.Add(this.txt_rua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DE ENDEREÇO";
            // 
            // txt_bairro
            // 
            this.txt_bairro.BackColor = System.Drawing.SystemColors.Info;
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.ForeColor = System.Drawing.Color.Blue;
            this.txt_bairro.Location = new System.Drawing.Point(14, 167);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(384, 26);
            this.txt_bairro.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bairro:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cidade.ForeColor = System.Drawing.Color.Blue;
            this.txt_Cidade.Location = new System.Drawing.Point(146, 109);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(400, 26);
            this.txt_Cidade.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cidade:";
            // 
            // txt_DataFund
            // 
            this.txt_DataFund.BackColor = System.Drawing.SystemColors.Info;
            this.txt_DataFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataFund.ForeColor = System.Drawing.Color.Blue;
            this.txt_DataFund.Location = new System.Drawing.Point(14, 106);
            this.txt_DataFund.Mask = "00/00/0000";
            this.txt_DataFund.Name = "txt_DataFund";
            this.txt_DataFund.Size = new System.Drawing.Size(97, 29);
            this.txt_DataFund.TabIndex = 14;
            this.txt_DataFund.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_DataFund.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data/Fundação:";
            // 
            // Nup_Numero
            // 
            this.Nup_Numero.BackColor = System.Drawing.SystemColors.Info;
            this.Nup_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nup_Numero.ForeColor = System.Drawing.Color.Blue;
            this.Nup_Numero.Location = new System.Drawing.Point(385, 51);
            this.Nup_Numero.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.Nup_Numero.Name = "Nup_Numero";
            this.Nup_Numero.Size = new System.Drawing.Size(109, 27);
            this.Nup_Numero.TabIndex = 12;
            // 
            // txt_rua
            // 
            this.txt_rua.BackColor = System.Drawing.SystemColors.Info;
            this.txt_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_rua.ForeColor = System.Drawing.Color.Blue;
            this.txt_rua.Location = new System.Drawing.Point(14, 51);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(354, 26);
            this.txt_rua.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rua:";
            // 
            // txt_CodigoIgreja
            // 
            this.txt_CodigoIgreja.BackColor = System.Drawing.SystemColors.Info;
            this.txt_CodigoIgreja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoIgreja.ForeColor = System.Drawing.Color.Blue;
            this.txt_CodigoIgreja.Location = new System.Drawing.Point(90, 100);
            this.txt_CodigoIgreja.Name = "txt_CodigoIgreja";
            this.txt_CodigoIgreja.ReadOnly = true;
            this.txt_CodigoIgreja.Size = new System.Drawing.Size(250, 26);
            this.txt_CodigoIgreja.TabIndex = 9;
            this.txt_CodigoIgreja.Text = "IEA0000";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nome.ForeColor = System.Drawing.Color.Blue;
            this.txt_Nome.Location = new System.Drawing.Point(91, 183);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(471, 26);
            this.txt_Nome.TabIndex = 10;
            // 
            // btn_CancelarDados
            // 
            this.btn_CancelarDados.BackColor = System.Drawing.Color.LightGray;
            this.btn_CancelarDados.Enabled = false;
            this.btn_CancelarDados.FlatAppearance.BorderSize = 0;
            this.btn_CancelarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_CancelarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CancelarDados.Image = global::SICM.Properties.Resources.editarBtn;
            this.btn_CancelarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarDados.Location = new System.Drawing.Point(204, 540);
            this.btn_CancelarDados.Name = "btn_CancelarDados";
            this.btn_CancelarDados.Size = new System.Drawing.Size(225, 40);
            this.btn_CancelarDados.TabIndex = 12;
            this.btn_CancelarDados.Text = "Salvar Alterações";
            this.btn_CancelarDados.UseVisualStyleBackColor = false;
            this.btn_CancelarDados.Click += new System.EventHandler(this.btn_CancelarDados_Click);
            // 
            // btn_SalvarDados
            // 
            this.btn_SalvarDados.BackColor = System.Drawing.Color.LightGray;
            this.btn_SalvarDados.FlatAppearance.BorderSize = 0;
            this.btn_SalvarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btn_SalvarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SalvarDados.Image = global::SICM.Properties.Resources.salvar;
            this.btn_SalvarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarDados.Location = new System.Drawing.Point(36, 540);
            this.btn_SalvarDados.Name = "btn_SalvarDados";
            this.btn_SalvarDados.Size = new System.Drawing.Size(156, 40);
            this.btn_SalvarDados.TabIndex = 11;
            this.btn_SalvarDados.Text = "Salvar Dados";
            this.btn_SalvarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SalvarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalvarDados.UseVisualStyleBackColor = false;
            this.btn_SalvarDados.Click += new System.EventHandler(this.btn_SalvarDados_Click);
            // 
            // txt_dirigentes
            // 
            this.txt_dirigentes.BackColor = System.Drawing.SystemColors.Info;
            this.txt_dirigentes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dirigentes.ForeColor = System.Drawing.Color.Blue;
            this.txt_dirigentes.Location = new System.Drawing.Point(90, 232);
            this.txt_dirigentes.Name = "txt_dirigentes";
            this.txt_dirigentes.Size = new System.Drawing.Size(371, 26);
            this.txt_dirigentes.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dirigente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "CNPJ:";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.BackColor = System.Drawing.SystemColors.Info;
            this.txt_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnpj.ForeColor = System.Drawing.Color.Blue;
            this.txt_cnpj.Location = new System.Drawing.Point(90, 274);
            this.txt_cnpj.Mask = "##,###,###/####-##";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(151, 27);
            this.txt_cnpj.TabIndex = 16;
            this.txt_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(387, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "CAMPO DE CADASTRO DE IGREJAS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "SEDE:";
            // 
            // CB_ListaSede
            // 
            this.CB_ListaSede.BackColor = System.Drawing.SystemColors.Info;
            this.CB_ListaSede.FormattingEnabled = true;
            this.CB_ListaSede.Location = new System.Drawing.Point(90, 141);
            this.CB_ListaSede.Name = "CB_ListaSede";
            this.CB_ListaSede.Size = new System.Drawing.Size(414, 28);
            this.CB_ListaSede.TabIndex = 19;
            // 
            // FrmCadIgreja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(593, 592);
            this.Controls.Add(this.CB_ListaSede);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_dirigentes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_CancelarDados);
            this.Controls.Add(this.btn_SalvarDados);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_CodigoIgreja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rb_CadCongregacao);
            this.Controls.Add(this.Rb_TemploSede);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadIgreja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadIgreja";
            this.Load += new System.EventHandler(this.FrmCadIgreja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rb_CadCongregacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RadioButton Rb_TemploSede;
        public System.Windows.Forms.TextBox txt_CodigoIgreja;
        public System.Windows.Forms.TextBox txt_Nome;
        public System.Windows.Forms.TextBox txt_dirigentes;
        public System.Windows.Forms.MaskedTextBox txt_cnpj;
        public System.Windows.Forms.TextBox txt_rua;
        public System.Windows.Forms.NumericUpDown Nup_Numero;
        public System.Windows.Forms.TextBox txt_Cidade;
        public System.Windows.Forms.TextBox txt_bairro;
        public System.Windows.Forms.Button btn_SalvarDados;
        public System.Windows.Forms.Button btn_CancelarDados;
        public System.Windows.Forms.MaskedTextBox txt_DataFund;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox CB_ListaSede;
    }
}