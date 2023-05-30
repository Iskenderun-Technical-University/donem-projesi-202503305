namespace Sinema_Otomasyonu
{
    partial class FilmEkle
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
            this.txtfilmadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfilmekle = new System.Windows.Forms.Button();
            this.txtyonetmen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnafisekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbfilmturu = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtyapimyili = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfilmadi
            // 
            this.txtfilmadi.Location = new System.Drawing.Point(126, 30);
            this.txtfilmadi.Name = "txtfilmadi";
            this.txtfilmadi.Size = new System.Drawing.Size(121, 22);
            this.txtfilmadi.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Filmin Adi :";
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfilmekle.Location = new System.Drawing.Point(126, 289);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(121, 39);
            this.btnfilmekle.TabIndex = 28;
            this.btnfilmekle.Text = "Film Ekle";
            this.btnfilmekle.UseVisualStyleBackColor = true;
            this.btnfilmekle.Click += new System.EventHandler(this.btnSalonEkleme_Click);
            // 
            // txtyonetmen
            // 
            this.txtyonetmen.Location = new System.Drawing.Point(126, 76);
            this.txtyonetmen.Name = "txtyonetmen";
            this.txtyonetmen.Size = new System.Drawing.Size(121, 22);
            this.txtyonetmen.TabIndex = 32;
            this.txtyonetmen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Yonetmen :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsure
            // 
            this.txtsure.Location = new System.Drawing.Point(126, 167);
            this.txtsure.Name = "txtsure";
            this.txtsure.Size = new System.Drawing.Size(121, 22);
            this.txtsure.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Suresi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Filmin Turu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Yapım Yılı :";
            // 
            // btnafisekle
            // 
            this.btnafisekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnafisekle.Location = new System.Drawing.Point(274, 289);
            this.btnafisekle.Name = "btnafisekle";
            this.btnafisekle.Size = new System.Drawing.Size(151, 39);
            this.btnafisekle.TabIndex = 39;
            this.btnafisekle.Text = "Afiş Ekle";
            this.btnafisekle.UseVisualStyleBackColor = true;
            this.btnafisekle.Click += new System.EventHandler(this.btnafisekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(274, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 202);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // cmbfilmturu
            // 
            this.cmbfilmturu.FormattingEnabled = true;
            this.cmbfilmturu.Location = new System.Drawing.Point(126, 121);
            this.cmbfilmturu.Name = "cmbfilmturu";
            this.cmbfilmturu.Size = new System.Drawing.Size(121, 24);
            this.cmbfilmturu.TabIndex = 41;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtyapimyili
            // 
            this.txtyapimyili.Location = new System.Drawing.Point(126, 211);
            this.txtyapimyili.Name = "txtyapimyili";
            this.txtyapimyili.Size = new System.Drawing.Size(121, 22);
            this.txtyapimyili.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(16, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tarih :";
            // 
            // datetarih
            // 
            this.datetarih.Location = new System.Drawing.Point(126, 251);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(200, 22);
            this.datetarih.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(464, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 44;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datetarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbfilmturu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnafisekle);
            this.Controls.Add(this.txtyapimyili);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyonetmen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilmadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfilmekle);
            this.Name = "FilmEkle";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfilmadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfilmekle;
        private System.Windows.Forms.TextBox txtyonetmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnafisekle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbfilmturu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtyapimyili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetarih;
        private System.Windows.Forms.Button button1;
    }
}