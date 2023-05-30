namespace Sinema_Otomasyonu
{
    partial class SalonEkle
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
            this.txtSalonAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalonEkleme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Location = new System.Drawing.Point(149, 47);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Size = new System.Drawing.Size(121, 22);
            this.txtSalonAdi.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Salon Adi :";
            // 
            // btnSalonEkleme
            // 
            this.btnSalonEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkleme.Location = new System.Drawing.Point(153, 105);
            this.btnSalonEkleme.Name = "btnSalonEkleme";
            this.btnSalonEkleme.Size = new System.Drawing.Size(141, 56);
            this.btnSalonEkleme.TabIndex = 25;
            this.btnSalonEkleme.Text = "Salon Ekle";
            this.btnSalonEkleme.UseVisualStyleBackColor = true;
            this.btnSalonEkleme.Click += new System.EventHandler(this.btnSalonEkleme_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(295, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 234);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSalonAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalonEkleme);
            this.Name = "SalonEkle";
            this.Text = "SalonEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalonEkle_FormClosing);
            this.Load += new System.EventHandler(this.SalonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalonEkleme;
        private System.Windows.Forms.Button button2;
    }
}