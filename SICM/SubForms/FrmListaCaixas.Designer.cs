namespace SICM.SubForms
{
    partial class FrmListaCaixas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCaixas));
            this.Clb_CaixasSelecionados = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TotalEntrdasGeral = new System.Windows.Forms.TextBox();
            this.txt_TotalSaidasGeral = new System.Windows.Forms.TextBox();
            this.txt_TotalSaldoGeral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_ListaMeses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ListaAnos = new System.Windows.Forms.ComboBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_PrintInfor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clb_CaixasSelecionados
            // 
            this.Clb_CaixasSelecionados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clb_CaixasSelecionados.FormattingEnabled = true;
            this.Clb_CaixasSelecionados.Location = new System.Drawing.Point(12, 47);
            this.Clb_CaixasSelecionados.Name = "Clb_CaixasSelecionados";
            this.Clb_CaixasSelecionados.Size = new System.Drawing.Size(809, 224);
            this.Clb_CaixasSelecionados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE CAIXAS->";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Red;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Location = new System.Drawing.Point(23, 282);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(97, 33);
            this.btn_deletar.TabIndex = 2;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(126, 282);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Calcular.Size = new System.Drawing.Size(165, 33);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "Calcular Total R$:";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total de Entradas R$:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(844, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total de Saidas R$:";
            // 
            // txt_TotalEntrdasGeral
            // 
            this.txt_TotalEntrdasGeral.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TotalEntrdasGeral.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalEntrdasGeral.ForeColor = System.Drawing.Color.Blue;
            this.txt_TotalEntrdasGeral.Location = new System.Drawing.Point(831, 55);
            this.txt_TotalEntrdasGeral.Name = "txt_TotalEntrdasGeral";
            this.txt_TotalEntrdasGeral.ReadOnly = true;
            this.txt_TotalEntrdasGeral.Size = new System.Drawing.Size(164, 31);
            this.txt_TotalEntrdasGeral.TabIndex = 6;
            this.txt_TotalEntrdasGeral.Text = "0.00";
            this.txt_TotalEntrdasGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalSaidasGeral
            // 
            this.txt_TotalSaidasGeral.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TotalSaidasGeral.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalSaidasGeral.ForeColor = System.Drawing.Color.Blue;
            this.txt_TotalSaidasGeral.Location = new System.Drawing.Point(831, 125);
            this.txt_TotalSaidasGeral.Name = "txt_TotalSaidasGeral";
            this.txt_TotalSaidasGeral.ReadOnly = true;
            this.txt_TotalSaidasGeral.Size = new System.Drawing.Size(164, 31);
            this.txt_TotalSaidasGeral.TabIndex = 7;
            this.txt_TotalSaidasGeral.Text = "0.00";
            this.txt_TotalSaidasGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalSaldoGeral
            // 
            this.txt_TotalSaldoGeral.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TotalSaldoGeral.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalSaldoGeral.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_TotalSaldoGeral.Location = new System.Drawing.Point(831, 197);
            this.txt_TotalSaldoGeral.Name = "txt_TotalSaldoGeral";
            this.txt_TotalSaldoGeral.ReadOnly = true;
            this.txt_TotalSaldoGeral.Size = new System.Drawing.Size(164, 34);
            this.txt_TotalSaldoGeral.TabIndex = 9;
            this.txt_TotalSaldoGeral.Text = "0.00";
            this.txt_TotalSaldoGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "SALDO GERAL R$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "MÊS:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Cb_ListaMeses
            // 
            this.Cb_ListaMeses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "NOVEMBRO",
            "DEZEMBRO"});
            this.Cb_ListaMeses.Location = new System.Drawing.Point(210, 7);
            this.Cb_ListaMeses.Name = "Cb_ListaMeses";
            this.Cb_ListaMeses.Size = new System.Drawing.Size(291, 28);
            this.Cb_ListaMeses.TabIndex = 12;
            this.Cb_ListaMeses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "ANO:";
            // 
            // cb_ListaAnos
            // 
            this.cb_ListaAnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ListaAnos.ForeColor = System.Drawing.Color.Blue;
            this.cb_ListaAnos.FormattingEnabled = true;
            this.cb_ListaAnos.Location = new System.Drawing.Point(558, 7);
            this.cb_ListaAnos.Name = "cb_ListaAnos";
            this.cb_ListaAnos.Size = new System.Drawing.Size(138, 28);
            this.cb_ListaAnos.TabIndex = 14;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.Image")));
            this.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Consultar.Location = new System.Drawing.Point(702, -3);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Consultar.Size = new System.Drawing.Size(37, 41);
            this.btn_Consultar.TabIndex = 15;
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PrintInfor
            // 
            this.btn_PrintInfor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintInfor.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintInfor.Image")));
            this.btn_PrintInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PrintInfor.Location = new System.Drawing.Point(894, 242);
            this.btn_PrintInfor.Name = "btn_PrintInfor";
            this.btn_PrintInfor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_PrintInfor.Size = new System.Drawing.Size(101, 33);
            this.btn_PrintInfor.TabIndex = 10;
            this.btn_PrintInfor.Text = "Report";
            this.btn_PrintInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrintInfor.UseVisualStyleBackColor = true;
            this.btn_PrintInfor.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmListaCaixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 328);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.cb_ListaAnos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cb_ListaMeses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_PrintInfor);
            this.Controls.Add(this.txt_TotalSaldoGeral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TotalSaidasGeral);
            this.Controls.Add(this.txt_TotalEntrdasGeral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clb_CaixasSelecionados);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListaCaixas";
            this.Text = "FrmListaCaixas";
            this.Load += new System.EventHandler(this.FrmListaCaixas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_deletar;
        public System.Windows.Forms.Button btn_Calcular;
        public System.Windows.Forms.TextBox txt_TotalEntrdasGeral;
        public System.Windows.Forms.TextBox txt_TotalSaidasGeral;
        public System.Windows.Forms.Button btn_PrintInfor;
        public System.Windows.Forms.CheckedListBox Clb_CaixasSelecionados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_Consultar;
        public System.Windows.Forms.ComboBox Cb_ListaMeses;
        public System.Windows.Forms.ComboBox cb_ListaAnos;
        public System.Windows.Forms.TextBox txt_TotalSaldoGeral;
    }
}