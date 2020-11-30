namespace RestaurantManagementSystem
{
    partial class frmMenu
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
            this.btnMasaSiparis = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnKasaIslemleri = new System.Windows.Forms.Button();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasaSiparis
            // 
            this.btnMasaSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasaSiparis.Location = new System.Drawing.Point(21, 28);
            this.btnMasaSiparis.Name = "btnMasaSiparis";
            this.btnMasaSiparis.Size = new System.Drawing.Size(132, 74);
            this.btnMasaSiparis.TabIndex = 0;
            this.btnMasaSiparis.Text = "Masa";
            this.btnMasaSiparis.UseVisualStyleBackColor = true;
            this.btnMasaSiparis.Click += new System.EventHandler(this.btnMasaSiparis_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyon.Location = new System.Drawing.Point(174, 28);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(132, 74);
            this.btnRezervasyon.TabIndex = 1;
            this.btnRezervasyon.Text = "Rezervasyon";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriler.Location = new System.Drawing.Point(21, 135);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(132, 74);
            this.btnMusteriler.TabIndex = 2;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnKasaIslemleri
            // 
            this.btnKasaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKasaIslemleri.Location = new System.Drawing.Point(174, 135);
            this.btnKasaIslemleri.Name = "btnKasaIslemleri";
            this.btnKasaIslemleri.Size = new System.Drawing.Size(132, 74);
            this.btnKasaIslemleri.TabIndex = 3;
            this.btnKasaIslemleri.Text = "Kasa İşlemleri";
            this.btnKasaIslemleri.UseVisualStyleBackColor = true;
            this.btnKasaIslemleri.Click += new System.EventHandler(this.btnKasaIslemleri_Click);
            // 
            // btnMutfak
            // 
            this.btnMutfak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMutfak.Location = new System.Drawing.Point(312, 135);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(132, 74);
            this.btnMutfak.TabIndex = 4;
            this.btnMutfak.Text = "Mutfak";
            this.btnMutfak.UseVisualStyleBackColor = true;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyarlar.Location = new System.Drawing.Point(21, 236);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(132, 74);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilit.Location = new System.Drawing.Point(174, 236);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(132, 74);
            this.btnKilit.TabIndex = 6;
            this.btnKilit.Text = "Kilitle";
            this.btnKilit.UseVisualStyleBackColor = true;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(312, 236);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(132, 74);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 405);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKilit);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnMutfak);
            this.Controls.Add(this.btnKasaIslemleri);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMasaSiparis);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasaSiparis;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnKasaIslemleri;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnCikis;
    }
}