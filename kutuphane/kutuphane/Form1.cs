using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtKirtasiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKAntin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOdunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            if(txtKirtasiye.Text != "" && txtKAntin.Text != "" && txtOdunc.Text != "")
            {
                int sonuc = hesapla();
                lbl1.Visible = true;
                lblSonuc.Visible = true;
                lblSonuc.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Tüm Boşlukları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl1.Visible = false;
                lblSonuc.Visible = false;
            }
        }
        int hesapla()
        {
            int kirtasiye = Convert.ToInt32(txtKirtasiye.Text);
            int kantin = Convert.ToInt32(txtKAntin.Text);
            int odunc = Convert.ToInt32(txtOdunc.Text);
            int sonuc = kirtasiye + kantin + odunc;

            return sonuc;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void temizle()
        {
            txtKAntin.Text = "";
            txtKirtasiye.Text = "";
            txtOdunc.Text = "";
            lbl1.Visible = false;
            lblSonuc.Visible = false;
        }
    }
}
