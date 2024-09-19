namespace SozlukHavuzu
{
    partial class FrmKullaniciKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciKayıt));
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(165, 26);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(287, 38);
            this.txtadsoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad :";
            // 
            // btnkaydol
            // 
            this.btnkaydol.Location = new System.Drawing.Point(337, 124);
            this.btnkaydol.Name = "btnkaydol";
            this.btnkaydol.Size = new System.Drawing.Size(115, 44);
            this.btnkaydol.TabIndex = 2;
            this.btnkaydol.Text = "Kaydol";
            this.btnkaydol.UseVisualStyleBackColor = true;
            this.btnkaydol.Click += new System.EventHandler(this.btnkaydol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(165, 80);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(287, 38);
            this.txtsifre.TabIndex = 1;
            // 
            // FrmKullaniciKayıt
            // 
            this.AcceptButton = this.btnkaydol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 182);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btnkaydol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadsoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmKullaniciKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
    }
}