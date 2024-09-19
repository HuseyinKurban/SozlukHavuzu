namespace SozlukHavuzu
{
    partial class FrmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanici));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtingilizce = new System.Windows.Forms.TextBox();
            this.txturkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkelime = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe :";
            // 
            // txtingilizce
            // 
            this.txtingilizce.Location = new System.Drawing.Point(146, 18);
            this.txtingilizce.Name = "txtingilizce";
            this.txtingilizce.Size = new System.Drawing.Size(217, 38);
            this.txtingilizce.TabIndex = 1;
            // 
            // txturkce
            // 
            this.txturkce.Location = new System.Drawing.Point(146, 76);
            this.txturkce.Name = "txturkce";
            this.txturkce.Size = new System.Drawing.Size(217, 38);
            this.txturkce.TabIndex = 0;
            this.txturkce.TextChanged += new System.EventHandler(this.txturkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre :";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(523, 18);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(29, 31);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime :";
            // 
            // lblkelime
            // 
            this.lblkelime.AutoSize = true;
            this.lblkelime.Location = new System.Drawing.Point(523, 118);
            this.lblkelime.Name = "lblkelime";
            this.lblkelime.Size = new System.Drawing.Size(29, 31);
            this.lblkelime.TabIndex = 7;
            this.lblkelime.Text = "0";
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcevap.Location = new System.Drawing.Point(6, 3);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(6, 2);
            this.lblcevap.TabIndex = 8;
            this.lblcevap.Text = "label7";
            this.lblcevap.Visible = false;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Location = new System.Drawing.Point(523, 66);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(29, 31);
            this.lblpuan.TabIndex = 10;
            this.lblpuan.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Puan :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(47, 3);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(6, 2);
            this.lblid.TabIndex = 11;
            this.lblid.Text = "label7";
            this.lblid.Visible = false;
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 164);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.lblkelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturkce);
            this.Controls.Add(this.txtingilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtingilizce;
        private System.Windows.Forms.TextBox txturkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblkelime;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblid;
    }
}