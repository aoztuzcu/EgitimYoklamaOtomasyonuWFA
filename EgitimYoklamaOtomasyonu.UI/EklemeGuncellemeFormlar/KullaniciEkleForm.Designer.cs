namespace EgitimYoklamaOtomasyonu.UI.EklemeIslem
{
    partial class KullaniciEkleForm
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
            txtAdi = new TextBox();
            txtSoyad = new TextBox();
            dTpDogumTarih = new DateTimePicker();
            mTxtBoxTelefon = new MaskedTextBox();
            cBGorev = new ComboBox();
            cBSube = new ComboBox();
            pictureBox = new PictureBox();
            btnResimSec = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtMail = new TextBox();
            txtParola = new TextBox();
            label11 = new Label();
            chkBOtoParola = new CheckBox();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Bilgileri";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 60);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 0;
            label2.Text = "Adı:";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 85);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyadı:";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 110);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Doğum Tarihi:";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 135);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 0;
            label5.Text = "Cep Telefonu:";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(90, 167);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 0;
            label6.Text = "Görevi:";
            label6.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(90, 211);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 0;
            label7.Text = "Şubesi:";
            label7.UseWaitCursor = true;
            // 
            // txtAdi
            // 
            txtAdi.BorderStyle = BorderStyle.FixedSingle;
            txtAdi.Location = new Point(154, 57);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(135, 23);
            txtAdi.TabIndex = 1;
            txtAdi.UseWaitCursor = true;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Location = new Point(154, 83);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(135, 23);
            txtSoyad.TabIndex = 1;
            txtSoyad.UseWaitCursor = true;
            // 
            // dTpDogumTarih
            // 
            dTpDogumTarih.Format = DateTimePickerFormat.Short;
            dTpDogumTarih.Location = new Point(154, 110);
            dTpDogumTarih.Name = "dTpDogumTarih";
            dTpDogumTarih.Size = new Size(135, 23);
            dTpDogumTarih.TabIndex = 2;
            dTpDogumTarih.UseWaitCursor = true;
            // 
            // mTxtBoxTelefon
            // 
            mTxtBoxTelefon.BorderStyle = BorderStyle.FixedSingle;
            mTxtBoxTelefon.Location = new Point(154, 138);
            mTxtBoxTelefon.Mask = "(999) 000-0000";
            mTxtBoxTelefon.Name = "mTxtBoxTelefon";
            mTxtBoxTelefon.Size = new Size(135, 23);
            mTxtBoxTelefon.TabIndex = 3;
            mTxtBoxTelefon.UseWaitCursor = true;
            // 
            // cBGorev
            // 
            cBGorev.FormattingEnabled = true;
            cBGorev.Location = new Point(154, 167);
            cBGorev.Name = "cBGorev";
            cBGorev.Size = new Size(135, 23);
            cBGorev.TabIndex = 4;
            cBGorev.UseWaitCursor = true;
            // 
            // cBSube
            // 
            cBSube.FormattingEnabled = true;
            cBSube.Location = new Point(154, 203);
            cBSube.Name = "cBSube";
            cBSube.Size = new Size(135, 23);
            cBSube.TabIndex = 4;
            cBSube.UseWaitCursor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(307, 57);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 125);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            pictureBox.UseWaitCursor = true;
            // 
            // btnResimSec
            // 
            btnResimSec.FlatStyle = FlatStyle.Popup;
            btnResimSec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimSec.Location = new Point(307, 188);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(100, 38);
            btnResimSec.TabIndex = 6;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(434, 29);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 0;
            label8.Text = "Üyelik Bilgileri";
            label8.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(434, 57);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 0;
            label9.Text = "Mail Adresi:";
            label9.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(461, 94);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 0;
            label10.Text = "Parola:";
            label10.UseWaitCursor = true;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(511, 57);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(135, 23);
            txtMail.TabIndex = 1;
            txtMail.UseWaitCursor = true;
            // 
            // txtParola
            // 
            txtParola.BorderStyle = BorderStyle.FixedSingle;
            txtParola.Location = new Point(511, 92);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(135, 23);
            txtParola.TabIndex = 1;
            txtParola.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(461, 135);
            label11.Name = "label11";
            label11.Size = new Size(146, 15);
            label11.TabIndex = 0;
            label11.Text = "Parolayı otomatik oluştur";
            label11.UseWaitCursor = true;
            // 
            // chkBOtoParola
            // 
            chkBOtoParola.AutoSize = true;
            chkBOtoParola.Location = new Point(613, 136);
            chkBOtoParola.Name = "chkBOtoParola";
            chkBOtoParola.Size = new Size(15, 14);
            chkBOtoParola.TabIndex = 7;
            chkBOtoParola.UseVisualStyleBackColor = true;
            chkBOtoParola.UseWaitCursor = true;
            // 
            // btnEkle
            // 
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(434, 167);
            btnEkle.Name = "btnEkle";
            btnEkle.RightToLeft = RightToLeft.No;
            btnEkle.Size = new Size(212, 56);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "KULLANICI EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.UseWaitCursor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // KullaniciEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 235);
            Controls.Add(chkBOtoParola);
            Controls.Add(btnEkle);
            Controls.Add(btnResimSec);
            Controls.Add(pictureBox);
            Controls.Add(cBSube);
            Controls.Add(cBGorev);
            Controls.Add(mTxtBoxTelefon);
            Controls.Add(dTpDogumTarih);
            Controls.Add(txtSoyad);
            Controls.Add(txtParola);
            Controls.Add(txtMail);
            Controls.Add(txtAdi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "KullaniciEkleForm";
            Text = "KullaniciEkleForm";
            UseWaitCursor = true;
            Load += KullaniciEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
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
        private TextBox txtAdi;
        private TextBox txtSoyad;
        private DateTimePicker dTpDogumTarih;
        private MaskedTextBox mTxtBoxTelefon;
        private ComboBox cBGorev;
        private ComboBox cBSube;
        private PictureBox pictureBox;
        private Button btnResimSec;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtMail;
        private TextBox txtParola;
        private Label label11;
        private CheckBox chkBOtoParola;
        private Button btnEkle;
    }
}