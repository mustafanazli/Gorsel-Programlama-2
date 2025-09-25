namespace TimerUygulama
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
            this.components = new System.ComponentModel.Container();
            this.lbSaat = new System.Windows.Forms.Label();
            this.lbDakika = new System.Windows.Forms.Label();
            this.lbSaniye = new System.Windows.Forms.Label();
            this.lbSalise = new System.Windows.Forms.Label();
            this.lbgSaat = new System.Windows.Forms.Label();
            this.lbgDakika = new System.Windows.Forms.Label();
            this.lbgSaniye = new System.Windows.Forms.Label();
            this.lbgSalise = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbSaat
            // 
            this.lbSaat.AutoSize = true;
            this.lbSaat.Location = new System.Drawing.Point(72, 57);
            this.lbSaat.Name = "lbSaat";
            this.lbSaat.Size = new System.Drawing.Size(35, 13);
            this.lbSaat.TabIndex = 0;
            this.lbSaat.Text = "SAAT";
            // 
            // lbDakika
            // 
            this.lbDakika.AutoSize = true;
            this.lbDakika.Location = new System.Drawing.Point(160, 57);
            this.lbDakika.Name = "lbDakika";
            this.lbDakika.Size = new System.Drawing.Size(22, 13);
            this.lbDakika.TabIndex = 1;
            this.lbDakika.Text = "DK";
            // 
            // lbSaniye
            // 
            this.lbSaniye.AutoSize = true;
            this.lbSaniye.Location = new System.Drawing.Point(246, 57);
            this.lbSaniye.Name = "lbSaniye";
            this.lbSaniye.Size = new System.Drawing.Size(22, 13);
            this.lbSaniye.TabIndex = 2;
            this.lbSaniye.Text = "SN";
            // 
            // lbSalise
            // 
            this.lbSalise.AutoSize = true;
            this.lbSalise.Location = new System.Drawing.Point(333, 57);
            this.lbSalise.Name = "lbSalise";
            this.lbSalise.Size = new System.Drawing.Size(21, 13);
            this.lbSalise.TabIndex = 3;
            this.lbSalise.Text = "SS";
            // 
            // lbgSaat
            // 
            this.lbgSaat.AutoSize = true;
            this.lbgSaat.Location = new System.Drawing.Point(72, 134);
            this.lbgSaat.Name = "lbgSaat";
            this.lbgSaat.Size = new System.Drawing.Size(35, 13);
            this.lbgSaat.TabIndex = 7;
            this.lbgSaat.Text = "SAAT";
            // 
            // lbgDakika
            // 
            this.lbgDakika.AutoSize = true;
            this.lbgDakika.Location = new System.Drawing.Point(160, 134);
            this.lbgDakika.Name = "lbgDakika";
            this.lbgDakika.Size = new System.Drawing.Size(22, 13);
            this.lbgDakika.TabIndex = 6;
            this.lbgDakika.Text = "DK";
            // 
            // lbgSaniye
            // 
            this.lbgSaniye.AutoSize = true;
            this.lbgSaniye.Location = new System.Drawing.Point(246, 134);
            this.lbgSaniye.Name = "lbgSaniye";
            this.lbgSaniye.Size = new System.Drawing.Size(22, 13);
            this.lbgSaniye.TabIndex = 5;
            this.lbgSaniye.Text = "SN";
            // 
            // lbgSalise
            // 
            this.lbgSalise.AutoSize = true;
            this.lbgSalise.Location = new System.Drawing.Point(333, 134);
            this.lbgSalise.Name = "lbgSalise";
            this.lbgSalise.Size = new System.Drawing.Size(21, 13);
            this.lbgSalise.TabIndex = 4;
            this.lbgSalise.Text = "SS";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(440, 57);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(90, 90);
            this.btnBasla.TabIndex = 8;
            this.btnBasla.Text = "BASLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 208);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lbgSaat);
            this.Controls.Add(this.lbgDakika);
            this.Controls.Add(this.lbgSaniye);
            this.Controls.Add(this.lbgSalise);
            this.Controls.Add(this.lbSalise);
            this.Controls.Add(this.lbSaniye);
            this.Controls.Add(this.lbDakika);
            this.Controls.Add(this.lbSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSaat;
        private System.Windows.Forms.Label lbDakika;
        private System.Windows.Forms.Label lbSaniye;
        private System.Windows.Forms.Label lbSalise;
        private System.Windows.Forms.Label lbgSaat;
        private System.Windows.Forms.Label lbgDakika;
        private System.Windows.Forms.Label lbgSaniye;
        private System.Windows.Forms.Label lbgSalise;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
    }
}

