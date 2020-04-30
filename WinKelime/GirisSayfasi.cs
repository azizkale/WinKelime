using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WinKelime
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        

        private void button1_Click(object sender, EventArgs e)
        {

            string dosyaismigiris = txtKullaniciAdiGiris.Text + ".xml";
           
            if(File.Exists(dosyaismigiris))
            {
XMLOkuma.XmlOku(txtKullaniciAdiGiris);
                if (txtKullaniciAdiGiris.Text == XMLOkuma.Oyunbilgileri.SelectSingleNode("KullaniciAdi").InnerText && txtSifre.Text == XMLOkuma.Oyunbilgileri.SelectSingleNode(" Sifre").InnerText)
                {                    
                    f1.Show();
                    this.Hide();
                }
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Bu isimde bir kullanici bulunamadı. Yeni hesap oluşturmak ister misiniz?", "Yeni Kullanıcı Hesabı", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    YeniKullaniciForm yk = new YeniKullaniciForm();
                    yk.Show();                   
                    yk.txtKullaniciAdiYeni.Text = txtKullaniciAdiGiris.Text;
                    this.Hide();
                }
                else
                {
                    YeniKullaniciForm yk = new YeniKullaniciForm();
                    yk.Close();
                    this.Show();
                }
            }
        }

      
        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            
        }

        public FlowLayoutPanel flowLayoutPanel1 { get; set; }
    }
}
