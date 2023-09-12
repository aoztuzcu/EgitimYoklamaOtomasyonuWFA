namespace EgitimYoklamaOtomasyonu.UI.EklemeGuncellemeFormlar
{
    partial class SubeEkleGuncelleForm
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
            txtSubeAd = new TextBox();
            txtSubeMail = new TextBox();
            txtTelefon = new MaskedTextBox();
            textBox1 = new TextBox();
            btnSubeEkle = new Button();
            btnSubeGuncelle = new Button();
            btnSubeSil = new Button();
            listView1 = new ListView();
            columnSubeAd = new ColumnHeader();
            columnSubeKoordinator = new ColumnHeader();
            columnSubeMail = new ColumnHeader();
            columnSubeTelefon = new ColumnHeader();
            cBSubeKoordinator = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Şube Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 48);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Şube Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 80);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 0;
            label3.Text = "Şube Koordinatörü:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 115);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Şube Maili:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 153);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 0;
            label5.Text = "Şube Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 48);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 0;
            label6.Text = "Şube Adresi:";
            // 
            // txtSubeAd
            // 
            txtSubeAd.BorderStyle = BorderStyle.FixedSingle;
            txtSubeAd.Location = new Point(142, 45);
            txtSubeAd.Name = "txtSubeAd";
            txtSubeAd.Size = new Size(131, 23);
            txtSubeAd.TabIndex = 1;
            // 
            // txtSubeMail
            // 
            txtSubeMail.BorderStyle = BorderStyle.FixedSingle;
            txtSubeMail.Location = new Point(142, 107);
            txtSubeMail.Name = "txtSubeMail";
            txtSubeMail.Size = new Size(131, 23);
            txtSubeMail.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.Location = new Point(142, 145);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(131, 23);
            txtTelefon.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(420, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(197, 122);
            textBox1.TabIndex = 1;
            // 
            // btnSubeEkle
            // 
            btnSubeEkle.FlatStyle = FlatStyle.Popup;
            btnSubeEkle.Location = new Point(26, 192);
            btnSubeEkle.Name = "btnSubeEkle";
            btnSubeEkle.Size = new Size(174, 37);
            btnSubeEkle.TabIndex = 3;
            btnSubeEkle.Text = "ŞUBE EKLE";
            btnSubeEkle.UseVisualStyleBackColor = true;
            // 
            // btnSubeGuncelle
            // 
            btnSubeGuncelle.FlatStyle = FlatStyle.Popup;
            btnSubeGuncelle.Location = new Point(206, 192);
            btnSubeGuncelle.Name = "btnSubeGuncelle";
            btnSubeGuncelle.Size = new Size(174, 37);
            btnSubeGuncelle.TabIndex = 3;
            btnSubeGuncelle.Text = "ŞUBE GÜNCELLE";
            btnSubeGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSubeSil
            // 
            btnSubeSil.FlatStyle = FlatStyle.Popup;
            btnSubeSil.Location = new Point(420, 192);
            btnSubeSil.Name = "btnSubeSil";
            btnSubeSil.Size = new Size(197, 37);
            btnSubeSil.TabIndex = 3;
            btnSubeSil.Text = "ŞUBE SİL";
            btnSubeSil.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnSubeAd, columnSubeKoordinator, columnSubeMail, columnSubeTelefon });
            listView1.Location = new Point(26, 245);
            listView1.Name = "listView1";
            listView1.Size = new Size(591, 293);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnSubeAd
            // 
            columnSubeAd.Text = "Şube Adı";
            columnSubeAd.Width = 180;
            // 
            // columnSubeKoordinator
            // 
            columnSubeKoordinator.Text = "Şube Koordinatör";
            columnSubeKoordinator.Width = 160;
            // 
            // columnSubeMail
            // 
            columnSubeMail.Text = "Şube MAil";
            columnSubeMail.Width = 120;
            // 
            // columnSubeTelefon
            // 
            columnSubeTelefon.Text = "Şube Telefon";
            columnSubeTelefon.Width = 100;
            // 
            // cBSubeKoordinator
            // 
            cBSubeKoordinator.FlatStyle = FlatStyle.System;
            cBSubeKoordinator.FormattingEnabled = true;
            cBSubeKoordinator.Location = new Point(142, 77);
            cBSubeKoordinator.Name = "cBSubeKoordinator";
            cBSubeKoordinator.Size = new Size(131, 23);
            cBSubeKoordinator.TabIndex = 5;
            // 
            // SubeEkleGuncelleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 550);
            Controls.Add(cBSubeKoordinator);
            Controls.Add(listView1);
            Controls.Add(btnSubeSil);
            Controls.Add(btnSubeGuncelle);
            Controls.Add(btnSubeEkle);
            Controls.Add(txtTelefon);
            Controls.Add(txtSubeMail);
            Controls.Add(textBox1);
            Controls.Add(txtSubeAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "SubeEkleGuncelleForm";
            Text = "SubeEkleGuncelleForm";
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
        private TextBox txtSubeAd;
        private TextBox txtSubeMail;
        private MaskedTextBox txtTelefon;
        private TextBox textBox1;
        private Button btnSubeEkle;
        private Button btnSubeGuncelle;
        private Button btnSubeSil;
        private ListView listView1;
        private ColumnHeader columnSubeAd;
        private ColumnHeader columnSubeKoordinator;
        private ColumnHeader columnSubeMail;
        private ColumnHeader columnSubeTelefon;
        private ComboBox cBSubeKoordinator;
    }
}