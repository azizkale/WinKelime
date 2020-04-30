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
    public partial class YeniKullaniciForm : Form
    {
        public YeniKullaniciForm()
        {
            InitializeComponent();
        }
        //public static string DosyaIsmi;
        private void button1_Click(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();
            //DosyaIsmi = txtKullaniciAdiYeni.Text + ".xml";
            if (!File.Exists(txtKullaniciAdiYeni.Text + ".xml"))
            {
                XmlElement Oyunbilgileri = doc.CreateElement("Oyunbilgileri");
                doc.AppendChild(Oyunbilgileri);
                XmlElement KullaniciAdi = doc.CreateElement("KullaniciAdi");
                KullaniciAdi.InnerText = txtKullaniciAdiYeni.Text;
                Oyunbilgileri.AppendChild(KullaniciAdi);
                XmlElement Sifre = doc.CreateElement("Sifre");
                Sifre.InnerText = txtSifre.Text;
                Oyunbilgileri.AppendChild(Sifre);
                XmlElement Sayac = doc.CreateElement("sayac");
                Sayac.InnerText = "1";
                Oyunbilgileri.AppendChild(Sayac);
                XmlElement Skor = doc.CreateElement("Skor");
                Skor.InnerText = "0";
                Oyunbilgileri.AppendChild(Skor);
                XmlElement KutuHarfleri = doc.CreateElement("KutuHarfleri");
                Oyunbilgileri.AppendChild(KutuHarfleri);
                XmlElement AltKutuHarfleri = doc.CreateElement("AltKutuHarfleri");
                Oyunbilgileri.AppendChild(AltKutuHarfleri);
                XmlElement listbox = doc.CreateElement("listbox");
                Oyunbilgileri.AppendChild(listbox);
                XmlElement KutuSayisi = doc.CreateElement("KutuSayisi");
                KutuSayisi.InnerText = "11";
                Oyunbilgileri.AppendChild(KutuSayisi);



                doc.Save(txtKullaniciAdiYeni.Text+".xml");
                
                XMLOkuma.XmlOku(txtKullaniciAdiYeni);
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();

            }
            else
            {
         DialogResult sonuc= MessageBox.Show("Bu isimde kullanıcı mevcuttur. Yeni bir isim deneyiniz.","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
         if (sonuc == DialogResult.Yes)
             this.Show();
         else
             this.Close();
            }
        }
    }
}
