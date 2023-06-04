namespace SICM.SubForms
{
    partial class FrmCadDepartCargo
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
            this.label2 = new System.Windows.Forms.Label();
            this.Rb_Cargo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Departamento = new System.Windows.Forms.ComboBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NomeDepartCargo = new System.Windows.Forms.TextBox();
            this.btn_SalvarAlterações = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.Rb_Departamento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cb_ListaCongregacao = new System.Windows.Forms.ComboBox();
            this.Rb_TemploSede = new System.Windows.Forms.RadioButton();
            this.Rb_Congregacao = new System.Windows.Forms.RadioButton();
            this.Cb_TemploSede = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CARGOS E DEPARTAMENTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "O que Deseja Cadastrar ?";
            // 
            // Rb_Cargo
            // 
            this.Rb_Cargo.AutoSize = true;
            this.Rb_Cargo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Cargo.Location = new System.Drawing.Point(355, 47);
            this.Rb_Cargo.Name = "Rb_Cargo";
            this.Rb_Cargo.Size = new System.Drawing.Size(79, 24);
            this.Rb_Cargo.TabIndex = 3;
            this.Rb_Cargo.Text = "CARGO";
            this.Rb_Cargo.UseVisualStyleBackColor = true;
            this.Rb_Cargo.CheckedChanged += new System.EventHandler(this.Rb_Cargo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEPARTAMENTO DE DESTINO DO CARGO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // Cb_Departamento
            // 
            this.Cb_Departamento.BackColor = System.Drawing.SystemColors.Info;
            this.Cb_Departamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Departamento.ForeColor = System.Drawing.Color.Blue;
            this.Cb_Departamento.FormattingEnabled = true;
            this.Cb_Departamento.Location = new System.Drawing.Point(17, 269);
            this.Cb_Departamento.Name = "Cb_Departamento";
            this.Cb_Departamento.Size = new System.Drawing.Size(377, 29);
            this.Cb_Departamento.TabIndex = 9;
            this.Cb_Departamento.SelectionChangeCommitted += new System.EventHandler(this.Cb_Departamento_SelectionChangeCommitted);
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.Blue;
            this.txt_Id.Location = new System.Drawing.Point(400, 270);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(117, 29);
            this.txt_Id.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "NOME DO CARGO OU DEPARTAMENTO:";
            // 
            // txt_NomeDepartCargo
            // 
            this.txt_NomeDepartCargo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NomeDepartCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NomeDepartCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeDepartCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeDepartCargo.ForeColor = System.Drawing.Color.Blue;
            this.txt_NomeDepartCargo.Location = new System.Drawing.Point(18, 329);
            this.txt_NomeDepartCargo.Name = "txt_NomeDepartCargo";
            this.txt_NomeDepartCargo.Size = new System.Drawing.Size(499, 29);
            this.txt_NomeDepartCargo.TabIndex = 12;
            // 
            // btn_SalvarAlterações
            // 
            this.btn_SalvarAlterações.BackColor = System.Drawing.Color.LightGray;
            this.btn_SalvarAlterações.Enabled = false;
            this.btn_SalvarAlterações.FlatAppearance.BorderSize = 0;
            this.btn_SalvarAlterações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarAlterações.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarAlterações.Image = global::SICM.Properties.Resources.salvar;
            this.btn_SalvarAlterações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarAlterações.Location = new System.Drawing.Point(157, 375);
            this.btn_SalvarAlterações.Name = "btn_SalvarAlterações";
            this.btn_SalvarAlterações.Size = new System.Drawing.Size(178, 32);
            this.btn_SalvarAlterações.TabIndex = 13;
            this.btn_SalvarAlterações.Text = "Salvar Alterações";
            this.btn_SalvarAlterações.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SalvarAlterações.UseVisualStyleBackColor = false;
            this.btn_SalvarAlterações.Click += new System.EventHandler(this.btn_SalvarAlterações_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.LightGray;
            this.btn_Cadastrar.Enabled = false;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Image = global::SICM.Properties.Resources.SALVAR01;
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(17, 375);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(125, 32);
            this.btn_Cadastrar.TabIndex = 14;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Rb_Departamento
            // 
            this.Rb_Departamento.AutoSize = true;
            this.Rb_Departamento.Checked = true;
            this.Rb_Departamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Departamento.Location = new System.Drawing.Point(200, 45);
            this.Rb_Departamento.Name = "Rb_Departamento";
            this.Rb_Departamento.Size = new System.Drawing.Size(139, 25);
            this.Rb_Departamento.TabIndex = 15;
            this.Rb_Departamento.TabStop = true;
            this.Rb_Departamento.Text = "Departamento";
            this.Rb_Departamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cb_ListaCongregacao);
            this.groupBox1.Controls.Add(this.Rb_TemploSede);
            this.groupBox1.Controls.Add(this.Rb_Congregacao);
            this.groupBox1.Controls.Add(this.Cb_TemploSede);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 153);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a Igreja";
            // 
            // Cb_ListaCongregacao
            // 
            this.Cb_ListaCongregacao.BackColor = System.Drawing.SystemColors.Info;
            this.Cb_ListaCongregacao.Enabled = false;
            this.Cb_ListaCongregacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ListaCongregacao.ForeColor = System.Drawing.Color.Blue;
            this.Cb_ListaCongregacao.FormattingEnabled = true;
            this.Cb_ListaCongregacao.Location = new System.Drawing.Point(6, 110);
            this.Cb_ListaCongregacao.Name = "Cb_ListaCongregacao";
            this.Cb_ListaCongregacao.Size = new System.Drawing.Size(377, 29);
            this.Cb_ListaCongregacao.TabIndex = 22;
            this.Cb_ListaCongregacao.SelectionChangeCommitted += new System.EventHandler(this.Cb_ListaCongregacao_SelectionChangeCommitted);
            // 
            // Rb_TemploSede
            // 
            this.Rb_TemploSede.AutoSize = true;
            this.Rb_TemploSede.Checked = true;
            this.Rb_TemploSede.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_TemploSede.Location = new System.Drawing.Point(6, 24);
            this.Rb_TemploSede.Name = "Rb_TemploSede";
            this.Rb_TemploSede.Size = new System.Drawing.Size(182, 23);
            this.Rb_TemploSede.TabIndex = 21;
            this.Rb_TemploSede.TabStop = true;
            this.Rb_TemploSede.Text = "TEMPLO SEDE (Destino)";
            this.Rb_TemploSede.UseVisualStyleBackColor = true;
            this.Rb_TemploSede.CheckedChanged += new System.EventHandler(this.Rb_TemploSede_CheckedChanged);
            // 
            // Rb_Congregacao
            // 
            this.Rb_Congregacao.AutoSize = true;
            this.Rb_Congregacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Congregacao.Location = new System.Drawing.Point(6, 85);
            this.Rb_Congregacao.Name = "Rb_Congregacao";
            this.Rb_Congregacao.Size = new System.Drawing.Size(227, 23);
            this.Rb_Congregacao.TabIndex = 20;
            this.Rb_Congregacao.Text = "NA CONGREGAÇAO (Destino):";
            this.Rb_Congregacao.UseVisualStyleBackColor = true;
            this.Rb_Congregacao.CheckedChanged += new System.EventHandler(this.Rb_Congregacao_CheckedChanged);
            // 
            // Cb_TemploSede
            // 
            this.Cb_TemploSede.BackColor = System.Drawing.SystemColors.Info;
            this.Cb_TemploSede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TemploSede.ForeColor = System.Drawing.Color.Blue;
            this.Cb_TemploSede.FormattingEnabled = true;
            this.Cb_TemploSede.Location = new System.Drawing.Point(6, 46);
            this.Cb_TemploSede.Name = "Cb_TemploSede";
            this.Cb_TemploSede.Size = new System.Drawing.Size(377, 29);
            this.Cb_TemploSede.TabIndex = 19;
            this.Cb_TemploSede.SelectedIndexChanged += new System.EventHandler(this.Cb_TemploSede_SelectedIndexChanged_1);
            this.Cb_TemploSede.SelectionChangeCommitted += new System.EventHandler(this.Cb_TemploSede_SelectionChangeCommitted_1);
            // 
            // FrmCadDepartCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(603, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Rb_Departamento);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_SalvarAlterações);
            this.Controls.Add(this.txt_NomeDepartCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.Cb_Departamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rb_Cargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadDepartCargo";
            this.Text = "DEPARTAMENTO/ CARGOS";
            this.Load += new System.EventHandler(this.FrmCadDepartCargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SalvarAlterações;
        public System.Windows.Forms.RadioButton Rb_Cargo;
        public System.Windows.Forms.ComboBox Cb_Departamento;
        public System.Windows.Forms.Button btn_Cadastrar;
        public System.Windows.Forms.TextBox txt_NomeDepartCargo;
        public System.Windows.Forms.TextBox txt_Id;
        public System.Windows.Forms.RadioButton Rb_Departamento;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox Cb_ListaCongregacao;
        public System.Windows.Forms.RadioButton Rb_TemploSede;
        public System.Windows.Forms.RadioButton Rb_Congregacao;
        public System.Windows.Forms.ComboBox Cb_TemploSede;
    }
}