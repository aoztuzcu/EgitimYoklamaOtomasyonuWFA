namespace EgitimYoklamaOtomasyonu.UI.EklemeGuncellemeFormlar
{
    partial class SinifEkleGuncelleForm
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblSubeAd = new Label();
            txtSinifKod = new TextBox();
            cBEgitmen = new ComboBox();
            cBEgitim = new ComboBox();
            dateTimeBaslangıc = new DateTimePicker();
            dateTimeBitis = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtBaslangicSaat = new MaskedTextBox();
            txtBitisSaat = new MaskedTextBox();
            chkListBoxGunler = new CheckedListBox();
            btnSinifEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            listView1 = new ListView();
            columnSinifKod = new ColumnHeader();
            columnEgitim = new ColumnHeader();
            columnBaslangicTarih = new ColumnHeader();
            columnBitisTarih = new ColumnHeader();
            columnEgitmen = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Sınıf Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Sınıf Kodu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 73);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Başlangıç Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 108);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Eğitmen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(78, 142);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Eğitim:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(56, 171);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Bitiş Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(85, 201);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "Şube:";
            // 
            // lblSubeAd
            // 
            lblSubeAd.AutoSize = true;
            lblSubeAd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubeAd.Location = new Point(139, 201);
            lblSubeAd.Name = "lblSubeAd";
            lblSubeAd.Size = new Size(27, 15);
            lblSubeAd.TabIndex = 0;
            lblSubeAd.Text = "????";
            // 
            // txtSinifKod
            // 
            txtSinifKod.BorderStyle = BorderStyle.FixedSingle;
            txtSinifKod.Location = new Point(132, 43);
            txtSinifKod.Name = "txtSinifKod";
            txtSinifKod.Size = new Size(118, 23);
            txtSinifKod.TabIndex = 1;
            // 
            // cBEgitmen
            // 
            cBEgitmen.FormattingEnabled = true;
            cBEgitmen.Location = new Point(132, 105);
            cBEgitmen.Name = "cBEgitmen";
            cBEgitmen.Size = new Size(121, 23);
            cBEgitmen.TabIndex = 2;
            // 
            // cBEgitim
            // 
            cBEgitim.FormattingEnabled = true;
            cBEgitim.Location = new Point(132, 139);
            cBEgitim.Name = "cBEgitim";
            cBEgitim.Size = new Size(121, 23);
            cBEgitim.TabIndex = 2;
            // 
            // dateTimeBaslangıc
            // 
            dateTimeBaslangıc.Format = DateTimePickerFormat.Short;
            dateTimeBaslangıc.Location = new Point(132, 73);
            dateTimeBaslangıc.Name = "dateTimeBaslangıc";
            dateTimeBaslangıc.Size = new Size(118, 23);
            dateTimeBaslangıc.TabIndex = 3;
            // 
            // dateTimeBitis
            // 
            dateTimeBitis.Format = DateTimePickerFormat.Short;
            dateTimeBitis.Location = new Point(132, 168);
            dateTimeBitis.Name = "dateTimeBitis";
            dateTimeBitis.Size = new Size(118, 23);
            dateTimeBitis.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(303, 19);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 0;
            label8.Text = "Eğitim Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(325, 55);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 0;
            label9.Text = "Eğitim Günleri";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(462, 55);
            label10.Name = "label10";
            label10.Size = new Size(79, 30);
            label10.TabIndex = 0;
            label10.Text = "Eğitim Süresi\r\n(Saat/Gün)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(462, 92);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 0;
            label11.Text = "Başlangıç-Bitiş Saati:";
            // 
            // txtBaslangicSaat
            // 
            txtBaslangicSaat.BorderStyle = BorderStyle.FixedSingle;
            txtBaslangicSaat.Location = new Point(462, 119);
            txtBaslangicSaat.Mask = "90:00";
            txtBaslangicSaat.Name = "txtBaslangicSaat";
            txtBaslangicSaat.Size = new Size(49, 23);
            txtBaslangicSaat.TabIndex = 4;
            txtBaslangicSaat.TextAlign = HorizontalAlignment.Center;
            txtBaslangicSaat.ValidatingType = typeof(DateTime);
            // 
            // txtBitisSaat
            // 
            txtBitisSaat.BorderStyle = BorderStyle.FixedSingle;
            txtBitisSaat.Location = new Point(533, 119);
            txtBitisSaat.Mask = "90:00";
            txtBitisSaat.Name = "txtBitisSaat";
            txtBitisSaat.Size = new Size(49, 23);
            txtBitisSaat.TabIndex = 4;
            txtBitisSaat.TextAlign = HorizontalAlignment.Center;
            txtBitisSaat.ValidatingType = typeof(DateTime);
            // 
            // chkListBoxGunler
            // 
            chkListBoxGunler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkListBoxGunler.FormattingEnabled = true;
            chkListBoxGunler.Items.AddRange(new object[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" });
            chkListBoxGunler.Location = new Point(325, 73);
            chkListBoxGunler.Name = "chkListBoxGunler";
            chkListBoxGunler.Size = new Size(120, 130);
            chkListBoxGunler.TabIndex = 5;
            // 
            // btnSinifEkle
            // 
            btnSinifEkle.FlatStyle = FlatStyle.Popup;
            btnSinifEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSinifEkle.Location = new Point(56, 241);
            btnSinifEkle.Name = "btnSinifEkle";
            btnSinifEkle.Size = new Size(155, 45);
            btnSinifEkle.TabIndex = 6;
            btnSinifEkle.Text = "SINIF EKLE";
            btnSinifEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.Popup;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(237, 241);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(153, 45);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "SINIF GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(408, 241);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(174, 45);
            btnSil.TabIndex = 6;
            btnSil.Text = "SINIF SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnSinifKod, columnEgitim, columnBaslangicTarih, columnBitisTarih, columnEgitmen });
            listView1.Location = new Point(29, 310);
            listView1.Name = "listView1";
            listView1.Size = new Size(553, 228);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnSinifKod
            // 
            columnSinifKod.Text = "Sınıf Kodu";
            columnSinifKod.Width = 90;
            // 
            // columnEgitim
            // 
            columnEgitim.Text = "Eğitim";
            columnEgitim.Width = 130;
            // 
            // columnBaslangicTarih
            // 
            columnBaslangicTarih.Text = "Başlangıç Tarihi";
            columnBaslangicTarih.Width = 130;
            // 
            // columnBitisTarih
            // 
            columnBitisTarih.Text = "Bitiş Tarihi";
            columnBitisTarih.Width = 130;
            // 
            // columnEgitmen
            // 
            columnEgitmen.Text = "Eğitmen";
            columnEgitmen.Width = 80;
            // 
            // SinifEkleGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 550);
            Controls.Add(listView1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSinifEkle);
            Controls.Add(chkListBoxGunler);
            Controls.Add(txtBitisSaat);
            Controls.Add(txtBaslangicSaat);
            Controls.Add(dateTimeBitis);
            Controls.Add(dateTimeBaslangıc);
            Controls.Add(cBEgitim);
            Controls.Add(cBEgitmen);
            Controls.Add(txtSinifKod);
            Controls.Add(lblSubeAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "SinifEkleGuncelleForm";
            Text = "SinifEkleGuncelleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblSubeAd;
        private TextBox txtSinifKod;
        private ComboBox cBEgitmen;
        private ComboBox cBEgitim;
        private DateTimePicker dateTimeBaslangıc;
        private DateTimePicker dateTimeBitis;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox txtBaslangicSaat;
        private MaskedTextBox txtBitisSaat;
        private CheckedListBox chkListBoxGunler;
        private Button btnSinifEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private ListView listView1;
        private ColumnHeader columnSinifKod;
        private ColumnHeader columnEgitim;
        private ColumnHeader columnBaslangicTarih;
        private ColumnHeader columnBitisTarih;
        private ColumnHeader columnEgitmen;
    }
}