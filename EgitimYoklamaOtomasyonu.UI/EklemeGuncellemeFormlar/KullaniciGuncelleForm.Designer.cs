namespace EgitimYoklamaOtomasyonu.UI.EklemeGuncellemeFormlar
{
    partial class KullaniciGuncelleForm
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
            btnResimSec = new Button();
            pictureBox = new PictureBox();
            cBSube = new ComboBox();
            cBGorev = new ComboBox();
            mTxtBoxTelefon = new MaskedTextBox();
            dTpDogumTarih = new DateTimePicker();
            txtSoyad = new TextBox();
            txtFiltreAdSoyad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkBOtoParola = new CheckBox();
            txtParola = new TextBox();
            txtMail = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            label8 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cBGoreveGöreFiltre = new ComboBox();
            btnAramaYap = new Button();
            listView1 = new ListView();
            columnAd = new ColumnHeader();
            columnSoyad = new ColumnHeader();
            columnTelefon = new ColumnHeader();
            columnMail = new ColumnHeader();
            coulmnGorev = new ColumnHeader();
            columnSube = new ColumnHeader();
            txtAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnResimSec
            // 
            btnResimSec.FlatStyle = FlatStyle.Popup;
            btnResimSec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimSec.Location = new Point(287, 181);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(100, 38);
            btnResimSec.TabIndex = 21;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.UseWaitCursor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(287, 50);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 125);
            pictureBox.TabIndex = 20;
            pictureBox.TabStop = false;
            pictureBox.UseWaitCursor = true;
            // 
            // cBSube
            // 
            cBSube.FormattingEnabled = true;
            cBSube.Location = new Point(134, 196);
            cBSube.Name = "cBSube";
            cBSube.Size = new Size(135, 23);
            cBSube.TabIndex = 18;
            cBSube.UseWaitCursor = true;
            // 
            // cBGorev
            // 
            cBGorev.FormattingEnabled = true;
            cBGorev.Location = new Point(134, 160);
            cBGorev.Name = "cBGorev";
            cBGorev.Size = new Size(135, 23);
            cBGorev.TabIndex = 19;
            cBGorev.UseWaitCursor = true;
            // 
            // mTxtBoxTelefon
            // 
            mTxtBoxTelefon.BorderStyle = BorderStyle.FixedSingle;
            mTxtBoxTelefon.Location = new Point(134, 131);
            mTxtBoxTelefon.Mask = "(999) 000-0000";
            mTxtBoxTelefon.Name = "mTxtBoxTelefon";
            mTxtBoxTelefon.Size = new Size(135, 23);
            mTxtBoxTelefon.TabIndex = 17;
            mTxtBoxTelefon.UseWaitCursor = true;
            // 
            // dTpDogumTarih
            // 
            dTpDogumTarih.Format = DateTimePickerFormat.Short;
            dTpDogumTarih.Location = new Point(134, 103);
            dTpDogumTarih.Name = "dTpDogumTarih";
            dTpDogumTarih.Size = new Size(135, 23);
            dTpDogumTarih.TabIndex = 16;
            dTpDogumTarih.UseWaitCursor = true;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Location = new Point(134, 76);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(135, 23);
            txtSoyad.TabIndex = 14;
            txtSoyad.UseWaitCursor = true;
            // 
            // txtFiltreAdSoyad
            // 
            txtFiltreAdSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtFiltreAdSoyad.Location = new Point(146, 265);
            txtFiltreAdSoyad.Name = "txtFiltreAdSoyad";
            txtFiltreAdSoyad.Size = new Size(135, 23);
            txtFiltreAdSoyad.TabIndex = 15;
            txtFiltreAdSoyad.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(70, 204);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 7;
            label7.Text = "Şubesi:";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(70, 160);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 8;
            label6.Text = "Görevi:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 128);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 9;
            label5.Text = "Cep Telefonu:";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 103);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 10;
            label4.Text = "Doğum Tarihi:";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 78);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 11;
            label3.Text = "Soyadı:";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 12;
            label2.Text = "Adı:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Bilgileri";
            label1.UseWaitCursor = true;
            // 
            // chkBOtoParola
            // 
            chkBOtoParola.AutoSize = true;
            chkBOtoParola.Location = new Point(604, 129);
            chkBOtoParola.Name = "chkBOtoParola";
            chkBOtoParola.Size = new Size(15, 14);
            chkBOtoParola.TabIndex = 28;
            chkBOtoParola.UseVisualStyleBackColor = true;
            chkBOtoParola.UseWaitCursor = true;
            // 
            // txtParola
            // 
            txtParola.BorderStyle = BorderStyle.FixedSingle;
            txtParola.Location = new Point(502, 85);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(135, 23);
            txtParola.TabIndex = 26;
            txtParola.UseWaitCursor = true;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(502, 50);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(135, 23);
            txtMail.TabIndex = 27;
            txtMail.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(452, 87);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 22;
            label10.Text = "Parola:";
            label10.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(425, 50);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 23;
            label9.Text = "Mail Adresi:";
            label9.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(452, 128);
            label11.Name = "label11";
            label11.Size = new Size(146, 15);
            label11.TabIndex = 24;
            label11.Text = "Parolayı otomatik oluştur";
            label11.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(425, 22);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 25;
            label8.Text = "Üyelik Bilgileri";
            label8.UseWaitCursor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.Popup;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(425, 181);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 38);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "KULLANICI GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.UseWaitCursor = true;
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(537, 181);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 38);
            btnSil.TabIndex = 21;
            btnSil.Text = "KULLANICI SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(19, 240);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 13;
            label12.Text = "Arama";
            label12.UseWaitCursor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(33, 267);
            label13.Name = "label13";
            label13.Size = new Size(106, 15);
            label13.TabIndex = 13;
            label13.Text = "Ada/Soyada Göre:";
            label13.UseWaitCursor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(311, 267);
            label14.Name = "label14";
            label14.Size = new Size(80, 15);
            label14.TabIndex = 13;
            label14.Text = "Göreve Göre";
            label14.UseWaitCursor = true;
            // 
            // cBGoreveGöreFiltre
            // 
            cBGoreveGöreFiltre.FormattingEnabled = true;
            cBGoreveGöreFiltre.Location = new Point(391, 264);
            cBGoreveGöreFiltre.Name = "cBGoreveGöreFiltre";
            cBGoreveGöreFiltre.Size = new Size(121, 23);
            cBGoreveGöreFiltre.TabIndex = 29;
            // 
            // btnAramaYap
            // 
            btnAramaYap.FlatStyle = FlatStyle.Popup;
            btnAramaYap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAramaYap.Location = new Point(531, 267);
            btnAramaYap.Name = "btnAramaYap";
            btnAramaYap.Size = new Size(106, 23);
            btnAramaYap.TabIndex = 21;
            btnAramaYap.Text = "Arama Yap";
            btnAramaYap.UseVisualStyleBackColor = true;
            btnAramaYap.UseWaitCursor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnAd, columnSoyad, columnTelefon, columnMail, coulmnGorev, columnSube });
            listView1.Location = new Point(19, 296);
            listView1.Name = "listView1";
            listView1.Size = new Size(618, 238);
            listView1.TabIndex = 30;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnAd
            // 
            columnAd.Text = "Ad";
            columnAd.Width = 150;
            // 
            // columnSoyad
            // 
            columnSoyad.Text = "Soyadı";
            columnSoyad.Width = 120;
            // 
            // columnTelefon
            // 
            columnTelefon.Text = "Cep Telefonu";
            columnTelefon.Width = 120;
            // 
            // columnMail
            // 
            columnMail.Text = "Mail Adresi";
            columnMail.Width = 100;
            // 
            // coulmnGorev
            // 
            coulmnGorev.Text = "Görevi";
            coulmnGorev.Width = 75;
            // 
            // columnSube
            // 
            columnSube.Text = "Şubesi";
            columnSube.Width = 75;
            // 
            // txtAdi
            // 
            txtAdi.BorderStyle = BorderStyle.FixedSingle;
            txtAdi.Location = new Point(134, 47);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(135, 23);
            txtAdi.TabIndex = 14;
            txtAdi.UseWaitCursor = true;
            // 
            // KullaniciGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 537);
            Controls.Add(listView1);
            Controls.Add(cBGoreveGöreFiltre);
            Controls.Add(chkBOtoParola);
            Controls.Add(txtParola);
            Controls.Add(txtMail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(btnSil);
            Controls.Add(btnAramaYap);
            Controls.Add(btnGuncelle);
            Controls.Add(btnResimSec);
            Controls.Add(pictureBox);
            Controls.Add(cBSube);
            Controls.Add(cBGorev);
            Controls.Add(mTxtBoxTelefon);
            Controls.Add(dTpDogumTarih);
            Controls.Add(txtAdi);
            Controls.Add(txtSoyad);
            Controls.Add(txtFiltreAdSoyad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label1);
            Cursor = Cursors.Arrow;
            Name = "KullaniciGuncelleForm";
            Text = "KullaniciGuncelleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResimSec;
        private PictureBox pictureBox;
        private ComboBox cBSube;
        private ComboBox cBGorev;
        private MaskedTextBox mTxtBoxTelefon;
        private DateTimePicker dTpDogumTarih;
        private TextBox txtSoyad;
        private TextBox txtFiltreAdSoyad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkBOtoParola;
        private TextBox txtParola;
        private TextBox txtMail;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label8;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cBGoreveGöreFiltre;
        private Button btnAramaYap;
        private ListView listView1;
        public ColumnHeader columnAd;
        private ColumnHeader columnSoyad;
        private ColumnHeader columnTelefon;
        private ColumnHeader columnMail;
        private ColumnHeader coulmnGorev;
        private ColumnHeader columnSube;
        private TextBox txtAdi;
    }
}