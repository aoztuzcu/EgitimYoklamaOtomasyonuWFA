namespace EgitimYoklamaOtomasyonu.UI.EklemeIslem
{
    partial class YoklamaEkleForm
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
            lblSube = new Label();
            label3 = new Label();
            label4 = new Label();
            cBSinif = new ComboBox();
            dTPTarih = new DateTimePicker();
            btnYoklamaBul = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            btnHicSecme = new Button();
            btnYoklamaGir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Yoklama Bul";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 70);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Şube";
            // 
            // lblSube
            // 
            lblSube.AutoSize = true;
            lblSube.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSube.Location = new Point(54, 102);
            lblSube.Name = "lblSube";
            lblSube.Size = new Size(27, 15);
            lblSube.TabIndex = 0;
            lblSube.Text = "????";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 70);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Sınıf:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(300, 70);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 0;
            label4.Text = "Tarih";
            // 
            // cBSinif
            // 
            cBSinif.FormattingEnabled = true;
            cBSinif.Location = new Point(117, 99);
            cBSinif.Name = "cBSinif";
            cBSinif.Size = new Size(121, 23);
            cBSinif.TabIndex = 1;
            // 
            // dTPTarih
            // 
            dTPTarih.Format = DateTimePickerFormat.Short;
            dTPTarih.Location = new Point(281, 99);
            dTPTarih.Name = "dTPTarih";
            dTPTarih.Size = new Size(110, 23);
            dTPTarih.TabIndex = 2;
            // 
            // btnYoklamaBul
            // 
            btnYoklamaBul.FlatStyle = FlatStyle.Popup;
            btnYoklamaBul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoklamaBul.Location = new Point(408, 70);
            btnYoklamaBul.Name = "btnYoklamaBul";
            btnYoklamaBul.Size = new Size(123, 55);
            btnYoklamaBul.TabIndex = 3;
            btnYoklamaBul.Text = "Yoklama Bul";
            btnYoklamaBul.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(37, 142);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(584, 364);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(37, 533);
            button1.Name = "button1";
            button1.Size = new Size(153, 55);
            button1.TabIndex = 3;
            button1.Text = "TÜM ÖĞRENCİLERİ SEÇ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnHicSecme
            // 
            btnHicSecme.FlatStyle = FlatStyle.Popup;
            btnHicSecme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHicSecme.Location = new Point(211, 533);
            btnHicSecme.Name = "btnHicSecme";
            btnHicSecme.Size = new Size(123, 55);
            btnHicSecme.TabIndex = 3;
            btnHicSecme.Text = "HİÇBİRİNİ SEÇME";
            btnHicSecme.UseVisualStyleBackColor = true;
            // 
            // btnYoklamaGir
            // 
            btnYoklamaGir.FlatStyle = FlatStyle.Popup;
            btnYoklamaGir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnYoklamaGir.Location = new Point(440, 533);
            btnYoklamaGir.Name = "btnYoklamaGir";
            btnYoklamaGir.Size = new Size(181, 55);
            btnYoklamaGir.TabIndex = 3;
            btnYoklamaGir.Text = "YOKLAMA GİR";
            btnYoklamaGir.UseVisualStyleBackColor = true;
            // 
            // YoklamaEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 600);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnYoklamaGir);
            Controls.Add(btnHicSecme);
            Controls.Add(button1);
            Controls.Add(btnYoklamaBul);
            Controls.Add(dTPTarih);
            Controls.Add(cBSinif);
            Controls.Add(lblSube);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YoklamaEkleForm";
            Text = "YoklamaEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSube;
        private Label label3;
        private Label label4;
        private ComboBox cBSinif;
        private DateTimePicker dTPTarih;
        private Button btnYoklamaBul;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnHicSecme;
        private Button btnYoklamaGir;
    }
}