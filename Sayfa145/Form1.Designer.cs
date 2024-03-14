namespace Sayfa145
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.numara = new System.Windows.Forms.TextBox();
            this.adSoyadN = new System.Windows.Forms.TextBox();
            this.Numaram = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdSoyadlar = new System.Windows.Forms.ListBox();
            this.Numaralar = new System.Windows.Forms.ListBox();
            this.Nesneler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // adSoyad
            // 
            this.adSoyad.Location = new System.Drawing.Point(108, 75);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(100, 20);
            this.adSoyad.TabIndex = 0;
            // 
            // numara
            // 
            this.numara.Location = new System.Drawing.Point(310, 75);
            this.numara.Name = "numara";
            this.numara.Size = new System.Drawing.Size(100, 20);
            this.numara.TabIndex = 0;
            // 
            // adSoyadN
            // 
            this.adSoyadN.Location = new System.Drawing.Point(583, 75);
            this.adSoyadN.Name = "adSoyadN";
            this.adSoyadN.Size = new System.Drawing.Size(100, 20);
            this.adSoyadN.TabIndex = 0;
            // 
            // Numaram
            // 
            this.Numaram.Location = new System.Drawing.Point(583, 101);
            this.Numaram.Name = "Numaram";
            this.Numaram.Size = new System.Drawing.Size(100, 20);
            this.Numaram.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Metin Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sayı Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Nesne Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numaranızı giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad  giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numaranızı giriniz";
            // 
            // AdSoyadlar
            // 
            this.AdSoyadlar.FormattingEnabled = true;
            this.AdSoyadlar.Location = new System.Drawing.Point(82, 171);
            this.AdSoyadlar.Name = "AdSoyadlar";
            this.AdSoyadlar.Size = new System.Drawing.Size(146, 186);
            this.AdSoyadlar.TabIndex = 3;
            // 
            // Numaralar
            // 
            this.Numaralar.FormattingEnabled = true;
            this.Numaralar.Location = new System.Drawing.Point(294, 171);
            this.Numaralar.Name = "Numaralar";
            this.Numaralar.Size = new System.Drawing.Size(146, 186);
            this.Numaralar.TabIndex = 3;
            // 
            // Nesneler
            // 
            this.Nesneler.FormattingEnabled = true;
            this.Nesneler.Location = new System.Drawing.Point(558, 171);
            this.Nesneler.Name = "Nesneler";
            this.Nesneler.Size = new System.Drawing.Size(146, 186);
            this.Nesneler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nesneler);
            this.Controls.Add(this.Numaralar);
            this.Controls.Add(this.AdSoyadlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Numaram);
            this.Controls.Add(this.adSoyadN);
            this.Controls.Add(this.numara);
            this.Controls.Add(this.adSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.TextBox numara;
        private System.Windows.Forms.TextBox adSoyadN;
        private System.Windows.Forms.TextBox Numaram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AdSoyadlar;
        private System.Windows.Forms.ListBox Numaralar;
        private System.Windows.Forms.ListBox Nesneler;
    }
}

