namespace EgitimYoklamaOtomasyonu.UI
{
    partial class GirisEkranı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMail = new TextBox();
            txtParola = new TextBox();
            checkBoxParolaGoster = new CheckBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "GİRİŞ PANELİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 57);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 0;
            label2.Text = "Mail Adresi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(90, 93);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Parola:";
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(140, 55);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(216, 23);
            txtMail.TabIndex = 1;
            // 
            // txtParola
            // 
            txtParola.BorderStyle = BorderStyle.FixedSingle;
            txtParola.Location = new Point(140, 91);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(216, 23);
            txtParola.TabIndex = 1;
            txtParola.UseSystemPasswordChar = true;
            // 
            // checkBoxParolaGoster
            // 
            checkBoxParolaGoster.AutoSize = true;
            checkBoxParolaGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxParolaGoster.Location = new Point(140, 130);
            checkBoxParolaGoster.Name = "checkBoxParolaGoster";
            checkBoxParolaGoster.Size = new Size(110, 19);
            checkBoxParolaGoster.TabIndex = 2;
            checkBoxParolaGoster.Text = "Parolayı Göster";
            checkBoxParolaGoster.UseVisualStyleBackColor = true;
            checkBoxParolaGoster.CheckedChanged += checkBoxParolaGoster_CheckedChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(140, 155);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(216, 30);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // GirisEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 220);
            Controls.Add(btnGirisYap);
            Controls.Add(checkBoxParolaGoster);
            Controls.Add(txtParola);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GirisEkranı";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMail;
        private TextBox txtParola;
        private CheckBox checkBoxParolaGoster;
        private Button btnGirisYap;
    }
}