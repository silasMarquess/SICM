namespace SICM.SubForms
{
    partial class testeFrm
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
            this.Cb_Lista = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Cb_Lista
            // 
            this.Cb_Lista.FormattingEnabled = true;
            this.Cb_Lista.Location = new System.Drawing.Point(53, 30);
            this.Cb_Lista.Name = "Cb_Lista";
            this.Cb_Lista.Size = new System.Drawing.Size(197, 139);
            this.Cb_Lista.TabIndex = 0;
            // 
            // testeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cb_Lista);
            this.Name = "testeFrm";
            this.Text = "testeFrm";
            this.Load += new System.EventHandler(this.testeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Cb_Lista;
    }
}