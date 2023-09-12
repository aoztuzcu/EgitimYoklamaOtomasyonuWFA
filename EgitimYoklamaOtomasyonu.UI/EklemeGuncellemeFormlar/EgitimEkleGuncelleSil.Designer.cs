namespace EgitimYoklamaOtomasyonu.UI.EklemeGuncellemeFormlar
{
    partial class EgitimEkleGuncelleSil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAciklama = new TextBox();
            txtEgitimAdi = new TextBox();
            nUDEgitimSure = new NumericUpDown();
            label5 = new Label();
            btnEgitimEkle = new Button();
            btnEgitimGuncelle = new Button();
            btnEgitimSil = new Button();
            listView1 = new ListView();
            columnEgitimAdi = new ColumnHeader();
            columnEgitimSure = new ColumnHeader();
            columnAciklama = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)nUDEgitimSure).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Eğitim Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 45);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Eğitim Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 81);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Eğitim Süresi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(321, 45);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 0;
            label4.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            txtAciklama.BorderStyle = BorderStyle.FixedSingle;
            txtAciklama.Location = new Point(394, 46);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(227, 50);
            txtAciklama.TabIndex = 1;
            // 
            // txtEgitimAdi
            // 
            txtEgitimAdi.BorderStyle = BorderStyle.FixedSingle;
            txtEgitimAdi.Location = new Point(145, 43);
            txtEgitimAdi.Name = "txtEgitimAdi";
            txtEgitimAdi.Size = new Size(129, 23);
            txtEgitimAdi.TabIndex = 1;
            // 
            // nUDEgitimSure
            // 
            nUDEgitimSure.BorderStyle = BorderStyle.FixedSingle;
            nUDEgitimSure.Location = new Point(145, 79);
            nUDEgitimSure.Name = "nUDEgitimSure";
            nUDEgitimSure.Size = new Size(57, 23);
            nUDEgitimSure.TabIndex = 2;
            nUDEgitimSure.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(208, 87);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 0;
            label5.Text = "saat";
            // 
            // btnEgitimEkle
            // 
            btnEgitimEkle.FlatStyle = FlatStyle.Popup;
            btnEgitimEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEgitimEkle.Location = new Point(394, 112);
            btnEgitimEkle.Name = "btnEgitimEkle";
            btnEgitimEkle.Size = new Size(62, 49);
            btnEgitimEkle.TabIndex = 3;
            btnEgitimEkle.Text = "Eğitim Ekle";
            btnEgitimEkle.UseVisualStyleBackColor = true;
            // 
            // btnEgitimGuncelle
            // 
            btnEgitimGuncelle.FlatStyle = FlatStyle.Popup;
            btnEgitimGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEgitimGuncelle.Location = new Point(478, 112);
            btnEgitimGuncelle.Name = "btnEgitimGuncelle";
            btnEgitimGuncelle.Size = new Size(66, 49);
            btnEgitimGuncelle.TabIndex = 3;
            btnEgitimGuncelle.Text = "Eğitim Güncelle";
            btnEgitimGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEgitimSil
            // 
            btnEgitimSil.FlatStyle = FlatStyle.Popup;
            btnEgitimSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEgitimSil.Location = new Point(559, 112);
            btnEgitimSil.Name = "btnEgitimSil";
            btnEgitimSil.Size = new Size(62, 49);
            btnEgitimSil.TabIndex = 3;
            btnEgitimSil.Text = "Eğitim Sil";
            btnEgitimSil.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnEgitimAdi, columnEgitimSure, columnAciklama });
            listView1.Location = new Point(21, 181);
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 257);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnEgitimAdi
            // 
            columnEgitimAdi.Text = "Eğitim Adı";
            columnEgitimAdi.Width = 150;
            // 
            // columnEgitimSure
            // 
            columnEgitimSure.Text = "Eğitim Süresi(saat)";
            columnEgitimSure.Width = 150;
            // 
            // columnAciklama
            // 
            columnAciklama.Text = "Açıklama";
            columnAciklama.Width = 250;
            // 
            // EgitimEkleGuncelleSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(listView1);
            Controls.Add(btnEgitimSil);
            Controls.Add(btnEgitimGuncelle);
            Controls.Add(btnEgitimEkle);
            Controls.Add(nUDEgitimSure);
            Controls.Add(txtEgitimAdi);
            Controls.Add(txtAciklama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EgitimEkleGuncelleSil";
            Text = "EgitimEkleGuncelleSil";
            ((System.ComponentModel.ISupportInitialize)nUDEgitimSure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAciklama;
        private TextBox txtEgitimAdi;
        private NumericUpDown nUDEgitimSure;
        private Label label5;
        private Button btnEgitimEkle;
        private Button btnEgitimGuncelle;
        private Button btnEgitimSil;
        private ListView listView1;
        private ColumnHeader columnEgitimAdi;
        private ColumnHeader columnEgitimSure;
        private ColumnHeader columnAciklama;
    }
}