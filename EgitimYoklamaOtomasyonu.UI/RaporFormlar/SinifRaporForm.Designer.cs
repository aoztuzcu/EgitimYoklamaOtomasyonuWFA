namespace EgitimYoklamaOtomasyonu.UI.Raporlar
{
    partial class SinifRaporForm
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
            cBSiniflar = new ComboBox();
            cBSubeler = new ComboBox();
            btnFiltrele = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblYapilanDersSaat = new Label();
            lblKalanDersSaat = new Label();
            lblOgrenciSayi = new Label();
            lblEgitmen = new Label();
            btnPdfKaydet = new Button();
            listOgrenci = new ListView();
            clmSiraNo = new ColumnHeader();
            clmOgrenci = new ColumnHeader();
            clmKatildigiDers = new ColumnHeader();
            clmDevamDurum = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Sınıf Seç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 37);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Şube Seç:";
            // 
            // cBSiniflar
            // 
            cBSiniflar.FormattingEnabled = true;
            cBSiniflar.Location = new Point(95, 69);
            cBSiniflar.Name = "cBSiniflar";
            cBSiniflar.Size = new Size(164, 23);
            cBSiniflar.TabIndex = 1;
            // 
            // cBSubeler
            // 
            cBSubeler.FormattingEnabled = true;
            cBSubeler.Location = new Point(95, 34);
            cBSubeler.Name = "cBSubeler";
            cBSubeler.Size = new Size(164, 23);
            cBSubeler.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            btnFiltrele.FlatStyle = FlatStyle.Popup;
            btnFiltrele.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrele.Location = new Point(289, 34);
            btnFiltrele.Margin = new Padding(5, 3, 3, 3);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(137, 58);
            btnFiltrele.TabIndex = 2;
            btnFiltrele.Text = "FİLTRELE";
            btnFiltrele.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 121);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Sınıf Raporu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 185);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 0;
            label4.Text = "Kalan Ders Saati:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 153);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 0;
            label5.Text = "Yapılan Ders Saati:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(241, 153);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "Öğrenci Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(272, 185);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 0;
            label7.Text = "Eğitmen:";
            // 
            // lblYapilanDersSaat
            // 
            lblYapilanDersSaat.AutoSize = true;
            lblYapilanDersSaat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYapilanDersSaat.Location = new Point(181, 153);
            lblYapilanDersSaat.Name = "lblYapilanDersSaat";
            lblYapilanDersSaat.Size = new Size(27, 15);
            lblYapilanDersSaat.TabIndex = 0;
            lblYapilanDersSaat.Text = "????";
            // 
            // lblKalanDersSaat
            // 
            lblKalanDersSaat.AutoSize = true;
            lblKalanDersSaat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKalanDersSaat.Location = new Point(181, 185);
            lblKalanDersSaat.Name = "lblKalanDersSaat";
            lblKalanDersSaat.Size = new Size(27, 15);
            lblKalanDersSaat.TabIndex = 0;
            lblKalanDersSaat.Text = "????";
            // 
            // lblOgrenciSayi
            // 
            lblOgrenciSayi.AutoSize = true;
            lblOgrenciSayi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciSayi.Location = new Point(351, 153);
            lblOgrenciSayi.Name = "lblOgrenciSayi";
            lblOgrenciSayi.Size = new Size(27, 15);
            lblOgrenciSayi.TabIndex = 0;
            lblOgrenciSayi.Text = "????";
            // 
            // lblEgitmen
            // 
            lblEgitmen.AutoSize = true;
            lblEgitmen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEgitmen.Location = new Point(351, 185);
            lblEgitmen.Name = "lblEgitmen";
            lblEgitmen.Size = new Size(27, 15);
            lblEgitmen.TabIndex = 0;
            lblEgitmen.Text = "????";
            // 
            // btnPdfKaydet
            // 
            btnPdfKaydet.FlatStyle = FlatStyle.Popup;
            btnPdfKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdfKaydet.Image = Properties.Resources.Ekran_görüntüsü_2023_08_20_210709;
            btnPdfKaydet.Location = new Point(422, 153);
            btnPdfKaydet.Margin = new Padding(5, 3, 3, 3);
            btnPdfKaydet.Name = "btnPdfKaydet";
            btnPdfKaydet.Size = new Size(137, 58);
            btnPdfKaydet.TabIndex = 2;
            btnPdfKaydet.UseVisualStyleBackColor = true;
            // 
            // listOgrenci
            // 
            listOgrenci.Columns.AddRange(new ColumnHeader[] { clmSiraNo, clmOgrenci, clmKatildigiDers, clmDevamDurum });
            listOgrenci.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listOgrenci.GridLines = true;
            listOgrenci.Location = new Point(20, 223);
            listOgrenci.Name = "listOgrenci";
            listOgrenci.Size = new Size(599, 343);
            listOgrenci.TabIndex = 4;
            listOgrenci.UseCompatibleStateImageBehavior = false;
            listOgrenci.View = View.Details;
            // 
            // clmSiraNo
            // 
            clmSiraNo.Text = "Sıra No";
            // 
            // clmOgrenci
            // 
            clmOgrenci.Text = "Öğrenci Adı Soyadı";
            clmOgrenci.Width = 200;
            // 
            // clmKatildigiDers
            // 
            clmKatildigiDers.Text = "Katıldığı Ders Saati";
            clmKatildigiDers.Width = 130;
            // 
            // clmDevamDurum
            // 
            clmDevamDurum.Text = "Devam Durumu(%)";
            clmDevamDurum.Width = 150;
            // 
            // SinifRaporForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 578);
            Controls.Add(listOgrenci);
            Controls.Add(btnPdfKaydet);
            Controls.Add(btnFiltrele);
            Controls.Add(cBSubeler);
            Controls.Add(cBSiniflar);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblKalanDersSaat);
            Controls.Add(lblEgitmen);
            Controls.Add(lblOgrenciSayi);
            Controls.Add(lblYapilanDersSaat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "SinifRaporForm";
            Text = "SinifRaporForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cBSiniflar;
        private ComboBox cBSubeler;
        private Button btnFiltrele;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblYapilanDersSaat;
        private Label lblKalanDersSaat;
        private Label lblOgrenciSayi;
        private Label lblEgitmen;
        private Button btnPdfKaydet;
        private ListView listOgrenci;
        public ColumnHeader clmSiraNo;
        private ColumnHeader clmOgrenci;
        private ColumnHeader clmKatildigiDers;
        private ColumnHeader clmDevamDurum;
        private ColumnHeader columnHeader1;
    }
}