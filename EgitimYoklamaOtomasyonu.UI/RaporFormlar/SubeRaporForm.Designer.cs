namespace EgitimYoklamaOtomasyonu.UI
{
    partial class SubeRaporForm
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
            cBSube = new ComboBox();
            label2 = new Label();
            lblOgrenciSayi = new Label();
            lblEgitmenSayi = new Label();
            lblVerilenDersSaati = new Label();
            lblEgitimSayi = new Label();
            lblKoordinatorSayisi = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblVerilenDersEgitmenOrt = new Label();
            btnPdfKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Şube Seç:";
            // 
            // cBSube
            // 
            cBSube.FormattingEnabled = true;
            cBSube.Items.AddRange(new object[] { "aaaaa" });
            cBSube.Location = new Point(12, 36);
            cBSube.Name = "cBSube";
            cBSube.Size = new Size(233, 23);
            cBSube.TabIndex = 1;
            cBSube.SelectedIndexChanged += cBSube_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 0;
            label2.Text = "Şube Raporu";
            // 
            // lblOgrenciSayi
            // 
            lblOgrenciSayi.AutoSize = true;
            lblOgrenciSayi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgrenciSayi.Location = new Point(163, 171);
            lblOgrenciSayi.Name = "lblOgrenciSayi";
            lblOgrenciSayi.Size = new Size(27, 15);
            lblOgrenciSayi.TabIndex = 7;
            lblOgrenciSayi.Text = "????";
            // 
            // lblEgitmenSayi
            // 
            lblEgitmenSayi.AutoSize = true;
            lblEgitmenSayi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEgitmenSayi.Location = new Point(163, 141);
            lblEgitmenSayi.Name = "lblEgitmenSayi";
            lblEgitmenSayi.Size = new Size(27, 15);
            lblEgitmenSayi.TabIndex = 8;
            lblEgitmenSayi.Text = "????";
            // 
            // lblVerilenDersSaati
            // 
            lblVerilenDersSaati.AutoSize = true;
            lblVerilenDersSaati.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerilenDersSaati.Location = new Point(163, 231);
            lblVerilenDersSaati.Name = "lblVerilenDersSaati";
            lblVerilenDersSaati.Size = new Size(27, 15);
            lblVerilenDersSaati.TabIndex = 9;
            lblVerilenDersSaati.Text = "????";
            // 
            // lblEgitimSayi
            // 
            lblEgitimSayi.AutoSize = true;
            lblEgitimSayi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEgitimSayi.Location = new Point(163, 201);
            lblEgitimSayi.Name = "lblEgitimSayi";
            lblEgitimSayi.Size = new Size(27, 15);
            lblEgitimSayi.TabIndex = 10;
            lblEgitimSayi.Text = "????";
            // 
            // lblKoordinatorSayisi
            // 
            lblKoordinatorSayisi.AutoSize = true;
            lblKoordinatorSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKoordinatorSayisi.Location = new Point(163, 111);
            lblKoordinatorSayisi.Name = "lblKoordinatorSayisi";
            lblKoordinatorSayisi.Size = new Size(27, 15);
            lblKoordinatorSayisi.TabIndex = 11;
            lblKoordinatorSayisi.Text = "????";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 171);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 2;
            label6.Text = "Öğrenci Sayısı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 201);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 3;
            label5.Text = "Eğitim Sayısı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 231);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(108, 15);
            label4.TabIndex = 4;
            label4.Text = "Verilen Ders Saati:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 141);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Eğitmen Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 111);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Koordinatör Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(21, 258);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(126, 30);
            label8.TabIndex = 4;
            label8.Text = "Verilen Ders/Eğitmen\r\nOrtalaması:\r\n";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // lblVerilenDersEgitmenOrt
            // 
            lblVerilenDersEgitmenOrt.AutoSize = true;
            lblVerilenDersEgitmenOrt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerilenDersEgitmenOrt.Location = new Point(163, 273);
            lblVerilenDersEgitmenOrt.Name = "lblVerilenDersEgitmenOrt";
            lblVerilenDersEgitmenOrt.Size = new Size(27, 15);
            lblVerilenDersEgitmenOrt.TabIndex = 9;
            lblVerilenDersEgitmenOrt.Text = "????";
            // 
            // btnPdfKaydet
            // 
            btnPdfKaydet.Image = Properties.Resources.Ekran_görüntüsü_2023_08_20_210709;
            btnPdfKaydet.Location = new Point(21, 307);
            btnPdfKaydet.Name = "btnPdfKaydet";
            btnPdfKaydet.Size = new Size(224, 53);
            btnPdfKaydet.TabIndex = 12;
            btnPdfKaydet.UseVisualStyleBackColor = true;
            // 
            // SubeRaporForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 372);
            Controls.Add(btnPdfKaydet);
            Controls.Add(lblOgrenciSayi);
            Controls.Add(lblEgitmenSayi);
            Controls.Add(lblVerilenDersEgitmenOrt);
            Controls.Add(lblVerilenDersSaati);
            Controls.Add(lblEgitimSayi);
            Controls.Add(lblKoordinatorSayisi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(cBSube);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubeRaporForm";
            Text = "SubeRaporForm";
            Load += SubeRaporForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cBSube;
        private Label label2;
        private Label lblOgrenciSayi;
        private Label lblEgitmenSayi;
        private Label lblVerilenDersSaati;
        private Label lblEgitimSayi;
        private Label lblKoordinatorSayisi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label lblVerilenDersEgitmenOrt;
        public Button btnPdfKaydet;
    }
}