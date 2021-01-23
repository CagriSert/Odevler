
namespace kutuphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKirtasiye = new System.Windows.Forms.TextBox();
            this.txtKAntin = new System.Windows.Forms.TextBox();
            this.txtOdunc = new System.Windows.Forms.TextBox();
            this.btnToplam = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) Kütüphane Gelir Hesaplayıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kantin Geliri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kırtasiye Geliri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödünç verilen kitaplardan elde ettiği gecikme ücreti:";
            // 
            // txtKirtasiye
            // 
            this.txtKirtasiye.Location = new System.Drawing.Point(479, 55);
            this.txtKirtasiye.Name = "txtKirtasiye";
            this.txtKirtasiye.Size = new System.Drawing.Size(114, 20);
            this.txtKirtasiye.TabIndex = 4;
            this.txtKirtasiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKirtasiye_KeyPress);
            // 
            // txtKAntin
            // 
            this.txtKAntin.Location = new System.Drawing.Point(479, 92);
            this.txtKAntin.Name = "txtKAntin";
            this.txtKAntin.Size = new System.Drawing.Size(114, 20);
            this.txtKAntin.TabIndex = 5;
            this.txtKAntin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKAntin_KeyPress);
            // 
            // txtOdunc
            // 
            this.txtOdunc.Location = new System.Drawing.Point(479, 129);
            this.txtOdunc.Name = "txtOdunc";
            this.txtOdunc.Size = new System.Drawing.Size(114, 20);
            this.txtOdunc.TabIndex = 6;
            this.txtOdunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdunc_KeyPress);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(469, 172);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(135, 23);
            this.btnToplam.TabIndex = 7;
            this.btnToplam.Text = " Toplam Gelir Hesaplayıcı";
            this.btnToplam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(256, 224);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Toplam Gelir:";
            this.lbl1.Visible = false;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(337, 224);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(372, 171);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.txtOdunc);
            this.Controls.Add(this.txtKAntin);
            this.Controls.Add(this.txtKirtasiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKirtasiye;
        private System.Windows.Forms.TextBox txtKAntin;
        private System.Windows.Forms.TextBox txtOdunc;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnTemizle;
    }
}

