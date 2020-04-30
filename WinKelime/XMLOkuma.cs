using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace WinKelime
{
   public static class XMLOkuma
    {
        public static string dosyaismi;
        public static XmlDocument xml = new XmlDocument();
        public static XmlNode Oyunbilgileri;
        public static XmlElement Sayacxml, Skorxml, KutuHarflerixml, listboxxml, AltKutuHarflerixml, KutuSayisi;

       public static void XmlOku(MaskedTextBox txtKullaniciAdi)
       {
           dosyaismi = txtKullaniciAdi.Text + ".xml";
           xml.Load(dosyaismi);
           Oyunbilgileri = (XmlElement)xml.SelectSingleNode("Oyunbilgileri");
           xml.Load(dosyaismi);
           Oyunbilgileri = (XmlElement)xml.SelectSingleNode("Oyunbilgileri");
           Sayacxml = (XmlElement)Oyunbilgileri.SelectSingleNode("sayac");
           Skorxml = (XmlElement)Oyunbilgileri.SelectSingleNode("Skor");
           KutuHarflerixml = (XmlElement)Oyunbilgileri.SelectSingleNode("KutuHarfleri");
           listboxxml = (XmlElement)Oyunbilgileri.SelectSingleNode("listbox");
           AltKutuHarflerixml = (XmlElement)Oyunbilgileri.SelectSingleNode("AltKutuHarfleri");
           KutuSayisi = (XmlElement)Oyunbilgileri.SelectSingleNode("KutuSayisi");

           Oyunbilgileri.AppendChild(Sayacxml);
           Oyunbilgileri.AppendChild(Skorxml);
           Oyunbilgileri.AppendChild(KutuHarflerixml);
           Oyunbilgileri.AppendChild(listboxxml);
           Oyunbilgileri.AppendChild(AltKutuHarflerixml);
           Oyunbilgileri.AppendChild(KutuSayisi);
       }
    }
}
