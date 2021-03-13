
namespace VideoYuzTanimaSistemi
{
    partial class Form1
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
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.btnKameraAc = new System.Windows.Forms.Button();
            this.btnYakala = new System.Windows.Forms.Button();
            this.btnVideoSec = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVideo
            // 
            this.pbVideo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.pbVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbVideo.Location = new System.Drawing.Point(5, 5);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(736, 511);
            this.pbVideo.TabIndex = 0;
            this.pbVideo.TabStop = false;
            // 
            // btnKameraAc
            // 
            this.btnKameraAc.Location = new System.Drawing.Point(766, 45);
            this.btnKameraAc.Name = "btnKameraAc";
            this.btnKameraAc.Size = new System.Drawing.Size(103, 23);
            this.btnKameraAc.TabIndex = 1;
            this.btnKameraAc.Text = "Kamerayı Aç";
            this.btnKameraAc.UseVisualStyleBackColor = true;
            this.btnKameraAc.Click += new System.EventHandler(this.btnKameraAc_Click);
            // 
            // btnYakala
            // 
            this.btnYakala.Location = new System.Drawing.Point(766, 74);
            this.btnYakala.Name = "btnYakala";
            this.btnYakala.Size = new System.Drawing.Size(103, 23);
            this.btnYakala.TabIndex = 2;
            this.btnYakala.Text = "Yüzü Yakala";
            this.btnYakala.UseVisualStyleBackColor = true;
            this.btnYakala.Click += new System.EventHandler(this.btnYakala_Click);
            // 
            // btnVideoSec
            // 
            this.btnVideoSec.Location = new System.Drawing.Point(766, 408);
            this.btnVideoSec.Name = "btnVideoSec";
            this.btnVideoSec.Size = new System.Drawing.Size(103, 23);
            this.btnVideoSec.TabIndex = 4;
            this.btnVideoSec.Text = "Video Seç";
            this.btnVideoSec.UseVisualStyleBackColor = true;
            this.btnVideoSec.Click += new System.EventHandler(this.btnVideoSec_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(747, 437);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(65, 23);
            this.btnBitir.TabIndex = 6;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Location = new System.Drawing.Point(818, 437);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(65, 23);
            this.btnDuraklat.TabIndex = 7;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(789, 187);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 13);
            this.lblSayac.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 518);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnVideoSec);
            this.Controls.Add(this.btnYakala);
            this.Controls.Add(this.btnKameraAc);
            this.Controls.Add(this.pbVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.Button btnKameraAc;
        private System.Windows.Forms.Button btnYakala;
        private System.Windows.Forms.Button btnVideoSec;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Label lblSayac;
    }
}

