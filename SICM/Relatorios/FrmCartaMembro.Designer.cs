namespace SICM.Relatorios
{
    partial class FrmCartaMembro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_solteiro = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_NomeMembrio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_EmitirCarta = new System.Windows.Forms.Button();
            this.Cb_Municipio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Uf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rb_transicao = new System.Windows.Forms.RadioButton();
            this.Rb_Transferencia = new System.Windows.Forms.RadioButton();
            this.Rb_recomendacao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 141);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(924, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_solteiro);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_NomeMembrio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_EmitirCarta);
            this.panel1.Controls.Add(this.Cb_Municipio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CB_Uf);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Rb_transicao);
            this.panel1.Controls.Add(this.Rb_Transferencia);
            this.panel1.Controls.Add(this.Rb_recomendacao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 132);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_solteiro
            // 
            this.lb_solteiro.AutoSize = true;
            this.lb_solteiro.ForeColor = System.Drawing.Color.Blue;
            this.lb_solteiro.Location = new System.Drawing.Point(650, 22);
            this.lb_solteiro.Name = "lb_solteiro";
            this.lb_solteiro.Size = new System.Drawing.Size(69, 17);
            this.lb_solteiro.TabIndex = 15;
            this.lb_solteiro.Text = "SOLTEIRO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "EST.CIVIL.";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.ForeColor = System.Drawing.Color.Blue;
            this.lb_status.Location = new System.Drawing.Point(794, 22);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(60, 17);
            this.lb_status.TabIndex = 13;
            this.lb_status.Text = "STATUS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(731, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "STATUS:";
            // 
            // lb_NomeMembrio
            // 
            this.lb_NomeMembrio.AutoSize = true;
            this.lb_NomeMembrio.ForeColor = System.Drawing.Color.Blue;
            this.lb_NomeMembrio.Location = new System.Drawing.Point(176, 22);
            this.lb_NomeMembrio.Name = "lb_NomeMembrio";
            this.lb_NomeMembrio.Size = new System.Drawing.Size(46, 17);
            this.lb_NomeMembrio.TabIndex = 11;
            this.lb_NomeMembrio.Text = "NOME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "MEMBRO SELECIONADO:";
            // 
            // btn_EmitirCarta
            // 
            this.btn_EmitirCarta.Image = global::SICM.Properties.Resources.PrintFicha;
            this.btn_EmitirCarta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EmitirCarta.Location = new System.Drawing.Point(777, 92);
            this.btn_EmitirCarta.Name = "btn_EmitirCarta";
            this.btn_EmitirCarta.Size = new System.Drawing.Size(141, 32);
            this.btn_EmitirCarta.TabIndex = 9;
            this.btn_EmitirCarta.Text = "EMITIR AGORA";
            this.btn_EmitirCarta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EmitirCarta.UseVisualStyleBackColor = true;
            this.btn_EmitirCarta.Click += new System.EventHandler(this.btn_EmitirCarta_Click);
            // 
            // Cb_Municipio
            // 
            this.Cb_Municipio.FormattingEnabled = true;
            this.Cb_Municipio.Location = new System.Drawing.Point(398, 92);
            this.Cb_Municipio.Name = "Cb_Municipio";
            this.Cb_Municipio.Size = new System.Drawing.Size(357, 25);
            this.Cb_Municipio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(312, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = ">MUNICÍPIO:";
            // 
            // CB_Uf
            // 
            this.CB_Uf.FormattingEnabled = true;
            this.CB_Uf.Items.AddRange(new object[] {
            "(AC) Acre",
            "(AL) Alagoas",
            "(AP) Amapá",
            "(AM) Amazonas",
            "(BA) Bahia",
            "(CE) Ceará",
            "(DF) Distrito Federal",
            "(ES) Espirito Santo",
            "(GO) Goiás",
            "(MA) Maranhão",
            "(MT) Mato Grosso",
            "(MS) Mato Grosso do Sul",
            "(MG) Minas Gerais",
            "(PA) Pará",
            "(PB) Paraiba",
            "(PR) Paraná",
            "(PE) Pernambuco",
            "(PI) Piauí",
            "(RJ) Rio De Janeiro",
            "(RN) Rio Grande do Norte",
            "(RS) Rio Grande do Sul",
            "(RO) Rondônia",
            "(RR) Roraima",
            "(SC) Santa Catarina",
            "(SP) São Paulo",
            "(SE) Sergipe",
            "(TO) Tocantins"});
            this.CB_Uf.Location = new System.Drawing.Point(130, 92);
            this.CB_Uf.MaxDropDownItems = 30;
            this.CB_Uf.Name = "CB_Uf";
            this.CB_Uf.Size = new System.Drawing.Size(176, 25);
            this.CB_Uf.TabIndex = 6;
            this.CB_Uf.SelectionChangeCommitted += new System.EventHandler(this.CB_Uf_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(94, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = ">UF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "DESTINO:";
            // 
            // Rb_transicao
            // 
            this.Rb_transicao.AutoSize = true;
            this.Rb_transicao.ForeColor = System.Drawing.Color.Blue;
            this.Rb_transicao.Location = new System.Drawing.Point(408, 54);
            this.Rb_transicao.Name = "Rb_transicao";
            this.Rb_transicao.Size = new System.Drawing.Size(112, 21);
            this.Rb_transicao.TabIndex = 3;
            this.Rb_transicao.Text = "EM TRANSITO";
            this.Rb_transicao.UseVisualStyleBackColor = true;
            this.Rb_transicao.CheckedChanged += new System.EventHandler(this.Rb_transicao_CheckedChanged);
            // 
            // Rb_Transferencia
            // 
            this.Rb_Transferencia.AutoSize = true;
            this.Rb_Transferencia.ForeColor = System.Drawing.Color.Blue;
            this.Rb_Transferencia.Location = new System.Drawing.Point(272, 54);
            this.Rb_Transferencia.Name = "Rb_Transferencia";
            this.Rb_Transferencia.Size = new System.Drawing.Size(128, 21);
            this.Rb_Transferencia.TabIndex = 2;
            this.Rb_Transferencia.Text = "TRANSFERÊNCIA";
            this.Rb_Transferencia.UseVisualStyleBackColor = true;
            // 
            // Rb_recomendacao
            // 
            this.Rb_recomendacao.AutoSize = true;
            this.Rb_recomendacao.Checked = true;
            this.Rb_recomendacao.ForeColor = System.Drawing.Color.Blue;
            this.Rb_recomendacao.Location = new System.Drawing.Point(130, 54);
            this.Rb_recomendacao.Name = "Rb_recomendacao";
            this.Rb_recomendacao.Size = new System.Drawing.Size(133, 21);
            this.Rb_recomendacao.TabIndex = 1;
            this.Rb_recomendacao.TabStop = true;
            this.Rb_recomendacao.Text = "RECOMENDAÇÃO";
            this.Rb_recomendacao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE CARTA:";
            // 
            // FrmCartaMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCartaMembro";
            this.Text = "FrmCartaMembro";
            this.Load += new System.EventHandler(this.FrmCartaMembro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EmitirCarta;
        private System.Windows.Forms.ComboBox Cb_Municipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Uf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rb_transicao;
        private System.Windows.Forms.RadioButton Rb_Transferencia;
        private System.Windows.Forms.RadioButton Rb_recomendacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_solteiro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_NomeMembrio;
        private System.Windows.Forms.Label label5;
    }
}