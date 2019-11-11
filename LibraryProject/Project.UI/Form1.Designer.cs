namespace Project.UI
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapAra = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategroiListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.btnYazarListele = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.txtKategoriAra = new System.Windows.Forms.TextBox();
            this.txtYazarAra = new System.Windows.Forms.TextBox();
            this.btnKategoriAdiAra = new System.Windows.Forms.Button();
            this.btnYazarAdiAra = new System.Windows.Forms.Button();
            this.btnGenelListeleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(478, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Adi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(861, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Adi";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(111, 355);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(145, 20);
            this.txtKitapAdi.TabIndex = 6;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(577, 351);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(215, 20);
            this.txtKategoriAdi.TabIndex = 8;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(971, 350);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(156, 20);
            this.txtYazarAdi.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 290);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(279, 387);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(136, 23);
            this.btnKitapEkle.TabIndex = 13;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapSil.Location = new System.Drawing.Point(279, 427);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(136, 23);
            this.btnKitapSil.TabIndex = 14;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.Location = new System.Drawing.Point(279, 353);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(136, 23);
            this.btnKitapGuncelle.TabIndex = 15;
            this.btnKitapGuncelle.Text = "Kitap Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAra.Location = new System.Drawing.Point(814, 30);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(136, 23);
            this.btnKitapAra.TabIndex = 16;
            this.btnKitapAra.Text = "Kitap Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(111, 397);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(145, 21);
            this.cmbKategori.TabIndex = 17;
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(481, 445);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(145, 23);
            this.btnKategoriGuncelle.TabIndex = 18;
            this.btnKategoriGuncelle.Text = "Kategori Guncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriSil.Location = new System.Drawing.Point(647, 394);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(145, 23);
            this.btnKategoriSil.TabIndex = 19;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.Location = new System.Drawing.Point(481, 394);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(145, 23);
            this.btnKategoriEkle.TabIndex = 20;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategroiListele
            // 
            this.btnKategroiListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategroiListele.Location = new System.Drawing.Point(647, 445);
            this.btnKategroiListele.Name = "btnKategroiListele";
            this.btnKategroiListele.Size = new System.Drawing.Size(145, 23);
            this.btnKategroiListele.TabIndex = 21;
            this.btnKategroiListele.Text = "Kategori Listele";
            this.btnKategroiListele.UseVisualStyleBackColor = true;
            this.btnKategroiListele.Click += new System.EventHandler(this.btnKategroiListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kategorisi";
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(971, 392);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtYazarSoyad.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(861, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Yazar Soyadi";
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarSil.Location = new System.Drawing.Point(1038, 439);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(107, 23);
            this.btnYazarSil.TabIndex = 25;
            this.btnYazarSil.Text = "Yazar Sil";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // btnYazarListele
            // 
            this.btnYazarListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarListele.Location = new System.Drawing.Point(1038, 501);
            this.btnYazarListele.Name = "btnYazarListele";
            this.btnYazarListele.Size = new System.Drawing.Size(107, 23);
            this.btnYazarListele.TabIndex = 26;
            this.btnYazarListele.Text = "Yazar Listele";
            this.btnYazarListele.UseVisualStyleBackColor = true;
            this.btnYazarListele.Click += new System.EventHandler(this.btnYazarListele_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarEkle.Location = new System.Drawing.Point(864, 438);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(127, 23);
            this.btnYazarEkle.TabIndex = 27;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarGuncelle.Location = new System.Drawing.Point(864, 501);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnYazarGuncelle.TabIndex = 28;
            this.btnYazarGuncelle.Text = "Yazar Guncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Yazar";
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(111, 444);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(145, 21);
            this.cmbYazar.TabIndex = 30;
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.Location = new System.Drawing.Point(279, 470);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(136, 23);
            this.btnKitapListele.TabIndex = 31;
            this.btnKitapListele.Text = "Kitap Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(975, 30);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAra.TabIndex = 32;
            // 
            // txtKategoriAra
            // 
            this.txtKategoriAra.Location = new System.Drawing.Point(975, 108);
            this.txtKategoriAra.Name = "txtKategoriAra";
            this.txtKategoriAra.Size = new System.Drawing.Size(100, 20);
            this.txtKategoriAra.TabIndex = 33;
            // 
            // txtYazarAra
            // 
            this.txtYazarAra.Location = new System.Drawing.Point(975, 178);
            this.txtYazarAra.Name = "txtYazarAra";
            this.txtYazarAra.Size = new System.Drawing.Size(100, 20);
            this.txtYazarAra.TabIndex = 34;
            // 
            // btnKategoriAdiAra
            // 
            this.btnKategoriAdiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriAdiAra.Location = new System.Drawing.Point(814, 101);
            this.btnKategoriAdiAra.Name = "btnKategoriAdiAra";
            this.btnKategoriAdiAra.Size = new System.Drawing.Size(136, 32);
            this.btnKategoriAdiAra.TabIndex = 35;
            this.btnKategoriAdiAra.Text = "Kategori Adı";
            this.btnKategoriAdiAra.UseVisualStyleBackColor = true;
            this.btnKategoriAdiAra.Click += new System.EventHandler(this.btnKategoriAdiAra_Click);
            // 
            // btnYazarAdiAra
            // 
            this.btnYazarAdiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarAdiAra.Location = new System.Drawing.Point(814, 178);
            this.btnYazarAdiAra.Name = "btnYazarAdiAra";
            this.btnYazarAdiAra.Size = new System.Drawing.Size(136, 23);
            this.btnYazarAdiAra.TabIndex = 36;
            this.btnYazarAdiAra.Text = "Yazar Adı";
            this.btnYazarAdiAra.UseVisualStyleBackColor = true;
            this.btnYazarAdiAra.Click += new System.EventHandler(this.btnYazarAdiAra_Click);
            // 
            // btnGenelListeleme
            // 
            this.btnGenelListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenelListeleme.Location = new System.Drawing.Point(21, 499);
            this.btnGenelListeleme.Name = "btnGenelListeleme";
            this.btnGenelListeleme.Size = new System.Drawing.Size(235, 29);
            this.btnGenelListeleme.TabIndex = 37;
            this.btnGenelListeleme.Text = "Genel Listeleme";
            this.btnGenelListeleme.UseVisualStyleBackColor = true;
            this.btnGenelListeleme.Click += new System.EventHandler(this.btnGenelListeleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 582);
            this.Controls.Add(this.btnGenelListeleme);
            this.Controls.Add(this.btnYazarAdiAra);
            this.Controls.Add(this.btnKategoriAdiAra);
            this.Controls.Add(this.txtYazarAra);
            this.Controls.Add(this.txtKategoriAra);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnYazarGuncelle);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.btnYazarListele);
            this.Controls.Add(this.btnYazarSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKategroiListele);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnKitapAra);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategroiListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.Button btnYazarListele;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.TextBox txtKategoriAra;
        private System.Windows.Forms.TextBox txtYazarAra;
        private System.Windows.Forms.Button btnKategoriAdiAra;
        private System.Windows.Forms.Button btnYazarAdiAra;
        private System.Windows.Forms.Button btnGenelListeleme;
    }
}

